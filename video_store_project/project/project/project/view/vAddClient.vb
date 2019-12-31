Imports MySql.Data.MySqlClient

Public Class vAddClient

    Private db As New DBManager
    Private client_num As String
    Private valid As Integer
    Private tmp_year As String
    Private tmp_month As String
    Private tmp_day As String

    Private Sub btn_add_NClient_Click(sender As Object, e As EventArgs) Handles btn_add_NClient.Click

        valid = 0

        If txt_fname_NClient.Text.Length > 18 Or txt_fname_NClient.Text = "" Then
            lbl_fname_NClient.Text = "First name length cannot be empty exceed past 18 characters"
            valid += 1
        Else
            lbl_fname_NClient.Text = ""
        End If

        If txt_lname_NClient.Text.Length > 18 Or txt_lname_NClient.Text = "" Then
            lbl_lname_NClient.Text = "Last name length cannot be empty or exceed past 18 characters"
            valid += 1
        Else
            lbl_lname_NClient.Text = ""
        End If

        If txt_email_NClient.Text.Length > 25 Or txt_email_NClient.Text = "" Then
            lbl_email_NClient.Text = "Email length cannot be empty or exceed past 25 characters"
            valid += 1
        Else
            lbl_email_NClient.Text = ""
        End If

        'If txt_age_NClient.Text.Length < 0 Or txt_age_NClient.Text.Length > 115 Then
        '    lbl_age_NClient.Text = "Invalid age entry"
        'Else
        '    lbl_age_NClient.Text = ""
        'End If

        If txt_address_Nclient.Text = "" Then
            lbl_address_Nclient.Text = "Address field cannot remain empty"
            valid += 1
        Else
            lbl_address_Nclient.Text = ""
        End If

        tmp_year = mtx_dob_NClient.Text.Substring(mtx_dob_NClient.Text.Length - 4)
        tmp_month = mtx_dob_NClient.Text.Substring(0, 2)
        tmp_day = mtx_dob_NClient.Text.Substring(3, 2)
        If mtx_dob_NClient.Text.Length < 10 Or tmp_year < 1850 Or tmp_year > 2019 Or tmp_month <= 0 Or tmp_month > 12 Or tmp_day <= 0 Or tmp_day > 31 Then
            lbl_dob_NClient.Text = "Date of birth is invalid"
            valid += 1
        Else
            lbl_dob_NClient.Text = ""
        End If

        If txt_city_Nclient.Text = "" Then
            lbl_city_Nclient.Text = "City name cannot remain empty"
            valid += 1
        Else
            lbl_city_Nclient.Text = ""
        End If

        If txt_province_NClient.Text = "" Then
            lbl_province_NClient.Text = "Province field cannot remain empty"
            valid += 1
        Else
            lbl_province_NClient.Text = ""
        End If

        If txt_id_NClient.Text.Length > 18 Then
            lbl_id_NClient.Text = "Client number cannot be empty or exceed past 18 characters"
            valid += 1
        Else
            lbl_id_NClient.Text = ""
        End If

        If mtx_postal_NClient.Text.Length < 7 Then
            lbl_postal_NClient.Text = "Invalid postal code"
        Else
            lbl_postal_NClient.Text = ""
        End If

        If valid = 0 Then
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
        Else
            MsgBox("One or more fields were filled incorrectly.", MsgBoxStyle.Critical, "Add client error")
        End If
    End Sub

    Private Sub btn_cancel_NClient_Click(sender As Object, e As EventArgs) Handles btn_cancel_NClient.Click
        Me.Close()
        vDashboard.Show()
    End Sub

End Class