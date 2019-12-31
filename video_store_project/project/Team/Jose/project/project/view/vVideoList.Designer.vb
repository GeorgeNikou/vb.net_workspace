<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vVideoList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_back_videolist = New System.Windows.Forms.Button()
        Me.dgv_videolist = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_videolist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 41)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Video List"
        '
        'btn_back_videolist
        '
        Me.btn_back_videolist.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_back_videolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back_videolist.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back_videolist.ForeColor = System.Drawing.Color.White
        Me.btn_back_videolist.Location = New System.Drawing.Point(8, 494)
        Me.btn_back_videolist.Name = "btn_back_videolist"
        Me.btn_back_videolist.Size = New System.Drawing.Size(811, 41)
        Me.btn_back_videolist.TabIndex = 33
        Me.btn_back_videolist.Text = "Back"
        Me.btn_back_videolist.UseVisualStyleBackColor = False
        '
        'dgv_videolist
        '
        Me.dgv_videolist.BackgroundColor = System.Drawing.Color.White
        Me.dgv_videolist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_videolist.Location = New System.Drawing.Point(8, 68)
        Me.dgv_videolist.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_videolist.Name = "dgv_videolist"
        Me.dgv_videolist.RowTemplate.Height = 24
        Me.dgv_videolist.Size = New System.Drawing.Size(811, 406)
        Me.dgv_videolist.TabIndex = 32
        '
        'vVideoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 549)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_back_videolist)
        Me.Controls.Add(Me.dgv_videolist)
        Me.Name = "vVideoList"
        Me.Text = "vVideoList"
        CType(Me.dgv_videolist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back_videolist As Button
    Friend WithEvents dgv_videolist As DataGridView
End Class
