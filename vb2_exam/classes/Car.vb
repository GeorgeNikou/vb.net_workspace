Public MustInherit Class Car

    Protected _speed As Integer
    Protected _regularPriced As Double
    Protected _color As String

    Public Sub New(speed As Integer, regularPriced As Double, color As String)
        _speed = speed
        _regularPriced = regularPriced
        _color = color
    End Sub

    Public Overrides Function ToString() As String
        Return "Speed: " & _speed & vbNewLine &
               "Regular price: " & _regularPriced & vbNewLine &
               "Color: " & _color & vbNewLine
    End Function

    Public Function getSalePrice()
        Return _regularPriced
    End Function

    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Speed As Integer
        Get
            Return _speed
        End Get
        Set(value As Integer)
            _speed = value
        End Set
    End Property

    Public Property RegularPriced As Double
        Get
            Return _regularPriced
        End Get
        Set(value As Double)
            _regularPriced = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property
End Class
