<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vDeleteVideo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vDeleteVideo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_id_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_next_DeleteVideo = New System.Windows.Forms.Button()
        Me.btn_back_DeleteVideo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_resume_DeleteVideo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_actor_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.txt_url_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtx_year_DeleteVideo = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_director_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_length_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_language_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.txt_country_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_title_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.txt_genre_DeleteVideo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Linen
        Me.GroupBox1.Controls.Add(Me.txt_id_DeleteVideo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(499, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 59)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Video to edit"
        '
        'txt_id_DeleteVideo
        '
        Me.txt_id_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_id_DeleteVideo.Enabled = False
        Me.txt_id_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_id_DeleteVideo.Location = New System.Drawing.Point(24, 18)
        Me.txt_id_DeleteVideo.Name = "txt_id_DeleteVideo"
        Me.txt_id_DeleteVideo.Size = New System.Drawing.Size(260, 29)
        Me.txt_id_DeleteVideo.TabIndex = 6
        Me.txt_id_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(27, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 47)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Delete Video"
        '
        'btn_next_DeleteVideo
        '
        Me.btn_next_DeleteVideo.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_next_DeleteVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next_DeleteVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next_DeleteVideo.ForeColor = System.Drawing.Color.White
        Me.btn_next_DeleteVideo.Location = New System.Drawing.Point(457, 477)
        Me.btn_next_DeleteVideo.Name = "btn_next_DeleteVideo"
        Me.btn_next_DeleteVideo.Size = New System.Drawing.Size(284, 41)
        Me.btn_next_DeleteVideo.TabIndex = 54
        Me.btn_next_DeleteVideo.Text = "Delete Video"
        Me.btn_next_DeleteVideo.UseVisualStyleBackColor = False
        '
        'btn_back_DeleteVideo
        '
        Me.btn_back_DeleteVideo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_DeleteVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_DeleteVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_DeleteVideo.ForeColor = System.Drawing.Color.White
        Me.btn_back_DeleteVideo.Location = New System.Drawing.Point(66, 477)
        Me.btn_back_DeleteVideo.Name = "btn_back_DeleteVideo"
        Me.btn_back_DeleteVideo.Size = New System.Drawing.Size(284, 41)
        Me.btn_back_DeleteVideo.TabIndex = 53
        Me.btn_back_DeleteVideo.Text = "Back"
        Me.btn_back_DeleteVideo.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txt_resume_DeleteVideo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(499, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 377)
        Me.GroupBox3.TabIndex = 52
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Synopsis"
        '
        'txt_resume_DeleteVideo
        '
        Me.txt_resume_DeleteVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_resume_DeleteVideo.Enabled = False
        Me.txt_resume_DeleteVideo.Location = New System.Drawing.Point(24, 37)
        Me.txt_resume_DeleteVideo.Name = "txt_resume_DeleteVideo"
        Me.txt_resume_DeleteVideo.Size = New System.Drawing.Size(249, 318)
        Me.txt_resume_DeleteVideo.TabIndex = 0
        Me.txt_resume_DeleteVideo.Text = resources.GetString("txt_resume_DeleteVideo.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_actor_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.txt_url_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.mtx_year_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_director_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_length_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_language_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.txt_country_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_title_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.txt_genre_DeleteVideo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(17, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 377)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video Information"
        '
        'txt_actor_DeleteVideo
        '
        Me.txt_actor_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_actor_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_actor_DeleteVideo.Enabled = False
        Me.txt_actor_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_actor_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_actor_DeleteVideo.Location = New System.Drawing.Point(235, 289)
        Me.txt_actor_DeleteVideo.Name = "txt_actor_DeleteVideo"
        Me.txt_actor_DeleteVideo.Size = New System.Drawing.Size(217, 29)
        Me.txt_actor_DeleteVideo.TabIndex = 24
        Me.txt_actor_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_url_DeleteVideo
        '
        Me.txt_url_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_url_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_url_DeleteVideo.Enabled = False
        Me.txt_url_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_url_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_url_DeleteVideo.Location = New System.Drawing.Point(166, 327)
        Me.txt_url_DeleteVideo.Name = "txt_url_DeleteVideo"
        Me.txt_url_DeleteVideo.Size = New System.Drawing.Size(286, 29)
        Me.txt_url_DeleteVideo.TabIndex = 23
        Me.txt_url_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Location = New System.Drawing.Point(33, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 30)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Poster URL"
        '
        'mtx_year_DeleteVideo
        '
        Me.mtx_year_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.mtx_year_DeleteVideo.Enabled = False
        Me.mtx_year_DeleteVideo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_year_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_year_DeleteVideo.Location = New System.Drawing.Point(235, 108)
        Me.mtx_year_DeleteVideo.Mask = "0000"
        Me.mtx_year_DeleteVideo.Name = "mtx_year_DeleteVideo"
        Me.mtx_year_DeleteVideo.Size = New System.Drawing.Size(167, 29)
        Me.mtx_year_DeleteVideo.TabIndex = 20
        Me.mtx_year_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mtx_year_DeleteVideo.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(33, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 30)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Actors"
        '
        'txt_director_DeleteVideo
        '
        Me.txt_director_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_director_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_director_DeleteVideo.Enabled = False
        Me.txt_director_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_director_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_director_DeleteVideo.Location = New System.Drawing.Point(236, 253)
        Me.txt_director_DeleteVideo.Name = "txt_director_DeleteVideo"
        Me.txt_director_DeleteVideo.Size = New System.Drawing.Size(216, 29)
        Me.txt_director_DeleteVideo.TabIndex = 17
        Me.txt_director_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(34, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 30)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Director"
        '
        'txt_length_DeleteVideo
        '
        Me.txt_length_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_length_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_length_DeleteVideo.Enabled = False
        Me.txt_length_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_length_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_length_DeleteVideo.Location = New System.Drawing.Point(236, 218)
        Me.txt_length_DeleteVideo.Name = "txt_length_DeleteVideo"
        Me.txt_length_DeleteVideo.Size = New System.Drawing.Size(215, 29)
        Me.txt_length_DeleteVideo.TabIndex = 15
        Me.txt_length_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(33, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 30)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Length"
        '
        'txt_language_DeleteVideo
        '
        Me.txt_language_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_language_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_language_DeleteVideo.Enabled = False
        Me.txt_language_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_language_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_language_DeleteVideo.Location = New System.Drawing.Point(236, 182)
        Me.txt_language_DeleteVideo.Name = "txt_language_DeleteVideo"
        Me.txt_language_DeleteVideo.Size = New System.Drawing.Size(215, 29)
        Me.txt_language_DeleteVideo.TabIndex = 13
        Me.txt_language_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_country_DeleteVideo
        '
        Me.txt_country_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_country_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_country_DeleteVideo.Enabled = False
        Me.txt_country_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_country_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_country_DeleteVideo.Location = New System.Drawing.Point(236, 147)
        Me.txt_country_DeleteVideo.Name = "txt_country_DeleteVideo"
        Me.txt_country_DeleteVideo.Size = New System.Drawing.Size(215, 29)
        Me.txt_country_DeleteVideo.TabIndex = 12
        Me.txt_country_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(31, 178)
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
        Me.Label4.Location = New System.Drawing.Point(31, 143)
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
        Me.Label3.Location = New System.Drawing.Point(31, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Year"
        '
        'txt_title_DeleteVideo
        '
        Me.txt_title_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_title_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_title_DeleteVideo.Enabled = False
        Me.txt_title_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_title_DeleteVideo.Location = New System.Drawing.Point(236, 34)
        Me.txt_title_DeleteVideo.Name = "txt_title_DeleteVideo"
        Me.txt_title_DeleteVideo.Size = New System.Drawing.Size(215, 29)
        Me.txt_title_DeleteVideo.TabIndex = 5
        Me.txt_title_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_genre_DeleteVideo
        '
        Me.txt_genre_DeleteVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_genre_DeleteVideo.BackColor = System.Drawing.Color.White
        Me.txt_genre_DeleteVideo.Enabled = False
        Me.txt_genre_DeleteVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_genre_DeleteVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_genre_DeleteVideo.Location = New System.Drawing.Point(236, 73)
        Me.txt_genre_DeleteVideo.Name = "txt_genre_DeleteVideo"
        Me.txt_genre_DeleteVideo.Size = New System.Drawing.Size(215, 29)
        Me.txt_genre_DeleteVideo.TabIndex = 7
        Me.txt_genre_DeleteVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(31, 30)
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
        Me.Label1.Location = New System.Drawing.Point(31, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Genre"
        '
        'vDeleteVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 541)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_next_DeleteVideo)
        Me.Controls.Add(Me.btn_back_DeleteVideo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "vDeleteVideo"
        Me.Text = "vDeleteVideo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_id_DeleteVideo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_next_DeleteVideo As Button
    Friend WithEvents btn_back_DeleteVideo As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_resume_DeleteVideo As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_actor_DeleteVideo As TextBox
    Friend WithEvents txt_url_DeleteVideo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mtx_year_DeleteVideo As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_director_DeleteVideo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_length_DeleteVideo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_language_DeleteVideo As TextBox
    Friend WithEvents txt_country_DeleteVideo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_title_DeleteVideo As TextBox
    Friend WithEvents txt_genre_DeleteVideo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
