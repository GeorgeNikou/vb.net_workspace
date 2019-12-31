Public Class Truck : Inherits Car

    'properties
    Private _weight As Integer

    'constructor
    Public Sub New(speed As Integer, regularPriced As Double, color As String, weight As Integer)
        MyBase.New(speed, regularPriced, color)
        _weight = weight
    End Sub

    'toString method 
    Public Overrides Function ToString() As String
        Return MyBase.ToString() &
            "Weight: " & _weight & vbNewLine
    End Function

    'overloaded car method (getSalePrice)
    Public Overloads Sub getSalePrice()
        If _weight > 2000 Then
            Dim num1 = _weight * 0.1
            _weight += num1
        Else
            Dim num2 = _weight * 0.2
            _weight += num2
        End If
    End Sub


    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Weight As Integer
        Get
            Return _weight
        End Get
        Set(value As Integer)
            _weight = value
        End Set
    End Property

End Class
