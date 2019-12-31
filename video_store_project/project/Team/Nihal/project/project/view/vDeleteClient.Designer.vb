<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vDeleteClient
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
        Me.btn_cancel_DClient = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbo_select_DClient = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_delete_DClient = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_DClient = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_email_DClient = New System.Windows.Forms.TextBox()
        Me.Addclient_txt = New System.Windows.Forms.Label()
        Me.mtx_number_DClient = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtx_postal_DClient = New System.Windows.Forms.MaskedTextBox()
        Me.mtx_dob_DClient = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_province_DClient = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_city_Dclient = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address_Dclient = New System.Windows.Forms.TextBox()
        Me.txt_age_DClient = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fname_DClient = New System.Windows.Forms.TextBox()
        Me.txt_lname_DClient = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel_DClient
        '
        Me.btn_cancel_DClient.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_cancel_DClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel_DClient.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_DClient.ForeColor = System.Drawing.Color.White
        Me.btn_cancel_DClient.Location = New System.Drawing.Point(455, 1030)
        Me.btn_cancel_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel_DClient.Name = "btn_cancel_DClient"
        Me.btn_cancel_DClient.Size = New System.Drawing.Size(399, 50)
        Me.btn_cancel_DClient.TabIndex = 36
        Me.btn_cancel_DClient.Text = "Cancel"
        Me.btn_cancel_DClient.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.cbo_select_DClient)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(33, 43)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(820, 123)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose a Client To Edit"
        '
        'cbo_select_DClient
        '
        Me.cbo_select_DClient.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_select_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cbo_select_DClient.FormattingEnabled = True
        Me.cbo_select_DClient.Location = New System.Drawing.Point(295, 44)
        Me.cbo_select_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.cbo_select_DClient.Name = "cbo_select_DClient"
        Me.cbo_select_DClient.Size = New System.Drawing.Size(437, 36)
        Me.cbo_select_DClient.TabIndex = 29
        Me.cbo_select_DClient.Text = "- Select Client -"
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label12.Location = New System.Drawing.Point(72, 41)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 37)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Clients"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(296, -25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(292, 60)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Delete Client"
        '
        'btn_delete_DClient
        '
        Me.btn_delete_DClient.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_delete_DClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete_DClient.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_DClient.ForeColor = System.Drawing.Color.White
        Me.btn_delete_DClient.Location = New System.Drawing.Point(35, 1030)
        Me.btn_delete_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete_DClient.Name = "btn_delete_DClient"
        Me.btn_delete_DClient.Size = New System.Drawing.Size(399, 50)
        Me.btn_delete_DClient.TabIndex = 35
        Me.btn_delete_DClient.Text = "Delete"
        Me.btn_delete_DClient.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txt_id_DClient)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_email_DClient)
        Me.GroupBox1.Controls.Add(Me.Addclient_txt)
        Me.GroupBox1.Controls.Add(Me.mtx_number_DClient)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.mtx_postal_DClient)
        Me.GroupBox1.Controls.Add(Me.mtx_dob_DClient)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_province_DClient)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_city_Dclient)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_address_Dclient)
        Me.GroupBox1.Controls.Add(Me.txt_age_DClient)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_fname_DClient)
        Me.GroupBox1.Controls.Add(Me.txt_lname_DClient)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(35, 189)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(819, 817)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Primary Information"
        '
        'txt_id_DClient
        '
        Me.txt_id_DClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_DClient.BackColor = System.Drawing.Color.White
        Me.txt_id_DClient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_id_DClient.Location = New System.Drawing.Point(297, 743)
        Me.txt_id_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id_DClient.Name = "txt_id_DClient"
        Me.txt_id_DClient.Size = New System.Drawing.Size(433, 34)
        Me.txt_id_DClient.TabIndex = 27
        Me.txt_id_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Location = New System.Drawing.Point(77, 252)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 37)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Telephone "
        '
        'txt_email_DClient
        '
        Me.txt_email_DClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email_DClient.BackColor = System.Drawing.Color.White
        Me.txt_email_DClient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_email_DClient.Location = New System.Drawing.Point(296, 193)
        Me.txt_email_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_email_DClient.Name = "txt_email_DClient"
        Me.txt_email_DClient.Size = New System.Drawing.Size(435, 34)
        Me.txt_email_DClient.TabIndex = 25
        Me.txt_email_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Addclient_txt
        '
        Me.Addclient_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Addclient_txt.AutoSize = True
        Me.Addclient_txt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addclient_txt.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Addclient_txt.Location = New System.Drawing.Point(75, 185)
        Me.Addclient_txt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Addclient_txt.Name = "Addclient_txt"
        Me.Addclient_txt.Size = New System.Drawing.Size(94, 37)
        Me.Addclient_txt.TabIndex = 24
        Me.Addclient_txt.Text = "Email "
        '
        'mtx_number_DClient
        '
        Me.mtx_number_DClient.BackColor = System.Drawing.Color.White
        Me.mtx_number_DClient.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_number_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_number_DClient.Location = New System.Drawing.Point(296, 263)
        Me.mtx_number_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_number_DClient.Mask = "(999) 000-0000"
        Me.mtx_number_DClient.Name = "mtx_number_DClient"
        Me.mtx_number_DClient.Size = New System.Drawing.Size(220, 34)
        Me.mtx_number_DClient.TabIndex = 23
        Me.mtx_number_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(81, 738)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 37)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Client number"
        '
        'mtx_postal_DClient
        '
        Me.mtx_postal_DClient.BackColor = System.Drawing.Color.White
        Me.mtx_postal_DClient.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_postal_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_postal_DClient.Location = New System.Drawing.Point(296, 673)
        Me.mtx_postal_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_postal_DClient.Mask = ">?#>? #>?#"
        Me.mtx_postal_DClient.Name = "mtx_postal_DClient"
        Me.mtx_postal_DClient.Size = New System.Drawing.Size(220, 34)
        Me.mtx_postal_DClient.TabIndex = 21
        Me.mtx_postal_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_postal_DClient.ValidatingType = GetType(Date)
        '
        'mtx_dob_DClient
        '
        Me.mtx_dob_DClient.BackColor = System.Drawing.Color.White
        Me.mtx_dob_DClient.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_dob_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_dob_DClient.Location = New System.Drawing.Point(296, 334)
        Me.mtx_dob_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_dob_DClient.Mask = "00/00/0000"
        Me.mtx_dob_DClient.Name = "mtx_dob_DClient"
        Me.mtx_dob_DClient.Size = New System.Drawing.Size(220, 34)
        Me.mtx_dob_DClient.TabIndex = 20
        Me.mtx_dob_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_dob_DClient.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(79, 663)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Postal code"
        '
        'txt_province_DClient
        '
        Me.txt_province_DClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_province_DClient.BackColor = System.Drawing.Color.White
        Me.txt_province_DClient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_province_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_province_DClient.Location = New System.Drawing.Point(296, 603)
        Me.txt_province_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_province_DClient.Name = "txt_province_DClient"
        Me.txt_province_DClient.Size = New System.Drawing.Size(433, 34)
        Me.txt_province_DClient.TabIndex = 17
        Me.txt_province_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(77, 594)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 37)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Province"
        '
        'txt_city_Dclient
        '
        Me.txt_city_Dclient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_city_Dclient.BackColor = System.Drawing.Color.White
        Me.txt_city_Dclient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_city_Dclient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_city_Dclient.Location = New System.Drawing.Point(296, 538)
        Me.txt_city_Dclient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_city_Dclient.Name = "txt_city_Dclient"
        Me.txt_city_Dclient.Size = New System.Drawing.Size(435, 34)
        Me.txt_city_Dclient.TabIndex = 15
        Me.txt_city_Dclient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(79, 529)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 37)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "City"
        '
        'txt_address_Dclient
        '
        Me.txt_address_Dclient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address_Dclient.BackColor = System.Drawing.Color.White
        Me.txt_address_Dclient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address_Dclient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_address_Dclient.Location = New System.Drawing.Point(296, 474)
        Me.txt_address_Dclient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_address_Dclient.Name = "txt_address_Dclient"
        Me.txt_address_Dclient.Size = New System.Drawing.Size(435, 34)
        Me.txt_address_Dclient.TabIndex = 13
        Me.txt_address_Dclient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_age_DClient
        '
        Me.txt_age_DClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_age_DClient.BackColor = System.Drawing.Color.White
        Me.txt_age_DClient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_age_DClient.Location = New System.Drawing.Point(296, 402)
        Me.txt_age_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_age_DClient.Name = "txt_age_DClient"
        Me.txt_age_DClient.Size = New System.Drawing.Size(435, 34)
        Me.txt_age_DClient.TabIndex = 12
        Me.txt_age_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(79, 465)
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
        Me.Label4.Location = New System.Drawing.Point(79, 393)
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
        Me.Label3.Location = New System.Drawing.Point(79, 324)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 37)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date of birth"
        '
        'txt_fname_DClient
        '
        Me.txt_fname_DClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_fname_DClient.BackColor = System.Drawing.Color.White
        Me.txt_fname_DClient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_fname_DClient.Location = New System.Drawing.Point(296, 63)
        Me.txt_fname_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fname_DClient.Name = "txt_fname_DClient"
        Me.txt_fname_DClient.Size = New System.Drawing.Size(435, 34)
        Me.txt_fname_DClient.TabIndex = 5
        Me.txt_fname_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_lname_DClient
        '
        Me.txt_lname_DClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lname_DClient.BackColor = System.Drawing.Color.White
        Me.txt_lname_DClient.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname_DClient.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_lname_DClient.Location = New System.Drawing.Point(296, 129)
        Me.txt_lname_DClient.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_lname_DClient.Name = "txt_lname_DClient"
        Me.txt_lname_DClient.Size = New System.Drawing.Size(435, 34)
        Me.txt_lname_DClient.TabIndex = 7
        Me.txt_lname_DClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(75, 54)
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
        Me.Label1.Location = New System.Drawing.Point(75, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Last name"
        '
        'vDeleteClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 1055)
        Me.Controls.Add(Me.btn_cancel_DClient)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_delete_DClient)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "vDeleteClient"
        Me.Text = "vDeleteClient"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel_DClient As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbo_select_DClient As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_delete_DClient As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_DClient As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_email_DClient As TextBox
    Friend WithEvents Addclient_txt As Label
    Friend WithEvents mtx_number_DClient As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mtx_postal_DClient As MaskedTextBox
    Friend WithEvents mtx_dob_DClient As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_province_DClient As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_city_Dclient As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_address_Dclient As TextBox
    Friend WithEvents txt_age_DClient As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_fname_DClient As TextBox
    Friend WithEvents txt_lname_DClient As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
