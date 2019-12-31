Public Class War

    Private _noun1 As String
    Private _noun2 As String
    Private _noun3 As String
    Private _occupation As String
    Private _place As String
    Private _verb As String
    Private _verb_ed As String
    Private _noun4 As String
    Private _verb_ing As String
    Private _noun_plural As String
    Private _noun5 As String
    Private _emotion As String

    Public Sub New(noun1 As String, noun2 As String, noun3 As String, occupation As String, place As String, verb As String, verb_ed As String, noun4 As String, verb_ing As String, noun_plural As String, noun5 As String, emotion As String)
        _noun1 = noun1
        _noun2 = noun2
        _noun3 = noun3
        _occupation = occupation
        _place = place
        _verb = verb
        _verb_ed = verb_ed
        _noun4 = noun4
        _verb_ing = verb_ing
        _noun_plural = noun_plural
        _noun5 = noun5
        _emotion = emotion
    End Sub

    Public Overrides Function ToString() As String
        Return "It was during the battle of " & _noun1 & " when I was running through " &
                vbNewLine & "an " & _noun2 & " when a " & _noun3 & " went off right next to my platoon." & vbNewLine _
                 & "Our " & _occupation & " yelled For us to " & _verb & " to the nearest " & _place & " we " &
                 vbNewLine & "could find. When we got to the " & _place & " we " & _verb_ed & " to start a fire." & vbNewLine _
                 & "As we were starting the fire the enemy saw the " & _noun4 & " from " &
                 " the fire And started " & _verb_ing & _noun_plural & " at us. " &
                 vbNewLine & "We all quickly ducked behind the " & _noun5 & " at the " & _place & " and returned fire." & vbNewLine _
                 & "We quickly eliminated the enemy and were " & _emotion & " that we had won the battle."
    End Function


    ''' <summary>
    ''' GETTERS AND SETTERS
    ''' </summary>
    ''' <returns></returns>
    Public Property Noun1 As String
        Get
            Return _noun1
        End Get
        Set(value As String)
            _noun1 = value
        End Set
    End Property

    Public Property Noun2 As String
        Get
            Return _noun2
        End Get
        Set(value As String)
            _noun2 = value
        End Set
    End Property

    Public Property Noun3 As String
        Get
            Return _noun3
        End Get
        Set(value As String)
            _noun3 = value
        End Set
    End Property

    Public Property Occupation As String
        Get
            Return _occupation
        End Get
        Set(value As String)
            _occupation = value
        End Set
    End Property

    Public Property Place As String
        Get
            Return _place
        End Get
        Set(value As String)
            _place = value
        End Set
    End Property

    Public Property Verb As String
        Get
            Return _verb
        End Get
        Set(value As String)
            _verb = value
        End Set
    End Property

    Public Property Verb_ed As String
        Get
            Return _verb_ed
        End Get
        Set(value As String)
            _verb_ed = value
        End Set
    End Property

    Public Property Noun4 As String
        Get
            Return _noun4
        End Get
        Set(value As String)
            _noun4 = value
        End Set
    End Property

    Public Property Verb_ing As String
        Get
            Return _verb_ing
        End Get
        Set(value As String)
            _verb_ing = value
        End Set
    End Property

    Public Property Noun_plural As String
        Get
            Return _noun_plural
        End Get
        Set(value As String)
            _noun_plural = value
        End Set
    End Property

    Public Property Noun5 As String
        Get
            Return _noun5
        End Get
        Set(value As String)
            _noun5 = value
        End Set
    End Property

    Public Property Emotion As String
        Get
            Return _emotion
        End Get
        Set(value As String)
            _emotion = value
        End Set
    End Property
End Class
