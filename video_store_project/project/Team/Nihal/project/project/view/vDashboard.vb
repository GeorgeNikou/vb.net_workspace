Imports MySql.Data.MySqlClient

Public Class vDashboard
    Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    Private connect As MySqlConnection
    Public db As New DBManager
    Public employee_num_edit As String
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        Me.Hide()
        vNEmployee1.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        'employee_num_edit = InputBox("Please enter the Employee ID number: ", "Edit Employee")
        'If employee_num_edit.ToString = "" Then
        '    MsgBox("Invalid entry. Empty input detected.", MsgBoxStyle.Critical)
        'ElseIf employee_num_edit <= 0 Then
        '    MsgBox("Invalid entry. Negative ID numbers do not exist.", MsgBoxStyle.Critical)
        'ElseIf employee_num_edit >= 1 Then
        '    vEditEmployee.TextBox1.Text = employee_num_edit
        '    vEditEmployee.TextBox1.ReadOnly = True
        '    Me.Hide()
        '    vEditEmployee.Show()
        'End If
        Me.Hide()
        vEditEmployee.Show()
    End Sub

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Me.Hide()
        VEmployeeList.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.Hide()
        vDeleteEmployee.Show()
    End Sub

    Private Sub RentVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentVideoToolStripMenuItem.Click
        Me.Hide()
        vRentVideo.Show()
    End Sub

    Private Sub ReturnVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnVideoToolStripMenuItem.Click
        Me.Hide()
        vReturnVideo.Show()
    End Sub
End Class