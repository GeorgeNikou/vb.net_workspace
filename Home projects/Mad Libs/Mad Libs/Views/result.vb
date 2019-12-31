Public Class result

    Public tmp_saved As String
    Public array_saved As New ArrayList


    Private Sub btn_result_exit_Click(sender As Object, e As EventArgs) Handles btn_result_exit.Click
        Me.Close()
        main_menu.Show()
    End Sub

    Private Sub result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_result_save_Click(sender As Object, e As EventArgs) Handles btn_result_save.Click
        tmp_saved = InputBox("Please select the named of this Mad lib", "Saving Mad Lib", "new saved")
        MsgBox(tmp_saved)
        main_menu.cb_menu_saved.Items.Add(tmp_saved)

        If main_menu.lib_name = "war" Then
            array_saved.Add(Form1.array_war(lib_war_view.array_len).ToString)
        End If

    End Sub
End Class