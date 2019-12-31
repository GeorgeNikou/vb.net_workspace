Imports MySql.Data.MySqlClient

Public Class vDashboard
    'application.restart

    Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    Private connect As MySqlConnection
    Public db As New DBManager
    Public client_num_edit As String
    Public client_num_del As String
    Public video_num_edit As String
    Public video_num_del As String

    Private Sub vDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'db.testConnection()
        Me.dgv_dashboard_topclients.Font = New Font("Segoe UI", 9)
        Me.dgv_dashboard_topvideos.Font = New Font("Segoe UI", 9)

        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT * FROM clients WHERE status = 1 LIMIT 10"
            Dim datatable1 As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable1)

            With dgv_dashboard_topclients
                .DataSource = datatable1

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "client #"
                .Columns(2).HeaderText = "first name"
                .Columns(3).HeaderText = "last name"
                .Columns(4).HeaderText = "email"
                .Columns(5).HeaderText = "phone"
                .Columns(6).HeaderText = "dob"
                .Columns(7).HeaderText = "address"
                .Columns(8).HeaderText = "city"
                .Columns(9).HeaderText = "province"
                .Columns(10).HeaderText = "postal"
                .Columns(11).HeaderText = "status"


                .Columns(0).Width = 30
                .Columns(1).Width = 60
                .Columns(2).Width = 60
                .Columns(3).Width = 60
                .Columns(4).Width = 200
                .Columns(5).Width = 80
                .Columns(6).Width = 80
                .Columns(7).Width = 110
                .Columns(8).Width = 60
                .Columns(9).Width = 60
                .Columns(10).Width = 60
                .Columns(11).Width = 40
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim query As String = "SELECT * FROM videos WHERE status = 1 LIMIT 10"
            Dim datatable2 As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable2)

            With dgv_dashboard_topvideos
                .DataSource = datatable2

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "photo"
                .Columns(2).HeaderText = "title"
                .Columns(3).HeaderText = "year"
                .Columns(4).HeaderText = "country"
                .Columns(5).HeaderText = "language"
                .Columns(6).HeaderText = "length"
                .Columns(7).HeaderText = "resume"
                .Columns(8).HeaderText = "genre"
                .Columns(9).HeaderText = "actors"
                .Columns(10).HeaderText = "director"
                .Columns(11).HeaderText = "status"


                .Columns(0).Width = 60
                .Columns(1).Width = 160
                .Columns(2).Width = 60
                .Columns(3).Width = 60
                .Columns(4).Width = 60
                .Columns(5).Width = 60
                .Columns(6).Width = 50
                .Columns(7).Width = 110
                .Columns(8).Width = 60
                .Columns(9).Width = 100
                .Columns(10).Width = 60
                .Columns(11).Width = 40
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Private Sub CreateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem1.Click
        Me.Hide()
        vAddClient.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        client_num_edit = InputBox("Please enter the client ID number: ", "BlueBuster Edit Client")
        db.clientExistsEdit(client_num_edit)

        If client_num_edit.ToString = "" Then
            MsgBox("Invalid entry. Empty input detected.", MsgBoxStyle.Critical)
        ElseIf IsNumeric(client_num_edit) AndAlso client_num_edit <= 0 Then
            MsgBox("Invalid entry. Negative ID numbers do not exist.", MsgBoxStyle.Critical)
        ElseIf IsNumeric(client_num_edit) AndAlso client_num_edit >= 1 Then
            vEditClient.txt_shownum_EClient.Text = client_num_edit
            vEditClient.txt_shownum_EClient.ReadOnly = True

            db.fillSingleClient(vEditClient.txt_shownum_EClient.Text)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        client_num_del = InputBox("Please enter the employee ID you would to delete: ", "Delete Client")
        db.clientExistsDelete(client_num_del)

        If client_num_del.ToString = "" Then
            MsgBox("Invalid entry. Empty input detected.", MsgBoxStyle.Critical)
        ElseIf IsNumeric(client_num_del) AndAlso client_num_del <= 0 Then
            MsgBox("Invalid entry. Negative ID numbers do not exist.", MsgBoxStyle.Critical)
        ElseIf IsNumeric(client_num_del) AndAlso client_num_del >= 1 Then
            'txt_shownum_DClient

            vDeleteClient.txt_shownum_DClient.Text = client_num_del
            vDeleteClient.txt_shownum_DClient.Enabled = True

            db.fillSingleClient(vDeleteClient.txt_shownum_DClient.Text)
        End If
    End Sub

    Private Sub ListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem1.Click
        Me.Close()
        vClientList.Show()
    End Sub

    Private Sub QuickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickToolStripMenuItem.Click
        vSearch.Show()
    End Sub
    Private Sub AdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvanceToolStripMenuItem.Click
        vAdvanceSearch.Show()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        vLogin.txt_username_login.Text = ""
        vLogin.txt_password_login.Text = ""

        Dim input = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Logout")
        If input = 6 Then
            Me.Close()
            vLogin.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim input = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit")
        If input = 6 Then
            vLogin.Close()
        End If
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        MsgBox("Bluebuster is a total rip off of the once beloved and now shut down Blockbusters. We pretty much try to be exactly like Blockbuster and in some way we are, but so much worse!")
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Me.Hide()
        vEmployeeList.Show()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        vNEmployee1.Show()
    End Sub




    Private Sub ListToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem2.Click
        Me.Hide()
        vVideoList.Show()
    End Sub

    Private Sub CreateToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem2.Click
        Me.Close()
        vAddVideo.Show()
    End Sub


    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        video_num_edit = InputBox("Please enter the video ID number: ", "Edit Video")


        If video_num_edit.ToString = "" Then
            MsgBox("Invalid entry. Empty input detected.", MsgBoxStyle.Critical)
        ElseIf db.getSingleVideo(video_num_edit) <= 0 Then
            MsgBox("Invalid entry. Video ID does not exist.", MsgBoxStyle.Critical)
        ElseIf video_num_edit >= 1 Then
            vEditVideo.txt_id_EVideo.Text = video_num_edit

            db.fillSingleVideo(vEditVideo.txt_id_EVideo.Text)

            Me.Hide()
            vEditVideo.Show()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        video_num_del = InputBox("Please enter the video ID number: ", "Delete Video")

        If video_num_del.ToString = "" Then
            MsgBox("Invalid entry. Empty input.", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(video_num_del) OrElse db.getSingleVideo(video_num_del) <= 0 Then
            MsgBox("Invalid entry. Video ID does not exist.", MsgBoxStyle.Critical)
        ElseIf video_num_del >= 1 Then
            vDeleteVideo.txt_id_DeleteVideo.Text = video_num_del

            db.fillSingleVideo(vDeleteVideo.txt_id_DeleteVideo.Text)

            Me.Hide()
            vDeleteVideo.Show()
        End If
    End Sub

    Private Sub RentVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentVideoToolStripMenuItem.Click
        Me.Hide()
        vRentVideo.Show()
    End Sub

    Private Sub ReturnVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnVideoToolStripMenuItem.Click
        Me.Hide()
        vReturnVideo.Show()
    End Sub
End Class