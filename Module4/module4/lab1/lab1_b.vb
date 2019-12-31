Public Class lab1_b

    Private wins As Integer
    Private losses As String
    Private tries As Integer
    Private counter As Integer
    Private num As Integer
    Private rand_num As New Random()


    Private Sub lab1_b_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tries = 3
        lbl_tries.Text = tries

        wins = 0
        lbl_wins.Text = wins

        losses = 0
        lbl_losses.Text = losses

        pokeball_set()
        pokeball_hide()

    End Sub

    ''' <summary>
    ''' picture box 1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic_1.Click

        If (pic_1.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_1.BackgroundImageLayout = ImageLayout.Stretch
            pic_1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_1.Text = num) Then
            pic_1.BackgroundImageLayout = ImageLayout.Stretch
            pic_1.BackColor = Color.Transparent
            pic_1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()
        End If

    End Sub

    ''' <summary>
    ''' picture box 2
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_2_Click(sender As Object, e As EventArgs) Handles pic_2.Click
        If (pic_2.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_2.BackgroundImageLayout = ImageLayout.Stretch
            pic_2.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_2.Text = num) Then
            pic_2.BackgroundImageLayout = ImageLayout.Stretch
            pic_2.BackColor = Color.Transparent
            pic_2.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 3
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_3_Click(sender As Object, e As EventArgs) Handles pic_3.Click
        If (pic_3.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_3.BackgroundImageLayout = ImageLayout.Stretch
            pic_3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_3.Text = num) Then
            pic_3.BackgroundImageLayout = ImageLayout.Stretch
            pic_3.BackColor = Color.Transparent
            pic_3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 4
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_4_Click(sender As Object, e As EventArgs) Handles pic_4.Click
        If (pic_4.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_4.BackgroundImageLayout = ImageLayout.Stretch
            pic_4.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_4.Text = num) Then
            pic_4.BackgroundImageLayout = ImageLayout.Stretch
            pic_4.BackColor = Color.Transparent
            pic_4.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 5
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_5_Click(sender As Object, e As EventArgs) Handles pic_5.Click
        If (pic_5.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_5.BackgroundImageLayout = ImageLayout.Stretch
            pic_5.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_5.Text = num) Then
            pic_5.BackgroundImageLayout = ImageLayout.Stretch
            pic_5.BackColor = Color.Transparent
            pic_5.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 6
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_6_Click(sender As Object, e As EventArgs) Handles pic_6.Click
        If (pic_6.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_6.BackgroundImageLayout = ImageLayout.Stretch
            pic_6.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_6.Text = num) Then
            pic_6.BackgroundImageLayout = ImageLayout.Stretch
            pic_6.BackColor = Color.Transparent
            pic_6.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 7
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_7_Click(sender As Object, e As EventArgs) Handles pic_7.Click
        If (pic_7.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_7.BackgroundImageLayout = ImageLayout.Stretch
            pic_7.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_7.Text = num) Then
            pic_7.BackgroundImageLayout = ImageLayout.Stretch
            pic_7.BackColor = Color.Transparent
            pic_7.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 8
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_8_Click(sender As Object, e As EventArgs) Handles pic_8.Click
        If (pic_8.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_8.BackgroundImageLayout = ImageLayout.Stretch
            pic_8.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_8.Text = num) Then
            pic_8.BackgroundImageLayout = ImageLayout.Stretch
            pic_8.BackColor = Color.Transparent
            pic_8.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    ''' <summary>
    ''' picture box 9
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pic_9_Click(sender As Object, e As EventArgs) Handles pic_9.Click
        If (pic_9.Text <> num) Then
            tries -= 1
            lbl_tries.Text = tries
            pic_9.BackgroundImageLayout = ImageLayout.Stretch
            pic_9.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\opened_pokeball.png")

            pokemon_lose()

        ElseIf (pic_9.Text = num) Then
            pic_9.BackgroundImageLayout = ImageLayout.Stretch
            pic_9.BackColor = Color.Transparent
            pic_9.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\pikachu_found.png")

            'display current wins
            tries = 3
            lbl_tries.Text = tries

            'display current tries
            wins += 1
            lbl_wins.Text = wins

            'display victory message
            MsgBox("You found Pikachu!")
            'function to reset all the pokeballs
            pokeball_reset()

        End If
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        num = rand_num.Next(1, 10)

        pic_1.Show()
        pic_2.Show()
        pic_3.Show()
        pic_4.Show()
        pic_5.Show()
        pic_6.Show()
        pic_7.Show()
        pic_8.Show()
        pic_9.Show()
        btn_start.Hide()

    End Sub

    ''' <summary>
    ''' This functions resets all the pokeballs
    ''' </summary>
    Private Sub pokeball_reset()
        num = rand_num.Next(1, 10)
        pic_1.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_2.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_3.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_4.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_5.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_6.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_7.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_8.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
        pic_9.BackgroundImage = System.Drawing.Image.FromFile("C:\Users\George Nikou\Desktop\pictures\closed_pokeball.png")
    End Sub

    ''' <summary>
    ''' this function hides all the current pokeballs
    ''' </summary>
    Private Sub pokeball_hide()
        pic_1.Hide()
        pic_2.Hide()
        pic_3.Hide()
        pic_4.Hide()
        pic_5.Hide()
        pic_6.Hide()
        pic_7.Hide()
        pic_8.Hide()
        pic_9.Hide()
    End Sub

    ''' <summary>
    ''' this function sets numbers to picture box (pokebals)
    ''' </summary>
    Private Sub pokeball_set()
        pic_1.Text = 1
        pic_2.Text = 2
        pic_3.Text = 3
        pic_4.Text = 4
        pic_5.Text = 5
        pic_6.Text = 6
        pic_7.Text = 7
        pic_8.Text = 8
        pic_9.Text = 9
    End Sub

    ''' <summary>
    ''' this function displays a lose message/ resets the tries to 3/ adds losses + 1/ resets pokeballs to closed
    ''' </summary>
    Private Sub pokemon_lose()
        If (tries = 0) Then
            losses += 1
            lbl_losses.Text = losses

            MsgBox("You lose.")

            num = rand_num.Next(1, 10)
            pokeball_reset()
            tries = 3
            lbl_tries.Text = tries
        End If
    End Sub

End Class