Imports MySql.Data.MySqlClient

Public Class DBManagerEmployee
    Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    Private connect As MySqlConnection
    Public Sub New()
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Sub testConnection()
        If Me.connect.State = ConnectionState.Open Then
            MsgBox("connect successfuly")
        Else
            MsgBox("not connected....")
        End If
    End Sub

    ' gets all users
    Public Function getAllEmployee()
        Dim query As String = "SELECT * FROM users WHERE status = 1"
        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return dataset.Tables("users").Rows
    End Function

    Public Function getAllEmployeeList() As List(Of employeeBean)
        Dim query As String = "SELECT * FROM users WHERE status = 1"
        Dim dataset As New DataSet
        Dim userlist As New List(Of employeeBean)

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")
            ' row("ID"),
            For Each row As DataRow In dataset.Tables("clients").Rows
                userlist.Add(New employeeBean(row("EmpNumber"), row("username"), row("password"), row("fname"), row("lname"), row("dob"), row("address"), row("city"), row("province"), row("postal"), row("phone"), row("cellphone"), row("dateCreated"), row("NAS"), row("salary"), row("education"), row("level"), row("status")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userlist
    End Function

    ''' <summary>
    ''' search single users
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function getSingleEmployee(ByVal id As Integer) As employeeBean
        Dim query As String = "SELECT * FROM users WHERE id = " & id
        Dim employee = New employeeBean()

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                employee.EmpNumber = reader.GetString(0)
                employee.Username = reader.GetString(1)
                employee.Password = reader.GetString(2)
                employee.Fname = reader.GetString(3)
                employee.Lname = reader.GetString(4)
                employee.Dob = reader.GetDateTime(5)
                employee.Address = reader.GetString(6)
                employee.City = reader.GetString(7)
                employee.Province = reader.GetString(8)
                employee.Postal = reader.GetString(9)
                employee.Phone = reader.GetString(10)
                employee.cellphone = reader.GetString(11)
                employee.DateCreated = reader.GetDateTime(12)
                employee.NAS = reader.GetString(13)
                employee.Salary = reader.GetDouble(14)
                employee.Education = reader.GetString(15)
                employee.Level = reader.GetInt16(16)
                employee.Status = reader.GetBoolean(17)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return employee
    End Function

    ''' <summary>
    ''' add new employee
    ''' </summary>
    ''' <param name="employee"></param>
    Public Sub addEmployee(ByVal employee As employeeBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "INSERT INTO users VALUES(DEFAULT, @EmpNumber,@username,@password, @fname, @lname, @dob,  @address, @city, @province, @postal, @phone,@Cellphone,@dateCreated, @NAS, @salary,  @education,  @level, @status)"
            cmd.Parameters.AddWithValue("@EmpNumber", employee.EmpNumber)
            cmd.Parameters.AddWithValue("@username", employee.Username)
            cmd.Parameters.AddWithValue("@password", employee.Password)
            cmd.Parameters.AddWithValue("@fname", employee.Fname)
            cmd.Parameters.AddWithValue("@lname", employee.Lname)
            cmd.Parameters.AddWithValue("@dob", employee.Dob)
            cmd.Parameters.AddWithValue("@address", employee.Address)
            cmd.Parameters.AddWithValue("@city", employee.City)
            cmd.Parameters.AddWithValue("@province", employee.Province)
            cmd.Parameters.AddWithValue("@postal", employee.Postal)
            cmd.Parameters.AddWithValue("@phone", employee.Phone)
            cmd.Parameters.AddWithValue("@Cellphone", employee.cellphone)
            cmd.Parameters.AddWithValue("@dateCreated", employee.DateCreated)
            cmd.Parameters.AddWithValue("@NAS", employee.NAS)
            cmd.Parameters.AddWithValue("@salary", employee.Salary)
            cmd.Parameters.AddWithValue("@education", employee.Education)
            cmd.Parameters.AddWithValue("@level", employee.Level)
            cmd.Parameters.AddWithValue("@status", employee.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed ")
        End Try
    End Sub

    ''' <summary>
    ''' edit employee
    ''' </summary>
    ''' <param name="editemployee"></param>

    Public Sub editemployee(ByVal editemployee As employeeBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE users SET employee_number=@EmpNumber,username=@username,password=@password,fname=@fname,lname=@lname,dob=@dob,address=@address, city=@city, province=@province,postal_code=@postal,home_phone=@phone,cell_phone=@cellphone,start_date=@dateCreated, sin=@NAS, hourly_pay=@salary,education=@education,level=@level,status=@status where employee_number = '" & vEditEmployee.cbo_select_EEmployee.Text & "' "
            cmd.Parameters.AddWithValue("@EmpNumber", editemployee.EmpNumber)
            cmd.Parameters.AddWithValue("@username", editemployee.Username)
            cmd.Parameters.AddWithValue("@password", editemployee.Password)
            cmd.Parameters.AddWithValue("@fname", editemployee.Fname)
            cmd.Parameters.AddWithValue("@lname", editemployee.Lname)
            cmd.Parameters.AddWithValue("@dob", editemployee.Dob)
            cmd.Parameters.AddWithValue("@address", editemployee.Address)
            cmd.Parameters.AddWithValue("@city", editemployee.City)
            cmd.Parameters.AddWithValue("@province", editemployee.Province)
            cmd.Parameters.AddWithValue("@postal", editemployee.Postal)
            cmd.Parameters.AddWithValue("@phone", editemployee.Phone)
            cmd.Parameters.AddWithValue("@Cellphone", editemployee.cellphone)
            cmd.Parameters.AddWithValue("@dateCreated", editemployee.DateCreated)
            cmd.Parameters.AddWithValue("@NAS", editemployee.NAS)
            cmd.Parameters.AddWithValue("@salary", editemployee.Salary)
            cmd.Parameters.AddWithValue("@education", editemployee.Education)
            cmd.Parameters.AddWithValue("@level", editemployee.Level)
            cmd.Parameters.AddWithValue("@status", editemployee.Status)
            'cmd.Parameters.AddWithValue("@ID", editemployee.ID)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")

        End Try

    End Sub


    ''' <summary>
    ''' deletes a single client
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub deleteemployee(ByVal id As Integer)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE users SET status = 0 WHERE id = @id"
            cmd.Parameters.AddWithValue("@id", id)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ' display Employee
    Public Sub Employee()
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()


            Dim query As String = "SELECT * FROM users WHERE status = 1"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With VEmployeeList.dgv_employeelist
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Emp_Num"
                .Columns(2).HeaderText = "Username"
                .Columns(3).HeaderText = "Password"
                .Columns(4).HeaderText = "Fname"
                .Columns(5).HeaderText = "Lname"
                .Columns(6).HeaderText = "DOB"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City"
                .Columns(9).HeaderText = "Province"
                .Columns(10).HeaderText = "Code"
                .Columns(11).HeaderText = "HomePhone"
                .Columns(12).HeaderText = "Cellphone"
                .Columns(13).HeaderText = "StartDate"
                .Columns(14).HeaderText = "SIN"
                .Columns(15).HeaderText = "Pay"
                .Columns(16).HeaderText = "Education"
                .Columns(17).HeaderText = "Level"
                .Columns(18).HeaderText = "Status"


                .Columns(0).Width = 30
                .Columns(1).Width = 80
                .Columns(2).Width = 80
                .Columns(3).Width = 60
                .Columns(4).Width = 60
                .Columns(5).Width = 60
                .Columns(6).Width = 80
                .Columns(7).Width = 100
                .Columns(8).Width = 80
                .Columns(9).Width = 80
                .Columns(10).Width = 80
                .Columns(11).Width = 80
                .Columns(12).Width = 80
                .Columns(13).Width = 80
                .Columns(14).Width = 80
                .Columns(15).Width = 80
                .Columns(16).Width = 80
                .Columns(17).Width = 60
                .Columns(18).Width = 60
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
End Class







