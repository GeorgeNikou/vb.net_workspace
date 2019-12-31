<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vDeleteEmployee
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
        Me.cbo_select_DeleteEmployee = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_next_DeleteEmployee = New System.Windows.Forms.Button()
        Me.btn_back_DeleteEmployee = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.mtx_number_DeleteEmployee = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtx_postal_DeleteEmployee = New System.Windows.Forms.MaskedTextBox()
        Me.mtx_dob_DeleteEmployee = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_province_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_city_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.txt_age_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fname_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.txt_lname_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ENumber_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbo_education_DeleteEmployee = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_password_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_username_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_Level_DeleteEmployee = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_NAS_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.txt_salary_DeleteEmployee = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.cbo_select_DeleteEmployee)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(436, 32)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(617, 73)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee to delete"
        '
        'cbo_select_DeleteEmployee
        '
        Me.cbo_select_DeleteEmployee.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbo_select_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.cbo_select_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbo_select_DeleteEmployee.FormattingEnabled = True
        Me.cbo_select_DeleteEmployee.Items.AddRange(New Object() {"linguini4 (Jose Wen) 521888998", "linguini3 (George Boursiquot) 56632235", "linguinimaster5 (Frank Etienne) 6699969"})
        Me.cbo_select_DeleteEmployee.Location = New System.Drawing.Point(8, 27)
        Me.cbo_select_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_select_DeleteEmployee.Name = "cbo_select_DeleteEmployee"
        Me.cbo_select_DeleteEmployee.Size = New System.Drawing.Size(600, 31)
        Me.cbo_select_DeleteEmployee.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(37, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(373, 60)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Delete Employee"
        '
        'btn_next_DeleteEmployee
        '
        Me.btn_next_DeleteEmployee.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_next_DeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next_DeleteEmployee.ForeColor = System.Drawing.Color.White
        Me.btn_next_DeleteEmployee.Location = New System.Drawing.Point(542, 609)
        Me.btn_next_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_next_DeleteEmployee.Name = "btn_next_DeleteEmployee"
        Me.btn_next_DeleteEmployee.Size = New System.Drawing.Size(511, 50)
        Me.btn_next_DeleteEmployee.TabIndex = 44
        Me.btn_next_DeleteEmployee.Text = "Delete"
        Me.btn_next_DeleteEmployee.UseVisualStyleBackColor = False
        '
        'btn_back_DeleteEmployee
        '
        Me.btn_back_DeleteEmployee.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_DeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_DeleteEmployee.ForeColor = System.Drawing.Color.White
        Me.btn_back_DeleteEmployee.Location = New System.Drawing.Point(24, 609)
        Me.btn_back_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back_DeleteEmployee.Name = "btn_back_DeleteEmployee"
        Me.btn_back_DeleteEmployee.Size = New System.Drawing.Size(511, 50)
        Me.btn_back_DeleteEmployee.TabIndex = 43
        Me.btn_back_DeleteEmployee.Text = "Back"
        Me.btn_back_DeleteEmployee.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.mtx_number_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.mtx_postal_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.mtx_dob_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_province_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_city_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_address_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.txt_age_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_fname_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.txt_lname_DeleteEmployee)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(24, 112)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(511, 464)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Primary Information"
        '
        'mtx_number_DeleteEmployee
        '
        Me.mtx_number_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.mtx_number_DeleteEmployee.Enabled = False
        Me.mtx_number_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_number_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_number_DeleteEmployee.Location = New System.Drawing.Point(249, 402)
        Me.mtx_number_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_number_DeleteEmployee.Mask = "(999) 000-0000"
        Me.mtx_number_DeleteEmployee.Name = "mtx_number_DeleteEmployee"
        Me.mtx_number_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.mtx_number_DeleteEmployee.TabIndex = 23
        Me.mtx_number_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(33, 398)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 37)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Home number"
        '
        'mtx_postal_DeleteEmployee
        '
        Me.mtx_postal_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.mtx_postal_DeleteEmployee.Enabled = False
        Me.mtx_postal_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_postal_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_postal_DeleteEmployee.Location = New System.Drawing.Point(249, 359)
        Me.mtx_postal_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_postal_DeleteEmployee.Mask = ">?#>? #>?#"
        Me.mtx_postal_DeleteEmployee.Name = "mtx_postal_DeleteEmployee"
        Me.mtx_postal_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.mtx_postal_DeleteEmployee.TabIndex = 21
        Me.mtx_postal_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_postal_DeleteEmployee.ValidatingType = GetType(Date)
        '
        'mtx_dob_DeleteEmployee
        '
        Me.mtx_dob_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.mtx_dob_DeleteEmployee.Enabled = False
        Me.mtx_dob_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_dob_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_dob_DeleteEmployee.Location = New System.Drawing.Point(248, 137)
        Me.mtx_dob_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_dob_DeleteEmployee.Mask = "00/00/0000"
        Me.mtx_dob_DeleteEmployee.Name = "mtx_dob_DeleteEmployee"
        Me.mtx_dob_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.mtx_dob_DeleteEmployee.TabIndex = 20
        Me.mtx_dob_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_dob_DeleteEmployee.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(33, 354)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Postal code"
        '
        'txt_province_DeleteEmployee
        '
        Me.txt_province_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_province_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_province_DeleteEmployee.Enabled = False
        Me.txt_province_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_province_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_province_DeleteEmployee.Location = New System.Drawing.Point(249, 311)
        Me.txt_province_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_province_DeleteEmployee.Name = "txt_province_DeleteEmployee"
        Me.txt_province_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.txt_province_DeleteEmployee.TabIndex = 17
        Me.txt_province_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(35, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 37)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Province"
        '
        'txt_city_DeleteEmployee
        '
        Me.txt_city_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_city_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_city_DeleteEmployee.Enabled = False
        Me.txt_city_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_city_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_city_DeleteEmployee.Location = New System.Drawing.Point(248, 268)
        Me.txt_city_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_city_DeleteEmployee.Name = "txt_city_DeleteEmployee"
        Me.txt_city_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.txt_city_DeleteEmployee.TabIndex = 15
        Me.txt_city_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(33, 263)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 37)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "City"
        '
        'txt_address_DeleteEmployee
        '
        Me.txt_address_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_address_DeleteEmployee.Enabled = False
        Me.txt_address_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_address_DeleteEmployee.Location = New System.Drawing.Point(248, 224)
        Me.txt_address_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_address_DeleteEmployee.Name = "txt_address_DeleteEmployee"
        Me.txt_address_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.txt_address_DeleteEmployee.TabIndex = 13
        Me.txt_address_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_age_DeleteEmployee
        '
        Me.txt_age_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_age_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_age_DeleteEmployee.Enabled = False
        Me.txt_age_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_age_DeleteEmployee.Location = New System.Drawing.Point(248, 181)
        Me.txt_age_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_age_DeleteEmployee.Name = "txt_age_DeleteEmployee"
        Me.txt_age_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.txt_age_DeleteEmployee.TabIndex = 12
        Me.txt_age_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(31, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label4.Location = New System.Drawing.Point(31, 176)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label3.Location = New System.Drawing.Point(31, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date of birth"
        '
        'txt_fname_DeleteEmployee
        '
        Me.txt_fname_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fname_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_fname_DeleteEmployee.Enabled = False
        Me.txt_fname_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_fname_DeleteEmployee.Location = New System.Drawing.Point(248, 42)
        Me.txt_fname_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fname_DeleteEmployee.Name = "txt_fname_DeleteEmployee"
        Me.txt_fname_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.txt_fname_DeleteEmployee.TabIndex = 5
        Me.txt_fname_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_lname_DeleteEmployee
        '
        Me.txt_lname_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lname_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_lname_DeleteEmployee.Enabled = False
        Me.txt_lname_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_lname_DeleteEmployee.Location = New System.Drawing.Point(248, 90)
        Me.txt_lname_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_lname_DeleteEmployee.Name = "txt_lname_DeleteEmployee"
        Me.txt_lname_DeleteEmployee.Size = New System.Drawing.Size(220, 34)
        Me.txt_lname_DeleteEmployee.TabIndex = 7
        Me.txt_lname_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(31, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label1.Location = New System.Drawing.Point(31, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Last name"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label13.Location = New System.Drawing.Point(31, 85)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 37)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "NAS"
        '
        'txt_ENumber_DeleteEmployee
        '
        Me.txt_ENumber_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ENumber_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_ENumber_DeleteEmployee.Enabled = False
        Me.txt_ENumber_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ENumber_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_ENumber_DeleteEmployee.Location = New System.Drawing.Point(293, 42)
        Me.txt_ENumber_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ENumber_DeleteEmployee.Name = "txt_ENumber_DeleteEmployee"
        Me.txt_ENumber_DeleteEmployee.Size = New System.Drawing.Size(187, 34)
        Me.txt_ENumber_DeleteEmployee.TabIndex = 19
        Me.txt_ENumber_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label14.Location = New System.Drawing.Point(31, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(250, 37)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Employee number"
        '
        'cbo_education_DeleteEmployee
        '
        Me.cbo_education_DeleteEmployee.Enabled = False
        Me.cbo_education_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_education_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbo_education_DeleteEmployee.FormattingEnabled = True
        Me.cbo_education_DeleteEmployee.Items.AddRange(New Object() {"DES", "AEC", "DEC", "Certificate", "BAC", "Master", "Doc"})
        Me.cbo_education_DeleteEmployee.Location = New System.Drawing.Point(252, 181)
        Me.cbo_education_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_education_DeleteEmployee.Name = "cbo_education_DeleteEmployee"
        Me.cbo_education_DeleteEmployee.Size = New System.Drawing.Size(228, 36)
        Me.cbo_education_DeleteEmployee.TabIndex = 17
        Me.cbo_education_DeleteEmployee.Text = "- Select Option -"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label12.Location = New System.Drawing.Point(31, 176)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 37)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Education"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txt_password_DeleteEmployee)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txt_username_DeleteEmployee)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.cbo_Level_DeleteEmployee)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox4.Location = New System.Drawing.Point(542, 375)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(511, 201)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Human Ressources"
        '
        'txt_password_DeleteEmployee
        '
        Me.txt_password_DeleteEmployee.Enabled = False
        Me.txt_password_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_password_DeleteEmployee.Location = New System.Drawing.Point(293, 139)
        Me.txt_password_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password_DeleteEmployee.Name = "txt_password_DeleteEmployee"
        Me.txt_password_DeleteEmployee.Size = New System.Drawing.Size(187, 34)
        Me.txt_password_DeleteEmployee.TabIndex = 26
        Me.txt_password_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label15.Location = New System.Drawing.Point(31, 134)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 37)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Password"
        '
        'txt_username_DeleteEmployee
        '
        Me.txt_username_DeleteEmployee.Enabled = False
        Me.txt_username_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_username_DeleteEmployee.Location = New System.Drawing.Point(293, 96)
        Me.txt_username_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username_DeleteEmployee.Name = "txt_username_DeleteEmployee"
        Me.txt_username_DeleteEmployee.Size = New System.Drawing.Size(187, 34)
        Me.txt_username_DeleteEmployee.TabIndex = 24
        Me.txt_username_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label16.Location = New System.Drawing.Point(31, 91)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(146, 37)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Username"
        '
        'cbo_Level_DeleteEmployee
        '
        Me.cbo_Level_DeleteEmployee.Enabled = False
        Me.cbo_Level_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Level_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbo_Level_DeleteEmployee.FormattingEnabled = True
        Me.cbo_Level_DeleteEmployee.Items.AddRange(New Object() {"level 1", "level 2", "level 3", "level 4"})
        Me.cbo_Level_DeleteEmployee.Location = New System.Drawing.Point(252, 48)
        Me.cbo_Level_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_Level_DeleteEmployee.Name = "cbo_Level_DeleteEmployee"
        Me.cbo_Level_DeleteEmployee.Size = New System.Drawing.Size(228, 36)
        Me.cbo_Level_DeleteEmployee.TabIndex = 22
        Me.cbo_Level_DeleteEmployee.Text = "- Select Option -"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label17.Location = New System.Drawing.Point(31, 43)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(169, 37)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Access level"
        '
        'txt_NAS_DeleteEmployee
        '
        Me.txt_NAS_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_NAS_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_NAS_DeleteEmployee.Enabled = False
        Me.txt_NAS_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NAS_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_NAS_DeleteEmployee.Location = New System.Drawing.Point(293, 90)
        Me.txt_NAS_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_NAS_DeleteEmployee.Name = "txt_NAS_DeleteEmployee"
        Me.txt_NAS_DeleteEmployee.Size = New System.Drawing.Size(187, 34)
        Me.txt_NAS_DeleteEmployee.TabIndex = 21
        Me.txt_NAS_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_salary_DeleteEmployee
        '
        Me.txt_salary_DeleteEmployee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_salary_DeleteEmployee.BackColor = System.Drawing.Color.White
        Me.txt_salary_DeleteEmployee.Enabled = False
        Me.txt_salary_DeleteEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salary_DeleteEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_salary_DeleteEmployee.Location = New System.Drawing.Point(293, 137)
        Me.txt_salary_DeleteEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_salary_DeleteEmployee.Name = "txt_salary_DeleteEmployee"
        Me.txt_salary_DeleteEmployee.Size = New System.Drawing.Size(187, 34)
        Me.txt_salary_DeleteEmployee.TabIndex = 23
        Me.txt_salary_DeleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Location = New System.Drawing.Point(31, 132)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 37)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Salary"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txt_salary_DeleteEmployee)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_NAS_DeleteEmployee)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_ENumber_DeleteEmployee)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbo_education_DeleteEmployee)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(542, 112)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(511, 256)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Human Ressources"
        '
        'vDeleteEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 687)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_next_DeleteEmployee)
        Me.Controls.Add(Me.btn_back_DeleteEmployee)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "vDeleteEmployee"
        Me.Text = "vDeleteEmployee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_select_DeleteEmployee As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_next_DeleteEmployee As Button
    Friend WithEvents btn_back_DeleteEmployee As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mtx_number_DeleteEmployee As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mtx_postal_DeleteEmployee As MaskedTextBox
    Friend WithEvents mtx_dob_DeleteEmployee As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_province_DeleteEmployee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_city_DeleteEmployee As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_address_DeleteEmployee As TextBox
    Friend WithEvents txt_age_DeleteEmployee As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_fname_DeleteEmployee As TextBox
    Friend WithEvents txt_lname_DeleteEmployee As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_ENumber_DeleteEmployee As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cbo_education_DeleteEmployee As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_password_DeleteEmployee As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_username_DeleteEmployee As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_Level_DeleteEmployee As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_NAS_DeleteEmployee As TextBox
    Friend WithEvents txt_salary_DeleteEmployee As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
