<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vAdvanceSearch
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_search_videoid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_search_videodirector = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_search_videoactor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_search_videolanguage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_search_videogenre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_search_videocountry = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_search_videoresume = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_search_videoyear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_search_videolength = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_search_videolist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search_videotitle = New System.Windows.Forms.TextBox()
        Me.btn_back_videolist = New System.Windows.Forms.Button()
        Me.dgv_videolist = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_videolist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(644, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 20)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Video ID"
        '
        'txt_search_videoid
        '
        Me.txt_search_videoid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videoid.BackColor = System.Drawing.Color.White
        Me.txt_search_videoid.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videoid.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videoid.Location = New System.Drawing.Point(648, 86)
        Me.txt_search_videoid.Name = "txt_search_videoid"
        Me.txt_search_videoid.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videoid.TabIndex = 83
        Me.txt_search_videoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label10.Location = New System.Drawing.Point(644, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Director"
        '
        'txt_search_videodirector
        '
        Me.txt_search_videodirector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videodirector.BackColor = System.Drawing.Color.White
        Me.txt_search_videodirector.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videodirector.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videodirector.Location = New System.Drawing.Point(648, 142)
        Me.txt_search_videodirector.Name = "txt_search_videodirector"
        Me.txt_search_videodirector.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videodirector.TabIndex = 81
        Me.txt_search_videodirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label6.Location = New System.Drawing.Point(491, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Actors"
        '
        'txt_search_videoactor
        '
        Me.txt_search_videoactor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videoactor.BackColor = System.Drawing.Color.White
        Me.txt_search_videoactor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videoactor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videoactor.Location = New System.Drawing.Point(495, 142)
        Me.txt_search_videoactor.Name = "txt_search_videoactor"
        Me.txt_search_videoactor.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videoactor.TabIndex = 79
        Me.txt_search_videoactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(491, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Language"
        '
        'txt_search_videolanguage
        '
        Me.txt_search_videolanguage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videolanguage.BackColor = System.Drawing.Color.White
        Me.txt_search_videolanguage.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videolanguage.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videolanguage.Location = New System.Drawing.Point(495, 86)
        Me.txt_search_videolanguage.Name = "txt_search_videolanguage"
        Me.txt_search_videolanguage.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videolanguage.TabIndex = 77
        Me.txt_search_videolanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label8.Location = New System.Drawing.Point(337, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Genre"
        '
        'txt_search_videogenre
        '
        Me.txt_search_videogenre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videogenre.BackColor = System.Drawing.Color.White
        Me.txt_search_videogenre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videogenre.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videogenre.Location = New System.Drawing.Point(341, 142)
        Me.txt_search_videogenre.Name = "txt_search_videogenre"
        Me.txt_search_videogenre.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videogenre.TabIndex = 75
        Me.txt_search_videogenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(337, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Country"
        '
        'txt_search_videocountry
        '
        Me.txt_search_videocountry.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videocountry.BackColor = System.Drawing.Color.White
        Me.txt_search_videocountry.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videocountry.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videocountry.Location = New System.Drawing.Point(341, 86)
        Me.txt_search_videocountry.Name = "txt_search_videocountry"
        Me.txt_search_videocountry.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videocountry.TabIndex = 73
        Me.txt_search_videocountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label5.Location = New System.Drawing.Point(184, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Resume"
        '
        'txt_search_videoresume
        '
        Me.txt_search_videoresume.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videoresume.BackColor = System.Drawing.Color.White
        Me.txt_search_videoresume.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videoresume.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videoresume.Location = New System.Drawing.Point(188, 142)
        Me.txt_search_videoresume.Name = "txt_search_videoresume"
        Me.txt_search_videoresume.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videoresume.TabIndex = 71
        Me.txt_search_videoresume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(184, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Year"
        '
        'txt_search_videoyear
        '
        Me.txt_search_videoyear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videoyear.BackColor = System.Drawing.Color.White
        Me.txt_search_videoyear.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videoyear.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videoyear.Location = New System.Drawing.Point(188, 86)
        Me.txt_search_videoyear.Name = "txt_search_videoyear"
        Me.txt_search_videoyear.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videoyear.TabIndex = 69
        Me.txt_search_videoyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(30, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Length"
        '
        'txt_search_videolength
        '
        Me.txt_search_videolength.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videolength.BackColor = System.Drawing.Color.White
        Me.txt_search_videolength.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videolength.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videolength.Location = New System.Drawing.Point(34, 142)
        Me.txt_search_videolength.Name = "txt_search_videolength"
        Me.txt_search_videolength.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videolength.TabIndex = 67
        Me.txt_search_videolength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label2.Location = New System.Drawing.Point(30, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Title"
        '
        'btn_search_videolist
        '
        Me.btn_search_videolist.AutoSize = True
        Me.btn_search_videolist.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_search_videolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_videolist.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_videolist.ForeColor = System.Drawing.Color.White
        Me.btn_search_videolist.Location = New System.Drawing.Point(407, 22)
        Me.btn_search_videolist.Name = "btn_search_videolist"
        Me.btn_search_videolist.Size = New System.Drawing.Size(385, 31)
        Me.btn_search_videolist.TabIndex = 65
        Me.btn_search_videolist.Text = "Search"
        Me.btn_search_videolist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(27, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 41)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Advanced Search"
        '
        'txt_search_videotitle
        '
        Me.txt_search_videotitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videotitle.BackColor = System.Drawing.Color.White
        Me.txt_search_videotitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videotitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videotitle.Location = New System.Drawing.Point(34, 86)
        Me.txt_search_videotitle.Name = "txt_search_videotitle"
        Me.txt_search_videotitle.Size = New System.Drawing.Size(144, 29)
        Me.txt_search_videotitle.TabIndex = 63
        Me.txt_search_videotitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_back_videolist
        '
        Me.btn_back_videolist.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_videolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_videolist.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_videolist.ForeColor = System.Drawing.Color.White
        Me.btn_back_videolist.Location = New System.Drawing.Point(11, 493)
        Me.btn_back_videolist.Name = "btn_back_videolist"
        Me.btn_back_videolist.Size = New System.Drawing.Size(811, 41)
        Me.btn_back_videolist.TabIndex = 62
        Me.btn_back_videolist.Text = "Back"
        Me.btn_back_videolist.UseVisualStyleBackColor = False
        '
        'dgv_videolist
        '
        Me.dgv_videolist.BackgroundColor = System.Drawing.Color.White
        Me.dgv_videolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_videolist.Location = New System.Drawing.Point(11, 175)
        Me.dgv_videolist.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_videolist.Name = "dgv_videolist"
        Me.dgv_videolist.RowTemplate.Height = 24
        Me.dgv_videolist.Size = New System.Drawing.Size(811, 298)
        Me.dgv_videolist.TabIndex = 61
        '
        'vAdvanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 547)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_search_videoid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_search_videodirector)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_search_videoactor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_search_videolanguage)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_search_videogenre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_search_videocountry)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_search_videoresume)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_search_videoyear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_search_videolength)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_search_videolist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search_videotitle)
        Me.Controls.Add(Me.btn_back_videolist)
        Me.Controls.Add(Me.dgv_videolist)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "vAdvanceSearch"
        Me.Text = "vAdvanceSearch"
        CType(Me.dgv_videolist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents txt_search_videoid As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_search_videodirector As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_search_videoactor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_search_videolanguage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_search_videogenre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_search_videocountry As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_search_videoresume As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_search_videoyear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_search_videolength As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_search_videolist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search_videotitle As TextBox
    Friend WithEvents btn_back_videolist As Button
    Friend WithEvents dgv_videolist As DataGridView
End Class
