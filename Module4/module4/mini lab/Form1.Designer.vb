<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.il_characters = New System.Windows.Forms.ImageList(Me.components)
        Me.TIM_1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.lbl_mario = New System.Windows.Forms.Label()
        Me.lbl_luigi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'il_characters
        '
        Me.il_characters.ImageStream = CType(resources.GetObject("il_characters.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il_characters.TransparentColor = System.Drawing.Color.Transparent
        Me.il_characters.Images.SetKeyName(0, "bulbasaur.png")
        Me.il_characters.Images.SetKeyName(1, "chimchar.png")
        Me.il_characters.Images.SetKeyName(2, "pikachu_found.png")
        Me.il_characters.Images.SetKeyName(3, "mario.png")
        Me.il_characters.Images.SetKeyName(4, "luigi_back.png")
        Me.il_characters.Images.SetKeyName(5, "boo.png")
        '
        'TIM_1
        '
        Me.TIM_1.Interval = 50
        '
        'btn_enter
        '
        Me.btn_enter.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enter.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter.ForeColor = System.Drawing.Color.Red
        Me.btn_enter.Location = New System.Drawing.Point(397, 451)
        Me.btn_enter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(138, 50)
        Me.btn_enter.TabIndex = 0
        Me.btn_enter.Text = "START"
        Me.btn_enter.UseVisualStyleBackColor = False
        '
        'lbl_mario
        '
        Me.lbl_mario.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_mario.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mario.ForeColor = System.Drawing.Color.Red
        Me.lbl_mario.Location = New System.Drawing.Point(79, 34)
        Me.lbl_mario.Name = "lbl_mario"
        Me.lbl_mario.Size = New System.Drawing.Size(147, 56)
        Me.lbl_mario.TabIndex = 1
        Me.lbl_mario.Text = "Mario"
        Me.lbl_mario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_luigi
        '
        Me.lbl_luigi.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_luigi.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_luigi.ForeColor = System.Drawing.Color.GreenYellow
        Me.lbl_luigi.Location = New System.Drawing.Point(249, 34)
        Me.lbl_luigi.Name = "lbl_luigi"
        Me.lbl_luigi.Size = New System.Drawing.Size(147, 56)
        Me.lbl_luigi.TabIndex = 2
        Me.lbl_luigi.Text = "Luigi"
        Me.lbl_luigi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(135, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(295, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_luigi)
        Me.Controls.Add(Me.lbl_mario)
        Me.Controls.Add(Me.btn_enter)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents il_characters As ImageList
    Friend WithEvents TIM_1 As Timer
    Friend WithEvents btn_enter As Button
    Friend WithEvents lbl_mario As Label
    Friend WithEvents lbl_luigi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
