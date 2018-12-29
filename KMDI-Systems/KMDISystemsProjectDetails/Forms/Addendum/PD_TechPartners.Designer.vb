<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PD_TechPartners
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PD_TechPartners))
        Me.TP_TabControl = New MetroFramework.Controls.MetroTabControl()
        Me.TP_Tab = New MetroFramework.Controls.MetroTabPage()
        Me.Position_Cbox = New System.Windows.Forms.ComboBox()
        Me.Nature_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.Search_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Operation_BTN = New MetroFramework.Controls.MetroButton()
        Me.Emp_DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Comp_DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TechPartners_DGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.OFFICENAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadingPbox = New System.Windows.Forms.PictureBox()
        Me.EMPNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TP_TabControl.SuspendLayout()
        Me.TP_Tab.SuspendLayout()
        CType(Me.Emp_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comp_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechPartners_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Cmenu.SuspendLayout()
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TP_TabControl
        '
        Me.TP_TabControl.Controls.Add(Me.TP_Tab)
        Me.TP_TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TP_TabControl.Location = New System.Drawing.Point(20, 60)
        Me.TP_TabControl.Name = "TP_TabControl"
        Me.TP_TabControl.SelectedIndex = 0
        Me.TP_TabControl.Size = New System.Drawing.Size(664, 482)
        Me.TP_TabControl.TabIndex = 828
        Me.TP_TabControl.UseSelectable = True
        '
        'TP_Tab
        '
        Me.TP_Tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TP_Tab.Controls.Add(Me.Position_Cbox)
        Me.TP_Tab.Controls.Add(Me.Nature_Cbox)
        Me.TP_Tab.Controls.Add(Me.Search_Tbox)
        Me.TP_Tab.Controls.Add(Me.Operation_BTN)
        Me.TP_Tab.Controls.Add(Me.Emp_DGV)
        Me.TP_Tab.Controls.Add(Me.Comp_DGV)
        Me.TP_Tab.Controls.Add(Me.TechPartners_DGV)
        Me.TP_Tab.HorizontalScrollbarBarColor = True
        Me.TP_Tab.HorizontalScrollbarHighlightOnWheel = False
        Me.TP_Tab.HorizontalScrollbarSize = 10
        Me.TP_Tab.Location = New System.Drawing.Point(4, 38)
        Me.TP_Tab.Name = "TP_Tab"
        Me.TP_Tab.Padding = New System.Windows.Forms.Padding(20)
        Me.TP_Tab.Size = New System.Drawing.Size(656, 440)
        Me.TP_Tab.TabIndex = 0
        Me.TP_Tab.Text = "                                                                                 " &
    "                                                                                " &
    ""
        Me.TP_Tab.VerticalScrollbarBarColor = True
        Me.TP_Tab.VerticalScrollbarHighlightOnWheel = False
        Me.TP_Tab.VerticalScrollbarSize = 10
        '
        'Position_Cbox
        '
        Me.Position_Cbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Position_Cbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Position_Cbox.BackColor = System.Drawing.SystemColors.Window
        Me.Position_Cbox.DropDownHeight = 75
        Me.Position_Cbox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Position_Cbox.ForeColor = System.Drawing.Color.Black
        Me.Position_Cbox.FormattingEnabled = True
        Me.Position_Cbox.IntegralHeight = False
        Me.Position_Cbox.Location = New System.Drawing.Point(342, 12)
        Me.Position_Cbox.Name = "Position_Cbox"
        Me.Position_Cbox.Size = New System.Drawing.Size(289, 29)
        Me.Position_Cbox.TabIndex = 2
        '
        'Nature_Cbox
        '
        Me.Nature_Cbox.FormattingEnabled = True
        Me.Nature_Cbox.ItemHeight = 23
        Me.Nature_Cbox.Items.AddRange(New Object() {"Architectural Design", "Interior Design", "Construction Management", "General Contractor"})
        Me.Nature_Cbox.Location = New System.Drawing.Point(23, 12)
        Me.Nature_Cbox.Name = "Nature_Cbox"
        Me.Nature_Cbox.Size = New System.Drawing.Size(289, 29)
        Me.Nature_Cbox.TabIndex = 1
        Me.Nature_Cbox.UseSelectable = True
        '
        'Search_Tbox
        '
        Me.Search_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.Search_Tbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Tbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Search_Tbox.CustomButton.Location = New System.Drawing.Point(261, 2)
        Me.Search_Tbox.CustomButton.Name = ""
        Me.Search_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Search_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Search_Tbox.CustomButton.TabIndex = 1
        Me.Search_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Search_Tbox.CustomButton.UseSelectable = True
        Me.Search_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Search_Tbox.ForeColor = System.Drawing.Color.Black
        Me.Search_Tbox.Lines = New String(-1) {}
        Me.Search_Tbox.Location = New System.Drawing.Point(23, 47)
        Me.Search_Tbox.MaxLength = 32767
        Me.Search_Tbox.Name = "Search_Tbox"
        Me.Search_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Search_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Search_Tbox.SelectedText = ""
        Me.Search_Tbox.SelectionLength = 0
        Me.Search_Tbox.SelectionStart = 0
        Me.Search_Tbox.ShowButton = True
        Me.Search_Tbox.ShowClearButton = True
        Me.Search_Tbox.Size = New System.Drawing.Size(289, 30)
        Me.Search_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Search_Tbox.TabIndex = 3
        Me.Search_Tbox.UseCustomForeColor = True
        Me.Search_Tbox.UseSelectable = True
        Me.Search_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Search_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Operation_BTN
        '
        Me.Operation_BTN.Location = New System.Drawing.Point(554, 47)
        Me.Operation_BTN.Name = "Operation_BTN"
        Me.Operation_BTN.Size = New System.Drawing.Size(77, 30)
        Me.Operation_BTN.TabIndex = 4
        Me.Operation_BTN.Text = "ADD"
        Me.Operation_BTN.UseSelectable = True
        '
        'Emp_DGV
        '
        Me.Emp_DGV.AllowUserToAddRows = False
        Me.Emp_DGV.AllowUserToDeleteRows = False
        Me.Emp_DGV.AllowUserToOrderColumns = True
        Me.Emp_DGV.AllowUserToResizeRows = False
        Me.Emp_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Emp_DGV.ColumnHeadersHeight = 30
        Me.Emp_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EMPNAME})
        Me.Emp_DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Emp_DGV.Location = New System.Drawing.Point(23, 83)
        Me.Emp_DGV.MultiSelect = False
        Me.Emp_DGV.Name = "Emp_DGV"
        Me.Emp_DGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.Emp_DGV.ReadOnly = True
        Me.Emp_DGV.RowHeadersWidth = 30
        Me.Emp_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Emp_DGV.Size = New System.Drawing.Size(289, 160)
        Me.Emp_DGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.Emp_DGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.Emp_DGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.Emp_DGV.StateCommon.DataCell.Border.Width = 0
        Me.Emp_DGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_DGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Emp_DGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Emp_DGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.Emp_DGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.Emp_DGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.Emp_DGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.Emp_DGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_DGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.Emp_DGV.TabIndex = 832
        Me.Emp_DGV.VirtualMode = True
        '
        'Comp_DGV
        '
        Me.Comp_DGV.AllowUserToAddRows = False
        Me.Comp_DGV.AllowUserToDeleteRows = False
        Me.Comp_DGV.AllowUserToOrderColumns = True
        Me.Comp_DGV.AllowUserToResizeRows = False
        Me.Comp_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Comp_DGV.ColumnHeadersHeight = 30
        Me.Comp_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.Comp_DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Comp_DGV.Location = New System.Drawing.Point(342, 83)
        Me.Comp_DGV.MultiSelect = False
        Me.Comp_DGV.Name = "Comp_DGV"
        Me.Comp_DGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.Comp_DGV.ReadOnly = True
        Me.Comp_DGV.RowHeadersWidth = 30
        Me.Comp_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Comp_DGV.Size = New System.Drawing.Size(289, 160)
        Me.Comp_DGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.Comp_DGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.Comp_DGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.Comp_DGV.StateCommon.DataCell.Border.Width = 0
        Me.Comp_DGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_DGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Comp_DGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Comp_DGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.Comp_DGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.Comp_DGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.Comp_DGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.Comp_DGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_DGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.Comp_DGV.TabIndex = 833
        Me.Comp_DGV.VirtualMode = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "OFFICENAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TechPartners_DGV
        '
        Me.TechPartners_DGV.AllowUserToAddRows = False
        Me.TechPartners_DGV.AllowUserToDeleteRows = False
        Me.TechPartners_DGV.AllowUserToOrderColumns = True
        Me.TechPartners_DGV.AllowUserToResizeRows = False
        Me.TechPartners_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.TechPartners_DGV.ColumnHeadersHeight = 30
        Me.TechPartners_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OFFICENAME, Me.Column1, Me.Column8, Me.Column9})
        Me.TechPartners_DGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TechPartners_DGV.Location = New System.Drawing.Point(23, 249)
        Me.TechPartners_DGV.MultiSelect = False
        Me.TechPartners_DGV.Name = "TechPartners_DGV"
        Me.TechPartners_DGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.TechPartners_DGV.ReadOnly = True
        Me.TechPartners_DGV.RowHeadersWidth = 30
        Me.TechPartners_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TechPartners_DGV.Size = New System.Drawing.Size(608, 166)
        Me.TechPartners_DGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.TechPartners_DGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.TechPartners_DGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.TechPartners_DGV.StateCommon.DataCell.Border.Width = 0
        Me.TechPartners_DGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechPartners_DGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.TechPartners_DGV.TabIndex = 834
        Me.TechPartners_DGV.VirtualMode = True
        '
        'OFFICENAME
        '
        Me.OFFICENAME.HeaderText = "OFFICENAME"
        Me.OFFICENAME.Name = "OFFICENAME"
        Me.OFFICENAME.ReadOnly = True
        Me.OFFICENAME.Width = 132
        '
        'Column1
        '
        Me.Column1.HeaderText = "NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 83
        '
        'Column8
        '
        Me.Column8.HeaderText = "POSITION"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 108
        '
        'Column9
        '
        Me.Column9.HeaderText = "CONTACT NUMBER"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 176
        '
        'TP_Cmenu
        '
        Me.TP_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TP_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.TP_Cmenu.Name = "TP_Cmenu"
        Me.TP_Cmenu.Size = New System.Drawing.Size(113, 70)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.UpdateToolStripMenuItem.Text = "Up&date"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DeleteToolStripMenuItem.Text = "D&elete"
        '
        'LoadingPbox
        '
        Me.LoadingPbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPbox.BackColor = System.Drawing.Color.Transparent
        Me.LoadingPbox.Image = Global.KMDI_Systems.My.Resources.Resources.loading_page
        Me.LoadingPbox.Location = New System.Drawing.Point(619, 63)
        Me.LoadingPbox.Name = "LoadingPbox"
        Me.LoadingPbox.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPbox.TabIndex = 17
        Me.LoadingPbox.TabStop = False
        Me.LoadingPbox.Visible = False
        '
        'EMPNAME
        '
        Me.EMPNAME.HeaderText = "NAME"
        Me.EMPNAME.Name = "EMPNAME"
        Me.EMPNAME.ReadOnly = True
        '
        'PD_TechPartners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 562)
        Me.Controls.Add(Me.LoadingPbox)
        Me.Controls.Add(Me.TP_TabControl)
        Me.MaximizeBox = False
        Me.Name = "PD_TechPartners"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Technical Partners"
        Me.TP_TabControl.ResumeLayout(False)
        Me.TP_Tab.ResumeLayout(False)
        CType(Me.Emp_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechPartners_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Cmenu.ResumeLayout(False)
        CType(Me.LoadingPbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadingPbox As PictureBox
    Friend WithEvents TP_TabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TP_Tab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Nature_Cbox As MetroFramework.Controls.MetroComboBox
    Public WithEvents Search_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Position_Cbox As ComboBox
    Friend WithEvents Operation_BTN As MetroFramework.Controls.MetroButton
    Friend WithEvents TP_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Emp_DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Comp_DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TechPartners_DGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents OFFICENAME As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents EMPNAME As DataGridViewTextBoxColumn
End Class
