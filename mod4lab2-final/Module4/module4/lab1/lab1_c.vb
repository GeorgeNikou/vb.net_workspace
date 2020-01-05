﻿Public Class lab1_c


    Private total As Decimal
    Private total_display As String

    Private one As String
    Private two As String
    Private three As String
    Private four As String
    Private five As String
    Private six As String
    Private seven As String
    Private eight As String
    Private nine As String
    Private zero As String
    Private subtract As String
    Private addition As String
    Private multiply As String
    Private divide As String
    Private equals As String
    Private dot As String




    Private Sub lab1_c_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        one = "1"
        two = "2"
        three = "3"
        four = "4"
        five = "5"
        six = "6"
        seven = "7"
        eight = "8"
        nine = "9"
        zero = "0"
        subtract = "-"
        addition = "+"
        multiply = "*"
        divide = "/"
        equals = "="
        dot = "."
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += one
        Else
            lbl_view.Text += one
        End If
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += two
        Else
            lbl_view.Text += two
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += three
        Else
            lbl_view.Text += three
        End If
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += four
        Else
            lbl_view.Text += four
        End If
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += five
        Else
            lbl_view.Text += five
        End If
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += six
        Else
            lbl_view.Text += six
        End If
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += seven
        Else
            lbl_view.Text += seven
        End If
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += eight
        Else
            lbl_view.Text += eight
        End If
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += nine
        Else
            lbl_view.Text += nine
        End If
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        lbl_view.Text += zero
    End Sub

    Private Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        lbl_view.Text = "0"
    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click

        'checks for duplicate 0's
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += subtract
        End If

        'checks for duplicate "-"
        If (lbl_view.Text = subtract) Then
            'do nothing

            'checks for rightmost char for duplicates
        ElseIf (lbl_view.Text.Substring(lbl_view.Text.Length - 1) = subtract) Then
            'do nothing

            'displays "-" opertator
        Else
            lbl_view.Text += subtract
        End If

    End Sub

    Private Sub btn_addition_Click(sender As Object, e As EventArgs) Handles btn_addition.Click

        'checks for duplicate 0's
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += addition
        End If

        'checks for duplicate "+"
        If (lbl_view.Text = addition) Then
            'do nothing

            'checks for rightmost char for duplicates
        ElseIf (lbl_view.Text.Substring(lbl_view.Text.Length - 1) = addition) Then
            'do nothing

            'displays "+" opertator
        Else
            lbl_view.Text += addition
        End If

    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click

        'checks for duplicate 0's
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += multiply
        End If

        'checks for duplicate "*"
        If (lbl_view.Text = multiply) Then
            'do nothing

            'checks for rightmost char for duplicates
        ElseIf (lbl_view.Text.Substring(lbl_view.Text.Length - 1) = multiply) Then
            'do nothing

            'displays "*" opertator
        Else
            lbl_view.Text += multiply
        End If

    End Sub

    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click

        'checks for duplicate 0's
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += divide
        End If

        'checks for duplicate "/"
        If (lbl_view.Text = divide) Then
            'do nothing

            'checks for rightmost char for duplicates
        ElseIf (lbl_view.Text.Substring(lbl_view.Text.Length - 1) = divide) Then
            'do nothing

            'displays "/" opertator
        Else
            lbl_view.Text += divide
        End If

    End Sub

    Private Sub btn_point_Click(sender As Object, e As EventArgs) Handles btn_point.Click

        'checks for duplicate 0's
        If (lbl_view.Text = "0") Then
            lbl_view.Text = ""
            lbl_view.Text += dot
        End If

        'checks for duplicate "."
        If (lbl_view.Text = dot) Then
            'do nothing

            'checks for rightmost char for duplicates
        ElseIf (lbl_view.Text.Substring(lbl_view.Text.Length - 1) = dot) Then
            'do nothing

            'displays "." opertator           
        Else
            lbl_view.Text += dot
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        lbl_view.Text = lbl_view.Text.Trim.Remove(lbl_view.Text.Length - 1)
    End Sub
End Class