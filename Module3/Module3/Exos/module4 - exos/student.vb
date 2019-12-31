Public Class student

    Private name As String
    Private email As String
    Private phone As String
    Private address As String
    Private program As String
    Private school As String


    Public Sub New()
        Me.name = name
        Me.email = email
        Me.phone = phone
        Me.address = address
        Me.program = program
        Me.school = school
    End Sub

    Public Sub New(name As String, email As String, phone As String, address As String, program As String, school As String)
        Me.name = name
        Me.email = email
        Me.phone = phone
        Me.address = address
        Me.program = program
        Me.school = school
    End Sub


    Public Function display()
        Return "Name: " & Me.name & " " &
                "Email: " & Me.email & " " &
                 "phone: " & Me.phone & " " &
                 "address: " & Me.address & " " &
                 "program: " & Me.program & " " &
                 "school: " & Me.school & " "
    End Function


    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Property Name1 As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property Address1 As String
        Get
            Return address
        End Get
        Set(value As String)
            address = value
        End Set
    End Property

    Public Property Program1 As String
        Get
            Return program
        End Get
        Set(value As String)
            program = value
        End Set
    End Property

    Public Property School1 As String
        Get
            Return school
        End Get
        Set(value As String)
            school = value
        End Set
    End Property

    Public Property Phone1 As String
        Get
            Return phone
        End Get
        Set(value As String)
            phone = value
        End Set
    End Property
End Class
