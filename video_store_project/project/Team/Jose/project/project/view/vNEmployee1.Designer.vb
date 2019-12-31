<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vNEmployee1
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
        Me.btn_next_NEmployee1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mtx_number_NEmployee1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtx_postal_NEmployee1 = New System.Windows.Forms.MaskedTextBox()
        Me.mtx_dob_NEmployee1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_province_NEmployee1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_city_NEmployee1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address_NEmployee1 = New System.Windows.Forms.TextBox()
        Me.txt_age_NEmployee1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_lname_NEmployee1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_fname_NEmployee1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_next_NEmployee1
        '
        Me.btn_next_NEmployee1.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_next_NEmployee1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next_NEmployee1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next_NEmployee1.ForeColor = System.Drawing.Color.White
        Me.btn_next_NEmployee1.Location = New System.Drawing.Point(25, 723)
        Me.btn_next_NEmployee1.Name = "btn_next_NEmployee1"
        Me.btn_next_NEmployee1.Size = New System.Drawing.Size(614, 41)
        Me.btn_next_NEmployee1.TabIndex = 16
        Me.btn_next_NEmployee1.Text = "Next Step"
        Me.btn_next_NEmployee1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(210, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(333, 60)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "New Employee"
        '
        'mtx_number_NEmployee1
        '
        Me.mtx_number_NEmployee1.BackColor = System.Drawing.Color.White
        Me.mtx_number_NEmployee1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_number_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_number_NEmployee1.Location = New System.Drawing.Point(222, 482)
        Me.mtx_number_NEmployee1.Mask = "(999) 000-0000"
        Me.mtx_number_NEmployee1.Name = "mtx_number_NEmployee1"
        Me.mtx_number_NEmployee1.Size = New System.Drawing.Size(166, 34)
        Me.mtx_number_NEmployee1.TabIndex = 23
        Me.mtx_number_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(61, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 37)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Home number"
        '
        'mtx_postal_NEmployee1
        '
        Me.mtx_postal_NEmployee1.BackColor = System.Drawing.Color.White
        Me.mtx_postal_NEmployee1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_postal_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_postal_NEmployee1.Location = New System.Drawing.Point(222, 421)
        Me.mtx_postal_NEmployee1.Mask = ">?#>? #>?#"
        Me.mtx_postal_NEmployee1.Name = "mtx_postal_NEmployee1"
        Me.mtx_postal_NEmployee1.Size = New System.Drawing.Size(166, 34)
        Me.mtx_postal_NEmployee1.TabIndex = 21
        Me.mtx_postal_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_postal_NEmployee1.ValidatingType = GetType(Date)
        '
        'mtx_dob_NEmployee1
        '
        Me.mtx_dob_NEmployee1.BackColor = System.Drawing.Color.White
        Me.mtx_dob_NEmployee1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_dob_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_dob_NEmployee1.Location = New System.Drawing.Point(222, 162)
        Me.mtx_dob_NEmployee1.Mask = "00/00/0000"
        Me.mtx_dob_NEmployee1.Name = "mtx_dob_NEmployee1"
        Me.mtx_dob_NEmployee1.Size = New System.Drawing.Size(166, 34)
        Me.mtx_dob_NEmployee1.TabIndex = 20
        Me.mtx_dob_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_dob_NEmployee1.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(59, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Postal code"
        '
        'txt_province_NEmployee1
        '
        Me.txt_province_NEmployee1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_province_NEmployee1.BackColor = System.Drawing.Color.White
        Me.txt_province_NEmployee1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_province_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_province_NEmployee1.Location = New System.Drawing.Point(222, 364)
        Me.txt_province_NEmployee1.Name = "txt_province_NEmployee1"
        Me.txt_province_NEmployee1.Size = New System.Drawing.Size(326, 34)
        Me.txt_province_NEmployee1.TabIndex = 17
        Me.txt_province_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(58, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 37)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Province"
        '
        'txt_city_NEmployee1
        '
        Me.txt_city_NEmployee1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_city_NEmployee1.BackColor = System.Drawing.Color.White
        Me.txt_city_NEmployee1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_city_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_city_NEmployee1.Location = New System.Drawing.Point(222, 311)
        Me.txt_city_NEmployee1.Name = "txt_city_NEmployee1"
        Me.txt_city_NEmployee1.Size = New System.Drawing.Size(327, 34)
        Me.txt_city_NEmployee1.TabIndex = 15
        Me.txt_city_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(59, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 37)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "City"
        '
        'txt_address_NEmployee1
        '
        Me.txt_address_NEmployee1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address_NEmployee1.BackColor = System.Drawing.Color.White
        Me.txt_address_NEmployee1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_address_NEmployee1.Location = New System.Drawing.Point(222, 259)
        Me.txt_address_NEmployee1.Name = "txt_address_NEmployee1"
        Me.txt_address_NEmployee1.Size = New System.Drawing.Size(327, 34)
        Me.txt_address_NEmployee1.TabIndex = 13
        Me.txt_address_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_age_NEmployee1
        '
        Me.txt_age_NEmployee1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_age_NEmployee1.BackColor = System.Drawing.Color.White
        Me.txt_age_NEmployee1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_age_NEmployee1.Location = New System.Drawing.Point(222, 214)
        Me.txt_age_NEmployee1.Name = "txt_age_NEmployee1"
        Me.txt_age_NEmployee1.Size = New System.Drawing.Size(327, 34)
        Me.txt_age_NEmployee1.TabIndex = 12
        Me.txt_age_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(59, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 37)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Location = New System.Drawing.Point(59, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 37)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Age"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(59, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date of birth"
        '
        'txt_lname_NEmployee1
        '
        Me.txt_lname_NEmployee1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lname_NEmployee1.BackColor = System.Drawing.Color.White
        Me.txt_lname_NEmployee1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_lname_NEmployee1.Location = New System.Drawing.Point(222, 105)
        Me.txt_lname_NEmployee1.Name = "txt_lname_NEmployee1"
        Me.txt_lname_NEmployee1.Size = New System.Drawing.Size(327, 34)
        Me.txt_lname_NEmployee1.TabIndex = 7
        Me.txt_lname_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(56, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First name"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(56, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Last name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.mtx_number_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mtx_postal_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.mtx_dob_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_province_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_city_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_address_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.txt_age_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_fname_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.txt_lname_NEmployee1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(25, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 552)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1/3 - primary information"
        '
        'txt_fname_NEmployee1
        '
        Me.txt_fname_NEmployee1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fname_NEmployee1.BackColor = System.Drawing.Color.White
        Me.txt_fname_NEmployee1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname_NEmployee1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_fname_NEmployee1.Location = New System.Drawing.Point(222, 51)
        Me.txt_fname_NEmployee1.Name = "txt_fname_NEmployee1"
        Me.txt_fname_NEmployee1.Size = New System.Drawing.Size(327, 34)
        Me.txt_fname_NEmployee1.TabIndex = 5
        Me.txt_fname_NEmployee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vNEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 797)
        Me.Controls.Add(Me.btn_next_NEmployee1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "vNEmployee"
        Me.Text = "vNEmployee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_next_NEmployee1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents mtx_number_NEmployee1 As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mtx_postal_NEmployee1 As MaskedTextBox
    Friend WithEvents mtx_dob_NEmployee1 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_province_NEmployee1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_city_NEmployee1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_address_NEmployee1 As TextBox
    Friend WithEvents txt_age_NEmployee1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lname_NEmployee1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_fname_NEmployee1 As TextBox
End Class
