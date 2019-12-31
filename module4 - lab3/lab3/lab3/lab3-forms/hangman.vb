Public Class form_hangman

    Private rand As New Random
    Private tmp_arr As New ArrayList
    Private word = "GEORGE"
    Private lbl = ""
    Private done As Boolean = False
    Private guessed As New ArrayList()
    Private tries2 As Integer


    Private Sub form_hangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmp_arr.Add("abandonment".ToUpper)
        tmp_arr.Add("firebombs".ToUpper)
        tmp_arr.Add("hookers".ToUpper)
        tmp_arr.Add("junctions".ToUpper)
        tmp_arr.Add("mindlessness".ToUpper)
        tmp_arr.Add("ordaining".ToUpper)
        tmp_arr.Add("quadripartite".ToUpper)
        tmp_arr.Add("regimentation".ToUpper)
        tmp_arr.Add("scooping".ToUpper)
        tmp_arr.Add("spicery".ToUpper)
        tmp_arr.Add("subsidised".ToUpper)
        tmp_arr.Add("vacuously".ToUpper)
        word = tmp_arr(rand.Next(tmp_arr.Count)).ToString.ToUpper
        pb_hangman.Image = il_hangman.Images(4)
        tries2 = 5
        ts_hangman.Items.Add("Welcome to this broken game of hangman, " & form_login.username)
    End Sub

    Private Sub btn_hangman_enter_Click(sender As Object, e As EventArgs) Handles btn_hangman_enter.Click

        For Each c As Char In word
            lbl_hangman.Text &= "_"
        Next

        Dim guess = txt_hangman_input.Text
        lbl_hangman.Text = ""

        For Each c As Char In word
            If c = guess.ToUpper() Then
                lbl_hangman.Text &= guess.ToUpper()
                guessed.Add(c)
                done = False
            ElseIf guessed.IndexOf(c) >= 0 Then
                lbl_hangman.Text &= c.ToString().ToUpper()
                done = False
            Else
                lbl_hangman.Text &= " _ "
                done = True
            End If
        Next

        Try
            lb_hangman.Items.Add(txt_hangman_input.Text.Substring(0, 1))
        Catch ex As Exception
        End Try

        If tries2 = 5 AndAlso done Then
            tries2 -= 1
            pb_hangman.Image = il_hangman.Images(5)

        ElseIf tries2 = 4 AndAlso done Then
            tries2 -= 1
            pb_hangman.Image = il_hangman.Images(0)

        ElseIf tries2 = 3 AndAlso done Then
            tries2 -= 1
            pb_hangman.Image = il_hangman.Images(2)

        ElseIf tries2 = 2 AndAlso done Then
            tries2 -= 1
            pb_hangman.Image = il_hangman.Images(1)

        ElseIf tries2 = 1 AndAlso done Then
            tries2 -= 1
            pb_hangman.Image = il_hangman.Images(8)

        ElseIf tries2 = 0 AndAlso done Then
            pb_hangman.Image = il_hangman.Images(6)
            MsgBox("You lose")
            pb_hangman.Image = il_hangman.Images(4)
            lb_hangman.Items.Clear()
            txt_hangman_input.Text = ""
            lbl_hangman.Text = ""
            guessed.Clear()
            tries2 = 5
        ElseIf lbl_hangman.Text = word Then
            MsgBox("you win")
            pb_hangman.Image = il_hangman.Images(4)
            lb_hangman.Items.Clear()
            txt_hangman_input.Text = ""
            lbl_hangman.Text = ""
            guessed.Clear()
            tries2 = 5
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("The player guessing the word may, at any time, attempt to guess the whole word. If the word is correct, the game is over and the guesser wins. Otherwise, the other player may choose to penalize the guesser by adding an element to the diagram. On the other hand, if the other player makes enough incorrect guesses to allow his opponent to complete the diagram, the game is also over, this time with the guesser losing. However, the guesser can also win by guessing all the letters or numbers that appears in the word, thereby completing the word, before the diagram is completed.")
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
        form_menu.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        form_login.Show()
    End Sub


End Class