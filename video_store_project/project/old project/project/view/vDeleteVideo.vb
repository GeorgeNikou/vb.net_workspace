Public Class vDeleteVideo
    Private Sub btn_back_DeleteVideo_Click(sender As Object, e As EventArgs) Handles btn_back_DeleteVideo.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub btn_next_DeleteVideo_Click(sender As Object, e As EventArgs) Handles btn_next_DeleteVideo.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub vDeleteVideo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class