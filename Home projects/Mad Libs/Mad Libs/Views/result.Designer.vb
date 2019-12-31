<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class result
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
        Me.btn_result_exit = New System.Windows.Forms.Button()
        Me.ms_new = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb_result_war = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.lbl_result_title = New System.Windows.Forms.Label()
        Me.btn_result_save = New System.Windows.Forms.Button()
        Me.ms_new.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_result_war, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_result_exit
        '
        Me.btn_result_exit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_result_exit.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_result_exit.Location = New System.Drawing.Point(406, 656)
        Me.btn_result_exit.Name = "btn_result_exit"
        Me.btn_result_exit.Size = New System.Drawing.Size(178, 36)
        Me.btn_result_exit.TabIndex = 5
        Me.btn_result_exit.Text = "Exit"
        Me.btn_result_exit.UseVisualStyleBackColor = True
        '
        'ms_new
        '
        Me.ms_new.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_new.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.ms_new.Location = New System.Drawing.Point(0, 0)
        Me.ms_new.Name = "ms_new"
        Me.ms_new.Size = New System.Drawing.Size(1329, 28)
        Me.ms_new.TabIndex = 17
        Me.ms_new.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.BackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.LoginToolStripMenuItem.Text = "new lib"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.BackToolStripMenuItem.Text = "exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.VersionToolStripMenuItem.Text = "Version"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.pb_result_war)
        Me.Panel1.Location = New System.Drawing.Point(-9, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1355, 188)
        Me.Panel1.TabIndex = 18
        '
        'pb_result_war
        '
        Me.pb_result_war.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_result_war.Location = New System.Drawing.Point(460, 0)
        Me.pb_result_war.Name = "pb_result_war"
        Me.pb_result_war.Size = New System.Drawing.Size(410, 188)
        Me.pb_result_war.TabIndex = 0
        Me.pb_result_war.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.lbl_result)
        Me.Panel2.Location = New System.Drawing.Point(37, 300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1257, 286)
        Me.Panel2.TabIndex = 19
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_result.ForeColor = System.Drawing.Color.White
        Me.lbl_result.Location = New System.Drawing.Point(13, 11)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(94, 35)
        Me.lbl_result.TabIndex = 0
        Me.lbl_result.Text = "Label1"
        Me.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_result_title
        '
        Me.lbl_result_title.AutoSize = True
        Me.lbl_result_title.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_result_title.Location = New System.Drawing.Point(584, 46)
        Me.lbl_result_title.Name = "lbl_result_title"
        Me.lbl_result_title.Size = New System.Drawing.Size(0, 39)
        Me.lbl_result_title.TabIndex = 20
        '
        'btn_result_save
        '
        Me.btn_result_save.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_result_save.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_result_save.Location = New System.Drawing.Point(638, 656)
        Me.btn_result_save.Name = "btn_result_save"
        Me.btn_result_save.Size = New System.Drawing.Size(178, 36)
        Me.btn_result_save.TabIndex = 21
        Me.btn_result_save.Text = "Save"
        Me.btn_result_save.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 724)
        Me.Controls.Add(Me.btn_result_save)
        Me.Controls.Add(Me.lbl_result_title)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ms_new)
        Me.Controls.Add(Me.btn_result_exit)
        Me.Name = "result"
        Me.Text = "Mad Lib"
        Me.ms_new.ResumeLayout(False)
        Me.ms_new.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb_result_war, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_result_exit As Button
    Friend WithEvents ms_new As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pb_result_war As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_result As Label
    Friend WithEvents lbl_result_title As Label
    Friend WithEvents btn_result_save As Button
End Class
