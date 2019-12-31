Imports MySql.Data.MySqlClient

Public Class vAddClient

    Private db As New DBManager
    Private client_num As String

    Private Sub btn_add_NClient_Click(sender As Object, e As EventArgs) Handles btn_add_NClient.Click

        Dim client As New clientBean(txt_id_NClient.Text,
                                     txt_fname_NClient.Text,
                                     txt_lname_NClient.Text,
                                     txt_email_NClient.Text,
                                     mtx_number_NClient.Text,
                                     CDate(mtx_dob_NClient.Text),
                                     txt_address_Nclient.Text,
                                     txt_city_Nclient.Text,
                                     txt_province_NClient.Text,
                                     mtx_postal_NClient.Text,
                                     1)

        MsgBox(client.ToString, MsgBoxStyle.Information, "Client Info")

        'confirms the users decision
        Dim user_input = MsgBox("Are you certain you want to add this new client to Bluebuster?", MsgBoxStyle.YesNo, "Verify addition")
        client_num = txt_id_NClient.Text ' stores client number

        If user_input = 6 Then

            db.addClient(client)

            MsgBox("Client ID number: " & client_num & " has been successfully added.")
            Me.Close()
            vDashboard.Show()
        Else
            MsgBox("No changes were made.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btn_cancel_NClient_Click(sender As Object, e As EventArgs) Handles btn_cancel_NClient.Click
        Me.Close()
        vDashboard.Show()
    End Sub

End Class