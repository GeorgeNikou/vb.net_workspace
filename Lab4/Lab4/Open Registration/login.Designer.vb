<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_login_username = New System.Windows.Forms.TextBox()
        Me.txt_login_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_login_cancel = New System.Windows.Forms.Button()
        Me.btn_login_submit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(45, 82)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(114, 25)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txt_login_username
        '
        Me.txt_login_username.BackColor = System.Drawing.SystemColors.Info
        Me.txt_login_username.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_username.Location = New System.Drawing.Point(175, 83)
        Me.txt_login_username.Name = "txt_login_username"
        Me.txt_login_username.Size = New System.Drawing.Size(214, 28)
        Me.txt_login_username.TabIndex = 7
        '
        'txt_login_password
        '
        Me.txt_login_password.BackColor = System.Drawing.SystemColors.Info
        Me.txt_login_password.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_password.Location = New System.Drawing.Point(175, 117)
        Me.txt_login_password.Name = "txt_login_password"
        Me.txt_login_password.Size = New System.Drawing.Size(214, 28)
        Me.txt_login_password.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Login Form"
        '
        'btn_login_cancel
        '
        Me.btn_login_cancel.BackColor = System.Drawing.Color.Gold
        Me.btn_login_cancel.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_cancel.Location = New System.Drawing.Point(209, 169)
        Me.btn_login_cancel.Name = "btn_login_cancel"
        Me.btn_login_cancel.Size = New System.Drawing.Size(87, 30)
        Me.btn_login_cancel.TabIndex = 11
        Me.btn_login_cancel.Text = "Cancel"
        Me.btn_login_cancel.UseVisualStyleBackColor = False
        '
        'btn_login_submit
        '
        Me.btn_login_submit.BackColor = System.Drawing.Color.Gold
        Me.btn_login_submit.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_submit.Location = New System.Drawing.Point(302, 169)
        Me.btn_login_submit.Name = "btn_login_submit"
        Me.btn_login_submit.Size = New System.Drawing.Size(87, 30)
        Me.btn_login_submit.TabIndex = 12
        Me.btn_login_submit.Text = "Login"
        Me.btn_login_submit.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab4.My.Resources.Resources.homer_nakie
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 224)
        Me.Controls.Add(Me.btn_login_submit)
        Me.Controls.Add(Me.btn_login_cancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_login_password)
        Me.Controls.Add(Me.txt_login_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_login_username As TextBox
    Friend WithEvents txt_login_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_login_cancel As Button
    Friend WithEvents btn_login_submit As Button
End Class
