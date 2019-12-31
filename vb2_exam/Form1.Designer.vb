<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cb_main_sedans = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_main_trucks = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_main_fords = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_main_clear = New System.Windows.Forms.Button()
        Me.btn_main_create = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_main_show = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewVehicleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_main_sedans
        '
        Me.cb_main_sedans.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cb_main_sedans.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_main_sedans.ForeColor = System.Drawing.SystemColors.Window
        Me.cb_main_sedans.FormattingEnabled = True
        Me.cb_main_sedans.Location = New System.Drawing.Point(74, 147)
        Me.cb_main_sedans.Name = "cb_main_sedans"
        Me.cb_main_sedans.Size = New System.Drawing.Size(121, 22)
        Me.cb_main_sedans.TabIndex = 0
        Me.cb_main_sedans.Text = "- Select option -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(69, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sedans"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(69, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Trucks"
        '
        'cb_main_trucks
        '
        Me.cb_main_trucks.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cb_main_trucks.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_main_trucks.ForeColor = System.Drawing.SystemColors.Window
        Me.cb_main_trucks.FormattingEnabled = True
        Me.cb_main_trucks.Location = New System.Drawing.Point(74, 224)
        Me.cb_main_trucks.Name = "cb_main_trucks"
        Me.cb_main_trucks.Size = New System.Drawing.Size(121, 22)
        Me.cb_main_trucks.TabIndex = 2
        Me.cb_main_trucks.Text = "- Select option -"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(69, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fords"
        '
        'cb_main_fords
        '
        Me.cb_main_fords.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.cb_main_fords.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_main_fords.ForeColor = System.Drawing.SystemColors.Window
        Me.cb_main_fords.FormattingEnabled = True
        Me.cb_main_fords.Location = New System.Drawing.Point(74, 299)
        Me.cb_main_fords.Name = "cb_main_fords"
        Me.cb_main_fords.Size = New System.Drawing.Size(121, 22)
        Me.cb_main_fords.TabIndex = 4
        Me.cb_main_fords.Text = "- Select option -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(112, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(404, 45)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Vehicle Friendly Auto shop"
        '
        'btn_main_clear
        '
        Me.btn_main_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_main_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_main_clear.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_main_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_main_clear.Location = New System.Drawing.Point(401, 368)
        Me.btn_main_clear.Name = "btn_main_clear"
        Me.btn_main_clear.Size = New System.Drawing.Size(54, 23)
        Me.btn_main_clear.TabIndex = 8
        Me.btn_main_clear.Text = "Clear"
        Me.btn_main_clear.UseVisualStyleBackColor = False
        '
        'btn_main_create
        '
        Me.btn_main_create.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_main_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_main_create.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_main_create.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_main_create.Location = New System.Drawing.Point(461, 368)
        Me.btn_main_create.Name = "btn_main_create"
        Me.btn_main_create.Size = New System.Drawing.Size(110, 23)
        Me.btn_main_create.TabIndex = 10
        Me.btn_main_create.Text = "Create New"
        Me.btn_main_create.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Controls.Add(Me.lbl_main_show)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(291, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 223)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'lbl_main_show
        '
        Me.lbl_main_show.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_main_show.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_main_show.ForeColor = System.Drawing.Color.Orange
        Me.lbl_main_show.Location = New System.Drawing.Point(8, 22)
        Me.lbl_main_show.Name = "lbl_main_show"
        Me.lbl_main_show.Size = New System.Drawing.Size(266, 195)
        Me.lbl_main_show.TabIndex = 0
        Me.lbl_main_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewVehicleToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
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
        Me.VerisonToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerisonToolStripMenuItem.Text = "version"
        '
        'NewVehicleToolStripMenuItem
        '
        Me.NewVehicleToolStripMenuItem.Name = "NewVehicleToolStripMenuItem"
        Me.NewVehicleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewVehicleToolStripMenuItem.Text = "new vehicle"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vb2_exam.My.Resources.Resources.showroom
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(631, 407)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_main_create)
        Me.Controls.Add(Me.btn_main_clear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_main_fords)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_main_trucks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_main_sedans)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Auto Shop"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_main_sedans As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_main_trucks As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_main_fords As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_main_clear As Button
    Friend WithEvents btn_main_create As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_main_show As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewVehicleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerisonToolStripMenuItem As ToolStripMenuItem
End Class
