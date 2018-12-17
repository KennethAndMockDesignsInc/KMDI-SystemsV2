Imports System.Data.SqlClient

Public Class ContractImagesClass
    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public bs As New BindingSource

    Public Sub ContractImagesLoad(ByVal ActionTaken As String,
                                  ByVal stp_Name As String,
                                  ByVal SearchString As String)
        sqlConnection.Close()
        sqlConnection.Open()

        sqlCommand = New SqlCommand(stp_Name, sqlConnection)

        Select Case ActionTaken
            Case "Search"
                ds.Clear()

                sqlCommand.Parameters.AddWithValue("@SearchString", SearchString)
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.CommandTimeout = 10

                sqlDataAdapter.SelectCommand = sqlCommand
                sqlDataAdapter.Fill(ds, "ContractImages")
                bs.DataSource = ds
                bs.DataMember = "ContractImages"
                Read = sqlCommand.ExecuteReader
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub
End Class
