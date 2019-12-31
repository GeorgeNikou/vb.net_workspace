Imports MySql.Data.MySqlClient

Public Class vLogin

    Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    Private connect As MySqlConnection
    Public db As New DBManager

    Private Sub btn_login_login_Click(sender As Object, e As EventArgs) Handles btn_login_login.Click
        db.loginValid(txt_username_login.Text, txt_password_login.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login_visible.Click
        If txt_password_login.UseSystemPasswordChar = False Then
            txt_password_login.UseSystemPasswordChar = True
            btn_login_visible.Text = "Show"
        ElseIf txt_password_login.UseSystemPasswordChar = True Then
            btn_login_visible.Text = "Hide"
            txt_password_login.UseSystemPasswordChar = False
        End If
    End Sub
End Class
