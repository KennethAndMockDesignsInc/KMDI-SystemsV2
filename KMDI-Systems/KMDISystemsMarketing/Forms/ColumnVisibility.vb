Public Class ColumnVisibility

    Private Sub ItemCode_chk_CheckedChanged(sender As Object, e As EventArgs) Handles ItemCode_chk.CheckedChanged
        If ItemCode_chk.Checked = True Then
            ItemCode_bool = True
        Else
            ItemCode_bool = False
        End If

        Inventory.InventoryDGV.Columns("Item Code").Visible = ItemCode_bool
    End Sub

    Private Sub Category_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Category_chk.CheckedChanged
        If Category_chk.Checked = True Then
            Category_bool = True
        Else
            Category_bool = False
        End If

        Inventory.InventoryDGV.Columns("Category").Visible = Category_bool
    End Sub

    Private Sub ItemDescription_chk_CheckedChanged(sender As Object, e As EventArgs) Handles ItemDescription_chk.CheckedChanged
        If ItemDescription_chk.Checked = True Then
            ItemDescription_bool = True
        Else
            ItemDescription_bool = False
        End If

        Inventory.InventoryDGV.Columns("Item Description").Visible = ItemDescription_bool
    End Sub

    Private Sub Brand_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Brand_chk.CheckedChanged
        If Brand_chk.Checked = True Then
            Brand_bool = True
        Else
            Brand_bool = False
        End If

        Inventory.InventoryDGV.Columns("Brand").Visible = Brand_bool
    End Sub

    Private Sub Color_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Color_chk.CheckedChanged
        If Color_chk.Checked = True Then
            Color_bool = True
        Else
            Color_bool = False
        End If

        Inventory.InventoryDGV.Columns("Color").Visible = Color_bool

    End Sub

    Private Sub Size_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Size_chk.CheckedChanged
        If Size_chk.Checked = True Then
            Size_bool = True
        Else
            Size_bool = False
        End If

        Inventory.InventoryDGV.Columns("Size").Visible = Size_bool

    End Sub

    Private Sub Gender_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Gender_chk.CheckedChanged
        If Gender_chk.Checked = True Then
            Gender_bool = True
        Else
            Gender_bool = False
        End If

        Inventory.InventoryDGV.Columns("Gender Preference").Visible = Gender_bool

    End Sub

    Private Sub PurchasedPrice_chk_CheckedChanged(sender As Object, e As EventArgs) Handles PurchasedPrice_chk.CheckedChanged
        If PurchasedPrice_chk.Checked = True Then
            PurchasedPrice_bool = True
            Inventory.InventoryDGV.Columns("Purchased Price").DefaultCellStyle.Format = "N2"
        Else
            PurchasedPrice_bool = False
        End If

        Inventory.InventoryDGV.Columns("Purchased Price").Visible = PurchasedPrice_bool

    End Sub

    Private Sub DiscountedPrice_chk_CheckedChanged(sender As Object, e As EventArgs) Handles DiscountedPrice_chk.CheckedChanged
        If DiscountedPrice_chk.Checked = True Then
            DiscountedPrice_bool = True
            Inventory.InventoryDGV.Columns("Discounted Price").DefaultCellStyle.Format = "N2"
        Else
            DiscountedPrice_bool = False
        End If

        Inventory.InventoryDGV.Columns("Discounted Price").Visible = DiscountedPrice_bool

    End Sub

    Private Sub Discount_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Discount_chk.CheckedChanged
        If Discount_chk.Checked = True Then
            Discount_bool = True
        Else
            Discount_bool = False
        End If

        Inventory.InventoryDGV.Columns("Discount").Visible = Discount_bool

    End Sub

    Private Sub Quantity_chk_CheckedChanged(sender As Object, e As EventArgs) Handles Quantity_chk.CheckedChanged
        If Quantity_chk.Checked = True Then
            Quantity_bool = True
        Else
            Quantity_bool = False
        End If

        Inventory.InventoryDGV.Columns("Quantity").Visible = Quantity_bool

    End Sub

    Private Sub PurchasedDate_chk_CheckedChanged(sender As Object, e As EventArgs) Handles PurchasedDate_chk.CheckedChanged
        If PurchasedDate_chk.Checked = True Then
            PurchasedDate_bool = True
        Else
            PurchasedDate_bool = False
        End If

        Inventory.InventoryDGV.Columns("Purchased Date").Visible = PurchasedDate_bool

    End Sub

    Private Sub ItemPurpose_chk_CheckedChanged(sender As Object, e As EventArgs) Handles ItemPurpose_chk.CheckedChanged
        If ItemPurpose_chk.Checked = True Then
            ItemPurpose_bool = True
        Else
            ItemPurpose_bool = False
        End If

        Inventory.InventoryDGV.Columns("Item Purpose").Visible = ItemPurpose_bool

    End Sub

    Private Sub ItemClass_chk_CheckedChanged(sender As Object, e As EventArgs) Handles ItemClass_chk.CheckedChanged
        If ItemClass_chk.Checked = True Then
            ItemClass_bool = True
        Else
            ItemClass_bool = False
        End If

        Inventory.InventoryDGV.Columns("Item Classification").Visible = ItemClass_bool

    End Sub

    Private Sub InputtedBy_chk_CheckedChanged(sender As Object, e As EventArgs) Handles InputtedBy_chk.CheckedChanged
        If InputtedBy_chk.Checked = True Then
            InputtedBy_bool = True
        Else
            InputtedBy_bool = False
        End If

        Inventory.InventoryDGV.Columns("Inputted By").Visible = InputtedBy_bool

    End Sub

    Private Sub UpdatedBy_chk_CheckedChanged(sender As Object, e As EventArgs) Handles UpdatedBy_chk.CheckedChanged
        If UpdatedBy_chk.Checked = True Then
            UpdatedBy_bool = True
        Else
            UpdatedBy_bool = False
        End If

        Inventory.InventoryDGV.Columns("Updated By").Visible = UpdatedBy_bool

    End Sub

    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Inventory.Enabled = True
        Inventory.BringToFront()
        Me.Hide()
    End Sub
    Private Sub ColumnVisibility_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Alt And e.KeyCode = Keys.F4 Then

        End If
    End Sub

    Private Sub ColumnVisibility_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub
End Class