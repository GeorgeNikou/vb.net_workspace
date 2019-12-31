<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VEmployeeList
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
        Me.btn_search_employeelist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search_clientlist = New System.Windows.Forms.TextBox()
        Me.btn_back_employeelistlist = New System.Windows.Forms.Button()
        Me.dgv_employeelist = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_employeelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_search_employeelist
        '
        Me.btn_search_employeelist.AutoSize = True
        Me.btn_search_employeelist.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_search_employeelist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_employeelist.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_employeelist.ForeColor = System.Drawing.Color.White
        Me.btn_search_employeelist.Location = New System.Drawing.Point(955, 22)
        Me.btn_search_employeelist.Name = "btn_search_employeelist"
        Me.btn_search_employeelist.Size = New System.Drawing.Size(135, 31)
        Me.btn_search_employeelist.TabIndex = 36
        Me.btn_search_employeelist.Text = "search"
        Me.btn_search_employeelist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 41)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Employee List"
        '
        'txt_search_clientlist
        '
        Me.txt_search_clientlist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_clientlist.BackColor = System.Drawing.Color.White
        Me.txt_search_clientlist.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_clientlist.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_clientlist.Location = New System.Drawing.Point(1108, 24)
        Me.txt_search_clientlist.Name = "txt_search_clientlist"
        Me.txt_search_clientlist.Size = New System.Drawing.Size(250, 29)
        Me.txt_search_clientlist.TabIndex = 34
        Me.txt_search_clientlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_back_employeelistlist
        '
        Me.btn_back_employeelistlist.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_employeelistlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_employeelistlist.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_employeelistlist.ForeColor = System.Drawing.Color.White
        Me.btn_back_employeelistlist.Location = New System.Drawing.Point(1154, 499)
        Me.btn_back_employeelistlist.Name = "btn_back_employeelistlist"
        Me.btn_back_employeelistlist.Size = New System.Drawing.Size(201, 41)
        Me.btn_back_employeelistlist.TabIndex = 33
        Me.btn_back_employeelistlist.Text = "Back"
        Me.btn_back_employeelistlist.UseVisualStyleBackColor = False
        '
        'dgv_employeelist
        '
        Me.dgv_employeelist.BackgroundColor = System.Drawing.Color.White
        Me.dgv_employeelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employeelist.Location = New System.Drawing.Point(4, 70)
        Me.dgv_employeelist.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_employeelist.Name = "dgv_employeelist"
        Me.dgv_employeelist.RowTemplate.Height = 24
        Me.dgv_employeelist.Size = New System.Drawing.Size(1351, 406)
        Me.dgv_employeelist.TabIndex = 32
        '
        'VEmployeeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 552)
        Me.Controls.Add(Me.btn_search_employeelist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search_clientlist)
        Me.Controls.Add(Me.btn_back_employeelistlist)
        Me.Controls.Add(Me.dgv_employeelist)
        Me.Name = "VEmployeeList"
        Me.Text = "VEmployeeList"
        CType(Me.dgv_employeelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_search_employeelist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search_clientlist As TextBox
    Friend WithEvents btn_back_employeelistlist As Button
    Friend WithEvents dgv_employeelist As DataGridView
End Class
