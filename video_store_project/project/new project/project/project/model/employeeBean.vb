Public Class employeeBean

    'properties
    Private _ID As Long
    Private _fname As String
    Private _lname As String
    Private _dob As Date
    Private _age As Integer
    Private _address As String
    Private _city As String
    Private _province As String
    Private _postal As String
    Private _phone As String
    Private _EmpNumber As String
    Private _NAS As String
    Private _salary As Double
    Private _dateCreated As Date
    Private _education As String
    Private _username As String
    Private _password As String = "herzing"
    Private _level As Integer
    Private _status As Integer
    Private _cellphone As String

    Public Sub New()

    End Sub

    Public Sub New(username As String)
        _username = username
    End Sub

    'constructor
    Public Sub New(ID As Long, fname As String, lname As String, dob As Date, age As Integer, address As String, city As String, province As String, postal As String, phone As String, EmpNumber As String, NAS As String, salary As Double, dateCreated As Date, education As String, username As String, password As String, level As Integer, status As Integer)
        _ID = ID
        _fname = fname
        _lname = lname
        _dob = dob
        _age = age
        _address = address
        _city = city
        _province = province
        _postal = postal
        _phone = phone
        _EmpNumber = EmpNumber
        _NAS = NAS
        _salary = salary
        _dateCreated = dateCreated
        _education = education
        _username = username
        _password = password
        _level = level
        _status = status
    End Sub

    Public Sub New(empNumber As String, username As String, password As String, fname As String, lname As String, dob As Date, address As String, city As String, province As String, postal As String, phone As String, cellphone As String, dateCreated As Date, NAS As String, salary As Double, education As String, level As String, status As Integer)
        ' _ID = ID
        _EmpNumber = empNumber
        _username = username
        _password = password
        _fname = fname
        _lname = lname
        _dob = dob
        _address = address
        _city = city
        _province = province
        _postal = postal
        _phone = phone
        _cellphone = cellphone
        _dateCreated = dateCreated
        _NAS = NAS
        _salary = salary
        _education = education
        _level = level
        _status = status
    End Sub


    'toString method (Display information)
    Public Overrides Function ToString() As String
        Return "First name: " & _fname & vbNewLine &
               "Last name: " & _lname & vbNewLine &
               "Date of birth: " & _dob & vbNewLine &
               "Age: " & _age & vbNewLine &
               "Address: " & _address & vbNewLine &
               "City: " & _city & vbNewLine &
               "Province: " & _province & vbNewLine &
               "Postal: " & _postal & vbNewLine &
               "Phone: " & _phone & vbNewLine &
               "Employee number: " & _EmpNumber & vbNewLine &
               "NAS: " & _NAS & vbNewLine &
               "Salary: " & _salary & vbNewLine &
               "Date created: " & _dateCreated & vbNewLine &
               "Education: " & _education & vbNewLine &
               "Username: " & _username & vbNewLine &
               "Password: " & _password & vbNewLine &
               "Level: " & _level & vbNewLine &
               "Status: " & _status & vbNewLine
    End Function


    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property ID As Long
        Get
            Return _ID
        End Get
        Set(value As Long)
            _ID = value
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

    Public Property Dob As Date
        Get
            Return _dob
        End Get
        Set(value As Date)
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

    Public Property Phone As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property EmpNumber As String
        Get
            Return _EmpNumber
        End Get
        Set(value As String)
            _EmpNumber = value
        End Set
    End Property

    Public Property NAS As String
        Get
            Return _NAS
        End Get
        Set(value As String)
            _NAS = value
        End Set
    End Property

    Public Property Salary As Double
        Get
            Return _salary
        End Get
        Set(value As Double)
            _salary = value
        End Set
    End Property

    Public Property DateCreated As Date
        Get
            Return _dateCreated
        End Get
        Set(value As Date)
            _dateCreated = value
        End Set
    End Property

    Public Property Education As String
        Get
            Return _education
        End Get
        Set(value As String)
            _education = value
        End Set
    End Property

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

    Public Property Level As Integer
        Get
            Return _level
        End Get
        Set(value As Integer)
            _level = value
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

    Public Property Cellphone As String
        Get
            Return _cellphone
        End Get
        Set(value As String)
            _cellphone = value
        End Set
    End Property
End Class

