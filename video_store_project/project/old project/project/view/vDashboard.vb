Public Class vDashboard
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        Me.Close()
        vNEmployee1.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Me.Close()
        vEditEmployee.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.Close()
        vDeleteEmployee.Show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        Me.Close()
        vEditVideo.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        Me.Close()
        vDeleteVideo.Show()
    End Sub

    Private Sub vDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class