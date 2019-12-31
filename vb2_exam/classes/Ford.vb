Public Class Ford : Inherits Car

    'properties
    Private _year As Integer
    Private _manufactureDiscount As Integer

    'constructor
    Public Sub New(speed As Integer, regularPriced As Double, color As String, year As Integer, manufactureDiscount As Integer)
        MyBase.New(speed, regularPriced, color)
        _year = year
        _manufactureDiscount = manufactureDiscount
    End Sub

    'toString method 
    Public Overrides Function ToString() As String
        Return MyBase.ToString() &
            "Year: " & _year & vbNewLine &
            "Manufacture Discount: " & _manufactureDiscount & vbNewLine
    End Function

    'overloaded ford method (getSalePrice)
    Public Overloads Function getSalePrice()
        Return _regularPriced - _manufactureDiscount
    End Function

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Public Property ManufactureDiscount As Integer
        Get
            Return _manufactureDiscount
        End Get
        Set(value As Integer)
            _manufactureDiscount = value
        End Set
    End Property




End Class
