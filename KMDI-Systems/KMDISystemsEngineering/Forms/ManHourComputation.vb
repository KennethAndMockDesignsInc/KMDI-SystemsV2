﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Public Class ManHourComputation
    Public MHC_BGW As BackgroundWorker = New BackgroundWorker
    Public MHC_TODO As String
    Public MHC_DGV As New KryptonDataGridView
    Dim STF_ID As Integer
    Dim SYSTEM_TYPE As String
    Dim FACTOR As TimeSpan
    Dim Generate_DGVCols, Generate_DGVRows As Boolean
    Dim DGVrow_list As New List(Of Object)
    Public Sub Start_MHCBGW()
        If MHC_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            MHC_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ManHourComputation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DGV_Pnl.Dock = DockStyle.Fill
            MHC_BGW.WorkerSupportsCancellation = True
            MHC_BGW.WorkerReportsProgress = True
            AddHandler MHC_BGW.DoWork, AddressOf MHC_BGW_DoWork
            AddHandler MHC_BGW.ProgressChanged, AddressOf MHC_BGW_ProgressChanged
            AddHandler MHC_BGW.RunWorkerCompleted, AddressOf MHC_BGW_RunWorkerCompleted
            MHC_TODO = "Onload"
            Start_MHCBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub MHC_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MHC_TODO
                Case "Onload"
                    Generate_DGVCols = True
                    ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
                    Engr_Query_Select_STP("", "ENGR_stp_ManHourCompute")
                Case "ADD"
                    Generate_DGVCols = False
                    Engr_SystemNfactor_INSERT("ENGR_stp_ManHourCompute_INSERT", SYSTEM_TYPE, FACTOR)
            End Select

            Select Case Generate_DGVCols
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                        Sleep(100)
                        MHC_BGW.ReportProgress(i)
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
                        MHC_BGW.ReportProgress(i)
                    Next
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            MHC_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        End Try

        If MHC_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub
    Dim AASDASD As Integer = 0
    Private Sub MHC_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case Generate_DGVCols
                Case True
                    If e.ProgressPercentage = 0 Then
                        If Not DGV_Pnl.Contains(MHC_DGV) Then
                            DGV_Properties(MHC_DGV, "MHC_DGV")
                            DGV_Pnl.Controls.Add(MHC_DGV)

                            AddHandler MHC_DGV.RowPostPaint, AddressOf MHCDGV_RowPostPaint
                            AddHandler MHC_DGV.RowEnter, AddressOf MHCDGV_RowEnter
                            AddHandler MHC_DGV.CellMouseClick, AddressOf MHCDGV_CellMouseClick
                            AddHandler MHC_DGV.MouseClick, AddressOf MHC_DGV_MouseClick
                        End If
                    End If
                    Dim MHC_dgvCol As New DataGridViewColumn
                    Dim cell As DataGridViewCell = New DataGridViewTextBoxCell()
                    If e.ProgressPercentage < sqlDataSet.Tables("QUERY_DETAILS").Columns.Count Then
                        With MHC_dgvCol
                            .Name = sqlDataSet.Tables("QUERY_DETAILS").Columns(e.ProgressPercentage).ToString
                            .HeaderText = MHC_dgvCol.Name
                            .CellTemplate = cell
                            .SortMode = DataGridViewColumnSortMode.Automatic
                            If .Name.Contains("FACTOR") Then
                                .ValueType = GetType(TimeSpan)
                                .DefaultCellStyle.Format = "c"
                            End If
                            If .Name = "STF_ID" Then
                                .Visible = False
                            End If
                        End With
                        MHC_DGV.Columns.Add(MHC_dgvCol)
                    End If
            End Select

            Select Case Generate_DGVRows
                Case True
                    Select Case Generate_DGVCols
                        Case True
                            Generate_DGVCols = False
                        Case False
                            DGVrow_list.Clear()
                            For I = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                                DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(I))
                            Next
                            MHC_DGV.Rows.Add(DGVrow_list.ToArray)
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

    Private Sub MHC_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
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
                        Start_MHCBGW()
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
                        Select Case MHC_TODO
                            Case "Onload"
                                MHC_DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                                DGV_Pnl.Dock = DockStyle.Fill
                            Case "ADD"
                                MHC_DGV.Rows.Add(InsertedSTF_ID, SYSTEM_TYPE, FACTOR)
                                KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                        End Select
                    End If
                End If
            End If
            RESET()
            LoadingPB.Visible = False

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub MHCDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub
    Private Sub MHCDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                With MHC_DGV
                    .Rows(e.RowIndex).Selected = True
                    STF_ID = .Item("STF_ID", e.RowIndex).Value
                    SYSTEM_TYPE = .Item("SYSTEM TYPE", e.RowIndex).Value
                    FACTOR = .Item("FACTOR", e.RowIndex).Value

                    SysType_Tbox.Text = SYSTEM_TYPE
                    Factor_Tbox.Text = FACTOR.ToString("c")
                End With
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub MHC_DGV_MouseClick(sender As Object, e As MouseEventArgs)
        Try
            If e.Button = MouseButtons.Right Then
                MHC_Cmenu.Show()
                MHC_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub MHCDGV_CellMouseClick(SENDER As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                With MHC_DGV
                    .Rows(e.RowIndex).Selected = True
                    STF_ID = .Item("STF_ID", e.RowIndex).Value
                    SYSTEM_TYPE = .Item("SYSTEM TYPE", e.RowIndex).Value
                    FACTOR = .Item("FACTOR", e.RowIndex).Value

                    SysType_Tbox.Text = SYSTEM_TYPE
                    Factor_Tbox.Text = FACTOR.ToString("c")
                End With
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub ManHourComputation_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) Then
                If DGV_Pnl.Dock = DockStyle.Top Then
                    SYSTEM_TYPE = SysType_Tbox.Text
                    FACTOR = TimeSpan.Parse(Factor_Tbox.Text)
                    If MHC_TODO = "ADD" Then
                        Start_MHCBGW()
                    End If
                    DGV_Pnl.Dock = DockStyle.Fill
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Try
            DGV_Pnl.Dock = DockStyle.Top
            SysType_Tbox.Text = Nothing
            Factor_Tbox.Text = Nothing
            MHC_TODO = "ADD"
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Try
            DGV_Pnl.Dock = DockStyle.Top
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
End Class