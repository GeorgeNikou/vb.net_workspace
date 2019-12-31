Public Class Function_randomizer

    Private rand As New Random

    ''' <summary>
    ''' regular noun
    ''' </summary>
    ''' <returns></returns>
    Public Function rand_noun(ByVal array As ArrayList)
        Return array(rand.Next(0, 27))
    End Function

End Class
