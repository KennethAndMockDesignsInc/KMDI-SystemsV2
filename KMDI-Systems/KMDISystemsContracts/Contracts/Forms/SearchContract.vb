Public Class SearchContract
    Private Sub SearchContract_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Contracts.Enabled = True
    End Sub

    Private Sub FindBtn_Click(sender As Object, e As EventArgs) Handles FindBtn.Click
        Lock_search_string = SearchAllTbox.Text
        ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(SearchAllTbox.Text, "0")
        Me.Close()
        Contracts.Enabled = True
    End Sub
End Class