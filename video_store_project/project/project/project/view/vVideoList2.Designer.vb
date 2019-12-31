<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vVideoList2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vVideoList2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_back_ListVideo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_LVideo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_resume_LVideo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_url_LVideo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_actor_LVideo = New System.Windows.Forms.TextBox()
        Me.mtx_year_LVideo = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_director_LVideo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_length_LVideo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_language_LVideo = New System.Windows.Forms.TextBox()
        Me.txt_country_LVideo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_title_LVideo = New System.Windows.Forms.TextBox()
        Me.txt_genre_LVideo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btn_rent_RentVideo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(422, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 615)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'btn_back_ListVideo
        '
        Me.btn_back_ListVideo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_ListVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_ListVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_ListVideo.ForeColor = System.Drawing.Color.White
        Me.btn_back_ListVideo.Location = New System.Drawing.Point(109, 636)
        Me.btn_back_ListVideo.Name = "btn_back_ListVideo"
        Me.btn_back_ListVideo.Size = New System.Drawing.Size(284, 41)
        Me.btn_back_ListVideo.TabIndex = 50
        Me.btn_back_ListVideo.Text = "Back"
        Me.btn_back_ListVideo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.txt_id_LVideo)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 59)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video ID"
        '
        'txt_id_LVideo
        '
        Me.txt_id_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_id_LVideo.Enabled = False
        Me.txt_id_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_id_LVideo.Location = New System.Drawing.Point(24, 18)
        Me.txt_id_LVideo.Name = "txt_id_LVideo"
        Me.txt_id_LVideo.Size = New System.Drawing.Size(370, 29)
        Me.txt_id_LVideo.TabIndex = 6
        Me.txt_id_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txt_resume_LVideo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(0, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(400, 193)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Synopsis"
        '
        'txt_resume_LVideo
        '
        Me.txt_resume_LVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_resume_LVideo.Enabled = False
        Me.txt_resume_LVideo.Location = New System.Drawing.Point(24, 37)
        Me.txt_resume_LVideo.Name = "txt_resume_LVideo"
        Me.txt_resume_LVideo.Size = New System.Drawing.Size(357, 143)
        Me.txt_resume_LVideo.TabIndex = 0
        Me.txt_resume_LVideo.Text = resources.GetString("txt_resume_LVideo.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_url_LVideo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_actor_LVideo)
        Me.GroupBox2.Controls.Add(Me.mtx_year_LVideo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_director_LVideo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_length_LVideo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_language_LVideo)
        Me.GroupBox2.Controls.Add(Me.txt_country_LVideo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_title_LVideo)
        Me.GroupBox2.Controls.Add(Me.txt_genre_LVideo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(7, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 365)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video Information"
        '
        'txt_url_LVideo
        '
        Me.txt_url_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_url_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_url_LVideo.Enabled = False
        Me.txt_url_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_url_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_url_LVideo.Location = New System.Drawing.Point(145, 320)
        Me.txt_url_LVideo.Name = "txt_url_LVideo"
        Me.txt_url_LVideo.Size = New System.Drawing.Size(220, 29)
        Me.txt_url_LVideo.TabIndex = 26
        Me.txt_url_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(13, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 30)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Actors"
        '
        'txt_actor_LVideo
        '
        Me.txt_actor_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_actor_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_actor_LVideo.Enabled = False
        Me.txt_actor_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_actor_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_actor_LVideo.Location = New System.Drawing.Point(144, 287)
        Me.txt_actor_LVideo.Name = "txt_actor_LVideo"
        Me.txt_actor_LVideo.Size = New System.Drawing.Size(220, 29)
        Me.txt_actor_LVideo.TabIndex = 24
        Me.txt_actor_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mtx_year_LVideo
        '
        Me.mtx_year_LVideo.BackColor = System.Drawing.Color.White
        Me.mtx_year_LVideo.Enabled = False
        Me.mtx_year_LVideo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_year_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_year_LVideo.Location = New System.Drawing.Point(145, 110)
        Me.mtx_year_LVideo.Mask = "0000"
        Me.mtx_year_LVideo.Name = "mtx_year_LVideo"
        Me.mtx_year_LVideo.Size = New System.Drawing.Size(167, 29)
        Me.mtx_year_LVideo.TabIndex = 20
        Me.mtx_year_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_year_LVideo.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(12, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 30)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Actors"
        '
        'txt_director_LVideo
        '
        Me.txt_director_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_director_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_director_LVideo.Enabled = False
        Me.txt_director_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_director_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_director_LVideo.Location = New System.Drawing.Point(145, 251)
        Me.txt_director_LVideo.Name = "txt_director_LVideo"
        Me.txt_director_LVideo.Size = New System.Drawing.Size(219, 29)
        Me.txt_director_LVideo.TabIndex = 17
        Me.txt_director_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(13, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 30)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Director"
        '
        'txt_length_LVideo
        '
        Me.txt_length_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_length_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_length_LVideo.Enabled = False
        Me.txt_length_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_length_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_length_LVideo.Location = New System.Drawing.Point(145, 216)
        Me.txt_length_LVideo.Name = "txt_length_LVideo"
        Me.txt_length_LVideo.Size = New System.Drawing.Size(218, 29)
        Me.txt_length_LVideo.TabIndex = 15
        Me.txt_length_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(12, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Length"
        '
        'txt_language_LVideo
        '
        Me.txt_language_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_language_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_language_LVideo.Enabled = False
        Me.txt_language_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_language_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_language_LVideo.Location = New System.Drawing.Point(145, 180)
        Me.txt_language_LVideo.Name = "txt_language_LVideo"
        Me.txt_language_LVideo.Size = New System.Drawing.Size(218, 29)
        Me.txt_language_LVideo.TabIndex = 13
        Me.txt_language_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_country_LVideo
        '
        Me.txt_country_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_country_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_country_LVideo.Enabled = False
        Me.txt_country_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_country_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_country_LVideo.Location = New System.Drawing.Point(145, 145)
        Me.txt_country_LVideo.Name = "txt_country_LVideo"
        Me.txt_country_LVideo.Size = New System.Drawing.Size(218, 29)
        Me.txt_country_LVideo.TabIndex = 12
        Me.txt_country_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(10, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 30)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Language"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Location = New System.Drawing.Point(10, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 30)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Country"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(10, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'txt_title_LVideo
        '
        Me.txt_title_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_title_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_title_LVideo.Enabled = False
        Me.txt_title_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_title_LVideo.Location = New System.Drawing.Point(145, 32)
        Me.txt_title_LVideo.Name = "txt_title_LVideo"
        Me.txt_title_LVideo.Size = New System.Drawing.Size(218, 29)
        Me.txt_title_LVideo.TabIndex = 5
        Me.txt_title_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_genre_LVideo
        '
        Me.txt_genre_LVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_genre_LVideo.BackColor = System.Drawing.Color.White
        Me.txt_genre_LVideo.Enabled = False
        Me.txt_genre_LVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_genre_LVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_genre_LVideo.Location = New System.Drawing.Point(145, 71)
        Me.txt_genre_LVideo.Name = "txt_genre_LVideo"
        Me.txt_genre_LVideo.Size = New System.Drawing.Size(218, 29)
        Me.txt_genre_LVideo.TabIndex = 7
        Me.txt_genre_LVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(10, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Genre"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.RichTextBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox4.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 180)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Synopsis"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(24, 37)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(357, 137)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btn_rent_RentVideo
        '
        Me.btn_rent_RentVideo.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_rent_RentVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rent_RentVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rent_RentVideo.ForeColor = System.Drawing.Color.White
        Me.btn_rent_RentVideo.Location = New System.Drawing.Point(422, 635)
        Me.btn_rent_RentVideo.Name = "btn_rent_RentVideo"
        Me.btn_rent_RentVideo.Size = New System.Drawing.Size(299, 41)
        Me.btn_rent_RentVideo.TabIndex = 53
        Me.btn_rent_RentVideo.Text = "Rent"
        Me.btn_rent_RentVideo.UseVisualStyleBackColor = False
        '
        'vVideoList2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 688)
        Me.Controls.Add(Me.btn_rent_RentVideo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_back_ListVideo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "vVideoList2"
        Me.Text = "vVideoList2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_back_ListVideo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_LVideo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_resume_LVideo As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_url_LVideo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_actor_LVideo As TextBox
    Friend WithEvents mtx_year_LVideo As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_director_LVideo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_length_LVideo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_language_LVideo As TextBox
    Friend WithEvents txt_country_LVideo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_title_LVideo As TextBox
    Friend WithEvents txt_genre_LVideo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btn_rent_RentVideo As Button
End Class
