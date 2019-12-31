Imports MySql.Data.MySqlClient

Public Class vEditClient

    'Private connectionString = "server=localhost;user id=root;password=;database=blueBuster;"
    'Private connect As MySqlConnection
    Private db As New DBManager


    Private Sub vEditClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ''' <summary>
    ''' edit client
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_save_EClient_Click(sender As Object, e As EventArgs) Handles btn_save_EClient.Click
        Dim client As New clientBean(txt_id_EClient.Text,
                                     txt_fname_EClient.Text,
                                     txt_lname_EClient.Text,
                                     txt_email_EClient.Text,
                                     mtx_number_EClient.Text,
                                     mtx_dob_EClient.Text,
                                     txt_address_Eclient.Text,
                                     txt_city_Eclient.Text,
                                     txt_province_EClient.Text,
                                     mtx_postal_EClient.Text,
                                     1)

        Dim client_num As String
        MsgBox(client.ToString, MsgBoxStyle.Information, "Client Info")

        'confirms the users decision
        Dim user_input = MsgBox("Are you certain you want to edit this client?", MsgBoxStyle.YesNo, "Verify edit")
        client_num = txt_id_EClient.Text ' stores client number

        If user_input = 6 Then
            db.editClient(client)
            MsgBox("Client ID number: " & client_num & " has been successfully edited.")

            Me.Close()
            vDashboard.Show()
        Else
            MsgBox("No changes were made.", MsgBoxStyle.Information)
        End If

    End Sub

    ''' <summary>
    ''' cancel button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_cancel_EClient_Click(sender As Object, e As EventArgs) Handles btn_cancel_EClient.Click
        Me.Close()
        vDashboard.Show()
    End Sub


End Class