<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vDashboard
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_dashboard = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmi_file_login = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_dashboard = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.tab_dashboard.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv_dashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_dashboard)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(38, 110)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(780, 391)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.Tag = ""
        '
        'tab_dashboard
        '
        Me.tab_dashboard.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tab_dashboard.Controls.Add(Me.dgv_dashboard)
        Me.tab_dashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_dashboard.Location = New System.Drawing.Point(4, 22)
        Me.tab_dashboard.Name = "tab_dashboard"
        Me.tab_dashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_dashboard.Size = New System.Drawing.Size(772, 365)
        Me.tab_dashboard.TabIndex = 0
        Me.tab_dashboard.Text = "Top clients"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(772, 365)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Top videos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_file_login, Me.EmployeeToolStripMenuItem, Me.ClientToolStripMenuItem, Me.VideoToolStripMenuItem, Me.SearchToolStripMenuItem, Me.RentToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmi_file_login
        '
        Me.tsmi_file_login.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.tsmi_file_login.Name = "tsmi_file_login"
        Me.tsmi_file_login.Size = New System.Drawing.Size(37, 20)
        Me.tsmi_file_login.Text = "File"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem, Me.CreateToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem1, Me.CreateToolStripMenuItem1, Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem1})
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'ListToolStripMenuItem1
        '
        Me.ListToolStripMenuItem1.Name = "ListToolStripMenuItem1"
        Me.ListToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.ListToolStripMenuItem1.Text = "List"
        '
        'CreateToolStripMenuItem1
        '
        Me.CreateToolStripMenuItem1.Name = "CreateToolStripMenuItem1"
        Me.CreateToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem1.Text = "Create"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListToolStripMenuItem2, Me.CreateToolStripMenuItem2, Me.EditToolStripMenuItem2, Me.DeleteToolStripMenuItem2})
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'ListToolStripMenuItem2
        '
        Me.ListToolStripMenuItem2.Name = "ListToolStripMenuItem2"
        Me.ListToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.ListToolStripMenuItem2.Text = "List"
        '
        'CreateToolStripMenuItem2
        '
        Me.CreateToolStripMenuItem2.Name = "CreateToolStripMenuItem2"
        Me.CreateToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.CreateToolStripMenuItem2.Text = "Create"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.EditToolStripMenuItem2.Text = "Edit"
        '
        'DeleteToolStripMenuItem2
        '
        Me.DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        Me.DeleteToolStripMenuItem2.Size = New System.Drawing.Size(108, 22)
        Me.DeleteToolStripMenuItem2.Text = "Delete"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuickToolStripMenuItem, Me.AdvanceToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'QuickToolStripMenuItem
        '
        Me.QuickToolStripMenuItem.Name = "QuickToolStripMenuItem"
        Me.QuickToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.QuickToolStripMenuItem.Text = "Quick"
        '
        'AdvanceToolStripMenuItem
        '
        Me.AdvanceToolStripMenuItem.Name = "AdvanceToolStripMenuItem"
        Me.AdvanceToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AdvanceToolStripMenuItem.Text = "Advance"
        '
        'RentToolStripMenuItem
        '
        Me.RentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentVideoToolStripMenuItem, Me.ReturnVideoToolStripMenuItem})
        Me.RentToolStripMenuItem.Name = "RentToolStripMenuItem"
        Me.RentToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.RentToolStripMenuItem.Text = "Rent"
        '
        'RentVideoToolStripMenuItem
        '
        Me.RentVideoToolStripMenuItem.Name = "RentVideoToolStripMenuItem"
        Me.RentVideoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.RentVideoToolStripMenuItem.Text = "Rent Video"
        '
        'ReturnVideoToolStripMenuItem
        '
        Me.ReturnVideoToolStripMenuItem.Name = "ReturnVideoToolStripMenuItem"
        Me.ReturnVideoToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ReturnVideoToolStripMenuItem.Text = "Return Video"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(34, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Dashboard"
        '
        'dgv_dashboard
        '
        Me.dgv_dashboard.BackgroundColor = System.Drawing.Color.White
        Me.dgv_dashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dashboard.Location = New System.Drawing.Point(6, 6)
        Me.dgv_dashboard.Name = "dgv_dashboard"
        Me.dgv_dashboard.Size = New System.Drawing.Size(760, 353)
        Me.dgv_dashboard.TabIndex = 0
        '
        'vDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(856, 524)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "vDashboard"
        Me.Text = "BlueBuster"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_dashboard.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv_dashboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_dashboard As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmi_file_login As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgv_dashboard As DataGridView
End Class
