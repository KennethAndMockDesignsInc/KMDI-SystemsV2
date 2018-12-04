Public Class Category_Update
    Public CategoryKey, Category_Name, Category_Code As String

    Private Sub Category_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CATEGORYUPDATE_READ()
        CategoryCodeCbox.SelectedIndex = 0
    End Sub

    Private Sub CategoryDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles CategoryDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click

        CategoryTbox.Text = Trim(CategoryTbox.Text)

        CATEGORYUPDATE_AddCategory(CategoryTbox.Text, CategoryCodeCbox.Text)

        If MARKETING_INVENTORY_V2_DBMaintenance_bool = True Then
            CategoryTbox.Clear()
            CATEGORYUPDATE_READ()
        End If
    End Sub

    Private Sub Update_Btn_Click(sender As Object, e As EventArgs) Handles Update_Btn.Click
        CategoryTbox.Text = Trim(CategoryTbox.Text)
        CATEGORYUPDATE_UpdateCategory(CategoryTbox.Text, CategoryCodeCbox.Text, CategoryKey)
        If MARKETING_INVENTORY_V2_DBMaintenance_bool = True Then
            CategoryTbox.Clear()
            CATEGORYUPDATE_READ()
        End If
    End Sub

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click
        If CategoryKey = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select record to DELETE", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "Do you want to delete this record? NOTE! This action cannot be undone.", "Deletion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                CATEGORYUPDATE_DeleteCategory(CategoryKey)
                If MARKETING_INVENTORY_V2_DBMaintenance_bool = True Then
                    CategoryTbox.Clear()
                    CATEGORYUPDATE_READ()
                End If
            End If
        End If
    End Sub

    Private Sub Category_Update_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Inventory.Enabled = True
    End Sub

    Private Sub CategoryDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CategoryDGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then

            If CategoryDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                CategoryKey = CategoryDGV.Item("CategoryKey", e.RowIndex).Value.ToString
                Category_Name = CategoryDGV.Item("Category Name", e.RowIndex).Value.ToString
                Category_Code = CategoryDGV.Item("Category Code", e.RowIndex).Value.ToString

                CategoryCodeCbox.Text = Category_Code
                CategoryTbox.Text = Category_Name
            End If
        End If
    End Sub
End Class