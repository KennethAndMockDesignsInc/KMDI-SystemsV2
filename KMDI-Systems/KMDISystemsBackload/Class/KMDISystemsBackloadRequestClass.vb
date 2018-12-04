Imports System.Data.SqlClient

Public Class KMDISystemsBackloadRequestClass
    'Dim myserver As String = KMDISystemsLogin_AccessPoint
    'Dim mydatabase As String = KMDISystemsLogin_DBName
    'Dim myuser As String = "kmdiadmin"
    'Dim mypass As String = "kmdiadmin"
    'Public sqlConnection As New SqlConnection With {.ConnectionString = "Data Source='" & myserver & "';Network Library=DBMSSOCN;Initial Catalog='" & mydatabase & "';User ID='" & myuser & "';Password='" & mypass & "';"}
    'Public sqlCommand As SqlCommand
    'Public read As SqlDataReader
    'Public query As String

    Public ds As New DataSet
    Public ds2 As New DataSet
    Public da As New SqlDataAdapter
    Public bs As New BindingSource

    Public Sub BackloadRequestLoadFrameSash(ByVal JO As String)
        sqlConnection.Close()
        sqlConnection.Open()


        ds.Clear()
        Dim query As String = "SELECT TOP 1000 [JOB_ORDER_NO]
                              ,[ITEM_NO] as [Item No.]
                              ,[KMDI_NO] as [K#]
                              ,[WDW_NO] as [Wdw No.]
                              ,[COLOR] as [Profile Color]
                              ,[LOCATION] as [Location]
                              ,[DESCRIPTION] as [Item Description]
                              ,[DR]
                              ,[DATE_DELIVERED]
                              ,[DR_NO]
                              ,[PLATE_NO]
                              ,[WIDTH] as [Width]
                              ,[HEIGHT] as [Height]
                              ,[STATUS]
                          FROM [KMDI_FABRICATION_TB]
                          where DATE_DELIVERED <> '' and 
                                DR_NO <> '' and 
                                [STATUS] = '' and 
                                JOB_ORDER_NO = '" & JO & "'
                          order by ITEM_NO asc"
        sqlCommand = New SqlCommand(query, sqlConnection)
        'sqlCommand.Parameters.AddWithValue("@JO", "" & JO & "")
        sqlCommand.CommandTimeout = 300
        da.SelectCommand = sqlCommand
        da.Fill(ds, "KMDI_FABRICATION_TB")
        bs.DataSource = ds
        bs.DataMember = "KMDI_FABRICATION_TB"

        Read = sqlCommand.ExecuteReader

    End Sub

    Public Sub BackloadRequestLoadScreen(ByVal JO As String)
        sqlConnection.Close()
        sqlConnection.Open()


        ds.Clear()
        Dim query As String = "SELECT TOP 1000 [JOB_ORDER_NO]
                              ,[ITEM_NO] as [Item No.]
                              ,[KMDI_NO] as [K#]
                              ,[WDW_NO] as [Wdw No.]
                              ,[COLOR] as [Profile Color]
                              ,[LOCATION] as [Location]
                              ,[DESCRIPTION] as [Item Description]
                              ,[DR]
                              ,[DATE_DELIVERED]
                              ,[DR_NO]
                              ,[PLATE_NO]
                              ,[WIDTH] as [Width]
                              ,[HEIGHT] as [Height]
                              ,[STATUS]
                          FROM [KMDI_SCREENFAB_TB]
                          where DATE_DELIVERED <> '' and 
                                DR_NO <> '' and 
                                [STATUS] = '' and 
                                JOB_ORDER_NO = '" & JO & "'
                                order by ITEM_NO asc"
        sqlCommand = New SqlCommand(query, sqlConnection)
        'sqlCommand.Parameters.AddWithValue("@JO", "" & JO & "")
        sqlCommand.CommandTimeout = 300
        da.SelectCommand = sqlCommand
        da.Fill(ds, "KMDI_SCREENFAB_TB")
        bs.DataSource = ds
        bs.DataMember = "KMDI_SCREENFAB_TB"

        Read = sqlCommand.ExecuteReader

    End Sub

    Public Sub RequestBackload(ByVal JONo As String,
                               ByVal ItemNo As String,
                               ByVal KNo As String,
                               ByVal ItemDescription As String,
                               ByVal Reason As String,
                               ByVal OtherDetails As String,
                               ByVal RequestedBy As String,
                               ByVal RequestedByIdentifier As String,
                               ByVal DateRequested As String,
                               ByVal RequestStatus As String,
                               ByVal ItemType As String)

        sqlConnection.Close()
        sqlConnection.Open()

        Query = "Insert into BACKLOADS ([JO#]
                                       ,[Item No.]
                                       ,[K#]
                                       ,[Description]
                                       ,[Reason]
                                       ,[Other Details]
                                       ,[Item Type]
                                       ,[Requested By]
                                       ,[Requested By Identifier]
                                       ,[Date Requested]
                                       ,[Request Status])

                           VALUES ('" & JONo & "', 
                                   '" & ItemNo & "',
                                   '" & KNo & "',
                                   '" & ItemDescription & "',
                                   '" & Reason & "',
                                   '" & OtherDetails & "',
                                   '" & ItemType & "',
                                   '" & RequestedBy & "',
                                   '" & RequestedByIdentifier & "',
                                   '" & DateRequested & "',
                                   '" & RequestStatus & "')"

        sqlCommand = New SqlCommand(Query, sqlConnection)
        sqlCommand.Parameters.AddWithValue("@JONo", "'" & JONo & "'")
        sqlCommand.Parameters.AddWithValue("@ItemNo", "'" & ItemNo & "'")
        sqlCommand.Parameters.AddWithValue("@KNo", "'" & KNo & "'")
        sqlCommand.Parameters.AddWithValue("@ItemDescription", "'" & ItemDescription & "'")
        sqlCommand.Parameters.AddWithValue("@Reason", "'" & Reason & "'")
        sqlCommand.Parameters.AddWithValue("@OtherDetails", "'" & OtherDetails & "'")
        sqlCommand.Parameters.AddWithValue("@ItemType", "'" & ItemType & "'")
        sqlCommand.Parameters.AddWithValue("@RequestedBy", "'" & RequestedBy & "'")
        sqlCommand.Parameters.AddWithValue("@RequestedByIdentifier", "'" & RequestedBy & "'")
        sqlCommand.Parameters.AddWithValue("@DateRequested", "'" & DateRequested & "'")
        sqlCommand.Parameters.AddWithValue("@RequestStatus", "'" & RequestStatus & "'")
        'sqlCommand.Parameters.AddWithValue("@DBStatus", "'" & 1 & "'")

        sqlCommand.ExecuteNonQuery()

        MessageBox.Show(JONo + " " + ItemNo + " " + KNo + " " + ItemDescription + " " + Reason + " " + OtherDetails + " " + RequestedBy + " " + DateRequested + " " + RequestStatus + " " + ItemType)
    End Sub

    Public Sub CheckRequestedBackloads()
        sqlConnection.Close()
        sqlConnection.Open()


        ds.Clear()
        Dim query As String = "SELECT TOP 1000 [Autonum]
                                              ,[JO#]
                                              ,[Item No.]
                                              ,[K#]
                                              ,[Description]
                                              ,[Reason]
                                              ,[Other Details]
                                              ,[Item Type]
                                              ,[Requested By]
                                              ,[Requested By Identifier]
                                              ,[Date Requested]
                               FROM [BACKLOADS]
                               ORDER BY [Item No.] asc "
        sqlCommand = New SqlCommand(query, sqlConnection)
        'sqlCommand.Parameters.AddWithValue("@JO", "" & JO & "")
        sqlCommand.CommandTimeout = 300
        da.SelectCommand = sqlCommand
        da.Fill(ds2, "BACKLOADS")
        bs.DataSource = ds2
        bs.DataMember = "BACKLOADS"

        Read = sqlCommand.ExecuteReader

    End Sub

    Public Sub RowPostPaintBackloadRequest(sender As Object, e As DataGridViewRowPostPaintEventArgs)
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

