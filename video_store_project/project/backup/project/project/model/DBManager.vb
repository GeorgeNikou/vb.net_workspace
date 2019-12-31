Imports MySql.Data.MySqlClient
Public Class DBManager

    Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    Private connect As MySqlConnection

    Public Sub New()
        Try
            Me.connect = New MySqlConnection(connectionString)
            Me.connect.Open()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try
    End Sub

    Public Sub testConnection()
        If Me.connect.State = ConnectionState.Open Then
            MsgBox("connect successfuly")
        Else
            MsgBox("not connected....")
        End If
    End Sub

    Public Function getAllUsers()
        Dim query As String = "SELECT * FROM users WHERE status = 1"
        Dim dataset As New DataSet

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return dataset.Tables("users").Rows
    End Function

    Public Function getAllUsersList() As List(Of clientBean)
        Dim query As String = "SELECT * FROM users WHERE status = 1"
        Dim dataset As New DataSet
        Dim userlist As New List(Of clientBean)

        Try
            Dim cmd As New MySqlCommand(query, Me.connect)
            Dim adapter As New MySqlDataAdapter(cmd)

            adapter.Fill(dataset, "users")

            For Each row As DataRow In dataset.Tables("clients").Rows
                userlist.Add(New clientBean(row("fname"), row("lname"), row("email"), row("phone"), row("dob"), row("age"), row("address"), row("city"), row("province"), row("postal"), row("status"), row("level")))
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Failed")
        End Try

        Return userlist
    End Function

End Class
