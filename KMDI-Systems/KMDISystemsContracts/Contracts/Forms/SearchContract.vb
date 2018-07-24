Public Class SearchContract
    Private Sub SearchContract_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Contracts.Enabled = True
        Contracts.Focus()
    End Sub

    Private Sub FindBtn_Click(sender As Object, e As EventArgs) Handles FindBtn.Click
        'MsgBox(ShowLock_Status)
        Lock_search_string = SearchAllTbox.Text
        ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(Lock_search_string, ShowLock_Status)
        Me.Close()
    End Sub

End Class