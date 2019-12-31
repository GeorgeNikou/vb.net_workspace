Public Class Form1

    Public index_pos As Integer
    Public logged_avatar As Integer

    Public user_list As New List(Of User)
    'Dim person As New User("George", "Nikou", "123 fk street", 2666884, "Herzing College", "programming", "12345", img_images.Images(1))

    'user_list.Add(person)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb_reg_avatar.Image = img_images.Images(5)
        cb_reg_avatar.Items.Add("Bart Simpson")
        cb_reg_avatar.Items.Add("Homer Simpson")
        cb_reg_avatar.Items.Add("Marge Simpson")
        cb_reg_avatar.Items.Add("Lisa Simpson")
        cb_reg_avatar.Items.Add("Maggie Simpson")
    End Sub

    Private Sub cb_reg_avatar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_reg_avatar.SelectedIndexChanged
        pb_reg_avatar.Image = img_images.Images(cb_reg_avatar.SelectedIndex)
    End Sub

    Private Sub btn_reg_login_Click(sender As Object, e As EventArgs) Handles btn_reg_login.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub btn_reg_submit_Click(sender As Object, e As EventArgs) Handles btn_reg_submit.Click
        If txt_reg_password.Text = txt_reg_confirm.Text AndAlso txt_reg_username.Text.Length >= 5 Then
            If txt_reg_password.Text.Length >= 5 And txt_reg_password.Text.Length < 20 Then
                Dim person As New User(txt_reg_username.Text, txt_reg_password.Text, cb_reg_avatar.SelectedIndex)
                user_list.Add(person)
                MsgBox("|== New user added ==|" & vbNewLine & vbNewLine & person.ToString)

                txt_reg_username.Text = ""
                txt_reg_password.Text = ""
                txt_reg_confirm.Text = ""
                pb_reg_avatar.Image = img_images.Images(5)
            Else
                MsgBox("Invalid password attempt. Password must be greaterthan 5 characters and less than 20.", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Passwords do not match or username is too short. Username must be greater than 5 characters long. Please try again.", MsgBoxStyle.Information)
        End If
    End Sub

End Class
