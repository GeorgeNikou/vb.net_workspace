Imports MySql.Data.MySqlClient
Public Class vVideoList2
    Private db As New DBManager
    Private Sub vVideoList2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        db.LoadImageFromUrl(txt_url_LVideo.Text, Me.PictureBox1)
    End Sub

    Private Sub btn_back_ListVideo_Click(sender As Object, e As EventArgs) Handles btn_back_ListVideo.Click
        Me.Close()
    End Sub
End Class