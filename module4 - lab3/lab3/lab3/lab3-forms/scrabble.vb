Public Class form_scrabble


    Private rand As New Random
    Private actual As String
    Private word As String
    Private arr_words As New ArrayList
    Private tmp As String
    Private tries As Integer = 7


    Private Sub form_scrabble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ts_scrabble.Items.Add("Welcome " & form_login.username)
        tmp = My.Resources.words.ToString
        'Dim names As String = My.Resources.names.ToString

        arr_words.Add("abandonment")
        arr_words.Add("firebombs")
        arr_words.Add("hookers")
        arr_words.Add("junctions")
        arr_words.Add("mindlessness")
        arr_words.Add("ordaining")
        arr_words.Add("quadripartite")
        arr_words.Add("regimentation")
        arr_words.Add("scooping")
        arr_words.Add("spicery")
        arr_words.Add("subsidised")
        arr_words.Add("vacuously")
        lbl_scrabble_tries.Text = "Tries left: " & tries
        word = arr_words(rand.Next(arr_words.Count))
        Dim shuffledInput As String = word.OrderBy(Function() rand.Next).ToArray
        lbl_scrabble_word.Text = shuffledInput


    End Sub

    Private Sub btn_scrabble_enter_Click(sender As Object, e As EventArgs) Handles btn_scrabble_enter.Click

        If txt_scrabble_input.Text = word Then
            MsgBox("You win! Genius, now go away.")
            txt_scrabble_input.Text = ""
            lb_scrabble.Items.Clear()
            word = arr_words(rand.Next(arr_words.Count))
            Dim shuffledInput As String = word.OrderBy(Function() rand.Next).ToArray
            lbl_scrabble_word.Text = shuffledInput
            tries = 7
            lbl_scrabble_tries.Text = "Tries left: " & tries
        ElseIf tries = 1 Then
            MsgBox("Game over you loser.")
            txt_scrabble_input.Text = ""
            lb_scrabble.Items.Clear()
            word = arr_words(rand.Next(arr_words.Count))
            Dim shuffledInput As String = word.OrderBy(Function() rand.Next).ToArray
            lbl_scrabble_word.Text = shuffledInput
            tries = 7
            lbl_scrabble_tries.Text = "Tries left: " & tries
        Else
            tries -= 1
            lbl_scrabble_tries.Text = "Tries left: " & tries
            lb_scrabble.Items.Add(txt_scrabble_input.Text)
            txt_scrabble_input.Text = ""
        End If


    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
        form_menu.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        form_login.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("You should have a game board, 100 letter tiles, a letter bag, and four racks. Before the game begins, all players should agree upon the dictionary that they will use, in case of a challenge. All words labeled as a part of speech (including those listed of foreign origin, and as archaic, obsolete, colloquial, slang, etc.) are permitted with the exception of the following: words always capitalized, abbreviations, prefixes and suffixes standing alone, words requiring a hyphen or an apostrophe.Place all letters in the pouch, or facedown beside the board, and mix them up. Draw for first play. The player with the letter closest to 'A' plays first. A blank tile beats any letter. Return the letters to the pool and remix. All players draw seven new letters and place them on their racks.")
    End Sub

End Class