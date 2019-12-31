Public Class create_vehicle

    Private rButton As Integer
    Private decision As Integer

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub create_vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picb_1.Image = img_list.Images(0) ' adds images to pictures boxes
        picb_2.Image = img_list.Images(1)
        picb_3.Image = img_list.Images(2)

        rdo_sedan.Enabled = True 'set default radio button
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        'setting radio button selection
        rButton = gb_rdos.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).TabIndex

        If rButton = 0 Then
            If IsNumeric(txt_speed.Text) = False OrElse txt_speed.Text = "" Then
                MsgBox("Invalid field. Sedan speed must be numeric!", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_price.Text) = False OrElse txt_price.Text = "" Then
                MsgBox("Invalid field. Sedan price must be numeric!", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_color.Text) = True OrElse txt_color.Text = "" Then
                MsgBox("Invalid field. Sedan color cannot be numeric!", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_length.Text) = False OrElse txt_length.Text = "" Then
                MsgBox("Invalid field. Sedan Length must be numeric!", MsgBoxStyle.Information)
            Else 'CREATES A NEW SEDAN
                Form1.cb_main_sedans.Items.Add(txt_name.Text)
                Form1.arr_sedan.Add(New Sedan(CType(txt_speed.Text, Integer), CType(txt_price.Text, Double), txt_color.Text, CType(txt_length.Text, Integer)))
                decision = MsgBox("Your new sedan has be successfully created! Would you like to return to the main page?", MsgBoxStyle.YesNo)
                If decision = 6 Then
                    Me.Close()
                    Form1.Show()
                End If
            End If

        ElseIf rButton = 1 Then
            If IsNumeric(txt_speed.Text) = False OrElse txt_speed.Text = "" Then
                MsgBox("Invalid field. Truck speed must be numeric and cannot remain empty.", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_price.Text) = False OrElse txt_price.Text = "" Then
                MsgBox("Invalid field. Truck price must be numeric and cannot remain empty.", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_color.Text) = True OrElse txt_color.Text = "" Then
                MsgBox("Invalid field. Truck color cannot be numeric and cannot remain empty.", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_weight.Text) = False OrElse txt_weight.Text = "" Then
                MsgBox("Invalid field. Truck Length must be numeric and cannot remain empty.", MsgBoxStyle.Information)
            Else 'CREATES A NEW TRUCK
                Form1.cb_main_trucks.Items.Add(txt_name.Text)
                Form1.arr_truck.Add(New Truck(CInt(txt_speed.Text), CDbl(txt_price.Text), txt_color.Text, CInt(txt_weight.Text)))
                decision = MsgBox("Your new truck has be successfully created! Would you like to return to the main page?", MsgBoxStyle.YesNo)
                If decision = 6 Then
                    Me.Close()
                    Form1.Show()
                End If
            End If

        ElseIf rButton = 2 Then
            If IsNumeric(txt_speed.Text) = False OrElse txt_speed.Text = "" Then
                MsgBox("Invalid field. Ford speed must be numeric and cannot remain empty.", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_price.Text) = False OrElse txt_price.Text = "" Then
                MsgBox("Invalid field. Ford price must be numeric and cannot remain empty.", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_color.Text) = True OrElse txt_color.Text = "" Then
                MsgBox("Invalid field. Ford color cannot be numeric and cannot remain empty.", MsgBoxStyle.Critical)
            ElseIf IsNumeric(txt_discount.Text) = False OrElse txt_discount.Text = "" Then
                MsgBox("Invalid field. Ford discount price must be numeric and cannot remain empty.", MsgBoxStyle.Information)
            ElseIf IsNumeric(txt_year.Text) = False OrElse txt_year.Text = "" OrElse txt_year.Text.Length >= 5 OrElse txt_year.Text.Length < 4 Then
                MsgBox("Invalid field. Ford year must be numeric, four digits (ex: 2019) and cannot remain empty.", MsgBoxStyle.Information)
            Else 'CREATES A NEW FORD
                Form1.cb_main_fords.Items.Add(txt_name.Text)
                Form1.arr_ford.Add(New Ford(CInt(txt_speed.Text), CDbl(txt_price.Text), txt_color.Text, CInt(txt_year.Text), CInt(txt_discount.Text)))
                decision = MsgBox("Your new Ford has be successfully created! Would you like to return to the main page?", MsgBoxStyle.YesNo)
                If decision = 6 Then
                    Me.Close()
                    Form1.Show()
                End If
            End If
        End If
    End Sub

    Private Sub gb_rdos_Enter(sender As Object, e As EventArgs) Handles gb_rdos.Enter
        If rButton = 2 Then
            txt_length.Enabled = False
            txt_weight.Enabled = False
            txt_year.Enabled = True
            txt_discount.Enabled = True
        ElseIf rButton = -1 Then
            'do nothing
        End If
    End Sub

    Private Sub NewVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVehicleToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form1.Close()
    End Sub

    Private Sub VerisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerisonToolStripMenuItem.Click
        MsgBox("Version 10 trillion", MsgBoxStyle.Information)
    End Sub
End Class