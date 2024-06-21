Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions
Public Class ViewSubForm
    Dim reqIdx As Integer = 0
    Dim currntSubObj As Submission
    Private Sub GetAndDisplaySubmission(uriStr As String)
        Try
            Dim resp = Form1.httpClientObj.GetAsync(uriStr)
            resp.Wait(3000)
            If resp.Result.StatusCode = 200 Then
                Console.WriteLine(String.Format("Successfully received the {0}th submission", reqIdx + 1))

                ' get the response content
                Dim respContent = resp.Result.Content
                Dim respJsonString = respContent.ReadAsStringAsync.Result
                Dim respJsonObj = JsonConvert.DeserializeObject(respJsonString)

                ' display the data in the specific labels
                Dim respName As String = respJsonObj.Property("NameProp").Value
                Dim respEmail As String = respJsonObj.Property("EmailProp").Value
                Dim respPhoneNum As String = respJsonObj.Property("PhoneNumProp").Value
                Dim respGHubLink As String = respJsonObj.Property("GithubLinkProp").Value
                Dim respSWSec As Integer = respJsonObj.Property("StopwatchSecProp").Value
                Dim respSWMin As Integer = respJsonObj.Property("StopwatchMinProp").Value
                Dim respSWHrs As Integer = respJsonObj.Property("StopwatchHrsProp").Value
                nameTxtBox.Text = respName
                emailTxtBox.Text = respEmail
                phoneNumTxtBox.Text = respPhoneNum
                gHubLinkTxtBox.Text = respGHubLink
                SWatchLabel.Text = String.Format("{0}:{1}:{2}", respSWHrs.ToString("D2"), respSWMin.ToString("D2"), respSWSec.ToString("D2"))

                ' Keep the data received in the submissions object
                currntSubObj = New Submission(respName, respEmail, respPhoneNum, respGHubLink, respSWSec, respSWMin, respSWHrs)
            End If
            If resp.Result.StatusCode = 500 Then
                MsgBox("Could not get the record due to internal error, try later.")
                Me.Close()
            ElseIf resp.Result.StatusCode = 404 Then
                MsgBox("No records currently exist, try later.")
                Me.Close()
            ElseIf resp.Result.StatusCode = 400 Then
                MsgBox("Unable to get the data due to bad request, try later.")
                Console.WriteLine(resp.Result.ReasonPhrase)
                Me.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Could not get submissions sucessfully, try later")
        End Try
    End Sub

    Private Sub ViewSubForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        ' make the get request for the first record
        Dim uriStr As String = "http://localhost:3000/read?index=0"
        GetAndDisplaySubmission(uriStr)
    End Sub

    Private Sub PrevBtn_Click(sender As Object, e As EventArgs) Handles PrevBtn.Click
        If reqIdx = 0 Then
            MsgBox("No previous submissions.")
        Else
            reqIdx -= 1 ' decrecement the reqIdx
            ' call the /read endpoint with the new index
            Dim uriStr As String = String.Concat("http://localhost:3000/read?index=", Str(reqIdx))
            GetAndDisplaySubmission(uriStr)
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Dim totalNumCurrentSubCnt As Integer
        Try
            Dim uriForReadMeatadata As String = "http://localhost:3000/readMetadata"
            Dim resp = Form1.httpClientObj.GetAsync(uriForReadMeatadata)
            resp.Wait(3000)
            If resp.Result.StatusCode = 200 Then
                Console.WriteLine(String.Format("Successfully received the metadata"))
                ' get the response content
                Dim respContent = resp.Result.Content
                Dim respJsonString = respContent.ReadAsStringAsync.Result
                Dim respJsonObj = JsonConvert.DeserializeObject(respJsonString)
                totalNumCurrentSubCnt = respJsonObj.Property("submission_cnt").Value - respJsonObj.Property("deleted_cnt").Value
            End If
            If resp.Result.StatusCode = 500 Then
                MsgBox("Could not get the metadata due to internal error, try later.")
                Me.Close()
            ElseIf resp.Result.StatusCode = 404 Then
                Console.WriteLine("No metadata currently exist, try later.")
                MsgBox("No records are currently present, try later.")
                Me.Close()
            ElseIf resp.Result.StatusCode = 400 Then
                MsgBox("Unable to get the data due to bad request, try later.")
                Console.WriteLine(resp.Result.ReasonPhrase)
                Me.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Could not get submissions sucessfully, try later")
        End Try
        If totalNumCurrentSubCnt <> 0 Then
            If totalNumCurrentSubCnt = reqIdx + 1 Then
                MsgBox("No more submissions.")
            Else
                reqIdx += 1 ' increment the reqIdx
                ' call the /read endpoint with the new index
                Dim uriStr As String = String.Concat("http://localhost:3000/read?index=", Str(reqIdx))
                GetAndDisplaySubmission(uriStr)
            End If
        End If
    End Sub

    Private Sub ViewSubForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            PrevBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            NextBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            DeleteBtn.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.E Then
            EditBtn.PerformClick()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim surePromptResp As DialogResult = MsgBox("Are You Sure ?", MsgBoxStyle.YesNo)
        If surePromptResp = DialogResult.Yes Then
            Try
                Dim uriStr As String = String.Concat("http://localhost:3000/submission?index=", Str(reqIdx))
                Dim resp = Form1.httpClientObj.DeleteAsync(uriStr)
                resp.Wait(3000)
                If resp.Result.StatusCode = 200 Then
                    Console.WriteLine(String.Format("Successfully deleted the {0}th submission", reqIdx))
                    Dim msgBoxRes As DialogResult = MsgBox("Successfully deleted the submission")
                    If msgBoxRes = DialogResult.OK Then
                        Me.Close()
                        Form1.ViewSubmissionsBtn.PerformClick()
                    End If
                End If
                If resp.Result.StatusCode = 500 Then
                    MsgBox("Could not delete the record due to internal error, try later.")
                ElseIf resp.Result.StatusCode = 404 Then
                    MsgBox("Wrong index passed for deletion, try later.")
                ElseIf resp.Result.StatusCode = 400 Then
                    MsgBox("Unable to delete the submission due to bad request, try later.")
                    Console.WriteLine(resp.Result.ReasonPhrase)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox("Could not delete the submission sucessfully, try later")
            End Try
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        ' Get the input data
        Dim name As String = nameTxtBox.Text
        Dim email As String = emailTxtBox.Text
        Dim phoneNum As String = phoneNumTxtBox.Text
        Dim githubLink As String = gHubLinkTxtBox.Text

        ' Check if it has changed
        Dim dataChangedFlag As Boolean = False
        If String.Equals(name, currntSubObj.NameProp) = False Then
            dataChangedFlag = True
            currntSubObj.NameProp = name
        ElseIf String.Equals(email, currntSubObj.EmailProp) = False Then
            dataChangedFlag = True
            currntSubObj.EmailProp = email
        ElseIf String.Equals(phoneNum, currntSubObj.PhoneNumProp) = False Then
            dataChangedFlag = True
            currntSubObj.PhoneNumProp = phoneNum
        ElseIf String.Equals(githubLink, currntSubObj.GithubLinkProp) = False Then
            dataChangedFlag = True
            currntSubObj.GithubLinkProp = githubLink
        End If

        If dataChangedFlag = True Then
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
                ' Prepare the put request
                Dim subObjJson As String = JsonConvert.SerializeObject(currntSubObj)
                Dim strContent As New StringContent(subObjJson)
                strContent.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/json")

                ' Performing the put request 
                Dim uriStr As String = String.Concat("http://localhost:3000/submission?index=", Str(reqIdx))
                Try
                    Dim resp = Form1.httpClientObj.PutAsync(uriStr, strContent)
                    resp.Wait(5000)
                    If resp.Result.StatusCode = 200 Then
                        MsgBox("Edit was successful")
                    End If
                    If resp.Result.StatusCode = 500 Then
                        MsgBox("Edit not successful, try later")
                    End If
                    If resp.Result.StatusCode = 404 Then
                        Console.WriteLine("Requested resource is not present, edit not possible.")
                        MsgBox("Edit not successful, try later")
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    MsgBox("Edit not sucessful, try later")
                End Try
            End If
        Else
            MsgBox("No change made, Edit not required.")
        End If
    End Sub
End Class