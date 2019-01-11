<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MKTNG_Inventory
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MKTNG_Inventory))
        Me.ProjectDetailsLBL = New MetroFramework.Controls.MetroLabel()
        Me.MktngInventoryDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.MktngInv_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        CType(Me.MktngInventoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MktngInv_Cmenu.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDetailsLBL
        '
        Me.ProjectDetailsLBL.AutoSize = True
        Me.ProjectDetailsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ProjectDetailsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ProjectDetailsLBL.Location = New System.Drawing.Point(15, 24)
        Me.ProjectDetailsLBL.Name = "ProjectDetailsLBL"
        Me.ProjectDetailsLBL.Size = New System.Drawing.Size(156, 25)
        Me.ProjectDetailsLBL.TabIndex = 608
        Me.ProjectDetailsLBL.Text = "I N V E N T O R Y"
        '
        'MktngInventoryDGV
        '
        Me.MktngInventoryDGV.AllowUserToAddRows = False
        Me.MktngInventoryDGV.AllowUserToDeleteRows = False
        Me.MktngInventoryDGV.AllowUserToOrderColumns = True
        Me.MktngInventoryDGV.AllowUserToResizeRows = False
        Me.MktngInventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MktngInventoryDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MktngInventoryDGV.ColumnHeadersHeight = 30
        Me.MktngInventoryDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MktngInventoryDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MktngInventoryDGV.Location = New System.Drawing.Point(21, 60)
        Me.MktngInventoryDGV.MultiSelect = False
        Me.MktngInventoryDGV.Name = "MktngInventoryDGV"
        Me.MktngInventoryDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.MktngInventoryDGV.ReadOnly = True
        Me.MktngInventoryDGV.RowHeadersWidth = 30
        Me.MktngInventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MktngInventoryDGV.Size = New System.Drawing.Size(982, 620)
        Me.MktngInventoryDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.MktngInventoryDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.MktngInventoryDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.MktngInventoryDGV.StateCommon.DataCell.Border.Width = 0
        Me.MktngInventoryDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MktngInventoryDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.MktngInventoryDGV.TabIndex = 610
        Me.MktngInventoryDGV.VirtualMode = True
        '
        'MktngInv_Cmenu
        '
        Me.MktngInv_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MktngInv_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColumnToolStripMenuItem})
        Me.MktngInv_Cmenu.Name = "MktngInv_Cmenu"
        Me.MktngInv_Cmenu.Size = New System.Drawing.Size(123, 26)
        '
        'ColumnToolStripMenuItem
        '
        Me.ColumnToolStripMenuItem.Name = "ColumnToolStripMenuItem"
        Me.ColumnToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ColumnToolStripMenuItem.Text = "Columns"
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(939, 29)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 611
        Me.LoadingPB.TabStop = False
        '
        'MKTNG_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.MktngInventoryDGV)
        Me.Controls.Add(Me.ProjectDetailsLBL)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "MKTNG_Inventory"
        Me.Padding = New System.Windows.Forms.Padding(21, 60, 21, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MktngInventoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MktngInv_Cmenu.ResumeLayout(False)
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectDetailsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents MktngInventoryDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents MktngInv_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ColumnToolStripMenuItem As ToolStripMenuItem
End Class
