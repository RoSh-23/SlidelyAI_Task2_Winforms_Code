Imports System.Net.Http
Public Class Form1

    Public Shared ReadOnly httpClientObj As HttpClient = New HttpClient()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewSubmissionsBtn.Click
        ViewSubForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CreateNewSubmissionBtn.Click
        CreateSubForm.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubForm.Show()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            CreateSubForm.Show()
        End If
    End Sub
End Class
