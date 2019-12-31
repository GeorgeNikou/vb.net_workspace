Imports MySql.Data.MySqlClient
Public Class DBManager

    Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    Private connect As MySqlConnection
    Private login_reader As MySqlDataReader
    Private exists_reader As MySqlDataReader

    Public tmp_user As String

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

    'START OF GEORGES FUNCTIONS BELOW ---------------------------------------------------------------------------
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
        Dim query As String = "SELECT * FROM clients WHERE status = 1"
        Dim dataset As New DataSet
        Dim userlist As New List(Of clientBean)

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")

            For Each row As DataRow In dataset.Tables("clients").Rows
                userlist.Add(New clientBean(row("fname"), row("lname"), row("email"), row("phone"), row("dob"), row("address"), row("city"), row("province"), row("postal"), row("status"), row("level")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userlist
    End Function

    Public Function getSingleClient(ByVal id As Integer)
        Dim query As String = "SELECT * FROM clients WHERE client_number = " & id
        Dim client As Integer

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                client = reader.GetString(0)

            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return client
    End Function

    ''' <summary>
    ''' search single client
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    'Public Function getSingleClient(ByVal id As Integer) As clientBean
    '    Dim query As String = "SELECT * FROM clients WHERE id = " & id
    '    Dim client = New clientBean()

    '    Try
    '        Dim cmd As New MySqlCommand(query, Me.connect)
    '        Dim reader As MySqlDataReader = cmd.ExecuteReader()

    '        If reader.Read() Then
    '            client.Fname = reader.GetString(0)
    '            client.Lname = reader.GetString(1)
    '            client.Email = reader.GetString(2)
    '            client.Phone = reader.GetInt16(3)
    '            client.Dob = reader.GetDateTime(4)
    '            client.Address = reader.GetString(6)
    '            client.City = reader.GetString(7)
    '            client.Province = reader.GetString(8)
    '            client.Postal = reader.GetString(9)
    '            client.Status = reader.GetBoolean(11)
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
    '    End Try

    '    Return client
    'End Function

    ''' <summary>
    ''' this function fills out all textfields within the client edit page
    ''' </summary>
    ''' <param name="id">this parameter takes a clients id number</param>
    ''' <returns></returns>
    Public Function fillSingleClient(ByVal id As Integer) As clientBean
        Dim client As New clientBean()
        Dim query As String = "SELECT * FROM clients WHERE client_number = " & id

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                client.Id = reader.GetInt32(0)
                client.Id = reader.GetString(1)
                client.Fname = reader.GetString(2)
                client.Lname = reader.GetString(3)
                client.Email = reader.GetString(4)
                client.Phone = reader.GetString(5)
                client.Dob = reader.GetDateTime(6)
                client.Address = reader.GetString(7)
                client.City = reader.GetString(8)
                client.Province = reader.GetString(9)
                client.Postal = reader.GetString(10)
                client.Status = reader.GetInt16(11)

                Dim birthdate = Math.Floor(Date.Now().Subtract(client.Dob).TotalDays / 365)

                vEditClient.txt_id_EClient.Text = client.Id
                vEditClient.txt_fname_EClient.Text = client.Fname
                vEditClient.txt_lname_EClient.Text = client.Lname
                vEditClient.txt_email_EClient.Text = client.Email
                vEditClient.mtx_number_EClient.Text = client.Phone
                vEditClient.mtx_dob_EClient.Text = client.Dob
                vEditClient.txt_age_EClient.Text = birthdate
                vEditClient.txt_address_Eclient.Text = client.Address
                vEditClient.txt_city_Eclient.Text = client.City
                vEditClient.txt_province_EClient.Text = client.Province
                vEditClient.mtx_postal_EClient.Text = client.Postal

                vDeleteClient.txt_id_DClient.Text = client.Id
                vDeleteClient.txt_fname_DClient.Text = client.Fname
                vDeleteClient.txt_lname_DClient.Text = client.Lname
                vDeleteClient.txt_email_DClient.Text = client.Email
                vDeleteClient.mtx_number_DClient.Text = client.Phone
                vDeleteClient.mtx_dob_DClient.Text = client.Dob
                vDeleteClient.txt_age_DClient.Text = birthdate
                vDeleteClient.txt_address_Dclient.Text = client.Address
                vDeleteClient.txt_city_Dclient.Text = client.City
                vDeleteClient.txt_province_DClient.Text = client.Province
                vDeleteClient.mtx_postal_DClient.Text = client.Postal


            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return client
    End Function
    ''' <summary>
    ''' add new client
    ''' </summary>
    ''' <param name="client"></param>
    Public Sub addClient(ByVal client As clientBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "INSERT INTO clients VALUES(DEFAULT, @client_number, @fname, @lname, @email, @phone, @dob, @address, @city, @province, @postal_code, @status)"
            cmd.Parameters.AddWithValue("@client_number", client.Id)
            cmd.Parameters.AddWithValue("@fname", client.Fname)
            cmd.Parameters.AddWithValue("@lname", client.Lname)
            cmd.Parameters.AddWithValue("@email", client.Email)
            cmd.Parameters.AddWithValue("@phone", client.Phone)
            cmd.Parameters.AddWithValue("@dob", client.Dob)
            cmd.Parameters.AddWithValue("@address", client.Address)
            cmd.Parameters.AddWithValue("@city", client.City)
            cmd.Parameters.AddWithValue("@province", client.Province)
            cmd.Parameters.AddWithValue("@postal_code", client.Postal)
            cmd.Parameters.AddWithValue("@status", client.Status)


            Dim rowAffected = cmd.ExecuteNonQuery()
            'MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
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
            cmd.CommandText = "UPDATE clients SET client_number = @clientID, fname = @fname, lname = @lname, email = @email, phone = @phone, dob = @dob, address = @address, city = @city, province = @province, postal_code = @postal_code, status = @status WHERE client_number = '" & vDashboard.client_num_edit & "'"
            cmd.Parameters.AddWithValue("@clientID", client.Id)
            cmd.Parameters.AddWithValue("@fname", client.Fname)
            cmd.Parameters.AddWithValue("@lname", client.Lname)
            cmd.Parameters.AddWithValue("@email", client.Email)
            cmd.Parameters.AddWithValue("@phone", client.Phone)
            cmd.Parameters.AddWithValue("@dob", client.Dob)
            cmd.Parameters.AddWithValue("@address", client.Address)
            cmd.Parameters.AddWithValue("@city", client.City)
            cmd.Parameters.AddWithValue("@province", client.Province)
            cmd.Parameters.AddWithValue("@postal_code", client.Postal)
            cmd.Parameters.AddWithValue("@status", client.Status)


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
            cmd.CommandText = "UPDATE clients SET status = 0 WHERE client_number = @id"
            cmd.Parameters.AddWithValue("@id", id)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' login validation function
    ''' </summary>
    ''' <param name="username">this parameter takes in the employees username</param>
    ''' <param name="password">this parameter takes in the employees password</param>
    ''' <returns></returns>
    Public Function loginValid(ByVal username As String, ByVal password As String) As employeeBean
        Dim query As String = "SELECT * FROM users WHERE username = '" & username & "' AND password = '" & password & "'"
        Dim employee = New employeeBean()

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            login_reader = cmd.ExecuteReader()

            If login_reader.Read() Then
                employee.ID = login_reader.GetString(0)
                employee.EmpNumber = login_reader.GetString(1)
                employee.Username = login_reader.GetString(2)
                employee.Password = login_reader.GetString(3)
                employee.Fname = login_reader.GetString(4)
                employee.Lname = login_reader.GetString(5)
                employee.Dob = login_reader.GetDateTime(6)
                employee.Address = login_reader.GetString(7)
                employee.City = login_reader.GetString(8)
                employee.Province = login_reader.GetString(9)
                employee.Postal = login_reader.GetString(10)
                employee.Phone = login_reader.GetString(11)
                employee.Phone = login_reader.GetString(12)
                employee.DateCreated = login_reader.GetDateTime(13)
                employee.NAS = login_reader.GetString(14)
                employee.Salary = login_reader.GetDouble(15)
                employee.Education = login_reader.GetString(16)
                employee.Level = login_reader.GetInt32(17)
                employee.Status = login_reader.GetInt32(18)

                If employee.Password.ToLower.Contains("herzing") Then
                    MsgBox("Default password detected.")
                    tmp_user = employee.Username
                    vNPassword.Show()
                Else
                    If employee.Level = 1 Then
                        MsgBox("Level 1 has been seen")

                        vDashboard.EditToolStripMenuItem.Enabled = False
                        vDashboard.EditToolStripMenuItem1.Enabled = False
                        vDashboard.EditToolStripMenuItem2.Enabled = False
                        vDashboard.DeleteToolStripMenuItem.Enabled = False
                        vDashboard.DeleteToolStripMenuItem1.Enabled = False
                        vDashboard.DeleteToolStripMenuItem2.Enabled = False

                        vLogin.Hide()
                        vDashboard.Show()

                    ElseIf employee.Level = 2 Then
                        MsgBox("Level 2 has been seen")

                        vDashboard.DeleteToolStripMenuItem.Enabled = False
                        vDashboard.DeleteToolStripMenuItem1.Enabled = False
                        vDashboard.DeleteToolStripMenuItem2.Enabled = False

                        vLogin.Hide()
                        vDashboard.Show()
                    ElseIf employee.Level = 3 Then
                        MsgBox("Level 3 has been seen")
                        vLogin.Hide()
                        vDashboard.Show()

                    ElseIf employee.Level = 4 Then
                        MsgBox("Admin logged in!")
                        vLogin.Hide()
                        vDashboard.Show()
                    End If
                    login_reader.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox("Invalid entry. Please try again.", MsgBoxStyle.Information, "User Login")
            login_reader.Close()
        End Try

        If employee.Username = "" Or employee.Password = "" Then
            MsgBox("Invalid entry. Please try again.", MsgBoxStyle.Information, "BlueBuster login")
            login_reader.Close()
        End If

        Return employee
    End Function



    Public Function clientExistsEdit(ByVal id As String) As clientBean
        Dim query As String = "SELECT * FROM clients WHERE client_number = " & id
        Dim client = New clientBean()

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            exists_reader = cmd.ExecuteReader()

            If exists_reader.Read() Then
                client.Id = exists_reader.GetInt32(0)
                client.Id = exists_reader.GetString(1)
                client.Fname = exists_reader.GetString(2)
                client.Lname = exists_reader.GetString(3)
                client.Email = exists_reader.GetString(4)
                client.Phone = exists_reader.GetString(5)
                client.Dob = exists_reader.GetDateTime(6)
                client.Address = exists_reader.GetString(7)
                client.City = exists_reader.GetString(8)
                client.Province = exists_reader.GetString(9)
                client.Postal = exists_reader.GetString(10)
                client.Status = exists_reader.GetInt16(11)

                vDashboard.Hide()
                vEditClient.Show()
            End If

        Catch ex As Exception
            MsgBox("Invalid entry. Please try again.", MsgBoxStyle.Critical)
            exists_reader.Close()
        End Try
        exists_reader.Close()
        Return client
    End Function


    Public Function clientExistsDelete(ByVal id As String) As clientBean
        Dim query As String = "SELECT * FROM clients WHERE client_number = " & id
        Dim client = New clientBean()

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            exists_reader = cmd.ExecuteReader()

            If exists_reader.Read() Then
                client.Id = exists_reader.GetInt32(0)
                client.Id = exists_reader.GetString(1)
                client.Fname = exists_reader.GetString(2)
                client.Lname = exists_reader.GetString(3)
                client.Email = exists_reader.GetString(4)
                client.Phone = exists_reader.GetString(5)
                client.Dob = exists_reader.GetDateTime(6)
                client.Address = exists_reader.GetString(7)
                client.City = exists_reader.GetString(8)
                client.Province = exists_reader.GetString(9)
                client.Postal = exists_reader.GetString(10)
                client.Status = exists_reader.GetInt16(11)

                vDashboard.Hide()
                vDeleteClient.Show()
            End If

        Catch ex As Exception
            MsgBox("Invalid entry. Please try again.", MsgBoxStyle.Critical)
            exists_reader.Close()
        End Try
        exists_reader.Close()
        Return client
    End Function


    Public Sub newPass(ByVal user As String, ByVal pass As String)
        Dim cmd As New MySqlCommand
        Dim employee As New employeeBean()

        employee.Username = user
        employee.Password = pass

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE users SET password = @password WHERE username = '" & employee.Username & "'"
            cmd.Parameters.AddWithValue("@password", employee.Password)

            Dim rowAffected = cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub



    Public Sub quickSearch(ByVal id As Integer, ByVal title As String)

        vQuickSearch.dgv_quicksearch.Font = New Font("Segoe UI", 9)
        vQuickSearch.dgv_quicksearch.Font = New Font("Segoe UI", 9)
        vQuickSearch.pnl_quicksearch.Visible = True

        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT * FROM videos WHERE video_id = '" & id & "' OR title = '" & title & "'"
            Dim datatable1 As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable1)

            With vQuickSearch.dgv_quicksearch
                .DataSource = datatable1

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Photo"
                .Columns(2).HeaderText = "Title"
                .Columns(3).HeaderText = "Year"
                .Columns(4).HeaderText = "Country"
                .Columns(5).HeaderText = "Language"
                .Columns(6).HeaderText = "Length"
                .Columns(7).HeaderText = "Resume"
                .Columns(8).HeaderText = "Genre"
                .Columns(9).HeaderText = "Actors"
                .Columns(10).HeaderText = "Director"
                .Columns(11).HeaderText = "Status"


                '.Columns(0).Width = 30
                '.Columns(1).Width = 60
                '.Columns(2).Width = 60
                '.Columns(3).Width = 60
                '.Columns(4).Width = 200
                '.Columns(5).Width = 80
                '.Columns(6).Width = 80
                '.Columns(7).Width = 110
                '.Columns(8).Width = 60
                '.Columns(9).Width = 60
                '.Columns(10).Width = 60
                '.Columns(11).Width = 40
            End With
            With vQuickSearch.dgv_quicksearch
                If .Rows(0).Cells(0).Value Is Nothing Then
                    vQuickSearch.lbl_quicksearch.Visible = True
                Else
                    vQuickSearch.pnl_quicksearch.Visible = False
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
    'END OF GEORGE'S FUNCTIONS ---------------------------------------------------------------------------





    'START OF JOSE'S FUNCTIONS BELOW ---------------------------------------------------------------------
    'VIDEO FUNCTIONS BELOW ---------------



    ''' <summary>
    ''' gets all videos
    ''' </summary>
    ''' <returns></returns>
    Public Function getAllVideos()
        Dim query As String = "SELECT * FROM vb_videos"
        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "vb_videos")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return dataset.Tables("vb_videos").Rows
    End Function


    Public Function getAllVideosList() As List(Of videoBean)
        Dim query As String = "SELECT * FROM vb_videos"
        Dim dataset As New DataSet
        Dim videoslist As New List(Of videoBean)

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "vb_videos")

            For Each row As DataRow In dataset.Tables("vb_videos").Rows
                videoslist.Add(New videoBean(row("video_id"), row("photo"), row("title"), row("year"), row("country"), row("language"), row("length"), row("resume"), row("genre"), row("actors"), row("director"), row("status")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return videoslist
    End Function

    'Populate video form from db
    Public Function fillSingleVideo(ByVal id As Integer) As videoBean
        Dim video As New videoBean()
        Dim query As String = "SELECT * FROM vb_videos WHERE video_id = " & id

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                video.VideoID = reader.GetInt32(0)
                video.Title = reader.GetString(2)
                video.Genre = reader.GetString(8)
                video.Year = reader.GetString(3)
                video.Country = reader.GetString(4)
                video.Language = reader.GetString(5)
                video.Length = reader.GetString(6)
                video.Director = reader.GetString(10)
                video.Actor = reader.GetString(9)
                video.Photo = reader.GetString(1)
                video.Resume = reader.GetString(7)
                video.Status = reader.GetInt16(11)

                vEditVideo.txt_id_EVideo.Text = video.VideoID
                vEditVideo.txt_title_EditVideo.Text = video.Title
                vEditVideo.txt_genre_EditVideo.Text = video.Genre
                vEditVideo.mtx_year_EditVideo.Text = video.Year
                vEditVideo.txt_country_EditVideo.Text = video.Country
                vEditVideo.txt_language_EditVideo.Text = video.Language
                vEditVideo.txt_length_EditVideo.Text = video.Length
                vEditVideo.txt_director_EditVideo.Text = video.Director
                vEditVideo.txt_actor_EditVideo.Text = video.Actor
                vEditVideo.txt_url_EditVideo.Text = video.Photo
                vEditVideo.txt_resume_EditVideo.Text = video.Resume

                vDeleteVideo.txt_id_DeleteVideo.Text = video.VideoID
                vDeleteVideo.txt_title_DeleteVideo.Text = video.Title
                vDeleteVideo.txt_genre_DeleteVideo.Text = video.Genre
                vDeleteVideo.mtx_year_DeleteVideo.Text = video.Year
                vDeleteVideo.txt_country_DeleteVideo.Text = video.Country
                vDeleteVideo.txt_language_DeleteVideo.Text = video.Language
                vDeleteVideo.txt_length_DeleteVideo.Text = video.Length
                vDeleteVideo.txt_director_DeleteVideo.Text = video.Director
                vDeleteVideo.txt_actor_DeleteVideo.Text = video.Actor
                vDeleteVideo.txt_url_DeleteVideo.Text = video.Photo
                vDeleteVideo.txt_resume_DeleteVideo.Text = video.Resume

                vVideoList2.txt_id_LVideo.Text = video.VideoID
                vVideoList2.txt_title_LVideo.Text = video.Title
                vVideoList2.txt_genre_LVideo.Text = video.Genre
                vVideoList2.mtx_year_LVideo.Text = video.Year
                vVideoList2.txt_country_LVideo.Text = video.Country
                vVideoList2.txt_language_LVideo.Text = video.Language
                vVideoList2.txt_length_lVideo.Text = video.Length
                vVideoList2.txt_director_LVideo.Text = video.Director
                vVideoList2.txt_actor_LVideo.Text = video.Actor
                vVideoList2.txt_url_LVideo.Text = video.Photo
                vVideoList2.txt_resume_LVideo.Text = video.Resume

            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return video
    End Function


    ''' <summary>
    ''' search single video
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function getSingleVideo(ByVal id As Integer)
        Dim query As String = "SELECT * FROM vb_videos WHERE video_id = " & id
        Dim video As Integer

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                video = reader.GetString(0)

            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return video
    End Function

    ''' <summary>
    ''' add new video
    ''' </summary>
    ''' <param name="video"></param>
    Public Sub addVideo(ByVal video As videoBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "INSERT INTO vb_videos VALUES(DEFAULT, @photo, @title, @year, @country, @language, @length, @resume, @genre, @actor, @director, @status)"
            cmd.Parameters.AddWithValue("@photo", video.Photo)
            cmd.Parameters.AddWithValue("@title", video.Title)
            cmd.Parameters.AddWithValue("@year", video.Year)
            cmd.Parameters.AddWithValue("@country", video.Country)
            cmd.Parameters.AddWithValue("@language", video.Language)
            cmd.Parameters.AddWithValue("@length", video.Length)
            cmd.Parameters.AddWithValue("@resume", video.Resume)
            cmd.Parameters.AddWithValue("@genre", video.Genre)
            cmd.Parameters.AddWithValue("@actor", video.Actor)
            cmd.Parameters.AddWithValue("@director", video.Director)
            cmd.Parameters.AddWithValue("@status", video.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' edits a single video
    ''' </summary>
    ''' <param name="video"></param>
    Public Sub editVideo(ByVal video As videoBean)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE vb_videos SET photo=@photo, title=@title, year=@year, country=@country, language=@language, length=@length, resume=@resume, genre=@genre, actors=@actor, director=@director, status=@status WHERE video_id='" & vDashboard.video_num_edit & "' "
            cmd.Parameters.AddWithValue("@photo", video.Photo)
            cmd.Parameters.AddWithValue("@title", video.Title)
            cmd.Parameters.AddWithValue("@year", video.Year)
            cmd.Parameters.AddWithValue("@country", video.Country)
            cmd.Parameters.AddWithValue("@language", video.Language)
            cmd.Parameters.AddWithValue("@length", video.Length)
            cmd.Parameters.AddWithValue("@resume", video.Resume)
            cmd.Parameters.AddWithValue("@genre", video.Genre)
            cmd.Parameters.AddWithValue("@actor", video.Actor)
            cmd.Parameters.AddWithValue("@director", video.Director)
            cmd.Parameters.AddWithValue("@status", video.Status)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    ''' <summary>
    ''' deletes a single video
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub deleteVideo(ByVal id As Integer)
        Dim cmd As New MySqlCommand

        Try
            cmd.Connection = Me.connect
            cmd.CommandText = "UPDATE vb_videos SET status = 0 WHERE video_id=@video_id"
            cmd.Parameters.AddWithValue("@video_id", id)

            Dim rowAffected = cmd.ExecuteNonQuery()
            MsgBox("Row Affected : " & rowAffected)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)
        Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
        Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
        Dim img As Image = Image.FromStream(response.GetResponseStream())
        response.Close()
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = img
    End Sub



End Class

