<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lab2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab2))
        Me.gb_animals = New System.Windows.Forms.GroupBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.rdo_snail = New System.Windows.Forms.RadioButton()
        Me.rdo_donkey = New System.Windows.Forms.RadioButton()
        Me.rdo_turtle = New System.Windows.Forms.RadioButton()
        Me.rdo_sloth = New System.Windows.Forms.RadioButton()
        Me.rdo_sheep = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_bet = New System.Windows.Forms.TextBox()
        Me.txt_cash_remain = New System.Windows.Forms.TextBox()
        Me.txt_start_cash = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_profit = New System.Windows.Forms.Label()
        Me.lbl_losses = New System.Windows.Forms.Label()
        Me.lbl_wins = New System.Windows.Forms.Label()
        Me.lbl_round = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_bet = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pg_snail = New System.Windows.Forms.ProgressBar()
        Me.pg_sheep = New System.Windows.Forms.ProgressBar()
        Me.pg_sloth = New System.Windows.Forms.ProgressBar()
        Me.pg_turtle = New System.Windows.Forms.ProgressBar()
        Me.pg_donkey = New System.Windows.Forms.ProgressBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pb_snail = New System.Windows.Forms.PictureBox()
        Me.pb_donkey = New System.Windows.Forms.PictureBox()
        Me.pb_turtle = New System.Windows.Forms.PictureBox()
        Me.pb_sloth = New System.Windows.Forms.PictureBox()
        Me.pb_sheep = New System.Windows.Forms.PictureBox()
        Me.lbl_rank_snail = New System.Windows.Forms.Label()
        Me.lbl_rank_donkey = New System.Windows.Forms.Label()
        Me.lbl_rank_turtle = New System.Windows.Forms.Label()
        Me.lbl_rank_sloth = New System.Windows.Forms.Label()
        Me.lbl_rank_sheep = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.gb_animals.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pb_snail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_donkey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_turtle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_sloth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_sheep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_animals
        '
        Me.gb_animals.BackColor = System.Drawing.Color.ForestGreen
        Me.gb_animals.Controls.Add(Me.PictureBox10)
        Me.gb_animals.Controls.Add(Me.PictureBox9)
        Me.gb_animals.Controls.Add(Me.PictureBox8)
        Me.gb_animals.Controls.Add(Me.PictureBox7)
        Me.gb_animals.Controls.Add(Me.PictureBox5)
        Me.gb_animals.Controls.Add(Me.rdo_snail)
        Me.gb_animals.Controls.Add(Me.rdo_donkey)
        Me.gb_animals.Controls.Add(Me.rdo_turtle)
        Me.gb_animals.Controls.Add(Me.rdo_sloth)
        Me.gb_animals.Controls.Add(Me.rdo_sheep)
        Me.gb_animals.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_animals.ForeColor = System.Drawing.Color.Ivory
        Me.gb_animals.Location = New System.Drawing.Point(3, 3)
        Me.gb_animals.Name = "gb_animals"
        Me.gb_animals.Size = New System.Drawing.Size(288, 304)
        Me.gb_animals.TabIndex = 0
        Me.gb_animals.TabStop = False
        Me.gb_animals.Text = "ANIMALS"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(211, 134)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox10.TabIndex = 28
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(211, 77)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox9.TabIndex = 28
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(211, 19)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox8.TabIndex = 28
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Aquamarine
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(211, 247)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SandyBrown
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(211, 190)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 51)
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'rdo_snail
        '
        Me.rdo_snail.AutoSize = True
        Me.rdo_snail.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_snail.ForeColor = System.Drawing.Color.Aquamarine
        Me.rdo_snail.Location = New System.Drawing.Point(18, 254)
        Me.rdo_snail.Name = "rdo_snail"
        Me.rdo_snail.Size = New System.Drawing.Size(92, 37)
        Me.rdo_snail.TabIndex = 4
        Me.rdo_snail.TabStop = True
        Me.rdo_snail.Text = "Snail"
        Me.rdo_snail.UseVisualStyleBackColor = True
        '
        'rdo_donkey
        '
        Me.rdo_donkey.AutoSize = True
        Me.rdo_donkey.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_donkey.ForeColor = System.Drawing.Color.SandyBrown
        Me.rdo_donkey.Location = New System.Drawing.Point(18, 201)
        Me.rdo_donkey.Name = "rdo_donkey"
        Me.rdo_donkey.Size = New System.Drawing.Size(119, 37)
        Me.rdo_donkey.TabIndex = 3
        Me.rdo_donkey.TabStop = True
        Me.rdo_donkey.Text = "Donkey"
        Me.rdo_donkey.UseVisualStyleBackColor = True
        '
        'rdo_turtle
        '
        Me.rdo_turtle.AutoSize = True
        Me.rdo_turtle.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_turtle.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.rdo_turtle.Location = New System.Drawing.Point(18, 148)
        Me.rdo_turtle.Name = "rdo_turtle"
        Me.rdo_turtle.Size = New System.Drawing.Size(105, 37)
        Me.rdo_turtle.TabIndex = 2
        Me.rdo_turtle.TabStop = True
        Me.rdo_turtle.Text = "Turtle"
        Me.rdo_turtle.UseVisualStyleBackColor = True
        '
        'rdo_sloth
        '
        Me.rdo_sloth.AutoSize = True
        Me.rdo_sloth.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_sloth.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.rdo_sloth.Location = New System.Drawing.Point(18, 95)
        Me.rdo_sloth.Name = "rdo_sloth"
        Me.rdo_sloth.Size = New System.Drawing.Size(97, 37)
        Me.rdo_sloth.TabIndex = 1
        Me.rdo_sloth.TabStop = True
        Me.rdo_sloth.Text = "Sloth"
        Me.rdo_sloth.UseVisualStyleBackColor = True
        '
        'rdo_sheep
        '
        Me.rdo_sheep.AutoSize = True
        Me.rdo_sheep.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_sheep.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rdo_sheep.Location = New System.Drawing.Point(18, 42)
        Me.rdo_sheep.Name = "rdo_sheep"
        Me.rdo_sheep.Size = New System.Drawing.Size(106, 37)
        Me.rdo_sheep.TabIndex = 0
        Me.rdo_sheep.TabStop = True
        Me.rdo_sheep.Text = "Sheep"
        Me.rdo_sheep.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.GroupBox2.Controls.Add(Me.txt_bet)
        Me.GroupBox2.Controls.Add(Me.txt_cash_remain)
        Me.GroupBox2.Controls.Add(Me.txt_start_cash)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Ivory
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 245)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PLACE YOUR BETS"
        '
        'txt_bet
        '
        Me.txt_bet.BackColor = System.Drawing.SystemColors.Info
        Me.txt_bet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_bet.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bet.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txt_bet.Location = New System.Drawing.Point(182, 176)
        Me.txt_bet.Name = "txt_bet"
        Me.txt_bet.Size = New System.Drawing.Size(160, 26)
        Me.txt_bet.TabIndex = 6
        Me.txt_bet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cash_remain
        '
        Me.txt_cash_remain.BackColor = System.Drawing.SystemColors.Info
        Me.txt_cash_remain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cash_remain.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cash_remain.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txt_cash_remain.Location = New System.Drawing.Point(182, 118)
        Me.txt_cash_remain.Name = "txt_cash_remain"
        Me.txt_cash_remain.Size = New System.Drawing.Size(160, 26)
        Me.txt_cash_remain.TabIndex = 5
        Me.txt_cash_remain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_start_cash
        '
        Me.txt_start_cash.BackColor = System.Drawing.SystemColors.Info
        Me.txt_start_cash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_start_cash.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_start_cash.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txt_start_cash.Location = New System.Drawing.Point(182, 60)
        Me.txt_start_cash.Name = "txt_start_cash"
        Me.txt_start_cash.Size = New System.Drawing.Size(160, 26)
        Me.txt_start_cash.TabIndex = 4
        Me.txt_start_cash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Placed bet"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cash remaining"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Starting cash"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.gb_animals)
        Me.Panel1.Location = New System.Drawing.Point(33, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 307)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(363, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 248)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Location = New System.Drawing.Point(788, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(227, 244)
        Me.Panel3.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.ForestGreen
        Me.GroupBox3.Controls.Add(Me.lbl_profit)
        Me.GroupBox3.Controls.Add(Me.lbl_losses)
        Me.GroupBox3.Controls.Add(Me.lbl_wins)
        Me.GroupBox3.Controls.Add(Me.lbl_round)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Ivory
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 238)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "STATISTIC"
        '
        'lbl_profit
        '
        Me.lbl_profit.AutoSize = True
        Me.lbl_profit.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profit.ForeColor = System.Drawing.Color.RosyBrown
        Me.lbl_profit.Location = New System.Drawing.Point(164, 174)
        Me.lbl_profit.Name = "lbl_profit"
        Me.lbl_profit.Size = New System.Drawing.Size(22, 25)
        Me.lbl_profit.TabIndex = 9
        Me.lbl_profit.Text = "0"
        Me.lbl_profit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_losses
        '
        Me.lbl_losses.AutoSize = True
        Me.lbl_losses.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_losses.ForeColor = System.Drawing.Color.Red
        Me.lbl_losses.Location = New System.Drawing.Point(164, 136)
        Me.lbl_losses.Name = "lbl_losses"
        Me.lbl_losses.Size = New System.Drawing.Size(22, 25)
        Me.lbl_losses.TabIndex = 8
        Me.lbl_losses.Text = "0"
        Me.lbl_losses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_wins
        '
        Me.lbl_wins.AutoSize = True
        Me.lbl_wins.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wins.ForeColor = System.Drawing.Color.LimeGreen
        Me.lbl_wins.Location = New System.Drawing.Point(164, 98)
        Me.lbl_wins.Name = "lbl_wins"
        Me.lbl_wins.Size = New System.Drawing.Size(22, 25)
        Me.lbl_wins.TabIndex = 7
        Me.lbl_wins.Text = "0"
        Me.lbl_wins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_round
        '
        Me.lbl_round.AutoSize = True
        Me.lbl_round.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_round.ForeColor = System.Drawing.Color.Orange
        Me.lbl_round.Location = New System.Drawing.Point(164, 63)
        Me.lbl_round.Name = "lbl_round"
        Me.lbl_round.Size = New System.Drawing.Size(22, 25)
        Me.lbl_round.TabIndex = 6
        Me.lbl_round.Text = "0"
        Me.lbl_round.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 24)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Round: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total profit: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Losses: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Wins: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_bet
        '
        Me.btn_bet.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bet.ForeColor = System.Drawing.Color.OrangeRed
        Me.btn_bet.Location = New System.Drawing.Point(363, 302)
        Me.btn_bet.Name = "btn_bet"
        Me.btn_bet.Size = New System.Drawing.Size(192, 34)
        Me.btn_bet.TabIndex = 5
        Me.btn_bet.Text = "Starting bet"
        Me.btn_bet.UseVisualStyleBackColor = True
        '
        'btn_start
        '
        Me.btn_start.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.LimeGreen
        Me.btn_start.Location = New System.Drawing.Point(573, 302)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(179, 34)
        Me.btn_start.TabIndex = 6
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.btn_next.Location = New System.Drawing.Point(788, 302)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(227, 34)
        Me.btn_next.TabIndex = 7
        Me.btn_next.Text = "Next Round"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'timer1
        '
        '
        'pg_snail
        '
        Me.pg_snail.ForeColor = System.Drawing.Color.Aquamarine
        Me.pg_snail.Location = New System.Drawing.Point(10, 304)
        Me.pg_snail.Maximum = 500
        Me.pg_snail.Name = "pg_snail"
        Me.pg_snail.Size = New System.Drawing.Size(904, 27)
        Me.pg_snail.TabIndex = 13
        '
        'pg_sheep
        '
        Me.pg_sheep.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pg_sheep.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pg_sheep.Location = New System.Drawing.Point(10, 32)
        Me.pg_sheep.Maximum = 500
        Me.pg_sheep.Name = "pg_sheep"
        Me.pg_sheep.Size = New System.Drawing.Size(904, 27)
        Me.pg_sheep.TabIndex = 14
        Me.pg_sheep.Value = 1
        '
        'pg_sloth
        '
        Me.pg_sloth.ForeColor = System.Drawing.Color.PaleGoldenrod
        Me.pg_sloth.Location = New System.Drawing.Point(10, 100)
        Me.pg_sloth.Maximum = 500
        Me.pg_sloth.Name = "pg_sloth"
        Me.pg_sloth.Size = New System.Drawing.Size(904, 27)
        Me.pg_sloth.TabIndex = 15
        '
        'pg_turtle
        '
        Me.pg_turtle.ForeColor = System.Drawing.Color.DarkSeaGreen
        Me.pg_turtle.Location = New System.Drawing.Point(10, 168)
        Me.pg_turtle.Maximum = 500
        Me.pg_turtle.Name = "pg_turtle"
        Me.pg_turtle.Size = New System.Drawing.Size(904, 27)
        Me.pg_turtle.TabIndex = 16
        '
        'pg_donkey
        '
        Me.pg_donkey.ForeColor = System.Drawing.Color.SandyBrown
        Me.pg_donkey.Location = New System.Drawing.Point(10, 236)
        Me.pg_donkey.Maximum = 500
        Me.pg_donkey.Name = "pg_donkey"
        Me.pg_donkey.Size = New System.Drawing.Size(904, 27)
        Me.pg_donkey.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.pb_snail)
        Me.Panel4.Controls.Add(Me.pb_donkey)
        Me.Panel4.Controls.Add(Me.pb_turtle)
        Me.Panel4.Controls.Add(Me.pb_sloth)
        Me.Panel4.Controls.Add(Me.pb_sheep)
        Me.Panel4.Controls.Add(Me.lbl_rank_snail)
        Me.Panel4.Controls.Add(Me.lbl_rank_donkey)
        Me.Panel4.Controls.Add(Me.lbl_rank_turtle)
        Me.Panel4.Controls.Add(Me.lbl_rank_sloth)
        Me.Panel4.Controls.Add(Me.lbl_rank_sheep)
        Me.Panel4.Controls.Add(Me.pg_donkey)
        Me.Panel4.Controls.Add(Me.pg_turtle)
        Me.Panel4.Controls.Add(Me.pg_sloth)
        Me.Panel4.Controls.Add(Me.pg_sheep)
        Me.Panel4.Controls.Add(Me.pg_snail)
        Me.Panel4.Location = New System.Drawing.Point(23, 378)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1007, 358)
        Me.Panel4.TabIndex = 18
        '
        'pb_snail
        '
        Me.pb_snail.BackgroundImage = CType(resources.GetObject("pb_snail.BackgroundImage"), System.Drawing.Image)
        Me.pb_snail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_snail.Location = New System.Drawing.Point(3, 293)
        Me.pb_snail.Name = "pb_snail"
        Me.pb_snail.Size = New System.Drawing.Size(57, 51)
        Me.pb_snail.TabIndex = 27
        Me.pb_snail.TabStop = False
        '
        'pb_donkey
        '
        Me.pb_donkey.BackgroundImage = CType(resources.GetObject("pb_donkey.BackgroundImage"), System.Drawing.Image)
        Me.pb_donkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_donkey.Location = New System.Drawing.Point(0, 225)
        Me.pb_donkey.Name = "pb_donkey"
        Me.pb_donkey.Size = New System.Drawing.Size(57, 51)
        Me.pb_donkey.TabIndex = 25
        Me.pb_donkey.TabStop = False
        '
        'pb_turtle
        '
        Me.pb_turtle.BackgroundImage = CType(resources.GetObject("pb_turtle.BackgroundImage"), System.Drawing.Image)
        Me.pb_turtle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_turtle.Location = New System.Drawing.Point(3, 156)
        Me.pb_turtle.Name = "pb_turtle"
        Me.pb_turtle.Size = New System.Drawing.Size(57, 51)
        Me.pb_turtle.TabIndex = 24
        Me.pb_turtle.TabStop = False
        '
        'pb_sloth
        '
        Me.pb_sloth.BackgroundImage = CType(resources.GetObject("pb_sloth.BackgroundImage"), System.Drawing.Image)
        Me.pb_sloth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_sloth.Location = New System.Drawing.Point(3, 88)
        Me.pb_sloth.Name = "pb_sloth"
        Me.pb_sloth.Size = New System.Drawing.Size(57, 51)
        Me.pb_sloth.TabIndex = 23
        Me.pb_sloth.TabStop = False
        '
        'pb_sheep
        '
        Me.pb_sheep.BackgroundImage = CType(resources.GetObject("pb_sheep.BackgroundImage"), System.Drawing.Image)
        Me.pb_sheep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_sheep.Location = New System.Drawing.Point(0, 18)
        Me.pb_sheep.Name = "pb_sheep"
        Me.pb_sheep.Size = New System.Drawing.Size(57, 51)
        Me.pb_sheep.TabIndex = 5
        Me.pb_sheep.TabStop = False
        '
        'lbl_rank_snail
        '
        Me.lbl_rank_snail.AutoSize = True
        Me.lbl_rank_snail.Font = New System.Drawing.Font("Segoe Script", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rank_snail.ForeColor = System.Drawing.Color.MintCream
        Me.lbl_rank_snail.Location = New System.Drawing.Point(953, 293)
        Me.lbl_rank_snail.Name = "lbl_rank_snail"
        Me.lbl_rank_snail.Size = New System.Drawing.Size(0, 40)
        Me.lbl_rank_snail.TabIndex = 22
        '
        'lbl_rank_donkey
        '
        Me.lbl_rank_donkey.AutoSize = True
        Me.lbl_rank_donkey.Font = New System.Drawing.Font("Segoe Script", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rank_donkey.ForeColor = System.Drawing.Color.MintCream
        Me.lbl_rank_donkey.Location = New System.Drawing.Point(953, 225)
        Me.lbl_rank_donkey.Name = "lbl_rank_donkey"
        Me.lbl_rank_donkey.Size = New System.Drawing.Size(0, 40)
        Me.lbl_rank_donkey.TabIndex = 21
        '
        'lbl_rank_turtle
        '
        Me.lbl_rank_turtle.AutoSize = True
        Me.lbl_rank_turtle.Font = New System.Drawing.Font("Segoe Script", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rank_turtle.ForeColor = System.Drawing.Color.MintCream
        Me.lbl_rank_turtle.Location = New System.Drawing.Point(953, 167)
        Me.lbl_rank_turtle.Name = "lbl_rank_turtle"
        Me.lbl_rank_turtle.Size = New System.Drawing.Size(0, 40)
        Me.lbl_rank_turtle.TabIndex = 20
        '
        'lbl_rank_sloth
        '
        Me.lbl_rank_sloth.AutoSize = True
        Me.lbl_rank_sloth.Font = New System.Drawing.Font("Segoe Script", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rank_sloth.ForeColor = System.Drawing.Color.MintCream
        Me.lbl_rank_sloth.Location = New System.Drawing.Point(953, 95)
        Me.lbl_rank_sloth.Name = "lbl_rank_sloth"
        Me.lbl_rank_sloth.Size = New System.Drawing.Size(0, 40)
        Me.lbl_rank_sloth.TabIndex = 19
        '
        'lbl_rank_sheep
        '
        Me.lbl_rank_sheep.AutoSize = True
        Me.lbl_rank_sheep.Font = New System.Drawing.Font("Segoe Script", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rank_sheep.ForeColor = System.Drawing.Color.MintCream
        Me.lbl_rank_sheep.Location = New System.Drawing.Point(953, 29)
        Me.lbl_rank_sheep.Name = "lbl_rank_sheep"
        Me.lbl_rank_sheep.Size = New System.Drawing.Size(0, 40)
        Me.lbl_rank_sheep.TabIndex = 18
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Timer5
        '
        '
        'lab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1051, 762)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.btn_bet)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lab2"
        Me.Text = "Animal Crossing"
        Me.gb_animals.ResumeLayout(False)
        Me.gb_animals.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pb_snail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_donkey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_turtle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_sloth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_sheep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_animals As GroupBox
    Friend WithEvents rdo_snail As RadioButton
    Friend WithEvents rdo_donkey As RadioButton
    Friend WithEvents rdo_turtle As RadioButton
    Friend WithEvents rdo_sloth As RadioButton
    Friend WithEvents rdo_sheep As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_bet As TextBox
    Friend WithEvents txt_cash_remain As TextBox
    Friend WithEvents txt_start_cash As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_bet As Button
    Friend WithEvents btn_start As Button
    Friend WithEvents lbl_profit As Label
    Friend WithEvents lbl_losses As Label
    Friend WithEvents lbl_wins As Label
    Friend WithEvents lbl_round As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_next As Button
    Friend WithEvents timer1 As Timer
    Friend WithEvents pg_snail As ProgressBar
    Friend WithEvents pg_sheep As ProgressBar
    Friend WithEvents pg_sloth As ProgressBar
    Friend WithEvents pg_turtle As ProgressBar
    Friend WithEvents pg_donkey As ProgressBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_rank_sheep As Label
    Friend WithEvents lbl_rank_snail As Label
    Friend WithEvents lbl_rank_donkey As Label
    Friend WithEvents lbl_rank_turtle As Label
    Friend WithEvents lbl_rank_sloth As Label
    Friend WithEvents pb_sheep As PictureBox
    Friend WithEvents pb_sloth As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pb_snail As PictureBox
    Friend WithEvents pb_donkey As PictureBox
    Friend WithEvents pb_turtle As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
End Class
