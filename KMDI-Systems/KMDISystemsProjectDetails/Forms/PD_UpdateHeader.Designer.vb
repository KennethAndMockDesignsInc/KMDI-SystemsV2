<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PD_UpdateHeader
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
        Me.BreadCrumb_Tab = New MetroFramework.Controls.MetroTabControl()
        Me.ProjectDetails_Page = New MetroFramework.Controls.MetroTabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.Area_Cbox_Required = New MetroFramework.Controls.MetroComboBox()
        Me.Province_Tbox_Required = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.City_Tbox_Required = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.Brgy_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.Village_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.Street_Tbox_Required = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.HouseNo_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.Establishment_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.UnitNo_Tbox = New MetroFramework.Controls.MetroTextBox()
        Me.Warning_Tooltip = New MetroFramework.Components.MetroToolTip()
        Me.BreadCrumb_Tab.SuspendLayout()
        Me.ProjectDetails_Page.SuspendLayout()
        Me.SuspendLayout()
        '
        'BreadCrumb_Tab
        '
        Me.BreadCrumb_Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BreadCrumb_Tab.Controls.Add(Me.ProjectDetails_Page)
        Me.BreadCrumb_Tab.Location = New System.Drawing.Point(23, 68)
        Me.BreadCrumb_Tab.Multiline = True
        Me.BreadCrumb_Tab.Name = "BreadCrumb_Tab"
        Me.BreadCrumb_Tab.SelectedIndex = 0
        Me.BreadCrumb_Tab.Size = New System.Drawing.Size(348, 456)
        Me.BreadCrumb_Tab.TabIndex = 15
        Me.BreadCrumb_Tab.UseSelectable = True
        '
        'ProjectDetails_Page
        '
        Me.ProjectDetails_Page.AutoScroll = True
        Me.ProjectDetails_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectDetails_Page.Controls.Add(Me.MetroButton1)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel14)
        Me.ProjectDetails_Page.Controls.Add(Me.Area_Cbox_Required)
        Me.ProjectDetails_Page.Controls.Add(Me.Province_Tbox_Required)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel13)
        Me.ProjectDetails_Page.Controls.Add(Me.City_Tbox_Required)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel12)
        Me.ProjectDetails_Page.Controls.Add(Me.Brgy_Tbox)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel11)
        Me.ProjectDetails_Page.Controls.Add(Me.Village_Tbox)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel10)
        Me.ProjectDetails_Page.Controls.Add(Me.Street_Tbox_Required)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel9)
        Me.ProjectDetails_Page.Controls.Add(Me.HouseNo_Tbox)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel8)
        Me.ProjectDetails_Page.Controls.Add(Me.Establishment_Tbox)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel7)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel4)
        Me.ProjectDetails_Page.Controls.Add(Me.MetroLabel3)
        Me.ProjectDetails_Page.Controls.Add(Me.UnitNo_Tbox)
        Me.ProjectDetails_Page.HorizontalScrollbar = True
        Me.ProjectDetails_Page.HorizontalScrollbarBarColor = True
        Me.ProjectDetails_Page.HorizontalScrollbarHighlightOnWheel = False
        Me.ProjectDetails_Page.HorizontalScrollbarSize = 10
        Me.ProjectDetails_Page.Location = New System.Drawing.Point(4, 38)
        Me.ProjectDetails_Page.Name = "ProjectDetails_Page"
        Me.ProjectDetails_Page.Size = New System.Drawing.Size(340, 414)
        Me.ProjectDetails_Page.TabIndex = 0
        Me.ProjectDetails_Page.Text = "Header                                                                       "
        Me.ProjectDetails_Page.VerticalScrollbar = True
        Me.ProjectDetails_Page.VerticalScrollbarBarColor = True
        Me.ProjectDetails_Page.VerticalScrollbarHighlightOnWheel = False
        Me.ProjectDetails_Page.VerticalScrollbarSize = 20
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(196, 365)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(112, 34)
        Me.MetroButton1.TabIndex = 78
        Me.MetroButton1.Text = "Save"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel14.Location = New System.Drawing.Point(61, 335)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel14.TabIndex = 28
        Me.MetroLabel14.Text = "Area"
        '
        'Area_Cbox_Required
        '
        Me.Area_Cbox_Required.ItemHeight = 23
        Me.Area_Cbox_Required.Items.AddRange(New Object() {"Luzon", "Visayas", "Mindanao"})
        Me.Area_Cbox_Required.Location = New System.Drawing.Point(113, 330)
        Me.Area_Cbox_Required.Name = "Area_Cbox_Required"
        Me.Area_Cbox_Required.Size = New System.Drawing.Size(195, 29)
        Me.Area_Cbox_Required.Style = MetroFramework.MetroColorStyle.Blue
        Me.Area_Cbox_Required.TabIndex = 13
        Me.Area_Cbox_Required.UseSelectable = True
        Me.Area_Cbox_Required.UseStyleColors = True
        '
        'Province_Tbox_Required
        '
        '
        '
        '
        Me.Province_Tbox_Required.CustomButton.Image = Nothing
        Me.Province_Tbox_Required.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.Province_Tbox_Required.CustomButton.Name = ""
        Me.Province_Tbox_Required.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Province_Tbox_Required.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Province_Tbox_Required.CustomButton.TabIndex = 1
        Me.Province_Tbox_Required.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Province_Tbox_Required.CustomButton.UseSelectable = True
        Me.Province_Tbox_Required.CustomButton.Visible = False
        Me.Province_Tbox_Required.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Province_Tbox_Required.Lines = New String(-1) {}
        Me.Province_Tbox_Required.Location = New System.Drawing.Point(113, 294)
        Me.Province_Tbox_Required.MaxLength = 32767
        Me.Province_Tbox_Required.Name = "Province_Tbox_Required"
        Me.Province_Tbox_Required.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Province_Tbox_Required.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Province_Tbox_Required.SelectedText = ""
        Me.Province_Tbox_Required.SelectionLength = 0
        Me.Province_Tbox_Required.SelectionStart = 0
        Me.Province_Tbox_Required.Size = New System.Drawing.Size(195, 30)
        Me.Province_Tbox_Required.Style = MetroFramework.MetroColorStyle.Blue
        Me.Province_Tbox_Required.TabIndex = 12
        Me.Province_Tbox_Required.UseSelectable = True
        Me.Province_Tbox_Required.UseStyleColors = True
        Me.Province_Tbox_Required.WaterMark = "e.g Metro Manila"
        Me.Province_Tbox_Required.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Province_Tbox_Required.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel13.Location = New System.Drawing.Point(37, 299)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel13.TabIndex = 26
        Me.MetroLabel13.Text = "Province"
        '
        'City_Tbox_Required
        '
        '
        '
        '
        Me.City_Tbox_Required.CustomButton.Image = Nothing
        Me.City_Tbox_Required.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.City_Tbox_Required.CustomButton.Name = ""
        Me.City_Tbox_Required.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.City_Tbox_Required.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.City_Tbox_Required.CustomButton.TabIndex = 1
        Me.City_Tbox_Required.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.City_Tbox_Required.CustomButton.UseSelectable = True
        Me.City_Tbox_Required.CustomButton.Visible = False
        Me.City_Tbox_Required.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.City_Tbox_Required.Lines = New String(-1) {}
        Me.City_Tbox_Required.Location = New System.Drawing.Point(113, 258)
        Me.City_Tbox_Required.MaxLength = 32767
        Me.City_Tbox_Required.Name = "City_Tbox_Required"
        Me.City_Tbox_Required.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.City_Tbox_Required.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.City_Tbox_Required.SelectedText = ""
        Me.City_Tbox_Required.SelectionLength = 0
        Me.City_Tbox_Required.SelectionStart = 0
        Me.City_Tbox_Required.Size = New System.Drawing.Size(195, 30)
        Me.City_Tbox_Required.Style = MetroFramework.MetroColorStyle.Blue
        Me.City_Tbox_Required.TabIndex = 11
        Me.City_Tbox_Required.UseSelectable = True
        Me.City_Tbox_Required.UseStyleColors = True
        Me.City_Tbox_Required.WaterMark = "e.g Quezon City"
        Me.City_Tbox_Required.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.City_Tbox_Required.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel12.Location = New System.Drawing.Point(57, 263)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel12.TabIndex = 24
        Me.MetroLabel12.Text = "City"
        '
        'Brgy_Tbox
        '
        '
        '
        '
        Me.Brgy_Tbox.CustomButton.Image = Nothing
        Me.Brgy_Tbox.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.Brgy_Tbox.CustomButton.Name = ""
        Me.Brgy_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Brgy_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Brgy_Tbox.CustomButton.TabIndex = 1
        Me.Brgy_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Brgy_Tbox.CustomButton.UseSelectable = True
        Me.Brgy_Tbox.CustomButton.Visible = False
        Me.Brgy_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Brgy_Tbox.Lines = New String(-1) {}
        Me.Brgy_Tbox.Location = New System.Drawing.Point(113, 222)
        Me.Brgy_Tbox.MaxLength = 32767
        Me.Brgy_Tbox.Name = "Brgy_Tbox"
        Me.Brgy_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Brgy_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Brgy_Tbox.SelectedText = ""
        Me.Brgy_Tbox.SelectionLength = 0
        Me.Brgy_Tbox.SelectionStart = 0
        Me.Brgy_Tbox.Size = New System.Drawing.Size(195, 30)
        Me.Brgy_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Brgy_Tbox.TabIndex = 10
        Me.Brgy_Tbox.UseSelectable = True
        Me.Brgy_Tbox.UseStyleColors = True
        Me.Brgy_Tbox.WaterMark = "e.g Brgy. Bagumbayan"
        Me.Brgy_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Brgy_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(24, 227)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel11.TabIndex = 22
        Me.MetroLabel11.Text = "Baranggay"
        '
        'Village_Tbox
        '
        '
        '
        '
        Me.Village_Tbox.CustomButton.Image = Nothing
        Me.Village_Tbox.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.Village_Tbox.CustomButton.Name = ""
        Me.Village_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Village_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Village_Tbox.CustomButton.TabIndex = 1
        Me.Village_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Village_Tbox.CustomButton.UseSelectable = True
        Me.Village_Tbox.CustomButton.Visible = False
        Me.Village_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Village_Tbox.Lines = New String(-1) {}
        Me.Village_Tbox.Location = New System.Drawing.Point(113, 186)
        Me.Village_Tbox.MaxLength = 32767
        Me.Village_Tbox.Name = "Village_Tbox"
        Me.Village_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Village_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Village_Tbox.SelectedText = ""
        Me.Village_Tbox.SelectionLength = 0
        Me.Village_Tbox.SelectionStart = 0
        Me.Village_Tbox.Size = New System.Drawing.Size(195, 30)
        Me.Village_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Village_Tbox.TabIndex = 9
        Me.Village_Tbox.UseSelectable = True
        Me.Village_Tbox.UseStyleColors = True
        Me.Village_Tbox.WaterMark = "e.g KMDI Village"
        Me.Village_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Village_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(49, 191)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel10.TabIndex = 20
        Me.MetroLabel10.Text = "Village"
        '
        'Street_Tbox_Required
        '
        '
        '
        '
        Me.Street_Tbox_Required.CustomButton.Image = Nothing
        Me.Street_Tbox_Required.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.Street_Tbox_Required.CustomButton.Name = ""
        Me.Street_Tbox_Required.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Street_Tbox_Required.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Street_Tbox_Required.CustomButton.TabIndex = 1
        Me.Street_Tbox_Required.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Street_Tbox_Required.CustomButton.UseSelectable = True
        Me.Street_Tbox_Required.CustomButton.Visible = False
        Me.Street_Tbox_Required.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Street_Tbox_Required.Lines = New String(-1) {}
        Me.Street_Tbox_Required.Location = New System.Drawing.Point(114, 150)
        Me.Street_Tbox_Required.MaxLength = 32767
        Me.Street_Tbox_Required.Name = "Street_Tbox_Required"
        Me.Street_Tbox_Required.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Street_Tbox_Required.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Street_Tbox_Required.SelectedText = ""
        Me.Street_Tbox_Required.SelectionLength = 0
        Me.Street_Tbox_Required.SelectionStart = 0
        Me.Street_Tbox_Required.Size = New System.Drawing.Size(195, 30)
        Me.Street_Tbox_Required.Style = MetroFramework.MetroColorStyle.Blue
        Me.Street_Tbox_Required.TabIndex = 8
        Me.Street_Tbox_Required.UseSelectable = True
        Me.Street_Tbox_Required.UseStyleColors = True
        Me.Street_Tbox_Required.WaterMark = "e.g Mercury Ave."
        Me.Street_Tbox_Required.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Street_Tbox_Required.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(53, 155)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel9.TabIndex = 19
        Me.MetroLabel9.Text = "Street"
        '
        'HouseNo_Tbox
        '
        '
        '
        '
        Me.HouseNo_Tbox.CustomButton.Image = Nothing
        Me.HouseNo_Tbox.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.HouseNo_Tbox.CustomButton.Name = ""
        Me.HouseNo_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.HouseNo_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.HouseNo_Tbox.CustomButton.TabIndex = 1
        Me.HouseNo_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.HouseNo_Tbox.CustomButton.UseSelectable = True
        Me.HouseNo_Tbox.CustomButton.Visible = False
        Me.HouseNo_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.HouseNo_Tbox.Lines = New String(-1) {}
        Me.HouseNo_Tbox.Location = New System.Drawing.Point(114, 114)
        Me.HouseNo_Tbox.MaxLength = 32767
        Me.HouseNo_Tbox.Name = "HouseNo_Tbox"
        Me.HouseNo_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HouseNo_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.HouseNo_Tbox.SelectedText = ""
        Me.HouseNo_Tbox.SelectionLength = 0
        Me.HouseNo_Tbox.SelectionStart = 0
        Me.HouseNo_Tbox.Size = New System.Drawing.Size(195, 30)
        Me.HouseNo_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.HouseNo_Tbox.TabIndex = 7
        Me.HouseNo_Tbox.UseSelectable = True
        Me.HouseNo_Tbox.UseStyleColors = True
        Me.HouseNo_Tbox.WaterMark = "e.g No. 01 or Blk 01 Lot 01"
        Me.HouseNo_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.HouseNo_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(25, 119)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel8.TabIndex = 18
        Me.MetroLabel8.Text = "House No."
        '
        'Establishment_Tbox
        '
        '
        '
        '
        Me.Establishment_Tbox.CustomButton.Image = Nothing
        Me.Establishment_Tbox.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.Establishment_Tbox.CustomButton.Name = ""
        Me.Establishment_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.Establishment_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Establishment_Tbox.CustomButton.TabIndex = 1
        Me.Establishment_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Establishment_Tbox.CustomButton.UseSelectable = True
        Me.Establishment_Tbox.CustomButton.Visible = False
        Me.Establishment_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Establishment_Tbox.Lines = New String(-1) {}
        Me.Establishment_Tbox.Location = New System.Drawing.Point(113, 78)
        Me.Establishment_Tbox.MaxLength = 32767
        Me.Establishment_Tbox.Name = "Establishment_Tbox"
        Me.Establishment_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Establishment_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Establishment_Tbox.SelectedText = ""
        Me.Establishment_Tbox.SelectionLength = 0
        Me.Establishment_Tbox.SelectionStart = 0
        Me.Establishment_Tbox.Size = New System.Drawing.Size(195, 30)
        Me.Establishment_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.Establishment_Tbox.TabIndex = 6
        Me.Establishment_Tbox.UseSelectable = True
        Me.Establishment_Tbox.UseStyleColors = True
        Me.Establishment_Tbox.WaterMark = "e.g KMDI Building"
        Me.Establishment_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Establishment_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 83)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(94, 19)
        Me.MetroLabel7.TabIndex = 17
        Me.MetroLabel7.Text = "Establishment"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 11)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "Project Address"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(37, 47)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel3.TabIndex = 16
        Me.MetroLabel3.Text = "Unit No."
        '
        'UnitNo_Tbox
        '
        '
        '
        '
        Me.UnitNo_Tbox.CustomButton.Image = Nothing
        Me.UnitNo_Tbox.CustomButton.Location = New System.Drawing.Point(167, 2)
        Me.UnitNo_Tbox.CustomButton.Name = ""
        Me.UnitNo_Tbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.UnitNo_Tbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UnitNo_Tbox.CustomButton.TabIndex = 1
        Me.UnitNo_Tbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UnitNo_Tbox.CustomButton.UseSelectable = True
        Me.UnitNo_Tbox.CustomButton.Visible = False
        Me.UnitNo_Tbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.UnitNo_Tbox.Lines = New String(-1) {}
        Me.UnitNo_Tbox.Location = New System.Drawing.Point(113, 42)
        Me.UnitNo_Tbox.MaxLength = 32767
        Me.UnitNo_Tbox.Name = "UnitNo_Tbox"
        Me.UnitNo_Tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UnitNo_Tbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UnitNo_Tbox.SelectedText = ""
        Me.UnitNo_Tbox.SelectionLength = 0
        Me.UnitNo_Tbox.SelectionStart = 0
        Me.UnitNo_Tbox.Size = New System.Drawing.Size(195, 30)
        Me.UnitNo_Tbox.Style = MetroFramework.MetroColorStyle.Blue
        Me.UnitNo_Tbox.TabIndex = 5
        Me.UnitNo_Tbox.UseSelectable = True
        Me.UnitNo_Tbox.UseStyleColors = True
        Me.UnitNo_Tbox.WaterMark = "e.g Unit 01"
        Me.UnitNo_Tbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UnitNo_Tbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        '
        'Warning_Tooltip
        '
        Me.Warning_Tooltip.AutoPopDelay = 100
        Me.Warning_Tooltip.InitialDelay = 500
        Me.Warning_Tooltip.ReshowDelay = 100
        Me.Warning_Tooltip.Style = MetroFramework.MetroColorStyle.Blue
        Me.Warning_Tooltip.StyleManager = Nothing
        Me.Warning_Tooltip.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'PD_UpdateHeader
        '
        Me.AcceptButton = Me.MetroButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 547)
        Me.Controls.Add(Me.BreadCrumb_Tab)
        Me.MaximizeBox = False
        Me.Name = "PD_UpdateHeader"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Update"
        Me.BreadCrumb_Tab.ResumeLayout(False)
        Me.ProjectDetails_Page.ResumeLayout(False)
        Me.ProjectDetails_Page.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BreadCrumb_Tab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents ProjectDetails_Page As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Area_Cbox_Required As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Province_Tbox_Required As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents City_Tbox_Required As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Brgy_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Village_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Street_Tbox_Required As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents HouseNo_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Establishment_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents UnitNo_Tbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Warning_Tooltip As MetroFramework.Components.MetroToolTip
End Class
