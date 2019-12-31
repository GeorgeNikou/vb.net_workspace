Imports MySql.Data.MySqlClient
Public Class vAdvanceSearch
    Private db As New DBManager
    Private connectionString = "server=localhost;user id=root;password=;database=bluebuster;"
    Private connect As MySqlConnection
    Public vid_id As Integer = vid_id
    Private Sub vAdvanceSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()


            Dim query As String = "SELECT video_id, title, year, country, language, length, resume, genre, actors, director, status FROM vb_videos ORDER BY video_id DESC"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With Me.dgv_videolist
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "title"
                .Columns(2).HeaderText = "year"
                .Columns(3).HeaderText = "country"
                .Columns(4).HeaderText = "language"
                .Columns(5).HeaderText = "length"
                .Columns(6).HeaderText = "resume"
                .Columns(7).HeaderText = "genre"
                .Columns(8).HeaderText = "actors"
                .Columns(9).HeaderText = "director"
                .Columns(10).HeaderText = "status"

                .Columns(0).Width = 50
                .Columns(1).Width = 90
                .Columns(2).Width = 40
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                .Columns(5).Width = 40
                .Columns(6).Width = 110
                .Columns(7).Width = 60
                .Columns(8).Width = 80
                .Columns(9).Width = 80
                .Columns(10).Width = 40
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Private Sub dgv_videolist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_videolist.CellContentClick
        Dim dg As DataGridView = sender
        Dim vid_ID As Integer = dgv_videolist.Rows(e.RowIndex).Cells(0).Value

        vVideoList2.txt_id_LVideo.Text = vid_ID

        db.fillSingleVideo(vid_ID)

        vVideoList2.Show()

    End Sub

    Private Sub btn_search_videolist_Click(sender As Object, e As EventArgs) Handles btn_search_videolist.Click
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim title = txt_search_videotitle.Text
            Dim year = txt_search_videoyear.Text
            Dim country = txt_search_videocountry.Text
            Dim language = txt_search_videolanguage.Text
            Dim length = txt_search_videolength.Text
            Dim synopsis = txt_search_videoresume.Text
            Dim genre = txt_search_videogenre.Text
            Dim actor = txt_search_videoactor.Text
            Dim director = txt_search_videodirector.Text


            Dim query As String = "SELECT video_id, title, year, country, language, length, resume, genre, actors, director, status FROM vb_videos WHERE title like '%" & title & "%' AND year like '%" & year & "%' AND country like '%" & country & "%' AND language like '%" & language & "%' AND length like '%" & length & "%' AND resume like '%" & synopsis & "%' AND genre like '%" & genre & "%' AND actors like '%" & actor & "%' AND director like '%" & director & "%'"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With Me.dgv_videolist
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "title"
                .Columns(2).HeaderText = "year"
                .Columns(3).HeaderText = "country"
                .Columns(4).HeaderText = "language"
                .Columns(5).HeaderText = "length"
                .Columns(6).HeaderText = "resume"
                .Columns(7).HeaderText = "genre"
                .Columns(8).HeaderText = "actors"
                .Columns(9).HeaderText = "director"
                .Columns(10).HeaderText = "status"

                .Columns(0).Width = 50
                .Columns(1).Width = 90
                .Columns(2).Width = 40
                .Columns(3).Width = 80
                .Columns(4).Width = 80
                .Columns(5).Width = 40
                .Columns(6).Width = 110
                .Columns(7).Width = 77
                .Columns(8).Width = 80
                .Columns(9).Width = 80
                .Columns(10).Width = 40

            End With






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub
End Class