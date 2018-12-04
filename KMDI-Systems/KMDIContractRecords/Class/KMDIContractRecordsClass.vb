Imports System.Data.SqlClient

Public Class KMDIContractRecordsClass
    Public Query As String

    Public ds As New DataSet
    Public bs As New BindingSource

    Public Sub ContractRecordsLoad(ByVal QueryFunction As String,
                                   ByVal QueryBody As String,
                                   ByVal QueryCondition As String,
                                   ByVal ActionTaken As String,
                                   ByVal SearchItemFN As String)
        sqlConnection.Close()
        sqlConnection.Open()

        Select Case ActionTaken
            Case "Search"
                ds.Clear()
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
        Query = QueryFunction &
                QueryBody &
                QueryCondition
        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlCommand.CommandTimeout = 300
        sqlDataAdapter.SelectCommand = sqlCommand
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        sqlDataAdapter.Fill(ds, "InitialF2")
                        bs.DataSource = ds
                        bs.DataMember = "InitialF2"
                    Case "SecondF2"
                        sqlDataAdapter.Fill(ds, "SecondF2")
                        bs.DataSource = ds
                        bs.DataMember = "SecondF2"
                    Case "ItemSearchInitialF2"
                        sqlDataAdapter.Fill(ds, "FFabTB_Join_A2C1")
                        bs.DataSource = ds
                        bs.DataMember = "FFabTB_Join_A2C1"
                    Case "ItemSearchSecondF2"
                        sqlDataAdapter.Fill(ds, "FFabTB_Join_A2C2")
                        bs.DataSource = ds
                        bs.DataMember = "FFabTB_Join_A2C2"
                End Select
                Read = sqlCommand.ExecuteReader
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Public Sub ProjectAddress(ByVal QueryFunction As String,
                              ByVal QueryBody As String,
                              ByVal QueryCondition As String,
                              ByVal ActionTaken As String,
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
        sqlConnection.Close()
        sqlConnection.Open()

        Select Case ActionTaken
            Case "Search"
                ds.Clear()
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select

        Query = QueryFunction &
                QueryBody &
                QueryCondition
        sqlCommand = New SqlCommand(Query, sqlConnection)

        Select Case ActionTaken
            Case "Search"
                sqlCommand.Parameters.AddWithValue("@SearchString", SearchString)
            Case "Add"
            Case "Update"
                sqlCommand.Parameters.AddWithValue("@UnitNo", UnitNo)
                sqlCommand.Parameters.AddWithValue("@Establishment", Establishment)
                sqlCommand.Parameters.AddWithValue("@HouseNo", HouseNo)
                sqlCommand.Parameters.AddWithValue("@Street", Street)
                sqlCommand.Parameters.AddWithValue("@Village", Village)
                sqlCommand.Parameters.AddWithValue("@Brgy", Brgy)
                sqlCommand.Parameters.AddWithValue("@CityMunicipality", CityMunicipality)
                sqlCommand.Parameters.AddWithValue("@Province", Province)
                sqlCommand.Parameters.AddWithValue("@Area", Area)
                sqlCommand.Parameters.AddWithValue("@FullAddress", FullAddress)
                sqlCommand.Parameters.AddWithValue("@SearchString", SearchString)
            Case "Delete"
        End Select

        sqlCommand.CommandTimeout = 300
        sqlDataAdapter.SelectCommand = sqlCommand
        Read = sqlCommand.ExecuteReader
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
