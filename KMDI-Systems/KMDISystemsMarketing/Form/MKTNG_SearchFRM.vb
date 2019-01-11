Public Class MKTNG_SearchFRM
    Private Sub MKTNG_SearchFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchTbox.Select()
        SearchTbox.Focus()
    End Sub

    Private Sub MKTNG_SearchFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, SearchTbox.KeyDown, SearchBTN.KeyDown
        If e.KeyCode = Keys.Escape Then
            MKTNG_Inventory.BringToFront()
            Me.Close()
        End If
    End Sub

    Private Sub SearchBTN_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click
        Mktng_SearchStr = SearchTbox.Text
        MKTNG_Inventory.MktngInv_TODO = "Search"
        MKTNG_Inventory.Start_MktngInventoryBGW()
    End Sub
End Class