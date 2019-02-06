<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TE_Installation_CPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TE_Installation_CPanel))
        Me.Mktng_InvLBL = New MetroFramework.Controls.MetroLabel()
        Me.Frm_PNL = New System.Windows.Forms.Panel()
        Me.DGV_Pnl = New System.Windows.Forms.Panel()
        Me.Glass_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Sash_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Frame_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Size_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ProfileType_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.TE_Cmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fields_Pnl = New System.Windows.Forms.Panel()
        Me.Fields_TblPnl = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.FieldsHeader_Pnl = New System.Windows.Forms.Panel()
        Me.FieldsHeader_Lbl = New MetroFramework.Controls.MetroLabel()
        Me.AddSidebar_Lbl = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.AddSidebar_Pnl = New System.Windows.Forms.Panel()
        Me.Exit_Pbtn = New System.Windows.Forms.PictureBox()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Frm_PNL.SuspendLayout()
        Me.TE_Cmenu.SuspendLayout()
        Me.Fields_Pnl.SuspendLayout()
        Me.Fields_TblPnl.SuspendLayout()
        Me.FieldsHeader_Pnl.SuspendLayout()
        CType(Me.Exit_Pbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mktng_InvLBL
        '
        Me.Mktng_InvLBL.AutoSize = True
        Me.Mktng_InvLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.Mktng_InvLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.Mktng_InvLBL.Location = New System.Drawing.Point(15, 24)
        Me.Mktng_InvLBL.Name = "Mktng_InvLBL"
        Me.Mktng_InvLBL.Size = New System.Drawing.Size(197, 25)
        Me.Mktng_InvLBL.TabIndex = 610
        Me.Mktng_InvLBL.Text = "T I M E   E L E M E N T"
        '
        'Frm_PNL
        '
        Me.Frm_PNL.Controls.Add(Me.DGV_Pnl)
        Me.Frm_PNL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frm_PNL.Location = New System.Drawing.Point(20, 60)
        Me.Frm_PNL.Name = "Frm_PNL"
        Me.Frm_PNL.Padding = New System.Windows.Forms.Padding(10)
        Me.Frm_PNL.Size = New System.Drawing.Size(613, 284)
        Me.Frm_PNL.TabIndex = 0
        '
        'DGV_Pnl
        '
        Me.DGV_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DGV_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Pnl.Location = New System.Drawing.Point(10, 10)
        Me.DGV_Pnl.Name = "DGV_Pnl"
        Me.DGV_Pnl.Size = New System.Drawing.Size(593, 264)
        Me.DGV_Pnl.TabIndex = 18
        '
        'Glass_Tbox
        '
        Me.Glass_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.Glass_Tbox.CustomButton.Image = Nothing
        Me.Glass_Tbox.CustomButton.Location = New System.Drawing.Point(99, 2)
        Me.Glass_Tbox.CustomButton.Name = ""
        Me.Glass_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Glass_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Glass_Tbox.CustomButton.TabIndex = 1
        Me.Glass_Tbox.CustomButton.Text = "+"
        Me.Glass_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Glass_Tbox.CustomButton.UseSelectable = True
        Me.Glass_Tbox.CustomButton.Visible = False
        Me.Glass_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Glass_Tbox.Lines = New String(-1) {}
        Me.Glass_Tbox.Location = New System.Drawing.Point(139, 212)
        Me.Glass_Tbox.MaxLength = 32767
        Me.Glass_Tbox.Name = "Glass_Tbox"
        Me.Glass_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Glass_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Glass_Tbox.SelectedText = ""
        Me.Glass_Tbox.SelectionLength = 0
        Me.Glass_Tbox.SelectionStart = 0
        Me.Glass_Tbox.Size = New System.Drawing.Size(127, 30)
        Me.Glass_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Glass_Tbox.TabIndex = 34
        Me.Glass_Tbox.UseSelectable = True
        Me.Glass_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Glass_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Sash_Tbox
        '
        Me.Sash_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.Sash_Tbox.CustomButton.Image = Nothing
        Me.Sash_Tbox.CustomButton.Location = New System.Drawing.Point(99, 1)
        Me.Sash_Tbox.CustomButton.Name = ""
        Me.Sash_Tbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.Sash_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Sash_Tbox.CustomButton.TabIndex = 1
        Me.Sash_Tbox.CustomButton.Text = "+"
        Me.Sash_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Sash_Tbox.CustomButton.UseSelectable = True
        Me.Sash_Tbox.CustomButton.Visible = False
        Me.Sash_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Sash_Tbox.Lines = New String(-1) {}
        Me.Sash_Tbox.Location = New System.Drawing.Point(139, 160)
        Me.Sash_Tbox.MaxLength = 32767
        Me.Sash_Tbox.Name = "Sash_Tbox"
        Me.Sash_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Sash_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Sash_Tbox.SelectedText = ""
        Me.Sash_Tbox.SelectionLength = 0
        Me.Sash_Tbox.SelectionStart = 0
        Me.Sash_Tbox.Size = New System.Drawing.Size(127, 29)
        Me.Sash_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Sash_Tbox.TabIndex = 33
        Me.Sash_Tbox.UseSelectable = True
        Me.Sash_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Sash_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Frame_Tbox
        '
        Me.Frame_Tbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        '
        '
        '
        Me.Frame_Tbox.CustomButton.Image = Nothing
        Me.Frame_Tbox.CustomButton.Location = New System.Drawing.Point(99, 1)
        Me.Frame_Tbox.CustomButton.Name = ""
        Me.Frame_Tbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.Frame_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Frame_Tbox.CustomButton.TabIndex = 1
        Me.Frame_Tbox.CustomButton.Text = "+"
        Me.Frame_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Frame_Tbox.CustomButton.UseSelectable = True
        Me.Frame_Tbox.CustomButton.Visible = False
        Me.Frame_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Frame_Tbox.Lines = New String(-1) {}
        Me.Frame_Tbox.Location = New System.Drawing.Point(139, 108)
        Me.Frame_Tbox.MaxLength = 32767
        Me.Frame_Tbox.Name = "Frame_Tbox"
        Me.Frame_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Frame_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Frame_Tbox.SelectedText = ""
        Me.Frame_Tbox.SelectionLength = 0
        Me.Frame_Tbox.SelectionStart = 0
        Me.Frame_Tbox.Size = New System.Drawing.Size(127, 29)
        Me.Frame_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Frame_Tbox.TabIndex = 32
        Me.Frame_Tbox.UseSelectable = True
        Me.Frame_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Frame_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Size_Tbox
        '
        '
        '
        '
        Me.Size_Tbox.CustomButton.Image = Nothing
        Me.Size_Tbox.CustomButton.Location = New System.Drawing.Point(99, 1)
        Me.Size_Tbox.CustomButton.Name = ""
        Me.Size_Tbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.Size_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Size_Tbox.CustomButton.TabIndex = 1
        Me.Size_Tbox.CustomButton.Text = "+"
        Me.Size_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Size_Tbox.CustomButton.UseSelectable = True
        Me.Size_Tbox.CustomButton.Visible = False
        Me.Size_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Size_Tbox.Lines = New String(-1) {}
        Me.Size_Tbox.Location = New System.Drawing.Point(139, 56)
        Me.Size_Tbox.MaxLength = 32767
        Me.Size_Tbox.Name = "Size_Tbox"
        Me.Size_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Size_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Size_Tbox.SelectedText = ""
        Me.Size_Tbox.SelectionLength = 0
        Me.Size_Tbox.SelectionStart = 0
        Me.Size_Tbox.Size = New System.Drawing.Size(127, 29)
        Me.Size_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Size_Tbox.TabIndex = 31
        Me.Size_Tbox.UseSelectable = True
        Me.Size_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Size_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(4, 209)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(120, 25)
        Me.MetroLabel4.TabIndex = 38
        Me.MetroLabel4.Text = "Glass (in secs)"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(4, 157)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(116, 25)
        Me.MetroLabel3.TabIndex = 37
        Me.MetroLabel3.Text = "Sash (in secs)"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(4, 105)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(128, 25)
        Me.MetroLabel2.TabIndex = 36
        Me.MetroLabel2.Text = "Frame (in secs)"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 53)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(43, 25)
        Me.MetroLabel1.TabIndex = 35
        Me.MetroLabel1.Text = "Size"
        '
        'ProfileType_Tbox
        '
        '
        '
        '
        Me.ProfileType_Tbox.CustomButton.Image = Nothing
        Me.ProfileType_Tbox.CustomButton.Location = New System.Drawing.Point(99, 1)
        Me.ProfileType_Tbox.CustomButton.Name = ""
        Me.ProfileType_Tbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.ProfileType_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ProfileType_Tbox.CustomButton.TabIndex = 1
        Me.ProfileType_Tbox.CustomButton.Text = "+"
        Me.ProfileType_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ProfileType_Tbox.CustomButton.UseSelectable = True
        Me.ProfileType_Tbox.CustomButton.Visible = False
        Me.ProfileType_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.ProfileType_Tbox.Lines = New String(-1) {}
        Me.ProfileType_Tbox.Location = New System.Drawing.Point(139, 4)
        Me.ProfileType_Tbox.MaxLength = 32767
        Me.ProfileType_Tbox.Name = "ProfileType_Tbox"
        Me.ProfileType_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProfileType_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProfileType_Tbox.SelectedText = ""
        Me.ProfileType_Tbox.SelectionLength = 0
        Me.ProfileType_Tbox.SelectionStart = 0
        Me.ProfileType_Tbox.Size = New System.Drawing.Size(127, 29)
        Me.ProfileType_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.ProfileType_Tbox.TabIndex = 30
        Me.ProfileType_Tbox.UseSelectable = True
        Me.ProfileType_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ProfileType_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TE_Cmenu
        '
        Me.TE_Cmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TE_Cmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.TE_Cmenu.Name = "TE_Cmenu"
        Me.TE_Cmenu.Size = New System.Drawing.Size(108, 48)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Fields_Pnl
        '
        Me.Fields_Pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fields_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Fields_Pnl.Controls.Add(Me.Fields_TblPnl)
        Me.Fields_Pnl.Controls.Add(Me.FieldsHeader_Pnl)
        Me.Fields_Pnl.Location = New System.Drawing.Point(351, 60)
        Me.Fields_Pnl.Name = "Fields_Pnl"
        Me.Fields_Pnl.Size = New System.Drawing.Size(272, 284)
        Me.Fields_Pnl.TabIndex = 20
        Me.Fields_Pnl.Visible = False
        '
        'Fields_TblPnl
        '
        Me.Fields_TblPnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Fields_TblPnl.ColumnCount = 2
        Me.Fields_TblPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.55762!))
        Me.Fields_TblPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.44238!))
        Me.Fields_TblPnl.Controls.Add(Me.Glass_Tbox, 1, 4)
        Me.Fields_TblPnl.Controls.Add(Me.ProfileType_Tbox, 1, 0)
        Me.Fields_TblPnl.Controls.Add(Me.MetroLabel4, 0, 4)
        Me.Fields_TblPnl.Controls.Add(Me.Sash_Tbox, 1, 3)
        Me.Fields_TblPnl.Controls.Add(Me.MetroLabel6, 0, 0)
        Me.Fields_TblPnl.Controls.Add(Me.Frame_Tbox, 1, 2)
        Me.Fields_TblPnl.Controls.Add(Me.MetroLabel3, 0, 3)
        Me.Fields_TblPnl.Controls.Add(Me.MetroLabel1, 0, 1)
        Me.Fields_TblPnl.Controls.Add(Me.Size_Tbox, 1, 1)
        Me.Fields_TblPnl.Controls.Add(Me.MetroLabel2, 0, 2)
        Me.Fields_TblPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Fields_TblPnl.Location = New System.Drawing.Point(0, 21)
        Me.Fields_TblPnl.Name = "Fields_TblPnl"
        Me.Fields_TblPnl.RowCount = 5
        Me.Fields_TblPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Fields_TblPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Fields_TblPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Fields_TblPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Fields_TblPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Fields_TblPnl.Size = New System.Drawing.Size(270, 261)
        Me.Fields_TblPnl.TabIndex = 30
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(4, 1)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(104, 25)
        Me.MetroLabel6.TabIndex = 39
        Me.MetroLabel6.Text = "Profile Type"
        '
        'FieldsHeader_Pnl
        '
        Me.FieldsHeader_Pnl.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.FieldsHeader_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FieldsHeader_Pnl.Controls.Add(Me.Exit_Pbtn)
        Me.FieldsHeader_Pnl.Controls.Add(Me.FieldsHeader_Lbl)
        Me.FieldsHeader_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.FieldsHeader_Pnl.Location = New System.Drawing.Point(0, 0)
        Me.FieldsHeader_Pnl.Name = "FieldsHeader_Pnl"
        Me.FieldsHeader_Pnl.Size = New System.Drawing.Size(270, 21)
        Me.FieldsHeader_Pnl.TabIndex = 31
        '
        'FieldsHeader_Lbl
        '
        Me.FieldsHeader_Lbl.AutoSize = True
        Me.FieldsHeader_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.FieldsHeader_Lbl.ForeColor = System.Drawing.Color.Black
        Me.FieldsHeader_Lbl.Location = New System.Drawing.Point(3, 0)
        Me.FieldsHeader_Lbl.Name = "FieldsHeader_Lbl"
        Me.FieldsHeader_Lbl.Size = New System.Drawing.Size(53, 19)
        Me.FieldsHeader_Lbl.TabIndex = 40
        Me.FieldsHeader_Lbl.Text = "Header"
        Me.FieldsHeader_Lbl.UseCustomBackColor = True
        Me.FieldsHeader_Lbl.UseCustomForeColor = True
        '
        'AddSidebar_Lbl
        '
        Me.AddSidebar_Lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSidebar_Lbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.AddSidebar_Lbl.Location = New System.Drawing.Point(624, 71)
        Me.AddSidebar_Lbl.Name = "AddSidebar_Lbl"
        Me.AddSidebar_Lbl.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
        Me.AddSidebar_Lbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003
        Me.AddSidebar_Lbl.Size = New System.Drawing.Size(22, 86)
        Me.AddSidebar_Lbl.TabIndex = 0
        Me.AddSidebar_Lbl.Values.Text = "Add new item"
        '
        'AddSidebar_Pnl
        '
        Me.AddSidebar_Pnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddSidebar_Pnl.BackColor = System.Drawing.Color.DimGray
        Me.AddSidebar_Pnl.Location = New System.Drawing.Point(646, 70)
        Me.AddSidebar_Pnl.Name = "AddSidebar_Pnl"
        Me.AddSidebar_Pnl.Size = New System.Drawing.Size(7, 86)
        Me.AddSidebar_Pnl.TabIndex = 1
        '
        'Exit_Pbtn
        '
        Me.Exit_Pbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Exit_Pbtn.Image = Global.KMDI_Systems.My.Resources.Resources.icons8_close_window_96
        Me.Exit_Pbtn.Location = New System.Drawing.Point(245, -2)
        Me.Exit_Pbtn.Name = "Exit_Pbtn"
        Me.Exit_Pbtn.Size = New System.Drawing.Size(22, 22)
        Me.Exit_Pbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Exit_Pbtn.TabIndex = 41
        Me.Exit_Pbtn.TabStop = False
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(564, 26)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 612
        Me.LoadingPB.TabStop = False
        '
        'TE_Installation_CPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 364)
        Me.Controls.Add(Me.Fields_Pnl)
        Me.Controls.Add(Me.AddSidebar_Pnl)
        Me.Controls.Add(Me.AddSidebar_Lbl)
        Me.Controls.Add(Me.Frm_PNL)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Mktng_InvLBL)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TE_Installation_CPanel"
        Me.Resizable = False
        Me.Frm_PNL.ResumeLayout(False)
        Me.TE_Cmenu.ResumeLayout(False)
        Me.Fields_Pnl.ResumeLayout(False)
        Me.Fields_TblPnl.ResumeLayout(False)
        Me.Fields_TblPnl.PerformLayout()
        Me.FieldsHeader_Pnl.ResumeLayout(False)
        Me.FieldsHeader_Pnl.PerformLayout()
        CType(Me.Exit_Pbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Mktng_InvLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents Frm_PNL As Panel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents DGV_Pnl As Panel
    Friend WithEvents TE_Cmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Fields_Pnl As Panel
    Friend WithEvents Fields_TblPnl As TableLayoutPanel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Glass_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Sash_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Frame_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Size_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProfileType_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents AddSidebar_Lbl As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents AddSidebar_Pnl As Panel
    Friend WithEvents FieldsHeader_Pnl As Panel
    Friend WithEvents FieldsHeader_Lbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Exit_Pbtn As PictureBox
End Class
