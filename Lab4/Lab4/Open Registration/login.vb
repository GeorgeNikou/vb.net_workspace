Public Class login


    Private Sub btn_login_cancel_Click(sender As Object, e As EventArgs) Handles btn_login_cancel.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_login_submit_Click(sender As Object, e As EventArgs) Handles btn_login_submit.Click
        For i As Integer = 0 To Form1.user_list.Count - 1
            If txt_login_username.Text = Form1.user_list(i).Firstname Then
                If txt_login_password.Text = Form1.user_list(i).Password Then
                    Form1.index_pos = i
                    Form1.logged_avatar = Form1.user_list(i).Avatar
                    MsgBox(Form1.user_list(i).Firstname & " has logged in" & vbNewLine & "Index: " & Form1.index_pos)
                    Me.Close()
                    edit.Show()
                    Return
                End If
            End If
        Next
        MsgBox("Invalid entry. Please try again", MsgBoxStyle.Exclamation)
    End Sub
End Class