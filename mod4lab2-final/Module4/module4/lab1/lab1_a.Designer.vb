<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class lab1_a
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lab1_a))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_count_driver = New System.Windows.Forms.Label()
        Me.lbl_kilometers = New System.Windows.Forms.Label()
        Me.lbl_consumption = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_passengers = New System.Windows.Forms.Label()
        Me.txt_kilo = New System.Windows.Forms.TextBox()
        Me.txt_consumption = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_num_passengers = New System.Windows.Forms.TextBox()
        Me.rdo_yes = New System.Windows.Forms.RadioButton()
        Me.rdo_no = New System.Windows.Forms.RadioButton()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.lbl_per_person = New System.Windows.Forms.Label()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(776, 102)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Traveling Fees"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_count_driver
        '
        Me.lbl_count_driver.AutoSize = True
        Me.lbl_count_driver.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_count_driver.Location = New System.Drawing.Point(94, 147)
        Me.lbl_count_driver.Name = "lbl_count_driver"
        Me.lbl_count_driver.Size = New System.Drawing.Size(154, 29)
        Me.lbl_count_driver.TabIndex = 1
        Me.lbl_count_driver.Text = "Count drivers"
        '
        'lbl_kilometers
        '
        Me.lbl_kilometers.AutoSize = True
        Me.lbl_kilometers.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kilometers.Location = New System.Drawing.Point(93, 192)
        Me.lbl_kilometers.Name = "lbl_kilometers"
        Me.lbl_kilometers.Size = New System.Drawing.Size(124, 29)
        Me.lbl_kilometers.TabIndex = 2
        Me.lbl_kilometers.Text = "Kilometers"
        '
        'lbl_consumption
        '
        Me.lbl_consumption.AutoSize = True
        Me.lbl_consumption.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_consumption.Location = New System.Drawing.Point(96, 239)
        Me.lbl_consumption.Name = "lbl_consumption"
        Me.lbl_consumption.Size = New System.Drawing.Size(149, 29)
        Me.lbl_consumption.TabIndex = 3
        Me.lbl_consumption.Text = "Consumption"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.Location = New System.Drawing.Point(96, 277)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(112, 29)
        Me.lbl_price.TabIndex = 4
        Me.lbl_price.Text = "Gaz price"
        '
        'lbl_passengers
        '
        Me.lbl_passengers.AutoSize = True
        Me.lbl_passengers.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_passengers.Location = New System.Drawing.Point(96, 319)
        Me.lbl_passengers.Name = "lbl_passengers"
        Me.lbl_passengers.Size = New System.Drawing.Size(187, 29)
        Me.lbl_passengers.TabIndex = 5
        Me.lbl_passengers.Text = "# of passengers"
        '
        'txt_kilo
        '
        Me.txt_kilo.BackColor = System.Drawing.SystemColors.Window
        Me.txt_kilo.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_kilo.Location = New System.Drawing.Point(444, 199)
        Me.txt_kilo.Name = "txt_kilo"
        Me.txt_kilo.Size = New System.Drawing.Size(284, 28)
        Me.txt_kilo.TabIndex = 8
        '
        'txt_consumption
        '
        Me.txt_consumption.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_consumption.Location = New System.Drawing.Point(443, 239)
        Me.txt_consumption.Name = "txt_consumption"
        Me.txt_consumption.Size = New System.Drawing.Size(284, 28)
        Me.txt_consumption.TabIndex = 9
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_price.Location = New System.Drawing.Point(443, 280)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(284, 28)
        Me.txt_price.TabIndex = 10
        '
        'txt_num_passengers
        '
        Me.txt_num_passengers.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num_passengers.Location = New System.Drawing.Point(443, 322)
        Me.txt_num_passengers.Name = "txt_num_passengers"
        Me.txt_num_passengers.Size = New System.Drawing.Size(284, 28)
        Me.txt_num_passengers.TabIndex = 11
        '
        'rdo_yes
        '
        Me.rdo_yes.AutoSize = True
        Me.rdo_yes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_yes.Location = New System.Drawing.Point(444, 155)
        Me.rdo_yes.Name = "rdo_yes"
        Me.rdo_yes.Size = New System.Drawing.Size(61, 28)
        Me.rdo_yes.TabIndex = 12
        Me.rdo_yes.TabStop = True
        Me.rdo_yes.Text = "yes"
        Me.rdo_yes.UseVisualStyleBackColor = True
        '
        'rdo_no
        '
        Me.rdo_no.AutoSize = True
        Me.rdo_no.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_no.Location = New System.Drawing.Point(613, 155)
        Me.rdo_no.Name = "rdo_no"
        Me.rdo_no.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rdo_no.Size = New System.Drawing.Size(53, 28)
        Me.rdo_no.TabIndex = 13
        Me.rdo_no.TabStop = True
        Me.rdo_no.Text = "no"
        Me.rdo_no.UseVisualStyleBackColor = True
        '
        'btn_enter
        '
        Me.btn_enter.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_enter.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter.Location = New System.Drawing.Point(598, 388)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(129, 29)
        Me.btn_enter.TabIndex = 14
        Me.btn_enter.Text = "Enter"
        Me.btn_enter.UseVisualStyleBackColor = False
        '
        'lbl_per_person
        '
        Me.lbl_per_person.AutoSize = True
        Me.lbl_per_person.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_per_person.Location = New System.Drawing.Point(94, 388)
        Me.lbl_per_person.Name = "lbl_per_person"
        Me.lbl_per_person.Size = New System.Drawing.Size(132, 21)
        Me.lbl_per_person.TabIndex = 15
        Me.lbl_per_person.Text = "Total per person"
        '
        'txt_result
        '
        Me.txt_result.BackColor = System.Drawing.SystemColors.Window
        Me.txt_result.Font = New System.Drawing.Font("Tahoma", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_result.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txt_result.Location = New System.Drawing.Point(243, 388)
        Me.txt_result.Name = "txt_result"
        Me.txt_result.ReadOnly = True
        Me.txt_result.Size = New System.Drawing.Size(91, 23)
        Me.txt_result.TabIndex = 16
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_reset.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.Location = New System.Drawing.Point(443, 388)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(129, 29)
        Me.btn_reset.TabIndex = 17
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'lab1_a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.lbl_per_person)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.rdo_no)
        Me.Controls.Add(Me.rdo_yes)
        Me.Controls.Add(Me.txt_num_passengers)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_consumption)
        Me.Controls.Add(Me.txt_kilo)
        Me.Controls.Add(Me.lbl_passengers)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_consumption)
        Me.Controls.Add(Me.lbl_kilometers)
        Me.Controls.Add(Me.lbl_count_driver)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(818, 497)
        Me.MinimumSize = New System.Drawing.Size(818, 497)
        Me.Name = "lab1_a"
        Me.Text = "Travel Guide"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_count_driver As Label
    Friend WithEvents lbl_kilometers As Label
    Friend WithEvents lbl_consumption As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_passengers As Label
    Friend WithEvents txt_kilo As TextBox
    Friend WithEvents txt_consumption As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_num_passengers As TextBox
    Friend WithEvents rdo_yes As RadioButton
    Friend WithEvents rdo_no As RadioButton
    Friend WithEvents btn_enter As Button
    Friend WithEvents lbl_per_person As Label
    Friend WithEvents txt_result As TextBox
    Friend WithEvents btn_reset As Button
End Class
