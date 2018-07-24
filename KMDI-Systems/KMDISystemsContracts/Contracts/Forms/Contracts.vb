Public Class Contracts
    Private Sub Contracts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowLock_Status = "0"
        ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts("", ShowLock_Status)
    End Sub

    Private Sub ContractsDGV_KeyDown(sender As Object, e As KeyEventArgs) Handles ContractsDGV.KeyDown
        Objects_Keydown(sender, e)
    End Sub

    Private Sub Contracts_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Objects_Keydown(sender, e)
    End Sub
    Private Sub LockedContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockedContractsToolStripMenuItem.Click
        If LockedContractsToolStripMenuItem.Checked = True Then
            ShowLock_Status = ""
            ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(Lock_search_string, ShowLock_Status)
        Else
            ShowLock_Status = "0"
            ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(Lock_search_string, ShowLock_Status)
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ShowLock_Status = "0"
        Lock_search_string = ""
        ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(Lock_search_string, ShowLock_Status)
        LockedContractsToolStripMenuItem.Checked = False
    End Sub

    Private Sub ContractsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractsDGV.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ViewLockedContracts.Show()

            ViewLockedContracts.Location = New Point(MousePosition.X, MousePosition.Y)


        End If

    End Sub

    Private Sub ContractsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ContractsDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub ContractsDGV_Panel_KeyDown(sender As Object, e As KeyEventArgs) Handles ContractsDGV_Panel.KeyDown
        Objects_Keydown(sender, e)
    End Sub

    Public Sub Objects_Keydown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            SearchContract.Show()
        End If

        If e.KeyCode = Keys.F5 Then
            ResetToolStripMenuItem_Click(sender, e)
            LockedContractsToolStripMenuItem.Checked = False
        End If
    End Sub

End Class