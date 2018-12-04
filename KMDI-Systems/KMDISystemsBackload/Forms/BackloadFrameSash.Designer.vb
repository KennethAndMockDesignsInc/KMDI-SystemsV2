<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackloadFrameSash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackloadFrameSash))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReasonLBL = New MetroFramework.Controls.MetroLabel()
        Me.OthersCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.SafeKeepingCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.SpareCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.ReplacementCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.RecutCBX = New MetroFramework.Controls.MetroCheckBox()
        Me.StorageLocationTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.BackloadedByTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.ProfileColorTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.ItemNoTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.HeightTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.KNoTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.WidthTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.DescriptionTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BackloadFrameSashDGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RefreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.AddUpdateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.OtherDetailsTBOX = New MetroFramework.Controls.MetroTextBox()
        Me.OtherDetailsLBL = New MetroFramework.Controls.MetroLabel()
        Me.BackloadsLBL = New MetroFramework.Controls.MetroLabel()
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BackloadFrameSashDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReasonLBL)
        Me.Panel1.Controls.Add(Me.OthersCBX)
        Me.Panel1.Controls.Add(Me.SafeKeepingCBX)
        Me.Panel1.Controls.Add(Me.SpareCBX)
        Me.Panel1.Controls.Add(Me.ReplacementCBX)
        Me.Panel1.Controls.Add(Me.RecutCBX)
        Me.Panel1.Controls.Add(Me.StorageLocationTBOX)
        Me.Panel1.Controls.Add(Me.BackloadedByTBOX)
        Me.Panel1.Controls.Add(Me.ProfileColorTBOX)
        Me.Panel1.Controls.Add(Me.ItemNoTBOX)
        Me.Panel1.Controls.Add(Me.HeightTBOX)
        Me.Panel1.Controls.Add(Me.KNoTBOX)
        Me.Panel1.Controls.Add(Me.WidthTBOX)
        Me.Panel1.Controls.Add(Me.DescriptionTBOX)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 500)
        Me.Panel1.TabIndex = 0
        '
        'ReasonLBL
        '
        Me.ReasonLBL.AutoSize = True
        Me.ReasonLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ReasonLBL.Location = New System.Drawing.Point(15, 306)
        Me.ReasonLBL.Name = "ReasonLBL"
        Me.ReasonLBL.Size = New System.Drawing.Size(64, 19)
        Me.ReasonLBL.TabIndex = 642
        Me.ReasonLBL.Text = "REASON:"
        '
        'OthersCBX
        '
        Me.OthersCBX.AutoSize = True
        Me.OthersCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.OthersCBX.Location = New System.Drawing.Point(15, 433)
        Me.OthersCBX.Name = "OthersCBX"
        Me.OthersCBX.Size = New System.Drawing.Size(165, 19)
        Me.OthersCBX.TabIndex = 641
        Me.OthersCBX.Text = "Others - Please Specify"
        Me.OthersCBX.UseSelectable = True
        '
        'SafeKeepingCBX
        '
        Me.SafeKeepingCBX.AutoSize = True
        Me.SafeKeepingCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.SafeKeepingCBX.Location = New System.Drawing.Point(15, 408)
        Me.SafeKeepingCBX.Name = "SafeKeepingCBX"
        Me.SafeKeepingCBX.Size = New System.Drawing.Size(103, 19)
        Me.SafeKeepingCBX.TabIndex = 640
        Me.SafeKeepingCBX.Text = "Safe Keeping"
        Me.SafeKeepingCBX.UseSelectable = True
        '
        'SpareCBX
        '
        Me.SpareCBX.AutoSize = True
        Me.SpareCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.SpareCBX.Location = New System.Drawing.Point(15, 383)
        Me.SpareCBX.Name = "SpareCBX"
        Me.SpareCBX.Size = New System.Drawing.Size(59, 19)
        Me.SpareCBX.TabIndex = 639
        Me.SpareCBX.Text = "Spare"
        Me.SpareCBX.UseSelectable = True
        '
        'ReplacementCBX
        '
        Me.ReplacementCBX.AutoSize = True
        Me.ReplacementCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.ReplacementCBX.Location = New System.Drawing.Point(15, 358)
        Me.ReplacementCBX.Name = "ReplacementCBX"
        Me.ReplacementCBX.Size = New System.Drawing.Size(103, 19)
        Me.ReplacementCBX.TabIndex = 638
        Me.ReplacementCBX.Text = "Replacement"
        Me.ReplacementCBX.UseSelectable = True
        '
        'RecutCBX
        '
        Me.RecutCBX.AutoSize = True
        Me.RecutCBX.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.RecutCBX.Location = New System.Drawing.Point(15, 333)
        Me.RecutCBX.Name = "RecutCBX"
        Me.RecutCBX.Size = New System.Drawing.Size(59, 19)
        Me.RecutCBX.TabIndex = 637
        Me.RecutCBX.Text = "Recut"
        Me.RecutCBX.UseSelectable = True
        '
        'StorageLocationTBOX
        '
        '
        '
        '
        Me.StorageLocationTBOX.CustomButton.Image = Nothing
        Me.StorageLocationTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.StorageLocationTBOX.CustomButton.Name = ""
        Me.StorageLocationTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.StorageLocationTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.StorageLocationTBOX.CustomButton.TabIndex = 1
        Me.StorageLocationTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.StorageLocationTBOX.CustomButton.UseSelectable = True
        Me.StorageLocationTBOX.CustomButton.Visible = False
        Me.StorageLocationTBOX.Lines = New String(-1) {}
        Me.StorageLocationTBOX.Location = New System.Drawing.Point(3, 255)
        Me.StorageLocationTBOX.MaxLength = 32767
        Me.StorageLocationTBOX.Name = "StorageLocationTBOX"
        Me.StorageLocationTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StorageLocationTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.StorageLocationTBOX.SelectedText = ""
        Me.StorageLocationTBOX.SelectionLength = 0
        Me.StorageLocationTBOX.SelectionStart = 0
        Me.StorageLocationTBOX.Size = New System.Drawing.Size(236, 30)
        Me.StorageLocationTBOX.TabIndex = 636
        Me.StorageLocationTBOX.UseSelectable = True
        Me.StorageLocationTBOX.WaterMark = "Storage Location"
        Me.StorageLocationTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StorageLocationTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BackloadedByTBOX
        '
        '
        '
        '
        Me.BackloadedByTBOX.CustomButton.Image = Nothing
        Me.BackloadedByTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.BackloadedByTBOX.CustomButton.Name = ""
        Me.BackloadedByTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.BackloadedByTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.BackloadedByTBOX.CustomButton.TabIndex = 1
        Me.BackloadedByTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.BackloadedByTBOX.CustomButton.UseSelectable = True
        Me.BackloadedByTBOX.CustomButton.Visible = False
        Me.BackloadedByTBOX.Lines = New String(-1) {}
        Me.BackloadedByTBOX.Location = New System.Drawing.Point(4, 219)
        Me.BackloadedByTBOX.MaxLength = 32767
        Me.BackloadedByTBOX.Name = "BackloadedByTBOX"
        Me.BackloadedByTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BackloadedByTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BackloadedByTBOX.SelectedText = ""
        Me.BackloadedByTBOX.SelectionLength = 0
        Me.BackloadedByTBOX.SelectionStart = 0
        Me.BackloadedByTBOX.Size = New System.Drawing.Size(236, 30)
        Me.BackloadedByTBOX.TabIndex = 635
        Me.BackloadedByTBOX.UseSelectable = True
        Me.BackloadedByTBOX.WaterMark = "Backloaded By"
        Me.BackloadedByTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BackloadedByTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ProfileColorTBOX
        '
        '
        '
        '
        Me.ProfileColorTBOX.CustomButton.Image = Nothing
        Me.ProfileColorTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.ProfileColorTBOX.CustomButton.Name = ""
        Me.ProfileColorTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.ProfileColorTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ProfileColorTBOX.CustomButton.TabIndex = 1
        Me.ProfileColorTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ProfileColorTBOX.CustomButton.UseSelectable = True
        Me.ProfileColorTBOX.CustomButton.Visible = False
        Me.ProfileColorTBOX.Enabled = False
        Me.ProfileColorTBOX.Lines = New String(-1) {}
        Me.ProfileColorTBOX.Location = New System.Drawing.Point(4, 183)
        Me.ProfileColorTBOX.MaxLength = 32767
        Me.ProfileColorTBOX.Name = "ProfileColorTBOX"
        Me.ProfileColorTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProfileColorTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ProfileColorTBOX.SelectedText = ""
        Me.ProfileColorTBOX.SelectionLength = 0
        Me.ProfileColorTBOX.SelectionStart = 0
        Me.ProfileColorTBOX.Size = New System.Drawing.Size(236, 30)
        Me.ProfileColorTBOX.TabIndex = 634
        Me.ProfileColorTBOX.UseSelectable = True
        Me.ProfileColorTBOX.WaterMark = "Profile Color"
        Me.ProfileColorTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ProfileColorTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ItemNoTBOX
        '
        '
        '
        '
        Me.ItemNoTBOX.CustomButton.Image = Nothing
        Me.ItemNoTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.ItemNoTBOX.CustomButton.Name = ""
        Me.ItemNoTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.ItemNoTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ItemNoTBOX.CustomButton.TabIndex = 1
        Me.ItemNoTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ItemNoTBOX.CustomButton.UseSelectable = True
        Me.ItemNoTBOX.CustomButton.Visible = False
        Me.ItemNoTBOX.Enabled = False
        Me.ItemNoTBOX.Lines = New String(-1) {}
        Me.ItemNoTBOX.Location = New System.Drawing.Point(4, 3)
        Me.ItemNoTBOX.MaxLength = 32767
        Me.ItemNoTBOX.Name = "ItemNoTBOX"
        Me.ItemNoTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ItemNoTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ItemNoTBOX.SelectedText = ""
        Me.ItemNoTBOX.SelectionLength = 0
        Me.ItemNoTBOX.SelectionStart = 0
        Me.ItemNoTBOX.Size = New System.Drawing.Size(236, 30)
        Me.ItemNoTBOX.TabIndex = 629
        Me.ItemNoTBOX.UseSelectable = True
        Me.ItemNoTBOX.WaterMark = "Item No."
        Me.ItemNoTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ItemNoTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HeightTBOX
        '
        '
        '
        '
        Me.HeightTBOX.CustomButton.Image = Nothing
        Me.HeightTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.HeightTBOX.CustomButton.Name = ""
        Me.HeightTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.HeightTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HeightTBOX.CustomButton.TabIndex = 1
        Me.HeightTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HeightTBOX.CustomButton.UseSelectable = True
        Me.HeightTBOX.CustomButton.Visible = False
        Me.HeightTBOX.Enabled = False
        Me.HeightTBOX.Lines = New String(-1) {}
        Me.HeightTBOX.Location = New System.Drawing.Point(4, 147)
        Me.HeightTBOX.MaxLength = 32767
        Me.HeightTBOX.Name = "HeightTBOX"
        Me.HeightTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HeightTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HeightTBOX.SelectedText = ""
        Me.HeightTBOX.SelectionLength = 0
        Me.HeightTBOX.SelectionStart = 0
        Me.HeightTBOX.Size = New System.Drawing.Size(236, 30)
        Me.HeightTBOX.TabIndex = 633
        Me.HeightTBOX.UseSelectable = True
        Me.HeightTBOX.WaterMark = "Height"
        Me.HeightTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HeightTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'KNoTBOX
        '
        '
        '
        '
        Me.KNoTBOX.CustomButton.Image = Nothing
        Me.KNoTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.KNoTBOX.CustomButton.Name = ""
        Me.KNoTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.KNoTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.KNoTBOX.CustomButton.TabIndex = 1
        Me.KNoTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.KNoTBOX.CustomButton.UseSelectable = True
        Me.KNoTBOX.CustomButton.Visible = False
        Me.KNoTBOX.Enabled = False
        Me.KNoTBOX.Lines = New String(-1) {}
        Me.KNoTBOX.Location = New System.Drawing.Point(4, 39)
        Me.KNoTBOX.MaxLength = 32767
        Me.KNoTBOX.Name = "KNoTBOX"
        Me.KNoTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.KNoTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.KNoTBOX.SelectedText = ""
        Me.KNoTBOX.SelectionLength = 0
        Me.KNoTBOX.SelectionStart = 0
        Me.KNoTBOX.Size = New System.Drawing.Size(236, 30)
        Me.KNoTBOX.TabIndex = 630
        Me.KNoTBOX.UseSelectable = True
        Me.KNoTBOX.WaterMark = "K#"
        Me.KNoTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KNoTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'WidthTBOX
        '
        '
        '
        '
        Me.WidthTBOX.CustomButton.Image = Nothing
        Me.WidthTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.WidthTBOX.CustomButton.Name = ""
        Me.WidthTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.WidthTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.WidthTBOX.CustomButton.TabIndex = 1
        Me.WidthTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.WidthTBOX.CustomButton.UseSelectable = True
        Me.WidthTBOX.CustomButton.Visible = False
        Me.WidthTBOX.Enabled = False
        Me.WidthTBOX.Lines = New String(-1) {}
        Me.WidthTBOX.Location = New System.Drawing.Point(4, 111)
        Me.WidthTBOX.MaxLength = 32767
        Me.WidthTBOX.Name = "WidthTBOX"
        Me.WidthTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.WidthTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.WidthTBOX.SelectedText = ""
        Me.WidthTBOX.SelectionLength = 0
        Me.WidthTBOX.SelectionStart = 0
        Me.WidthTBOX.Size = New System.Drawing.Size(236, 30)
        Me.WidthTBOX.TabIndex = 632
        Me.WidthTBOX.UseSelectable = True
        Me.WidthTBOX.WaterMark = "Width"
        Me.WidthTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.WidthTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'DescriptionTBOX
        '
        '
        '
        '
        Me.DescriptionTBOX.CustomButton.Image = Nothing
        Me.DescriptionTBOX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.DescriptionTBOX.CustomButton.Name = ""
        Me.DescriptionTBOX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.DescriptionTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.DescriptionTBOX.CustomButton.TabIndex = 1
        Me.DescriptionTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.DescriptionTBOX.CustomButton.UseSelectable = True
        Me.DescriptionTBOX.CustomButton.Visible = False
        Me.DescriptionTBOX.Enabled = False
        Me.DescriptionTBOX.Lines = New String(-1) {}
        Me.DescriptionTBOX.Location = New System.Drawing.Point(4, 75)
        Me.DescriptionTBOX.MaxLength = 32767
        Me.DescriptionTBOX.Name = "DescriptionTBOX"
        Me.DescriptionTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescriptionTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DescriptionTBOX.SelectedText = ""
        Me.DescriptionTBOX.SelectionLength = 0
        Me.DescriptionTBOX.SelectionStart = 0
        Me.DescriptionTBOX.Size = New System.Drawing.Size(236, 30)
        Me.DescriptionTBOX.TabIndex = 631
        Me.DescriptionTBOX.UseSelectable = True
        Me.DescriptionTBOX.WaterMark = "Description"
        Me.DescriptionTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DescriptionTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BackloadFrameSashDGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(265, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 285)
        Me.Panel2.TabIndex = 1
        '
        'BackloadFrameSashDGV
        '
        Me.BackloadFrameSashDGV.AllowUserToAddRows = False
        Me.BackloadFrameSashDGV.AllowUserToDeleteRows = False
        Me.BackloadFrameSashDGV.AllowUserToOrderColumns = True
        Me.BackloadFrameSashDGV.AllowUserToResizeRows = False
        Me.BackloadFrameSashDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.BackloadFrameSashDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.BackloadFrameSashDGV.ColumnHeadersHeight = 30
        Me.BackloadFrameSashDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackloadFrameSashDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackloadFrameSashDGV.Location = New System.Drawing.Point(0, 0)
        Me.BackloadFrameSashDGV.MultiSelect = False
        Me.BackloadFrameSashDGV.Name = "BackloadFrameSashDGV"
        Me.BackloadFrameSashDGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.BackloadFrameSashDGV.ReadOnly = True
        Me.BackloadFrameSashDGV.RowHeadersWidth = 30
        Me.BackloadFrameSashDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BackloadFrameSashDGV.Size = New System.Drawing.Size(603, 285)
        Me.BackloadFrameSashDGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.BackloadFrameSashDGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.BackloadFrameSashDGV.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BackloadFrameSashDGV.StateCommon.DataCell.Border.Width = 0
        Me.BackloadFrameSashDGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackloadFrameSashDGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.BackloadFrameSashDGV.TabIndex = 604
        Me.BackloadFrameSashDGV.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RefreshBTN)
        Me.Panel3.Controls.Add(Me.AddUpdateBTN)
        Me.Panel3.Controls.Add(Me.OtherDetailsTBOX)
        Me.Panel3.Controls.Add(Me.OtherDetailsLBL)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(265, 345)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(603, 215)
        Me.Panel3.TabIndex = 2
        '
        'RefreshBTN
        '
        Me.RefreshBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshBTN.Image = Nothing
        Me.RefreshBTN.Location = New System.Drawing.Point(372, 180)
        Me.RefreshBTN.Name = "RefreshBTN"
        Me.RefreshBTN.Size = New System.Drawing.Size(109, 30)
        Me.RefreshBTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.RefreshBTN.TabIndex = 629
        Me.RefreshBTN.Text = "Refresh"
        Me.RefreshBTN.UseSelectable = True
        Me.RefreshBTN.UseVisualStyleBackColor = True
        '
        'AddUpdateBTN
        '
        Me.AddUpdateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddUpdateBTN.Image = Nothing
        Me.AddUpdateBTN.Location = New System.Drawing.Point(487, 180)
        Me.AddUpdateBTN.Name = "AddUpdateBTN"
        Me.AddUpdateBTN.Size = New System.Drawing.Size(109, 30)
        Me.AddUpdateBTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.AddUpdateBTN.TabIndex = 628
        Me.AddUpdateBTN.Text = "Add"
        Me.AddUpdateBTN.UseSelectable = True
        Me.AddUpdateBTN.UseVisualStyleBackColor = True
        '
        'OtherDetailsTBOX
        '
        '
        '
        '
        Me.OtherDetailsTBOX.CustomButton.Image = Nothing
        Me.OtherDetailsTBOX.CustomButton.Location = New System.Drawing.Point(472, 1)
        Me.OtherDetailsTBOX.CustomButton.Name = ""
        Me.OtherDetailsTBOX.CustomButton.Size = New System.Drawing.Size(117, 117)
        Me.OtherDetailsTBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.OtherDetailsTBOX.CustomButton.TabIndex = 1
        Me.OtherDetailsTBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.OtherDetailsTBOX.CustomButton.UseSelectable = True
        Me.OtherDetailsTBOX.CustomButton.Visible = False
        Me.OtherDetailsTBOX.Lines = New String(-1) {}
        Me.OtherDetailsTBOX.Location = New System.Drawing.Point(6, 48)
        Me.OtherDetailsTBOX.MaxLength = 32767
        Me.OtherDetailsTBOX.Multiline = True
        Me.OtherDetailsTBOX.Name = "OtherDetailsTBOX"
        Me.OtherDetailsTBOX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OtherDetailsTBOX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.OtherDetailsTBOX.SelectedText = ""
        Me.OtherDetailsTBOX.SelectionLength = 0
        Me.OtherDetailsTBOX.SelectionStart = 0
        Me.OtherDetailsTBOX.Size = New System.Drawing.Size(590, 119)
        Me.OtherDetailsTBOX.TabIndex = 627
        Me.OtherDetailsTBOX.UseSelectable = True
        Me.OtherDetailsTBOX.WaterMark = "Input other information here including remarks."
        Me.OtherDetailsTBOX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.OtherDetailsTBOX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'OtherDetailsLBL
        '
        Me.OtherDetailsLBL.AutoSize = True
        Me.OtherDetailsLBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.OtherDetailsLBL.Location = New System.Drawing.Point(6, 21)
        Me.OtherDetailsLBL.Name = "OtherDetailsLBL"
        Me.OtherDetailsLBL.Size = New System.Drawing.Size(108, 19)
        Me.OtherDetailsLBL.TabIndex = 626
        Me.OtherDetailsLBL.Text = "OTHER DETAILS:"
        '
        'BackloadsLBL
        '
        Me.BackloadsLBL.AutoSize = True
        Me.BackloadsLBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.BackloadsLBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.BackloadsLBL.Location = New System.Drawing.Point(20, 34)
        Me.BackloadsLBL.Name = "BackloadsLBL"
        Me.BackloadsLBL.Size = New System.Drawing.Size(159, 25)
        Me.BackloadsLBL.TabIndex = 610
        Me.BackloadsLBL.Text = "B A C K L O A D S"
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(804, 31)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 609
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'BackloadFrameSash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 580)
        Me.Controls.Add(Me.BackloadsLBL)
        Me.Controls.Add(Me.LoadingPB)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BackloadFrameSash"
        Me.Resizable = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.BackloadFrameSashDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents BackloadsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents StorageLocationTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BackloadedByTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ProfileColorTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ItemNoTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents HeightTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KNoTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents WidthTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DescriptionTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ReasonLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents OthersCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents SafeKeepingCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents SpareCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ReplacementCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents RecutCBX As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents AddUpdateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents OtherDetailsTBOX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents OtherDetailsLBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents BackloadFrameSashDGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents RefreshBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
