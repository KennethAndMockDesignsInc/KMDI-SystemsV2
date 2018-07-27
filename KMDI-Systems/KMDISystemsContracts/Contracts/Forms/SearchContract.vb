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

    Private Sub FindBtn_KeyDown(sender As Object, e As KeyEventArgs) Handles FindBtn.KeyDown
        Escape_Keydown(sender, e)
    End Sub

    Public Sub Escape_Keydown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub SearchAllTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchAllTbox.KeyDown
        Escape_Keydown(sender, e)
    End Sub

    Private Sub SearchContract_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Escape_Keydown(sender, e)
    End Sub

    Private Sub SearchContract_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        SearchAllTbox.Focus()
    End Sub
End Class