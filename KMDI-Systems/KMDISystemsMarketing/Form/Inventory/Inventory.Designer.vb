<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintQR_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.GenerateQR_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.CategoryUpdate_Btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Reset_Btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.DelItemInv_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.EditItemInv_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SaveItemInv_btn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.RemarksTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.ItemClass_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.ItemPurpose_Cbox = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.DeliveryQuantityNUpdown = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.PurchasedDate_dtp = New MetroFramework.Controls.MetroDateTime()
        Me.InventoryDGVUpdateItemImage = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ViewImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryDGVHeaderCmenu = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ShowColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasedDateTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.SearchInvTbox = New MetroFramework.Controls.MetroTextBox()
        Me.InventoryDGV = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.DiscountedPriceTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.ListPriceTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.GenPrefCbox = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ItemCodeTbox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.CategoryCbox = New System.Windows.Forms.ComboBox()
        Me.BrandTbox = New MetroFramework.Controls.MetroTextBox()
        Me.ItemDesTbox = New MetroFramework.Controls.MetroTextBox()
        Me.ColorTbox = New MetroFramework.Controls.MetroTextBox()
        Me.SizeTbox = New MetroFramework.Controls.MetroTextBox()
        Me.DontClick_Btn = New MetroFramework.Controls.MetroButton()
        CType(Me.DeliveryQuantityNUpdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryDGVUpdateItemImage.SuspendLayout()
        Me.InventoryDGVHeaderCmenu.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        CType(Me.InventoryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintQR_btn
        '
        Me.PrintQR_btn.Image = Nothing
        Me.PrintQR_btn.Location = New System.Drawing.Point(110, 17)
        Me.PrintQR_btn.Name = "PrintQR_btn"
        Me.PrintQR_btn.Size = New System.Drawing.Size(152, 30)
        Me.PrintQR_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.PrintQR_btn.TabIndex = 38
        Me.PrintQR_btn.Text = "&Print QR Code"
        Me.PrintQR_btn.UseSelectable = True
        Me.PrintQR_btn.UseVisualStyleBackColor = True
        '
        'GenerateQR_btn
        '
        Me.GenerateQR_btn.Image = Nothing
        Me.GenerateQR_btn.Location = New System.Drawing.Point(308, 54)
        Me.GenerateQR_btn.Name = "GenerateQR_btn"
        Me.GenerateQR_btn.Size = New System.Drawing.Size(34, 23)
        Me.GenerateQR_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.GenerateQR_btn.TabIndex = 37
        Me.GenerateQR_btn.Text = "&G"
        Me.GenerateQR_btn.UseSelectable = True
        Me.GenerateQR_btn.UseVisualStyleBackColor = True
        '
        'CategoryUpdate_Btn
        '
        Me.CategoryUpdate_Btn.Image = Nothing
        Me.CategoryUpdate_Btn.Location = New System.Drawing.Point(308, 90)
        Me.CategoryUpdate_Btn.Name = "CategoryUpdate_Btn"
        Me.CategoryUpdate_Btn.Size = New System.Drawing.Size(34, 23)
        Me.CategoryUpdate_Btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.CategoryUpdate_Btn.TabIndex = 36
        Me.CategoryUpdate_Btn.Text = "&C"
        Me.CategoryUpdate_Btn.UseSelectable = True
        Me.CategoryUpdate_Btn.UseVisualStyleBackColor = True
        '
        'Reset_Btn
        '
        Me.Reset_Btn.Image = Nothing
        Me.Reset_Btn.Location = New System.Drawing.Point(268, 17)
        Me.Reset_Btn.Name = "Reset_Btn"
        Me.Reset_Btn.Size = New System.Drawing.Size(74, 30)
        Me.Reset_Btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.Reset_Btn.TabIndex = 34
        Me.Reset_Btn.Text = "&Reset"
        Me.Reset_Btn.UseSelectable = True
        Me.Reset_Btn.UseVisualStyleBackColor = True
        '
        'DelItemInv_btn
        '
        Me.DelItemInv_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelItemInv_btn.Image = Nothing
        Me.DelItemInv_btn.Location = New System.Drawing.Point(234, 547)
        Me.DelItemInv_btn.Name = "DelItemInv_btn"
        Me.DelItemInv_btn.Size = New System.Drawing.Size(102, 56)
        Me.DelItemInv_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.DelItemInv_btn.TabIndex = 33
        Me.DelItemInv_btn.Text = "&Delete"
        Me.DelItemInv_btn.UseSelectable = True
        Me.DelItemInv_btn.UseVisualStyleBackColor = True
        '
        'EditItemInv_btn
        '
        Me.EditItemInv_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditItemInv_btn.Image = Nothing
        Me.EditItemInv_btn.Location = New System.Drawing.Point(126, 547)
        Me.EditItemInv_btn.Name = "EditItemInv_btn"
        Me.EditItemInv_btn.Size = New System.Drawing.Size(102, 56)
        Me.EditItemInv_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.EditItemInv_btn.TabIndex = 32
        Me.EditItemInv_btn.Text = "Updat&e"
        Me.EditItemInv_btn.UseSelectable = True
        Me.EditItemInv_btn.UseVisualStyleBackColor = True
        '
        'SaveItemInv_btn
        '
        Me.SaveItemInv_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveItemInv_btn.Image = Nothing
        Me.SaveItemInv_btn.Location = New System.Drawing.Point(18, 547)
        Me.SaveItemInv_btn.Name = "SaveItemInv_btn"
        Me.SaveItemInv_btn.Size = New System.Drawing.Size(102, 56)
        Me.SaveItemInv_btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.SaveItemInv_btn.TabIndex = 31
        Me.SaveItemInv_btn.Text = "&Add"
        Me.SaveItemInv_btn.UseSelectable = True
        Me.SaveItemInv_btn.UseVisualStyleBackColor = True
        '
        'RemarksTbox
        '
        '
        '
        '
        Me.RemarksTbox.CustomButton.Image = Nothing
        Me.RemarksTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.RemarksTbox.CustomButton.Name = ""
        Me.RemarksTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.RemarksTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.RemarksTbox.CustomButton.TabIndex = 1
        Me.RemarksTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.RemarksTbox.CustomButton.UseSelectable = True
        Me.RemarksTbox.CustomButton.Visible = False
        Me.RemarksTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.RemarksTbox.ForeColor = System.Drawing.Color.Black
        Me.RemarksTbox.Lines = New String(-1) {}
        Me.RemarksTbox.Location = New System.Drawing.Point(110, 512)
        Me.RemarksTbox.MaxLength = 32767
        Me.RemarksTbox.Name = "RemarksTbox"
        Me.RemarksTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RemarksTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RemarksTbox.SelectedText = ""
        Me.RemarksTbox.SelectionLength = 0
        Me.RemarksTbox.SelectionStart = 0
        Me.RemarksTbox.Size = New System.Drawing.Size(233, 29)
        Me.RemarksTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.RemarksTbox.TabIndex = 30
        Me.RemarksTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.RemarksTbox.UseCustomBackColor = True
        Me.RemarksTbox.UseCustomForeColor = True
        Me.RemarksTbox.UseSelectable = True
        Me.RemarksTbox.UseStyleColors = True
        Me.RemarksTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RemarksTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(47, 518)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel14.TabIndex = 29
        Me.MetroLabel14.Text = "Remarks:"
        '
        'ItemClass_Cbox
        '
        Me.ItemClass_Cbox.FormattingEnabled = True
        Me.ItemClass_Cbox.ItemHeight = 23
        Me.ItemClass_Cbox.Items.AddRange(New Object() {"Regular", "Special", "Casual"})
        Me.ItemClass_Cbox.Location = New System.Drawing.Point(110, 476)
        Me.ItemClass_Cbox.Name = "ItemClass_Cbox"
        Me.ItemClass_Cbox.Size = New System.Drawing.Size(233, 29)
        Me.ItemClass_Cbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.ItemClass_Cbox.TabIndex = 28
        Me.ItemClass_Cbox.UseSelectable = True
        Me.ItemClass_Cbox.UseStyleColors = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(23, 481)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel13.TabIndex = 27
        Me.MetroLabel13.Text = "Classification:"
        '
        'ItemPurpose_Cbox
        '
        Me.ItemPurpose_Cbox.FormattingEnabled = True
        Me.ItemPurpose_Cbox.ItemHeight = 23
        Me.ItemPurpose_Cbox.Items.AddRange(New Object() {"Gift", "Raffle"})
        Me.ItemPurpose_Cbox.Location = New System.Drawing.Point(110, 440)
        Me.ItemPurpose_Cbox.Name = "ItemPurpose_Cbox"
        Me.ItemPurpose_Cbox.Size = New System.Drawing.Size(233, 29)
        Me.ItemPurpose_Cbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.ItemPurpose_Cbox.TabIndex = 26
        Me.ItemPurpose_Cbox.UseSelectable = True
        Me.ItemPurpose_Cbox.UseStyleColors = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(19, 446)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(90, 19)
        Me.MetroLabel12.TabIndex = 25
        Me.MetroLabel12.Text = "Item Purpose:"
        '
        'DeliveryQuantityNUpdown
        '
        Me.DeliveryQuantityNUpdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeliveryQuantityNUpdown.Location = New System.Drawing.Point(110, 407)
        Me.DeliveryQuantityNUpdown.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.DeliveryQuantityNUpdown.Name = "DeliveryQuantityNUpdown"
        Me.DeliveryQuantityNUpdown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DeliveryQuantityNUpdown.Size = New System.Drawing.Size(232, 26)
        Me.DeliveryQuantityNUpdown.TabIndex = 24
        Me.DeliveryQuantityNUpdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DeliveryQuantityNUpdown.ThousandsSeparator = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(48, 411)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel11.TabIndex = 23
        Me.MetroLabel11.Text = "Quantity:"
        '
        'PurchasedDate_dtp
        '
        Me.PurchasedDate_dtp.Location = New System.Drawing.Point(318, 371)
        Me.PurchasedDate_dtp.MinimumSize = New System.Drawing.Size(0, 29)
        Me.PurchasedDate_dtp.Name = "PurchasedDate_dtp"
        Me.PurchasedDate_dtp.Size = New System.Drawing.Size(24, 29)
        Me.PurchasedDate_dtp.Style = MetroFramework.MetroColorStyle.Teal
        Me.PurchasedDate_dtp.TabIndex = 22
        '
        'InventoryDGVUpdateItemImage
        '
        Me.InventoryDGVUpdateItemImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InventoryDGVUpdateItemImage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewImageToolStripMenuItem})
        Me.InventoryDGVUpdateItemImage.Name = "InventoryDGVUpdateItemImage"
        Me.InventoryDGVUpdateItemImage.Size = New System.Drawing.Size(136, 26)
        '
        'ViewImageToolStripMenuItem
        '
        Me.ViewImageToolStripMenuItem.Name = "ViewImageToolStripMenuItem"
        Me.ViewImageToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ViewImageToolStripMenuItem.Text = "View Image"
        '
        'InventoryDGVHeaderCmenu
        '
        Me.InventoryDGVHeaderCmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.InventoryDGVHeaderCmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowColumnsToolStripMenuItem})
        Me.InventoryDGVHeaderCmenu.Name = "MetroContextMenu1"
        Me.InventoryDGVHeaderCmenu.Size = New System.Drawing.Size(155, 26)
        '
        'ShowColumnsToolStripMenuItem
        '
        Me.ShowColumnsToolStripMenuItem.Name = "ShowColumnsToolStripMenuItem"
        Me.ShowColumnsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ShowColumnsToolStripMenuItem.Text = "Show Columns"
        '
        'PurchasedDateTbox
        '
        '
        '
        '
        Me.PurchasedDateTbox.CustomButton.Image = Nothing
        Me.PurchasedDateTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.PurchasedDateTbox.CustomButton.Name = ""
        Me.PurchasedDateTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.PurchasedDateTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PurchasedDateTbox.CustomButton.TabIndex = 1
        Me.PurchasedDateTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PurchasedDateTbox.CustomButton.UseSelectable = True
        Me.PurchasedDateTbox.CustomButton.Visible = False
        Me.PurchasedDateTbox.Enabled = False
        Me.PurchasedDateTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.PurchasedDateTbox.ForeColor = System.Drawing.Color.Black
        Me.PurchasedDateTbox.Lines = New String(-1) {}
        Me.PurchasedDateTbox.Location = New System.Drawing.Point(110, 371)
        Me.PurchasedDateTbox.MaxLength = 32767
        Me.PurchasedDateTbox.Name = "PurchasedDateTbox"
        Me.PurchasedDateTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PurchasedDateTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PurchasedDateTbox.SelectedText = ""
        Me.PurchasedDateTbox.SelectionLength = 0
        Me.PurchasedDateTbox.SelectionStart = 0
        Me.PurchasedDateTbox.Size = New System.Drawing.Size(233, 29)
        Me.PurchasedDateTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.PurchasedDateTbox.TabIndex = 21
        Me.PurchasedDateTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.PurchasedDateTbox.UseCustomBackColor = True
        Me.PurchasedDateTbox.UseCustomForeColor = True
        Me.PurchasedDateTbox.UseSelectable = True
        Me.PurchasedDateTbox.UseStyleColors = True
        Me.PurchasedDateTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PurchasedDateTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(6, 377)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel10.TabIndex = 20
        Me.MetroLabel10.Text = "Purchased Date:"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroPanel3)
        Me.MetroPanel1.Controls.Add(Me.MetroPanel2)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(984, 620)
        Me.MetroPanel1.TabIndex = 5
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel3.Controls.Add(Me.SearchInvTbox)
        Me.MetroPanel3.Controls.Add(Me.InventoryDGV)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(359, 0)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(625, 620)
        Me.MetroPanel3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel3.TabIndex = 3
        Me.MetroPanel3.UseStyleColors = True
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'SearchInvTbox
        '
        Me.SearchInvTbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchInvTbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        '
        '
        '
        Me.SearchInvTbox.CustomButton.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchInvTbox.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.SearchInvTbox.CustomButton.Location = New System.Drawing.Point(591, 1)
        Me.SearchInvTbox.CustomButton.Name = ""
        Me.SearchInvTbox.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.SearchInvTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchInvTbox.CustomButton.TabIndex = 1
        Me.SearchInvTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchInvTbox.CustomButton.UseSelectable = True
        Me.SearchInvTbox.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.SearchInvTbox.ForeColor = System.Drawing.Color.Black
        Me.SearchInvTbox.Lines = New String(-1) {}
        Me.SearchInvTbox.Location = New System.Drawing.Point(3, 6)
        Me.SearchInvTbox.MaxLength = 32767
        Me.SearchInvTbox.Name = "SearchInvTbox"
        Me.SearchInvTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchInvTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchInvTbox.SelectedText = ""
        Me.SearchInvTbox.SelectionLength = 0
        Me.SearchInvTbox.SelectionStart = 0
        Me.SearchInvTbox.ShowButton = True
        Me.SearchInvTbox.ShowClearButton = True
        Me.SearchInvTbox.Size = New System.Drawing.Size(617, 27)
        Me.SearchInvTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.SearchInvTbox.TabIndex = 826
        Me.SearchInvTbox.UseCustomForeColor = True
        Me.SearchInvTbox.UseSelectable = True
        Me.SearchInvTbox.WaterMark = "Search Marketing Inventory"
        Me.SearchInvTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchInvTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'InventoryDGV
        '
        Me.InventoryDGV.AllowUserToAddRows = False
        Me.InventoryDGV.AllowUserToDeleteRows = False
        Me.InventoryDGV.AllowUserToOrderColumns = True
        Me.InventoryDGV.AllowUserToResizeRows = False
        Me.InventoryDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InventoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.InventoryDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InventoryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InventoryDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.InventoryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InventoryDGV.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InventoryDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.InventoryDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InventoryDGV.EnableHeadersVisualStyles = False
        Me.InventoryDGV.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.InventoryDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InventoryDGV.Location = New System.Drawing.Point(0, 42)
        Me.InventoryDGV.Name = "InventoryDGV"
        Me.InventoryDGV.ReadOnly = True
        Me.InventoryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InventoryDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.InventoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InventoryDGV.Size = New System.Drawing.Size(623, 576)
        Me.InventoryDGV.Style = MetroFramework.MetroColorStyle.Teal
        Me.InventoryDGV.TabIndex = 7
        Me.InventoryDGV.UseStyleColors = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroPanel2.Controls.Add(Me.PrintQR_btn)
        Me.MetroPanel2.Controls.Add(Me.GenerateQR_btn)
        Me.MetroPanel2.Controls.Add(Me.CategoryUpdate_Btn)
        Me.MetroPanel2.Controls.Add(Me.Reset_Btn)
        Me.MetroPanel2.Controls.Add(Me.DelItemInv_btn)
        Me.MetroPanel2.Controls.Add(Me.EditItemInv_btn)
        Me.MetroPanel2.Controls.Add(Me.SaveItemInv_btn)
        Me.MetroPanel2.Controls.Add(Me.RemarksTbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel14)
        Me.MetroPanel2.Controls.Add(Me.ItemClass_Cbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel2.Controls.Add(Me.ItemPurpose_Cbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel2.Controls.Add(Me.DeliveryQuantityNUpdown)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel2.Controls.Add(Me.PurchasedDate_dtp)
        Me.MetroPanel2.Controls.Add(Me.PurchasedDateTbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel2.Controls.Add(Me.DiscountedPriceTbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel2.Controls.Add(Me.ListPriceTbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel2.Controls.Add(Me.GenPrefCbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel2.Controls.Add(Me.ItemCodeTbox)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel2.Controls.Add(Me.CategoryCbox)
        Me.MetroPanel2.Controls.Add(Me.BrandTbox)
        Me.MetroPanel2.Controls.Add(Me.ItemDesTbox)
        Me.MetroPanel2.Controls.Add(Me.ColorTbox)
        Me.MetroPanel2.Controls.Add(Me.SizeTbox)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(353, 620)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroPanel2.TabIndex = 2
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'DiscountedPriceTbox
        '
        '
        '
        '
        Me.DiscountedPriceTbox.CustomButton.Image = Nothing
        Me.DiscountedPriceTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.DiscountedPriceTbox.CustomButton.Name = ""
        Me.DiscountedPriceTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.DiscountedPriceTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.DiscountedPriceTbox.CustomButton.TabIndex = 1
        Me.DiscountedPriceTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.DiscountedPriceTbox.CustomButton.UseSelectable = True
        Me.DiscountedPriceTbox.CustomButton.Visible = False
        Me.DiscountedPriceTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.DiscountedPriceTbox.ForeColor = System.Drawing.Color.Black
        Me.DiscountedPriceTbox.Lines = New String(-1) {}
        Me.DiscountedPriceTbox.Location = New System.Drawing.Point(110, 335)
        Me.DiscountedPriceTbox.MaxLength = 32767
        Me.DiscountedPriceTbox.Name = "DiscountedPriceTbox"
        Me.DiscountedPriceTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DiscountedPriceTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DiscountedPriceTbox.SelectedText = ""
        Me.DiscountedPriceTbox.SelectionLength = 0
        Me.DiscountedPriceTbox.SelectionStart = 0
        Me.DiscountedPriceTbox.Size = New System.Drawing.Size(233, 29)
        Me.DiscountedPriceTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.DiscountedPriceTbox.TabIndex = 19
        Me.DiscountedPriceTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.DiscountedPriceTbox.UseCustomBackColor = True
        Me.DiscountedPriceTbox.UseCustomForeColor = True
        Me.DiscountedPriceTbox.UseSelectable = True
        Me.DiscountedPriceTbox.UseStyleColors = True
        Me.DiscountedPriceTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.DiscountedPriceTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(4, 332)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(105, 38)
        Me.MetroLabel9.TabIndex = 18
        Me.MetroLabel9.Text = "Purchased Price:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(After Discount)"
        '
        'ListPriceTbox
        '
        '
        '
        '
        Me.ListPriceTbox.CustomButton.Image = Nothing
        Me.ListPriceTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.ListPriceTbox.CustomButton.Name = ""
        Me.ListPriceTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.ListPriceTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ListPriceTbox.CustomButton.TabIndex = 1
        Me.ListPriceTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ListPriceTbox.CustomButton.UseSelectable = True
        Me.ListPriceTbox.CustomButton.Visible = False
        Me.ListPriceTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.ListPriceTbox.ForeColor = System.Drawing.Color.Black
        Me.ListPriceTbox.Lines = New String(-1) {}
        Me.ListPriceTbox.Location = New System.Drawing.Point(110, 299)
        Me.ListPriceTbox.MaxLength = 32767
        Me.ListPriceTbox.Name = "ListPriceTbox"
        Me.ListPriceTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ListPriceTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ListPriceTbox.SelectedText = ""
        Me.ListPriceTbox.SelectionLength = 0
        Me.ListPriceTbox.SelectionStart = 0
        Me.ListPriceTbox.Size = New System.Drawing.Size(233, 29)
        Me.ListPriceTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.ListPriceTbox.TabIndex = 17
        Me.ListPriceTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ListPriceTbox.UseCustomBackColor = True
        Me.ListPriceTbox.UseCustomForeColor = True
        Me.ListPriceTbox.UseSelectable = True
        Me.ListPriceTbox.UseStyleColors = True
        Me.ListPriceTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ListPriceTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(4, 306)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel8.TabIndex = 16
        Me.MetroLabel8.Text = "Purchased Price:"
        '
        'GenPrefCbox
        '
        Me.GenPrefCbox.FormattingEnabled = True
        Me.GenPrefCbox.ItemHeight = 23
        Me.GenPrefCbox.Items.AddRange(New Object() {"Male", "Female", "Unisex"})
        Me.GenPrefCbox.Location = New System.Drawing.Point(110, 263)
        Me.GenPrefCbox.Name = "GenPrefCbox"
        Me.GenPrefCbox.Size = New System.Drawing.Size(233, 29)
        Me.GenPrefCbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.GenPrefCbox.TabIndex = 15
        Me.GenPrefCbox.UseSelectable = True
        Me.GenPrefCbox.UseStyleColors = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(53, 269)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Gender:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(74, 233)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel6.TabIndex = 12
        Me.MetroLabel6.Text = "Size:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(63, 198)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Color:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(6, 164)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "ItemDescription:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(62, 128)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Brand:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(42, 93)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Category:"
        '
        'ItemCodeTbox
        '
        '
        '
        '
        Me.ItemCodeTbox.CustomButton.Image = Nothing
        Me.ItemCodeTbox.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.ItemCodeTbox.CustomButton.Name = ""
        Me.ItemCodeTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.ItemCodeTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ItemCodeTbox.CustomButton.TabIndex = 1
        Me.ItemCodeTbox.CustomButton.Text = "G"
        Me.ItemCodeTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ItemCodeTbox.CustomButton.UseSelectable = True
        Me.ItemCodeTbox.CustomButton.Visible = False
        Me.ItemCodeTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.ItemCodeTbox.ForeColor = System.Drawing.Color.Black
        Me.ItemCodeTbox.Lines = New String(-1) {}
        Me.ItemCodeTbox.Location = New System.Drawing.Point(110, 51)
        Me.ItemCodeTbox.MaxLength = 32767
        Me.ItemCodeTbox.Name = "ItemCodeTbox"
        Me.ItemCodeTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ItemCodeTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ItemCodeTbox.SelectedText = ""
        Me.ItemCodeTbox.SelectionLength = 0
        Me.ItemCodeTbox.SelectionStart = 0
        Me.ItemCodeTbox.Size = New System.Drawing.Size(196, 29)
        Me.ItemCodeTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.ItemCodeTbox.TabIndex = 3
        Me.ItemCodeTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ItemCodeTbox.UseCustomBackColor = True
        Me.ItemCodeTbox.UseCustomForeColor = True
        Me.ItemCodeTbox.UseSelectable = True
        Me.ItemCodeTbox.UseStyleColors = True
        Me.ItemCodeTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ItemCodeTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(35, 56)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Item Code:"
        '
        'CategoryCbox
        '
        Me.CategoryCbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CategoryCbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CategoryCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryCbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CategoryCbox.FormattingEnabled = True
        Me.CategoryCbox.ItemHeight = 20
        Me.CategoryCbox.Location = New System.Drawing.Point(110, 87)
        Me.CategoryCbox.Name = "CategoryCbox"
        Me.CategoryCbox.Size = New System.Drawing.Size(196, 28)
        Me.CategoryCbox.TabIndex = 5
        '
        'BrandTbox
        '
        '
        '
        '
        Me.BrandTbox.CustomButton.Image = Nothing
        Me.BrandTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.BrandTbox.CustomButton.Name = ""
        Me.BrandTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.BrandTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.BrandTbox.CustomButton.TabIndex = 1
        Me.BrandTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.BrandTbox.CustomButton.UseSelectable = True
        Me.BrandTbox.CustomButton.Visible = False
        Me.BrandTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.BrandTbox.ForeColor = System.Drawing.Color.Black
        Me.BrandTbox.Lines = New String(-1) {}
        Me.BrandTbox.Location = New System.Drawing.Point(110, 123)
        Me.BrandTbox.MaxLength = 32767
        Me.BrandTbox.Name = "BrandTbox"
        Me.BrandTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BrandTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.BrandTbox.SelectedText = ""
        Me.BrandTbox.SelectionLength = 0
        Me.BrandTbox.SelectionStart = 0
        Me.BrandTbox.Size = New System.Drawing.Size(233, 29)
        Me.BrandTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.BrandTbox.TabIndex = 7
        Me.BrandTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.BrandTbox.UseCustomBackColor = True
        Me.BrandTbox.UseCustomForeColor = True
        Me.BrandTbox.UseSelectable = True
        Me.BrandTbox.UseStyleColors = True
        Me.BrandTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BrandTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ItemDesTbox
        '
        '
        '
        '
        Me.ItemDesTbox.CustomButton.Image = Nothing
        Me.ItemDesTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.ItemDesTbox.CustomButton.Name = ""
        Me.ItemDesTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.ItemDesTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ItemDesTbox.CustomButton.TabIndex = 1
        Me.ItemDesTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ItemDesTbox.CustomButton.UseSelectable = True
        Me.ItemDesTbox.CustomButton.Visible = False
        Me.ItemDesTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.ItemDesTbox.ForeColor = System.Drawing.Color.Black
        Me.ItemDesTbox.Lines = New String(-1) {}
        Me.ItemDesTbox.Location = New System.Drawing.Point(110, 158)
        Me.ItemDesTbox.MaxLength = 32767
        Me.ItemDesTbox.Name = "ItemDesTbox"
        Me.ItemDesTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ItemDesTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ItemDesTbox.SelectedText = ""
        Me.ItemDesTbox.SelectionLength = 0
        Me.ItemDesTbox.SelectionStart = 0
        Me.ItemDesTbox.Size = New System.Drawing.Size(233, 29)
        Me.ItemDesTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.ItemDesTbox.TabIndex = 9
        Me.ItemDesTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ItemDesTbox.UseCustomBackColor = True
        Me.ItemDesTbox.UseCustomForeColor = True
        Me.ItemDesTbox.UseSelectable = True
        Me.ItemDesTbox.UseStyleColors = True
        Me.ItemDesTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ItemDesTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ColorTbox
        '
        '
        '
        '
        Me.ColorTbox.CustomButton.Image = Nothing
        Me.ColorTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.ColorTbox.CustomButton.Name = ""
        Me.ColorTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.ColorTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ColorTbox.CustomButton.TabIndex = 1
        Me.ColorTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ColorTbox.CustomButton.UseSelectable = True
        Me.ColorTbox.CustomButton.Visible = False
        Me.ColorTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.ColorTbox.ForeColor = System.Drawing.Color.Black
        Me.ColorTbox.Lines = New String(-1) {}
        Me.ColorTbox.Location = New System.Drawing.Point(110, 193)
        Me.ColorTbox.MaxLength = 32767
        Me.ColorTbox.Name = "ColorTbox"
        Me.ColorTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ColorTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ColorTbox.SelectedText = ""
        Me.ColorTbox.SelectionLength = 0
        Me.ColorTbox.SelectionStart = 0
        Me.ColorTbox.Size = New System.Drawing.Size(233, 29)
        Me.ColorTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.ColorTbox.TabIndex = 11
        Me.ColorTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorTbox.UseCustomBackColor = True
        Me.ColorTbox.UseCustomForeColor = True
        Me.ColorTbox.UseSelectable = True
        Me.ColorTbox.UseStyleColors = True
        Me.ColorTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ColorTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'SizeTbox
        '
        '
        '
        '
        Me.SizeTbox.CustomButton.Image = Nothing
        Me.SizeTbox.CustomButton.Location = New System.Drawing.Point(205, 1)
        Me.SizeTbox.CustomButton.Name = ""
        Me.SizeTbox.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.SizeTbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SizeTbox.CustomButton.TabIndex = 1
        Me.SizeTbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SizeTbox.CustomButton.UseSelectable = True
        Me.SizeTbox.CustomButton.Visible = False
        Me.SizeTbox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.SizeTbox.ForeColor = System.Drawing.Color.Black
        Me.SizeTbox.Lines = New String(-1) {}
        Me.SizeTbox.Location = New System.Drawing.Point(110, 228)
        Me.SizeTbox.MaxLength = 32767
        Me.SizeTbox.Name = "SizeTbox"
        Me.SizeTbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SizeTbox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SizeTbox.SelectedText = ""
        Me.SizeTbox.SelectionLength = 0
        Me.SizeTbox.SelectionStart = 0
        Me.SizeTbox.Size = New System.Drawing.Size(233, 29)
        Me.SizeTbox.Style = MetroFramework.MetroColorStyle.Teal
        Me.SizeTbox.TabIndex = 13
        Me.SizeTbox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SizeTbox.UseCustomBackColor = True
        Me.SizeTbox.UseCustomForeColor = True
        Me.SizeTbox.UseSelectable = True
        Me.SizeTbox.UseStyleColors = True
        Me.SizeTbox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SizeTbox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'DontClick_Btn
        '
        Me.DontClick_Btn.BackColor = System.Drawing.Color.Black
        Me.DontClick_Btn.Location = New System.Drawing.Point(20, 25)
        Me.DontClick_Btn.Name = "DontClick_Btn"
        Me.DontClick_Btn.Size = New System.Drawing.Size(99, 29)
        Me.DontClick_Btn.Style = MetroFramework.MetroColorStyle.Teal
        Me.DontClick_Btn.TabIndex = 7
        Me.DontClick_Btn.Text = "Do&n't Click"
        Me.DontClick_Btn.UseCustomBackColor = True
        Me.DontClick_Btn.UseSelectable = True
        Me.DontClick_Btn.UseStyleColors = True
        Me.DontClick_Btn.Visible = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 700)
        Me.Controls.Add(Me.DontClick_Btn)
        Me.Controls.Add(Me.MetroPanel1)
        Me.IsMdiContainer = True
        Me.Name = "Inventory"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DeliveryQuantityNUpdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryDGVUpdateItemImage.ResumeLayout(False)
        Me.InventoryDGVHeaderCmenu.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel3.ResumeLayout(False)
        CType(Me.InventoryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintQR_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents GenerateQR_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents CategoryUpdate_Btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Reset_Btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents DelItemInv_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents EditItemInv_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents SaveItemInv_btn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents RemarksTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ItemClass_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ItemPurpose_Cbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DeliveryQuantityNUpdown As NumericUpDown
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PurchasedDate_dtp As MetroFramework.Controls.MetroDateTime
    Friend WithEvents InventoryDGVUpdateItemImage As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ViewImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryDGVHeaderCmenu As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ShowColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasedDateTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Public WithEvents SearchInvTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents InventoryDGV As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents DiscountedPriceTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ListPriceTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GenPrefCbox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ItemCodeTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents CategoryCbox As ComboBox
    Friend WithEvents DontClick_Btn As MetroFramework.Controls.MetroButton
    Friend WithEvents BrandTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ItemDesTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ColorTbox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents SizeTbox As MetroFramework.Controls.MetroTextBox
End Class
