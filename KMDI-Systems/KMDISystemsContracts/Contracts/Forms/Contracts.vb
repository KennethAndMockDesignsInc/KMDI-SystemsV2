Public Class Contracts
    Private Sub Contracts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts("", "0")

    End Sub

    Private Sub ContractsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ContractsDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub ContractsDGV_KeyDown(sender As Object, e As KeyEventArgs) Handles ContractsDGV.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Enabled = False
            SearchContract.Show()
        End If
    End Sub

    Private Sub Contracts_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Me.Enabled = False
            SearchContract.Show()
        End If
    End Sub

    Private Sub ContractsDGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ContractsDGV.CellFormatting
        For i = 0 To ContractsDGV.Rows.Count - 1
            Dim LOCK As String = ContractsDGV.Rows(i).Cells("LOCK").Value.ToString

            If LOCK = "1" Then
                ContractsDGV.Rows(i).DefaultCellStyle.BackColor = Color.Gray
            Else
                ContractsDGV.Rows(i).DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub LockedContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockedContractsToolStripMenuItem.Click
        If LockedContractsToolStripMenuItem.Checked = True Then
            ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(Lock_search_string, "")
        Else
            ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts(Lock_search_string, "0")
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ADDENDUM_TO_CONTRACT_TB_SEARCH_FOR_Contracts("", "0")
        Lock_search_string = ""
    End Sub

    Private Sub ContractsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractsDGV.CellMouseClick
        If e.Button = MouseButtons.Right Then
            ViewLockedContracts.Show()

            ViewLockedContracts.Location = New Point(MousePosition.X, MousePosition.Y)

        End If

    End Sub
End Class