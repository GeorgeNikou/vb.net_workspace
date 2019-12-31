Public Class vAddClient
    Dim dbs As New DBManager

    Private Sub vAddClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbs.testConnection()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class