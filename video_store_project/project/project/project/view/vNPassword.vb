Public Class vNPassword

    Public db As New DBManager

    Private Sub vNPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username_vNPass.Enabled = False
        txt_username_vNPass.BackColor = Color.AntiqueWhite
        txt_username_vNPass.Text = vLogin.txt_username_login.Text
    End Sub

    Private Sub btn_save_NPass_Click(sender As Object, e As EventArgs) Handles btn_save_NPass.Click


        If txt_password_vNPass.Text = "" OrElse txt_Cpassword_vNPass.Text = "" Then
            MsgBox("Invalid entry. Text fields cannot be empty.", MsgBoxStyle.Critical, "error")
        ElseIf txt_password_vNPass.Text.Length < 5 Or txt_password_vNPass.Text.Length > 12 OrElse txt_Cpassword_vNPass.Text.Length < 5 Or txt_Cpassword_vNPass.Text.Length > 12 Then
            MsgBox("Invalid entry. Password must be between 5 and 12 characters long.", MsgBoxStyle.Critical, "error")
        ElseIf txt_password_vNPass.Text <> txt_Cpassword_vNPass.Text Then
            MsgBox("Passwords do no match!", MsgBoxStyle.Critical, "error")
        Else
            Dim input = MsgBox("Are you sure you want to save this password? ", MsgBoxStyle.YesNo, "Change password")
            If input = 6 Then
                db.newPass(vLogin.txt_username_login.Text, txt_password_vNPass.Text)
                MsgBox("New password has been changed successfully! You may now attempt to log in", MsgBoxStyle.Information, "Password changed")
                Me.Hide()
                vLogin.txt_password_login.Text = ""
            Else
                'do nothing
            End If
        End If
    End Sub


End Class