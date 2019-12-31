Imports MySql.Data.MySqlClient

Public Class vReturnVideo
    Dim db As New DBManagerEmployee
    Dim client As New clientBean
    Dim video As New videoBean

    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)
        Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
        Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
        Dim img As Image = Image.FromStream(response.GetResponseStream())
        response.Close()
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = img
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_video_return.SelectedIndexChanged
        Dim MysqlConnect = New MySqlConnection
        MysqlConnect.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim READER As MySqlDataReader
        Try
            MysqlConnect.Open()
            Dim Query As String
            Query = "select *  from blueBuster.rents As r INNER JOIN vb_videos AS v INNER JOIN clients As c  ON r.video_fk=v.video_id AND c.client_number=r.client_fk  where title=@title"
            Dim Cmd = New MySqlCommand(Query, MysqlConnect)
            Cmd.Parameters.AddWithValue("@title", cbo_video_return.Text)
            READER = Cmd.ExecuteReader()

            While READER.Read()
                btn_rent_ReturnVideo.Enabled = True
                mtx_RDate_ReturnVideo.Text = READER.GetDateTime("rent_date")
                mtx_RDate_ReturnVideo.Enabled = False
                txt_Cname_ReturnVideo.Text = READER.GetString("video_id")
                txt_Cname_ReturnVideo.Enabled = False
                txt_CNo_ReturnVideo.Text = READER.GetString("client_number")
                txt_CNo_ReturnVideo.Enabled = False
                LoadImageFromUrl(READER.GetString("photo"), pb_poster_ReturnVideo)
                txt_Cname_ReturnVideo.Text = READER.GetString("fname") & " " & READER.GetString("lname")
            End While

            MysqlConnect.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConnect.Dispose()
        End Try
    End Sub

    Private Sub btn_rent_ReturnVideo_Click(sender As Object, e As EventArgs) Handles btn_rent_ReturnVideo.Click
        Dim MysqlConn = New MySqlConnection

        MysqlConn.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        MysqlConn.Open()

        Dim command1 As New MySqlCommand("UPDATE vb_videos SET status=1 WHERE title='" & cbo_video_return.Text & "'", MysqlConn)
        Dim command2 As New MySqlCommand("DELETE FROM rents where video_fk='" & txt_Cname_ReturnVideo.Text & "'", MysqlConn)


        command1.ExecuteNonQuery()
        command2.ExecuteNonQuery()
        MsgBox("THANK YOU ")
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        vReturnVideo_Load(e, e)
        Refresh()
        MysqlConn.Close()

    End Sub

    Private Sub vReturnVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_rent_ReturnVideo.Enabled = False
        Dim MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;user id=root;password=;database=blueBuster;"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select *  from blueBuster.rents As r INNER JOIN vb_videos AS v ON r.video_fk=v.video_id "
            Dim Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader
            While READER.Read
                Dim title = READER.GetString("title")

                cbo_video_return.Items.Add(title)
            End While
            MysqlConn.Close()
            READER.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub



    Private Sub btn_cancel_ReturnVideo_Click(sender As Object, e As EventArgs) Handles btn_cancel_ReturnVideo.Click
        Me.Close()
        vDashboard.Show()
    End Sub
End Class