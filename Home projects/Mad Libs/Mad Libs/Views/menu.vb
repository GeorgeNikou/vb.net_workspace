Public Class main_menu

    Public lib_name As String

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb_war.Image = Form1.img_list1.Images(0)
    End Sub

    Private Sub pb_war_Click(sender As Object, e As EventArgs) Handles pb_war.Click
        lib_name = "war"
        Me.Close()
        lib_war_view.Show()
    End Sub

    Private Sub ms_menu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ms_menu.ItemClicked
    End Sub

    Private Sub cb_menu_saved_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_menu_saved.SelectedIndexChanged

    End Sub
End Class