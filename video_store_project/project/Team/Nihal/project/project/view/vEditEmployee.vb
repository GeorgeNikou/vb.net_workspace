Imports MySql.Data.MySqlClient

Public Class vEditEmployee
    Private db As New DBManagerEmployee
    Private emp As employeeBean

    Private Sub btn_next_EditEmployee_Click(sender As Object, e As EventArgs) Handles btn_next_EditEmployee.Click

        Dim MysqlConnect = New MySqlConnection
        MysqlConnect.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"

        If txt_fname_EditEmployee.Text = "" OrElse IsNumeric(txt_fname_EditEmployee.Text) = True OrElse txt_fname_EditEmployee.Text.Length > 6 Then
            txt_fname_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter valid first name")
        ElseIf txt_lname_EditEmployee.Text = "" OrElse IsNumeric(txt_lname_EditEmployee.Text) = True OrElse txt_lname_EditEmployee.Text.Length > 6 Then
            txt_lname_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter Lastname")
        ElseIf txt_address_EditEmployee.Text = "" OrElse IsNumeric(txt_address_EditEmployee.Text) = True OrElse txt_address_EditEmployee.Text.Length > 15 Then
            txt_address_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter Address")
        ElseIf txt_city_EditEmployee.Text = "" OrElse IsNumeric(txt_city_EditEmployee.Text) = True OrElse txt_city_EditEmployee.Text.length > 6 Then
            txt_city_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter City")
        ElseIf txt_province_EditEmployee.Text = "" OrElse IsNumeric(txt_province_EditEmployee.Text) = True OrElse txt_province_EditEmployee.Text.Length > 6 Then
            txt_province_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter province")
        ElseIf mtx_cell_EditEmployee.Text = "" OrElse mtx_cell_EditEmployee.Text.Length < 12 Then
            mtx_cell_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter CellNumber")
        ElseIf mtx_number_EditEmployee.Text = "" OrElse mtx_number_EditEmployee.Text.Length < 12 Then
            mtx_number_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter PhoneNumber")
        ElseIf mtx_postal_EditEmployee.Text = "" OrElse mtx_postal_EditEmployee.Text.Length < 7 Then
            mtx_postal_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter Postal Code")
        ElseIf txt_ENumber_EditEmployee.Text = "" OrElse IsNumeric(txt_ENumber_EditEmployee.Text) = False OrElse txt_ENumber_EditEmployee.Text.Length > 4 Then
            txt_ENumber_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter valid Employee number (1234)")
        ElseIf txt_NAS_EditEmployee.Text = "" OrElse IsNumeric(txt_NAS_EditEmployee.Text) = False OrElse txt_NAS_EditEmployee.Text.Length > 9 Then
            txt_NAS_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter valid NAS (123456789)")
        ElseIf txt_salary_EditEmployee.Text = "" OrElse IsNumeric(txt_salary_EditEmployee.Text) = False OrElse txt_salary_EditEmployee.Text.Length > 2 Then
            txt_salary_EditEmployee.BackColor = Color.Red
            MsgBox("Please Enter valid Salary (12)")
        ElseIf txt_username_EditEmployee.Text = "" OrElse txt_username_EditEmployee.Text.Length > 6 Then
            MsgBox("Please enter valid Username")
        ElseIf txt_password_EditEmployee.Text = "" OrElse txt_password_EditEmployee.Text.Length > 6 Then
            MsgBox("Please enter valid Username")
        Else
            Dim newemployee As employeeBean
            newemployee = New employeeBean(txt_ENumber_EditEmployee.Text,
                                           txt_username_EditEmployee.Text,
                                           txt_password_EditEmployee.Text,
                                           txt_fname_EditEmployee.Text,
                                           txt_lname_EditEmployee.Text,
                                           CDate(mtx_dob_EditEmployee.Text).ToShortDateString,
                                           txt_address_EditEmployee.Text,
                                           txt_city_EditEmployee.Text,
                                           txt_province_EditEmployee.Text,
                                           mtx_postal_EditEmployee.Text,
                                           mtx_number_EditEmployee.Text,
                                           mtx_cell_EditEmployee.Text,
                                           CDate(mtx_DCreated_EEmployee.Text).ToShortDateString,
                                           txt_NAS_EditEmployee.Text,
                                           txt_salary_EditEmployee.Text,
                                           cbo_education_EditEmployee.Text,
                                           cbo_Level_EditEmployee.Text,
                                           True)
            db.editemployee(newemployee)
            MsgBox("success")
        End If



    End Sub


    Private Sub mtx_dob_EditEmployee_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles mtx_dob_EditEmployee.TypeValidationCompleted

        If mtx_dob_EditEmployee.Text = "__/__/____" Then
            e.Cancel = True
            Exit Sub
        End If


        If (Not e.IsValidInput) Then
            MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
            mtx_dob_EditEmployee.Focus()
            SendKeys.Send("{End}")

        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate < "01/01/1930" Or UserDate > "01/01/2099") Then
                MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
                e.Cancel = True
                mtx_dob_EditEmployee.Focus()
                SendKeys.Send("{End}")
            End If
        End If
    End Sub

    Private Sub mtx_DCreated_EEmployee_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles mtx_DCreated_EEmployee.TypeValidationCompleted

        If mtx_DCreated_EEmployee.Text = "__/__/____" Then
            e.Cancel = True
            Exit Sub
        End If


        If (Not e.IsValidInput) Then
            MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
            mtx_DCreated_EEmployee.Focus()
            SendKeys.Send("{End}")

        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate < "01/01/1930" Or UserDate > "01/01/2099") Then
                MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
                e.Cancel = True
                mtx_DCreated_EEmployee.Focus()
                SendKeys.Send("{End}")
            End If
        End If



    End Sub

    Private Sub cbo_select_EEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_select_EEmployee.SelectedIndexChanged
        'db.editemployee(emp)
        Dim MysqlConnect = New MySqlConnection
        MysqlConnect.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim READER As MySqlDataReader
        Try
            MysqlConnect.Open()
            Dim Query As String
            Query = "select *  from blueBuster.users where employee_number=@EmpNumber "
            Dim Cmd = New MySqlCommand(Query, MysqlConnect)
            Cmd.Parameters.AddWithValue("@EmpNumber", cbo_select_EEmployee.Text)
            READER = Cmd.ExecuteReader()

            While READER.Read()

                'tb_age.Text = ADD_employee.emp.ageYear(READER.GetDateTime("dob"))
                txt_fname_EditEmployee.Text = READER.GetString("fname")
                txt_lname_EditEmployee.Text = READER.GetString("lname")
                mtx_number_EditEmployee.Text = READER.GetString("home_phone")
                mtx_cell_EditEmployee.Text = READER.GetString("cell_phone")
                mtx_DCreated_EEmployee.Text = READER.GetDateTime("start_date")
                mtx_dob_EditEmployee.Text = READER.GetDateTime("dob")
                txt_address_EditEmployee.Text = READER.GetString("address")
                txt_city_EditEmployee.Text = READER.GetString("city")
                txt_province_EditEmployee.Text = READER.GetString("province")
                mtx_postal_EditEmployee.Text = READER.GetString("postal_code")
                txt_ENumber_EditEmployee.Text = READER.GetString("employee_number")
                txt_NAS_EditEmployee.Text = READER.GetString("sin")
                txt_salary_EditEmployee.Text = READER.GetString("hourly_pay")
                cbo_education_EditEmployee.Text = READER.GetString("education")
                txt_username_EditEmployee.Text = READER.GetString("username")
                txt_password_EditEmployee.Text = READER.GetString("password")
                cbo_Level_EditEmployee.Text = READER.GetString("level")
                'CB_Status.Text = READER.GetString("status")

            End While

            MysqlConnect.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConnect.Dispose()
        End Try
    End Sub

    Private Sub btn_back_EditEmployee_Click(sender As Object, e As EventArgs) Handles btn_back_EditEmployee.Click

        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub vEditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PB_editVideo.SizeMode = PictureBoxSizeMode.StretchImage
        'db.employeecombo()
        Dim MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select *  from blueBuster.users where status = 1"
            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                Dim fName = READER.GetString("fname")
                Dim id = READER.GetString("employee_number")
                cbo_select_EEmployee.Items.Add(id)
            End While
            MysqlConn.Close()
            READER.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

End Class