Imports System.Data.SqlClient
Module EngineeringModule
    Dim sqlconnString As String = "Data Source = 121.58.229.248,49107; Network Library=DBMSSOCN;Initial Catalog='heretosave';User ID=kmdiadmin;Password=kmdiadmin;"
    Public ENGR_QUERY_INSTANCE As String = Nothing
    Public InsertedSTF_ID As Integer
    Public InsertedTFM_ID As Integer
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
                        sqlCommand.Parameters.Add("@SearchString", SqlDbType.VarChar).Value = "%" & SearchString & "%"
                    Case "Loading_using_EqualSearch"
                        sqlCommand.Parameters.Add("@EqualSearch", SqlDbType.VarChar).Value = SearchString
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
    Public Sub Engr_Query_Select_T_FACTOR(ByVal StoredProcedureName As String,
                                          ByVal ST_ID As Integer,
                                          Optional WDT_ID As Integer = Nothing,
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

                sqlCommand.Parameters.Add("@ST_ID", SqlDbType.Int).Value = ST_ID
                sqlCommand.Parameters.Add("@WDT_ID", SqlDbType.Int).Value = WDT_ID
                sqlCommand.ExecuteNonQuery()

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
    Public Sub Engr_SystemNfactor_INSERT(ByVal StoredProcedureName As String,
                                         ByVal SYSTEM_TYPE As String,
                                         ByVal FACTOR As TimeSpan)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@SYSTEM_TYPE", SYSTEM_TYPE)
                sqlCommand.Parameters.AddWithValue("@TIME_FACTOR", FACTOR)
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedSTF_ID = read.Item("STF_ID")
                End Using
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_SystemNfactor_UPDATE(ByVal StoredProcedureName As String,
                                         ByVal SYSTEM_TYPE As String,
                                         ByVal FACTOR As TimeSpan,
                                         ByVal STF_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@SYSTEM_TYPE", SYSTEM_TYPE)
                sqlCommand.Parameters.AddWithValue("@TIME_FACTOR", FACTOR)
                sqlCommand.Parameters.AddWithValue("@STF_ID", STF_ID)
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_SystemNfactor_DELETE(ByVal StoredProcedureName As String,
                                         ByVal STF_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.AddWithValue("@STF_ID", STF_ID)
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_TFM_INSERT(ByVal StoredProcedureName As String,
                                     ByVal WindoorPart As String,
                                     ByVal InsertValue As String)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@WindoorPart", SqlDbType.VarChar).Value = WindoorPart
                sqlCommand.Parameters.Add("@InsertValue", SqlDbType.VarChar).Value = InsertValue
                Using read As SqlDataReader = sqlCommand.ExecuteReader
                    read.Read()
                    InsertedTFM_ID = read.Item("TAG_ID")
                End Using
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_ProfileType_UPDATE(ByVal StoredProcedureName As String,
                                      ByVal SYSTEM_TYPE As String,
                                      ByVal FRAME_SCREEN As String,
                                      ByVal ST_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@SYSTEM_TYPE", SqlDbType.VarChar).Value = SYSTEM_TYPE
                sqlCommand.Parameters.Add("@FRAME_OR_SCREEN", SqlDbType.VarChar).Value = FRAME_SCREEN
                sqlCommand.Parameters.Add("@ST_ID", SqlDbType.Int).Value = ST_ID
                sqlCommand.ExecuteNonQuery()
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_ProfileType_DELETE(ByVal StoredProcedureName As String,
                                      ByVal ST_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@ST_ID", SqlDbType.Int).Value = ST_ID
                sqlCommand.ExecuteNonQuery()
                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    'Public Sub Engr_WindoorType_INSERT(ByVal StoredProcedureName As String,
    '                                   ByVal WINDOW_TYPE As String)
    '    Using sqlcon As New SqlConnection(sqlconnString)
    '        sqlcon.Open()
    '        Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
    '            transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
    '            sqlCommand.Connection = sqlcon
    '            sqlCommand.Transaction = transaction
    '            sqlCommand.CommandText = StoredProcedureName
    '            sqlCommand.CommandType = CommandType.StoredProcedure

    '            sqlCommand.Parameters.Add("@WINDOW_TYPE", SqlDbType.VarChar).Value = WINDOW_TYPE
    '            Using read As SqlDataReader = sqlCommand.ExecuteReader
    '                read.Read()
    '                InsertedRight_ID = read.Item("TAG_ID")
    '            End Using
    '            transaction.Commit()
    '            sql_Transaction_result = "Committed"
    '        End Using
    '    End Using
    'End Sub
    Public Sub Engr_WindoorType_UPDATE(ByVal StoredProcedureName As String,
                                       ByVal WINDOW_TYPE As String,
                                       ByVal WDT_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@WINDOW_TYPE", SqlDbType.VarChar).Value = WINDOW_TYPE
                sqlCommand.Parameters.Add("@WDT_ID", SqlDbType.Int).Value = WDT_ID
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_WindoorType_DELETE(ByVal StoredProcedureName As String,
                                       ByVal WDT_ID As Integer)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@WDT_ID", SqlDbType.Int).Value = WDT_ID
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub
    Public Sub Engr_TFactor_Transact(ByVal StoredProcedureName As String,
                                     ByVal ST_ID As Integer,
                                     ByVal WDT_ID As Integer,
                                     ByVal T_FACTOR As TimeSpan)
        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Using sqlCommand As SqlCommand = sqlcon.CreateCommand()
                transaction = sqlcon.BeginTransaction(IsolationLevel.RepeatableRead, StoredProcedureName)
                sqlCommand.Connection = sqlcon
                sqlCommand.Transaction = transaction
                sqlCommand.CommandText = StoredProcedureName
                sqlCommand.CommandType = CommandType.StoredProcedure

                sqlCommand.Parameters.Add("@ST_ID_REF", SqlDbType.Int).Value = ST_ID
                sqlCommand.Parameters.Add("@WDT_ID_REF", SqlDbType.Int).Value = WDT_ID
                sqlCommand.Parameters.Add("@T_FACTOR", SqlDbType.Time).Value = T_FACTOR
                sqlCommand.ExecuteNonQuery()

                transaction.Commit()
                sql_Transaction_result = "Committed"
            End Using
        End Using
    End Sub

End Module
