Imports MySql.Data.MySqlClient

Public Class vClientList

    Private db As New DBManager
    Private connectionString = "server=localhost;user id=root;password=;database=bluebuster;"
    Private connect As MySqlConnection

    Private Sub btn_back_clientlist_Click(sender As Object, e As EventArgs) Handles btn_back_clientlist.Click
        Me.Close()
        vDashboard.Show()
    End Sub

    Private Sub vClientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()


            Dim query As String = "SELECT * FROM clients WHERE status = 1"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With Me.dgv_clientlist
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "client #"
                .Columns(2).HeaderText = "first name"
                .Columns(3).HeaderText = "last name"
                .Columns(4).HeaderText = "email"
                .Columns(5).HeaderText = "phone"
                .Columns(6).HeaderText = "dob"
                .Columns(7).HeaderText = "address"
                .Columns(8).HeaderText = "city"
                .Columns(9).HeaderText = "province"
                .Columns(10).HeaderText = "postal"
                .Columns(11).HeaderText = "status"


                .Columns(0).Width = 50
                .Columns(1).Width = 60
                .Columns(2).Width = 60
                .Columns(3).Width = 60
                .Columns(4).Width = 110
                .Columns(5).Width = 80
                .Columns(6).Width = 80
                .Columns(7).Width = 110
                .Columns(8).Width = 60
                .Columns(9).Width = 30
                .Columns(10).Width = 80
                .Columns(11).Width = 30
            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Private Sub btn_search_clientlist_Click(sender As Object, e As EventArgs) Handles btn_search_clientlist.Click

        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()

            Dim name = txt_search_clientlist.Text

            Dim query As String = "SELECT * FROM clients WHERE fname like '" & name & "' OR client_number = '" & name & "'"
            Dim datatable As New DataTable()

            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(datatable)

            With Me.dgv_clientlist
                .DataSource = datatable

                .Columns(0).HeaderText = "ID"
                .Columns(1).HeaderText = "client #"
                .Columns(2).HeaderText = "first name"
                .Columns(3).HeaderText = "last name"
                .Columns(4).HeaderText = "email"
                .Columns(5).HeaderText = "phone"
                .Columns(6).HeaderText = "dob"
                .Columns(7).HeaderText = "address"
                .Columns(8).HeaderText = "city"
                .Columns(9).HeaderText = "province"
                .Columns(10).HeaderText = "postal"
                .Columns(11).HeaderText = "status"


                .Columns(0).Width = 50
                .Columns(1).Width = 60
                .Columns(2).Width = 60
                .Columns(3).Width = 60
                .Columns(4).Width = 110
                .Columns(5).Width = 80
                .Columns(6).Width = 80
                .Columns(7).Width = 110
                .Columns(8).Width = 60
                .Columns(9).Width = 30
                .Columns(10).Width = 80
                .Columns(11).Width = 30


            End With


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

    End Sub
End Class