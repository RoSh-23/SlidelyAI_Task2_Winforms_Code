Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class CreateSubForm

    Dim btnStarted As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ToggleSWBtn.Click
        ' logic for toggling the stopwatch button, using a flag called btnStarted
        If btnStarted = False Then
            btnStarted = True
            StopwatchTimer.Enabled = True
        ElseIf btnStarted = True Then
            btnStarted = False
            StopwatchTimer.Enabled = False
        End If
    End Sub

    Private Sub CreateSubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        StopwatchTimer.Enabled = True
    End Sub

    Dim hrs, min, sec As Integer ' represents the stopwatch values
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        ' Get the input data
        Dim name As String = nameTxtBox.Text
        Dim email As String = emailTxtBox.Text
        Dim phoneNum As String = phoneNumTxtBox.Text
        Dim githubLink As String = gHubLinkTxtBox.Text

        ' Check for empty data
        Dim emptyFlag As Boolean = False
        If name = "" Then
            MsgBox("Enter name")
            emptyFlag = True
        End If
        If email = "" Then
            MsgBox("Enter email")
            emptyFlag = True
        End If
        If phoneNum = "" Then
            MsgBox("Enter phone number")
            emptyFlag = True
        End If
        If githubLink = "" Then
            MsgBox("Enter github link")
            emptyFlag = True
        End If

        Dim validFlag As Boolean = True
        ' Validate input data
        If emptyFlag = False Then
            If Len(name) > 60 Then
                MsgBox("Enter a valid name. Name cannot be longer than 60 characters")
                validFlag = False
            End If
            If Regex.IsMatch(email, "^[A-Z0-9._%+-]{1,64}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$", RegexOptions.IgnoreCase) = False Then
                MsgBox("Enter a valid email address.")
                validFlag = False
            End If
            If Regex.IsMatch(phoneNum, "^[6-9]\d{9}$") = False Then
                MsgBox("Enter a valid Indian mobile number.(10 digits long, starts from 6,7,8 or 9)")
                validFlag = False
            End If
            If Regex.IsMatch(githubLink, "^(https:\/\/github\.com\/){1}", RegexOptions.IgnoreCase) = False Then
                MsgBox("Enter a valid github link, should start with https://github.com/ (case insensitive)")
                validFlag = False
            End If
        End If

        If emptyFlag = False AndAlso validFlag = True Then
            ' Prepare the post request
            Dim subObj As New Submission(name, email, phoneNum, githubLink, sec, min, hrs)
            Dim subObjJson As String = JsonConvert.SerializeObject(subObj)
            Dim strContent As New StringContent(subObjJson)
            strContent.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/json")

            ' Performing the post request 
            Dim uri As String = "http://localhost:3000/submit"
            Try
                Dim resp = Form1.httpClientObj.PostAsync(uri, strContent)
                resp.Wait(5000)
                If resp.Result.StatusCode = 200 Then
                    MsgBox("Submission was successful")
                    Me.Close()
                End If
                If resp.Result.StatusCode = 500 Then
                    MsgBox("Submission not successful, try later")
                    Me.Close()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox("Submission not sucessful, try later")
            End Try
        End If
    End Sub

    Private Sub StopwatchTimer_Tick(sender As Object, e As EventArgs) Handles StopwatchTimer.Tick
        ' logic for updating the values of the stopwatch
        StopwatchLabel.Text = Format(hrs, "00:") & Format(min, "00:") & Format(sec, "00")
        sec += 1
        If sec > 59 Then
            sec = 0
            min += 1
        End If
        If min > 59 Then
            min = 0
            hrs += 1
        End If
    End Sub
    Private Sub CreateSubForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleSWBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            SubmitBtn.PerformClick()
        End If
    End Sub

End Class