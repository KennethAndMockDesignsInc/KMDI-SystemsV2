Imports System.Data.SqlClient

Public Class KMDIContractRecordsClass
    Public Query As String

    Public ds As New DataSet
    Public bs As New BindingSource
    Public ReadHasRows As Boolean

    Public Sub ContractRecordsLoad(ByVal ActionTaken As String,
                                   ByVal SearchItemFN As String,
                                   ByVal SearchScope As String,
                                   ByVal stp_Name As String,
                                   ByVal SearchString As String)

        Dim sqlDataAdapter As New SqlDataAdapter

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()

            Using sqlcmd As New SqlCommand(stp_Name, sqlcon)
                Select Case ActionTaken
                    Case "Search"
                        ds.Clear()
                        Select Case SearchItemFN
                            Case "InitialF2"
                                sqlcmd.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                                sqlcmd.CommandType = CommandType.StoredProcedure
                                sqlcmd.CommandTimeout = 5

                                sqlDataAdapter.SelectCommand = sqlcmd
                                sqlDataAdapter.Fill(ds, "InitialF2")

                                bs.DataSource = ds
                                bs.DataMember = "InitialF2"
                            Case "SecondF2"
                                Select Case SearchScope
                                    Case "Broad"
                                        sqlcmd.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                                    Case "Specific"
                                        sqlcmd.Parameters.AddWithValue("@SearchString", SearchString)
                                End Select
                                sqlcmd.CommandType = CommandType.StoredProcedure
                                sqlcmd.CommandTimeout = 5

                                sqlDataAdapter.SelectCommand = sqlcmd
                                sqlDataAdapter.Fill(ds, "SecondF2")
                                bs.DataSource = ds
                                bs.DataMember = "SecondF2"
                            Case "ItemSearchInitialF2"
                                sqlcmd.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                                sqlcmd.CommandType = CommandType.StoredProcedure
                                sqlcmd.CommandTimeout = 5

                                sqlDataAdapter.SelectCommand = sqlcmd
                                sqlDataAdapter.Fill(ds, "FFabTB_Join_A2C1")
                                bs.DataSource = ds
                                bs.DataMember = "FFabTB_Join_A2C1"
                            Case "ItemSearchSecondF2"
                                sqlcmd.Parameters.AddWithValue("@SearchString", "%" & SearchString & "%")
                                sqlcmd.CommandType = CommandType.StoredProcedure
                                sqlcmd.CommandTimeout = 5

                                sqlDataAdapter.SelectCommand = sqlcmd
                                sqlDataAdapter.Fill(ds, "FFabTB_Join_A2C2")
                                bs.DataSource = ds
                                bs.DataMember = "FFabTB_Join_A2C2"
                        End Select

                        Using read As SqlDataReader = sqlcmd.ExecuteReader
                            read.Read()
                            Select Case read.HasRows
                                Case True
                                    ReadHasRows = True
                                Case False
                                    ReadHasRows = False
                            End Select
                        End Using

                    Case "Add"
                    Case "Update"
                    Case "Delete"
                End Select
            End Using
        End Using

    End Sub

    Public Sub ProjectAddress(ByVal ActionTaken As String,
                              ByVal stp_Name As String,
                              ByVal SearchString As String,
                              ByVal UnitNo As String,
                              ByVal Establishment As String,
                              ByVal HouseNo As String,
                              ByVal Street As String,
                              ByVal Village As String,
                              ByVal Brgy As String,
                              ByVal CityMunicipality As String,
                              ByVal Province As String,
                              ByVal Area As String,
                              ByVal FullAddress As String)

        Dim sqlDataAdapter As New SqlDataAdapter

        Using sqlcon As New SqlConnection(sqlconnString)
            sqlcon.Open()
            Dim transaction As SqlTransaction

            Dim sqlcmd As SqlCommand = sqlcon.CreateCommand()
            transaction = sqlcon.BeginTransaction("AddressTransaction")

            sqlcmd = New SqlCommand(stp_Name, sqlcon, transaction)
            'Using sqlcmd As New SqlCommand(stp_Name, sqlcon)
            Try
                Select Case ActionTaken
                    Case "Search"
                        ds.Clear()
                        sqlcmd.Parameters.AddWithValue("@SearchString", SearchString)


                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.CommandTimeout = 5
                        sqlDataAdapter.SelectCommand = sqlcmd

                        Using read As SqlDataReader = sqlcmd.ExecuteReader
                            read.Read()
                            Select Case read.HasRows
                                Case True
                                    ReadHasRows = True
                                    With read
                                        KMDISystemsGlobalModule.UnitNo = .Item(0).ToString
                                        KMDISystemsGlobalModule.Establishment = .Item(1).ToString
                                        KMDISystemsGlobalModule.HouseNo = .Item(2).ToString
                                        KMDISystemsGlobalModule.Street = .Item(3).ToString
                                        KMDISystemsGlobalModule.Village = .Item(4).ToString
                                        KMDISystemsGlobalModule.Brgy = .Item(5).ToString
                                        KMDISystemsGlobalModule.CityMunicipality = .Item(6).ToString
                                        KMDISystemsGlobalModule.Province = .Item(7).ToString
                                        KMDISystemsGlobalModule.Area = .Item(8).ToString
                                    End With
                                Case False
                                    ReadHasRows = False
                            End Select
                        End Using
                    Case "Add"
                    Case "Update"
                        sqlcmd.Parameters.AddWithValue("@UnitNo", UnitNo)
                        sqlcmd.Parameters.AddWithValue("@Establishment", Establishment)
                        sqlcmd.Parameters.AddWithValue("@HouseNo", HouseNo)
                        sqlcmd.Parameters.AddWithValue("@Street", Street)
                        sqlcmd.Parameters.AddWithValue("@Village", Village)
                        sqlcmd.Parameters.AddWithValue("@Brgy", Brgy)
                        sqlcmd.Parameters.AddWithValue("@CityMunicipality", CityMunicipality)
                        sqlcmd.Parameters.AddWithValue("@Province", Province)
                        sqlcmd.Parameters.AddWithValue("@Area", Area)
                        sqlcmd.Parameters.AddWithValue("@FullAddress", FullAddress)
                        sqlcmd.Parameters.AddWithValue("@SearchString", SearchString)

                        sqlcmd.CommandType = CommandType.StoredProcedure
                        sqlcmd.CommandTimeout = 5
                        sqlDataAdapter.SelectCommand = sqlcmd

                        sqlcmd.ExecuteNonQuery()
                    Case "Delete"
                End Select
                transaction.Commit()

            Catch ex As Exception
                Try
                    transaction.Rollback()
                Catch ex2 As Exception
                    MessageBox.Show("Transaction failed")
                End Try
            End Try

        End Using

    End Sub

    Private Sub ExecuteSqlTransaction(ByVal connectionString As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim command As SqlCommand = connection.CreateCommand()
            Dim transaction As SqlTransaction

            ' Start a local transaction
            transaction = connection.BeginTransaction("SampleTransaction")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            command.Connection = connection
            command.Transaction = transaction

            Try
                command.CommandText =
                  "Insert into [A_NEW_A_SAMPLE_TBL] ([SAMPLE_COL1]) VALUES ('qweqwe')"
                command.ExecuteNonQuery()
                MsgBox("EXECUTE #1")
                command.CommandText =
                  "waitfor delay '00:00:02' Insert into [A_NEW_A_SAMPLE_TBL] ([SAMPLE_COL1]) VALUES ('asdasdd')"

                command.ExecuteNonQuery()
                MsgBox("EXECUTE #2")

                ' Attempt to commit the transaction.
                transaction.Commit()
                Console.WriteLine("Both records are written to database.")

            Catch ex As Exception
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Console.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    transaction.Rollback()

                Catch ex2 As Exception
                    ' This catch block will handle any errors that may have occurred
                    ' on the server that would cause the rollback to fail, such as
                    ' a closed connection.
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Console.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using
    End Sub

    Public Sub RowPostPaintContractRecords(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Segoe UI", 9.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
End Class
