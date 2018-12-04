Public Class DeletedInventory
    Dim ItemRefNo As String
    Private Sub DeletedInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MARKETING_INVENTORY_V2_READ_SEARCH("", False)
    End Sub

    Private Sub DeletedInventory_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        IfDeletedInventoryisOpen_bool = False
        Inventory.clear()
    End Sub

    Private Sub DeletedInventoryDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DeletedInventoryDGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            If e.Button = MouseButtons.Right Then
                DeletedInventoryDGV.Rows(e.RowIndex).Selected = True
                Dim r As New Rectangle
                r = DeletedInventoryDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                AdminsContextMenu.Show()
                AdminsContextMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If

            If DeletedInventoryDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                ItemRefNo = DeletedInventoryDGV.Item("MI_AUTONUMBER", e.RowIndex).Value.ToString

            End If
        End If
    End Sub

    Private Sub ReviveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReviveToolStripMenuItem.Click
        If ItemRefNo = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select record to REVIVE", "REVIVE Record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            MARKETING_INVENTORY_V2_DeleteInventoryItem(ItemRefNo, "REVIVE", True)
            If MARKETING_INVENTORY_V2_DBMaintenance_bool = True Then
                MARKETING_INVENTORY_V2_READ_SEARCH("", False)
            End If

        End If
    End Sub

    Private Sub SearchInvTbox_ButtonClick(sender As Object, e As EventArgs) Handles SearchInvTbox.ButtonClick
        MARKETING_INVENTORY_V2_READ_SEARCH(SearchInvTbox.Text, False)
    End Sub

    Private Sub SearchInvTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchInvTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            MARKETING_INVENTORY_V2_READ_SEARCH(SearchInvTbox.Text, False)
        End If
    End Sub

End Class