Public Class form_login

    'public variables
    Public users(19) As person
    Public username As String
    Public tmp As Integer = 3


    ''' <summary>
    ''' FORM LOADER
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'adding three pre-determined users
        users(0).username = "George"
        users(0).password = "george123"

        users(1).username = "Lucy"
        users(1).password = "lucy123"

        users(2).username = "Tim"
        users(2).password = "tim123"

    End Sub


    ''' <summary>
    ''' CREATE NEW USER
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_login_create_Click(sender As Object, e As EventArgs) Handles btn_login_create.Click
        Me.Hide()
        form_create.Show()
    End Sub


    ''' <summary>
    ''' LOGIN BUTTON
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_login_enter_Click(sender As Object, e As EventArgs) Handles btn_login_enter.Click

        If (txt_login_username.Text = "" OrElse txt_login_password.Text = "") Then
            MsgBox("One or more fiels were empty.", MsgBoxStyle.Information)
        ElseIf (isNumeric(txt_login_username.Text) = True OrElse isNumeric(txt_login_password.Text) = True) Then
            MsgBox("invalid entry", MsgBoxStyle.Information)
        Else
            For i As Integer = 0 To users.Count - 1
                Try
                    If (users(i).username.ToLower = txt_login_username.Text And users(i).password.ToLower = txt_login_password.Text) Then
                        Me.Hide()
                        form_menu.Show()
                        form_menu.Refresh()

                        username = txt_login_username.Text 'save users name to greet
                        form_menu.lbl_menu_greet.Text = "Welcome to the game menu, " & username

                        txt_login_username.Text = ""
                        txt_login_password.Text = ""
                    End If
                Catch ex As Exception
                End Try
                If i = users.Count - 1 AndAlso username = "" Then
                    MsgBox("nope")
                End If
            Next
        End If
    End Sub

    ''' <summary>
    ''' menu item create new user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub msi_login_create_Click(sender As Object, e As EventArgs) Handles msi_login_create.Click
        Me.Hide()
        form_create.Show()
    End Sub


    ''' <summary>
    ''' STRUCTURE
    ''' </summary>
    Public Structure person
        Public username As String
        Public password As String
    End Structure

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        MsgBox("Version 1.34.7", MsgBoxStyle.Information)
    End Sub

    Private Sub AuthorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorToolStripMenuItem.Click
        MsgBox("George Nikou")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
