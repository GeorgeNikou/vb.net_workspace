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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_Cno_RentVideo = New System.Windows.Forms.TextBox()
        Me.txt_director_RentVideo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_language_RentVideo = New System.Windows.Forms.TextBox()
        Me.txt_title_RentVideo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Vid_RentVideo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pb_poster_RentVideo = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Resume_RentVideo = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_cancel_RentVideo = New System.Windows.Forms.Button()
        Me.btn_rent_RentVideo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_poster_RentVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(378, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(253, 60)
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
        Me.Label4.Location = New System.Drawing.Point(29, 239)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 37)
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
        Me.Label2.Location = New System.Drawing.Point(29, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 37)
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
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Cno_RentVideo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(93, 109)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(824, 332)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client's Information"
        '
        'mtx_number_RentVideo
        '
        Me.mtx_number_RentVideo.BackColor = System.Drawing.Color.White
        Me.mtx_number_RentVideo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_number_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_number_RentVideo.Location = New System.Drawing.Point(251, 244)
        Me.mtx_number_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.mtx_number_RentVideo.Mask = "(999) 000-0000"
        Me.mtx_number_RentVideo.Name = "mtx_number_RentVideo"
        Me.mtx_number_RentVideo.Size = New System.Drawing.Size(435, 34)
        Me.mtx_number_RentVideo.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(29, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 37)
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
        Me.txt_address_RentVideo.Location = New System.Drawing.Point(251, 186)
        Me.txt_address_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_address_RentVideo.Name = "txt_address_RentVideo"
        Me.txt_address_RentVideo.Size = New System.Drawing.Size(435, 34)
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
        Me.Label1.Location = New System.Drawing.Point(29, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 37)
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
        Me.txt_name_RentVideo.Location = New System.Drawing.Point(251, 121)
        Me.txt_name_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name_RentVideo.Name = "txt_name_RentVideo"
        Me.txt_name_RentVideo.Size = New System.Drawing.Size(435, 34)
        Me.txt_name_RentVideo.TabIndex = 21
        Me.txt_name_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(703, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'txt_Cno_RentVideo
        '
        Me.txt_Cno_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cno_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_Cno_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cno_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_Cno_RentVideo.Location = New System.Drawing.Point(251, 54)
        Me.txt_Cno_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Cno_RentVideo.Name = "txt_Cno_RentVideo"
        Me.txt_Cno_RentVideo.Size = New System.Drawing.Size(435, 34)
        Me.txt_Cno_RentVideo.TabIndex = 18
        Me.txt_Cno_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_director_RentVideo
        '
        Me.txt_director_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_director_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_director_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_director_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_director_RentVideo.Location = New System.Drawing.Point(251, 250)
        Me.txt_director_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_director_RentVideo.Name = "txt_director_RentVideo"
        Me.txt_director_RentVideo.Size = New System.Drawing.Size(435, 34)
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
        Me.Label6.Location = New System.Drawing.Point(29, 177)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 37)
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
        Me.txt_language_RentVideo.Location = New System.Drawing.Point(251, 186)
        Me.txt_language_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_language_RentVideo.Name = "txt_language_RentVideo"
        Me.txt_language_RentVideo.Size = New System.Drawing.Size(435, 34)
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
        Me.txt_title_RentVideo.Location = New System.Drawing.Point(251, 121)
        Me.txt_title_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_title_RentVideo.Name = "txt_title_RentVideo"
        Me.txt_title_RentVideo.Size = New System.Drawing.Size(435, 34)
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
        Me.Label8.Location = New System.Drawing.Point(29, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 37)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Video ID"
        '
        'txt_Vid_RentVideo
        '
        Me.txt_Vid_RentVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Vid_RentVideo.BackColor = System.Drawing.Color.White
        Me.txt_Vid_RentVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vid_RentVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_Vid_RentVideo.Location = New System.Drawing.Point(251, 54)
        Me.txt_Vid_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Vid_RentVideo.Name = "txt_Vid_RentVideo"
        Me.txt_Vid_RentVideo.Size = New System.Drawing.Size(435, 34)
        Me.txt_Vid_RentVideo.TabIndex = 18
        Me.txt_Vid_RentVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_Vid_RentVideo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(93, 483)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(824, 606)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video's Information"
        '
        'pb_poster_RentVideo
        '
        Me.pb_poster_RentVideo.Location = New System.Drawing.Point(251, 428)
        Me.pb_poster_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_poster_RentVideo.Name = "pb_poster_RentVideo"
        Me.pb_poster_RentVideo.Size = New System.Drawing.Size(241, 156)
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
        Me.Label11.Location = New System.Drawing.Point(29, 453)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 37)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Video Poster"
        '
        'txt_Resume_RentVideo
        '
        Me.txt_Resume_RentVideo.FormattingEnabled = True
        Me.txt_Resume_RentVideo.ItemHeight = 18
        Me.txt_Resume_RentVideo.Items.AddRange(New Object() {"", "", "", "", "", "", ""})
        Me.txt_Resume_RentVideo.Location = New System.Drawing.Point(251, 314)
        Me.txt_Resume_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Resume_RentVideo.Name = "txt_Resume_RentVideo"
        Me.txt_Resume_RentVideo.Size = New System.Drawing.Size(435, 76)
        Me.txt_Resume_RentVideo.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(29, 314)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 37)
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
        Me.Label5.Location = New System.Drawing.Point(29, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 37)
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
        Me.Label7.Location = New System.Drawing.Point(29, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 37)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Title"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(703, 54)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'btn_cancel_RentVideo
        '
        Me.btn_cancel_RentVideo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_cancel_RentVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel_RentVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_RentVideo.ForeColor = System.Drawing.Color.White
        Me.btn_cancel_RentVideo.Location = New System.Drawing.Point(93, 1120)
        Me.btn_cancel_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel_RentVideo.Name = "btn_cancel_RentVideo"
        Me.btn_cancel_RentVideo.Size = New System.Drawing.Size(399, 50)
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
        Me.btn_rent_RentVideo.Location = New System.Drawing.Point(518, 1120)
        Me.btn_rent_RentVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_rent_RentVideo.Name = "btn_rent_RentVideo"
        Me.btn_rent_RentVideo.Size = New System.Drawing.Size(399, 50)
        Me.btn_rent_RentVideo.TabIndex = 42
        Me.btn_rent_RentVideo.Text = "Rent"
        Me.btn_rent_RentVideo.UseVisualStyleBackColor = False
        '
        'vRentVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 1055)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_cancel_RentVideo)
        Me.Controls.Add(Me.btn_rent_RentVideo)
        Me.Name = "vRentVideo"
        Me.Text = "vRentVideo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_poster_RentVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mtx_number_RentVideo As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_address_RentVideo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name_RentVideo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_Cno_RentVideo As TextBox
    Friend WithEvents txt_director_RentVideo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_language_RentVideo As TextBox
    Friend WithEvents txt_title_RentVideo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Vid_RentVideo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pb_poster_RentVideo As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Resume_RentVideo As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_cancel_RentVideo As Button
    Friend WithEvents btn_rent_RentVideo As Button
End Class
