
Public Class vSearch

    Private tmp_valid As Integer

    Private Sub btn_search_qsearch_Click(sender As Object, e As EventArgs) Handles btn_search_qsearch.Click
        lbl_id_quicksearch.Text = ""
        lbl_title_quicksearch.Text = ""
        tmp_valid = 0

        If txt_id_qsearch.Text = "" Then
            lbl_id_quicksearch.Text = "Video ID field is empty"
            tmp_valid += 1
        End If

        If txt_title_qsearch.Text = "" Then
            lbl_title_quicksearch.Text = "Video title field is empty"
            tmp_valid += 1
        End If

        If IsNumeric(txt_id_qsearch.Text) = False Then
            lbl_id_quicksearch.Text = "Video ID must be numeric or is empty"
            tmp_valid += 1
        End If

        If tmp_valid = 0 Then
            Me.Hide()
            vQuickSearch.Show()
        End If

    End Sub
End Class