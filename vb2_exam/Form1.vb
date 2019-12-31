Public Class Form1

    'lists of vehicles
    Public arr_sedan As New List(Of Sedan)
    Public arr_truck As New List(Of Truck)
    Public arr_ford As New List(Of Ford)

    'index variables
    Dim index_sedan As Integer
    Dim index_truck As Integer
    Dim index_ford As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Pre-created objects of vehicle sub class (sedan)
        Dim sedan1 As New Sedan(200, 25000, "RED", 4.882)
        Dim sedan2 As New Sedan(180, 22500, "GREY", 4.879)

        'Pre-created objects of vehicle class (truck)
        Dim truck1 As New Truck(260, 32000, "BLACK", 8.234)
        Dim truck2 As New Truck(300, 45000, "YELLOW", 15.236)

        'Pre-created objects of vehicle class (ford)
        Dim ford1 As New Ford(145, 14000, "ORANGE", 2004, 1000)
        Dim ford2 As New Ford(225, 16500, "BLUE", 2009, 500)

        'adds sedan to list and item name to combo box
        arr_sedan.Add(sedan1)
        cb_main_sedans.Items.Add("Honda Accord")
        arr_sedan.Add(sedan2)
        cb_main_sedans.Items.Add("Toyota Camry")

        'adds truck to list and item name to combo box
        arr_truck.Add(truck1)
        cb_main_trucks.Items.Add("Ford F 150")
        arr_truck.Add(truck2)
        cb_main_trucks.Items.Add("Hummer")

        'adds ford to list and item name to combo box
        arr_ford.Add(ford1)
        cb_main_fords.Items.Add(ford1.Year & " Ford Focus")
        arr_ford.Add(ford2)
        cb_main_fords.Items.Add(ford2.Year & "Ford Fusion")

    End Sub


    'cb_sedans combo box
    Private Sub cb_main_sedans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_main_sedans.SelectedIndexChanged
        index_sedan = cb_main_sedans.SelectedIndex 'retrieves index of combo box
        lbl_main_show.Text = arr_sedan(index_sedan).ToString 'displays details according to arrays index position       
    End Sub

    'cb_trucks combo box
    Private Sub cb_main_trucks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_main_trucks.SelectedIndexChanged
        index_truck = cb_main_trucks.SelectedIndex 'retrieves index of combo box
        lbl_main_show.Text = arr_truck(index_truck).ToString 'displays details according to arrays index position
    End Sub

    Private Sub cb_main_fords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_main_fords.SelectedIndexChanged
        index_ford = cb_main_fords.SelectedIndex 'retrieves index of combo box
        lbl_main_show.Text = arr_ford(index_ford).ToString 'displays details according to arrays index position
    End Sub

    Private Sub btn_main_create_Click(sender As Object, e As EventArgs) Handles btn_main_create.Click
        Me.Hide()
        create_vehicle.Show()
    End Sub

    Private Sub btn_main_clear_Click(sender As Object, e As EventArgs) Handles btn_main_clear.Click
        lbl_main_show.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewVehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewVehicleToolStripMenuItem.Click
        Me.Hide()
        create_vehicle.Show()
    End Sub

    Private Sub VerisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerisonToolStripMenuItem.Click
        MsgBox("Version 10 trillion", MsgBoxStyle.Information)
    End Sub
End Class
