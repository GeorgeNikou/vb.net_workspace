<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_hangman
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_hangman))
        Me.ms_hangman = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_hangman = New System.Windows.Forms.PictureBox()
        Me.gb_hangman_words = New System.Windows.Forms.GroupBox()
        Me.lb_hangman = New System.Windows.Forms.ListBox()
        Me.txt_hangman_input = New System.Windows.Forms.TextBox()
        Me.btn_hangman_enter = New System.Windows.Forms.Button()
        Me.lbl_hangman = New System.Windows.Forms.Label()
        Me.il_hangman = New System.Windows.Forms.ImageList(Me.components)
        Me.ts_hangman = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ms_hangman.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_hangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_hangman_words.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_hangman
        '
        Me.ms_hangman.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_hangman.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ms_hangman.Location = New System.Drawing.Point(0, 0)
        Me.ms_hangman.Name = "ms_hangman"
        Me.ms_hangman.Size = New System.Drawing.Size(821, 28)
        Me.ms_hangman.TabIndex = 0
        Me.ms_hangman.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(115, 26)
        Me.BackToolStripMenuItem.Text = "back"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 26)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.pb_hangman)
        Me.Panel1.Location = New System.Drawing.Point(456, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 392)
        Me.Panel1.TabIndex = 1
        '
        'pb_hangman
        '
        Me.pb_hangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_hangman.Location = New System.Drawing.Point(15, 16)
        Me.pb_hangman.Name = "pb_hangman"
        Me.pb_hangman.Size = New System.Drawing.Size(271, 360)
        Me.pb_hangman.TabIndex = 0
        Me.pb_hangman.TabStop = False
        '
        'gb_hangman_words
        '
        Me.gb_hangman_words.BackColor = System.Drawing.Color.Transparent
        Me.gb_hangman_words.Controls.Add(Me.lb_hangman)
        Me.gb_hangman_words.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_hangman_words.Location = New System.Drawing.Point(231, 118)
        Me.gb_hangman_words.Name = "gb_hangman_words"
        Me.gb_hangman_words.Size = New System.Drawing.Size(219, 346)
        Me.gb_hangman_words.TabIndex = 2
        Me.gb_hangman_words.TabStop = False
        Me.gb_hangman_words.Text = "Letters used"
        '
        'lb_hangman
        '
        Me.lb_hangman.AllowDrop = True
        Me.lb_hangman.FormattingEnabled = True
        Me.lb_hangman.ItemHeight = 31
        Me.lb_hangman.Location = New System.Drawing.Point(7, 34)
        Me.lb_hangman.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lb_hangman.Name = "lb_hangman"
        Me.lb_hangman.Size = New System.Drawing.Size(206, 314)
        Me.lb_hangman.TabIndex = 0
        '
        'txt_hangman_input
        '
        Me.txt_hangman_input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_hangman_input.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hangman_input.Location = New System.Drawing.Point(301, 473)
        Me.txt_hangman_input.Name = "txt_hangman_input"
        Me.txt_hangman_input.Size = New System.Drawing.Size(39, 27)
        Me.txt_hangman_input.TabIndex = 3
        '
        'btn_hangman_enter
        '
        Me.btn_hangman_enter.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn_hangman_enter.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_hangman_enter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_hangman_enter.Location = New System.Drawing.Point(357, 471)
        Me.btn_hangman_enter.Name = "btn_hangman_enter"
        Me.btn_hangman_enter.Size = New System.Drawing.Size(88, 34)
        Me.btn_hangman_enter.TabIndex = 4
        Me.btn_hangman_enter.Text = "enter"
        Me.btn_hangman_enter.UseVisualStyleBackColor = False
        '
        'lbl_hangman
        '
        Me.lbl_hangman.AutoSize = True
        Me.lbl_hangman.Font = New System.Drawing.Font("Palatino Linotype", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hangman.Location = New System.Drawing.Point(64, 64)
        Me.lbl_hangman.Name = "lbl_hangman"
        Me.lbl_hangman.Size = New System.Drawing.Size(0, 50)
        Me.lbl_hangman.TabIndex = 5
        '
        'il_hangman
        '
        Me.il_hangman.ImageStream = CType(resources.GetObject("il_hangman.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il_hangman.TransparentColor = System.Drawing.Color.Transparent
        Me.il_hangman.Images.SetKeyName(0, "hangman_1_arm.jpg")
        Me.il_hangman.Images.SetKeyName(1, "hangman_1_leg.jpg")
        Me.il_hangman.Images.SetKeyName(2, "hangman_2_arms.jpg")
        Me.il_hangman.Images.SetKeyName(3, "hangman_body.jpg")
        Me.il_hangman.Images.SetKeyName(4, "hangman_empty.jpg")
        Me.il_hangman.Images.SetKeyName(5, "hangman_head.jpg")
        Me.il_hangman.Images.SetKeyName(6, "hangman_over.jpg")
        Me.il_hangman.Images.SetKeyName(7, "hangman_string.jpg")
        Me.il_hangman.Images.SetKeyName(8, "hangman_whole.jpg")
        '
        'ts_hangman
        '
        Me.ts_hangman.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ts_hangman.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ts_hangman.Location = New System.Drawing.Point(0, 523)
        Me.ts_hangman.Name = "ts_hangman"
        Me.ts_hangman.Size = New System.Drawing.Size(821, 25)
        Me.ts_hangman.TabIndex = 6
        Me.ts_hangman.Text = "ToolStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(244, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "The broken Hangman dark souls edition"
        '
        'form_hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.lab3.My.Resources.Resources.petals
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(821, 548)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ts_hangman)
        Me.Controls.Add(Me.lbl_hangman)
        Me.Controls.Add(Me.btn_hangman_enter)
        Me.Controls.Add(Me.txt_hangman_input)
        Me.Controls.Add(Me.gb_hangman_words)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ms_hangman)
        Me.MainMenuStrip = Me.ms_hangman
        Me.Name = "form_hangman"
        Me.Text = "hangman"
        Me.ms_hangman.ResumeLayout(False)
        Me.ms_hangman.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_hangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_hangman_words.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_hangman As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pb_hangman As PictureBox
    Friend WithEvents gb_hangman_words As GroupBox
    Friend WithEvents txt_hangman_input As TextBox
    Friend WithEvents btn_hangman_enter As Button
    Friend WithEvents lb_hangman As ListBox
    Friend WithEvents lbl_hangman As Label
    Friend WithEvents il_hangman As ImageList
    Friend WithEvents ts_hangman As ToolStrip
    Friend WithEvents Label1 As Label
End Class
