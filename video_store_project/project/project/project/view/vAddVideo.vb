Public Class vAddVideo

    Private db As New DBManager



    Private Sub btn_next_NVideo_Click(sender As Object, e As EventArgs) Handles btn_next_NVideo.Click
        If txt_title_NVideo.Text = "" OrElse txt_title_NVideo.Text.Length > 100 Then
            MsgBox("Invalid length for the Title")
        ElseIf txt_genre_NVideo.Text = "" OrElse txt_title_NVideo.Text.Length > 255 Then
            MsgBox("Invalid length for the Genre")
        ElseIf mtx_year_NVideo.Text = "" OrElse mtx_year_NVideo.Text.Length < 4 OrElse mtx_year_NVideo.Text > System.DateTime.Now.Year Then
            MsgBox("Invalid Year")
        ElseIf txt_country_NVideo.Text = "" OrElse IsNumeric(txt_country_NVideo.Text) Or txt_country_NVideo.Text.Length > 50 Then
            MsgBox("Invalid Country")
        ElseIf txt_language_NVideo.Text = "" OrElse txt_language_NVideo.Text.Length > 50 Then
            MsgBox("Invalid length for the Language")
        ElseIf txt_length_NVideo.Text = "" OrElse txt_length_NVideo.Text.Length > 10 Then
            MsgBox("Invalid movie Length")
        ElseIf txt_director_NVideo.Text = "" OrElse txt_director_NVideo.Text.Length > 50 Then
            MsgBox("Invalid length for the Director")
        ElseIf txt_actor_NVideo.Text = "" Then
            MsgBox("Invalid length for the Actors")
        ElseIf txt_resume_NVideo.Text = "" OrElse IsNumeric(txt_resume_NVideo.Text) Then
            MsgBox("Invalid length for the Synopsis")
        Else
            Dim vid As New videoBean(txt_url_NVideo.Text, txt_title_NVideo.Text, mtx_year_NVideo.Text, txt_country_NVideo.Text, txt_language_NVideo.Text, CInt(txt_length_NVideo.Text), txt_resume_NVideo.Text, txt_genre_NVideo.Text, txt_actor_NVideo.Text, txt_director_NVideo.Text, 1)
            db.addVideo(vid)
            MsgBox(vid.ToString, MsgBoxStyle.Information, "video added")

            Me.Close()
            vDashboard.Show()
        End If
    End Sub

    Private Sub txt_length_NVideo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_length_NVideo.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btn_back_NVideo_Click(sender As Object, e As EventArgs) Handles btn_back_NVideo.Click
        Me.Hide()
        vDashboard.Show()
    End Sub
End Class