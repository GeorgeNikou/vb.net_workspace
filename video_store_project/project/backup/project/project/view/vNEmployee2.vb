Public Class vNEmployee2

    Private Sub btn_next_NEmployee2_Click(sender As Object, e As EventArgs) Handles btn_next_NEmployee2.Click
        Me.Hide()
        vNEmployee3.Show()
    End Sub

    Private Sub btn_back_NEmployee2_Click(sender As Object, e As EventArgs) Handles btn_back_NEmployee2.Click
        Me.Hide()
        vNEmployee1.Show()
    End Sub
End Class