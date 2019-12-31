Imports MySql.Data.MySqlClient
Public Class vEditVideo
    Private db As New DBManager

    Private Sub btn_back_EditVideo_Click(sender As Object, e As EventArgs) Handles btn_back_EditVideo.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub vEditVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_length_EditVideo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_length_EditVideo.KeyPress

        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btn_next_EditVideo_Click(sender As Object, e As EventArgs) Handles btn_next_EditVideo.Click
        If txt_title_EditVideo.Text = "" OrElse txt_title_EditVideo.Text.Length > 255 Then
            MsgBox("Invalid length for the Title")
        ElseIf txt_genre_EditVideo.Text = "" OrElse txt_title_EditVideo.Text.Length > 255 Then
            MsgBox("Invalid length for the Genre")
        ElseIf mtx_year_EditVideo.Text = "" OrElse mtx_year_EditVideo.Text.Length < 4 OrElse mtx_year_EditVideo.Text > System.DateTime.Now.Year Then
            MsgBox("Invalid Year")
        ElseIf txt_country_EditVideo.Text = "" OrElse IsNumeric(txt_country_EditVideo.Text) Or txt_country_EditVideo.Text.Length > 255 Then
            MsgBox("Invalid Country")
        ElseIf txt_language_EditVideo.Text = "" OrElse txt_language_EditVideo.Text.Length > 50 Then
            MsgBox("Invalid length for the Language")
        ElseIf txt_length_EditVideo.Text = "" OrElse txt_length_EditVideo.Text.Length > 10 Then
            MsgBox("Invalid movie Length")
        ElseIf txt_director_EditVideo.Text = "" OrElse txt_director_EditVideo.Text.Length > 255 Then
            MsgBox("Invalid length for the Director")
        ElseIf txt_actor_EditVideo.Text = "" Then
            MsgBox("Invalid length for the Actors")
        ElseIf txt_resume_EditVideo.Text = "" OrElse IsNumeric(txt_resume_EditVideo.Text) Then
            MsgBox("Invalid input for the Synopsis")
        Else
            Dim video As New videoBean(txt_id_EVideo.Text,
                                     txt_url_EditVideo.Text,
                                     txt_title_EditVideo.Text,
                                     mtx_year_EditVideo.Text,
                                     txt_country_EditVideo.Text,
                                     txt_language_EditVideo.Text,
                                     txt_length_EditVideo.Text,
                                     txt_resume_EditVideo.Text,
                                     txt_genre_EditVideo.Text,
                                     txt_actor_EditVideo.Text,
                                     txt_director_EditVideo.Text,
                                     1)

            Dim video_num As String
            MsgBox(video.ToString, MsgBoxStyle.Information, "Video Info")

            'confirms the users decision
            Dim user_input = MsgBox("Are you certain you want to edit this video?", MsgBoxStyle.YesNo, "Verify edit")
            video_num = vDashboard.video_num_edit ' stores video number

            If user_input = 6 Then
                db.editVideo(video)
                MsgBox("Video ID number: " & video_num & " has been successfully edited.")

                Me.Close()
                vDashboard.Show()
            Else
                MsgBox("No changes were made.", MsgBoxStyle.Information)
            End If
        End If
    End Sub
End Class