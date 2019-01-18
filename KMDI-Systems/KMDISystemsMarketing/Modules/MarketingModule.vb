Imports System.Data.SqlClient
Module MarketingModule
    Public Mktng_SearchStr As String = Nothing
    Public Mktng_QUERY_INSTANCE As String = Nothing

    Public OpenedByFormName As Form
    Public DGVStrGlobal As String

    Public MI_ID As String
    Public ITEM_CODE As String
    Public BRAND As String
    Public ITEM_DESC As String
    Public M_COLOR As String
    Public M_SIZE As String
    Public GENDER As String
    Public MARKET_PRICE As Decimal
    Public PURCHASED_PRICE As Decimal
    Public QUANTITY As String
    Public PURCHASED_DATE As Date
    Public REMARKS As String
    Public ITEM_PICTURE As String
    Public MIC_ID_REF As Integer
    Public InsertedMI_ID As Integer
    Public Gift_bool, Raffle_bool,
           Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool As Boolean

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
                transaction = sqlcon.BeginTransaction(StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@MAIN_CLASS", MainClassStr)
                sqlCommand.ExecuteNonQuery()
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
                transaction = sqlcon.BeginTransaction(StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@SubClass", SubClassStr)
                sqlCommand.Parameters.AddWithValue("@MIC_ID_REF", MIC_ID_REF)
                sqlCommand.ExecuteNonQuery()
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

                sqlCommand.Parameters.AddWithValue("@MIC_ID_REF", MIC_ID_REF)
                sqlCommand.Parameters.AddWithValue("@ITEM_CODE", ITEM_CODE)
                sqlCommand.Parameters.AddWithValue("@ITEM_DESC", ITEM_DESC)
                sqlCommand.Parameters.AddWithValue("@GENDER", GENDER)
                sqlCommand.Parameters.AddWithValue("@MARKET_PRICE", MARKET_PRICE)
                sqlCommand.Parameters.AddWithValue("@PURCHASED_PRICE", PURCHASED_PRICE)
                sqlCommand.Parameters.AddWithValue("@DISCOUNT", DISCOUNT)
                sqlCommand.Parameters.AddWithValue("@QUANTITY", QUANTITY)
                sqlCommand.Parameters.AddWithValue("@PURCHASED_DATE", PURCHASED_DATE)
                sqlCommand.Parameters.AddWithValue("@QR_STATUS", QR_STATUS)
                sqlCommand.Parameters.AddWithValue("@GIFT", GIFT)
                sqlCommand.Parameters.AddWithValue("@RAFFLE", RAFFLE)
                sqlCommand.Parameters.AddWithValue("@TIER_1", TIER_1)
                sqlCommand.Parameters.AddWithValue("@TIER_2", TIER_2)
                sqlCommand.Parameters.AddWithValue("@TIER_3", TIER_3)
                sqlCommand.Parameters.AddWithValue("@TIER_4", TIER_4)
                sqlCommand.Parameters.AddWithValue("@TIER_5", TIER_5)
                sqlCommand.Parameters.AddWithValue("@TIER_6", TIER_6)
                sqlCommand.Parameters.AddWithValue("@TIER_7", TIER_7)
                sqlCommand.Parameters.AddWithValue("@MIC_ID_REF", MIC_ID_REF)
                sqlCommand.Parameters.AddWithValue("@Color", Color)
                sqlCommand.Parameters.AddWithValue("@BRAND", BRAND)
                sqlCommand.Parameters.AddWithValue("@Size", Size)
                sqlCommand.Parameters.AddWithValue("@REMARKS", REMARKS)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedMI_ID = read.Item("MI_ID_INSERTED").ToString
                End Using
                If InsertedMI_ID <> "" Or InsertedMI_ID <> Nothing Then
                    For Each SubClass_ID As Integer In SubClass_list
                        sqlCommand.CommandText = "INSERT INTO [A_NEW_MKTNG_INV_SUBCLASS_LOOKUP]  ([MI_ID_REF_SUB],
                                                                                              [MISC_ID_REF])
                                                                 VALUES  (@MI_ID_REF_SUB,
                                                                          @MISC_ID_REF" & SubClass_ID & ")"
                        sqlCommand.CommandType = CommandType.Text
                        sqlCommand.Parameters.AddWithValue("@MI_ID_REF_SUB", InsertedMI_ID)
                        sqlCommand.Parameters.AddWithValue("@MISC_ID_REF" & SubClass_ID, SubClass_ID)
                        sqlCommand.ExecuteNonQuery()
                    Next
                    For Each Events_ID As Integer In Events_list
                        sqlCommand.CommandText = "INSERT INTO [A_NEW_MKTNG_INV_EVENT_TAGS]  ([MI_ID_REF_EVENT],
                                                                                         [MIE_ID_REF]
                                                                 VALUES  (@MI_ID_REF_EVENT,
                                                                          @MIE_ID_REF" & Events_ID & ")"
                        sqlCommand.CommandType = CommandType.Text
                        sqlCommand.Parameters.AddWithValue("@MI_ID_REF_EVENT", InsertedMI_ID)
                        sqlCommand.Parameters.AddWithValue("@MIE_ID_REF" & Events_ID, Events_ID)
                        sqlCommand.ExecuteNonQuery()
                    Next
                End If
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
End Module