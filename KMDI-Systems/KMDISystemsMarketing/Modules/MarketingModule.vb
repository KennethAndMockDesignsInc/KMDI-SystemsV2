Imports System.Data.SqlClient
Module MarketingModule
    Public Mktng_SearchStr As String = Nothing
    Public Mktng_QUERY_INSTANCE As String = Nothing

    Public OpenedByFormName As Form
    Public DGVStrGlobal As String

    Public InsertedMI_ID, InsertedMIC_ID, InsertedMISC_ID As Integer
    Public MI_ID As String
    Public ITEM_CODE As String
    Public BRAND As String
    Public ITEM_DESC As String
    Public M_COLOR As String
    Public M_SIZE As String
    Public GENDER As String
    Public MARKET_PRICE As Decimal
    Public PURCHASED_PRICE As Decimal
    Public QUANTITY As Integer
    Public PURCHASED_DATE As Date
    Public REMARKS As String
    Public INV_DGV_ROWINDEX As Integer

    Public NEW_QUANTITY As Integer
    Public Sub Mktng_Query_Select_STP(ByVal SearchString As String,
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

    Public Sub Mktng_MainClass_Insert(ByVal MainClassStr As String,
                                      ByVal StoredProcedureName As String)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@MAIN_CLASS", SqlDbType.VarChar).Value = MainClassStr
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedMIC_ID = read.Item("TAG_ID")
                End Using

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Mktng_SubClass_Insert(ByVal SubClassStr As String,
                                     ByVal MIC_ID_REF As Integer,
                                     ByVal StoredProcedureName As String)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@SubClass", SqlDbType.VarChar).Value = SubClassStr
                sqlCommand.Parameters.Add("@MIC_ID_REF", SqlDbType.Int).Value = MIC_ID_REF
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedMISC_ID = read.Item("TAG_ID")
                End Using
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Mktng_Inv_ItemInsert(ByVal StoredProcedureName As String,
                                    ByVal ITEM_CODE As String,
                                    ByVal ITEM_DESC As String,
                                    ByVal GENDER As String,
                                    ByVal MARKET_PRICE As Decimal,
                                    ByVal PURCHASED_PRICE As Decimal,
                                    ByVal DISCOUNT As Decimal,
                                    ByVal QUANTITY As Integer,
                                    ByVal PURCHASED_DATE As Date,
                                    ByVal QR_STATUS As Boolean,
                                    ByVal GIFT As Boolean,
                                    ByVal RAFFLE As Boolean,
                                    ByVal TIER_1 As Boolean,
                                    ByVal TIER_2 As Boolean,
                                    ByVal TIER_3 As Boolean,
                                    ByVal TIER_4 As Boolean,
                                    ByVal TIER_5 As Boolean,
                                    ByVal TIER_6 As Boolean,
                                    ByVal TIER_7 As Boolean,
                                    ByVal MIC_ID_REF As Integer,
                                    ByVal SubClass_list As List(Of Integer),
                                    ByVal Events_list As List(Of Integer),
                                    Optional Color As String = "",
                                    Optional BRAND As String = "",
                                    Optional Size As String = "",
                                    Optional REMARKS As String = "")
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@MIC_ID_REF", SqlDbType.Int).Value = MIC_ID_REF
                sqlCommand.Parameters.Add("@ITEM_CODE", SqlDbType.VarChar).Value = ITEM_CODE
                sqlCommand.Parameters.Add("@ITEM_DESC", SqlDbType.VarChar).Value = ITEM_DESC
                sqlCommand.Parameters.Add("@GENDER", SqlDbType.VarChar).Value = GENDER
                sqlCommand.Parameters.Add("@MARKET_PRICE", SqlDbType.Decimal).Value = MARKET_PRICE
                sqlCommand.Parameters.Add("@PURCHASED_PRICE", SqlDbType.Decimal).Value = PURCHASED_PRICE
                sqlCommand.Parameters.Add("@DISCOUNT", SqlDbType.Decimal).Value = DISCOUNT
                sqlCommand.Parameters.Add("@QUANTITY", SqlDbType.Int).Value = QUANTITY
                sqlCommand.Parameters.Add("@PURCHASED_DATE", SqlDbType.Date).Value = PURCHASED_DATE
                sqlCommand.Parameters.Add("@QR_STATUS", SqlDbType.Bit).Value = QR_STATUS
                sqlCommand.Parameters.Add("@GIFT", SqlDbType.Bit).Value = GIFT
                sqlCommand.Parameters.Add("@RAFFLE", SqlDbType.Bit).Value = RAFFLE
                sqlCommand.Parameters.Add("@TIER_1", SqlDbType.Bit).Value = TIER_1
                sqlCommand.Parameters.Add("@TIER_2", SqlDbType.Bit).Value = TIER_2
                sqlCommand.Parameters.Add("@TIER_3", SqlDbType.Bit).Value = TIER_3
                sqlCommand.Parameters.Add("@TIER_4", SqlDbType.Bit).Value = TIER_4
                sqlCommand.Parameters.Add("@TIER_5", SqlDbType.Bit).Value = TIER_5
                sqlCommand.Parameters.Add("@TIER_6", SqlDbType.Bit).Value = TIER_6
                sqlCommand.Parameters.Add("@TIER_7", SqlDbType.Bit).Value = TIER_7
                sqlCommand.Parameters.Add("@Color", SqlDbType.VarChar).Value = Color
                sqlCommand.Parameters.Add("@BRAND", SqlDbType.VarChar).Value = BRAND
                sqlCommand.Parameters.Add("@Size", SqlDbType.VarChar).Value = Size
                sqlCommand.Parameters.Add("@REMARKS", SqlDbType.VarChar).Value = REMARKS
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedMI_ID = read.Item("MI_ID_INSERTED")
                End Using
                If InsertedMI_ID <> Nothing Then
                    For Each SubClass_ID As Integer In SubClass_list
                        sqlCommand.CommandText = "INSERT INTO [A_NEW_MKTNG_INV_SUBCLASS_LOOKUP]  ([MI_ID_REF_SUB],
                                                                                              [MISC_ID_REF])
                                                                 VALUES  (@MI_ID_REF_SUB" & SubClass_ID & ",
                                                                          @MISC_ID_REF" & SubClass_ID & ")"
                        sqlCommand.CommandType = CommandType.Text
                        sqlCommand.Parameters.Add("@MI_ID_REF_SUB" & SubClass_ID, SqlDbType.Int).Value = InsertedMI_ID
                        sqlCommand.Parameters.Add("@MISC_ID_REF" & SubClass_ID, SqlDbType.Int).Value = SubClass_ID
                        sqlCommand.ExecuteNonQuery()
                    Next
                    For Each Events_ID As Integer In Events_list
                        sqlCommand.CommandText = "INSERT INTO [A_NEW_MKTNG_INV_EVENT_TAGS]  ([MI_ID_REF_EVENT],
                                                                                             [MIE_ID_REF])
                                                                 VALUES  (@MI_ID_REF_EVENT" & Events_ID & ",
                                                                          @MIE_ID_REF" & Events_ID & ")"
                        sqlCommand.CommandType = CommandType.Text
                        sqlCommand.Parameters.Add("@MI_ID_REF_EVENT" & Events_ID, SqlDbType.Int).Value = InsertedMI_ID
                        sqlCommand.Parameters.Add("@MIE_ID_REF" & Events_ID, SqlDbType.Int).Value = Events_ID
                        sqlCommand.ExecuteNonQuery()
                    Next
                End If
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Mktng_Inv_ItemUpdateQTY(ByVal StoredProcedureName As String,
                                       ByVal MI_ID As Integer,
                                       ByVal QUANTITY As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@ADDEDQUANTITY", QUANTITY)
                sqlCommand.Parameters.AddWithValue("@MI_ID", MI_ID)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    NEW_QUANTITY = read.Item("QUANTITY")
                End Using
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
End Module