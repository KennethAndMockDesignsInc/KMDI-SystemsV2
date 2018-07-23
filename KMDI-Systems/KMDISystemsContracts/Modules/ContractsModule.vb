Imports System.Data.SqlClient

Module ContractsModule

    Public Sub ADDENDUM_TO_CONTRACT_TB_READ_FOR_Contracts() 'ByVal UserAcctAutonum As String)
        Try
            Dim sqlDataAdapter As New SqlDataAdapter
            Dim sqlDataSet As New DataSet
            Dim sqlBindingSource As New BindingSource

            sqlConnection.Close()
            sqlConnection.Open()

            sqlDataSet.Clear()
            Query = "SELECT TOP 100 *
                     FROM [KMDIDATA].[dbo].[ADDENDUM_TO_CONTRACT_TB]"
            sqlCommand = New SqlCommand(Query, sqlConnection)
            'sqlCommand.Parameters.AddWithValue("@UserAcctAutonum", UserAcctAutonum)

            sqlDataAdapter.SelectCommand = sqlCommand
            sqlDataAdapter.Fill(sqlDataSet, "KMDI_ACCT_ACCESS_TB")
            sqlBindingSource.DataSource = sqlDataSet
            sqlBindingSource.DataMember = "KMDI_ACCT_ACCESS_TB"
            Contracts.ContractsDGV.DataSource = sqlBindingSource

            With Contracts.ContractsDGV
                .DefaultCellStyle.BackColor = Color.White
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With

            'ChangeWritePermision.UserAccessDGV.Columns("Autonumber").Visible = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

End Module
