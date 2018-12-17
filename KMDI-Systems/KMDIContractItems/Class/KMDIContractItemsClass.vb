Imports System.Data.SqlClient

Public Class KMDIContractItemsClass
    Public Query As String

    Public ds As New DataSet
    Public bs As New BindingSource
    Public Sub ContractItemsLoad(ByVal ActionTaken As String,
                                 ByVal SearchItemFN As String,
                                 ByVal stp_Name As String,
                                 ByVal SearchString As String)
        Try
            sqlConnection.Close()
            sqlConnection.Open()
        Catch ex As Exception

        End Try

        Select Case ActionTaken
            Case "Search"
                sqlCommand = New SqlCommand(stp_Name, sqlConnection)
                sqlCommand.Parameters.AddWithValue("@SearchString", SearchString)
                sqlCommand.CommandType = CommandType.StoredProcedure
                sqlCommand.CommandTimeout = 10
                sqlDataAdapter.SelectCommand = sqlCommand
                Select Case SearchItemFN
                    Case "Frames"
                        If ds.Tables.Contains("Frames") = True Then
                            ds.Tables("Frames").Clear()
                        End If

                        sqlDataAdapter.Fill(ds, "Frames")
                        bs.DataSource = ds
                        bs.DataMember = "Frames"
                    Case "Screens"
                        If ds.Tables.Contains("Screens") = True Then
                            ds.Tables("Screens").Clear()
                        End If

                        sqlDataAdapter.Fill(ds, "Screens")
                        bs.DataSource = ds
                        bs.DataMember = "Screens"
                    Case "Glass"
                        If ds.Tables.Contains("Glass") = True Then
                            ds.Tables("Glass").Clear()
                        End If

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
