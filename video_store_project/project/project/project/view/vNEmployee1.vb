Public Class vNEmployee1

    Private Sub btn_next_NEmployee1_Click(sender As Object, e As EventArgs) Handles btn_next_NEmployee1.Click
        If txt_fname_NEmployee1.Text = "" OrElse IsNumeric(txt_fname_NEmployee1.Text) = True OrElse txt_fname_NEmployee1.Text.Length > 6 Then
            txt_fname_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter first name")
        ElseIf txt_lname_NEmployee1.Text = "" OrElse IsNumeric(txt_lname_NEmployee1.Text) = True OrElse txt_lname_NEmployee1.Text.Length > 6 Then
            txt_lname_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter Lastname")
        ElseIf txt_address_NEmployee1.Text = "" OrElse IsNumeric(txt_address_NEmployee1.Text) = True OrElse txt_address_NEmployee1.Text.Length > 15 Then
            txt_address_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter Address")
        ElseIf txt_city_NEmployee1.Text = "" OrElse IsNumeric(txt_city_NEmployee1.Text) = True OrElse txt_city_NEmployee1.Text.Length > 6 Then
            txt_city_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter City")
        ElseIf txt_province_NEmployee1.Text = "" OrElse IsNumeric(txt_province_NEmployee1.Text) = True OrElse txt_province_NEmployee1.Text.Length > 6 Then
            txt_province_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter province")
        ElseIf mtx_cellno_NEmployee1.Text = "" OrElse mtx_cellno_NEmployee1.Text.Length < 12 Then
            mtx_cellno_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter CellNumber")
        ElseIf mtx_dob_NEmployee1.Text = "" Then
            mtx_dob_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter Date of birth")
        ElseIf mtx_number_NEmployee1.Text = "" OrElse mtx_number_NEmployee1.Text.Length < 12 Then
            mtx_number_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter PhoneNumber")
        ElseIf mtx_postal_NEmployee1.Text = "" OrElse mtx_postal_NEmployee1.Text.Length < 7 Then
            mtx_postal_NEmployee1.BackColor = Color.Red
            MsgBox("Please Enter Postal Code")
        Else
            Me.Hide()
            vNEmployee2.Show()
        End If


    End Sub

    Private Sub mtx_dob_NEmployee1_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles mtx_dob_NEmployee1.TypeValidationCompleted

        If mtx_dob_NEmployee1.Text = "__/__/____" Then
            e.Cancel = True
            Exit Sub
        End If


        If (Not e.IsValidInput) Then
            MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
            mtx_dob_NEmployee1.Focus()
            SendKeys.Send("{End}")

        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate < "01/01/1930" Or UserDate > "01/01/2099") Then
                MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
                e.Cancel = True
                mtx_dob_NEmployee1.Focus()
                SendKeys.Send("{End}")
            End If
        End If



    End Sub

    Private Sub txt_fname_NEmployee1_TextChanged(sender As Object, e As EventArgs) Handles txt_fname_NEmployee1.TextChanged
        If txt_fname_NEmployee1.Text <> "" Then
            txt_fname_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub txt_lname_NEmployee1_TextChanged(sender As Object, e As EventArgs) Handles txt_lname_NEmployee1.TextChanged
        If txt_lname_NEmployee1.Text <> "" Then
            txt_lname_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub mtx_dob_NEmployee1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtx_dob_NEmployee1.MaskInputRejected
        If mtx_dob_NEmployee1.Text <> "" Then
            mtx_dob_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub txt_address_NEmployee1_TextChanged(sender As Object, e As EventArgs) Handles txt_address_NEmployee1.TextChanged
        If txt_address_NEmployee1.Text <> "" Then
            txt_address_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub txt_city_NEmployee1_TextChanged(sender As Object, e As EventArgs) Handles txt_city_NEmployee1.TextChanged
        If txt_city_NEmployee1.Text <> "" Then
            txt_city_NEmployee1.BackColor = Color.Empty
        End If

    End Sub

    Private Sub txt_province_NEmployee1_TextChanged(sender As Object, e As EventArgs) Handles txt_province_NEmployee1.TextChanged
        If txt_province_NEmployee1.Text <> "" Then
            txt_province_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub mtx_postal_NEmployee1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtx_postal_NEmployee1.MaskInputRejected
        If mtx_postal_NEmployee1.Text <> "" Then
            mtx_postal_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub mtx_number_NEmployee1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)
        If mtx_number_NEmployee1.Text <> "" Then
            mtx_number_NEmployee1.BackColor = Color.Empty
        End If
    End Sub

    Private Sub mtx_cellno_NEmployee1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtx_cellno_NEmployee1.MaskInputRejected

    End Sub

    Private Sub vNEmployee1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.mtx_dob_NEmployee1.Mask = "00/00/0000"
        Me.mtx_dob_NEmployee1.ValidatingType = GetType(System.DateTime)
        Me.mtx_dob_NEmployee1.Mask = "00/00/0000"
        Me.mtx_dob_NEmployee1.ValidatingType = GetType(System.DateTime)
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Me.Close()
    '    vDashboard.Show()
    'End Sub

End Class