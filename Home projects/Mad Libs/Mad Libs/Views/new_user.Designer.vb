<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_user
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
        Me.txt_new_password = New System.Windows.Forms.TextBox()
        Me.txt_new_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_new_submit = New System.Windows.Forms.Button()
        Me.btn_new_cancel = New System.Windows.Forms.Button()
        Me.lbl_new_result = New System.Windows.Forms.Label()
        Me.ms_new = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_new.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_new_password
        '
        Me.txt_new_password.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_password.Location = New System.Drawing.Point(260, 247)
        Me.txt_new_password.Name = "txt_new_password"
        Me.txt_new_password.Size = New System.Drawing.Size(183, 41)
        Me.txt_new_password.TabIndex = 10
        '
        'txt_new_username
        '
        Me.txt_new_username.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_username.Location = New System.Drawing.Point(260, 186)
        Me.txt_new_username.Name = "txt_new_username"
        Me.txt_new_username.Size = New System.Drawing.Size(183, 41)
        Me.txt_new_username.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 42)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 42)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 57)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Create user menu"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_new_submit
        '
        Me.btn_new_submit.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_submit.Location = New System.Drawing.Point(342, 328)
        Me.btn_new_submit.Name = "btn_new_submit"
        Me.btn_new_submit.Size = New System.Drawing.Size(101, 36)
        Me.btn_new_submit.TabIndex = 12
        Me.btn_new_submit.Text = "Submit"
        Me.btn_new_submit.UseVisualStyleBackColor = True
        '
        'btn_new_cancel
        '
        Me.btn_new_cancel.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_cancel.Location = New System.Drawing.Point(235, 328)
        Me.btn_new_cancel.Name = "btn_new_cancel"
        Me.btn_new_cancel.Size = New System.Drawing.Size(101, 36)
        Me.btn_new_cancel.TabIndex = 13
        Me.btn_new_cancel.Text = "Cancel"
        Me.btn_new_cancel.UseVisualStyleBackColor = True
        '
        'lbl_new_result
        '
        Me.lbl_new_result.AutoSize = True
        Me.lbl_new_result.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_result.Location = New System.Drawing.Point(94, 59)
        Me.lbl_new_result.Name = "lbl_new_result"
        Me.lbl_new_result.Size = New System.Drawing.Size(0, 25)
        Me.lbl_new_result.TabIndex = 14
        '
        'ms_new
        '
        Me.ms_new.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.ms_new.Location = New System.Drawing.Point(0, 0)
        Me.ms_new.Name = "ms_new"
        Me.ms_new.Size = New System.Drawing.Size(540, 28)
        Me.ms_new.TabIndex = 15
        Me.ms_new.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.BackToolStripMenuItem.Text = "exit"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'new_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 394)
        Me.Controls.Add(Me.lbl_new_result)
        Me.Controls.Add(Me.btn_new_cancel)
        Me.Controls.Add(Me.btn_new_submit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_new_password)
        Me.Controls.Add(Me.txt_new_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ms_new)
        Me.MainMenuStrip = Me.ms_new
        Me.Name = "new_user"
        Me.Text = "new_user"
        Me.ms_new.ResumeLayout(False)
        Me.ms_new.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_new_password As TextBox
    Friend WithEvents txt_new_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_new_submit As Button
    Friend WithEvents btn_new_cancel As Button
    Friend WithEvents lbl_new_result As Label
    Friend WithEvents ms_new As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
End Class
