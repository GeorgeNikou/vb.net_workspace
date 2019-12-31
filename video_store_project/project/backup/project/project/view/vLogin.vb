Public Class vLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_login_Click(sender As Object, e As EventArgs) Handles btn_login_login.Click

        Dim tmp As New DBManager
        'tmp.testConnection()

        'Dim format As String = "ID: {0,3} Name: {1, -20} Age: {2,3} Gender: {3,-10}"
        'For Each row As DataRow In tmp.getAllUsers
        '    Console.WriteLine(String.Format(format, row("user_id"), row("employee_number") & " " & row("username"), row("password"), row("fname"), row("lname"), row("dob"), row("address"), row("city"), row("province"), row("postal_code"), row("home_phone"), row("cell_phone"), row("start_date"), row("sin"), row("hourly_pay"), row("education"), row("level"), row("status")))
        'Next
        'Console.Read()

        tmp.getAllUsersList()

        Me.Hide()
        vDashboard.Show()

    End Sub


End Class
