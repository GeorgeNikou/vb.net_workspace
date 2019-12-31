Public Class Form1

    'class arrays
    Public array_users As New List(Of User)
    Public array_war As New List(Of War)

    'position variables
    Public index_pos As Integer
    Public index_lib As Integer

    'word arrays
    Public array_noun As New ArrayList

    'Function classes
    Public func As New Function_randomizer

    'Public array_noun_plural As New ArrayList
    'Public array_verb As New ArrayList
    'Public array_verb_ed As New ArrayList
    'Public array_verb_ing As New ArrayList
    'Public array_adjective As New ArrayList
    'Public array_adverb As New ArrayList

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        add_noun() 'adds all words to arraylist
        func.rand_noun(array_noun) 'calls function to randomize noun
    End Sub

    Private Sub btn_login_new_Click(sender As Object, e As EventArgs) Handles btn_login_new.Click
        Me.Hide()
        new_user.Show()
    End Sub

    Private Sub btn_login_enter_Click(sender As Object, e As EventArgs) Handles btn_login_enter.Click
        'For i = 0 To array_users.Count - 1
        '    If txt_login_username.Text = array_users(i).Username AndAlso txt_login_password.Text = array_users(i).Password AndAlso array_users(i).Status = 1 Then
        '        index_pos = i
        '        Me.Hide()
        '        main_menu.Show()
        '        Return
        '    End If
        'Next
        'MsgBox("invalid entry")
        Me.Hide()
        main_menu.Show()
    End Sub

    ''' <summary>
    ''' adds NOUN to the arraylist
    ''' </summary>
    Public Sub add_noun()
        array_noun.Add("idiot")
        array_noun.Add("toaster")
        array_noun.Add("therapy")
        array_noun.Add("psychic")
        array_noun.Add("knife")
        array_noun.Add("sandwich")
        array_noun.Add("lettuce")
        array_noun.Add("kitty")
        array_noun.Add("tank")
        array_noun.Add("karate")
        array_noun.Add("pistol")
        array_noun.Add("dragon")
        array_noun.Add("mediation")
        array_noun.Add("patrolman")
        array_noun.Add("pervert")
        array_noun.Add("apple")
        array_noun.Add("fifth")
        array_noun.Add("arithmetic")
        array_noun.Add("finger")
        array_noun.Add("seashore")
        array_noun.Add("badge")
        array_noun.Add("flock")
        array_noun.Add("basket")
        array_noun.Add("frame")
        array_noun.Add("sleet")
        array_noun.Add("furniture")
        array_noun.Add("basketball")
        array_noun.Add("smoke")
    End Sub

End Class
