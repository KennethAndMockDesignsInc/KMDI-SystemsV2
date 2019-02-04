Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Public Class TE_Installation_CPanel
    Public InsCPanel_BGW As BackgroundWorker = New BackgroundWorker
    Public InsCPanel_TODO As String
    Dim Generate_DGVCols, Generate_DGVRows As Boolean
    Dim DGVrow_list As New List(Of Object)
    Public InsCpanel_DGV As New KryptonDataGridView

    Dim XS As Integer = 0, S As Integer = 0, M As Integer = 0, L As Integer = 0, XL As Integer = 0
    Dim Profile_Type As String = Nothing
    Public Sub Start_InsCPanelBGW()
        If InsCPanel_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            InsCPanel_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub TE_Installation_CPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InsCPanel_BGW.WorkerSupportsCancellation = True
            InsCPanel_BGW.WorkerReportsProgress = True
            AddHandler InsCPanel_BGW.DoWork, AddressOf InsCPanel_BGW_DoWork
            AddHandler InsCPanel_BGW.ProgressChanged, AddressOf InsCPanel_BGW_ProgressChanged
            AddHandler InsCPanel_BGW.RunWorkerCompleted, AddressOf InsCPanel_BGW_RunWorkerCompleted
            InsCPanel_TODO = "Search"
            Start_InsCPanelBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub InsCPanel_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case InsCPanel_TODO
                Case "Search"
                    Generate_DGVCols = True
                    TMLMNT_QUERY_INSTANCE = "Loading_using_SearchString"
                    TMLMNT_Query_Select_STP("", "TE_stp_Search")
                Case "ADD"
                    TMLMNT_Insert("TE_stp_ADD", Profile_Type, XS, S, M, L, XL)
            End Select

            Select Case Generate_DGVCols
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                        Sleep(100)
                        InsCPanel_BGW.ReportProgress(i)
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
                        InsCPanel_BGW.ReportProgress(i)
                    Next
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            InsCPanel_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        Catch EX2 As Exception
            KMDIPrompts(Me, "DotNetError", EX2.Message, EX2.StackTrace, Nothing, True)
        End Try

        If InsCPanel_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub InsCPanel_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case Generate_DGVCols
                Case True
                    If e.ProgressPercentage = 0 Then
                        If Not Dgv_PNL.Controls.Contains(InsCpanel_DGV) Then
                            DGV_Properties(InsCpanel_DGV, "InsCpanel_DGV")
                            Dgv_PNL.Controls.Add(InsCpanel_DGV)
                            'AddHandler InsCpanel_DGV.RowPostPaint, AddressOf InsCpanel_DGV_RowPostPaint
                            'AddHandler InsCpanel_DGV.RowEnter, AddressOf InsCpanel_DGV_RowEnter
                            'AddHandler InsCpanel_DGV.CellMouseClick, AddressOf InsCpanel_DGV_CellMouseClick
                            'AddHandler InsCpanel_DGV.ColumnHeaderMouseClick, AddressOf InsCpanel_DGV_ColumnHeaderMouseClick
                        End If
                    End If
                    Dim dgvCol As New DataGridViewColumn
                    Dim cell As DataGridViewCell = New DataGridViewTextBoxCell()
                    If e.ProgressPercentage < sqlDataSet.Tables("QUERY_DETAILS").Columns.Count Then
                        With dgvCol
                            .Name = sqlDataSet.Tables("QUERY_DETAILS").Columns(e.ProgressPercentage).ToString
                            .HeaderText = dgvCol.Name
                            .CellTemplate = cell
                            .SortMode = DataGridViewColumnSortMode.Automatic
                            If .Name = "TE_ID" Then
                                .ValueType = GetType(Integer)
                                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            End If
                            If .Name = "TE_ID" Then
                                .Visible = False
                            End If
                        End With
                        InsCpanel_DGV.Columns.Add(dgvCol)
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
                                DGVrow_list.Add(Convert.ToInt32(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i)))
                            Next
                            InsCpanel_DGV.Rows.Add(DGVrow_list.ToArray)
                    End Select
            End Select

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
        End Try
    End Sub

    Private Sub InsCPanel_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                ' if BackgroundWorker terminated due to error
                LoadingPB.Visible = False
            Else
                '' otherwise it completed normally
                If sql_Transaction_result = "Committed" Then
                    Select Case InsCPanel_TODO
                        Case "Search"
                            If sqlDataSet.Tables("QUERY_DETAILS").Rows.Count <> 0 Then
                                With ProfileType_Cbox
                                    .DataSource = sqlDataSet
                                    .ValueMember = "TE_ID"
                                    .DisplayMember = "PROFILE_TYPE"
                                End With
                            End If
                            Generate_DGVCols = False
                        Case "ADD"
                            If sqlDataSet.Tables("QUERY_DETAILS").Rows.Count <> 0 Then
                                With ProfileType_Cbox
                                    .DataSource = sqlDataSet
                                    .ValueMember = "TE_ID"
                                    .DisplayMember = "PROFILE_TYPE"
                                End With
                            End If
                            InsCpanel_DGV.Rows.Add(InsertedTE_ID, XS, S, M, L, XL, Profile_Type)
                    End Select
                End If
            End If
            RESET()
            LoadingPB.Visible = False
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
        End Try
    End Sub
    Private Sub ProfileType_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles ProfileType_Tbox.ButtonClick
        Try
            Profile_Type = Trim(ProfileType_Tbox.Text)
            XS = XS_Tbox.Text
            S = S_Tbox.Text
            M = M_Tbox.Text
            L = L_Tbox.Text
            XL = XL_Tbox.Text
            InsCpanel_DGV.Rows.Clear()
            InsCPanel_TODO = "ADD"
            Start_InsCPanelBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

End Class