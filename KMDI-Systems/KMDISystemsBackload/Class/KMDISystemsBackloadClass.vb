Imports System.Data.SqlClient

Public Class KMDISystemsBackloadClass
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

    Public Sub Backloads(ByVal QueryFunction As String,
                         ByVal QueryBody As String,
                         ByVal QueryCondition As String,
                         ByVal ActionTaken As String)

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
        sqlCommand.ExecuteNonQuery()
        sqlCommand.CommandTimeout = 300
        da.SelectCommand = sqlCommand
        Select Case ActionTaken
            Case "Search"
                da.Fill(ds, "BACKLOADS")
                bs.DataSource = ds
                bs.DataMember = "BACKLOADS"
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select

        MessageBox.Show(query)

    End Sub

    Public Sub RowPostPaintBackload(sender As Object, e As DataGridViewRowPostPaintEventArgs)
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
