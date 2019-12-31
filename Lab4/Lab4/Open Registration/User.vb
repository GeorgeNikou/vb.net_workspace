Public Class User

    Private _firstname As String
    Private _lastname As String
    Private _dob As Date
    Private _address As String
    Private _phone As Integer = 2666884
    Private _school As String
    Private _program As String
    Private _password As String
    Private _avatar As String

    Public Sub New(firstname As String, password As String, avatar As String)
        _firstname = firstname
        _password = password
        _avatar = avatar
    End Sub

    Public Sub New(firstname As String, lastname As String, dob As Date, address As String, phone As Integer, school As String, program As String, password As String, avatar As String)
        _firstname = firstname
        _lastname = lastname
        _dob = dob
        _address = address
        _phone = phone
        _school = school
        _program = program
        _password = password
        _avatar = avatar
    End Sub

    Public Overrides Function ToString() As String
        Return "Firstname: " & _firstname & vbNewLine _
                & "Lastname: " & _lastname & vbNewLine _
                & "DOB: " & _dob & vbNewLine _
                & "Address: " & _address & vbNewLine _
                & "Phone: " & _phone & vbNewLine _
                & "School: " & _school & vbNewLine _
                & "Program: " & _program & vbNewLine _
                & "Password: " & _password & vbNewLine _
                & "Avatar: " & _avatar & vbNewLine
    End Function

    Public Property Firstname As String
        Get
            Return _firstname
        End Get
        Set(value As String)
            _firstname = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(value As String)
            _lastname = value
        End Set
    End Property

    Public Property Dob As Date
        Get
            Return _dob
        End Get
        Set(value As Date)
            _dob = value
        End Set
    End Property


    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Property Phone As Integer
        Get
            Return _phone
        End Get
        Set(value As Integer)
            _phone = value
        End Set
    End Property

    Public Property School As String
        Get
            Return _school
        End Get
        Set(value As String)
            _school = value
        End Set
    End Property

    Public Property Program As String
        Get
            Return _program
        End Get
        Set(value As String)
            _program = value
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

    Public Property Avatar As String
        Get
            Return _avatar
        End Get
        Set(value As String)
            _avatar = value
        End Set
    End Property


End Class
