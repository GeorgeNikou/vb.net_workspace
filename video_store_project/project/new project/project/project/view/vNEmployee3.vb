Public Class vNEmployee3
    Private db As New DBManagerEmployee
    Private Sub btn_next_NEmployee3_Click(sender As Object, e As EventArgs) Handles btn_next_NEmployee3.Click
        Dim obj As New vNEmployee2()
        If txt_username_NEmployee3.Text = "" OrElse txt_username_NEmployee3.Text.Length > 6 Then
            MsgBox("Please enter valid Username")
        End If
        If txt_password_NEmployee3.Text = "" OrElse txt_password_NEmployee3.Text.Length > 6 Then
            MsgBox("Please enter valid Username")
        End If
        If cbo_Level_NEmployee2.SelectedItem = Nothing OrElse vNEmployee2.cbo_education_NEmployee2.SelectedItem.ToString() = Nothing Then
            MsgBox("Please select EDUTATION or ACCESS LEVEL option")
        End If
        Dim level As Integer
        If cbo_Level_NEmployee2.SelectedIndex = 0 Then
            level = 1
        ElseIf cbo_Level_NEmployee2.SelectedIndex = 1 Then
            level = 2
        ElseIf cbo_Level_NEmployee2.SelectedIndex = 2 Then
            level = 3
        ElseIf cbo_Level_NEmployee2.SelectedIndex = 3 Then
            level = 4
        End If
        If cbo_activate_NEmployee3.Checked = True Then

            Dim employee As New employeeBean(vNEmployee2.txt_ENumber_NEmployee2.Text,
                                         txt_username_NEmployee3.Text,
                                         txt_password_NEmployee3.Text,
                                         vNEmployee1.txt_fname_NEmployee1.Text,
                                         vNEmployee1.txt_lname_NEmployee1.Text,
                                         CDate(vNEmployee1.mtx_dob_NEmployee1.Text),
                                         vNEmployee1.txt_address_NEmployee1.Text,
                                         vNEmployee1.txt_city_NEmployee1.Text,
                                         vNEmployee1.txt_province_NEmployee1.Text,
                                         vNEmployee1.mtx_postal_NEmployee1.Text,
                                         vNEmployee1.mtx_number_NEmployee1.Text,
                                         vNEmployee1.mtx_cellno_NEmployee1.Text,
                                         CDate(vNEmployee2.mtx_DCreated_NEmployee2.Text).Date,
                                         vNEmployee2.txt_NAS_NEmployee2.Text,
                                         vNEmployee2.txt_salary_NEmployee2.Text,
                                         vNEmployee2.cbo_education_NEmployee2.SelectedItem.ToString(),
                                         level,
                                         1) 'cbo_activate_NEmployee3.Checked
            MsgBox(employee.ToString, MsgBoxStyle.Information, "Employee added")
            db.addEmployee(employee)
            Me.Close()
            vEmployeeList.Show()

        Else
            MsgBox("Please select")
        End If
    End Sub

    Private Sub btn_back_NEmployee3_Click(sender As Object, e As EventArgs) Handles btn_back_NEmployee3.Click
        Me.Hide()
        vNEmployee2.Show()
    End Sub
End Class