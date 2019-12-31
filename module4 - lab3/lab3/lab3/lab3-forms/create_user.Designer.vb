<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_create
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_new_password = New System.Windows.Forms.TextBox()
        Me.txt_new_username = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_create_password = New System.Windows.Forms.TextBox()
        Me.txt_create_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_create_enter = New System.Windows.Forms.Button()
        Me.btn_create_cancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(48, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password: "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(48, 46)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(138, 32)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Username: "
        '
        'txt_new_password
        '
        Me.txt_new_password.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_password.Location = New System.Drawing.Point(224, 96)
        Me.txt_new_password.Name = "txt_new_password"
        Me.txt_new_password.Size = New System.Drawing.Size(171, 30)
        Me.txt_new_password.TabIndex = 7
        '
        'txt_new_username
        '
        Me.txt_new_username.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_username.Location = New System.Drawing.Point(224, 49)
        Me.txt_new_username.Name = "txt_new_username"
        Me.txt_new_username.Size = New System.Drawing.Size(171, 30)
        Me.txt_new_username.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.txt_create_password)
        Me.Panel1.Controls.Add(Me.txt_create_username)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(1, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 131)
        Me.Panel1.TabIndex = 8
        '
        'txt_create_password
        '
        Me.txt_create_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_create_password.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_create_password.Location = New System.Drawing.Point(197, 76)
        Me.txt_create_password.Name = "txt_create_password"
        Me.txt_create_password.Size = New System.Drawing.Size(171, 23)
        Me.txt_create_password.TabIndex = 5
        Me.txt_create_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_create_username
        '
        Me.txt_create_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_create_username.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_create_username.Location = New System.Drawing.Point(197, 29)
        Me.txt_create_username.Name = "txt_create_username"
        Me.txt_create_username.Size = New System.Drawing.Size(171, 23)
        Me.txt_create_username.TabIndex = 4
        Me.txt_create_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(42, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(42, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Username: "
        '
        'btn_create_enter
        '
        Me.btn_create_enter.AutoSize = True
        Me.btn_create_enter.BackColor = System.Drawing.Color.Orange
        Me.btn_create_enter.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_create_enter.Location = New System.Drawing.Point(293, 171)
        Me.btn_create_enter.Name = "btn_create_enter"
        Me.btn_create_enter.Size = New System.Drawing.Size(76, 33)
        Me.btn_create_enter.TabIndex = 6
        Me.btn_create_enter.Text = "Enter"
        Me.btn_create_enter.UseVisualStyleBackColor = False
        '
        'btn_create_cancel
        '
        Me.btn_create_cancel.AutoSize = True
        Me.btn_create_cancel.BackColor = System.Drawing.Color.Orange
        Me.btn_create_cancel.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_create_cancel.Location = New System.Drawing.Point(198, 171)
        Me.btn_create_cancel.Name = "btn_create_cancel"
        Me.btn_create_cancel.Size = New System.Drawing.Size(76, 33)
        Me.btn_create_cancel.TabIndex = 9
        Me.btn_create_cancel.Text = "Cancel"
        Me.btn_create_cancel.UseVisualStyleBackColor = False
        '
        'form_create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(473, 216)
        Me.Controls.Add(Me.btn_create_cancel)
        Me.Controls.Add(Me.btn_create_enter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_new_password)
        Me.Controls.Add(Me.txt_new_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "form_create"
        Me.Text = "New User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents txt_new_password As TextBox
    Friend WithEvents txt_new_username As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_create_password As TextBox
    Friend WithEvents txt_create_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_create_enter As Button
    Friend WithEvents btn_create_cancel As Button
End Class
