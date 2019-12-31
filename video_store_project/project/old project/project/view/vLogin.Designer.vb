<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmi_file_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_username_login = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_login_login = New System.Windows.Forms.Button()
        Me.txt_password_login = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(224, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_file_login})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmi_file_login
        '
        Me.tsmi_file_login.Name = "tsmi_file_login"
        Me.tsmi_file_login.Size = New System.Drawing.Size(37, 20)
        Me.tsmi_file_login.Text = "File"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(60, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'txt_username_login
        '
        Me.txt_username_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username_login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username_login.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_username_login.Location = New System.Drawing.Point(176, 141)
        Me.txt_username_login.Name = "txt_username_login"
        Me.txt_username_login.Size = New System.Drawing.Size(307, 22)
        Me.txt_username_login.TabIndex = 3
        Me.txt_username_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(65, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'btn_login_login
        '
        Me.btn_login_login.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login_login.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_login.ForeColor = System.Drawing.Color.White
        Me.btn_login_login.Location = New System.Drawing.Point(368, 264)
        Me.btn_login_login.Name = "btn_login_login"
        Me.btn_login_login.Size = New System.Drawing.Size(115, 41)
        Me.btn_login_login.TabIndex = 6
        Me.btn_login_login.Text = "login"
        Me.btn_login_login.UseVisualStyleBackColor = False
        '
        'txt_password_login
        '
        Me.txt_password_login.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password_login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_login.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_password_login.Location = New System.Drawing.Point(176, 202)
        Me.txt_password_login.Name = "txt_password_login"
        Me.txt_password_login.Size = New System.Drawing.Size(307, 22)
        Me.txt_password_login.TabIndex = 5
        Me.txt_password_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(544, 332)
        Me.Controls.Add(Me.btn_login_login)
        Me.Controls.Add(Me.txt_password_login)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_username_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "vLogin"
        Me.Text = "BlueBuster"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmi_file_login As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username_login As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login_login As Button
    Friend WithEvents txt_password_login As TextBox
End Class
