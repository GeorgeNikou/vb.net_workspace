<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_login_enter = New System.Windows.Forms.Button()
        Me.btn_login_create = New System.Windows.Forms.Button()
        Me.txt_login_username = New System.Windows.Forms.TextBox()
        Me.txt_login_password = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ms_login = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msi_login_create = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ms_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(42, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(138, 32)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Username: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(42, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password: "
        '
        'btn_login_enter
        '
        Me.btn_login_enter.AutoSize = True
        Me.btn_login_enter.BackColor = System.Drawing.Color.IndianRed
        Me.btn_login_enter.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login_enter.Location = New System.Drawing.Point(291, 216)
        Me.btn_login_enter.Name = "btn_login_enter"
        Me.btn_login_enter.Size = New System.Drawing.Size(81, 33)
        Me.btn_login_enter.TabIndex = 2
        Me.btn_login_enter.Text = "Enter"
        Me.btn_login_enter.UseVisualStyleBackColor = False
        '
        'btn_login_create
        '
        Me.btn_login_create.AutoSize = True
        Me.btn_login_create.BackColor = System.Drawing.Color.IndianRed
        Me.btn_login_create.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_create.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login_create.Location = New System.Drawing.Point(176, 216)
        Me.btn_login_create.Name = "btn_login_create"
        Me.btn_login_create.Size = New System.Drawing.Size(101, 33)
        Me.btn_login_create.TabIndex = 3
        Me.btn_login_create.Text = "Create"
        Me.btn_login_create.UseVisualStyleBackColor = False
        '
        'txt_login_username
        '
        Me.txt_login_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_login_username.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_username.Location = New System.Drawing.Point(197, 29)
        Me.txt_login_username.Name = "txt_login_username"
        Me.txt_login_username.Size = New System.Drawing.Size(171, 23)
        Me.txt_login_username.TabIndex = 4
        Me.txt_login_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_login_password
        '
        Me.txt_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_login_password.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_password.Location = New System.Drawing.Point(197, 76)
        Me.txt_login_password.Name = "txt_login_password"
        Me.txt_login_password.Size = New System.Drawing.Size(171, 23)
        Me.txt_login_password.TabIndex = 5
        Me.txt_login_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.txt_login_password)
        Me.Panel1.Controls.Add(Me.txt_login_username)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 131)
        Me.Panel1.TabIndex = 6
        '
        'ms_login
        '
        Me.ms_login.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_login.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ms_login.Location = New System.Drawing.Point(0, 0)
        Me.ms_login.Name = "ms_login"
        Me.ms_login.Size = New System.Drawing.Size(473, 28)
        Me.ms_login.TabIndex = 7
        Me.ms_login.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msi_login_create, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'msi_login_create
        '
        Me.msi_login_create.Name = "msi_login_create"
        Me.msi_login_create.Size = New System.Drawing.Size(127, 26)
        Me.msi_login_create.Text = "Create"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(127, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem, Me.AuthorToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.VersionToolStripMenuItem.Text = "version"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.AuthorToolStripMenuItem.Text = "author"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "blue_bg.jpg")
        Me.ImageList1.Images.SetKeyName(1, "petals.jpg")
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(473, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_login_create)
        Me.Controls.Add(Me.btn_login_enter)
        Me.Controls.Add(Me.ms_login)
        Me.MainMenuStrip = Me.ms_login
        Me.Name = "form_login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ms_login.ResumeLayout(False)
        Me.ms_login.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_login_enter As Button
    Friend WithEvents btn_login_create As Button
    Friend WithEvents txt_login_username As TextBox
    Friend WithEvents txt_login_password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ms_login As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msi_login_create As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
End Class
