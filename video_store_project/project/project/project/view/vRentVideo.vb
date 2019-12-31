Public Class vRentVideo
    Dim db As New DBManagerEmployee
    Dim cnolist As New ArrayList
    Dim vidlist As New List(Of Integer)
    Dim client As New clientBean
    Dim video As New videoBean
    Dim cnoClick, vidClick As Boolean

    Private Sub vRentVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnolist = db.getClientnos
    End Sub

    Private Sub btn_rent_RentVideo_Click(sender As Object, e As EventArgs) Handles btn_rent_RentVideo.Click
        Dim errmsg = ""

        If String.IsNullOrEmpty(txt_Client_RentVideo.Text) Then
            errmsg += vbNewLine & "Please enter client number"
        ElseIf String.IsNullOrEmpty(txt_Video_RentVideo.Text) Then
            errmsg += vbNewLine & "Please enter video ID"
        Else
            db.rentVideo(client.Id, video.VideoID, System.DateTime.Now)
            db.de_rentVideo(video.VideoID, 2)
            MsgBox("Video been rent")
            vDashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub pb_poster_RentVideo_Click(sender As Object, e As EventArgs) Handles pb_poster_RentVideo.Click
        Me.Dispose()
    End Sub

    Private Sub pb_Vid_RentVideo_Click(sender As Object, e As EventArgs) Handles pb_Vid_RentVideo.Click
        If Not String.IsNullOrEmpty(txt_Video_RentVideo.Text) Then
            video = db.getVideoByID(CInt(txt_Video_RentVideo.Text))
            If video.VideoID <> 0 Then

                If video.Status = 1 Then
                    txt_title_RentVideo.Text = video.Title
                    txt_title_RentVideo.Enabled = False
                    txt_language_RentVideo.Text = video.Language
                    txt_language_RentVideo.Enabled = False
                    txt_director_RentVideo.Text = video.Director
                    txt_director_RentVideo.Enabled = False
                    txt_Resume_RentVideo.Text = video.Resume
                    txt_Resume_RentVideo.Enabled = False
                    LoadImageFromUrl(video.Photo, pb_poster_RentVideo)
                Else
                    MsgBox("video has already been rented")
                End If
            Else
                MsgBox("Unvalidated video")
            End If
        Else
            MsgBox("Please enter a video number")
        End If
    End Sub

    Public Sub LoadImageFromUrl(ByRef url As String, ByVal pb As PictureBox)
        Dim request As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(url), Net.HttpWebRequest)
        Dim response As Net.HttpWebResponse = DirectCast(request.GetResponse, Net.HttpWebResponse)
        Dim img As Image = Image.FromStream(response.GetResponseStream())
        response.Close()
        pb.SizeMode = PictureBoxSizeMode.StretchImage
        pb.Image = img
    End Sub

    Private Sub btn_cancel_RentVideo_Click(sender As Object, e As EventArgs) Handles btn_cancel_RentVideo.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub pb_Cid_RentVideo_Click(sender As Object, e As EventArgs) Handles pb_Cid_RentVideo.Click
        cnoClick = True
        If cnolist.Contains(txt_Client_RentVideo.Text) Then
            client = db.getClientByNo(txt_Client_RentVideo.Text)
            txt_name_RentVideo.Text = client.Fname & " " & client.Lname
            txt_name_RentVideo.Enabled = False
            txt_address_RentVideo.Text = client.Address
            txt_address_RentVideo.Enabled = False
            mtx_number_RentVideo.Text = client.Phone
            mtx_number_RentVideo.Enabled = False
        Else
            MsgBox("Client number isn't existed in the system")
        End If
    End Sub
End Class