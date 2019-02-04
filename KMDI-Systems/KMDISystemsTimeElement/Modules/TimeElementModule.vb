Imports System.Data.SqlClient
Module TimeElementModule
    Dim sqlconnString As String = "Data Source = 121.58.229.248,49107; Network Library=DBMSSOCN;Initial Catalog='heretosave';User ID=kmdiadmin;Password=kmdiadmin;"
    Public TMLMNT_SearchStr As String = Nothing
    Public TMLMNT_QUERY_INSTANCE As String = Nothing
    Public InsertedTE_ID As Integer
    Public Sub TMLMNT_Query_Select_STP(ByVal SearchString As String,
                                       ByVal StoredProcedureName As String,
                                       Optional WillUseReader As Boolean = False)
        'Try [Di ko na dito nilagay ang try catch para may sumalo sa Form at maCancel ang BGW]
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
                Select Case TMLMNT_QUERY_INSTANCE
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
                End Select
            End Using
        End Using
        'Catch ex As SqlException
        '    'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
        '    sql_err_bool = True
        '    'sql_Err_msg = ex.Message
        '    'sql_Err_no = ex.Number
        '    'sql_Err_StackTrace = ex.StackTrace
        '    KMDIPrompts(FormName, "SqlError", ex.Message, ex.StackTrace, ex.Number)
        '    Try
        '        transaction.Rollback()
        '        sql_Transaction_result = "Rollback"
        '    Catch ex2 As Exception
        '        KMDIPrompts(FormName, "DotNetError", ex.Message, ex.StackTrace)

        '        'Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
        '        'Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
        '        '                           "Rollback Error Message: " & ex2.Message & vbCrLf &
        '        '                           "Trace: " & ex2.StackTrace & vbCrLf)
        '        'Log_File.Close()
        '    End Try
        'End Try
    End Sub
    Public Sub TMLMNT_Insert(ByVal StoredProcedureName As String,
                             ByVal PROFILE_TYPE As String,
                             Optional XS As Integer = 0,
                             Optional S As Integer = 0,
                             Optional M As Integer = 0,
                             Optional L As Integer = 0,
                             Optional XL As Integer = 0)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@PROFILE_TYPE", SqlDbType.VarChar).Value = PROFILE_TYPE
                sqlCommand.Parameters.Add("@EXTRA_SMALL", SqlDbType.Int).Value = XS
                sqlCommand.Parameters.Add("@SMALL", SqlDbType.Int).Value = S
                sqlCommand.Parameters.Add("@MEDIUM", SqlDbType.Int).Value = M
                sqlCommand.Parameters.Add("@LARGE", SqlDbType.Int).Value = L
                sqlCommand.Parameters.Add("@EXTRA_LARGE", SqlDbType.Int).Value = XL
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedTE_ID = read.Item("INSERTED_TE_ID")
                End Using

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub TMLMNT_Update(ByVal StoredProcedureName As String,
                             ByVal TE_ID As Integer,
                             ByVal PROFILE_TYPE As String,
                             Optional XS As Integer = 0,
                             Optional S As Integer = 0,
                             Optional M As Integer = 0,
                             Optional L As Integer = 0,
                             Optional XL As Integer = 0)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@PROFILE_TYPE", SqlDbType.VarChar).Value = PROFILE_TYPE
                sqlCommand.Parameters.Add("@TE_ID", SqlDbType.Int).Value = TE_ID
                sqlCommand.Parameters.Add("@EXTRA_SMALL", SqlDbType.Int).Value = XS
                sqlCommand.Parameters.Add("@SMALL", SqlDbType.Int).Value = S
                sqlCommand.Parameters.Add("@MEDIUM", SqlDbType.Int).Value = M
                sqlCommand.Parameters.Add("@LARGE", SqlDbType.Int).Value = L
                sqlCommand.Parameters.Add("@EXTRA_LARGE", SqlDbType.Int).Value = XL
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub TMLMNT_Delete(ByVal StoredProcedureName As String,
                             ByVal TE_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@TE_ID", SqlDbType.Int).Value = TE_ID
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub

End Module
