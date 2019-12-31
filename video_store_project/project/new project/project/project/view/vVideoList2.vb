Imports MySql.Data.MySqlClient
Public Class vVideoList2
    Private db As New DBManager
    Private db_employee As New DBManagerEmployee
    Public client As New clientBean
    Public client_num_rent As String
    Public video As New videoBean
    Private Sub vVideoList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db.LoadImageFromUrl(txt_url_LVideo.Text, Me.PictureBox1)
    End Sub

    Private Sub btn_back_ListVideo_Click(sender As Object, e As EventArgs) Handles btn_back_ListVideo.Click
        Me.Close()
    End Sub

    Private Sub btn_rent_RentVideo_Click(sender As Object, e As EventArgs) Handles btn_rent_RentVideo.Click
        client_num_rent = InputBox("Please enter the client ID number: ", "Rent Video")
        If client_num_rent.ToString = "" Then
            MsgBox("Invalid entry. Empty input detected.", MsgBoxStyle.Critical)
        ElseIf Not IsNumeric(client_num_rent) OrElse db.getSingleClient(client_num_rent) <= 0 Then
            MsgBox("Invalid entry. Video ID does not exist.", MsgBoxStyle.Critical)
        ElseIf client_num_rent >= 1 Then
            video = db_employee.getVideoByID(CInt(txt_id_LVideo.Text))
            If video.VideoID <> 0 Then

                If video.Status = 1 Then
                    Dim video As New videoBean(txt_id_LVideo.Text,
                                    txt_url_LVideo.Text,
                                    txt_title_LVideo.Text,
                                    mtx_year_LVideo.Text,
                                    txt_country_LVideo.Text,
                                    txt_language_LVideo.Text,
                                    txt_length_LVideo.Text,
                                    txt_resume_LVideo.Text,
                                    txt_genre_LVideo.Text,
                                    txt_actor_LVideo.Text,
                                    txt_director_LVideo.Text,
                                    1)
                    client = db_employee.getClientByNo(client_num_rent)
                    btn_rent_RentVideo.Enabled = False

                    db_employee.rentVideo(client.Id, video.VideoID, System.DateTime.Now)
                    db_employee.de_rentVideo(video.VideoID, 2)
                    MsgBox("Video been rented")
                    vDashboard.Show()
                    Me.Close()

                    MsgBox(video.ToString, MsgBoxStyle.Information, "Video Info")
                Else
                    MsgBox("video has already been rented")
                End If


            End If
        End If
    End Sub
End Class