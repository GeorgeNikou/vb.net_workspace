Public Class vNEmployee2
    Private Sub btn_next_NEmployee2_Click(sender As Object, e As EventArgs) Handles btn_next_NEmployee2.Click
        If txt_ENumber_NEmployee2.Text = "" OrElse IsNumeric(txt_ENumber_NEmployee2.Text) = False OrElse txt_ENumber_NEmployee2.Text.Length > 4 Then
            txt_ENumber_NEmployee2.BackColor = Color.Red
            MsgBox("Please Enter valid Employee number (1234)")
        ElseIf txt_NAS_NEmployee2.Text = "" OrElse IsNumeric(txt_NAS_NEmployee2.Text) = False OrElse txt_NAS_NEmployee2.Text.Length > 9 Then
            txt_NAS_NEmployee2.BackColor = Color.Red
            MsgBox("Please Enter valid NAS (123456789)")
        ElseIf txt_salary_NEmployee2.Text = "" OrElse IsNumeric(txt_salary_NEmployee2.Text) = False OrElse txt_salary_NEmployee2.Text.Length > 2 Then
            txt_salary_NEmployee2.BackColor = Color.Red
            MsgBox("Please Enter valid Salary (12)")
        Else
            Me.Hide()
            vNEmployee3.Show()
        End If


    End Sub
    Private Sub mtx_DCreated_NEmployee2_TypeValidationCompleted(ByVal sender As Object, ByVal e As TypeValidationEventArgs) Handles mtx_DCreated_NEmployee2.TypeValidationCompleted

        If mtx_DCreated_NEmployee2.Text = "__/__/____" Then
            e.Cancel = True
            Exit Sub
        End If


        If (Not e.IsValidInput) Then
            MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
            mtx_DCreated_NEmployee2.Focus()
            SendKeys.Send("{End}")

        Else
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate < "01/01/1930" Or UserDate > "01/01/2099") Then
                MessageBox.Show("Please input a valid date in the format mm/dd/yyyy.", "Invalid Date Entered", MessageBoxButtons.RetryCancel)
                e.Cancel = True
                mtx_DCreated_NEmployee2.Focus()
                SendKeys.Send("{End}")
            End If
        End If
    End Sub
    Private Sub vNEmployee2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtx_DCreated_NEmployee2.Text = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
        Me.mtx_DCreated_NEmployee2.Mask = "00/00/0000"
        Me.mtx_DCreated_NEmployee2.ValidatingType = GetType(System.DateTime)
        Me.mtx_DCreated_NEmployee2.Mask = "00/00/0000"
        Me.mtx_DCreated_NEmployee2.ValidatingType = GetType(System.DateTime)
    End Sub
    Private Sub txt_ENumber_NEmployee2_TextChanged(sender As Object, e As EventArgs) Handles txt_ENumber_NEmployee2.TextChanged
        If txt_ENumber_NEmployee2.Text <> "" Then
            txt_ENumber_NEmployee2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub txt_NAS_NEmployee2_TextChanged(sender As Object, e As EventArgs) Handles txt_NAS_NEmployee2.TextChanged
        If txt_NAS_NEmployee2.Text <> "" Then
            txt_NAS_NEmployee2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub txt_salary_NEmployee2_TextChanged(sender As Object, e As EventArgs) Handles txt_salary_NEmployee2.TextChanged
        If txt_salary_NEmployee2.Text <> "" Then
            txt_salary_NEmployee2.BackColor = Color.Empty
        End If
    End Sub

    Private Sub mtx_DCreated_NEmployee2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mtx_DCreated_NEmployee2.MaskInputRejected
        If mtx_DCreated_NEmployee2.Text <> "" Then
            mtx_DCreated_NEmployee2.BackColor = Color.Empty
        End If
        'Dim dt As Date = Date.Today

        'mtx_DCreated_NEmployee2.Text = dt
    End Sub

    Private Sub btn_back_NEmployee2_Click(sender As Object, e As EventArgs) Handles btn_back_NEmployee2.Click
        Me.Hide()
        vNEmployee1.Show()
    End Sub
End Class