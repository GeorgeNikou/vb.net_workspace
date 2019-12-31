Public Class Sedan : Inherits Car

    'properties
    Private _length As Integer

    'constructor
    Public Sub New(speed As Integer, regularPriced As Double, color As String, length As Integer)
        MyBase.New(speed, regularPriced, color)
        _length = length
    End Sub

    'toString method 
    Public Overrides Function ToString() As String
        Return MyBase.ToString() &
            "Length: " & _length & vbNewLine
    End Function

    'overloaded sedan method (getSalePrice)
    Public Overloads Sub getSalePrice()
        If Length > 20 Then
            'Dim num1 = length * 0.5
            'length = length + num1
            Dim num1 = _length * 0.5
            _length += num1
        Else
            Dim num2 = _length * 0.1
            _length += num2
        End If
    End Sub

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Length As Integer
        Get
            Return _length
        End Get
        Set(value As Integer)
            _length = value
        End Set
    End Property


End Class
