Public Class clientBean

    'properties
    Private _clientID As Long
    Private _fname As String
    Private _lname As String
    Private _email As String
    Private _phone As Integer
    Private _dob As Integer
    Private _age As Integer
    Private _address As String
    Private _city As String
    Private _province As Char
    Private _postal As String
    Private _rented As Integer
    Private _status As Boolean
    Private _level As Integer

    'constructor
    Public Sub New(fname As String, lname As String, email As String, phone As Integer, dob As Integer, age As Integer, address As String, city As String, province As Char, postal As String, status As Boolean, level As Integer)
        _fname = fname
        _lname = lname
        _email = email
        _phone = phone
        _dob = dob
        _age = age
        _address = address
        _city = city
        _province = province
        _postal = postal
        _status = status
        _level = level
    End Sub


    ''' <summary>
    ''' toString method (display info)
    ''' </summary>
    ''' <returns></returns>
    Public Overrides Function ToString() As String
        Return "ID: " & _clientID & vbNewLine &
               "First name: " & _fname & vbNewLine &
               "Last name: " & _lname & vbNewLine &
               "Email: " & _email & vbNewLine &
               "Phone: " & _phone & vbNewLine &
               "d.o.b: " & _dob & vbNewLine &
               "age: " & _age & vbNewLine &
               "Address: " & _address & vbNewLine &
               "City: " & _city & vbNewLine &
               "Province: " & _province & vbNewLine &
               "Postal: " & _postal
    End Function

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Id As Long
        Get
            Return _clientID
        End Get
        Set(value As Long)
            _clientID = value
        End Set
    End Property

    Public Property Fname As String
        Get
            Return _fname
        End Get
        Set(value As String)
            _fname = value
        End Set
    End Property

    Public Property Lname As String
        Get
            Return _lname
        End Get
        Set(value As String)
            _lname = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
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

    Public Property Dob As Integer
        Get
            Return _dob
        End Get
        Set(value As Integer)
            _dob = value
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            _age = value
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

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property Province As Char
        Get
            Return _province
        End Get
        Set(value As Char)
            _province = value
        End Set
    End Property

    Public Property Postal As String
        Get
            Return _postal
        End Get
        Set(value As String)
            _postal = value
        End Set
    End Property

    Public Property Rented As Integer
        Get
            Return _rented
        End Get
        Set(value As Integer)
            _rented = value
        End Set
    End Property

    Public Property Status As Boolean
        Get
            Return _status
        End Get
        Set(value As Boolean)
            _status = value
        End Set
    End Property

    Public Property Level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
        End Set
    End Property
End Class
