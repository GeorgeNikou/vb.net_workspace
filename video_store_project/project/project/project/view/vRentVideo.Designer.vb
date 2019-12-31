<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vRentVideo
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtx_number_RentVideo = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_address_RentVideo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name_RentVideo = New System.Windows.Forms.TextBox()
        Me.pb_Cid_RentVideo = New System.Windows.Forms.PictureBox()
        Me.txt_Client_RentVideo = New System.Windows.Forms.TextBox()
        Me.txt_director_RentVideo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_language_RentVideo = New System.Windows.Forms.TextBox()
        Me.txt_title_RentVideo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Video_RentVideo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pb_poster_RentVideo = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Resume_RentVideo = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pb_Vid_RentVideo = New System.Windows.Forms.PictureBox()
        Me.btn_cancel_RentVideo = New System.Windows.Forms.Button()
        Me.btn_rent_RentVideo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_Cid_RentVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_poster_RentVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Vid_RentVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(284, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(201, 47)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Rent Video"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Location = New System.Drawing.Point(22, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 30)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Telephone"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(22, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 30)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Client Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.mtx_number_RentVideo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_address_RentVideo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_name_RentVideo)
        Me.GroupBox1.Controls.Add(Me.pb_Cid_RentVideo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Client_RentVideo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(70, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 270)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client's Information"
        '
        'mtx_number_RentVideo
        '
        Me.mtx_number_RentVideo.BackColor = System.Drawing.Color.White
        Me.mtx_number_RentVideo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_number_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_number_RentVideo.Location = New System.Drawing.Point(188, 198)
        Me.mtx_number_RentVideo.Mask = "999 000 0000"
        Me.mtx_number_RentVideo.Name = "mtx_number_RentVideo"
        Me.mtx_number_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.mtx_number_RentVideo.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(22, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 30)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Address "
        '
        'txt_address_RentVideo
        '
        Me.txt_address_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_address_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_address_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_address_RentVideo.Location = New System.Drawing.Point(188, 151)
        Me.txt_address_RentVideo.Name = "txt_address_RentVideo"
        Me.txt_address_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_address_RentVideo.TabIndex = 23
        Me.txt_address_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(22, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Name"
        '
        'txt_name_RentVideo
        '
        Me.txt_name_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_name_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_name_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_name_RentVideo.Location = New System.Drawing.Point(188, 98)
        Me.txt_name_RentVideo.Name = "txt_name_RentVideo"
        Me.txt_name_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_name_RentVideo.TabIndex = 21
        Me.txt_name_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb_Cid_RentVideo
        '
        Me.pb_Cid_RentVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Cid_RentVideo.Location = New System.Drawing.Point(527, 44)
        Me.pb_Cid_RentVideo.Name = "pb_Cid_RentVideo"
        Me.pb_Cid_RentVideo.Size = New System.Drawing.Size(31, 29)
        Me.pb_Cid_RentVideo.TabIndex = 19
        Me.pb_Cid_RentVideo.TabStop = False
        '
        'txt_Client_RentVideo
        '
        Me.txt_Client_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Client_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_Client_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Client_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_Client_RentVideo.Location = New System.Drawing.Point(188, 44)
        Me.txt_Client_RentVideo.Name = "txt_Client_RentVideo"
        Me.txt_Client_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_Client_RentVideo.TabIndex = 18
        Me.txt_Client_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_director_RentVideo
        '
        Me.txt_director_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_director_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_director_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_director_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_director_RentVideo.Location = New System.Drawing.Point(188, 203)
        Me.txt_director_RentVideo.Name = "txt_director_RentVideo"
        Me.txt_director_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_director_RentVideo.TabIndex = 31
        Me.txt_director_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(22, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 30)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Language"
        '
        'txt_language_RentVideo
        '
        Me.txt_language_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_language_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_language_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_language_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_language_RentVideo.Location = New System.Drawing.Point(188, 151)
        Me.txt_language_RentVideo.Name = "txt_language_RentVideo"
        Me.txt_language_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_language_RentVideo.TabIndex = 23
        Me.txt_language_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_title_RentVideo
        '
        Me.txt_title_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_title_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_title_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_title_RentVideo.Location = New System.Drawing.Point(188, 98)
        Me.txt_title_RentVideo.Name = "txt_title_RentVideo"
        Me.txt_title_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_title_RentVideo.TabIndex = 21
        Me.txt_title_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(22, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 30)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Video ID"
        '
        'txt_Video_RentVideo
        '
        Me.txt_Video_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Video_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_Video_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Video_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_Video_RentVideo.Location = New System.Drawing.Point(188, 44)
        Me.txt_Video_RentVideo.Name = "txt_Video_RentVideo"
        Me.txt_Video_RentVideo.Size = New System.Drawing.Size(327, 29)
        Me.txt_Video_RentVideo.TabIndex = 18
        Me.txt_Video_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_director_RentVideo)
        Me.GroupBox2.Controls.Add(Me.pb_poster_RentVideo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_Resume_RentVideo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_language_RentVideo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_title_RentVideo)
        Me.GroupBox2.Controls.Add(Me.pb_Vid_RentVideo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_Video_RentVideo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(70, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(618, 492)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video's Information"
        '
        'pb_poster_RentVideo
        '
        Me.pb_poster_RentVideo.Location = New System.Drawing.Point(188, 348)
        Me.pb_poster_RentVideo.Name = "pb_poster_RentVideo"
        Me.pb_poster_RentVideo.Size = New System.Drawing.Size(181, 127)
        Me.pb_poster_RentVideo.TabIndex = 30
        Me.pb_poster_RentVideo.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Location = New System.Drawing.Point(22, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 30)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Video Poster"
        '
        'txt_Resume_RentVideo
        '
        Me.txt_Resume_RentVideo.FormattingEnabled = True
        Me.txt_Resume_RentVideo.ItemHeight = 15
        Me.txt_Resume_RentVideo.Items.AddRange(New Object() {"", "", "", "", "", "", ""})
        Me.txt_Resume_RentVideo.Location = New System.Drawing.Point(188, 255)
        Me.txt_Resume_RentVideo.Name = "txt_Resume_RentVideo"
        Me.txt_Resume_RentVideo.Size = New System.Drawing.Size(327, 49)
        Me.txt_Resume_RentVideo.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(22, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 30)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Resume"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(22, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 30)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Director"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(22, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 30)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Title"
        '
        'pb_Vid_RentVideo
        '
        Me.pb_Vid_RentVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Vid_RentVideo.Location = New System.Drawing.Point(527, 44)
        Me.pb_Vid_RentVideo.Name = "pb_Vid_RentVideo"
        Me.pb_Vid_RentVideo.Size = New System.Drawing.Size(31, 29)
        Me.pb_Vid_RentVideo.TabIndex = 19
        Me.pb_Vid_RentVideo.TabStop = False
        '
        'btn_cancel_RentVideo
        '
        Me.btn_cancel_RentVideo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_cancel_RentVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel_RentVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_RentVideo.ForeColor = System.Drawing.Color.White
        Me.btn_cancel_RentVideo.Location = New System.Drawing.Point(70, 910)
        Me.btn_cancel_RentVideo.Name = "btn_cancel_RentVideo"
        Me.btn_cancel_RentVideo.Size = New System.Drawing.Size(299, 41)
        Me.btn_cancel_RentVideo.TabIndex = 41
        Me.btn_cancel_RentVideo.Text = "Cancel"
        Me.btn_cancel_RentVideo.UseVisualStyleBackColor = False
        '
        'btn_rent_RentVideo
        '
        Me.btn_rent_RentVideo.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_rent_RentVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rent_RentVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rent_RentVideo.ForeColor = System.Drawing.Color.White
        Me.btn_rent_RentVideo.Location = New System.Drawing.Point(388, 910)
        Me.btn_rent_RentVideo.Name = "btn_rent_RentVideo"
        Me.btn_rent_RentVideo.Size = New System.Drawing.Size(299, 41)
        Me.btn_rent_RentVideo.TabIndex = 42
        Me.btn_rent_RentVideo.Text = "Rent"
        Me.btn_rent_RentVideo.UseVisualStyleBackColor = False
        '
        'vRentVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 970)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_cancel_RentVideo)
        Me.Controls.Add(Me.btn_rent_RentVideo)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "vRentVideo"
        Me.Text = "vRentVideo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pb_Cid_RentVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_poster_RentVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Vid_RentVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_address_RentVideo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name_RentVideo As TextBox
    Friend WithEvents pb_Cid_RentVideo As PictureBox
    Friend WithEvents txt_Client_RentVideo As TextBox
    Friend WithEvents txt_director_RentVideo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_language_RentVideo As TextBox
    Friend WithEvents txt_title_RentVideo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Video_RentVideo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pb_poster_RentVideo As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Resume_RentVideo As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pb_Vid_RentVideo As PictureBox
    Friend WithEvents btn_cancel_RentVideo As Button
    Friend WithEvents btn_rent_RentVideo As Button
    Friend WithEvents mtx_number_RentVideo As MaskedTextBox
End Class
