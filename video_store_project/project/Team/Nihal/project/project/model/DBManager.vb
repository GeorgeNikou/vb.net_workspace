Imports MySql.Data.MySqlClient
Public Class DBManager

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

    ''' <summary>
    ''' gets all client
    ''' </summary>
    ''' <returns></returns>
    Public Function getAllClients()
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


    Public Function getAllClientsList() As List(Of clientBean)
        Dim query As String = "SELECT * FROM users WHERE status = 1"
        Dim dataset As New DataSet
        Dim userlist As New List(Of clientBean)

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")

            For Each row As DataRow In dataset.Tables("clients").Rows
                userlist.Add(New clientBean(row("fname"), row("lname"), row("email"), row("phone"), row("dob"), row("age"), row("address"), row("city"), row("province"), row("postal"), row("status"), row("level")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userlist
    End Function

    ''' <summary>
    ''' search single client
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function getSingleClient(ByVal id As Integer) As clientBean
        Dim query As String = "SELECT * FROM users WHERE id = " & id
        Dim client = New clientBean()

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                client.Fname = reader.GetString(0)
                client.Lname = reader.GetString(1)
                client.Email = reader.GetString(2)
                client.Phone = reader.GetInt16(3)
                client.Dob = reader.GetDateTime(4)
                client.Age = reader.GetInt16(5)
                client.Address = reader.GetString(6)
                client.City = reader.GetString(7)
                client.Province = reader.GetString(8)
                client.Postal = reader.GetString(9)
                client.Rented = reader.GetInt16(10)
                client.Status = reader.GetBoolean(11)
                client.Level = reader.GetInt16(12)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return client
    End Function

    ''' <summary>
    ''' add new client
    ''' </summary>
    ''' <param name="client"></param>
    Public Sub addUser(ByVal client As clientBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "INSERT INTO users VALUES(DEFAULT, @fname, @lname, @email, @phone, @dob, @age, @address, @city, @province, @postal, @rented, @status, @level)"
            cmd.Parameters.AddWithValue("@fname", client.Fname)
            cmd.Parameters.AddWithValue("@lname", client.Lname)
            cmd.Parameters.AddWithValue("@email", client.Email)
            cmd.Parameters.AddWithValue("@phone", client.Phone)
            cmd.Parameters.AddWithValue("@dob", client.Dob)
            cmd.Parameters.AddWithValue("@age", client.Age)
            cmd.Parameters.AddWithValue("@address", client.Address)
            cmd.Parameters.AddWithValue("@city", client.City)
            cmd.Parameters.AddWithValue("@province", client.Province)
            cmd.Parameters.AddWithValue("@postal", client.Postal)
            cmd.Parameters.AddWithValue("@rented", client.Rented)
            cmd.Parameters.AddWithValue("@status", client.Status)
            cmd.Parameters.AddWithValue("@level", client.Level)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' edits a single client
    ''' </summary>
    ''' <param name="client"></param>
    Public Sub editClient(ByVal client As clientBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE users SET fname = @fname, lname = @lname, email = @email, phone = @phone, dob = @dob, age = @age, address = @address, city = @city, province = @province, postal = @postal, rented = @rented, status = @status, level = @level WHERE clientID = @clientID"
            cmd.Parameters.AddWithValue("@fname", client.Fname)
            cmd.Parameters.AddWithValue("@lname", client.Lname)
            cmd.Parameters.AddWithValue("@age", client.Email)
            cmd.Parameters.AddWithValue("@gender", client.Phone)
            cmd.Parameters.AddWithValue("@dob", client.Dob)
            cmd.Parameters.AddWithValue("@age", client.Age)
            cmd.Parameters.AddWithValue("@address", client.Address)
            cmd.Parameters.AddWithValue("@city", client.City)
            cmd.Parameters.AddWithValue("@province", client.Province)
            cmd.Parameters.AddWithValue("@postal", client.Postal)
            cmd.Parameters.AddWithValue("@rented", client.Rented)
            cmd.Parameters.AddWithValue("@status", client.Status)
            cmd.Parameters.AddWithValue("@level", client.Level)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' deletes a single client
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub deleteClient(ByVal id As Integer)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE clients SET status = 0 WHERE id = @id"
            cmd.Parameters.AddWithValue("@id", id)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ' display clients
    Public Sub clients()
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()


            Dim query As String = "SELECT * FROM clients WHERE status = 1"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With test.DataGridView1
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Firstname"
                .Columns(2).HeaderText = "Lastname"
                .Columns(3).HeaderText = "Age"
                .Columns(4).HeaderText = "Gender"
                .Columns(5).HeaderText = "Status"


                .Columns(0).Width = 30
                .Columns(1).Width = 60
                .Columns(2).Width = 60
                .Columns(3).Width = 30
                .Columns(4).Width = 50
                .Columns(5).Width = 40

            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
End Class

