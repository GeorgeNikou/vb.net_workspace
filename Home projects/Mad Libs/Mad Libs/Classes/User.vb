Public Class User

    Private _username As String
    Private _password As String
    Private _status As Integer = 0

    Public Sub New(username As String, password As String, status As Integer)
        Me._username = username
        Me._password = password
        Me._status = status
    End Sub


    Public Overrides Function ToString() As String
        Return _
        _username = Username
        _password = Password
        _status = Status
    End Function


    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property
End Class
