Public Class lab1_a

    Private total As Decimal
    Private kilometers As Decimal
    Private consumption As Decimal
    Private gaz_price As Decimal
    Private num_passengers As Decimal
    Private total_per_person As Integer

    Private Sub lab1_a_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\long_road.jpg")

        lbl_consumption.BackColor = Color.Transparent
        lbl_consumption.ForeColor = Color.White

        lbl_count_driver.BackColor = Color.Transparent
        lbl_count_driver.ForeColor = Color.White

        lbl_kilometers.BackColor = Color.Transparent
        lbl_kilometers.ForeColor = Color.White

        lbl_passengers.BackColor = Color.Transparent
        lbl_passengers.ForeColor = Color.White

        lbl_price.BackColor = Color.Transparent
        lbl_price.ForeColor = Color.White

        lbl_title.BackColor = Color.Transparent
        lbl_title.ForeColor = Color.White

        lbl_per_person.BackColor = Color.Transparent
        lbl_per_person.ForeColor = Color.White

        txt_result.ForeColor = Color.White

        rdo_yes.BackColor = Color.Transparent
        rdo_no.BackColor = Color.Transparent

        txt_kilo.BackColor = Color.AliceBlue
        txt_consumption.BackColor = Color.AliceBlue
        txt_num_passengers.BackColor = Color.AliceBlue
        txt_price.BackColor = Color.AliceBlue

        txt_result.BackColor = Color.DeepSkyBlue
        txt_result.ForeColor = Color.White

        txt_result.Hide()

    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click

        If (txt_kilo.Text = "" OrElse txt_consumption.Text = "" OrElse txt_price.Text = "" OrElse txt_num_passengers.Text = "") Then
            MsgBox("Some fields remain empty. Please fill in every field (Keep in mind that the driver included is optional).")
        Else
            'inputs stored into class variables
            If (IsNumeric(txt_kilo.Text) = True AndAlso IsNumeric(txt_consumption.Text) = True AndAlso IsNumeric(txt_price.Text) = True AndAlso IsNumeric(txt_num_passengers.Text) = True) Then
                kilometers = txt_kilo.Text
                consumption = txt_consumption.Text
                gaz_price = txt_price.Text
                num_passengers = txt_num_passengers.Text

                'verify whether radio button was checked
                If (rdo_yes.Checked = True) Then
                    num_passengers += 1
                End If

                'calculating using math formula
                total = (((kilometers / 100) * consumption) * gaz_price) / num_passengers

                'display the total in read only text field
                txt_result.Text = total.ToString("C")

                txt_result.Show()

            Else
                MsgBox("Sorry, one or more fields were invalid.")
            End If
        End If

    End Sub

    ''' <summary>
    ''' This function resets the input fields including the radio buttons
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

        txt_kilo.Text = ""
        txt_consumption.Text = ""
        txt_price.Text = ""
        txt_num_passengers.Text = ""
        txt_result.Text = ""
        rdo_yes.Checked = False
        rdo_no.Checked = False
        txt_result.Hide()

    End Sub

End Class
