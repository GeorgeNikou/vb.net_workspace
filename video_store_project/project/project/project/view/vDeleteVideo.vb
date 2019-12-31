Imports MySql.Data.MySqlClient

Public Class vDeleteVideo
    Private db As New DBManager()

    Private Sub btn_back_DeleteVideo_Click(sender As Object, e As EventArgs) Handles btn_back_DeleteVideo.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub btn_next_DeleteVideo_Click(sender As Object, e As EventArgs) Handles btn_next_DeleteVideo.Click
        Dim video As Integer = txt_id_DeleteVideo.Text

        Dim video_num As String
        MsgBox(video.ToString, MsgBoxStyle.Information, "Video Info")

        'confirms the users decision
        Dim user_input = MsgBox("Are you certain you want to delete this video?", MsgBoxStyle.YesNo, "Verify delete")
        video_num = vDashboard.video_num_edit ' stores video number

        If user_input = 6 Then
            db.deleteVideo(video)
            MsgBox("Video ID number: " & video_num & " has been successfully deleted.")

            Me.Close()
            vDashboard.Show()
        Else
            MsgBox("No changes were made.", MsgBoxStyle.Information)
        End If
    End Sub
End Class