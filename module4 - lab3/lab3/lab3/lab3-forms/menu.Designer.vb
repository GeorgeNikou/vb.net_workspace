<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_menu_greet = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menuStrip_menu = New System.Windows.Forms.MenuStrip()
        Me.ms_menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_menu_exit = New System.Windows.Forms.Button()
        Me.btn_menu_scrabble = New System.Windows.Forms.Button()
        Me.btn_menu_hangman = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.menuStrip_menu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_menu_greet
        '
        Me.lbl_menu_greet.AutoSize = True
        Me.lbl_menu_greet.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu_greet.ForeColor = System.Drawing.Color.Black
        Me.lbl_menu_greet.Location = New System.Drawing.Point(41, 28)
        Me.lbl_menu_greet.Name = "lbl_menu_greet"
        Me.lbl_menu_greet.Size = New System.Drawing.Size(0, 43)
        Me.lbl_menu_greet.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.lbl_menu_greet)
        Me.Panel1.Controls.Add(Me.menuStrip_menu)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 80)
        Me.Panel1.TabIndex = 1
        '
        'menuStrip_menu
        '
        Me.menuStrip_menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuStrip_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_menu, Me.AboutToolStripMenuItem})
        Me.menuStrip_menu.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip_menu.Name = "menuStrip_menu"
        Me.menuStrip_menu.Size = New System.Drawing.Size(549, 28)
        Me.menuStrip_menu.TabIndex = 1
        Me.menuStrip_menu.Text = "MenuStrip1"
        '
        'ms_menu
        '
        Me.ms_menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ms_menu.Name = "ms_menu"
        Me.ms_menu.Size = New System.Drawing.Size(44, 24)
        Me.ms_menu.Text = "File"
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
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem, Me.AuthorToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.VersionToolStripMenuItem.Text = "version"
        '
        'AuthorToolStripMenuItem
        '
        Me.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem"
        Me.AuthorToolStripMenuItem.Size = New System.Drawing.Size(131, 26)
        Me.AuthorToolStripMenuItem.Text = "author"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.lab3.My.Resources.Resources.scrabble_bg
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(24, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 186)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_menu_exit)
        Me.Panel3.Controls.Add(Me.btn_menu_scrabble)
        Me.Panel3.Controls.Add(Me.btn_menu_hangman)
        Me.Panel3.Location = New System.Drawing.Point(299, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(218, 141)
        Me.Panel3.TabIndex = 3
        '
        'btn_menu_exit
        '
        Me.btn_menu_exit.AutoSize = True
        Me.btn_menu_exit.BackColor = System.Drawing.Color.Orange
        Me.btn_menu_exit.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_menu_exit.Location = New System.Drawing.Point(3, 91)
        Me.btn_menu_exit.Name = "btn_menu_exit"
        Me.btn_menu_exit.Size = New System.Drawing.Size(212, 33)
        Me.btn_menu_exit.TabIndex = 9
        Me.btn_menu_exit.Text = "Exit"
        Me.btn_menu_exit.UseVisualStyleBackColor = False
        '
        'btn_menu_scrabble
        '
        Me.btn_menu_scrabble.AutoSize = True
        Me.btn_menu_scrabble.BackColor = System.Drawing.Color.Orange
        Me.btn_menu_scrabble.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_scrabble.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_menu_scrabble.Location = New System.Drawing.Point(6, 13)
        Me.btn_menu_scrabble.Name = "btn_menu_scrabble"
        Me.btn_menu_scrabble.Size = New System.Drawing.Size(212, 33)
        Me.btn_menu_scrabble.TabIndex = 8
        Me.btn_menu_scrabble.Text = "Scrabble"
        Me.btn_menu_scrabble.UseVisualStyleBackColor = False
        '
        'btn_menu_hangman
        '
        Me.btn_menu_hangman.AutoSize = True
        Me.btn_menu_hangman.BackColor = System.Drawing.Color.Orange
        Me.btn_menu_hangman.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menu_hangman.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_menu_hangman.Location = New System.Drawing.Point(3, 52)
        Me.btn_menu_hangman.Name = "btn_menu_hangman"
        Me.btn_menu_hangman.Size = New System.Drawing.Size(212, 33)
        Me.btn_menu_hangman.TabIndex = 7
        Me.btn_menu_hangman.Text = "Hangman"
        Me.btn_menu_hangman.UseVisualStyleBackColor = False
        '
        'form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(546, 307)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.menuStrip_menu
        Me.Name = "form_menu"
        Me.Text = "menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menuStrip_menu.ResumeLayout(False)
        Me.menuStrip_menu.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_menu_greet As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_menu_exit As Button
    Friend WithEvents btn_menu_scrabble As Button
    Friend WithEvents btn_menu_hangman As Button
    Friend WithEvents menuStrip_menu As MenuStrip
    Friend WithEvents ms_menu As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AuthorToolStripMenuItem As ToolStripMenuItem
End Class
