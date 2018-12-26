<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Project_Details
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Project_Details))
        Me.ProjectDetailsDGV = New MetroFramework.Controls.MetroGrid()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.ProjectDetailsLBL = New MetroFramework.Controls.MetroLabel()
        Me.PD_ContextMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesJobOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddendumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ProjectDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PD_ContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProjectDetailsDGV
        '
        Me.ProjectDetailsDGV.AllowUserToAddRows = False
        Me.ProjectDetailsDGV.AllowUserToDeleteRows = False
        Me.ProjectDetailsDGV.AllowUserToOrderColumns = True
        Me.ProjectDetailsDGV.AllowUserToResizeRows = False
        Me.ProjectDetailsDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProjectDetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProjectDetailsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProjectDetailsDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProjectDetailsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProjectDetailsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ProjectDetailsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProjectDetailsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ProjectDetailsDGV.ColumnHeadersHeight = 30
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProjectDetailsDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.ProjectDetailsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ProjectDetailsDGV.EnableHeadersVisualStyles = False
        Me.ProjectDetailsDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ProjectDetailsDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProjectDetailsDGV.Location = New System.Drawing.Point(20, 60)
        Me.ProjectDetailsDGV.MultiSelect = False
        Me.ProjectDetailsDGV.Name = "ProjectDetailsDGV"
        Me.ProjectDetailsDGV.ReadOnly = True
        Me.ProjectDetailsDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProjectDetailsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ProjectDetailsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.ProjectDetailsDGV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ProjectDetailsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProjectDetailsDGV.Size = New System.Drawing.Size(984, 620)
        Me.ProjectDetailsDGV.Style = MetroFramework.MetroColorStyle.Silver
        Me.ProjectDetailsDGV.TabIndex = 11
        Me.ProjectDetailsDGV.UseStyleColors = True
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(939, 29)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 10
        Me.LoadingPB.TabStop = False
        '
        'ProjectDetailsLBL
        '
        Me.ProjectDetailsLBL.AutoSize = True
        Me.ProjectDetailsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ProjectDetailsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ProjectDetailsLBL.Location = New System.Drawing.Point(20, 32)
        Me.ProjectDetailsLBL.Name = "ProjectDetailsLBL"
        Me.ProjectDetailsLBL.Size = New System.Drawing.Size(236, 25)
        Me.ProjectDetailsLBL.TabIndex = 607
        Me.ProjectDetailsLBL.Text = "P R O J E C T   D E T A I L S"
        '
        'PD_ContextMenu
        '
        Me.PD_ContextMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PD_ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.SalesJobOrderToolStripMenuItem, Me.AddendumToolStripMenuItem})
        Me.PD_ContextMenu.Name = "PD_ContextMenu"
        Me.PD_ContextMenu.Size = New System.Drawing.Size(155, 70)
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NewProjectToolStripMenuItem.Text = "N&ew Project"
        '
        'SalesJobOrderToolStripMenuItem
        '
        Me.SalesJobOrderToolStripMenuItem.Name = "SalesJobOrderToolStripMenuItem"
        Me.SalesJobOrderToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SalesJobOrderToolStripMenuItem.Text = "&Sales Job Order"
        '
        'AddendumToolStripMenuItem
        '
        Me.AddendumToolStripMenuItem.Name = "AddendumToolStripMenuItem"
        Me.AddendumToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.AddendumToolStripMenuItem.Text = "&Addendum"
        '
        'Project_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.ProjectDetailsLBL)
        Me.Controls.Add(Me.ProjectDetailsDGV)
        Me.Controls.Add(Me.LoadingPB)
        Me.IsMdiContainer = True
        Me.Name = "Project_Details"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.Empty
        CType(Me.ProjectDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PD_ContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents ProjectDetailsDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents ProjectDetailsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents PD_ContextMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents NewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesJobOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddendumToolStripMenuItem As ToolStripMenuItem
End Class
