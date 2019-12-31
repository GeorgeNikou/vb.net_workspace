Public Class form_menu

    Private Sub form_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_menu_exit_Click(sender As Object, e As EventArgs) Handles btn_menu_exit.Click
        Close()
        form_login.Show()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Close()
        form_login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        form_login.Close()
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        MsgBox("Verison 1.34.7", MsgBoxStyle.Information)
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorToolStripMenuItem.Click
        MsgBox("George Nikou", MsgBoxStyle.Information)
    End Sub

    Private Sub btn_menu_scrabble_Click(sender As Object, e As EventArgs) Handles btn_menu_scrabble.Click
        Me.Close()
        form_scrabble.Show()
    End Sub

    Private Sub btn_menu_hangman_Click(sender As Object, e As EventArgs) Handles btn_menu_hangman.Click
        Me.Close()
        form_hangman.Show()
    End Sub
End Class