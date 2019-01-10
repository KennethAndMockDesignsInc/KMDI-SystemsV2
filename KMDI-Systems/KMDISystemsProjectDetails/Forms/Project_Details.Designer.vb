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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Project_Details))
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.ProjectDetailsLBL = New MetroFramework.Controls.MetroLabel()
        Me.PD_ContextMenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesJobOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddendumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectDetailsDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PD_ContextMenu.SuspendLayout()
        CType(Me.ProjectDetailsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ProjectDetailsDGV
        '
        Me.ProjectDetailsDGV.AllowUserToAddRows = False
        Me.ProjectDetailsDGV.AllowUserToDeleteRows = False
        Me.ProjectDetailsDGV.AllowUserToOrderColumns = True
        Me.ProjectDetailsDGV.AllowUserToResizeRows = False
        Me.ProjectDetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ProjectDetailsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ProjectDetailsDGV.ColumnHeadersHeight = 30
        Me.ProjectDetailsDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProjectDetailsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectDetailsDGV.Location = New System.Drawing.Point(20, 60)
        Me.ProjectDetailsDGV.MultiSelect = False
        Me.ProjectDetailsDGV.Name = "ProjectDetailsDGV"
        Me.ProjectDetailsDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.ProjectDetailsDGV.ReadOnly = True
        Me.ProjectDetailsDGV.RowHeadersWidth = 30
        Me.ProjectDetailsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProjectDetailsDGV.Size = New System.Drawing.Size(984, 620)
        Me.ProjectDetailsDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.ProjectDetailsDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.ProjectDetailsDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.ProjectDetailsDGV.StateCommon.DataCell.Border.Width = 0
        Me.ProjectDetailsDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectDetailsDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.ProjectDetailsDGV.TabIndex = 609
        Me.ProjectDetailsDGV.VirtualMode = True
        '
        'Project_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.ProjectDetailsDGV)
        Me.Controls.Add(Me.ProjectDetailsLBL)
        Me.Controls.Add(Me.LoadingPB)
        Me.IsMdiContainer = True
        Me.Name = "Project_Details"
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.Empty
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PD_ContextMenu.ResumeLayout(False)
        CType(Me.ProjectDetailsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents ProjectDetailsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents PD_ContextMenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents NewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesJobOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddendumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjectDetailsDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
