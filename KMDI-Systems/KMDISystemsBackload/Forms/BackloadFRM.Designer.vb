<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackloadFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackloadFRM))
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.BackloadsAtHandDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.BackloadsLBL = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ItemTypeTAB = New MetroFramework.Controls.MetroTabControl()
        Me.ItemTypeFrameSashTAB = New MetroFramework.Controls.MetroTabPage()
        Me.ScreenTAB = New MetroFramework.Controls.MetroTabPage()
        Me.GlassTAB = New MetroFramework.Controls.MetroTabPage()
        Me.InstallationMaterialTAB = New MetroFramework.Controls.MetroTabPage()
        Me.StatusTAB = New MetroFramework.Controls.MetroTabControl()
        Me.BackloadsAtHandTAB = New MetroFramework.Controls.MetroTabPage()
        Me.PendingRequestTAB = New MetroFramework.Controls.MetroTabPage()
        Me.BackloadsCMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackloadsAtHandDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ItemTypeTAB.SuspendLayout()
        Me.StatusTAB.SuspendLayout()
        Me.BackloadsCMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(1115, 39)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 5
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'BackloadsAtHandDGV
        '
        Me.BackloadsAtHandDGV.AllowUserToAddRows = False
        Me.BackloadsAtHandDGV.AllowUserToDeleteRows = False
        Me.BackloadsAtHandDGV.AllowUserToOrderColumns = True
        Me.BackloadsAtHandDGV.AllowUserToResizeRows = False
        Me.BackloadsAtHandDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.BackloadsAtHandDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.BackloadsAtHandDGV.ColumnHeadersHeight = 30
        Me.BackloadsAtHandDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackloadsAtHandDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackloadsAtHandDGV.Location = New System.Drawing.Point(40, 80)
        Me.BackloadsAtHandDGV.Name = "BackloadsAtHandDGV"
        Me.BackloadsAtHandDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.BackloadsAtHandDGV.ReadOnly = True
        Me.BackloadsAtHandDGV.RowHeadersWidth = 30
        Me.BackloadsAtHandDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BackloadsAtHandDGV.Size = New System.Drawing.Size(1114, 533)
        Me.BackloadsAtHandDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.BackloadsAtHandDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.BackloadsAtHandDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BackloadsAtHandDGV.StateCommon.DataCell.Border.Width = 0
        Me.BackloadsAtHandDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackloadsAtHandDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.BackloadsAtHandDGV.TabIndex = 604
        Me.BackloadsAtHandDGV.TabStop = False
        '
        'BackloadsLBL
        '
        Me.BackloadsLBL.AutoSize = True
        Me.BackloadsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.BackloadsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.BackloadsLBL.Location = New System.Drawing.Point(23, 42)
        Me.BackloadsLBL.Name = "BackloadsLBL"
        Me.BackloadsLBL.Size = New System.Drawing.Size(159, 25)
        Me.BackloadsLBL.TabIndex = 605
        Me.BackloadsLBL.Text = "B A C K L O A D S"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackloadsAtHandDGV)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(23, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 613)
        Me.Panel1.TabIndex = 606
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(40, 533)
        Me.Panel2.TabIndex = 607
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ItemTypeTAB)
        Me.Panel3.Controls.Add(Me.StatusTAB)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1154, 80)
        Me.Panel3.TabIndex = 608
        '
        'ItemTypeTAB
        '
        Me.ItemTypeTAB.Controls.Add(Me.ItemTypeFrameSashTAB)
        Me.ItemTypeTAB.Controls.Add(Me.ScreenTAB)
        Me.ItemTypeTAB.Controls.Add(Me.GlassTAB)
        Me.ItemTypeTAB.Controls.Add(Me.InstallationMaterialTAB)
        Me.ItemTypeTAB.Location = New System.Drawing.Point(40, 41)
        Me.ItemTypeTAB.Name = "ItemTypeTAB"
        Me.ItemTypeTAB.SelectedIndex = 0
        Me.ItemTypeTAB.Size = New System.Drawing.Size(334, 77)
        Me.ItemTypeTAB.TabIndex = 606
        Me.ItemTypeTAB.UseSelectable = True
        '
        'ItemTypeFrameSashTAB
        '
        Me.ItemTypeFrameSashTAB.HorizontalScrollbarBarColor = True
        Me.ItemTypeFrameSashTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.ItemTypeFrameSashTAB.HorizontalScrollbarSize = 3
        Me.ItemTypeFrameSashTAB.Location = New System.Drawing.Point(4, 38)
        Me.ItemTypeFrameSashTAB.Name = "ItemTypeFrameSashTAB"
        Me.ItemTypeFrameSashTAB.Size = New System.Drawing.Size(326, 35)
        Me.ItemTypeFrameSashTAB.TabIndex = 0
        Me.ItemTypeFrameSashTAB.Text = "Frame / Sash"
        Me.ItemTypeFrameSashTAB.VerticalScrollbarBarColor = True
        Me.ItemTypeFrameSashTAB.VerticalScrollbarHighlightOnWheel = False
        Me.ItemTypeFrameSashTAB.VerticalScrollbarSize = 3
        '
        'ScreenTAB
        '
        Me.ScreenTAB.HorizontalScrollbarBarColor = True
        Me.ScreenTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.ScreenTAB.HorizontalScrollbarSize = 3
        Me.ScreenTAB.Location = New System.Drawing.Point(4, 38)
        Me.ScreenTAB.Name = "ScreenTAB"
        Me.ScreenTAB.Size = New System.Drawing.Size(326, 35)
        Me.ScreenTAB.TabIndex = 1
        Me.ScreenTAB.Text = "Screen"
        Me.ScreenTAB.VerticalScrollbarBarColor = True
        Me.ScreenTAB.VerticalScrollbarHighlightOnWheel = False
        Me.ScreenTAB.VerticalScrollbarSize = 3
        '
        'GlassTAB
        '
        Me.GlassTAB.HorizontalScrollbarBarColor = True
        Me.GlassTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.GlassTAB.HorizontalScrollbarSize = 3
        Me.GlassTAB.Location = New System.Drawing.Point(4, 38)
        Me.GlassTAB.Name = "GlassTAB"
        Me.GlassTAB.Size = New System.Drawing.Size(326, 35)
        Me.GlassTAB.TabIndex = 2
        Me.GlassTAB.Text = "Glass"
        Me.GlassTAB.VerticalScrollbarBarColor = True
        Me.GlassTAB.VerticalScrollbarHighlightOnWheel = False
        Me.GlassTAB.VerticalScrollbarSize = 3
        '
        'InstallationMaterialTAB
        '
        Me.InstallationMaterialTAB.HorizontalScrollbarBarColor = True
        Me.InstallationMaterialTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.InstallationMaterialTAB.HorizontalScrollbarSize = 3
        Me.InstallationMaterialTAB.Location = New System.Drawing.Point(4, 38)
        Me.InstallationMaterialTAB.Name = "InstallationMaterialTAB"
        Me.InstallationMaterialTAB.Size = New System.Drawing.Size(326, 35)
        Me.InstallationMaterialTAB.TabIndex = 3
        Me.InstallationMaterialTAB.Text = "Installation Materials"
        Me.InstallationMaterialTAB.VerticalScrollbarBarColor = True
        Me.InstallationMaterialTAB.VerticalScrollbarHighlightOnWheel = False
        Me.InstallationMaterialTAB.VerticalScrollbarSize = 3
        '
        'StatusTAB
        '
        Me.StatusTAB.Controls.Add(Me.BackloadsAtHandTAB)
        Me.StatusTAB.Controls.Add(Me.PendingRequestTAB)
        Me.StatusTAB.Location = New System.Drawing.Point(3, 3)
        Me.StatusTAB.Name = "StatusTAB"
        Me.StatusTAB.SelectedIndex = 0
        Me.StatusTAB.Size = New System.Drawing.Size(319, 100)
        Me.StatusTAB.TabIndex = 605
        Me.StatusTAB.TabStop = False
        Me.StatusTAB.UseSelectable = True
        '
        'BackloadsAtHandTAB
        '
        Me.BackloadsAtHandTAB.HorizontalScrollbarBarColor = True
        Me.BackloadsAtHandTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.BackloadsAtHandTAB.HorizontalScrollbarSize = 3
        Me.BackloadsAtHandTAB.Location = New System.Drawing.Point(4, 38)
        Me.BackloadsAtHandTAB.Name = "BackloadsAtHandTAB"
        Me.BackloadsAtHandTAB.Size = New System.Drawing.Size(311, 58)
        Me.BackloadsAtHandTAB.TabIndex = 0
        Me.BackloadsAtHandTAB.Text = "Backloads at Hand"
        Me.BackloadsAtHandTAB.VerticalScrollbarBarColor = True
        Me.BackloadsAtHandTAB.VerticalScrollbarHighlightOnWheel = False
        Me.BackloadsAtHandTAB.VerticalScrollbarSize = 3
        '
        'PendingRequestTAB
        '
        Me.PendingRequestTAB.HorizontalScrollbarBarColor = True
        Me.PendingRequestTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.PendingRequestTAB.HorizontalScrollbarSize = 3
        Me.PendingRequestTAB.Location = New System.Drawing.Point(4, 38)
        Me.PendingRequestTAB.Name = "PendingRequestTAB"
        Me.PendingRequestTAB.Size = New System.Drawing.Size(311, 58)
        Me.PendingRequestTAB.TabIndex = 1
        Me.PendingRequestTAB.Text = "Pending Request for Backloads"
        Me.PendingRequestTAB.VerticalScrollbarBarColor = True
        Me.PendingRequestTAB.VerticalScrollbarHighlightOnWheel = False
        Me.PendingRequestTAB.VerticalScrollbarSize = 3
        '
        'BackloadsCMS
        '
        Me.BackloadsCMS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BackloadsCMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ImageToolStripMenuItem})
        Me.BackloadsCMS.Name = "BackloadsCMS"
        Me.BackloadsCMS.Size = New System.Drawing.Size(153, 92)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImageToolStripMenuItem.Text = "Image"
        '
        'BackloadFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 705)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.BackloadsLBL)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "BackloadFRM"
        Me.Padding = New System.Windows.Forms.Padding(23, 69, 23, 23)
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackloadsAtHandDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ItemTypeTAB.ResumeLayout(False)
        Me.StatusTAB.ResumeLayout(False)
        Me.BackloadsCMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents BackloadsAtHandDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents BackloadsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ItemTypeTAB As MetroFramework.Controls.MetroTabControl
    Friend WithEvents ItemTypeFrameSashTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ScreenTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GlassTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents InstallationMaterialTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents StatusTAB As MetroFramework.Controls.MetroTabControl
    Friend WithEvents BackloadsAtHandTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PendingRequestTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents BackloadsCMS As ContextMenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
End Class
