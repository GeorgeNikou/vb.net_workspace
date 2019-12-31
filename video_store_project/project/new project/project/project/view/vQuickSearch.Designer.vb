<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vQuickSearch
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
        Me.dgv_quicksearch = New System.Windows.Forms.DataGridView()
        Me.btn_quicksearch_cancel = New System.Windows.Forms.Button()
        Me.btn_quicksearch_rent = New System.Windows.Forms.Button()
        Me.pnl_quicksearch = New System.Windows.Forms.Panel()
        Me.lbl_quicksearch = New System.Windows.Forms.Label()
        CType(Me.dgv_quicksearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_quicksearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_quicksearch
        '
        Me.dgv_quicksearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_quicksearch.Location = New System.Drawing.Point(3, 3)
        Me.dgv_quicksearch.Name = "dgv_quicksearch"
        Me.dgv_quicksearch.Size = New System.Drawing.Size(1219, 380)
        Me.dgv_quicksearch.TabIndex = 0
        '
        'btn_quicksearch_cancel
        '
        Me.btn_quicksearch_cancel.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btn_quicksearch_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quicksearch_cancel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quicksearch_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_quicksearch_cancel.Location = New System.Drawing.Point(342, 397)
        Me.btn_quicksearch_cancel.Name = "btn_quicksearch_cancel"
        Me.btn_quicksearch_cancel.Size = New System.Drawing.Size(299, 41)
        Me.btn_quicksearch_cancel.TabIndex = 27
        Me.btn_quicksearch_cancel.Text = "Cancel"
        Me.btn_quicksearch_cancel.UseVisualStyleBackColor = False
        '
        'btn_quicksearch_rent
        '
        Me.btn_quicksearch_rent.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_quicksearch_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_quicksearch_rent.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quicksearch_rent.ForeColor = System.Drawing.Color.White
        Me.btn_quicksearch_rent.Location = New System.Drawing.Point(656, 397)
        Me.btn_quicksearch_rent.Name = "btn_quicksearch_rent"
        Me.btn_quicksearch_rent.Size = New System.Drawing.Size(299, 41)
        Me.btn_quicksearch_rent.TabIndex = 26
        Me.btn_quicksearch_rent.Text = "Rent"
        Me.btn_quicksearch_rent.UseVisualStyleBackColor = False
        '
        'pnl_quicksearch
        '
        Me.pnl_quicksearch.Controls.Add(Me.lbl_quicksearch)
        Me.pnl_quicksearch.Location = New System.Drawing.Point(3, 3)
        Me.pnl_quicksearch.Name = "pnl_quicksearch"
        Me.pnl_quicksearch.Size = New System.Drawing.Size(1219, 388)
        Me.pnl_quicksearch.TabIndex = 28
        '
        'lbl_quicksearch
        '
        Me.lbl_quicksearch.AutoSize = True
        Me.lbl_quicksearch.Font = New System.Drawing.Font("Segoe UI", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quicksearch.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_quicksearch.Location = New System.Drawing.Point(379, 131)
        Me.lbl_quicksearch.Name = "lbl_quicksearch"
        Me.lbl_quicksearch.Size = New System.Drawing.Size(540, 86)
        Me.lbl_quicksearch.TabIndex = 0
        Me.lbl_quicksearch.Text = "Video Not Found"
        Me.lbl_quicksearch.Visible = False
        '
        'vQuickSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 450)
        Me.Controls.Add(Me.pnl_quicksearch)
        Me.Controls.Add(Me.btn_quicksearch_cancel)
        Me.Controls.Add(Me.btn_quicksearch_rent)
        Me.Controls.Add(Me.dgv_quicksearch)
        Me.Name = "vQuickSearch"
        Me.Text = "BlueBuster Quick Search"
        CType(Me.dgv_quicksearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_quicksearch.ResumeLayout(False)
        Me.pnl_quicksearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_quicksearch As DataGridView
    Friend WithEvents btn_quicksearch_cancel As Button
    Friend WithEvents btn_quicksearch_rent As Button
    Friend WithEvents pnl_quicksearch As Panel
    Friend WithEvents lbl_quicksearch As Label
End Class
