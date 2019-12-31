Public Class clientBean

    'properties
    Private _clientID As String
    Private _fname As String
    Private _lname As String
    Private _email As String
    Private _phone As String
    Private _dob As Date
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postal As String
    Private _status As Integer

    Public Sub New()
    End Sub

    Public Sub New(clientID As String)
        _clientID = clientID
    End Sub

    'constructor
    Public Sub New(clientID As String, fname As String, lname As String, email As String, phone As String, dob As Date, address As String, city As String, province As String, postal As String, status As Integer)
        _clientID = clientID
        _fname = fname
        _lname = lname
        _email = email
        _phone = phone
        _dob = dob
        _address = address
        _city = city
        _province = province
        _postal = postal
        _status = status
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
               "Address: " & _address & vbNewLine &
               "City: " & _city & vbNewLine &
               "Province: " & _province & vbNewLine &
               "Postal: " & _postal & vbNewLine &
               "Status: " & _status
    End Function

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Id As String
        Get
            Return _clientID
        End Get
        Set(value As String)
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

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
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

    Public Property City As String
        Get
            Return _city
        End Get
        Set(value As String)
            _city = value
        End Set
    End Property

    Public Property Province As String
        Get
            Return _province
        End Get
        Set(value As String)
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

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

End Class
