<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_scrabble
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
        Me.ms_scrabble = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_scrabble_words = New System.Windows.Forms.GroupBox()
        Me.lb_scrabble = New System.Windows.Forms.ListBox()
        Me.lbl_scrabble_word = New System.Windows.Forms.Label()
        Me.btn_scrabble_enter = New System.Windows.Forms.Button()
        Me.txt_scrabble_input = New System.Windows.Forms.TextBox()
        Me.lbl_scrabble_tries = New System.Windows.Forms.Label()
        Me.ts_scrabble = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ms_scrabble.SuspendLayout()
        Me.gb_scrabble_words.SuspendLayout()
        Me.ts_scrabble.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_scrabble
        '
        Me.ms_scrabble.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ms_scrabble.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_scrabble.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.ms_scrabble.Location = New System.Drawing.Point(0, 0)
        Me.ms_scrabble.Name = "ms_scrabble"
        Me.ms_scrabble.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.ms_scrabble.Size = New System.Drawing.Size(429, 28)
        Me.ms_scrabble.TabIndex = 0
        Me.ms_scrabble.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
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
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'gb_scrabble_words
        '
        Me.gb_scrabble_words.BackColor = System.Drawing.Color.Transparent
        Me.gb_scrabble_words.Controls.Add(Me.lb_scrabble)
        Me.gb_scrabble_words.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_scrabble_words.Location = New System.Drawing.Point(40, 286)
        Me.gb_scrabble_words.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_scrabble_words.Name = "gb_scrabble_words"
        Me.gb_scrabble_words.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gb_scrabble_words.Size = New System.Drawing.Size(345, 191)
        Me.gb_scrabble_words.TabIndex = 1
        Me.gb_scrabble_words.TabStop = False
        Me.gb_scrabble_words.Text = "Words used"
        '
        'lb_scrabble
        '
        Me.lb_scrabble.BackColor = System.Drawing.Color.Black
        Me.lb_scrabble.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_scrabble.ForeColor = System.Drawing.Color.White
        Me.lb_scrabble.FormattingEnabled = True
        Me.lb_scrabble.ItemHeight = 27
        Me.lb_scrabble.Location = New System.Drawing.Point(12, 34)
        Me.lb_scrabble.Margin = New System.Windows.Forms.Padding(4)
        Me.lb_scrabble.Name = "lb_scrabble"
        Me.lb_scrabble.Size = New System.Drawing.Size(326, 166)
        Me.lb_scrabble.TabIndex = 0
        '
        'lbl_scrabble_word
        '
        Me.lbl_scrabble_word.AutoSize = True
        Me.lbl_scrabble_word.BackColor = System.Drawing.Color.Transparent
        Me.lbl_scrabble_word.Font = New System.Drawing.Font("Palatino Linotype", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_scrabble_word.Location = New System.Drawing.Point(68, 59)
        Me.lbl_scrabble_word.Name = "lbl_scrabble_word"
        Me.lbl_scrabble_word.Size = New System.Drawing.Size(143, 65)
        Me.lbl_scrabble_word.TabIndex = 2
        Me.lbl_scrabble_word.Text = "word"
        Me.lbl_scrabble_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_scrabble_enter
        '
        Me.btn_scrabble_enter.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_scrabble_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_scrabble_enter.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scrabble_enter.Location = New System.Drawing.Point(261, 226)
        Me.btn_scrabble_enter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_scrabble_enter.Name = "btn_scrabble_enter"
        Me.btn_scrabble_enter.Size = New System.Drawing.Size(117, 34)
        Me.btn_scrabble_enter.TabIndex = 3
        Me.btn_scrabble_enter.Text = "Enter"
        Me.btn_scrabble_enter.UseVisualStyleBackColor = False
        '
        'txt_scrabble_input
        '
        Me.txt_scrabble_input.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_scrabble_input.Location = New System.Drawing.Point(55, 231)
        Me.txt_scrabble_input.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_scrabble_input.Name = "txt_scrabble_input"
        Me.txt_scrabble_input.Size = New System.Drawing.Size(185, 25)
        Me.txt_scrabble_input.TabIndex = 4
        '
        'lbl_scrabble_tries
        '
        Me.lbl_scrabble_tries.AutoSize = True
        Me.lbl_scrabble_tries.BackColor = System.Drawing.Color.Transparent
        Me.lbl_scrabble_tries.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_scrabble_tries.ForeColor = System.Drawing.Color.Red
        Me.lbl_scrabble_tries.Location = New System.Drawing.Point(180, 121)
        Me.lbl_scrabble_tries.Name = "lbl_scrabble_tries"
        Me.lbl_scrabble_tries.Size = New System.Drawing.Size(61, 21)
        Me.lbl_scrabble_tries.TabIndex = 5
        Me.lbl_scrabble_tries.Text = "tries left"
        '
        'ts_scrabble
        '
        Me.ts_scrabble.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ts_scrabble.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ts_scrabble.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ts_scrabble.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ts_scrabble.Location = New System.Drawing.Point(0, 525)
        Me.ts_scrabble.Name = "ts_scrabble"
        Me.ts_scrabble.Size = New System.Drawing.Size(429, 31)
        Me.ts_scrabble.TabIndex = 6
        Me.ts_scrabble.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.lab3.My.Resources.Resources.scrabble_bg
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'form_scrabble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.lab3.My.Resources.Resources.blue_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 556)
        Me.Controls.Add(Me.ts_scrabble)
        Me.Controls.Add(Me.lbl_scrabble_tries)
        Me.Controls.Add(Me.txt_scrabble_input)
        Me.Controls.Add(Me.btn_scrabble_enter)
        Me.Controls.Add(Me.lbl_scrabble_word)
        Me.Controls.Add(Me.gb_scrabble_words)
        Me.Controls.Add(Me.ms_scrabble)
        Me.MainMenuStrip = Me.ms_scrabble
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "form_scrabble"
        Me.Text = "scrabble"
        Me.ms_scrabble.ResumeLayout(False)
        Me.ms_scrabble.PerformLayout()
        Me.gb_scrabble_words.ResumeLayout(False)
        Me.ts_scrabble.ResumeLayout(False)
        Me.ts_scrabble.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_scrabble As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gb_scrabble_words As GroupBox
    Friend WithEvents lbl_scrabble_word As Label
    Friend WithEvents btn_scrabble_enter As Button
    Friend WithEvents txt_scrabble_input As TextBox
    Friend WithEvents lbl_scrabble_tries As Label
    Friend WithEvents lb_scrabble As ListBox
    Friend WithEvents ts_scrabble As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
