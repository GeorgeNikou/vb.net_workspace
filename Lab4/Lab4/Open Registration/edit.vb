Public Class edit
    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pb_edit_avatar.Image = Form1.img_images.Images(5)
        cb_edit_avatar.Items.Add("Bart Simpson")
        cb_edit_avatar.Items.Add("Homer Simpson")
        cb_edit_avatar.Items.Add("Marge Simpson")
        cb_edit_avatar.Items.Add("Lisa Simpson")
        cb_edit_avatar.Items.Add("Maggie Simpson")

        displayFields()

        If txt_edit_lastname.Text IsNot "" Then
            btn_create_final.Enabled = False
        End If

        If txt_edit_lastname.Text = "" Then
            btn_edit_edit.Enabled = False
            msi_edit_create.Enabled = False
            msi_edit_edit.Enabled = False
            msi_edit_delete.Enabled = False
        End If

        msi_edit_login.Enabled = False

    End Sub
    Private Sub cb_reg_avatar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_edit_avatar.SelectedIndexChanged
        pb_edit_avatar.Image = Form1.img_images.Images(cb_edit_avatar.SelectedIndex)
    End Sub

    Private Sub btn_create_final_Click(sender As Object, e As EventArgs) Handles btn_create_final.Click

        If IsNumeric(txt_edit_username.Text) = True OrElse txt_edit_username.Text = "" Then
            MsgBox("Invalid username entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_lastname.Text) = True OrElse txt_edit_lastname.Text = "" Then
            MsgBox("Invalid last name entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_phone.Text) = False AndAlso txt_edit_phone.Text.Length > 7 OrElse txt_edit_phone.Text = "" Then
            MsgBox("Invalid phone number entry. Must be numeric values", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_address.text) = True OrElse txt_edit_address.Text.Length > 20 OrElse txt_edit_address.Text = "" Then
            MsgBox("Invalid address entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_program.Text) = True OrElse txt_edit_program.Text = "" Then
            MsgBox("Invalid program entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_school.Text) = True OrElse txt_edit_school.Text = "" Then
            MsgBox("Invalid school entry.", MsgBoxStyle.Information)
        ElseIf cb_edit_avatar.SelectedIndex = -1 Then
            MsgBox("Please select an avatar from the dropdown menu.")
        Else
            'txt_edit_dob.Text = Format(txt_edit_dob.Text, "dd/mm/yyyy")
            Form1.user_list(Form1.index_pos).Firstname = txt_edit_username.Text
            Form1.user_list(Form1.index_pos).Lastname = txt_edit_lastname.Text
            Form1.user_list(Form1.index_pos).Dob = txt_edit_dob.Text
            Form1.user_list(Form1.index_pos).Address = txt_edit_address.Text
            Form1.user_list(Form1.index_pos).Phone = txt_edit_phone.Text
            Form1.user_list(Form1.index_pos).School = txt_edit_school.Text
            Form1.user_list(Form1.index_pos).Program = txt_edit_program.Text
            Form1.user_list(Form1.index_pos).Password = txt_edit_password.Text
            Form1.user_list(Form1.index_pos).Avatar = cb_edit_avatar.SelectedIndex

            If txt_edit_lastname.Text IsNot "" AndAlso txt_edit_phone.Text IsNot "" AndAlso txt_edit_program.Text IsNot "" AndAlso txt_edit_school.Text IsNot "" Then
                btn_create_final.Enabled = False
                btn_edit_edit.Enabled = True
                msi_edit_create.Enabled = False
                msi_edit_edit.Enabled = True
                msi_edit_delete.Enabled = True
            End If
            MsgBox("|== User has been created ==|" & vbNewLine & vbNewLine & Form1.user_list(Form1.index_pos).ToString)
        End If
    End Sub

    Private Sub btn_edit_edit_Click(sender As Object, e As EventArgs) Handles btn_edit_edit.Click

        If IsNumeric(txt_edit_username.Text) = True OrElse txt_edit_username.Text = "" Then
            MsgBox("Invalid username entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_lastname.Text) = True OrElse txt_edit_lastname.Text = "" Then
            MsgBox("Invalid last name entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_phone.Text) = False AndAlso txt_edit_phone.Text.Length > 7 OrElse txt_edit_phone.Text = "" Then
            MsgBox("Invalid phone number entry. Must be numeric values", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_address.Text) = True OrElse txt_edit_address.Text.Length > 20 OrElse txt_edit_address.Text = "" Then
            MsgBox("Invalid address entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_program.Text) = True OrElse txt_edit_program.Text = "" Then
            MsgBox("Invalid program entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_school.Text) = True OrElse txt_edit_school.Text = "" Then
            MsgBox("Invalid school entry.", MsgBoxStyle.Information)
        ElseIf cb_edit_avatar.SelectedIndex = -1 Then
            MsgBox("Please select an avatar from the dropdown menu.")
        Else
            Dim decision = MsgBox("Are you sure you want to edit this profile? Changes made are permanent and cannot be reverted.", MsgBoxStyle.YesNo)

            If decision = 6 Then
                Form1.user_list(Form1.index_pos).Firstname = txt_edit_username.Text
                Form1.user_list(Form1.index_pos).Lastname = txt_edit_lastname.Text
                Form1.user_list(Form1.index_pos).Dob = txt_edit_dob.Text
                Form1.user_list(Form1.index_pos).Address = txt_edit_address.Text
                Form1.user_list(Form1.index_pos).Phone = txt_edit_phone.Text
                Form1.user_list(Form1.index_pos).School = txt_edit_school.Text
                Form1.user_list(Form1.index_pos).Program = txt_edit_program.Text
                Form1.user_list(Form1.index_pos).Password = txt_edit_password.Text
                Form1.user_list(Form1.index_pos).Avatar = cb_edit_avatar.SelectedIndex

                If txt_edit_lastname.Text IsNot "" AndAlso txt_edit_phone.Text IsNot "" AndAlso txt_edit_program.Text IsNot "" AndAlso txt_edit_school.Text IsNot "" Then
                    btn_create_final.Enabled = False
                End If

                MsgBox("|== Your profile has been successfully edited ==|" & vbNewLine & vbNewLine & Form1.user_list(Form1.index_pos).ToString)
            Else
                MsgBox("Profile has been unchanged.")
                displayFields()
            End If
        End If


    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msi_edit_logout.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        MsgBox("And so as we look then at the time line and the importance of this time line, I want you to remember these words. Like the defining moment in this trial, the day Mr. Darden asked Mr. Simpson to try on those gloves and the gloves didn't fit, remember these words; if it doesn't fit, you must acquit. And we are going to be talking about that throughout. So to summarize, if you take the witnesses that we presented who stand unimpeached, unimpeached, and if you are left with dogs starting to bark at 10:35 or 10:40, 10:40 let's say--and we know from the most qualified individuals, Henry Lee and Michael Baden, this was a struggle that took from five to 15 minutes. It's already 10:55. And remember, the thumps were at 10:40 or 10:45--O.J. Simpson could not be guilty. He is then entitled to an acquittal", MsgBoxStyle.Information)
    End Sub

    Private Sub displayFields()
        txt_edit_username.Text = Form1.user_list(Form1.index_pos).Firstname
        txt_edit_lastname.Text = Form1.user_list(Form1.index_pos).Lastname
        txt_edit_dob.Text = Form1.user_list(Form1.index_pos).Dob
        txt_edit_address.Text = Form1.user_list(Form1.index_pos).Address
        txt_edit_phone.Text = Form1.user_list(Form1.index_pos).Phone
        txt_edit_school.Text = Form1.user_list(Form1.index_pos).School
        txt_edit_program.Text = Form1.user_list(Form1.index_pos).Program
        txt_edit_password.Text = Form1.user_list(Form1.index_pos).Password
        pb_edit_avatar.Image = Form1.img_images.Images(Form1.logged_avatar)
    End Sub

    Private Sub msi_edit_create_Click(sender As Object, e As EventArgs) Handles msi_edit_create.Click
        If IsNumeric(txt_edit_username.Text) = True OrElse txt_edit_username.Text = "" Then
            MsgBox("Invalid username entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_lastname.Text) = True OrElse txt_edit_lastname.Text = "" Then
            MsgBox("Invalid last name entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_phone.Text) = False AndAlso txt_edit_phone.Text.Length > 7 OrElse txt_edit_phone.Text = "" Then
            MsgBox("Invalid phone number entry. Must be numeric values", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_address.Text) = True OrElse txt_edit_address.Text.Length > 20 OrElse txt_edit_address.Text = "" Then
            MsgBox("Invalid address entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_program.Text) = True OrElse txt_edit_program.Text = "" Then
            MsgBox("Invalid program entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_school.Text) = True OrElse txt_edit_school.Text = "" Then
            MsgBox("Invalid school entry.", MsgBoxStyle.Information)
        ElseIf cb_edit_avatar.SelectedIndex = -1 Then
            MsgBox("Please select an avatar from the dropdown menu.")
        Else
            'txt_edit_dob.Text = Format(txt_edit_dob.Text, "dd/mm/yyyy")
            Form1.user_list(Form1.index_pos).Firstname = txt_edit_username.Text
            Form1.user_list(Form1.index_pos).Lastname = txt_edit_lastname.Text
            Form1.user_list(Form1.index_pos).Dob = txt_edit_dob.Text
            Form1.user_list(Form1.index_pos).Address = txt_edit_address.Text
            Form1.user_list(Form1.index_pos).Phone = txt_edit_phone.Text
            Form1.user_list(Form1.index_pos).School = txt_edit_school.Text
            Form1.user_list(Form1.index_pos).Program = txt_edit_program.Text
            Form1.user_list(Form1.index_pos).Password = txt_edit_password.Text
            Form1.user_list(Form1.index_pos).Avatar = cb_edit_avatar.SelectedIndex

            If txt_edit_lastname.Text IsNot "" AndAlso txt_edit_phone.Text IsNot "" AndAlso txt_edit_program.Text IsNot "" AndAlso txt_edit_school.Text IsNot "" Then
                btn_create_final.Enabled = False
                btn_edit_edit.Enabled = True
            End If
            MsgBox("|== User has been created ==|" & vbNewLine & vbNewLine & Form1.user_list(Form1.index_pos).ToString)
        End If
    End Sub

    Private Sub msi_edit_edit_Click(sender As Object, e As EventArgs) Handles msi_edit_edit.Click
        If IsNumeric(txt_edit_username.Text) = True OrElse txt_edit_username.Text = "" Then
            MsgBox("Invalid username entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_lastname.Text) = True OrElse txt_edit_lastname.Text = "" Then
            MsgBox("Invalid last name entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_phone.Text) = False AndAlso txt_edit_phone.Text.Length > 7 OrElse txt_edit_phone.Text = "" Then
            MsgBox("Invalid phone number entry. Must be numeric values", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_address.Text) = True OrElse txt_edit_address.Text.Length > 20 OrElse txt_edit_address.Text = "" Then
            MsgBox("Invalid address entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_program.Text) = True OrElse txt_edit_program.Text = "" Then
            MsgBox("Invalid program entry.", MsgBoxStyle.Information)
        ElseIf IsNumeric(txt_edit_school.Text) = True OrElse txt_edit_school.Text = "" Then
            MsgBox("Invalid school entry.", MsgBoxStyle.Information)
        ElseIf cb_edit_avatar.SelectedIndex = -1 Then
            MsgBox("Please select an avatar from the dropdown menu.")
        Else
            Dim decision = MsgBox("Are you sure you want to edit this profile? Changes made are permanent and cannot be reverted.", MsgBoxStyle.YesNo)

            If decision = 6 Then
                Form1.user_list(Form1.index_pos).Firstname = txt_edit_username.Text
                Form1.user_list(Form1.index_pos).Lastname = txt_edit_lastname.Text
                Form1.user_list(Form1.index_pos).Dob = txt_edit_dob.Text
                Form1.user_list(Form1.index_pos).Address = txt_edit_address.Text
                Form1.user_list(Form1.index_pos).Phone = txt_edit_phone.Text
                Form1.user_list(Form1.index_pos).School = txt_edit_school.Text
                Form1.user_list(Form1.index_pos).Program = txt_edit_program.Text
                Form1.user_list(Form1.index_pos).Password = txt_edit_password.Text
                Form1.user_list(Form1.index_pos).Avatar = cb_edit_avatar.SelectedIndex

                If txt_edit_lastname.Text IsNot "" AndAlso txt_edit_phone.Text IsNot "" AndAlso txt_edit_program.Text IsNot "" AndAlso txt_edit_school.Text IsNot "" Then
                    btn_create_final.Enabled = False
                End If

                MsgBox("|== Your profile has been successfully edited ==|" & vbNewLine & vbNewLine & Form1.user_list(Form1.index_pos).ToString)
            Else
                MsgBox("Profile has been unchanged.")
                displayFields()
            End If
        End If
    End Sub

    Private Sub msi_edit_delete_Click(sender As Object, e As EventArgs) Handles msi_edit_delete.Click

        Dim decision = MsgBox("Are you sure you want to edit this profile? Changes made are permanent and cannot be reverted.", MsgBoxStyle.YesNo)

        If decision = 6 Then
            Form1.user_list(Form1.index_pos).Firstname = ""
            Form1.user_list(Form1.index_pos).Lastname = ""

            Me.Close()
            Form1.Show()
        Else
            MsgBox("Profile has been left unchanged.")
        End If

    End Sub
End Class