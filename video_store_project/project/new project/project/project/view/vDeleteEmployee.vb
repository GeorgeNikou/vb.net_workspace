Imports MySql.Data.MySqlClient

Public Class vDeleteEmployee
    Dim db As New DBManager()
    Private Sub vDeleteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select *  from blueBuster.users where status=1"
            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                Dim fName = READER.GetString("fname")
                Dim id = READER.GetString("user_id")
                cbo_select_DeleteEmployee.Items.Add(fName)
            End While
            MysqlConn.Close()
            READER.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub cbo_select_DeleteEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_select_DeleteEmployee.SelectedIndexChanged
        Dim MysqlConnect = New MySqlConnection
        MysqlConnect.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim READER As MySqlDataReader
        Try
            MysqlConnect.Open()
            Dim Query As String
            Query = "select *  from blueBuster.users where fname=@fname and status=1"
            Dim Cmd = New MySqlCommand(Query, MysqlConnect)
            Cmd.Parameters.AddWithValue("@fname", cbo_select_DeleteEmployee.Text)
            READER = Cmd.ExecuteReader()

            While READER.Read()


                txt_fname_DeleteEmployee.Text = READER.GetString("fname")
                txt_lname_DeleteEmployee.Text = READER.GetString("lname")
                mtx_number_DeleteEmployee.Text = READER.GetString("home_phone")
                mtx_cell_DeleteEmployee.Text = READER.GetString("cell_phone")
                mtx_DCreated_DEmployee.Text = READER.GetString("dob")
                mtx_dob_DeleteEmployee.Text = READER.GetString("start_date")
                txt_address_DeleteEmployee.Text = READER.GetString("address")
                txt_city_DeleteEmployee.Text = READER.GetString("city")
                txt_province_DeleteEmployee.Text = READER.GetString("province")
                mtx_postal_DeleteEmployee.Text = READER.GetString("postal_code")
                txt_ENumber_DeleteEmployee.Text = READER.GetString("employee_number")
                txt_NAS_DeleteEmployee.Text = READER.GetString("sin")
                txt_salary_DeleteEmployee.Text = READER.GetString("hourly_pay")
                'mtx_dob_EditEmployee.Text = READER.GetDateTime("start_date")
                cbo_education_DeleteEmployee.Text = READER.GetString("education")
                txt_username_DeleteEmployee.Text = READER.GetString("username")
                txt_password_DeleteEmployee.Text = READER.GetString("password")
                cbo_Level_DeleteEmployee.Text = READER.GetString("level")

            End While

            MysqlConnect.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConnect.Dispose()
        End Try
    End Sub

    Private Sub btn_next_DeleteEmployee_Click(sender As Object, e As EventArgs) Handles btn_next_DeleteEmployee.Click
        Dim MysqlConnect = New MySqlConnection
        MysqlConnect.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim delete_command As New MySqlCommand("UPDATE users SET status=0 where fname=@fname", MysqlConnect)
        delete_command.Parameters.AddWithValue("@fname", cbo_select_DeleteEmployee.Text)
        MysqlConnect.Open()
        If delete_command.ExecuteNonQuery Then
            MsgBox("Employee deleted")
        Else
            MsgBox("data error")


        End If
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        vDeleteEmployee_Load(e, e)

        Refresh()
    End Sub

    Private Sub btn_back_DeleteEmployee_Click(sender As Object, e As EventArgs) Handles btn_back_DeleteEmployee.Click
        Me.Close()
        vDashboard.Show()
    End Sub
End Class