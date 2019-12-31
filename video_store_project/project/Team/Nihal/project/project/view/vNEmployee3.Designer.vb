<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vNEmployee3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_password_NEmployee3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username_NEmployee3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_Level_NEmployee2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_back_NEmployee3 = New System.Windows.Forms.Button()
        Me.btn_next_NEmployee3 = New System.Windows.Forms.Button()
        Me.cbo_activate_NEmployee3 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txt_password_NEmployee3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_username_NEmployee3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_Level_NEmployee2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(27, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 263)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 3/3 - system information"
        '
        'txt_password_NEmployee3
        '
        Me.txt_password_NEmployee3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_NEmployee3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_password_NEmployee3.Location = New System.Drawing.Point(256, 187)
        Me.txt_password_NEmployee3.Name = "txt_password_NEmployee3"
        Me.txt_password_NEmployee3.Size = New System.Drawing.Size(296, 29)
        Me.txt_password_NEmployee3.TabIndex = 20
        Me.txt_password_NEmployee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(59, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 30)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Password"
        '
        'txt_username_NEmployee3
        '
        Me.txt_username_NEmployee3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username_NEmployee3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_username_NEmployee3.Location = New System.Drawing.Point(256, 130)
        Me.txt_username_NEmployee3.Name = "txt_username_NEmployee3"
        Me.txt_username_NEmployee3.Size = New System.Drawing.Size(296, 29)
        Me.txt_username_NEmployee3.TabIndex = 18
        Me.txt_username_NEmployee3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(59, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 30)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username"
        '
        'cbo_Level_NEmployee2
        '
        Me.cbo_Level_NEmployee2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Level_NEmployee2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbo_Level_NEmployee2.FormattingEnabled = True
        Me.cbo_Level_NEmployee2.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4"})
        Me.cbo_Level_NEmployee2.Location = New System.Drawing.Point(256, 63)
        Me.cbo_Level_NEmployee2.Name = "cbo_Level_NEmployee2"
        Me.cbo_Level_NEmployee2.Size = New System.Drawing.Size(172, 29)
        Me.cbo_Level_NEmployee2.TabIndex = 16
        Me.cbo_Level_NEmployee2.Text = "- Select Option -"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(59, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Access level"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(204, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(266, 47)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "New Employee"
        '
        'btn_back_NEmployee3
        '
        Me.btn_back_NEmployee3.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_NEmployee3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_NEmployee3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_NEmployee3.ForeColor = System.Drawing.Color.White
        Me.btn_back_NEmployee3.Location = New System.Drawing.Point(26, 541)
        Me.btn_back_NEmployee3.Name = "btn_back_NEmployee3"
        Me.btn_back_NEmployee3.Size = New System.Drawing.Size(284, 41)
        Me.btn_back_NEmployee3.TabIndex = 29
        Me.btn_back_NEmployee3.Text = "Back"
        Me.btn_back_NEmployee3.UseVisualStyleBackColor = False
        '
        'btn_next_NEmployee3
        '
        Me.btn_next_NEmployee3.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_next_NEmployee3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next_NEmployee3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next_NEmployee3.ForeColor = System.Drawing.Color.White
        Me.btn_next_NEmployee3.Location = New System.Drawing.Point(356, 541)
        Me.btn_next_NEmployee3.Name = "btn_next_NEmployee3"
        Me.btn_next_NEmployee3.Size = New System.Drawing.Size(284, 41)
        Me.btn_next_NEmployee3.TabIndex = 28
        Me.btn_next_NEmployee3.Text = "Finalize"
        Me.btn_next_NEmployee3.UseVisualStyleBackColor = False
        '
        'cbo_activate_NEmployee3
        '
        Me.cbo_activate_NEmployee3.AutoSize = True
        Me.cbo_activate_NEmployee3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_activate_NEmployee3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cbo_activate_NEmployee3.Location = New System.Drawing.Point(27, 473)
        Me.cbo_activate_NEmployee3.Name = "cbo_activate_NEmployee3"
        Me.cbo_activate_NEmployee3.Size = New System.Drawing.Size(121, 21)
        Me.cbo_activate_NEmployee3.TabIndex = 27
        Me.cbo_activate_NEmployee3.Text = "Activate account"
        Me.cbo_activate_NEmployee3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(23, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(617, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Note: If you do not provide a password then a default password will be given (Her" &
    "zing)"
        '
        'vNEmployee3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 624)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_back_NEmployee3)
        Me.Controls.Add(Me.btn_next_NEmployee3)
        Me.Controls.Add(Me.cbo_activate_NEmployee3)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "vNEmployee3"
        Me.Text = "vNEmployee3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_password_NEmployee3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username_NEmployee3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_Level_NEmployee2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_back_NEmployee3 As Button
    Friend WithEvents btn_next_NEmployee3 As Button
    Friend WithEvents cbo_activate_NEmployee3 As CheckBox
    Friend WithEvents Label4 As Label
End Class
