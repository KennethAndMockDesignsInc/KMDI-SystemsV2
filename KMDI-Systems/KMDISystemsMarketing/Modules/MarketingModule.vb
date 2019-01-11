Imports System.Data.SqlClient
Module MarketingModule
    Public Mktng_SearchStr As String = Nothing
    Public Mktng_QUERY_INSTANCE As String = Nothing

    Public OpenedByFormName As Form
    Public DGVStrGlobal As String
    Public Sub Mktng_Query_Select_STP(ByVal SearchString As String,
                                      Optional StoredProcedureName As String = "",
                                      Optional WillUseReader As Boolean = False)
        Try
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

                    Select Case Mktng_QUERY_INSTANCE
                        Case "Loading_using_SearchString"
                            sqlCommand.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                        Case "Loading_using_EqualSearch"
                            sqlCommand.Parameters.AddWithValue("@EqualSearch", SearchString)
                    End Select
                    Select Case StoredProcedureName
                        'Case "PD_stp_SalesJobOrder_SubJoSearch"
                        '    return_bool = sqlCommand.ExecuteScalar
                    End Select

                    transaction.Commit()
                    sql_Transaction_result = "Committed"

                    Select Case WillUseReader
                        Case False
                            sqlDataAdapter.SelectCommand = sqlCommand
                            sqlDataAdapter.Fill(sqlDataSet, "QUERY_DETAILS")
                            sqlBindingSource.DataSource = sqlDataSet
                            sqlBindingSource.DataMember = "QUERY_DETAILS"
                        Case True
                            Using read As SqlDataReader = sqlCommand.ExecuteReader
                                read.Read()
                                If read.HasRows Then
                                    arr_WD_ID.Add(read.Item("WD_ID"))
                                    arr_Quote_Date.Add(read.Item("QUOTE_DATE"))
                                    arr_Profile_finish.Add(read.Item("PROFILE_FINISH"))
                                End If
                            End Using
                    End Select
                End Using
            End Using
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            sql_err_bool = True
            sql_Err_msg = ex.Message
            sql_Err_no = ex.Number
            sql_Err_StackTrace = ex.StackTrace
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           "Rollback Error Message: " & ex2.Message & vbCrLf &
                                           "Trace: " & ex2.StackTrace & vbCrLf)
                Log_File.Close()
            End Try
        End Try
    End Sub

End Module
