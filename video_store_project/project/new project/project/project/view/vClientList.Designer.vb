<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vClientList
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
        Me.dgv_clientlist = New System.Windows.Forms.DataGridView()
        Me.btn_back_clientlist = New System.Windows.Forms.Button()
        Me.txt_search_clientlist = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_search_clientlist = New System.Windows.Forms.Button()
        CType(Me.dgv_clientlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_clientlist
        '
        Me.dgv_clientlist.BackgroundColor = System.Drawing.Color.White
        Me.dgv_clientlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientlist.Location = New System.Drawing.Point(6, 82)
        Me.dgv_clientlist.Name = "dgv_clientlist"
        Me.dgv_clientlist.RowTemplate.Height = 24
        Me.dgv_clientlist.Size = New System.Drawing.Size(1081, 500)
        Me.dgv_clientlist.TabIndex = 0
        '
        'btn_back_clientlist
        '
        Me.btn_back_clientlist.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_clientlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_clientlist.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_clientlist.ForeColor = System.Drawing.Color.White
        Me.btn_back_clientlist.Location = New System.Drawing.Point(6, 607)
        Me.btn_back_clientlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_back_clientlist.Name = "btn_back_clientlist"
        Me.btn_back_clientlist.Size = New System.Drawing.Size(1081, 50)
        Me.btn_back_clientlist.TabIndex = 27
        Me.btn_back_clientlist.Text = "Back"
        Me.btn_back_clientlist.UseVisualStyleBackColor = False
        '
        'txt_search_clientlist
        '
        Me.txt_search_clientlist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_clientlist.BackColor = System.Drawing.Color.White
        Me.txt_search_clientlist.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_clientlist.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_clientlist.Location = New System.Drawing.Point(704, 26)
        Me.txt_search_clientlist.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_search_clientlist.Name = "txt_search_clientlist"
        Me.txt_search_clientlist.Size = New System.Drawing.Size(374, 34)
        Me.txt_search_clientlist.TabIndex = 29
        Me.txt_search_clientlist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 51)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Client List"
        '
        'btn_search_clientlist
        '
        Me.btn_search_clientlist.AutoSize = True
        Me.btn_search_clientlist.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_search_clientlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_clientlist.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_clientlist.ForeColor = System.Drawing.Color.White
        Me.btn_search_clientlist.Location = New System.Drawing.Point(516, 26)
        Me.btn_search_clientlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_search_clientlist.Name = "btn_search_clientlist"
        Me.btn_search_clientlist.Size = New System.Drawing.Size(180, 35)
        Me.btn_search_clientlist.TabIndex = 31
        Me.btn_search_clientlist.Text = "search"
        Me.btn_search_clientlist.UseVisualStyleBackColor = False
        '
        'vClientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 680)
        Me.Controls.Add(Me.btn_search_clientlist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search_clientlist)
        Me.Controls.Add(Me.btn_back_clientlist)
        Me.Controls.Add(Me.dgv_clientlist)
        Me.Name = "vClientList"
        Me.Text = "BlueBuster"
        CType(Me.dgv_clientlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_clientlist As DataGridView
    Friend WithEvents btn_back_clientlist As Button
    Friend WithEvents txt_search_clientlist As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_search_clientlist As Button
End Class
