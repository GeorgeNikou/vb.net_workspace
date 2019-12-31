<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vNEmployee2
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
        Me.mtx_DCreated_NEmployee2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_education_NEmployee2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_salary_NEmployee2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_NAS_NEmployee2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ENumber_NEmployee2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_back_NEmployee2 = New System.Windows.Forms.Button()
        Me.btn_next_NEmployee2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.mtx_DCreated_NEmployee2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbo_education_NEmployee2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_salary_NEmployee2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_NAS_NEmployee2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ENumber_NEmployee2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(34, 173)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 439)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 2/3 - human resources"
        '
        'mtx_DCreated_NEmployee2
        '
        Me.mtx_DCreated_NEmployee2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_DCreated_NEmployee2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_DCreated_NEmployee2.Location = New System.Drawing.Point(341, 369)
        Me.mtx_DCreated_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_DCreated_NEmployee2.Mask = "00/00/0000"
        Me.mtx_DCreated_NEmployee2.Name = "mtx_DCreated_NEmployee2"
        Me.mtx_DCreated_NEmployee2.Size = New System.Drawing.Size(228, 34)
        Me.mtx_DCreated_NEmployee2.TabIndex = 15
        Me.mtx_DCreated_NEmployee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_DCreated_NEmployee2.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(79, 368)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Date started"
        '
        'cbo_education_NEmployee2
        '
        Me.cbo_education_NEmployee2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_education_NEmployee2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbo_education_NEmployee2.FormattingEnabled = True
        Me.cbo_education_NEmployee2.Items.AddRange(New Object() {"DES", "AEC", "DEC", "Certificate", "BAC", "Master", "Doc"})
        Me.cbo_education_NEmployee2.Location = New System.Drawing.Point(341, 297)
        Me.cbo_education_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_education_NEmployee2.Name = "cbo_education_NEmployee2"
        Me.cbo_education_NEmployee2.Size = New System.Drawing.Size(228, 36)
        Me.cbo_education_NEmployee2.TabIndex = 13
        Me.cbo_education_NEmployee2.Text = "- Select Option -"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Location = New System.Drawing.Point(79, 297)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Education"
        '
        'txt_salary_NEmployee2
        '
        Me.txt_salary_NEmployee2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_salary_NEmployee2.BackColor = System.Drawing.Color.White
        Me.txt_salary_NEmployee2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salary_NEmployee2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_salary_NEmployee2.Location = New System.Drawing.Point(341, 223)
        Me.txt_salary_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_salary_NEmployee2.Name = "txt_salary_NEmployee2"
        Me.txt_salary_NEmployee2.Size = New System.Drawing.Size(393, 34)
        Me.txt_salary_NEmployee2.TabIndex = 11
        Me.txt_salary_NEmployee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(79, 218)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 37)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Salary"
        '
        'txt_NAS_NEmployee2
        '
        Me.txt_NAS_NEmployee2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_NAS_NEmployee2.BackColor = System.Drawing.Color.White
        Me.txt_NAS_NEmployee2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NAS_NEmployee2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_NAS_NEmployee2.Location = New System.Drawing.Point(341, 146)
        Me.txt_NAS_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_NAS_NEmployee2.Name = "txt_NAS_NEmployee2"
        Me.txt_NAS_NEmployee2.Size = New System.Drawing.Size(393, 34)
        Me.txt_NAS_NEmployee2.TabIndex = 9
        Me.txt_NAS_NEmployee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(79, 142)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "NAS"
        '
        'txt_ENumber_NEmployee2
        '
        Me.txt_ENumber_NEmployee2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ENumber_NEmployee2.BackColor = System.Drawing.Color.White
        Me.txt_ENumber_NEmployee2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ENumber_NEmployee2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_ENumber_NEmployee2.Location = New System.Drawing.Point(341, 74)
        Me.txt_ENumber_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ENumber_NEmployee2.Name = "txt_ENumber_NEmployee2"
        Me.txt_ENumber_NEmployee2.Size = New System.Drawing.Size(393, 34)
        Me.txt_ENumber_NEmployee2.TabIndex = 7
        Me.txt_ENumber_NEmployee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(79, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee number"
        '
        'btn_back_NEmployee2
        '
        Me.btn_back_NEmployee2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_NEmployee2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_NEmployee2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_NEmployee2.ForeColor = System.Drawing.Color.White
        Me.btn_back_NEmployee2.Location = New System.Drawing.Point(34, 660)
        Me.btn_back_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back_NEmployee2.Name = "btn_back_NEmployee2"
        Me.btn_back_NEmployee2.Size = New System.Drawing.Size(379, 50)
        Me.btn_back_NEmployee2.TabIndex = 20
        Me.btn_back_NEmployee2.Text = "Back"
        Me.btn_back_NEmployee2.UseVisualStyleBackColor = False
        '
        'btn_next_NEmployee2
        '
        Me.btn_next_NEmployee2.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_next_NEmployee2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next_NEmployee2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next_NEmployee2.ForeColor = System.Drawing.Color.White
        Me.btn_next_NEmployee2.Location = New System.Drawing.Point(474, 660)
        Me.btn_next_NEmployee2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_next_NEmployee2.Name = "btn_next_NEmployee2"
        Me.btn_next_NEmployee2.Size = New System.Drawing.Size(379, 50)
        Me.btn_next_NEmployee2.TabIndex = 19
        Me.btn_next_NEmployee2.Text = "Next Step"
        Me.btn_next_NEmployee2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(269, 48)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(333, 60)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "New Employee"
        '
        'vNEmployee2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 758)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_back_NEmployee2)
        Me.Controls.Add(Me.btn_next_NEmployee2)
        Me.Controls.Add(Me.Label10)
        Me.Name = "vNEmployee2"
        Me.Text = "vNEmployee2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtx_DCreated_NEmployee2 As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbo_education_NEmployee2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_salary_NEmployee2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_NAS_NEmployee2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ENumber_NEmployee2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_back_NEmployee2 As Button
    Friend WithEvents btn_next_NEmployee2 As Button
    Friend WithEvents Label10 As Label
End Class
