Public Class vDeleteClient

    Private db As New DBManager
    Private Sub btn_cancel_DClient_Click(sender As Object, e As EventArgs) Handles btn_cancel_DClient.Click

        Dim input = MsgBox("Are you sure you want to delete client ID number " & txt_shownum_DClient.Text & "?", MsgBoxStyle.YesNo, "Delete Client")

        If input = 6 Then
            db.deleteClient(vDashboard.client_num_del)
            MsgBox("Client ID number " & txt_shownum_DClient.Text & " has been successfully deleted.")

            Me.Close()
            vDashboard.Show()
        ElseIf input = 7 Then
            MsgBox("No changes were made", MsgBoxStyle.Information)
        End If


    End Sub
End Class