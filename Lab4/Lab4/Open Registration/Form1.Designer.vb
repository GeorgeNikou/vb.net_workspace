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
        Me.pb_reg_avatar = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_reg_avatar = New System.Windows.Forms.ComboBox()
        Me.txt_reg_username = New System.Windows.Forms.TextBox()
        Me.txt_reg_password = New System.Windows.Forms.TextBox()
        Me.txt_reg_confirm = New System.Windows.Forms.TextBox()
        Me.img_images = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_reg_submit = New System.Windows.Forms.Button()
        Me.btn_reg_login = New System.Windows.Forms.Button()
        CType(Me.pb_reg_avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_reg_avatar
        '
        Me.pb_reg_avatar.Location = New System.Drawing.Point(32, 41)
        Me.pb_reg_avatar.Name = "pb_reg_avatar"
        Me.pb_reg_avatar.Size = New System.Drawing.Size(203, 250)
        Me.pb_reg_avatar.TabIndex = 0
        Me.pb_reg_avatar.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(304, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(114, 25)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(304, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'cb_reg_avatar
        '
        Me.cb_reg_avatar.BackColor = System.Drawing.SystemColors.Info
        Me.cb_reg_avatar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_reg_avatar.FormattingEnabled = True
        Me.cb_reg_avatar.Location = New System.Drawing.Point(32, 11)
        Me.cb_reg_avatar.Name = "cb_reg_avatar"
        Me.cb_reg_avatar.Size = New System.Drawing.Size(203, 26)
        Me.cb_reg_avatar.TabIndex = 5
        Me.cb_reg_avatar.Text = "Select Option"
        '
        'txt_reg_username
        '
        Me.txt_reg_username.BackColor = System.Drawing.SystemColors.Info
        Me.txt_reg_username.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reg_username.Location = New System.Drawing.Point(308, 57)
        Me.txt_reg_username.Name = "txt_reg_username"
        Me.txt_reg_username.Size = New System.Drawing.Size(214, 28)
        Me.txt_reg_username.TabIndex = 6
        '
        'txt_reg_password
        '
        Me.txt_reg_password.BackColor = System.Drawing.SystemColors.Info
        Me.txt_reg_password.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reg_password.Location = New System.Drawing.Point(309, 141)
        Me.txt_reg_password.Name = "txt_reg_password"
        Me.txt_reg_password.Size = New System.Drawing.Size(214, 28)
        Me.txt_reg_password.TabIndex = 7
        '
        'txt_reg_confirm
        '
        Me.txt_reg_confirm.BackColor = System.Drawing.SystemColors.Info
        Me.txt_reg_confirm.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_reg_confirm.Location = New System.Drawing.Point(309, 222)
        Me.txt_reg_confirm.Name = "txt_reg_confirm"
        Me.txt_reg_confirm.Size = New System.Drawing.Size(214, 28)
        Me.txt_reg_confirm.TabIndex = 8
        '
        'img_images
        '
        Me.img_images.ImageStream = CType(resources.GetObject("img_images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_images.TransparentColor = System.Drawing.Color.Transparent
        Me.img_images.Images.SetKeyName(0, "bart.png")
        Me.img_images.Images.SetKeyName(1, "homer.jpg")
        Me.img_images.Images.SetKeyName(2, "marge.png")
        Me.img_images.Images.SetKeyName(3, "lisa.png")
        Me.img_images.Images.SetKeyName(4, "maggie.jpg")
        Me.img_images.Images.SetKeyName(5, "shadow.jpg")
        Me.img_images.Images.SetKeyName(6, "clouds.jpg")
        Me.img_images.Images.SetKeyName(7, "melvic.jpg")
        Me.img_images.Images.SetKeyName(8, "mowing.jpg")
        Me.img_images.Images.SetKeyName(9, "homer_nakie.jpg")
        '
        'btn_reg_submit
        '
        Me.btn_reg_submit.BackColor = System.Drawing.Color.Gold
        Me.btn_reg_submit.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg_submit.Location = New System.Drawing.Point(343, 275)
        Me.btn_reg_submit.Name = "btn_reg_submit"
        Me.btn_reg_submit.Size = New System.Drawing.Size(87, 30)
        Me.btn_reg_submit.TabIndex = 9
        Me.btn_reg_submit.Text = "Submit"
        Me.btn_reg_submit.UseVisualStyleBackColor = False
        '
        'btn_reg_login
        '
        Me.btn_reg_login.BackColor = System.Drawing.Color.Gold
        Me.btn_reg_login.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reg_login.Location = New System.Drawing.Point(436, 275)
        Me.btn_reg_login.Name = "btn_reg_login"
        Me.btn_reg_login.Size = New System.Drawing.Size(87, 30)
        Me.btn_reg_login.TabIndex = 10
        Me.btn_reg_login.Text = "Login"
        Me.btn_reg_login.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab4.My.Resources.Resources.clouds
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 329)
        Me.Controls.Add(Me.btn_reg_login)
        Me.Controls.Add(Me.btn_reg_submit)
        Me.Controls.Add(Me.txt_reg_confirm)
        Me.Controls.Add(Me.txt_reg_password)
        Me.Controls.Add(Me.txt_reg_username)
        Me.Controls.Add(Me.cb_reg_avatar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pb_reg_avatar)
        Me.Name = "Form1"
        Me.Text = "Open Registration"
        CType(Me.pb_reg_avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_reg_avatar As PictureBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_reg_avatar As ComboBox
    Friend WithEvents txt_reg_username As TextBox
    Friend WithEvents txt_reg_password As TextBox
    Friend WithEvents txt_reg_confirm As TextBox
    Friend WithEvents img_images As ImageList
    Friend WithEvents btn_reg_submit As Button
    Friend WithEvents btn_reg_login As Button
End Class
