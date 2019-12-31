<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ms_menu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pb_war = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_menu_saved = New System.Windows.Forms.ComboBox()
        Me.ms_menu.SuspendLayout()
        CType(Me.pb_war, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_menu
        '
        Me.ms_menu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ms_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.ms_menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_menu.Name = "ms_menu"
        Me.ms_menu.Size = New System.Drawing.Size(759, 28)
        Me.ms_menu.TabIndex = 16
        Me.ms_menu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BackToolStripMenuItem.Text = "exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'pb_war
        '
        Me.pb_war.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_war.Location = New System.Drawing.Point(1, 41)
        Me.pb_war.Name = "pb_war"
        Me.pb_war.Size = New System.Drawing.Size(203, 111)
        Me.pb_war.TabIndex = 17
        Me.pb_war.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(451, 59)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Mad Lib Main Menu"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Controls.Add(Me.pb_war)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(40, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 152)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "War"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Last date modified 10/19/2019"
        '
        'cb_menu_saved
        '
        Me.cb_menu_saved.Font = New System.Drawing.Font("Sitka Small", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_menu_saved.FormattingEnabled = True
        Me.cb_menu_saved.Location = New System.Drawing.Point(478, 103)
        Me.cb_menu_saved.Name = "cb_menu_saved"
        Me.cb_menu_saved.Size = New System.Drawing.Size(121, 26)
        Me.cb_menu_saved.TabIndex = 24
        Me.cb_menu_saved.Text = "- Saved Libs -"
        '
        'main_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(759, 605)
        Me.Controls.Add(Me.cb_menu_saved)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ms_menu)
        Me.Name = "main_menu"
        Me.Text = "Menu"
        Me.ms_menu.ResumeLayout(False)
        Me.ms_menu.PerformLayout()
        CType(Me.pb_war, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pb_war As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_menu_saved As ComboBox
End Class
