Public Class form_create

    Private Sub form_create_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_create_enter_Click(sender As Object, e As EventArgs) Handles btn_create_enter.Click

        If IsNumeric(txt_create_username.Text) = True OrElse IsNumeric(txt_create_password.Text) = True Then
            MsgBox("invalid entry.", MsgBoxStyle.Information)
        ElseIf txt_create_username.Text = "" OrElse txt_create_password.Text = "" Then
            MsgBox("one or more fields are empty.")
        Else

            form_login.users(form_login.tmp).username = txt_create_username.Text
            form_login.users(form_login.tmp).password = txt_create_password.Text
            form_login.tmp += 1

            txt_create_username.Text = ""
            txt_create_password.Text = ""

            Close()
            form_login.Show()
        End If

    End Sub

    Private Sub btn_create_cancel_Click(sender As Object, e As EventArgs) Handles btn_create_cancel.Click

        txt_create_username.Text = ""
        txt_create_password.Text = ""
        Close()
        form_login.Show()
    End Sub
End Class