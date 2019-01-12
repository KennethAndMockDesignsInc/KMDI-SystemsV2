Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Public Class MKTNG_Inventory
    Public MktngInventory_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngInv_TODO As String

    Public Sub Start_MktngInventoryBGW()
        If MktngInventory_BGW.IsBusy <> True Then
            MktngInventoryDGV.Enabled = False
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
                    Mktng_QUERY_INSTANCE = "Loading_using_SearchString"
                    Mktng_Query_Select_STP("", "MKTNG_stp_Inv_Search")
                Case "Search"
                    Mktng_QUERY_INSTANCE = "Loading_using_SearchString"
                    Mktng_Query_Select_STP(Mktng_SearchStr, "MKTNG_stp_Inv_Search")
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
    Public ColumnVisibility_Opened As Boolean = False
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
                    MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf sql_Err_no = 19 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf (sql_Err_no = "" Or sql_Err_no = Nothing) AndAlso
                       (sql_Err_msg = "" Or sql_Err_msg = Nothing) Then
                    If sql_Transaction_result = "Committed" Then
                        MktngInventoryDGV.DataSource = Nothing
                        MktngInventoryDGV.Enabled = True
                        MktngInventoryDGV.DataSource = sqlBindingSource

                        With MktngInventoryDGV
                            .Columns("ITEM_PICTURE").Visible = False
                            .Columns("MI_STATUS").Visible = False
                        End With
                        Select Case MktngInv_TODO
                            Case "Onload"
                                With MktngInventoryDGV
                                    .Columns("MI_ID").Visible = False
                                    .Columns("ITEM CODE").Visible = False
                                    .Columns("PURCHASED PRICE").Visible = False
                                    .Columns("DISCOUNT").Visible = False
                                    .Columns("GENDER").Visible = False
                                    .Columns("DATE PURCHASED").DefaultCellStyle.Format = "MMM. dd, yyyy"
                                    .DefaultCellStyle.BackColor = Color.White
                                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                End With
                            Case "Search"
                                If ColumnVisibility_Opened = True Then
                                    With ColumnVisibility
                                        For Each ctrl In .FLP_ColumnInvi.Controls
                                            For Each dgvCol In MktngInventoryDGV.Columns
                                                If ctrl.Name = dgvCol.HeaderText Then
                                                    dgvCol.Visible = ctrl.Checked
                                                End If
                                            Next
                                        Next
                                    End With
                                Else
                                    With MktngInventoryDGV
                                        .Columns("MI_ID").Visible = False
                                        .Columns("ITEM CODE").Visible = False
                                        .Columns("PURCHASED PRICE").Visible = False
                                        .Columns("DISCOUNT").Visible = False
                                        .Columns("GENDER").Visible = False
                                        .Columns("DATE PURCHASED").DefaultCellStyle.Format = "MMM. dd, yyyy"
                                        .DefaultCellStyle.BackColor = Color.White
                                        .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                                    End With
                                End If
                        End Select
                    End If
                End If
            End If
            RESET()
            LoadingPB.Visible = False
            MktngInventoryDGV.Focus()
            MktngInventoryDGV.Select()

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, True)
        End Try
    End Sub

    Private Sub MktngInventoryDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MktngInventoryDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub MktngInventoryDGV_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MktngInventoryDGV.ColumnHeaderMouseClick
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
            DGVStrGlobal = "MktngInventoryDGV"
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
                Start_MktngInventoryBGW()
            ElseIf e.KeyCode = Keys.Escape Then
                Close()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub

    Private Sub MktngInventoryDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MktngInventoryDGV.CellMouseClick
        Try
            If e.Button = MouseButtons.Right Then
                MktngInventoryDGV.Rows(e.RowIndex).Selected = True
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

    Private Sub MktngInventoryDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles MktngInventoryDGV.RowEnter
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                MI_ID = MktngInventoryDGV.Item("MI_ID", e.RowIndex).Value.ToString
                ITEM_CODE = MktngInventoryDGV.Item("ITEM CODE", e.RowIndex).Value.ToString
                BRAND = MktngInventoryDGV.Item("BRAND", e.RowIndex).Value.ToString
                ITEM_DESC = MktngInventoryDGV.Item("DESCRIPTION", e.RowIndex).Value.ToString
                M_COLOR = MktngInventoryDGV.Item("COLOR", e.RowIndex).Value.ToString
                M_SIZE = MktngInventoryDGV.Item("SIZE", e.RowIndex).Value.ToString
                GENDER = MktngInventoryDGV.Item("GENDER", e.RowIndex).Value.ToString
                MARKET_PRICE = MktngInventoryDGV.Item("MARKET PRICE", e.RowIndex).Value.ToString
                PURCHASED_PRICE = MktngInventoryDGV.Item("PURCHASED PRICE", e.RowIndex).Value.ToString
                QUANTITY = MktngInventoryDGV.Item("QUANTITY", e.RowIndex).Value.ToString
                PURCHASED_DATE = MktngInventoryDGV.Item("DATE PURCHASED", e.RowIndex).Value.ToString
                REMARKS = MktngInventoryDGV.Item("REMARKS", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
End Class