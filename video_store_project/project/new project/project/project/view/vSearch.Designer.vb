<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vSearch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_search_qsearch = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_title_qsearch = New System.Windows.Forms.TextBox()
        Me.txt_id_qsearch = New System.Windows.Forms.TextBox()
        Me.lbl_id_quicksearch = New System.Windows.Forms.Label()
        Me.lbl_title_quicksearch = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(139, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 47)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Quick Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(31, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Title"
        '
        'btn_search_qsearch
        '
        Me.btn_search_qsearch.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_search_qsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_qsearch.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search_qsearch.ForeColor = System.Drawing.Color.White
        Me.btn_search_qsearch.Location = New System.Drawing.Point(36, 159)
        Me.btn_search_qsearch.Name = "btn_search_qsearch"
        Me.btn_search_qsearch.Size = New System.Drawing.Size(369, 41)
        Me.btn_search_qsearch.TabIndex = 13
        Me.btn_search_qsearch.Text = "Search"
        Me.btn_search_qsearch.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Location = New System.Drawing.Point(31, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Video ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_title_quicksearch)
        Me.GroupBox1.Controls.Add(Me.lbl_id_quicksearch)
        Me.GroupBox1.Controls.Add(Me.txt_title_qsearch)
        Me.GroupBox1.Controls.Add(Me.txt_id_qsearch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_search_qsearch)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 223)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'txt_title_qsearch
        '
        Me.txt_title_qsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_title_qsearch.BackColor = System.Drawing.Color.White
        Me.txt_title_qsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_title_qsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_title_qsearch.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_title_qsearch.Location = New System.Drawing.Point(142, 101)
        Me.txt_title_qsearch.Name = "txt_title_qsearch"
        Me.txt_title_qsearch.Size = New System.Drawing.Size(263, 22)
        Me.txt_title_qsearch.TabIndex = 15
        Me.txt_title_qsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_id_qsearch
        '
        Me.txt_id_qsearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id_qsearch.BackColor = System.Drawing.Color.White
        Me.txt_id_qsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_qsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_qsearch.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txt_id_qsearch.Location = New System.Drawing.Point(142, 45)
        Me.txt_id_qsearch.Name = "txt_id_qsearch"
        Me.txt_id_qsearch.Size = New System.Drawing.Size(263, 22)
        Me.txt_id_qsearch.TabIndex = 14
        Me.txt_id_qsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_id_quicksearch
        '
        Me.lbl_id_quicksearch.AutoSize = True
        Me.lbl_id_quicksearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_quicksearch.ForeColor = System.Drawing.Color.Red
        Me.lbl_id_quicksearch.Location = New System.Drawing.Point(153, 70)
        Me.lbl_id_quicksearch.Name = "lbl_id_quicksearch"
        Me.lbl_id_quicksearch.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id_quicksearch.TabIndex = 29
        '
        'lbl_title_quicksearch
        '
        Me.lbl_title_quicksearch.AutoSize = True
        Me.lbl_title_quicksearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title_quicksearch.ForeColor = System.Drawing.Color.Red
        Me.lbl_title_quicksearch.Location = New System.Drawing.Point(153, 126)
        Me.lbl_title_quicksearch.Name = "lbl_title_quicksearch"
        Me.lbl_title_quicksearch.Size = New System.Drawing.Size(0, 13)
        Me.lbl_title_quicksearch.TabIndex = 30
        '
        'vSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 332)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "vSearch"
        Me.Text = "BlueBuster Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_search_qsearch As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_title_qsearch As TextBox
    Friend WithEvents txt_id_qsearch As TextBox
    Friend WithEvents lbl_title_quicksearch As Label
    Friend WithEvents lbl_id_quicksearch As Label
End Class
