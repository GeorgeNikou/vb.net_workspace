Imports MySql.Data.MySqlClient


Public Class test
    Dim dbs As New DBManager
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dg As DataGridView = sender
        MsgBox(Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datatable As New DataTable()
        dbs.testConnection()
        dbs.clients()

    End Sub
End Class