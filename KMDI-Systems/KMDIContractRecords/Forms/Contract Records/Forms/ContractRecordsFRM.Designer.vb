<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContractRecordsFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContractRecordsFRM))
        Me.ListOfViewMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScannedContractsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsAdditionalInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FrameSashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GlassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallationMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContractRecordsDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.ContractRecordsLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.ListOfViewMenuStrip.SuspendLayout()
        CType(Me.ContractRecordsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListOfViewMenuStrip
        '
        Me.ListOfViewMenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ListOfViewMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.SearchToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ReloadToolStripMenuItem, Me.ToolStripSeparator1, Me.UpdateInfoToolStripMenuItem, Me.BackloadToolStripMenuItem})
        Me.ListOfViewMenuStrip.Name = "ContextMenuStrip1"
        Me.ListOfViewMenuStrip.Size = New System.Drawing.Size(183, 142)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContractsToolStripMenuItem, Me.ContractItemsToolStripMenuItem, Me.ScannedContractsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ContractsToolStripMenuItem
        '
        Me.ContractsToolStripMenuItem.Name = "ContractsToolStripMenuItem"
        Me.ContractsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ContractsToolStripMenuItem.Text = "Contracts"
        '
        'ContractItemsToolStripMenuItem
        '
        Me.ContractItemsToolStripMenuItem.Name = "ContractItemsToolStripMenuItem"
        Me.ContractItemsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ContractItemsToolStripMenuItem.Text = "Contract Items"
        '
        'ScannedContractsToolStripMenuItem
        '
        Me.ScannedContractsToolStripMenuItem.Name = "ScannedContractsToolStripMenuItem"
        Me.ScannedContractsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ScannedContractsToolStripMenuItem.Text = "Scanned Contracts"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SearchToolStripMenuItem.Text = "Search (Ctrl+F or F2)"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh (F5)"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload (F5)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'UpdateInfoToolStripMenuItem
        '
        Me.UpdateInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddressToolStripMenuItem, Me.ClientsAdditionalInfoToolStripMenuItem, Me.OwnerToolStripMenuItem})
        Me.UpdateInfoToolStripMenuItem.Name = "UpdateInfoToolStripMenuItem"
        Me.UpdateInfoToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UpdateInfoToolStripMenuItem.Text = "Update Info"
        '
        'AddressToolStripMenuItem
        '
        Me.AddressToolStripMenuItem.Name = "AddressToolStripMenuItem"
        Me.AddressToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AddressToolStripMenuItem.Text = "Address"
        '
        'ClientsAdditionalInfoToolStripMenuItem
        '
        Me.ClientsAdditionalInfoToolStripMenuItem.Name = "ClientsAdditionalInfoToolStripMenuItem"
        Me.ClientsAdditionalInfoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ClientsAdditionalInfoToolStripMenuItem.Text = "Client's Additional Info"
        '
        'OwnerToolStripMenuItem
        '
        Me.OwnerToolStripMenuItem.Name = "OwnerToolStripMenuItem"
        Me.OwnerToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.OwnerToolStripMenuItem.Text = "Ownership"
        '
        'BackloadToolStripMenuItem
        '
        Me.BackloadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FrameSashToolStripMenuItem, Me.GlassToolStripMenuItem, Me.ScreenToolStripMenuItem, Me.InstallationMaterialToolStripMenuItem})
        Me.BackloadToolStripMenuItem.Name = "BackloadToolStripMenuItem"
        Me.BackloadToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.BackloadToolStripMenuItem.Text = "Backload"
        '
        'FrameSashToolStripMenuItem
        '
        Me.FrameSashToolStripMenuItem.Name = "FrameSashToolStripMenuItem"
        Me.FrameSashToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.FrameSashToolStripMenuItem.Text = "Frame / Sash"
        '
        'GlassToolStripMenuItem
        '
        Me.GlassToolStripMenuItem.Name = "GlassToolStripMenuItem"
        Me.GlassToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.GlassToolStripMenuItem.Text = "Glass"
        '
        'ScreenToolStripMenuItem
        '
        Me.ScreenToolStripMenuItem.Name = "ScreenToolStripMenuItem"
        Me.ScreenToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ScreenToolStripMenuItem.Text = "Screen"
        '
        'InstallationMaterialToolStripMenuItem
        '
        Me.InstallationMaterialToolStripMenuItem.Name = "InstallationMaterialToolStripMenuItem"
        Me.InstallationMaterialToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.InstallationMaterialToolStripMenuItem.Text = "Installation Material"
        '
        'ContractRecordsDGV
        '
        Me.ContractRecordsDGV.AllowUserToAddRows = False
        Me.ContractRecordsDGV.AllowUserToDeleteRows = False
        Me.ContractRecordsDGV.AllowUserToOrderColumns = True
        Me.ContractRecordsDGV.AllowUserToResizeRows = False
        Me.ContractRecordsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ContractRecordsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ContractRecordsDGV.ColumnHeadersHeight = 30
        Me.ContractRecordsDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ContractRecordsDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContractRecordsDGV.Location = New System.Drawing.Point(20, 60)
        Me.ContractRecordsDGV.Name = "ContractRecordsDGV"
        Me.ContractRecordsDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.ContractRecordsDGV.ReadOnly = True
        Me.ContractRecordsDGV.RowHeadersWidth = 30
        Me.ContractRecordsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ContractRecordsDGV.Size = New System.Drawing.Size(1160, 625)
        Me.ContractRecordsDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.ContractRecordsDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.ContractRecordsDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.ContractRecordsDGV.StateCommon.DataCell.Border.Width = 0
        Me.ContractRecordsDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContractRecordsDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.ContractRecordsDGV.TabIndex = 1
        Me.ContractRecordsDGV.VirtualMode = True
        '
        'ContractRecordsLBL
        '
        Me.ContractRecordsLBL.AutoSize = True
        Me.ContractRecordsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.ContractRecordsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.ContractRecordsLBL.Location = New System.Drawing.Point(20, 32)
        Me.ContractRecordsLBL.Name = "ContractRecordsLBL"
        Me.ContractRecordsLBL.Size = New System.Drawing.Size(159, 25)
        Me.ContractRecordsLBL.TabIndex = 0
        Me.ContractRecordsLBL.Text = "C O N T R A C T S"
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(1115, 29)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 3
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'ContractRecordsFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 705)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.ContractRecordsLBL)
        Me.Controls.Add(Me.ContractRecordsDGV)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ContractRecordsFRM"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.ListOfViewMenuStrip.ResumeLayout(False)
        CType(Me.ContractRecordsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListOfViewMenuStrip As ContextMenuStrip
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents ContractRecordsDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents BackloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContractRecordsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents FrameSashToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GlassToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallationMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsAdditionalInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OwnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScannedContractsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContractsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContractItemsToolStripMenuItem As ToolStripMenuItem
End Class
