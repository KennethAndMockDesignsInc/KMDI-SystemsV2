<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackloadRequestFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackloadRequestFRM))
        Me.SelectItemForBackloadDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OtherDetailsTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.OtherDetailsLBL = New MetroFramework.Controls.MetroLabel()
        Me.ReasonLBL = New MetroFramework.Controls.MetroLabel()
        Me.OthersCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.SafeKeepingCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.SpareCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.ReplacementCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.RecutCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.InstallationMaterialBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.GlassBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.RequestedItemsDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.FrameScreenBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.FrameScreenToTheRightPBOX = New System.Windows.Forms.PictureBox()
        Me.GlassToTheRightPBOX = New System.Windows.Forms.PictureBox()
        Me.InstallationMaterialToTheRightPBOX = New System.Windows.Forms.PictureBox()
        Me.FrameScreenToTheLeftPBOX = New System.Windows.Forms.PictureBox()
        Me.GlassToTheLeftPBOX = New System.Windows.Forms.PictureBox()
        Me.InstallationMaterialToTheLeftPBOX = New System.Windows.Forms.PictureBox()
        Me.ForBackloadTCTRL = New MetroFramework.Controls.MetroTabControl()
        Me.ForBackloadFrameSashTAB = New MetroFramework.Controls.MetroTabPage()
        Me.ForBackloadScreenTCTRL = New MetroFramework.Controls.MetroTabPage()
        Me.RequestForBackloadTCTRL = New MetroFramework.Controls.MetroTabControl()
        Me.RequestForBackloadFrameSashTAB = New MetroFramework.Controls.MetroTabPage()
        Me.RequestForBackloadScreenTCTRL = New MetroFramework.Controls.MetroTabPage()
        Me.TitleLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SelectItemForBackloadDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RequestedItemsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameScreenToTheRightPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlassToTheRightPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallationMaterialToTheRightPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameScreenToTheLeftPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GlassToTheLeftPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InstallationMaterialToTheLeftPBOX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ForBackloadTCTRL.SuspendLayout()
        Me.RequestForBackloadTCTRL.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelectItemForBackloadDGV
        '
        Me.SelectItemForBackloadDGV.AllowUserToAddRows = False
        Me.SelectItemForBackloadDGV.AllowUserToDeleteRows = False
        Me.SelectItemForBackloadDGV.AllowUserToOrderColumns = True
        Me.SelectItemForBackloadDGV.AllowUserToResizeRows = False
        Me.SelectItemForBackloadDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.SelectItemForBackloadDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.SelectItemForBackloadDGV.ColumnHeadersHeight = 30
        Me.SelectItemForBackloadDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.SelectItemForBackloadDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectItemForBackloadDGV.Location = New System.Drawing.Point(14, 51)
        Me.SelectItemForBackloadDGV.Name = "SelectItemForBackloadDGV"
        Me.SelectItemForBackloadDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.SelectItemForBackloadDGV.ReadOnly = True
        Me.SelectItemForBackloadDGV.RowHeadersWidth = 30
        Me.SelectItemForBackloadDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SelectItemForBackloadDGV.Size = New System.Drawing.Size(337, 353)
        Me.SelectItemForBackloadDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.SelectItemForBackloadDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.SelectItemForBackloadDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.SelectItemForBackloadDGV.StateCommon.DataCell.Border.Width = 0
        Me.SelectItemForBackloadDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectItemForBackloadDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.SelectItemForBackloadDGV.TabIndex = 604
        Me.SelectItemForBackloadDGV.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OtherDetailsTBOX)
        Me.Panel1.Controls.Add(Me.OtherDetailsLBL)
        Me.Panel1.Controls.Add(Me.ReasonLBL)
        Me.Panel1.Controls.Add(Me.OthersCBX)
        Me.Panel1.Controls.Add(Me.SafeKeepingCBX)
        Me.Panel1.Controls.Add(Me.SpareCBX)
        Me.Panel1.Controls.Add(Me.ReplacementCBX)
        Me.Panel1.Controls.Add(Me.RecutCBX)
        Me.Panel1.Controls.Add(Me.InstallationMaterialBTN)
        Me.Panel1.Controls.Add(Me.GlassBTN)
        Me.Panel1.Controls.Add(Me.RequestedItemsDGV)
        Me.Panel1.Controls.Add(Me.FrameScreenBTN)
        Me.Panel1.Controls.Add(Me.SelectItemForBackloadDGV)
        Me.Panel1.Controls.Add(Me.FrameScreenToTheRightPBOX)
        Me.Panel1.Controls.Add(Me.GlassToTheRightPBOX)
        Me.Panel1.Controls.Add(Me.InstallationMaterialToTheRightPBOX)
        Me.Panel1.Controls.Add(Me.FrameScreenToTheLeftPBOX)
        Me.Panel1.Controls.Add(Me.GlassToTheLeftPBOX)
        Me.Panel1.Controls.Add(Me.InstallationMaterialToTheLeftPBOX)
        Me.Panel1.Controls.Add(Me.ForBackloadTCTRL)
        Me.Panel1.Controls.Add(Me.RequestForBackloadTCTRL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(23, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 561)
        Me.Panel1.TabIndex = 608
        '
        'OtherDetailsTBOX
        '
        '
        '
        '
        Me.OtherDetailsTBOX.CustomButton.Image = Nothing
        Me.OtherDetailsTBOX.CustomButton.Location = New System.Drawing.Point(628, 1)
        Me.OtherDetailsTBOX.CustomButton.Name = ""
        Me.OtherDetailsTBOX.CustomButton.Size = New System.Drawing.Size(117, 117)
        Me.OtherDetailsTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.OtherDetailsTBOX.CustomButton.TabIndex = 1
        Me.OtherDetailsTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.OtherDetailsTBOX.CustomButton.UseSelectable = True
        Me.OtherDetailsTBOX.CustomButton.Visible = False
        Me.OtherDetailsTBOX.Lines = New String(-1) {}
        Me.OtherDetailsTBOX.Location = New System.Drawing.Point(222, 436)
        Me.OtherDetailsTBOX.MaxLength = 32767
        Me.OtherDetailsTBOX.Multiline = True
        Me.OtherDetailsTBOX.Name = "OtherDetailsTBOX"
        Me.OtherDetailsTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OtherDetailsTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OtherDetailsTBOX.SelectedText = ""
        Me.OtherDetailsTBOX.SelectionLength = 0
        Me.OtherDetailsTBOX.SelectionStart = 0
        Me.OtherDetailsTBOX.Size = New System.Drawing.Size(746, 119)
        Me.OtherDetailsTBOX.TabIndex = 622
        Me.OtherDetailsTBOX.UseSelectable = True
        Me.OtherDetailsTBOX.WaterMark = "Input other information here including remarks."
        Me.OtherDetailsTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OtherDetailsTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'OtherDetailsLBL
        '
        Me.OtherDetailsLBL.AutoSize = True
        Me.OtherDetailsLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.OtherDetailsLBL.Location = New System.Drawing.Point(222, 409)
        Me.OtherDetailsLBL.Name = "OtherDetailsLBL"
        Me.OtherDetailsLBL.Size = New System.Drawing.Size(108, 19)
        Me.OtherDetailsLBL.TabIndex = 621
        Me.OtherDetailsLBL.Text = "OTHER DETAILS:"
        '
        'ReasonLBL
        '
        Me.ReasonLBL.AutoSize = True
        Me.ReasonLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ReasonLBL.Location = New System.Drawing.Point(14, 409)
        Me.ReasonLBL.Name = "ReasonLBL"
        Me.ReasonLBL.Size = New System.Drawing.Size(64, 19)
        Me.ReasonLBL.TabIndex = 620
        Me.ReasonLBL.Text = "REASON:"
        '
        'OthersCBX
        '
        Me.OthersCBX.AutoSize = True
        Me.OthersCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.OthersCBX.Location = New System.Drawing.Point(14, 536)
        Me.OthersCBX.Name = "OthersCBX"
        Me.OthersCBX.Size = New System.Drawing.Size(165, 19)
        Me.OthersCBX.TabIndex = 619
        Me.OthersCBX.Text = "Others - Please Specify"
        Me.OthersCBX.UseSelectable = True
        '
        'SafeKeepingCBX
        '
        Me.SafeKeepingCBX.AutoSize = True
        Me.SafeKeepingCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.SafeKeepingCBX.Location = New System.Drawing.Point(14, 511)
        Me.SafeKeepingCBX.Name = "SafeKeepingCBX"
        Me.SafeKeepingCBX.Size = New System.Drawing.Size(103, 19)
        Me.SafeKeepingCBX.TabIndex = 618
        Me.SafeKeepingCBX.Text = "Safe Keeping"
        Me.SafeKeepingCBX.UseSelectable = True
        '
        'SpareCBX
        '
        Me.SpareCBX.AutoSize = True
        Me.SpareCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.SpareCBX.Location = New System.Drawing.Point(14, 486)
        Me.SpareCBX.Name = "SpareCBX"
        Me.SpareCBX.Size = New System.Drawing.Size(59, 19)
        Me.SpareCBX.TabIndex = 617
        Me.SpareCBX.Text = "Spare"
        Me.SpareCBX.UseSelectable = True
        '
        'ReplacementCBX
        '
        Me.ReplacementCBX.AutoSize = True
        Me.ReplacementCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ReplacementCBX.Location = New System.Drawing.Point(14, 461)
        Me.ReplacementCBX.Name = "ReplacementCBX"
        Me.ReplacementCBX.Size = New System.Drawing.Size(103, 19)
        Me.ReplacementCBX.TabIndex = 616
        Me.ReplacementCBX.Text = "Replacement"
        Me.ReplacementCBX.UseSelectable = True
        '
        'RecutCBX
        '
        Me.RecutCBX.AutoSize = True
        Me.RecutCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.RecutCBX.Location = New System.Drawing.Point(14, 436)
        Me.RecutCBX.Name = "RecutCBX"
        Me.RecutCBX.Size = New System.Drawing.Size(59, 19)
        Me.RecutCBX.TabIndex = 615
        Me.RecutCBX.Text = "Recut"
        Me.RecutCBX.UseSelectable = True
        '
        'InstallationMaterialBTN
        '
        Me.InstallationMaterialBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InstallationMaterialBTN.Image = Nothing
        Me.InstallationMaterialBTN.Location = New System.Drawing.Point(397, 171)
        Me.InstallationMaterialBTN.Name = "InstallationMaterialBTN"
        Me.InstallationMaterialBTN.Size = New System.Drawing.Size(152, 30)
        Me.InstallationMaterialBTN.Style = MetroFramework.MetroColorStyle.Green
        Me.InstallationMaterialBTN.TabIndex = 608
        Me.InstallationMaterialBTN.Text = "INSTALLATION MATERIALS"
        Me.InstallationMaterialBTN.UseSelectable = True
        Me.InstallationMaterialBTN.UseVisualStyleBackColor = True
        Me.InstallationMaterialBTN.Visible = False
        '
        'GlassBTN
        '
        Me.GlassBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GlassBTN.Image = Nothing
        Me.GlassBTN.Location = New System.Drawing.Point(397, 226)
        Me.GlassBTN.Name = "GlassBTN"
        Me.GlassBTN.Size = New System.Drawing.Size(152, 30)
        Me.GlassBTN.Style = MetroFramework.MetroColorStyle.Green
        Me.GlassBTN.TabIndex = 607
        Me.GlassBTN.Text = "GLASS"
        Me.GlassBTN.UseSelectable = True
        Me.GlassBTN.UseVisualStyleBackColor = True
        Me.GlassBTN.Visible = False
        '
        'RequestedItemsDGV
        '
        Me.RequestedItemsDGV.AllowUserToAddRows = False
        Me.RequestedItemsDGV.AllowUserToDeleteRows = False
        Me.RequestedItemsDGV.AllowUserToOrderColumns = True
        Me.RequestedItemsDGV.AllowUserToResizeRows = False
        Me.RequestedItemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RequestedItemsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.RequestedItemsDGV.ColumnHeadersHeight = 30
        Me.RequestedItemsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.RequestedItemsDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RequestedItemsDGV.Location = New System.Drawing.Point(599, 51)
        Me.RequestedItemsDGV.Name = "RequestedItemsDGV"
        Me.RequestedItemsDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.RequestedItemsDGV.ReadOnly = True
        Me.RequestedItemsDGV.RowHeadersWidth = 30
        Me.RequestedItemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RequestedItemsDGV.Size = New System.Drawing.Size(337, 353)
        Me.RequestedItemsDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.RequestedItemsDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.RequestedItemsDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.RequestedItemsDGV.StateCommon.DataCell.Border.Width = 0
        Me.RequestedItemsDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestedItemsDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.RequestedItemsDGV.TabIndex = 606
        Me.RequestedItemsDGV.TabStop = False
        '
        'FrameScreenBTN
        '
        Me.FrameScreenBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FrameScreenBTN.Image = Nothing
        Me.FrameScreenBTN.Location = New System.Drawing.Point(397, 121)
        Me.FrameScreenBTN.Name = "FrameScreenBTN"
        Me.FrameScreenBTN.Size = New System.Drawing.Size(152, 30)
        Me.FrameScreenBTN.Style = MetroFramework.MetroColorStyle.Green
        Me.FrameScreenBTN.TabIndex = 605
        Me.FrameScreenBTN.Text = "FRAME / SCREEN"
        Me.FrameScreenBTN.UseSelectable = True
        Me.FrameScreenBTN.UseStyleColors = True
        Me.FrameScreenBTN.UseVisualStyleBackColor = True
        Me.FrameScreenBTN.Visible = False
        '
        'FrameScreenToTheRightPBOX
        '
        Me.FrameScreenToTheRightPBOX.Image = CType(resources.GetObject("FrameScreenToTheRightPBOX.Image"), System.Drawing.Image)
        Me.FrameScreenToTheRightPBOX.Location = New System.Drawing.Point(540, 117)
        Me.FrameScreenToTheRightPBOX.Name = "FrameScreenToTheRightPBOX"
        Me.FrameScreenToTheRightPBOX.Size = New System.Drawing.Size(33, 40)
        Me.FrameScreenToTheRightPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FrameScreenToTheRightPBOX.TabIndex = 609
        Me.FrameScreenToTheRightPBOX.TabStop = False
        Me.FrameScreenToTheRightPBOX.Visible = False
        '
        'GlassToTheRightPBOX
        '
        Me.GlassToTheRightPBOX.Image = CType(resources.GetObject("GlassToTheRightPBOX.Image"), System.Drawing.Image)
        Me.GlassToTheRightPBOX.Location = New System.Drawing.Point(540, 222)
        Me.GlassToTheRightPBOX.Name = "GlassToTheRightPBOX"
        Me.GlassToTheRightPBOX.Size = New System.Drawing.Size(33, 40)
        Me.GlassToTheRightPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GlassToTheRightPBOX.TabIndex = 611
        Me.GlassToTheRightPBOX.TabStop = False
        Me.GlassToTheRightPBOX.Visible = False
        '
        'InstallationMaterialToTheRightPBOX
        '
        Me.InstallationMaterialToTheRightPBOX.Image = CType(resources.GetObject("InstallationMaterialToTheRightPBOX.Image"), System.Drawing.Image)
        Me.InstallationMaterialToTheRightPBOX.Location = New System.Drawing.Point(540, 167)
        Me.InstallationMaterialToTheRightPBOX.Name = "InstallationMaterialToTheRightPBOX"
        Me.InstallationMaterialToTheRightPBOX.Size = New System.Drawing.Size(33, 40)
        Me.InstallationMaterialToTheRightPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InstallationMaterialToTheRightPBOX.TabIndex = 613
        Me.InstallationMaterialToTheRightPBOX.TabStop = False
        Me.InstallationMaterialToTheRightPBOX.Visible = False
        '
        'FrameScreenToTheLeftPBOX
        '
        Me.FrameScreenToTheLeftPBOX.Image = CType(resources.GetObject("FrameScreenToTheLeftPBOX.Image"), System.Drawing.Image)
        Me.FrameScreenToTheLeftPBOX.Location = New System.Drawing.Point(372, 115)
        Me.FrameScreenToTheLeftPBOX.Name = "FrameScreenToTheLeftPBOX"
        Me.FrameScreenToTheLeftPBOX.Size = New System.Drawing.Size(33, 40)
        Me.FrameScreenToTheLeftPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FrameScreenToTheLeftPBOX.TabIndex = 610
        Me.FrameScreenToTheLeftPBOX.TabStop = False
        Me.FrameScreenToTheLeftPBOX.Visible = False
        '
        'GlassToTheLeftPBOX
        '
        Me.GlassToTheLeftPBOX.Image = CType(resources.GetObject("GlassToTheLeftPBOX.Image"), System.Drawing.Image)
        Me.GlassToTheLeftPBOX.Location = New System.Drawing.Point(372, 220)
        Me.GlassToTheLeftPBOX.Name = "GlassToTheLeftPBOX"
        Me.GlassToTheLeftPBOX.Size = New System.Drawing.Size(33, 40)
        Me.GlassToTheLeftPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GlassToTheLeftPBOX.TabIndex = 612
        Me.GlassToTheLeftPBOX.TabStop = False
        Me.GlassToTheLeftPBOX.Visible = False
        '
        'InstallationMaterialToTheLeftPBOX
        '
        Me.InstallationMaterialToTheLeftPBOX.Image = CType(resources.GetObject("InstallationMaterialToTheLeftPBOX.Image"), System.Drawing.Image)
        Me.InstallationMaterialToTheLeftPBOX.Location = New System.Drawing.Point(372, 165)
        Me.InstallationMaterialToTheLeftPBOX.Name = "InstallationMaterialToTheLeftPBOX"
        Me.InstallationMaterialToTheLeftPBOX.Size = New System.Drawing.Size(33, 40)
        Me.InstallationMaterialToTheLeftPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.InstallationMaterialToTheLeftPBOX.TabIndex = 614
        Me.InstallationMaterialToTheLeftPBOX.TabStop = False
        Me.InstallationMaterialToTheLeftPBOX.Visible = False
        '
        'ForBackloadTCTRL
        '
        Me.ForBackloadTCTRL.Controls.Add(Me.ForBackloadFrameSashTAB)
        Me.ForBackloadTCTRL.Controls.Add(Me.ForBackloadScreenTCTRL)
        Me.ForBackloadTCTRL.Location = New System.Drawing.Point(14, 12)
        Me.ForBackloadTCTRL.Name = "ForBackloadTCTRL"
        Me.ForBackloadTCTRL.SelectedIndex = 0
        Me.ForBackloadTCTRL.Size = New System.Drawing.Size(337, 100)
        Me.ForBackloadTCTRL.Style = MetroFramework.MetroColorStyle.Green
        Me.ForBackloadTCTRL.TabIndex = 623
        Me.ForBackloadTCTRL.TabStop = False
        Me.ForBackloadTCTRL.UseSelectable = True
        '
        'ForBackloadFrameSashTAB
        '
        Me.ForBackloadFrameSashTAB.HorizontalScrollbarBarColor = True
        Me.ForBackloadFrameSashTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.ForBackloadFrameSashTAB.HorizontalScrollbarSize = 3
        Me.ForBackloadFrameSashTAB.Location = New System.Drawing.Point(4, 38)
        Me.ForBackloadFrameSashTAB.Name = "ForBackloadFrameSashTAB"
        Me.ForBackloadFrameSashTAB.Size = New System.Drawing.Size(329, 58)
        Me.ForBackloadFrameSashTAB.TabIndex = 0
        Me.ForBackloadFrameSashTAB.Text = "Frame / Sash"
        Me.ForBackloadFrameSashTAB.VerticalScrollbarBarColor = True
        Me.ForBackloadFrameSashTAB.VerticalScrollbarHighlightOnWheel = False
        Me.ForBackloadFrameSashTAB.VerticalScrollbarSize = 3
        '
        'ForBackloadScreenTCTRL
        '
        Me.ForBackloadScreenTCTRL.HorizontalScrollbarBarColor = True
        Me.ForBackloadScreenTCTRL.HorizontalScrollbarHighlightOnWheel = False
        Me.ForBackloadScreenTCTRL.HorizontalScrollbarSize = 3
        Me.ForBackloadScreenTCTRL.Location = New System.Drawing.Point(4, 38)
        Me.ForBackloadScreenTCTRL.Name = "ForBackloadScreenTCTRL"
        Me.ForBackloadScreenTCTRL.Size = New System.Drawing.Size(329, 58)
        Me.ForBackloadScreenTCTRL.TabIndex = 1
        Me.ForBackloadScreenTCTRL.Text = "Screen"
        Me.ForBackloadScreenTCTRL.VerticalScrollbarBarColor = True
        Me.ForBackloadScreenTCTRL.VerticalScrollbarHighlightOnWheel = False
        Me.ForBackloadScreenTCTRL.VerticalScrollbarSize = 3
        '
        'RequestForBackloadTCTRL
        '
        Me.RequestForBackloadTCTRL.Controls.Add(Me.RequestForBackloadFrameSashTAB)
        Me.RequestForBackloadTCTRL.Controls.Add(Me.RequestForBackloadScreenTCTRL)
        Me.RequestForBackloadTCTRL.Location = New System.Drawing.Point(599, 12)
        Me.RequestForBackloadTCTRL.Name = "RequestForBackloadTCTRL"
        Me.RequestForBackloadTCTRL.SelectedIndex = 0
        Me.RequestForBackloadTCTRL.Size = New System.Drawing.Size(337, 100)
        Me.RequestForBackloadTCTRL.Style = MetroFramework.MetroColorStyle.Green
        Me.RequestForBackloadTCTRL.TabIndex = 624
        Me.RequestForBackloadTCTRL.TabStop = False
        Me.RequestForBackloadTCTRL.UseSelectable = True
        '
        'RequestForBackloadFrameSashTAB
        '
        Me.RequestForBackloadFrameSashTAB.HorizontalScrollbarBarColor = True
        Me.RequestForBackloadFrameSashTAB.HorizontalScrollbarHighlightOnWheel = False
        Me.RequestForBackloadFrameSashTAB.HorizontalScrollbarSize = 3
        Me.RequestForBackloadFrameSashTAB.Location = New System.Drawing.Point(4, 38)
        Me.RequestForBackloadFrameSashTAB.Name = "RequestForBackloadFrameSashTAB"
        Me.RequestForBackloadFrameSashTAB.Size = New System.Drawing.Size(329, 58)
        Me.RequestForBackloadFrameSashTAB.TabIndex = 0
        Me.RequestForBackloadFrameSashTAB.Text = "Frame / Sash"
        Me.RequestForBackloadFrameSashTAB.VerticalScrollbarBarColor = True
        Me.RequestForBackloadFrameSashTAB.VerticalScrollbarHighlightOnWheel = False
        Me.RequestForBackloadFrameSashTAB.VerticalScrollbarSize = 3
        '
        'RequestForBackloadScreenTCTRL
        '
        Me.RequestForBackloadScreenTCTRL.HorizontalScrollbarBarColor = True
        Me.RequestForBackloadScreenTCTRL.HorizontalScrollbarHighlightOnWheel = False
        Me.RequestForBackloadScreenTCTRL.HorizontalScrollbarSize = 3
        Me.RequestForBackloadScreenTCTRL.Location = New System.Drawing.Point(4, 38)
        Me.RequestForBackloadScreenTCTRL.Name = "RequestForBackloadScreenTCTRL"
        Me.RequestForBackloadScreenTCTRL.Size = New System.Drawing.Size(329, 58)
        Me.RequestForBackloadScreenTCTRL.TabIndex = 1
        Me.RequestForBackloadScreenTCTRL.Text = "Screen"
        Me.RequestForBackloadScreenTCTRL.VerticalScrollbarBarColor = True
        Me.RequestForBackloadScreenTCTRL.VerticalScrollbarHighlightOnWheel = False
        Me.RequestForBackloadScreenTCTRL.VerticalScrollbarSize = 3
        '
        'TitleLBL
        '
        Me.TitleLBL.AutoSize = True
        Me.TitleLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.TitleLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.TitleLBL.Location = New System.Drawing.Point(23, 41)
        Me.TitleLBL.Name = "TitleLBL"
        Me.TitleLBL.Size = New System.Drawing.Size(213, 25)
        Me.TitleLBL.TabIndex = 623
        Me.TitleLBL.Text = "Request for backload for "
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(932, 38)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 607
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Item No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "K#"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 57
        '
        'Column3
        '
        Me.Column3.HeaderText = "Wdw No."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 103
        '
        'Column4
        '
        Me.Column4.HeaderText = "Profile Color"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Location"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 98
        '
        'Column6
        '
        Me.Column6.HeaderText = "Item Description"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 155
        '
        'Column7
        '
        Me.Column7.HeaderText = "Width"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 81
        '
        'Column8
        '
        Me.Column8.HeaderText = "Height"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 85
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "K#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 57
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Wdw No."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 103
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Profile Color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 98
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Item Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 155
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Width"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 81
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Height"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 85
        '
        'BackloadRequestFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 653)
        Me.Controls.Add(Me.TitleLBL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoadingPB)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "BackloadRequestFRM"
        Me.Padding = New System.Windows.Forms.Padding(23, 69, 23, 23)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        CType(Me.SelectItemForBackloadDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RequestedItemsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameScreenToTheRightPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlassToTheRightPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallationMaterialToTheRightPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameScreenToTheLeftPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GlassToTheLeftPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InstallationMaterialToTheLeftPBOX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ForBackloadTCTRL.ResumeLayout(False)
        Me.RequestForBackloadTCTRL.ResumeLayout(False)
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectItemForBackloadDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents InstallationMaterialToTheLeftPBOX As PictureBox
    Friend WithEvents InstallationMaterialToTheRightPBOX As PictureBox
    Friend WithEvents GlassToTheLeftPBOX As PictureBox
    Friend WithEvents GlassToTheRightPBOX As PictureBox
    Friend WithEvents FrameScreenToTheLeftPBOX As PictureBox
    Friend WithEvents FrameScreenToTheRightPBOX As PictureBox
    Friend WithEvents InstallationMaterialBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents GlassBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents RequestedItemsDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents FrameScreenBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents OtherDetailsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReasonLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents OthersCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents SafeKeepingCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents SpareCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ReplacementCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents RecutCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents OtherDetailsTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TitleLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents RequestForBackloadTCTRL As MetroFramework.Controls.MetroTabControl
    Friend WithEvents RequestForBackloadFrameSashTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents RequestForBackloadScreenTCTRL As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ForBackloadTCTRL As MetroFramework.Controls.MetroTabControl
    Friend WithEvents ForBackloadFrameSashTAB As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ForBackloadScreenTCTRL As MetroFramework.Controls.MetroTabPage
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
