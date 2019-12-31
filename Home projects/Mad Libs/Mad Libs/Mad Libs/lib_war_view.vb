Public Class lib_war_view

    Public array_len As Integer

    Private Sub lib_war_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        result.pb_result_war.Image = Form1.img_list2.Images(0)
        result.lbl_result_title.Text = "Time for War"
    End Sub

    Private Sub btn_login_enter_Click(sender As Object, e As EventArgs) Handles btn_login_enter.Click
        Form1.array_war.Add(New War(txt_war_noun1.Text, txt_war_noun2.Text, txt_war_noun3.Text, txt_war_occupation.Text, txt_war_place.Text, txt_war_verb.Text, txt_war_verbed.Text, txt_war_noun4.Text, txt_war_verbing.Text, txt_war_noun_plural.Text, txt_war_noun5.Text, txt_war_emotion.Text))
        array_len = Form1.array_war.Count - 1
        MsgBox(array_len)
        result.lbl_result.Text = Form1.array_war(0).ToString
        Me.Hide()
        result.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        main_menu.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_war_noun1.Text = Form1.func.rand_noun(Form1.array_noun)
        txt_war_noun2.Text = Form1.func.rand_noun(Form1.array_noun)
        txt_war_noun3.Text = Form1.func.rand_noun(Form1.array_noun)
        txt_war_noun4.Text = Form1.func.rand_noun(Form1.array_noun)
        txt_war_noun_plural.Text = Form1.func.rand_noun(Form1.array_noun)
        txt_war_noun5.Text = Form1.func.rand_noun(Form1.array_noun)
    End Sub
End Class