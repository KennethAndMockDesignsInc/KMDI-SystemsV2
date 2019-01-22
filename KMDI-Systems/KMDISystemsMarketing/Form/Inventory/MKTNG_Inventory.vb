Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Imports System.IO
Imports System.Net
Public Class MKTNG_Inventory
    Public MktngInventory_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngInv_TODO As String
    Dim Generate_DGVCols, Generate_DGVRows As Boolean
    Dim DGVrow_list As New List(Of Object)
    Public ColumnVisibility_Opened As Boolean = False
    Public Inv_DGV As New KryptonDataGridView
    Public Sub Start_MktngInventoryBGW()
        If MktngInventory_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            MktngInventory_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub MKTNG_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MktngInventory_BGW.WorkerSupportsCancellation = True
            MktngInventory_BGW.WorkerReportsProgress = True
            AddHandler MktngInventory_BGW.DoWork, AddressOf MktngInventory_BGW_DoWork
            AddHandler MktngInventory_BGW.ProgressChanged, AddressOf MktngInventory_BGW_ProgressChanged
            AddHandler MktngInventory_BGW.RunWorkerCompleted, AddressOf MktngInventory_BGW_RunWorkerCompleted
            MktngInv_TODO = "Onload"
            Start_MktngInventoryBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub MktngInventory_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MktngInv_TODO
                Case "Onload"
                    Generate_DGVCols = True
                    Mktng_QUERY_INSTANCE = "Loading_using_SearchString"
                    Mktng_Query_Select_STP("", "MKTNG_stp_Inv_Search")
                Case "Search"
                    Generate_DGVCols = False
                    Mktng_QUERY_INSTANCE = "Loading_using_SearchString"
                    Mktng_Query_Select_STP(Mktng_SearchStr, "MKTNG_stp_Inv_Search")
            End Select

            Select Case Generate_DGVCols
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                        Sleep(100)
                        MktngInventory_BGW.ReportProgress(i)
                        If i = sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1 Then
                            Generate_DGVRows = True
                        End If
                    Next
            End Select
            Sleep(100)
            Select Case Generate_DGVRows
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Rows.Count - 1
                        Sleep(10)
                        MktngInventory_BGW.ReportProgress(i)
                    Next
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            MktngInventory_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        End Try

        If MktngInventory_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub


    Private Sub MktngInventory_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case Generate_DGVCols
                Case True
                    If e.ProgressPercentage = 0 Then
                        If Not Controls.Contains(Inv_DGV) Then
                            DGV_Properties(Inv_DGV, "Inv_DGV")
                            Controls.Add(Inv_DGV)

                            AddHandler Inv_DGV.RowPostPaint, AddressOf MktngInventoryDGV_RowPostPaint
                            AddHandler Inv_DGV.RowEnter, AddressOf MktngInventoryDGV_RowEnter
                            AddHandler Inv_DGV.CellMouseClick, AddressOf MktngInventoryDGV_CellMouseClick
                            AddHandler Inv_DGV.ColumnHeaderMouseClick, AddressOf MktngInventoryDGV_ColumnHeaderMouseClick
                        End If
                    End If
                    Dim inv_dgvCol As New DataGridViewColumn
                    Dim cell As DataGridViewCell = New DataGridViewTextBoxCell()
                    If e.ProgressPercentage < sqlDataSet.Tables("QUERY_DETAILS").Columns.Count Then
                        With inv_dgvCol
                            .Name = sqlDataSet.Tables("QUERY_DETAILS").Columns(e.ProgressPercentage).ToString
                            .HeaderText = inv_dgvCol.Name
                            .CellTemplate = cell
                            .SortMode = DataGridViewColumnSortMode.Automatic
                            If .Name.Contains("PRICE") Or .Name = "DISCOUNT" Then
                                .ValueType = GetType(Decimal)
                                .DefaultCellStyle.Format = "N2"
                                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            End If
                            If .Name = "QUANTITY" Then
                                .ValueType = GetType(Integer)
                                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            End If
                            If .Name = "ITEM_PICTURE" Or .Name = "MI_STATUS" Or .Name = "MI_ID" Or .Name = "ITEM CODE" Or
                               .Name = "PURCHASED PRICE" Or .Name = "DISCOUNT" Or .Name = "GENDER" Then
                                .Visible = False
                            End If
                            If .Name = "DATE PURCHASED" Then
                                .ValueType = GetType(Date)
                                .DefaultCellStyle.Format = "MMM. dd, yyyy"
                                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            End If
                        End With
                        Inv_DGV.Columns.Add(inv_dgvCol)
                    End If
            End Select


            Select Case Generate_DGVRows
                Case True
                    Select Case Generate_DGVCols
                        Case True
                            Generate_DGVCols = False
                        Case False
                            DGVrow_list.Clear()
                            For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                                If i = 11 Then
                                    DGVrow_list.Add(Convert.ToDateTime(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i)))
                                ElseIf i = 7 Then
                                    DGVrow_list.Add(Convert.ToInt32(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i)))
                                ElseIf i = 8 Or i = 9 Or i = 10 Then
                                    DGVrow_list.Add(Convert.ToDecimal(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i)))
                                Else
                                    DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i).ToString)
                                End If
                            Next
                            Inv_DGV.Rows.Add(DGVrow_list.ToArray)
                            If e.ProgressPercentage = sqlDataSet.Tables("QUERY_DETAILS").Rows.Count - 1 Then
                                Generate_DGVRows = False
                            End If
                    End Select
            End Select

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
        End Try
    End Sub

    Private Sub MktngInventory_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                ' if BackgroundWorker terminated due to error
                LoadingPB.Visible = False
            Else
                '' otherwise it completed normally
                If sql_Err_no = -2 Then
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect" & vbCrLf & "Cancel to Exit",
                                                       "Request Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    If result = DialogResult.OK Then
                        RESET()
                        Start_MktngInventoryBGW()
                        Exit Sub
                    ElseIf result = DialogResult.Cancel Then
                        RESET()
                        Dispose()
                        Exit Sub
                    End If
                ElseIf sql_Err_no = 1232 Or sql_Err_no = 121 Then
                    'MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf sql_Err_no = 19 Then
                    'MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back inv_dgvCol.S.inv_dgvCol.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (sql_Err_no = "" Or sql_Err_no = Nothing) AndAlso
                       (sql_Err_msg = "" Or sql_Err_msg = Nothing) Then
                    If sql_Transaction_result = "Committed" Then
                        'Wala ng halaga to, Hanap ka ng use nito Future EJ
                        '-Past EJ

                        'Generate_DGVCols = False
                        'Generate_DGVRows = False
                        'sqlDataSet.Clear()
                        'DGVrow_list.Clear()

                        'Inv_Pnl.Controls.Clear()
                        'DGV_Properties(Inv_DGV)
                        'Inv_Pnl.Controls.Add(Inv_DGV)

                        'Inv_DGV.DataSource = Nothing
                        'Inv_DGV.Enabled = True
                        'Inv_DGV.DataSource = sqlBindingSource

                        'With Inv_DGV
                        '    .Columns("ITEM_PICTURE").Visible = False
                        '    .Columns("MI_STATUS").Visible = False
                        'End With
                        'Select Case MktngInv_TODO
                        '    Case "Onload"
                        '        With Inv_DGV
                        '            .Columns("MI_ID").Visible = False
                        '            .Columns("ITEM CODE").Visible = False
                        '            .Columns("PURCHASED PRICE").Visible = False
                        '            .Columns("DISCOUNT").Visible = False
                        '            .Columns("GENDER").Visible = False
                        'Inv_DGV.Columns("DATE PURCHASED").DefaultCellStyle.Format = "MMM. dd, yyyy"
                        '            .DefaultCellStyle.BackColor = Color.White
                        '            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                        '        End With
                        '    Case "Search"
                        '        If ColumnVisibility_Opened = True Then
                        '            With ColumnVisibility
                        '                For Each ctrl In .FLP_ColumnInvi.Controls
                        '                    For Each dgvCol In Inv_DGV.Columns
                        '                        If ctrl.Name = dgvCol.HeaderText Then
                        '                            dgvCol.Visible = ctrl.Checked
                        '                        End If
                        '                    Next
                        '                Next
                        '            End With
                        '        Else
                        '            With Inv_DGV
                        '                .Columns("MI_ID").Visible = False
                        '                .Columns("ITEM CODE").Visible = False
                        '                .Columns("PURCHASED PRICE").Visible = False
                        '                .Columns("DISCOUNT").Visible = False
                        '                .Columns("GENDER").Visible = False
                        '                .Columns("DATE PURCHASED").DefaultCellStyle.Format = "MMM. dd, yyyy"
                        '                .DefaultCellStyle.BackColor = Color.White
                        '                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                        '            End With
                        '        End If
                        'End Select
                    End If
                End If
            End If
            RESET()
            LoadingPB.Visible = False

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MktngInventoryDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub

    Private Sub MktngInventoryDGV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            ColumnToolStripMenuItem.Visible = True
            ItemToolStripMenuItem.Visible = False
            AddQuantityToolStripMenuItem.Visible = False
            MktngInv_Cmenu.Show()
            MktngInv_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub ColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnToolStripMenuItem.Click
        Try
            OpenedByFormName = Me
            DGVStrGlobal = "Inv_DGV"
            Dim frm As Form = ColumnVisibility
            Select Case frm.Visible
                Case True
                    frm.BringToFront()
                Case False
                    frm.Show()
                    frm.BringToFront()
            End Select
            ColumnVisibility_Opened = True
            Enabled = False
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub SearchFn(sender As Object, e As KeyEventArgs) Handles Me.KeyDown ',MktngInventoryDGV.KeyDown,  Mktng_InvLBL.KeyDown
        Try
            If e.KeyCode = Keys.F2 Or (e.Control And e.KeyCode = Keys.F) Then
                MKTNG_SearchFRM.Show()
                MKTNG_SearchFRM.TopMost = True
            ElseIf e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Back Then
                MktngInv_TODO = "Search"
                Mktng_SearchStr = ""
                Inv_DGV.Rows.Clear()
                Start_MktngInventoryBGW()
            ElseIf e.KeyCode = Keys.Escape Then
                Close()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub MktngInventoryDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If e.Button = MouseButtons.Right Then
                'Inv_DGV.Rows(e.RowIndex).Selected = True
                ColumnToolStripMenuItem.Visible = False
                ItemToolStripMenuItem.Visible = True
                AddQuantityToolStripMenuItem.Visible = True
                MktngInv_Cmenu.Show()
                MktngInv_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Sub MKTNG_Item_Open()
        Dim frm As Form = MKTNG_Item
        Select Case frm.Visible
            Case True
                frm.BringToFront()
            Case False
                frm.Show()
                frm.BringToFront()
        End Select
    End Sub

    Private Sub AddItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem1.Click
        Try
            MKTNG_Item.OpenedByToolStripMenu = "ADD"
            MKTNG_Item_Open()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub UpdateItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateItemToolStripMenuItem1.Click
        Try
            MKTNG_Item.OpenedByToolStripMenu = "UPDATE"
            MKTNG_Item_Open()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub DeleteItemToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteItemToolStripMenuItem1.Click
        Try

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub MKTNG_Inventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            KMDI_MainFRM.BringToFront()

            'PD_UpdateHeader.Dispose()
            'PD_SearchFRM.Dispose()
            'NewProject_Register.Dispose()

            'PD_Addendum.Dispose()
            'PD_TechPartners.Dispose()
            'PD_UpdateCOMP.Dispose()
            'PD_UpdateEMP.Dispose()

            'PD_SalesJobOrder.Dispose()
            'PD_PertDetails.Dispose()
            'PD_JoAttach.Dispose()

            Dispose()

            e.Cancel = False
        End If
    End Sub

    Private Sub AddQuantityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQuantityToolStripMenuItem.Click
        Try
            Dim frm As Form = MKTNG_AddQuantity
            Select Case frm.Visible
                Case True
                    frm.BringToFront()
                Case False
                    frm.Show()
                    frm.BringToFront()
            End Select
            Enabled = False
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub MktngInventoryDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                Inv_DGV.Rows(e.RowIndex).Selected = True
                INV_DGV_ROWINDEX = e.RowIndex
                MI_ID = Inv_DGV.Item("MI_ID", e.RowIndex).Value.ToString
                ITEM_CODE = Inv_DGV.Item("ITEM CODE", e.RowIndex).Value.ToString
                BRAND = Inv_DGV.Item("BRAND", e.RowIndex).Value.ToString
                ITEM_DESC = Inv_DGV.Item("DESCRIPTION", e.RowIndex).Value.ToString
                M_COLOR = Inv_DGV.Item("COLOR", e.RowIndex).Value.ToString
                M_SIZE = Inv_DGV.Item("SIZE", e.RowIndex).Value.ToString
                GENDER = Inv_DGV.Item("GENDER", e.RowIndex).Value.ToString
                MARKET_PRICE = Inv_DGV.Item("MARKET PRICE", e.RowIndex).Value.ToString
                PURCHASED_PRICE = Inv_DGV.Item("PURCHASED PRICE", e.RowIndex).Value.ToString
                QUANTITY = Inv_DGV.Item("QUANTITY", e.RowIndex).Value.ToString
                PURCHASED_DATE = Inv_DGV.Item("DATE PURCHASED", e.RowIndex).Value.ToString
                REMARKS = Inv_DGV.Item("REMARKS", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
End Class