Imports System.Data.SqlClient

Public Class BackloadUpdateClass
    'Dim myserver As String = KMDISystemsLogin_AccessPoint
    'Dim mydatabase As String = KMDISystemsLogin_DBName
    'Dim myuser As String = "kmdiadmin"
    'Dim mypass As String = "kmdiadmin"
    'Public sqlConnection As New SqlConnection With {.ConnectionString = "Data Source='" & myserver & "';Network Library=DBMSSOCN;Initial Catalog='" & mydatabase & "';User ID='" & myuser & "';Password='" & mypass & "';"}
    'Public sqlcmd As SqlCommand
    'Public read As SqlDataReader
    'Public query As String

    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public bs As New BindingSource

    Public Sub UpdateBackloadRecord(ByVal QueryFunction As String,
                                    ByVal QueryBody As String,
                                    ByVal QueryCondition As String)
        sqlConnection.Close()
        sqlConnection.Open()

        Dim query As String = QueryFunction &
                              QueryBody &
                              QueryCondition
        sqlCommand = New SqlCommand(query, sqlConnection)
        sqlCommand.ExecuteNonQuery()

    End Sub

    Public Sub Backloads(ByVal QueryFunction As String,
                         ByVal QueryBody As String,
                         ByVal QueryCondition As String,
                         ByVal ActionTaken As String,
                         ByVal TypeofBackload As String)
        sqlConnection.Close()
        sqlConnection.Open()

        Select Case ActionTaken
            Case "Search"
                ds.Clear()
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
        Dim query As String = QueryFunction &
                              QueryBody &
                              QueryCondition
        sqlCommand = New SqlCommand(query, sqlConnection)
        sqlCommand.CommandTimeout = 300
        da.SelectCommand = sqlCommand
        Select Case ActionTaken
            Case "Search"
                Select Case TypeofBackload
                    Case "Frame/Sash"
                        da.Fill(ds, "Frame")
                        bs.DataSource = ds
                        bs.DataMember = "Frame"
                    Case "Screen"
                        da.Fill(ds, "Screen")
                        bs.DataSource = ds
                        bs.DataMember = "Screen"
                    Case "Glass"
                        da.Fill(ds, "Glass")
                        bs.DataSource = ds
                        bs.DataMember = "Glass"
                    Case "Installation Material"
                        da.Fill(ds, "Installation Material")
                        bs.DataSource = ds
                        bs.DataMember = "Installation Material"
                End Select
            Case Else
        End Select


        Read = sqlCommand.ExecuteReader
    End Sub

    Public Sub RowPostPaintBackloadUpdate(sender As Object, e As DataGridViewRowPostPaintEventArgs)
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
