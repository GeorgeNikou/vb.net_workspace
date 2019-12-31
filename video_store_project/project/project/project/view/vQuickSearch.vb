Public Class vQuickSearch

    Private db As New DBManager
    Private Sub vQuickSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.quickSearch(vSearch.txt_id_qsearch.Text, vSearch.txt_title_qsearch.Text)
    End Sub

    Private Sub btn_quicksearch_cancel_Click(sender As Object, e As EventArgs) Handles btn_quicksearch_cancel.Click
        vSearch.txt_id_qsearch.Text = ""
        vSearch.txt_title_qsearch.Text = ""
        Me.Close()
        vSearch.Show()
    End Sub
End Class