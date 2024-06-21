Public Class Submission
    Private name As String
    Private email As String
    Private phoneNum As String
    Private githubLink As String
    Private stopwatchSec As Integer
    Private stopwatchMin As Integer
    Private stopwatchHrs As Integer

    Public Property NameProp() As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property EmailProp() As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property PhoneNumProp() As String
        Get
            Return phoneNum
        End Get
        Set(value As String)
            phoneNum = value
        End Set
    End Property

    Public Property GithubLinkProp() As String
        Get
            Return githubLink
        End Get
        Set(value As String)
            githubLink = value
        End Set
    End Property

    Public Property StopwatchSecProp() As String
        Get
            Return stopwatchSec
        End Get
        Set(value As String)
            stopwatchSec = value
        End Set
    End Property

    Public Property StopwatchMinProp() As String
        Get
            Return stopwatchMin
        End Get
        Set(value As String)
            stopwatchMin = value
        End Set
    End Property

    Public Property StopwatchHrsProp() As String
        Get
            Return stopwatchHrs
        End Get
        Set(value As String)
            stopwatchHrs = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal email As String, ByVal phoneNum As String, ByVal githubLink As String, ByVal stopwatchSec As Integer, ByVal stopwatchMin As Integer, ByVal stopwatchHrs As Integer)
        Me.name = name
        Me.email = email
        Me.phoneNum = phoneNum
        Me.githubLink = githubLink
        Me.stopwatchSec = stopwatchSec
        Me.stopwatchMin = stopwatchMin
        Me.stopwatchHrs = stopwatchHrs
    End Sub
End Class
