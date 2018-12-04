Public Class BackloadSearchFRM

    Private Sub SearchBTN_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click
        SearchTbox.Text = Trim(SearchTbox.Text)
        SearchTbox.Text = SearchTbox.Text.Replace("'", "`")
        If SearchTbox.Text = Nothing Then
            Me.Hide()
            MetroFramework.MetroMessageBox.Show(BackloadUpdateFRM, "No search criteria.", "No criteria where inputted. Please refine search.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Show()
            SearchTbox.Focus()
        Else
            BackloadFRM.SearchString = SearchTbox.Text
            BackloadFRM.ActionTaken = "Search"
            BackloadFRM.StartWorker()
        End If
    End Sub

    Private Sub SearchTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBTN.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Hide()
            BackloadFRM.Focus()
        End If
    End Sub
End Class