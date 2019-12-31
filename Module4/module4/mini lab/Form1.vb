Public Class Form1

    Dim mario As Character
    Dim luigi As Character
    Dim boo As Character
    Dim direction = {"right", "left", "up", "down"}
    Dim rand As New Random
    Dim mario_cal As New Point
    Dim luigi_cal As New Point
    Dim boo_cal As New Point

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mario = New Character("Mario", New Point(40, 40), il_characters.Images(3), New Drawing.Size(50, 50), Me)
        luigi = New Character("Luigi", New Point(300, 40), il_characters.Images(4), New Drawing.Size(50, 50), Me)
        boo = New Character("boo", New Point(Me.Width / 2, Me.Height / 2), il_characters.Images(5), New Drawing.Size(50, 50), Me)


        Me.Controls.Add(mario)
        Me.Controls.Add(luigi)
        Me.Controls.Add(boo)
    End Sub

    Private Sub TIM_1_Tick(sender As Object, e As EventArgs) Handles TIM_1.Tick
        mario.move(direction(rand.Next(0, 4)))
        luigi.move(direction(rand.Next(0, 4)))
        boo.move(direction(rand.Next(0, 4)))

        mario_cal = mario.Location
        luigi_cal = luigi.Location
        boo_cal = boo.Location

        If mario_cal.X < 100 And boo_cal.X < 100 AndAlso mario_cal.Y < 100 And boo_cal.Y < 100 Then
            MsgBox("Luigi wins")
            TIM_1.Stop()
        ElseIf luigi_cal.X < 100 And boo_cal.X < 100 AndAlso luigi_cal.Y < 100 And boo_cal.Y < 100 Then
            MsgBox("Mario wins")
            TIM_1.Stop()
        End If



    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        TIM_1.Start()
    End Sub
End Class