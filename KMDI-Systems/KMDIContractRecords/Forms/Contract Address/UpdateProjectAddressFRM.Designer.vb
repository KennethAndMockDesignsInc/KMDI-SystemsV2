<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProjectAddressFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProjectAddressFRM))
        Me.LoadingPB = New System.Windows.Forms.PictureBox()
        Me.UpdateAddress_LBL = New MetroFramework.Controls.MetroLabel()
        Me.UpdateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Province__Required_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.CityMunicipality__Required_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.Brgy_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.Village_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.Street__Required_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.HouseNo_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.Establishment_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.UnitNo_TBX = New MetroFramework.Controls.MetroTextBox()
        Me.ContractImages_LBL = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Area__Required_CBX = New MetroFramework.Controls.MetroComboBox()
        Me.Address_TTP = New MetroFramework.Components.MetroToolTip()
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadingPB
        '
        Me.LoadingPB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadingPB.Image = CType(resources.GetObject("LoadingPB.Image"), System.Drawing.Image)
        Me.LoadingPB.Location = New System.Drawing.Point(346, 29)
        Me.LoadingPB.Name = "LoadingPB"
        Me.LoadingPB.Size = New System.Drawing.Size(85, 28)
        Me.LoadingPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LoadingPB.TabIndex = 642
        Me.LoadingPB.TabStop = False
        Me.LoadingPB.Visible = False
        '
        'UpdateAddress_LBL
        '
        Me.UpdateAddress_LBL.AutoSize = True
        Me.UpdateAddress_LBL.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.UpdateAddress_LBL.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.UpdateAddress_LBL.Location = New System.Drawing.Point(20, 32)
        Me.UpdateAddress_LBL.Name = "UpdateAddress_LBL"
        Me.UpdateAddress_LBL.Size = New System.Drawing.Size(307, 25)
        Me.UpdateAddress_LBL.TabIndex = 643
        Me.UpdateAddress_LBL.Text = "U P D A T E   A D D R E S S   I N F O"
        '
        'UpdateBTN
        '
        Me.UpdateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateBTN.Image = Nothing
        Me.UpdateBTN.Location = New System.Drawing.Point(311, 439)
        Me.UpdateBTN.Name = "UpdateBTN"
        Me.UpdateBTN.Size = New System.Drawing.Size(109, 30)
        Me.UpdateBTN.Style = MetroFramework.MetroColorStyle.Teal
        Me.UpdateBTN.TabIndex = 9
        Me.UpdateBTN.Text = "&Update"
        Me.UpdateBTN.UseSelectable = True
        Me.UpdateBTN.UseVisualStyleBackColor = True
        '
        'Province__Required_TBX
        '
        '
        '
        '
        Me.Province__Required_TBX.CustomButton.Image = Nothing
        Me.Province__Required_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.Province__Required_TBX.CustomButton.Name = ""
        Me.Province__Required_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Province__Required_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Province__Required_TBX.CustomButton.TabIndex = 1
        Me.Province__Required_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Province__Required_TBX.CustomButton.UseSelectable = True
        Me.Province__Required_TBX.CustomButton.Visible = False
        Me.Province__Required_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Province__Required_TBX.Lines = New String(-1) {}
        Me.Province__Required_TBX.Location = New System.Drawing.Point(143, 353)
        Me.Province__Required_TBX.MaxLength = 32767
        Me.Province__Required_TBX.Name = "Province__Required_TBX"
        Me.Province__Required_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Province__Required_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Province__Required_TBX.SelectedText = ""
        Me.Province__Required_TBX.SelectionLength = 0
        Me.Province__Required_TBX.SelectionStart = 0
        Me.Province__Required_TBX.Size = New System.Drawing.Size(236, 30)
        Me.Province__Required_TBX.Style = MetroFramework.MetroColorStyle.Red
        Me.Province__Required_TBX.TabIndex = 7
        Me.Province__Required_TBX.UseSelectable = True
        Me.Province__Required_TBX.WaterMark = "e.g Metro Manila"
        Me.Province__Required_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Province__Required_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CityMunicipality__Required_TBX
        '
        '
        '
        '
        Me.CityMunicipality__Required_TBX.CustomButton.Image = Nothing
        Me.CityMunicipality__Required_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.CityMunicipality__Required_TBX.CustomButton.Name = ""
        Me.CityMunicipality__Required_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.CityMunicipality__Required_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.CityMunicipality__Required_TBX.CustomButton.TabIndex = 1
        Me.CityMunicipality__Required_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.CityMunicipality__Required_TBX.CustomButton.UseSelectable = True
        Me.CityMunicipality__Required_TBX.CustomButton.Visible = False
        Me.CityMunicipality__Required_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.CityMunicipality__Required_TBX.Lines = New String(-1) {}
        Me.CityMunicipality__Required_TBX.Location = New System.Drawing.Point(143, 313)
        Me.CityMunicipality__Required_TBX.MaxLength = 32767
        Me.CityMunicipality__Required_TBX.Name = "CityMunicipality__Required_TBX"
        Me.CityMunicipality__Required_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CityMunicipality__Required_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CityMunicipality__Required_TBX.SelectedText = ""
        Me.CityMunicipality__Required_TBX.SelectionLength = 0
        Me.CityMunicipality__Required_TBX.SelectionStart = 0
        Me.CityMunicipality__Required_TBX.Size = New System.Drawing.Size(236, 30)
        Me.CityMunicipality__Required_TBX.Style = MetroFramework.MetroColorStyle.Red
        Me.CityMunicipality__Required_TBX.TabIndex = 6
        Me.CityMunicipality__Required_TBX.UseSelectable = True
        Me.CityMunicipality__Required_TBX.WaterMark = "e.g Quezon City"
        Me.CityMunicipality__Required_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.CityMunicipality__Required_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Brgy_TBX
        '
        '
        '
        '
        Me.Brgy_TBX.CustomButton.Image = Nothing
        Me.Brgy_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.Brgy_TBX.CustomButton.Name = ""
        Me.Brgy_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Brgy_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Brgy_TBX.CustomButton.TabIndex = 1
        Me.Brgy_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Brgy_TBX.CustomButton.UseSelectable = True
        Me.Brgy_TBX.CustomButton.Visible = False
        Me.Brgy_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Brgy_TBX.Lines = New String(-1) {}
        Me.Brgy_TBX.Location = New System.Drawing.Point(143, 273)
        Me.Brgy_TBX.MaxLength = 32767
        Me.Brgy_TBX.Name = "Brgy_TBX"
        Me.Brgy_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Brgy_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Brgy_TBX.SelectedText = ""
        Me.Brgy_TBX.SelectionLength = 0
        Me.Brgy_TBX.SelectionStart = 0
        Me.Brgy_TBX.Size = New System.Drawing.Size(236, 30)
        Me.Brgy_TBX.Style = MetroFramework.MetroColorStyle.Purple
        Me.Brgy_TBX.TabIndex = 5
        Me.Brgy_TBX.UseSelectable = True
        Me.Brgy_TBX.WaterMark = "e.g Brgy. Bagumbayan"
        Me.Brgy_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Brgy_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Village_TBX
        '
        '
        '
        '
        Me.Village_TBX.CustomButton.Image = Nothing
        Me.Village_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.Village_TBX.CustomButton.Name = ""
        Me.Village_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Village_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Village_TBX.CustomButton.TabIndex = 1
        Me.Village_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Village_TBX.CustomButton.UseSelectable = True
        Me.Village_TBX.CustomButton.Visible = False
        Me.Village_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Village_TBX.Lines = New String(-1) {}
        Me.Village_TBX.Location = New System.Drawing.Point(143, 233)
        Me.Village_TBX.MaxLength = 32767
        Me.Village_TBX.Name = "Village_TBX"
        Me.Village_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Village_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Village_TBX.SelectedText = ""
        Me.Village_TBX.SelectionLength = 0
        Me.Village_TBX.SelectionStart = 0
        Me.Village_TBX.Size = New System.Drawing.Size(236, 30)
        Me.Village_TBX.Style = MetroFramework.MetroColorStyle.Purple
        Me.Village_TBX.TabIndex = 4
        Me.Village_TBX.UseSelectable = True
        Me.Village_TBX.WaterMark = "e.g KMDI Village"
        Me.Village_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Village_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Street__Required_TBX
        '
        '
        '
        '
        Me.Street__Required_TBX.CustomButton.Image = Nothing
        Me.Street__Required_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.Street__Required_TBX.CustomButton.Name = ""
        Me.Street__Required_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Street__Required_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Street__Required_TBX.CustomButton.TabIndex = 1
        Me.Street__Required_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Street__Required_TBX.CustomButton.UseSelectable = True
        Me.Street__Required_TBX.CustomButton.Visible = False
        Me.Street__Required_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Street__Required_TBX.Lines = New String(-1) {}
        Me.Street__Required_TBX.Location = New System.Drawing.Point(143, 193)
        Me.Street__Required_TBX.MaxLength = 32767
        Me.Street__Required_TBX.Name = "Street__Required_TBX"
        Me.Street__Required_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Street__Required_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Street__Required_TBX.SelectedText = ""
        Me.Street__Required_TBX.SelectionLength = 0
        Me.Street__Required_TBX.SelectionStart = 0
        Me.Street__Required_TBX.Size = New System.Drawing.Size(236, 30)
        Me.Street__Required_TBX.Style = MetroFramework.MetroColorStyle.Red
        Me.Street__Required_TBX.TabIndex = 3
        Me.Street__Required_TBX.UseSelectable = True
        Me.Street__Required_TBX.WaterMark = "e.g Mercury Ave."
        Me.Street__Required_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Street__Required_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HouseNo_TBX
        '
        '
        '
        '
        Me.HouseNo_TBX.CustomButton.Image = Nothing
        Me.HouseNo_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.HouseNo_TBX.CustomButton.Name = ""
        Me.HouseNo_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.HouseNo_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HouseNo_TBX.CustomButton.TabIndex = 1
        Me.HouseNo_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HouseNo_TBX.CustomButton.UseSelectable = True
        Me.HouseNo_TBX.CustomButton.Visible = False
        Me.HouseNo_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.HouseNo_TBX.Lines = New String(-1) {}
        Me.HouseNo_TBX.Location = New System.Drawing.Point(143, 153)
        Me.HouseNo_TBX.MaxLength = 32767
        Me.HouseNo_TBX.Name = "HouseNo_TBX"
        Me.HouseNo_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HouseNo_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HouseNo_TBX.SelectedText = ""
        Me.HouseNo_TBX.SelectionLength = 0
        Me.HouseNo_TBX.SelectionStart = 0
        Me.HouseNo_TBX.Size = New System.Drawing.Size(236, 30)
        Me.HouseNo_TBX.Style = MetroFramework.MetroColorStyle.Purple
        Me.HouseNo_TBX.TabIndex = 2
        Me.HouseNo_TBX.UseSelectable = True
        Me.HouseNo_TBX.WaterMark = "e.g No. 1 or Blk 01 Lot 01"
        Me.HouseNo_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HouseNo_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Establishment_TBX
        '
        '
        '
        '
        Me.Establishment_TBX.CustomButton.Image = Nothing
        Me.Establishment_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.Establishment_TBX.CustomButton.Name = ""
        Me.Establishment_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Establishment_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Establishment_TBX.CustomButton.TabIndex = 1
        Me.Establishment_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Establishment_TBX.CustomButton.UseSelectable = True
        Me.Establishment_TBX.CustomButton.Visible = False
        Me.Establishment_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.Establishment_TBX.Lines = New String(-1) {}
        Me.Establishment_TBX.Location = New System.Drawing.Point(143, 113)
        Me.Establishment_TBX.MaxLength = 32767
        Me.Establishment_TBX.Name = "Establishment_TBX"
        Me.Establishment_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Establishment_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Establishment_TBX.SelectedText = ""
        Me.Establishment_TBX.SelectionLength = 0
        Me.Establishment_TBX.SelectionStart = 0
        Me.Establishment_TBX.Size = New System.Drawing.Size(236, 30)
        Me.Establishment_TBX.Style = MetroFramework.MetroColorStyle.Purple
        Me.Establishment_TBX.TabIndex = 1
        Me.Establishment_TBX.UseSelectable = True
        Me.Establishment_TBX.WaterMark = "e.g KMDI Building"
        Me.Establishment_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Establishment_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UnitNo_TBX
        '
        '
        '
        '
        Me.UnitNo_TBX.CustomButton.Image = Nothing
        Me.UnitNo_TBX.CustomButton.Location = New System.Drawing.Point(208, 2)
        Me.UnitNo_TBX.CustomButton.Name = ""
        Me.UnitNo_TBX.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.UnitNo_TBX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UnitNo_TBX.CustomButton.TabIndex = 1
        Me.UnitNo_TBX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UnitNo_TBX.CustomButton.UseSelectable = True
        Me.UnitNo_TBX.CustomButton.Visible = False
        Me.UnitNo_TBX.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.UnitNo_TBX.Lines = New String(-1) {}
        Me.UnitNo_TBX.Location = New System.Drawing.Point(143, 73)
        Me.UnitNo_TBX.MaxLength = 32767
        Me.UnitNo_TBX.Name = "UnitNo_TBX"
        Me.UnitNo_TBX.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UnitNo_TBX.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UnitNo_TBX.SelectedText = ""
        Me.UnitNo_TBX.SelectionLength = 0
        Me.UnitNo_TBX.SelectionStart = 0
        Me.UnitNo_TBX.Size = New System.Drawing.Size(236, 30)
        Me.UnitNo_TBX.Style = MetroFramework.MetroColorStyle.Purple
        Me.UnitNo_TBX.TabIndex = 0
        Me.UnitNo_TBX.UseSelectable = True
        Me.UnitNo_TBX.WaterMark = "e.g Unit 01"
        Me.UnitNo_TBX.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UnitNo_TBX.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ContractImages_LBL
        '
        Me.ContractImages_LBL.AutoSize = True
        Me.ContractImages_LBL.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.ContractImages_LBL.Location = New System.Drawing.Point(77, 78)
        Me.ContractImages_LBL.Name = "ContractImages_LBL"
        Me.ContractImages_LBL.Size = New System.Drawing.Size(60, 19)
        Me.ContractImages_LBL.TabIndex = 644
        Me.ContractImages_LBL.Text = "Unit No."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(43, 118)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel2.TabIndex = 645
        Me.MetroLabel2.Text = "Establishment"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(64, 158)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel3.TabIndex = 646
        Me.MetroLabel3.Text = "House No."
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(92, 198)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel4.TabIndex = 647
        Me.MetroLabel4.Text = "Street"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(88, 238)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel5.TabIndex = 648
        Me.MetroLabel5.Text = "Village"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(63, 278)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel6.TabIndex = 649
        Me.MetroLabel6.Text = "Baranggay"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(104, 318)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel7.TabIndex = 650
        Me.MetroLabel7.Text = "City"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(76, 358)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel8.TabIndex = 651
        Me.MetroLabel8.Text = "Province"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(100, 398)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel9.TabIndex = 652
        Me.MetroLabel9.Text = "Area"
        '
        'Area__Required_CBX
        '
        Me.Area__Required_CBX.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Area__Required_CBX.FormattingEnabled = True
        Me.Area__Required_CBX.ItemHeight = 23
        Me.Area__Required_CBX.Items.AddRange(New Object() {"Luzon", "Visayas", "Mindanao"})
        Me.Area__Required_CBX.Location = New System.Drawing.Point(143, 393)
        Me.Area__Required_CBX.Name = "Area__Required_CBX"
        Me.Area__Required_CBX.Size = New System.Drawing.Size(236, 29)
        Me.Area__Required_CBX.Style = MetroFramework.MetroColorStyle.Red
        Me.Area__Required_CBX.TabIndex = 8
        Me.Area__Required_CBX.UseSelectable = True
        '
        'Address_TTP
        '
        Me.Address_TTP.Style = MetroFramework.MetroColorStyle.Blue
        Me.Address_TTP.StyleManager = Nothing
        Me.Address_TTP.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'UpdateProjectAddressFRM
        '
        Me.AcceptButton = Me.UpdateBTN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 486)
        Me.Controls.Add(Me.Area__Required_CBX)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.ContractImages_LBL)
        Me.Controls.Add(Me.UpdateBTN)
        Me.Controls.Add(Me.Province__Required_TBX)
        Me.Controls.Add(Me.CityMunicipality__Required_TBX)
        Me.Controls.Add(Me.Brgy_TBX)
        Me.Controls.Add(Me.Village_TBX)
        Me.Controls.Add(Me.Street__Required_TBX)
        Me.Controls.Add(Me.HouseNo_TBX)
        Me.Controls.Add(Me.Establishment_TBX)
        Me.Controls.Add(Me.UnitNo_TBX)
        Me.Controls.Add(Me.UpdateAddress_LBL)
        Me.Controls.Add(Me.LoadingPB)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateProjectAddressFRM"
        Me.Resizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Purple
        CType(Me.LoadingPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoadingPB As PictureBox
    Friend WithEvents UpdateAddress_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents UpdateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Province__Required_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CityMunicipality__Required_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Brgy_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Village_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Street__Required_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents HouseNo_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Establishment_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents UnitNo_TBX As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ContractImages_LBL As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Area__Required_CBX As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Address_TTP As MetroFramework.Components.MetroToolTip
End Class
