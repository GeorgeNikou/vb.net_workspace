Imports MySql.Data.MySqlClient

Public Class VEmployeeList
    Private db As New DBManager
    Private connectionString = "server=localhost;user id=root;password=;database=bluebuster;"
    Private connect As MySqlConnection
    Dim dbs As New DBManagerEmployee
    Private Sub VEmployeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datatable As New DataTable()
        dbs.testConnection()
        dbs.Employee()
    End Sub

    Private Sub dgv_employeelist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_employeelist.CellContentClick
        Dim dg As DataGridView = sender
        MsgBox(Me.dgv_employeelist.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub btn_search_employeelist_Click(sender As Object, e As EventArgs) Handles btn_search_employeelist.Click
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim name = txt_search_clientlist.Text

            Dim query As String = "SELECT * FROM users WHERE fname like '" & name & "' OR employee_number = '" & name & "'"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With Me.dgv_employeelist
                .DataSource = datatable


                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "Emp_Num"
                .Columns(2).HeaderText = "Username"
                .Columns(3).HeaderText = "Password"
                .Columns(4).HeaderText = "Fname"
                .Columns(5).HeaderText = "Lname"
                .Columns(6).HeaderText = "DOB"
                .Columns(7).HeaderText = "Address"
                .Columns(8).HeaderText = "City"
                .Columns(9).HeaderText = "Province"
                .Columns(10).HeaderText = "Code"
                .Columns(11).HeaderText = "HomePhone"
                .Columns(12).HeaderText = "Cellphone"
                .Columns(13).HeaderText = "StartDate"
                .Columns(14).HeaderText = "SIN"
                .Columns(15).HeaderText = "Pay"
                .Columns(16).HeaderText = "Education"
                .Columns(17).HeaderText = "Level"
                .Columns(18).HeaderText = "Status"


                .Columns(0).Width = 30
                .Columns(1).Width = 80
                .Columns(2).Width = 80
                .Columns(3).Width = 60
                .Columns(4).Width = 60
                .Columns(5).Width = 60
                .Columns(6).Width = 80
                .Columns(7).Width = 100
                .Columns(8).Width = 80
                .Columns(9).Width = 80
                .Columns(10).Width = 80
                .Columns(11).Width = 80
                .Columns(12).Width = 80
                .Columns(13).Width = 80
                .Columns(14).Width = 80
                .Columns(15).Width = 80
                .Columns(16).Width = 80
                .Columns(17).Width = 60
                .Columns(18).Width = 60


            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Private Sub btn_back_employeelistlist_Click(sender As Object, e As EventArgs) Handles btn_back_employeelistlist.Click
        Me.Close()
        vDashboard.Show()
    End Sub
End Class