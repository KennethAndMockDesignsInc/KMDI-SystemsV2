Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Public Class Engr_STWDT_Maintenance
    Public STWDT_BGW As BackgroundWorker = New BackgroundWorker
    Public STWDT_DGV As New KryptonDataGridView
    Dim STF_ID, STWDT_ROWINDEX As Integer
    Dim SYSTEM_TYPE, Cmenu_Clicked, STWDT_TODO As String
    Dim FACTOR As TimeSpan
    Dim ReportBGW_bool As Boolean
    Dim DGVrow_list As New List(Of Object)
    Sub Start_STWDTBGW()
        If STWDT_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            STWDT_BGW.RunWorkerAsync()
        Else
            KMDIPrompts(Me, "UserWarning", Nothing, Nothing, Nothing, True, True, "Please Wait!")
        End If
    End Sub
    Private Sub Engr_STWDT_Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WDTRdBtn_Pnl.Dock = DockStyle.Fill
            STWDT_BGW.WorkerSupportsCancellation = True
            STWDT_BGW.WorkerReportsProgress = True
            AddHandler STWDT_BGW.DoWork, AddressOf STWDT_BGW_DoWork
            AddHandler STWDT_BGW.ProgressChanged, AddressOf STWDT_BGW_ProgressChanged
            AddHandler STWDT_BGW.RunWorkerCompleted, AddressOf STWDT_BGW_RunWorkerCompleted
            STWDT_TODO = "SystemType"
            Start_STWDTBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub STWDT_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case STWDT_TODO
                Case "SystemType"
                    ReportBGW_bool = True
                    ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
                    Engr_Query_Select_STP("", "ENGR_stp_STWDT_SystemType")
            End Select

            Select Case ReportBGW_bool
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Rows.Count - 1
                        Sleep(100)
                        STWDT_BGW.ReportProgress(i)
                    Next
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            STWDT_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        End Try

        If STWDT_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub
    Private Sub STWDT_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case STWDT_TODO
                Case "SystemType"
                    Using RdBtn As New MetroFramework.Controls.MetroRadioButton
                        With RdBtn
                            .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("SYSTEM_TYPE").ToString
                            .Text = .Name
                            .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("ST_ID").ToString
                            .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                            EngrToolTip.SetToolTip(RdBtn, .Text)
                            'AddHandler .Click, AddressOf ClassRbtn_Clicked
                            STRdBtn_Pnl.Controls.Add(RdBtn)
                        End With
                    End Using
            End Select
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
        End Try
    End Sub
    Private Sub STWDT_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
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
                        Start_STWDTBGW()
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
                        Select Case STWDT_TODO
                            Case "Onload"
                        End Select
                        WDTRdBtn_Pnl.Dock = DockStyle.Fill
                    End If
                End If
            End If
            RESET()
            LoadingPB.Visible = False

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
End Class