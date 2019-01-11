Imports System.IO

Public Class Inventory
    Dim sql As sql
    Public ItemRefNo, ItemCode, ItemCategory, ItemBrand, ItemDes, PurchasedDate,
        ItemColor, ItemSize, GenPref, ItemPurpose, ItemClass, Remarks, ITEM_IMAGE As String
    Public ListPrice, DiscountedPrice, DeliveryQuantity As Decimal

    Public QRCode As String

    Dim QRImage As Image

    Dim if_Generated_QR_Status As Boolean = False
    Sub QRCodeAutoGenerate()
        '5 6 _ _ _ _ _   _ _   _ _ _ _
        'K M 0 0 0 0 1   1 2   M M Y Y
        '    ItemCodes   UID   MMYY NOW
        MARKETING_INVENTORY_V2_QRCodeGeneration()
        If maxMI_AUTONUMBER <> "" Then
            maxMI_AUTONUMBER += 1
            Dim MICount As Integer = maxMI_AUTONUMBER.Count
            Dim ZEROES As String = Nothing

            For i = MICount + 1 To 5
                ZEROES += "0"
            Next

            QRCode = "56" & ZEROES & maxMI_AUTONUMBER & KMDISystemsGlobalModule.AccountAutonum & Now.ToString("MMyy")

            ItemCodeTbox.Text = QRCode
            ItemCodeTbox.Enabled = False
            CategoryCbox.Focus()
        Else
            QRCode = "56" & "00001" & KMDISystemsGlobalModule.AccountAutonum & Now.ToString("MMyy")
            ItemCodeTbox.Text = QRCode
            ItemCodeTbox.Enabled = False
            CategoryCbox.Focus()
        End If
        if_Generated_QR_Status = True
    End Sub

    Sub clear()
        MARKETING_INVENTORY_V2_READ_SEARCH("", True)
        ItemRefNo = Nothing
        ItemCodeTbox.Text = Nothing
        CategoryCbox.Text = Nothing
        BrandTbox.Text = Nothing
        ItemDesTbox.Text = Nothing
        ColorTbox.Text = Nothing
        SizeTbox.Text = Nothing
        GenPrefCbox.SelectedIndex = -1
        DeliveryQuantityNUpdown.Text = "0"
        ListPriceTbox.Text = "0.00"
        DiscountedPriceTbox.Text = "0.00"
        PurchasedDateTbox.Text = Date.Today.ToString("MM-dd-yyyy")
        DeliveryQuantityNUpdown.Text = "0.00"
        RemarksTbox.Text = Nothing
        ItemCodeTbox.Enabled = True
        ItemCodeTbox.Focus()
        if_Generated_QR_Status = False
    End Sub

    Sub ColumnHeaders_Visibility()
        ItemCode_bool = True
        Category_bool = True
        ItemDescription_bool = True
        Brand_bool = False
        Color_bool = False
        Size_bool = False
        Gender_bool = False
        PurchasedPrice_bool = True
        DiscountedPrice_bool = True
        Discount_bool = False
        Quantity_bool = True
        PurchasedDate_bool = False
        ItemPurpose_bool = False
        ItemClass_bool = False
        InputtedBy_bool = True
        UpdatedBy_bool = True

        InventoryDGV.Columns("MI_AUTONUMBER").Visible = False
        InventoryDGV.Columns("Item Code").Visible = ItemCode_bool
        InventoryDGV.Columns("Category").Visible = Category_bool
        InventoryDGV.Columns("Item Description").Visible = ItemDescription_bool
        InventoryDGV.Columns("Purchased Price").Visible = PurchasedDate_bool
        InventoryDGV.Columns("Purchased Price").DefaultCellStyle.Format = "N2"
        InventoryDGV.Columns("Discounted Price").Visible = DiscountedPrice_bool
        InventoryDGV.Columns("Discounted Price").DefaultCellStyle.Format = "N2"
        InventoryDGV.Columns("Quantity").Visible = Quantity_bool
        InventoryDGV.Columns("Inputted By").Visible = InputtedBy_bool
        InventoryDGV.Columns("Updated By").Visible = UpdatedBy_bool

        InventoryDGV.Columns("Brand").Visible = Brand_bool
        InventoryDGV.Columns("Color").Visible = Color_bool
        InventoryDGV.Columns("Size").Visible = Size_bool
        InventoryDGV.Columns("Gender Preference").Visible = Gender_bool
        InventoryDGV.Columns("Discount").Visible = Discount_bool
        InventoryDGV.Columns("Purchased Date").Visible = PurchasedDate_bool
        InventoryDGV.Columns("Item Purpose").Visible = ItemPurpose_bool
        InventoryDGV.Columns("Item Classification").Visible = ItemClass_bool
        InventoryDGV.Columns("ITEM_IMAGE").Visible = False


    End Sub

    Sub purchaseddate_()
        Dim Datepick As DateTime
        Datepick = PurchasedDate_dtp.Text
        Dim x As String = Datepick.ToString("MM-dd-yyyy")
        PurchasedDateTbox.Text = x
    End Sub

    Private Sub DiscountedPriceTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles DiscountedPriceTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PurchasedDate_dtp.Focus()
        End If
    End Sub

    Private Sub CategoryCbox_KeyDown(sender As Object, e As KeyEventArgs) Handles CategoryCbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            BrandTbox.Focus()
        End If
    End Sub

    Private Sub BrandTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles BrandTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ItemDesTbox.Focus()
        End If
    End Sub

    Private Sub ItemDesTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemDesTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ColorTbox.Focus()
        End If
    End Sub

    Private Sub ColorTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ColorTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SizeTbox.Focus()
        End If
    End Sub

    Private Sub SizeTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SizeTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenPrefCbox.Focus()
        End If
    End Sub

    Private Sub GenPrefCbox_KeyDown(sender As Object, e As KeyEventArgs) Handles GenPrefCbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListPriceTbox.Focus()
        End If
    End Sub

    Private Sub ListPriceTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ListPriceTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountedPriceTbox.Focus()
        End If
    End Sub

    Private Sub PurchasedDate_dtp_Enter(sender As Object, e As EventArgs) Handles PurchasedDate_dtp.Enter
        purchaseddate_()
    End Sub

    Private Sub PurchasedDate_dtp_KeyDown(sender As Object, e As KeyEventArgs) Handles PurchasedDate_dtp.KeyDown
        If e.KeyCode = Keys.Enter Then
            DeliveryQuantityNUpdown.Focus()
        End If
    End Sub

    Private Sub PurchasedDate_dtp_Leave(sender As Object, e As EventArgs) Handles PurchasedDate_dtp.Leave
        purchaseddate_()
    End Sub

    Private Sub PurchasedDate_dtp_ValueChanged(sender As Object, e As EventArgs) Handles PurchasedDate_dtp.ValueChanged
        purchaseddate_()
    End Sub

    Private Sub DeliveryQuantityNUpdown_KeyDown(sender As Object, e As KeyEventArgs) Handles DeliveryQuantityNUpdown.KeyDown
        If e.KeyCode = Keys.Enter Then
            ItemPurpose_Cbox.Focus()
        End If
    End Sub

    Private Sub ItemPurpose_Cbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemPurpose_Cbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ItemClass_Cbox.Focus()
        End If
    End Sub

    Private Sub ItemClass_Cbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemClass_Cbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            RemarksTbox.Focus()
        End If
    End Sub

    Private Sub Reset_Btn_Click(sender As Object, e As EventArgs) Handles Reset_Btn.Click
        clear()
    End Sub

    Private Sub ItemCodeTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles ItemCodeTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            MARKETING_INVENTORY_V2_SearchForDuplicateEntry(ItemCodeTbox.Text)

            If MARKETING_INVENTORY_V2_HasDuplicateEntry_bool = False Then

                CategoryCbox.Focus()
                ItemCodeTbox.Enabled = False
            Else
                ItemCodeTbox.Clear()
                ItemCodeTbox.Focus()
            End If
        End If
    End Sub

    Private Sub ListPriceTbox_TextChanged(sender As Object, e As EventArgs) Handles ListPriceTbox.TextChanged
        Try
            If ListPriceTbox.Text = "" Then
                ListPriceTbox.Text = 0.00
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DiscountedPriceTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DiscountedPriceTbox.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub DiscountedPriceTbox_Leave(sender As Object, e As EventArgs) Handles DiscountedPriceTbox.Leave
        Try
            DiscountedPrice = DiscountedPriceTbox.Text

            If DiscountedPrice > ListPrice Then
                DiscountedPriceTbox.Text = ListPrice
                DiscountedPriceTbox.Text = DiscountedPrice.ToString("N2")
            Else
                DiscountedPriceTbox.Text = DiscountedPrice.ToString("N2")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub SaveItemInv_btn_Click(sender As Object, e As EventArgs) Handles SaveItemInv_btn.Click

        ItemCodeTbox.Text = Trim(ItemCodeTbox.Text)
        CategoryCbox.Text = Trim(CategoryCbox.Text)
        ItemDesTbox.Text = Trim(ItemDesTbox.Text)
        ColorTbox.Text = Trim(ColorTbox.Text)
        SizeTbox.Text = Trim(SizeTbox.Text)
        RemarksTbox.Text = Trim(RemarksTbox.Text)


        Try
            If ItemCodeTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Item Code cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If CategoryCbox.Text = Nothing Then
                    MetroFramework.MetroMessageBox.Show(Me, "Category cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If BrandTbox.Text = Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, "Brand cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        If ItemDesTbox.Text = Nothing Then
                            MetroFramework.MetroMessageBox.Show(Me, "Item Description cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If ListPriceTbox.Text = "0" Or DiscountedPriceTbox.Text = "0" Or
                                ListPriceTbox.Text = "0.00" Or DiscountedPriceTbox.Text = "0.00" Then
                                MetroFramework.MetroMessageBox.Show(Me, "Purchased Price Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                MARKETING_INVENTORY_V2_SearchForDuplicateEntry(ItemCodeTbox.Text)

                                If MARKETING_INVENTORY_V2_HasDuplicateEntry_bool = False Then
                                    If MetroFramework.MetroMessageBox.Show(Me, "Do you want to add this record?", "Entry Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                                        Dim EffectiveDiscount As Decimal = 0
                                        EffectiveDiscount = (1 - (DiscountedPriceTbox.Text / ListPriceTbox.Text)) * 100

                                        MARKETING_INVENTORY_V2_SaveInventoryItem(ItemCodeTbox.Text, CategoryCbox.Text, BrandTbox.Text,
                                                             ItemDesTbox.Text, ColorTbox.Text, SizeTbox.Text,
                                                             GenPrefCbox.Text, ListPriceTbox.Text, DiscountedPriceTbox.Text,
                                                             EffectiveDiscount, DeliveryQuantityNUpdown.Value, PurchasedDateTbox.Text,
                                                             ItemPurpose_Cbox.Text, ItemClass_Cbox.Text, DeliveryQuantityNUpdown.Value,
                                                             RemarksTbox.Text, LoginModule.nickname + " " + Today.Date.ToString("MMM d, yyyy") + " " + TimeOfDay,
                                                             CategoryCbox.Text, if_Generated_QR_Status)

                                        If MARKETING_INVENTORY_V2_CountSucess >= 1 Then
                                            'IF saving is success then.
                                            MetroFramework.MetroMessageBox.Show(Me, "Record added successfully.", "Add Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            clear()
                                        Else

                                        End If


                                    End If
                                Else

                                End If
                            End If

                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditItemInv_btn_Click(sender As Object, e As EventArgs) Handles EditItemInv_btn.Click

        If ItemRefNo = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select item to Update first", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            ItemCodeTbox.Text = Trim(ItemCodeTbox.Text)
            ItemDesTbox.Text = Trim(ItemDesTbox.Text)
            ColorTbox.Text = Trim(ColorTbox.Text)
            SizeTbox.Text = Trim(SizeTbox.Text)
            RemarksTbox.Text = Trim(RemarksTbox.Text)

            If ItemCodeTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Item Code cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If CategoryCbox.Text = Nothing Then
                    MetroFramework.MetroMessageBox.Show(Me, "Category cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If BrandTbox.Text = Nothing Then
                        MetroFramework.MetroMessageBox.Show(Me, "Brand cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else

                        If ItemDesTbox.Text = Nothing Then
                            MetroFramework.MetroMessageBox.Show(Me, "Item Description cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If ListPriceTbox.Text = "0" Or DiscountedPriceTbox.Text = "0" Or
                                ListPriceTbox.Text = "0.00" Or DiscountedPriceTbox.Text = "0.00" Then
                                MetroFramework.MetroMessageBox.Show(Me, "Purchased Price Fields cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                Dim EffectiveDiscount As Decimal
                                EffectiveDiscount = (1 - (ListPriceTbox.Text / DiscountedPriceTbox.Text)) * 100


                                If ItemCode <> ItemCodeTbox.Text Then
                                    MetroFramework.MetroMessageBox.Show(Me, "Item Code cannot be change", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                                ElseIf ItemCode = ItemCodeTbox.Text Then

                                    Try
                                        MARKETING_INVENTORY_V2_EditInventoryItem(ItemRefNo, CategoryCbox.Text, BrandTbox.Text,
                                                                                 ItemDesTbox.Text, ColorTbox.Text, SizeTbox.Text,
                                                                                 GenPrefCbox.Text, ListPriceTbox.Text, DiscountedPriceTbox.Text,
                                                                                 EffectiveDiscount, DeliveryQuantityNUpdown.Value, PurchasedDateTbox.Text,
                                                                                 ItemPurpose_Cbox.Text, ItemClass_Cbox.Text, DeliveryQuantityNUpdown.Value, RemarksTbox.Text, LoginModule.nickname + " " + Today.Date.ToString("MMM d, yyyy") + " " + TimeOfDay,
                                                                                 if_Generated_QR_Status)
                                        If MARKETING_INVENTORY_V2_CountSucess >= 1 Then
                                            clear()
                                            MetroFramework.MetroMessageBox.Show(Me, "Record updated successfully.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Else

                                        End If
                                    Catch ex As Exception
                                        MsgBox(ex.ToString)
                                    End Try

                                End If

                            End If
                        End If
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub ViewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImageToolStripMenuItem.Click
        Me.Enabled = False

        'If ITEM_IMAGE = "" Or ITEM_IMAGE = Nothing Then
        '    ViewInventoryImage.InventoryImage_Pbox.Image = WindowsApplication7.My.Resources.ImageSelected
        'Else
        '    ViewInventoryImage.InventoryImage_Pbox.ImageLocation = ITEM_IMAGE
        'End If

        ViewInventoryImage.Show()
    End Sub

    Private Sub SearchInvTbox_ButtonClick(sender As Object, e As EventArgs) Handles SearchInvTbox.ButtonClick
        MARKETING_INVENTORY_V2_READ_SEARCH(SearchInvTbox.Text, True)
    End Sub

    Private Sub SearchInvTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchInvTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            MARKETING_INVENTORY_V2_READ_SEARCH(SearchInvTbox.Text, True)
        ElseIf e.KeyCode = Keys.F10 Then
            AdminConfirmation.Show()
        End If
    End Sub

    Private Sub DiscountedPriceTbox_TextChanged(sender As Object, e As EventArgs) Handles DiscountedPriceTbox.TextChanged
        Try
            If DiscountedPriceTbox.Text = "" Then
                DiscountedPriceTbox.Text = 0.00
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub InventoryDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles InventoryDGV.CellFormatting
        Try

            If InventoryDGV.RowCount >= 0 And e.RowIndex >= 0 Then
                For i As Integer = 0 To InventoryDGV.Rows.Count - 1
                    Dim _Status As Integer = InventoryDGV.Rows(i).Cells("Quantity").Value
                    If _Status <= 10 Then
                        InventoryDGV.Rows(i).DefaultCellStyle.ForeColor = Color.IndianRed
                    Else
                        InventoryDGV.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    End If
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CategoryUpdate_Btn_Click(sender As Object, e As EventArgs) Handles CategoryUpdate_Btn.Click
        Me.Enabled = False
        Category_Update.Show()
    End Sub

    Private Sub InventoryDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles InventoryDGV.RowEnter
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then

            If InventoryDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                ItemRefNo = InventoryDGV.Item("MI_AUTONUMBER", e.RowIndex).Value.ToString
                ItemCode = InventoryDGV.Item("Item Code", e.RowIndex).Value.ToString
                ItemCategory = InventoryDGV.Item("Category", e.RowIndex).Value.ToString
                ItemBrand = InventoryDGV.Item("Brand", e.RowIndex).Value.ToString
                ItemDes = InventoryDGV.Item("Item Description", e.RowIndex).Value.ToString
                ItemColor = InventoryDGV.Item("Color", e.RowIndex).Value.ToString
                ItemSize = InventoryDGV.Item("Size", e.RowIndex).Value.ToString
                GenPref = InventoryDGV.Item("Gender Preference", e.RowIndex).Value.ToString
                DeliveryQuantity = InventoryDGV.Item("Quantity", e.RowIndex).Value.ToString
                ListPrice = InventoryDGV.Item("Purchased Price", e.RowIndex).Value.ToString
                DiscountedPrice = InventoryDGV.Item("Discounted Price", e.RowIndex).Value.ToString
                PurchasedDate = InventoryDGV.Item("Purchased Date", e.RowIndex).Value
                ItemPurpose = InventoryDGV.Item("Item Purpose", e.RowIndex).Value.ToString
                ItemClass = InventoryDGV.Item("Item Classification", e.RowIndex).Value.ToString
                Remarks = InventoryDGV.Item("Remarks", e.RowIndex).Value.ToString
                ITEM_IMAGE = InventoryDGV.Item("ITEM_IMAGE", e.RowIndex).Value.ToString

                ItemCodeTbox.Enabled = False
                'ItemDesTbox.Focus()
                ItemCodeTbox.Text = ItemCode
                CategoryCbox.Text = ItemCategory
                BrandTbox.Text = ItemBrand
                ItemDesTbox.Text = ItemDes
                ListPriceTbox.Text = ListPrice.ToString("N2")
                DiscountedPriceTbox.Text = DiscountedPrice.ToString("N2")
                ColorTbox.Text = ItemColor
                SizeTbox.Text = ItemSize
                GenPrefCbox.Text = GenPref
                DeliveryQuantityNUpdown.Text = DeliveryQuantity
                PurchasedDateTbox.Text = PurchasedDate
                ItemPurpose_Cbox.Text = ItemPurpose
                ItemClass_Cbox.Text = ItemClass
                RemarksTbox.Text = Remarks
            End If
        End If
    End Sub

    Private Sub GenerateQR_btn_Click(sender As Object, e As EventArgs) Handles GenerateQR_btn.Click
        QRCodeAutoGenerate()
    End Sub

    Private Sub PrintQR_btn_Click(sender As Object, e As EventArgs) Handles PrintQR_btn.Click
        MARKETING_INVENTORY_V2_QRCODES_PRINT()
        Print_QRCodes.Show()
    End Sub

    Private Sub DontClick_Btn_Click(sender As Object, e As EventArgs) Handles DontClick_Btn.Click
        IfDeletedInventoryisOpen_bool = True
        DeletedInventory.Show()
    End Sub

    Private Sub DelItemInv_btn_Click(sender As Object, e As EventArgs) Handles DelItemInv_btn.Click
        If ItemRefNo = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select record to DELETE", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "Do you want to delete this record? NOTE! This action cannot be undone.", "Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MARKETING_INVENTORY_V2_DeleteInventoryItem(ItemRefNo, "Delete", False)
                If MARKETING_INVENTORY_V2_DBMaintenance_bool = True Then
                    clear()
                Else

                End If
            End If
        End If
    End Sub

    Private Sub InventoryDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InventoryDGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            If e.Button = MouseButtons.Right Then
                InventoryDGV.Rows(e.RowIndex).Selected = True
                Dim r As New Rectangle
                r = InventoryDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                InventoryDGVUpdateItemImage.Show()
                InventoryDGVUpdateItemImage.Location = New Point(MousePosition.X, MousePosition.Y)
            End If

            If InventoryDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                ItemRefNo = InventoryDGV.Item("MI_AUTONUMBER", e.RowIndex).Value.ToString
                ItemCode = InventoryDGV.Item("Item Code", e.RowIndex).Value.ToString
                ItemCategory = InventoryDGV.Item("Category", e.RowIndex).Value.ToString
                ItemBrand = InventoryDGV.Item("Brand", e.RowIndex).Value.ToString
                ItemDes = InventoryDGV.Item("Item Description", e.RowIndex).Value.ToString
                ItemColor = InventoryDGV.Item("Color", e.RowIndex).Value.ToString
                ItemSize = InventoryDGV.Item("Size", e.RowIndex).Value.ToString
                GenPref = InventoryDGV.Item("Gender Preference", e.RowIndex).Value.ToString
                DeliveryQuantity = InventoryDGV.Item("Quantity", e.RowIndex).Value.ToString
                ListPrice = InventoryDGV.Item("Purchased Price", e.RowIndex).Value.ToString
                DiscountedPrice = InventoryDGV.Item("Discounted Price", e.RowIndex).Value.ToString
                PurchasedDate = InventoryDGV.Item("Purchased Date", e.RowIndex).Value
                ItemPurpose = InventoryDGV.Item("Item Purpose", e.RowIndex).Value.ToString
                ItemClass = InventoryDGV.Item("Item Classification", e.RowIndex).Value.ToString
                Remarks = InventoryDGV.Item("Remarks", e.RowIndex).Value.ToString
                ITEM_IMAGE = InventoryDGV.Item("ITEM_IMAGE", e.RowIndex).Value.ToString

                ItemCodeTbox.Enabled = False
                'ItemDesTbox.Focus()
                ItemCodeTbox.Text = ItemCode
                CategoryCbox.Text = ItemCategory
                BrandTbox.Text = ItemBrand
                ItemDesTbox.Text = ItemDes
                ListPriceTbox.Text = ListPrice.ToString("N2")
                DiscountedPriceTbox.Text = DiscountedPrice.ToString("N2")
                ColorTbox.Text = ItemColor
                SizeTbox.Text = ItemSize
                GenPrefCbox.Text = GenPref
                DeliveryQuantityNUpdown.Text = DeliveryQuantity
                PurchasedDateTbox.Text = PurchasedDate
                ItemPurpose_Cbox.Text = ItemPurpose
                ItemClass_Cbox.Text = ItemClass
                RemarksTbox.Text = Remarks
            End If
        End If
    End Sub

    Private Sub ListPriceTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListPriceTbox.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub ListPriceTbox_Leave(sender As Object, e As EventArgs) Handles ListPriceTbox.Leave
        Try
            ListPrice = ListPriceTbox.Text

            If ListPrice < DiscountedPrice Then
                ListPriceTbox.Text = DiscountedPrice
                ListPriceTbox.Text = ListPrice.ToString("N2")
            Else
                ListPriceTbox.Text = ListPrice.ToString("N2")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub CategoryCbox_Enter(sender As Object, e As EventArgs) Handles CategoryCbox.Enter
        MarketingCategory()
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        ColumnHeaders_Visibility()
        MarketingCategory()
    End Sub

    Private Sub InventoryDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles InventoryDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub InventoryDGV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles InventoryDGV.ColumnHeaderMouseClick
        If e.Button = MouseButtons.Right Then
            InventoryDGVHeaderCmenu.Show()
            InventoryDGVHeaderCmenu.Location = New Point(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub ShowColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowColumnsToolStripMenuItem.Click
        ColumnVisibility.Show()
        Me.Enabled = False
    End Sub

    Private Sub Inventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to QUIT?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
            If Application.OpenForms().OfType(Of ColumnVisibility).Any Then
                ColumnVisibility.Close()
            End If
        Else
            e.Cancel = True
        End If
    End Sub
End Class