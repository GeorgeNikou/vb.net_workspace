<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vSearch
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
        Me.btn_search_videolist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search_videolist = New System.Windows.Forms.TextBox()
        Me.btn_back_videolist = New System.Windows.Forms.Button()
        Me.dgv_videolist = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_videolist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_search_videolist
        '
        Me.btn_search_videolist.AutoSize = True
        Me.btn_search_videolist.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_search_videolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_videolist.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_videolist.ForeColor = System.Drawing.Color.White
        Me.btn_search_videolist.Location = New System.Drawing.Point(389, 24)
        Me.btn_search_videolist.Name = "btn_search_videolist"
        Me.btn_search_videolist.Size = New System.Drawing.Size(135, 31)
        Me.btn_search_videolist.TabIndex = 41
        Me.btn_search_videolist.Text = "Search"
        Me.btn_search_videolist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(24, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 41)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Quick Video Search"
        '
        'txt_search_videolist
        '
        Me.txt_search_videolist.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search_videolist.BackColor = System.Drawing.Color.White
        Me.txt_search_videolist.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_search_videolist.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_search_videolist.Location = New System.Drawing.Point(533, 33)
        Me.txt_search_videolist.Name = "txt_search_videolist"
        Me.txt_search_videolist.Size = New System.Drawing.Size(282, 29)
        Me.txt_search_videolist.TabIndex = 39
        Me.txt_search_videolist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_back_videolist
        '
        Me.btn_back_videolist.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_videolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_videolist.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_videolist.ForeColor = System.Drawing.Color.White
        Me.btn_back_videolist.Location = New System.Drawing.Point(8, 495)
        Me.btn_back_videolist.Name = "btn_back_videolist"
        Me.btn_back_videolist.Size = New System.Drawing.Size(811, 41)
        Me.btn_back_videolist.TabIndex = 38
        Me.btn_back_videolist.Text = "Back"
        Me.btn_back_videolist.UseVisualStyleBackColor = False
        '
        'dgv_videolist
        '
        Me.dgv_videolist.BackgroundColor = System.Drawing.Color.White
        Me.dgv_videolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_videolist.Location = New System.Drawing.Point(8, 69)
        Me.dgv_videolist.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_videolist.Name = "dgv_videolist"
        Me.dgv_videolist.RowTemplate.Height = 24
        Me.dgv_videolist.Size = New System.Drawing.Size(811, 406)
        Me.dgv_videolist.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(530, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Title or Video ID"
        '
        'vSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 550)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_search_videolist)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_search_videolist)
        Me.Controls.Add(Me.btn_back_videolist)
        Me.Controls.Add(Me.dgv_videolist)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "vSearch"
        Me.Text = "vSearch"
        CType(Me.dgv_videolist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_search_videolist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search_videolist As TextBox
    Friend WithEvents btn_back_videolist As Button
    Friend WithEvents dgv_videolist As DataGridView
    Friend WithEvents Label2 As Label
End Class
