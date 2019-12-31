Public Class new_user

    Private Sub btn_new_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_cancel.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_new_submit_Click(sender As Object, e As EventArgs) Handles btn_new_submit.Click
        If txt_new_username.Text.Length < 5 OrElse txt_new_username.Text.Length >= 12 Then
            lbl_new_result.Text = "Invalid Username. Please try again."
            lbl_new_result.ForeColor = Color.Red
        ElseIf txt_new_password.Text.Length < 5 OrElse txt_new_password.Text.Length > 12 Then
            lbl_new_result.Text = "Invalid Password. Please try again."
            lbl_new_result.ForeColor = Color.Red
        Else
            Form1.array_users.Add(New User(txt_new_username.Text, txt_new_password.Text, 1))
            Dim tmp = MsgBox("User has been successfully created! Welcome " & txt_new_username.Text & ". Would you like to login now?", MsgBoxStyle.YesNo)
            txt_new_username.Text = ""
            txt_new_password.Text = ""
            lbl_new_result.Text = ""

            If tmp = 6 Then
                Me.Close()
                Form1.Show()
            Else
                'nothing
            End If
        End If
    End Sub
End Class