Imports System.Data.SqlClient

Public Class KMDIContractItemsClass
    Public Query As String

    Public ds As New DataSet
    Public bs As New BindingSource
    Public Sub ContractItemsLoad(ByVal QueryFunction As String,
                                 ByVal QueryBody As String,
                                 ByVal QueryCondition As String,
                                 ByVal ActionTaken As String,
                                 ByVal SearchItemFN As String,
                                 ByVal SearchString As String)
        sqlConnection.Close()
        sqlConnection.Open()

        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "Frames"
                        If ds.Tables.Contains("Frames") = True Then
                            ds.Tables("Frames").Clear()
                        End If
                    Case "Screens"
                        If ds.Tables.Contains("Screens") = True Then
                            ds.Tables("Screens").Clear()
                        End If
                    Case "Glass"
                        If ds.Tables.Contains("Glass") = True Then
                            ds.Tables("Glass").Clear()
                        End If
                    Case "Films"
                    Case "Mechanisms"
                    Case "Add-Ons"
                    Case "Summmary"
                End Select
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
                sqlCommand.CommandTimeout = 300
                sqlDataAdapter.SelectCommand = sqlCommand
                Select Case SearchItemFN
                    Case "Frames"
                        sqlDataAdapter.Fill(ds, "Frames")
                        bs.DataSource = ds
                        bs.DataMember = "Frames"
                    Case "Screens"
                        sqlDataAdapter.Fill(ds, "Screens")
                        bs.DataSource = ds
                        bs.DataMember = "Screens"
                    Case "Glass"
                        sqlDataAdapter.Fill(ds, "Glass")
                        bs.DataSource = ds
                        bs.DataMember = "Glass"
                    Case "Films"
                        sqlDataAdapter.Fill(ds, "Films")
                        bs.DataSource = ds
                        bs.DataMember = "Films"
                    Case "Mechanisms"
                        sqlDataAdapter.Fill(ds, "Mechanisms")
                        bs.DataSource = ds
                        bs.DataMember = "Mechanisms"
                    Case "Add-Ons"
                        sqlDataAdapter.Fill(ds, "Add-Ons")
                        bs.DataSource = ds
                        bs.DataMember = "Add-Ons"
                    Case "Summary"
                        sqlDataAdapter.Fill(ds, "Summary")
                        bs.DataSource = ds
                        bs.DataMember = "Summary"
                End Select
                Read = sqlCommand.ExecuteReader
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select

    End Sub

    Public Sub RowPostPaintContractItems(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)

        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
End Class
