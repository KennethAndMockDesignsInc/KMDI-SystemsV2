<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectAssignment
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.ClientDetailsTab = New MetroFramework.Controls.MetroTabPage()
        Me.PertinentDetailsTab = New MetroFramework.Controls.MetroTabPage()
        Me.ProjectStatusTab = New MetroFramework.Controls.MetroTabPage()
        Me.TechnicalPartnersTab = New MetroFramework.Controls.MetroTabPage()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.ClientsNameLbl = New MetroFramework.Controls.MetroLabel()
        Me.CompanyNameLbl = New MetroFramework.Controls.MetroLabel()
        Me.ProjStatsLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.ProjStatsLbl)
        Me.MetroPanel1.Controls.Add(Me.CompanyNameLbl)
        Me.MetroPanel1.Controls.Add(Me.ClientsNameLbl)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(800, 100)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.MetroTabControl1)
        Me.MetroPanel2.Controls.Add(Me.MetroGrid1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(20, 160)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(800, 444)
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.ClientDetailsTab)
        Me.MetroTabControl1.Controls.Add(Me.PertinentDetailsTab)
        Me.MetroTabControl1.Controls.Add(Me.ProjectStatusTab)
        Me.MetroTabControl1.Controls.Add(Me.TechnicalPartnersTab)
        Me.MetroTabControl1.Location = New System.Drawing.Point(2, 3)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(402, 435)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTabControl1.TabIndex = 5
        Me.MetroTabControl1.UseSelectable = True
        '
        'ClientDetailsTab
        '
        Me.ClientDetailsTab.HorizontalScrollbarBarColor = True
        Me.ClientDetailsTab.HorizontalScrollbarHighlightOnWheel = False
        Me.ClientDetailsTab.HorizontalScrollbarSize = 10
        Me.ClientDetailsTab.Location = New System.Drawing.Point(4, 38)
        Me.ClientDetailsTab.Name = "ClientDetailsTab"
        Me.ClientDetailsTab.Size = New System.Drawing.Size(394, 393)
        Me.ClientDetailsTab.TabIndex = 0
        Me.ClientDetailsTab.Text = "Client Details"
        Me.ClientDetailsTab.VerticalScrollbarBarColor = True
        Me.ClientDetailsTab.VerticalScrollbarHighlightOnWheel = False
        Me.ClientDetailsTab.VerticalScrollbarSize = 10
        '
        'PertinentDetailsTab
        '
        Me.PertinentDetailsTab.HorizontalScrollbarBarColor = True
        Me.PertinentDetailsTab.HorizontalScrollbarHighlightOnWheel = False
        Me.PertinentDetailsTab.HorizontalScrollbarSize = 10
        Me.PertinentDetailsTab.Location = New System.Drawing.Point(4, 38)
        Me.PertinentDetailsTab.Name = "PertinentDetailsTab"
        Me.PertinentDetailsTab.Size = New System.Drawing.Size(474, 393)
        Me.PertinentDetailsTab.TabIndex = 1
        Me.PertinentDetailsTab.Text = "Pertinent Details"
        Me.PertinentDetailsTab.VerticalScrollbarBarColor = True
        Me.PertinentDetailsTab.VerticalScrollbarHighlightOnWheel = False
        Me.PertinentDetailsTab.VerticalScrollbarSize = 10
        '
        'ProjectStatusTab
        '
        Me.ProjectStatusTab.HorizontalScrollbarBarColor = True
        Me.ProjectStatusTab.HorizontalScrollbarHighlightOnWheel = False
        Me.ProjectStatusTab.HorizontalScrollbarSize = 10
        Me.ProjectStatusTab.Location = New System.Drawing.Point(4, 38)
        Me.ProjectStatusTab.Name = "ProjectStatusTab"
        Me.ProjectStatusTab.Size = New System.Drawing.Size(474, 393)
        Me.ProjectStatusTab.TabIndex = 2
        Me.ProjectStatusTab.Text = "Project Status"
        Me.ProjectStatusTab.VerticalScrollbarBarColor = True
        Me.ProjectStatusTab.VerticalScrollbarHighlightOnWheel = False
        Me.ProjectStatusTab.VerticalScrollbarSize = 10
        '
        'TechnicalPartnersTab
        '
        Me.TechnicalPartnersTab.HorizontalScrollbarBarColor = True
        Me.TechnicalPartnersTab.HorizontalScrollbarHighlightOnWheel = False
        Me.TechnicalPartnersTab.HorizontalScrollbarSize = 10
        Me.TechnicalPartnersTab.Location = New System.Drawing.Point(4, 38)
        Me.TechnicalPartnersTab.Name = "TechnicalPartnersTab"
        Me.TechnicalPartnersTab.Size = New System.Drawing.Size(474, 393)
        Me.TechnicalPartnersTab.TabIndex = 3
        Me.TechnicalPartnersTab.Text = "Technical Partners"
        Me.TechnicalPartnersTab.VerticalScrollbarBarColor = True
        Me.TechnicalPartnersTab.VerticalScrollbarHighlightOnWheel = False
        Me.TechnicalPartnersTab.VerticalScrollbarSize = 10
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(404, 3)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(393, 438)
        Me.MetroGrid1.TabIndex = 6
        '
        'ClientsNameLbl
        '
        Me.ClientsNameLbl.AutoSize = True
        Me.ClientsNameLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ClientsNameLbl.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ClientsNameLbl.Location = New System.Drawing.Point(11, 9)
        Me.ClientsNameLbl.Name = "ClientsNameLbl"
        Me.ClientsNameLbl.Size = New System.Drawing.Size(235, 25)
        Me.ClientsNameLbl.Style = MetroFramework.MetroColorStyle.Green
        Me.ClientsNameLbl.TabIndex = 2
        Me.ClientsNameLbl.Text = "Last Name, First Name MI."
        '
        'CompanyNameLbl
        '
        Me.CompanyNameLbl.AutoSize = True
        Me.CompanyNameLbl.ForeColor = System.Drawing.Color.DimGray
        Me.CompanyNameLbl.Location = New System.Drawing.Point(11, 38)
        Me.CompanyNameLbl.Name = "CompanyNameLbl"
        Me.CompanyNameLbl.Size = New System.Drawing.Size(106, 19)
        Me.CompanyNameLbl.Style = MetroFramework.MetroColorStyle.Green
        Me.CompanyNameLbl.TabIndex = 3
        Me.CompanyNameLbl.Text = "Company Name"
        Me.CompanyNameLbl.UseCustomForeColor = True
        '
        'ProjStatsLbl
        '
        Me.ProjStatsLbl.AutoSize = True
        Me.ProjStatsLbl.ForeColor = System.Drawing.Color.DimGray
        Me.ProjStatsLbl.Location = New System.Drawing.Point(11, 61)
        Me.ProjStatsLbl.Name = "ProjStatsLbl"
        Me.ProjStatsLbl.Size = New System.Drawing.Size(88, 19)
        Me.ProjStatsLbl.Style = MetroFramework.MetroColorStyle.Green
        Me.ProjStatsLbl.TabIndex = 4
        Me.ProjStatsLbl.Text = "Project Status"
        Me.ProjStatsLbl.UseCustomForeColor = True
        '
        'ProjectAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 624)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "ProjectAssignment"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents ClientDetailsTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PertinentDetailsTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ProjectStatusTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TechnicalPartnersTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents ProjStatsLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents CompanyNameLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents ClientsNameLbl As MetroFramework.Controls.MetroLabel
End Class
