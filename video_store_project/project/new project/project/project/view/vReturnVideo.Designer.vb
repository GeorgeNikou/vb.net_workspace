<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vReturnVideo
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbo_video_return = New System.Windows.Forms.ComboBox()
        Me.btn_rent_ReturnVideo = New System.Windows.Forms.Button()
        Me.btn_cancel_ReturnVideo = New System.Windows.Forms.Button()
        Me.mtx_RDate_ReturnVideo = New System.Windows.Forms.MaskedTextBox()
        Me.pb_poster_ReturnVideo = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_CNo_ReturnVideo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Cname_ReturnVideo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Video_ReturnVideo = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pb_poster_ReturnVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_Video_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.cbo_video_return)
        Me.GroupBox2.Controls.Add(Me.btn_rent_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.btn_cancel_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.mtx_RDate_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.pb_poster_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_CNo_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_Cname_ReturnVideo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(37, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(618, 507)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video's Information"
        '
        'cbo_video_return
        '
        Me.cbo_video_return.FormattingEnabled = True
        Me.cbo_video_return.Location = New System.Drawing.Point(188, 39)
        Me.cbo_video_return.Name = "cbo_video_return"
        Me.cbo_video_return.Size = New System.Drawing.Size(327, 23)
        Me.cbo_video_return.TabIndex = 36
        '
        'btn_rent_ReturnVideo
        '
        Me.btn_rent_ReturnVideo.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_rent_ReturnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rent_ReturnVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rent_ReturnVideo.ForeColor = System.Drawing.Color.White
        Me.btn_rent_ReturnVideo.Location = New System.Drawing.Point(319, 443)
        Me.btn_rent_ReturnVideo.Name = "btn_rent_ReturnVideo"
        Me.btn_rent_ReturnVideo.Size = New System.Drawing.Size(293, 41)
        Me.btn_rent_ReturnVideo.TabIndex = 34
        Me.btn_rent_ReturnVideo.Text = "Return"
        Me.btn_rent_ReturnVideo.UseVisualStyleBackColor = False
        '
        'btn_cancel_ReturnVideo
        '
        Me.btn_cancel_ReturnVideo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_cancel_ReturnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel_ReturnVideo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel_ReturnVideo.ForeColor = System.Drawing.Color.White
        Me.btn_cancel_ReturnVideo.Location = New System.Drawing.Point(6, 443)
        Me.btn_cancel_ReturnVideo.Name = "btn_cancel_ReturnVideo"
        Me.btn_cancel_ReturnVideo.Size = New System.Drawing.Size(293, 41)
        Me.btn_cancel_ReturnVideo.TabIndex = 33
        Me.btn_cancel_ReturnVideo.Text = "Cancel"
        Me.btn_cancel_ReturnVideo.UseVisualStyleBackColor = False
        '
        'mtx_RDate_ReturnVideo
        '
        Me.mtx_RDate_ReturnVideo.BackColor = System.Drawing.Color.White
        Me.mtx_RDate_ReturnVideo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtx_RDate_ReturnVideo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtx_RDate_ReturnVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.mtx_RDate_ReturnVideo.Location = New System.Drawing.Point(188, 225)
        Me.mtx_RDate_ReturnVideo.Mask = "00/00/0000 90:00"
        Me.mtx_RDate_ReturnVideo.Name = "mtx_RDate_ReturnVideo"
        Me.mtx_RDate_ReturnVideo.Size = New System.Drawing.Size(327, 22)
        Me.mtx_RDate_ReturnVideo.TabIndex = 31
        Me.mtx_RDate_ReturnVideo.ValidatingType = GetType(Date)
        '
        'pb_poster_ReturnVideo
        '
        Me.pb_poster_ReturnVideo.Location = New System.Drawing.Point(188, 284)
        Me.pb_poster_ReturnVideo.Name = "pb_poster_ReturnVideo"
        Me.pb_poster_ReturnVideo.Size = New System.Drawing.Size(181, 127)
        Me.pb_poster_ReturnVideo.TabIndex = 30
        Me.pb_poster_ReturnVideo.TabStop = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label11.Location = New System.Drawing.Point(22, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 30)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Video Poster"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.Location = New System.Drawing.Point(22, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 30)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Rnted On"
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.Location = New System.Drawing.Point(22, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 30)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Client Number"
        '
        'txt_CNo_ReturnVideo
        '
        Me.txt_CNo_ReturnVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_CNo_ReturnVideo.BackColor = System.Drawing.Color.White
        Me.txt_CNo_ReturnVideo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_CNo_ReturnVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CNo_ReturnVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_CNo_ReturnVideo.Location = New System.Drawing.Point(188, 175)
        Me.txt_CNo_ReturnVideo.Name = "txt_CNo_ReturnVideo"
        Me.txt_CNo_ReturnVideo.Size = New System.Drawing.Size(327, 22)
        Me.txt_CNo_ReturnVideo.TabIndex = 23
        Me.txt_CNo_ReturnVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Location = New System.Drawing.Point(22, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 30)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Client Name "
        '
        'txt_Cname_ReturnVideo
        '
        Me.txt_Cname_ReturnVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Cname_ReturnVideo.BackColor = System.Drawing.Color.White
        Me.txt_Cname_ReturnVideo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Cname_ReturnVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cname_ReturnVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_Cname_ReturnVideo.Location = New System.Drawing.Point(188, 122)
        Me.txt_Cname_ReturnVideo.Name = "txt_Cname_ReturnVideo"
        Me.txt_Cname_ReturnVideo.Size = New System.Drawing.Size(327, 22)
        Me.txt_Cname_ReturnVideo.TabIndex = 21
        Me.txt_Cname_ReturnVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(22, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 30)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Video title"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Location = New System.Drawing.Point(217, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(236, 47)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Return Video"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(22, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 30)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Video Id"
        '
        'txt_Video_ReturnVideo
        '
        Me.txt_Video_ReturnVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Video_ReturnVideo.BackColor = System.Drawing.Color.White
        Me.txt_Video_ReturnVideo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Video_ReturnVideo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Video_ReturnVideo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_Video_ReturnVideo.Location = New System.Drawing.Point(188, 83)
        Me.txt_Video_ReturnVideo.Name = "txt_Video_ReturnVideo"
        Me.txt_Video_ReturnVideo.Size = New System.Drawing.Size(327, 22)
        Me.txt_Video_ReturnVideo.TabIndex = 39
        Me.txt_Video_ReturnVideo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'vReturnVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 619)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "vReturnVideo"
        Me.Text = "vReturnVideo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pb_poster_ReturnVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_rent_ReturnVideo As Button
    Friend WithEvents btn_cancel_ReturnVideo As Button
    Friend WithEvents mtx_RDate_ReturnVideo As MaskedTextBox
    Friend WithEvents pb_poster_ReturnVideo As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_CNo_ReturnVideo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Cname_ReturnVideo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_video_return As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Video_ReturnVideo As TextBox
End Class
