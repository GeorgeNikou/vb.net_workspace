﻿Public Class vEditEmployee
    Private Sub btn_back_NEmployee2_Click(sender As Object, e As EventArgs) Handles btn_back_EditEmployee.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub btn_next_NEmployee2_Click(sender As Object, e As EventArgs) Handles btn_next_EditEmployee.Click
        Me.Close()
        vDashboard.Show()
    End Sub
End Class