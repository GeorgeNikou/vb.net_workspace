<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_login_new = New System.Windows.Forms.Button()
        Me.btn_login_enter = New System.Windows.Forms.Button()
        Me.txt_login_username = New System.Windows.Forms.TextBox()
        Me.txt_login_password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.img_list1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ms_new = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.img_list2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ms_new.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'btn_login_new
        '
        Me.btn_login_new.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_new.Location = New System.Drawing.Point(144, 278)
        Me.btn_login_new.Name = "btn_login_new"
        Me.btn_login_new.Size = New System.Drawing.Size(184, 36)
        Me.btn_login_new.TabIndex = 3
        Me.btn_login_new.Text = "Create New"
        Me.btn_login_new.UseVisualStyleBackColor = True
        '
        'btn_login_enter
        '
        Me.btn_login_enter.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_enter.Location = New System.Drawing.Point(332, 278)
        Me.btn_login_enter.Name = "btn_login_enter"
        Me.btn_login_enter.Size = New System.Drawing.Size(101, 36)
        Me.btn_login_enter.TabIndex = 4
        Me.btn_login_enter.Text = "Enter"
        Me.btn_login_enter.UseVisualStyleBackColor = True
        '
        'txt_login_username
        '
        Me.txt_login_username.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_username.Location = New System.Drawing.Point(250, 133)
        Me.txt_login_username.Name = "txt_login_username"
        Me.txt_login_username.Size = New System.Drawing.Size(183, 41)
        Me.txt_login_username.TabIndex = 5
        '
        'txt_login_password
        '
        Me.txt_login_password.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_password.Location = New System.Drawing.Point(250, 194)
        Me.txt_login_password.Name = "txt_login_password"
        Me.txt_login_password.Size = New System.Drawing.Size(183, 41)
        Me.txt_login_password.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'img_list1
        '
        Me.img_list1.ImageStream = CType(resources.GetObject("img_list1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_list1.TransparentColor = System.Drawing.Color.Transparent
        Me.img_list1.Images.SetKeyName(0, "Squirrel.jpg")
        '
        'ms_new
        '
        Me.ms_new.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.ms_new.Location = New System.Drawing.Point(0, 0)
        Me.ms_new.Name = "ms_new"
        Me.ms_new.Size = New System.Drawing.Size(540, 28)
        Me.ms_new.TabIndex = 16
        Me.ms_new.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.LoginToolStripMenuItem.Text = "new user"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
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
        'img_list2
        '
        Me.img_list2.ImageStream = CType(resources.GetObject("img_list2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_list2.TransparentColor = System.Drawing.Color.Transparent
        Me.img_list2.Images.SetKeyName(0, "baby_chick.jpg")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 350)
        Me.Controls.Add(Me.ms_new)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_login_password)
        Me.Controls.Add(Me.txt_login_username)
        Me.Controls.Add(Me.btn_login_enter)
        Me.Controls.Add(Me.btn_login_new)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ms_new.ResumeLayout(False)
        Me.ms_new.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login_new As Button
    Friend WithEvents btn_login_enter As Button
    Friend WithEvents txt_login_username As TextBox
    Friend WithEvents txt_login_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents img_list1 As ImageList
    Friend WithEvents ms_new As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents img_list2 As ImageList
End Class
