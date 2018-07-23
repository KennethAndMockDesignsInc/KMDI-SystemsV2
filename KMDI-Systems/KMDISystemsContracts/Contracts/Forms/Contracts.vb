Public Class Contracts
    Private Sub Contracts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub Contracts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ADDENDUM_TO_CONTRACT_TB_READ_FOR_Contracts()
    End Sub

    Private Sub ContractsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ContractsDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub
End Class