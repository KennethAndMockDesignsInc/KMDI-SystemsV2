Imports System.Data.SqlClient
Module EngineeringModule
    Dim sqlconnString As String = "Data Source = 121.58.229.248,49107; Network Library=DBMSSOCN;Initial Catalog='HERETOSAVE';User ID=kmdiadmin;Password=kmdiadmin;"
    Public ENGR_QUERY_INSTANCE As String = Nothing
    Public Sub Engr_Query_Select_STP(ByVal SearchString As String,
                                     ByVal StoredProcedureName As String,
                                     Optional WillUseReader As Boolean = False)
        sqlDataSet = New DataSet
        sqlDataAdapter = New SqlDataAdapter
        sqlBindingSource = New BindingSource

        sqlDataSet.Clear()
        sqlBindingSource.Clear()

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure
                Select Case ENGR_QUERY_INSTANCE
                    Case "Loading_using_SearchString"
                        sqlCommand.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                    Case "Loading_using_EqualSearch"
                        sqlCommand.Parameters.AddWithValue("@EqualSearch", SearchString)
                End Select

                transaction.Commit()
                sql_Transaction_result = "Committed"

                Select Case WillUseReader
                    Case False
                        sqlDataAdapter.SelectCommand = sqlCommand
                        sqlDataAdapter.Fill(sqlDataSet, "QUERY_DETAILS")
                        sqlBindingSource.DataSource = sqlDataSet
                        sqlBindingSource.DataMember = "QUERY_DETAILS"
                End Select
            End Using
        End Using
    End Sub

End Module
