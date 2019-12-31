<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_vehicle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(create_vehicle))
        Me.btn_create = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gb_rdos = New System.Windows.Forms.GroupBox()
        Me.rdo_ford = New System.Windows.Forms.RadioButton()
        Me.rdo_truck = New System.Windows.Forms.RadioButton()
        Me.rdo_sedan = New System.Windows.Forms.RadioButton()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.img_list = New System.Windows.Forms.ImageList(Me.components)
        Me.picb_1 = New System.Windows.Forms.PictureBox()
        Me.picb_2 = New System.Windows.Forms.PictureBox()
        Me.picb_3 = New System.Windows.Forms.PictureBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_speed = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_rdos.SuspendLayout()
        CType(Me.picb_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picb_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picb_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_create.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_create.Location = New System.Drawing.Point(440, 337)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(93, 23)
        Me.btn_create.TabIndex = 11
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(40, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(40, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Speed: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(40, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Color: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(40, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Weight: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(335, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Year: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(295, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Discount: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(323, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Price: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(148, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(299, 45)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Create New Vehicle"
        '
        'gb_rdos
        '
        Me.gb_rdos.BackColor = System.Drawing.SystemColors.ControlDark
        Me.gb_rdos.Controls.Add(Me.rdo_ford)
        Me.gb_rdos.Controls.Add(Me.rdo_truck)
        Me.gb_rdos.Controls.Add(Me.rdo_sedan)
        Me.gb_rdos.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_rdos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gb_rdos.Location = New System.Drawing.Point(328, 100)
        Me.gb_rdos.Name = "gb_rdos"
        Me.gb_rdos.Size = New System.Drawing.Size(205, 45)
        Me.gb_rdos.TabIndex = 27
        Me.gb_rdos.TabStop = False
        Me.gb_rdos.Text = "Type"
        '
        'rdo_ford
        '
        Me.rdo_ford.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_ford.Location = New System.Drawing.Point(135, 21)
        Me.rdo_ford.Name = "rdo_ford"
        Me.rdo_ford.Size = New System.Drawing.Size(64, 18)
        Me.rdo_ford.TabIndex = 2
        Me.rdo_ford.Text = "Ford"
        Me.rdo_ford.UseVisualStyleBackColor = True
        '
        'rdo_truck
        '
        Me.rdo_truck.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_truck.Location = New System.Drawing.Point(70, 21)
        Me.rdo_truck.Name = "rdo_truck"
        Me.rdo_truck.Size = New System.Drawing.Size(64, 18)
        Me.rdo_truck.TabIndex = 1
        Me.rdo_truck.Text = "Truck"
        Me.rdo_truck.UseVisualStyleBackColor = True
        '
        'rdo_sedan
        '
        Me.rdo_sedan.Checked = True
        Me.rdo_sedan.Font = New System.Drawing.Font("Californian FB", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_sedan.Location = New System.Drawing.Point(10, 21)
        Me.rdo_sedan.Name = "rdo_sedan"
        Me.rdo_sedan.Size = New System.Drawing.Size(64, 18)
        Me.rdo_sedan.TabIndex = 0
        Me.rdo_sedan.TabStop = True
        Me.rdo_sedan.Text = "Sedan"
        Me.rdo_sedan.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancel.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_cancel.Location = New System.Drawing.Point(338, 337)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(93, 23)
        Me.btn_cancel.TabIndex = 28
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(40, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 23)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Length: "
        '
        'img_list
        '
        Me.img_list.ImageStream = CType(resources.GetObject("img_list.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_list.TransparentColor = System.Drawing.Color.Transparent
        Me.img_list.Images.SetKeyName(0, "pic1.jpg")
        Me.img_list.Images.SetKeyName(1, "pic2.jpg")
        Me.img_list.Images.SetKeyName(2, "pic3.jpg")
        '
        'picb_1
        '
        Me.picb_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picb_1.Location = New System.Drawing.Point(12, 412)
        Me.picb_1.Name = "picb_1"
        Me.picb_1.Size = New System.Drawing.Size(168, 156)
        Me.picb_1.TabIndex = 31
        Me.picb_1.TabStop = False
        '
        'picb_2
        '
        Me.picb_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picb_2.Location = New System.Drawing.Point(208, 412)
        Me.picb_2.Name = "picb_2"
        Me.picb_2.Size = New System.Drawing.Size(168, 156)
        Me.picb_2.TabIndex = 33
        Me.picb_2.TabStop = False
        '
        'picb_3
        '
        Me.picb_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picb_3.Location = New System.Drawing.Point(401, 412)
        Me.picb_3.Name = "picb_3"
        Me.picb_3.Size = New System.Drawing.Size(168, 156)
        Me.picb_3.TabIndex = 34
        Me.picb_3.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_name.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Orange
        Me.txt_name.Location = New System.Drawing.Point(138, 105)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(128, 22)
        Me.txt_name.TabIndex = 35
        '
        'txt_speed
        '
        Me.txt_speed.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_speed.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_speed.ForeColor = System.Drawing.Color.Orange
        Me.txt_speed.Location = New System.Drawing.Point(138, 162)
        Me.txt_speed.Name = "txt_speed"
        Me.txt_speed.Size = New System.Drawing.Size(128, 22)
        Me.txt_speed.TabIndex = 36
        '
        'txt_color
        '
        Me.txt_color.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_color.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.ForeColor = System.Drawing.Color.Orange
        Me.txt_color.Location = New System.Drawing.Point(138, 221)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Size = New System.Drawing.Size(128, 22)
        Me.txt_color.TabIndex = 37
        '
        'txt_weight
        '
        Me.txt_weight.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_weight.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_weight.ForeColor = System.Drawing.Color.Orange
        Me.txt_weight.Location = New System.Drawing.Point(138, 280)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(128, 22)
        Me.txt_weight.TabIndex = 38
        '
        'txt_length
        '
        Me.txt_length.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_length.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_length.ForeColor = System.Drawing.Color.Orange
        Me.txt_length.Location = New System.Drawing.Point(138, 338)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(128, 22)
        Me.txt_length.TabIndex = 39
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_year.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.ForeColor = System.Drawing.Color.Orange
        Me.txt_year.Location = New System.Drawing.Point(405, 164)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(128, 22)
        Me.txt_year.TabIndex = 40
        '
        'txt_discount
        '
        Me.txt_discount.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_discount.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.ForeColor = System.Drawing.Color.Orange
        Me.txt_discount.Location = New System.Drawing.Point(405, 221)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(128, 22)
        Me.txt_discount.TabIndex = 41
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.MenuText
        Me.txt_price.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.Orange
        Me.txt_price.Location = New System.Drawing.Point(405, 280)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(128, 22)
        Me.txt_price.TabIndex = 42
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(581, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewVehicleToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewVehicleToolStripMenuItem
        '
        Me.NewVehicleToolStripMenuItem.Name = "NewVehicleToolStripMenuItem"
        Me.NewVehicleToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.NewVehicleToolStripMenuItem.Text = "back"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerisonToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VerisonToolStripMenuItem
        '
        Me.VerisonToolStripMenuItem.Name = "VerisonToolStripMenuItem"
        Me.VerisonToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.VerisonToolStripMenuItem.Text = "version"
        '
        'create_vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.vb2_exam.My.Resources.Resources.aboutgallery1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(581, 390)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_length)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.txt_color)
        Me.Controls.Add(Me.txt_speed)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.picb_3)
        Me.Controls.Add(Me.picb_2)
        Me.Controls.Add(Me.picb_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.gb_rdos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_create)
        Me.Name = "create_vehicle"
        Me.Text = "create_vehicle"
        Me.gb_rdos.ResumeLayout(False)
        CType(Me.picb_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picb_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picb_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_create As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gb_rdos As GroupBox
    Friend WithEvents rdo_ford As RadioButton
    Friend WithEvents rdo_truck As RadioButton
    Friend WithEvents rdo_sedan As RadioButton
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents img_list As ImageList
    Friend WithEvents picb_1 As PictureBox
    Friend WithEvents picb_2 As PictureBox
    Friend WithEvents picb_3 As PictureBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_speed As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents txt_length As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerisonToolStripMenuItem As ToolStripMenuItem
End Class
