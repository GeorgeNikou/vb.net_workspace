Public Class lab2

    Dim rand As New Random()

    'betting variables
    Dim cash_start As Decimal
    Dim cash_remaining As Decimal
    Dim cash_bet As Decimal

    'stat variables
    Dim total_rounds As Integer
    Dim total_wins As Integer
    Dim total_losses As Integer
    Dim total_profit As Integer

    'misc variables
    Dim counter_sheep As Decimal
    Dim counter_sloth As Decimal
    Dim counter_donkey As Decimal
    Dim counter_turtle As Decimal
    Dim counter_snail As Decimal
    Dim rank As Integer = 0
    Dim chosen_animal As String
    Dim chosen_winner As String

    Dim ranking As Integer = 0
    Dim tmp As Decimal
    Dim bool As Boolean


    ''' <summary>
    ''' form loader
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lab2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_cash_remain.ReadOnly = True
        btn_next.Enabled = False

        'hideRanks()

    End Sub


    ''' <summary>
    ''' START button begins all operations
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        If (txt_start_cash.Text = "" OrElse txt_bet.Text = "" OrElse txt_cash_remain.Text = "") Then
            MsgBox("One or more fields are empty.", MsgBoxStyle.Information)
        Else
            'start all timers
            timer1.Start()
            Timer2.Start()
            Timer3.Start()
            Timer4.Start()
            Timer5.Start()

            'disables the start button
            btn_start.Enabled = False

            'increases rank
            lbl_round.Text += 1
        End If

        chosen_animal = gb_animals.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text

    End Sub

    ''' <summary>
    ''' BET button disables betting and remaining amount
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_bet_Click(sender As Object, e As EventArgs) Handles btn_bet.Click

        chosen_animal = gb_animals.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text


        'checks if cash bet and cash start has user values
        If (txt_start_cash.Text = "" OrElse txt_bet.Text = "") Then
            MsgBox("One or more fields are empty.", MsgBoxStyle.Information)
        Else

            'first time cash remaining 
            If (IsNumeric(txt_start_cash.Text) AndAlso IsNumeric(txt_bet.Text) AndAlso txt_start_cash.Text > 0) Then

                txt_cash_remain.Text = txt_start_cash.Text

                'saving cash, bets and remainder into varaibles
                cash_start = CType(txt_start_cash.Text, Decimal)
                cash_remaining = CType(txt_cash_remain.Text, Decimal)
                cash_bet = CType(txt_bet.Text, Decimal)

                If (cash_bet > cash_remaining OrElse cash_bet < 0 OrElse cash_start < 0) Then
                    MsgBox("Uh-Oh! You have bet more than you can afford. Please select a lower betting option.", MsgBoxStyle.Critical)
                Else
                    'calculation and bet goes through success
                    cash_remaining -= cash_bet
                    txt_cash_remain.Text = cash_remaining

                    btn_bet.Enabled = False
                    txt_start_cash.ReadOnly = True
                    txt_bet.ReadOnly = True
                    gb_animals.Enabled = False

                End If

            End If

        End If

    End Sub

    ''' <summary>
    ''' NEXT round button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        'hideRanks()
        btn_next.Enabled = False

        If (cash_remaining <= 0) Then
            Dim entry = MsgBox("Game over! Would you like to restart?", MsgBoxStyle.YesNo)

            If (entry = 6) Then
                timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                Timer4.Stop()
                Timer5.Stop()

                lbl_wins.Text = 0
                lbl_losses.Text = 0
                lbl_profit.Text = 0
                total_profit = 0
                lbl_round.Text = 0

                txt_bet.Text = ""
                txt_cash_remain.Text = ""
                txt_start_cash.Text = ""
                txt_start_cash.ReadOnly = False
                txt_bet.ReadOnly = False

                resetGame()

                btn_next.Enabled = False
                btn_start.Enabled = True
                btn_bet.Enabled = True

                gb_animals.Enabled = True
                MsgBox("Game has been reset.")
            End If

        Else
            If (txt_start_cash.Text = "" OrElse txt_bet.Text = "" OrElse txt_cash_remain.Text = "") Then
                MsgBox("One or more fields are empty.", MsgBoxStyle.Information)
                btn_next.Enabled = True
            Else
                If (CType(txt_bet.Text, Integer) > CType(txt_cash_remain.Text, Integer)) Then
                    MsgBox("Uh-Oh! You have bet more than you can afford. Please select a lower betting option.", MsgBoxStyle.Critical)
                    btn_next.Enabled = True
                Else
                    resetGame()
                    cash_bet = txt_bet.Text
                    cash_remaining -= cash_bet
                    txt_cash_remain.Text = cash_remaining

                    chosen_animal = gb_animals.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text

                    'start all timers
                    timer1.Start()
                    Timer2.Start()
                    Timer3.Start()
                    Timer4.Start()
                    Timer5.Start()

                    'disables the start button
                    btn_start.Enabled = False

                    'increases round
                    lbl_round.Text += 1
                End If

            End If
        End If




    End Sub

    ''' <summary>
    ''' sheep timer1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer_sheep_Tick(sender As Object, e As EventArgs) Handles timer1.Tick

        If (pg_sheep.Value >= 475) Then
            ranking += 1
            betRenable()
            lbl_rank_sheep.Text = ranking
            pb_sheep.Location = New Point(650, 18)
            timer1.Stop()
        Else
            Try
                counter_sheep += rand.Next(1, 25)
                pb_sheep.Location = New Point(counter_sheep, 18)
                pg_sheep.Value = counter_sheep / 1.3
            Catch ex As Exception
            End Try
        End If


    End Sub

    ''' <summary>
    ''' sloth timer2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        If (pg_sloth.Value >= 475) Then
            ranking += 1
            betRenable()
            lbl_rank_sloth.Text = ranking
            pb_sloth.Location = New Point(650, 68)
            Timer2.Stop()
        Else
            Try
                counter_sloth += rand.Next(1, 25)
                pb_sloth.Location = New Point(counter_sloth, 68)
                pg_sloth.Value = counter_sloth / 1.3
            Catch ex As Exception
            End Try
        End If


    End Sub

    ''' <summary>
    ''' turtle timer3 - poor turtle  :'( 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        If (pg_turtle.Value >= 475) Then
            ranking += 1
            betRenable()
            lbl_rank_turtle.Text = ranking
            pb_turtle.Location = New Point(650, 125)
            Timer3.Stop()
        Else
            Try
                counter_turtle += rand.Next(1, 25)
                pb_turtle.Location = New Point(counter_turtle, 125)
                pg_turtle.Value = counter_snail / 1.3
            Catch ex As Exception
            End Try
        End If

    End Sub


    ''' <summary>
    ''' donkey timer4
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        If (pg_donkey.Value >= 475) Then
            ranking += 1
            betRenable()
            lbl_rank_donkey.Text = ranking
            pb_donkey.Location = New Point(650, 185)
            Timer4.Stop()
        Else
            Try
                counter_donkey += rand.Next(1, 35)
                pb_donkey.Location = New Point(counter_donkey, 185)
                pg_donkey.Value = counter_donkey / 1.3
            Catch ex As Exception
            End Try
        End If

    End Sub

    ''' <summary>
    ''' snail timer 5
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick

        If (pg_snail.Value >= 475) Then
            ranking += 1
            betRenable()
            lbl_rank_snail.Text = ranking
            pb_snail.Location = New Point(650, 235)
            Timer5.Stop()
        Else
            Try
                counter_snail += rand.Next(1, 25)
                pb_snail.Location = New Point(counter_snail, 235)
                pg_snail.Value = counter_snail / 1.3
            Catch ex As Exception
            End Try
        End If



    End Sub

    ''' <summary>
    ''' this function re-enables the betting textbox
    ''' </summary>
    Private Sub betRenable()

        If (ranking = 5) Then

            If (lbl_round.Text = "12") Then

                timer1.Stop()
                Timer2.Stop()
                Timer3.Stop()
                Timer4.Stop()
                Timer5.Stop()

                lbl_wins.Text = 0
                lbl_losses.Text = 0
                lbl_profit.Text = 0
                lbl_round.Text = 0

                txt_bet.Text = ""
                txt_cash_remain.Text = ""
                txt_start_cash.Text = ""
                txt_start_cash.ReadOnly = False
                txt_bet.ReadOnly = False

                resetGame()

                btn_next.Enabled = False
                btn_start.Enabled = True
                btn_bet.Enabled = True

                gb_animals.Enabled = True


                MsgBox("Game over!", MsgBoxStyle.Information)

            Else
                showRanks()
                cash_bet = 0
                btn_next.Enabled = True
                If (chosen_animal.ToLower = "sloth" AndAlso lbl_rank_sloth.Text = "1") Then
                        cash_bet = txt_bet.Text
                        total_profit += cash_bet
                        cash_bet *= 2
                        cash_remaining += cash_bet
                        txt_cash_remain.Text = cash_remaining
                        lbl_wins.Text += 1
                        lbl_profit.Text = total_profit

                    ElseIf (chosen_animal.ToLower = "sheep" AndAlso lbl_rank_sheep.Text = "1") Then
                        cash_bet = txt_bet.Text
                        total_profit += cash_bet
                        cash_bet *= 2
                        cash_remaining += cash_bet
                        txt_cash_remain.Text = cash_remaining
                        lbl_wins.Text += 1
                        lbl_profit.Text = total_profit

                    ElseIf (chosen_animal.ToLower = "donkey" AndAlso lbl_rank_donkey.Text = "1") Then
                        cash_bet = txt_bet.Text
                        total_profit += cash_bet
                        cash_bet *= 2
                        cash_remaining += cash_bet
                        txt_cash_remain.Text = cash_remaining
                        lbl_wins.Text += 1
                        lbl_profit.Text = total_profit

                    ElseIf (chosen_animal.ToLower = "turtle" AndAlso lbl_rank_turtle.Text = "1") Then
                        cash_bet = txt_bet.Text
                        total_profit += cash_bet
                        cash_bet *= 2
                        cash_remaining += cash_bet
                        txt_cash_remain.Text = cash_remaining
                        lbl_wins.Text += 1
                        lbl_profit.Text = total_profit

                    ElseIf (chosen_animal.ToLower = "snail" AndAlso lbl_rank_snail.Text = "1") Then
                        cash_bet = txt_bet.Text
                        total_profit += cash_bet
                        cash_bet *= 2
                        cash_remaining += cash_bet
                        txt_cash_remain.Text = cash_remaining
                        lbl_wins.Text += 1
                        lbl_profit.Text = total_profit

                    Else
                        lbl_losses.Text += 1
                    End If

                End If

                txt_bet.ReadOnly = False
                gb_animals.Enabled = True
            End If


    End Sub

    ''' <summary>
    ''' this functions just resets all stats to default(prograss bar, picture boxes, labels and ranking)
    ''' </summary>
    Private Sub resetGame()

        'reset all random counter variables
        counter_sheep = 0
        counter_sloth = 0
        counter_donkey = 0
        counter_turtle = 0
        counter_snail = 0

        'resets progress bars to 0
        pg_sheep.Value = 1
        pg_sloth.Value = 1
        pg_turtle.Value = 1
        pg_donkey.Value = 1
        pg_snail.Value = 1

        'resets the picture-boxes to default settings
        pb_sheep.Location = New Point(0, 18)
        pb_sloth.Location = New Point(0, 68)
        pb_turtle.Location = New Point(0, 125)
        pb_donkey.Location = New Point(0, 185)
        pb_snail.Location = New Point(0, 235)

        'resets the label rankings
        lbl_rank_sheep.Text = ""
        lbl_rank_sloth.Text = ""
        lbl_rank_turtle.Text = ""
        lbl_rank_donkey.Text = ""
        lbl_rank_snail.Text = ""

        ranking = 0

    End Sub

    ''' <summary>
    ''' this function hides all the rank labels
    ''' </summary>
    Private Sub hideRanks()
        lbl_rank_sheep.Hide()
        lbl_rank_sloth.Hide()
        lbl_rank_donkey.Hide()
        lbl_rank_turtle.Hide()
        lbl_rank_snail.Hide()
    End Sub

    Private Sub showRanks()
        lbl_rank_sheep.Show()
        lbl_rank_sloth.Show()
        lbl_rank_donkey.Show()
        lbl_rank_turtle.Show()
        lbl_rank_snail.Show()
    End Sub

End Class