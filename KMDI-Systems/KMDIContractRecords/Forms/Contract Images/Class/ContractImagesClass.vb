Imports System.Data.SqlClient

Public Class ContractImagesClass
    Public query As String

    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public bs As New BindingSource

    Public Sub ContractImagesLoad(ByVal QueryFunction As String,
                                   ByVal QueryBody As String,
                                   ByVal QueryCondition As String,
                                   ByVal ActionTaken As String)
        sqlConnection.Close()
        sqlConnection.Open()

        Select Case ActionTaken
            Case "Search"
                ds.Clear()
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
        query = QueryFunction &
                QueryBody &
                QueryCondition
        sqlCommand = New SqlCommand(query, sqlConnection)
        sqlCommand.CommandTimeout = 300
        da.SelectCommand = sqlCommand
        Select Case ActionTaken
            Case "Search"
                da.Fill(ds, "ContractImages")
                bs.DataSource = ds
                bs.DataMember = "ContractImages"
                Read = sqlCommand.ExecuteReader
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub
End Class
