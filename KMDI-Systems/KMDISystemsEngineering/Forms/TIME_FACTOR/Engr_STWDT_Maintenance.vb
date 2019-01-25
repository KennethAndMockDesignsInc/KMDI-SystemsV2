Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Public Class Engr_STWDT_Maintenance
    Public STWDT_BGW As BackgroundWorker = New BackgroundWorker
    Dim ST_ID, WDT_ID, TFactor_Hrs, TFactor_Mins, TFactor_Secs As Integer
    Dim STWDT_TODO, SystemType_Str, WindowType_Str, FRAME_OR_SCREEN As String
    Dim T_FACTOR As TimeSpan
    Dim ReportBGW_bool, TrueIFSystemType_bool As Boolean
    Dim DGVrow_list As New List(Of Object)
    Sub Start_STWDTBGW()
        If STWDT_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            Frm_PNL.Enabled = False
            STWDT_BGW.RunWorkerAsync()
        Else
            KMDIPrompts(Me, "UserWarning", Nothing, Nothing, Nothing, True, True, "Please Wait!")
        End If
    End Sub
    Sub reset_here()
        WindowType_Tbox.Clear()
        WindowType_Str = Nothing
        InsertedWDT_ID = Nothing

        SystemType_Tbox.Clear()
        SystemType_Str = Nothing
        InsertedST_ID = Nothing
        RESET()
        LoadingPB.Visible = False
        Frm_PNL.Enabled = True
        With SystemType_Tbox
            .Style = MetroFramework.MetroColorStyle.Silver
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
        With WindowType_Tbox
            .Style = MetroFramework.MetroColorStyle.Silver
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
    End Sub
    Private Sub Engr_STWDT_Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            STWDT_BGW.WorkerSupportsCancellation = True
            STWDT_BGW.WorkerReportsProgress = True
            AddHandler STWDT_BGW.DoWork, AddressOf STWDT_BGW_DoWork
            AddHandler STWDT_BGW.ProgressChanged, AddressOf STWDT_BGW_ProgressChanged
            AddHandler STWDT_BGW.RunWorkerCompleted, AddressOf STWDT_BGW_RunWorkerCompleted
            FrameScreen_Cbox.SelectedIndex = 0
            FRAME_OR_SCREEN = "Frame"
            STWDT_TODO = "Onload"
            Start_STWDTBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub STWDT_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            If STWDT_TODO = "SystemType" Or STWDT_TODO = "Onload" Then
                ReportBGW_bool = True
                ENGR_QUERY_INSTANCE = "Loading_using_EqualSearch"
                Engr_Query_Select_STP(FRAME_OR_SCREEN, "ENGR_stp_STWDT_SystemType")

            ElseIf STWDT_TODO = "WindowType" Then
                ReportBGW_bool = True
                ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
                Engr_Query_Select_STP("", "ENGR_stp_STWDT_WindowType")

            ElseIf STWDT_TODO = "SystemType_Insert" Then
                Engr_SystemType_INSERT("ENGR_stp_STWDT_SystemType_Insert", SystemType_Str, FRAME_OR_SCREEN)

            ElseIf STWDT_TODO = "SystemType_Update" Then
                Engr_SystemType_UPDATE("ENGR_stp_STWDT_SystemType_Update", SystemType_Str, FRAME_OR_SCREEN, ST_ID)

            ElseIf STWDT_TODO = "SystemType_Delete" Then
                Engr_SystemType_DELETE("ENGR_stp_STWDT_SystemType_Delete", ST_ID)

            ElseIf STWDT_TODO = "WindowType_Insert" Then
                Engr_WindowType_INSERT("ENGR_stp_STWDT_WindowType_Insert", WindowType_Str)

            ElseIf STWDT_TODO = "WindowType_Update" Then
                Engr_WindowType_UPDATE("ENGR_stp_STWDT_WindowType_Update", WindowType_Str, WDT_ID)

            ElseIf STWDT_TODO = "WindowType_Delete" Then
                Engr_WindowType_DELETE("ENGR_stp_STWDT_WindowType_Delete", WDT_ID)

            ElseIf STWDT_TODO = "Fetch_TFactor" Then
                Select Case FRAME_OR_SCREEN
                    Case "Frame"
                        Engr_Query_Select_T_FACTOR("ENGR_stp_STWDT_TFactor_Fetch", ST_ID, WDT_ID)
                    Case "Screen"
                        Engr_Query_Select_T_FACTOR("ENGR_stp_STWDT_TFactor_Fetch", ST_ID)
                End Select
            ElseIf STWDT_TODO = "Transact_TFactor" Then
                Engr_TFactor_Transact("ENGR_stp_STWDT_TFactor_Transact", ST_ID, WDT_ID, T_FACTOR)

            End If

            Select Case ReportBGW_bool
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Rows.Count - 1
                        Sleep(100)
                        STWDT_BGW.ReportProgress(i)
                    Next
            End Select
        Catch SQLex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            STWDT_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", SQLex.Message, SQLex.StackTrace, SQLex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "SqlError", ex2.Message, ex2.StackTrace)
            End Try
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try

        If STWDT_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub
    Private Sub STWDT_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
            If STWDT_TODO = "SystemType" Or STWDT_TODO = "Onload" Then
                If STRdBtn_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                    STRdBtn_FLP.Controls.Clear()
                End If
                RdBtn_Properties("Dynamic", RdBtn, "SYSTEM_TYPE", "ST_ID", e.ProgressPercentage, STWDT_Cmenu)
                AddHandler RdBtn.Click, AddressOf SysRbtn_Clicked
                STRdBtn_FLP.Controls.Add(RdBtn)

            ElseIf STWDT_TODO = "WindowType" Then
                If WDTRdBtn_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                    WDTRdBtn_FLP.Controls.Clear()
                End If
                RdBtn_Properties("Dynamic", RdBtn, "WINDOW_TYPE", "WDT_ID", e.ProgressPercentage, STWDT_Cmenu)
                AddHandler RdBtn.Click, AddressOf WDTRbtn_Clicked
                WDTRdBtn_FLP.Controls.Add(RdBtn)
            End If
            AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
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
                If sql_Transaction_result = "Committed" Then
                    Select Case STWDT_TODO
                        Case "Onload"
                            STWDT_TODO = "WindowType"
                            Start_STWDTBGW()

                        Case "SystemType"
                            ReportBGW_bool = False
                            reset_here()

                        Case "WindowType"
                            ReportBGW_bool = False
                            reset_here()

                        Case "SystemType_Insert"
                            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
                            RdBtn_Properties("Static", RdBtn, SystemType_Str, InsertedST_ID, Nothing, STWDT_Cmenu)
                            STRdBtn_FLP.Controls.Add(RdBtn)
                            AddHandler RdBtn.Click, AddressOf SysRbtn_Clicked
                            AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
                            reset_here()

                        Case "SystemType_Update"
                            For Each ctrl In STRdBtn_FLP.Controls
                                If ctrl.Tag = ST_ID Then
                                    ctrl.Text = Replace(SystemType_Str, "&", "&&")
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            STWDT_TODO = "SystemType"
                            Start_STWDTBGW()

                        Case "SystemType_Delete"
                            For Each ctrl In STRdBtn_FLP.Controls
                                If ctrl.Tag = ST_ID Then
                                    STRdBtn_FLP.Controls.Remove(ctrl)
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()

                        Case "WindowType_Insert"
                            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
                            RdBtn_Properties("Static", RdBtn, WindowType_Str, InsertedWDT_ID, Nothing, STWDT_Cmenu)
                            WDTRdBtn_FLP.Controls.Add(RdBtn)
                            AddHandler RdBtn.Click, AddressOf WDTRbtn_Clicked
                            AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
                            reset_here()

                        Case "WindowType_Update"
                            For Each ctrl In WDTRdBtn_FLP.Controls
                                If ctrl.Tag = WDT_ID Then
                                    ctrl.Text = Replace(WindowType_Str, "&", "&&")
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()

                        Case "WindowType_Delete"
                            For Each ctrl In WDTRdBtn_FLP.Controls
                                If ctrl.Tag = WDT_ID Then
                                    WDTRdBtn_FLP.Controls.Remove(ctrl)
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()

                        Case "Fetch_TFactor"
                            If sqlDataSet.Tables("QUERY_DETAILS").Rows.Count <> 0 Then
                                Dim TFactor_str As String = Replace(sqlDataSet.Tables("QUERY_DETAILS").Rows(0).Item("T_FACTOR").ToString, ":", "")
                                TFactor_Hrs = Convert.ToInt32(TFactor_str.Substring(0, 2))
                                TFactor_Mins = Convert.ToInt32(TFactor_str.Substring(2, 2))
                                TFactor_Secs = Convert.ToInt32(TFactor_str.Substring(4, 2))

                                TFactorHrs_Num.Value = TFactor_Hrs
                                TFactorMins_Num.Value = TFactor_Mins
                                TFactorSecs_Num.Value = TFactor_Secs
                            ElseIf sqlDataSet.Tables("QUERY_DETAILS").Rows.Count = 0 Then
                                TFactorHrs_Num.Value = 0
                                TFactorMins_Num.Value = 0
                                TFactorSecs_Num.Value = 0
                            End If
                            reset_here()

                        Case "Transact_TFactor"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()

                    End Select
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            reset_here()
        End Try
    End Sub
    Private Sub SysRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            ST_ID = sender.Tag
            STWDT_TODO = "Fetch_TFactor"
            Start_STWDTBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub WDTRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            WDT_ID = sender.Tag
            If ST_ID <> Nothing Then
                STWDT_TODO = "Fetch_TFactor"
                Start_STWDTBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub FrameScreen_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FrameScreen_Cbox.SelectionChangeCommitted
        Try
            FRAME_OR_SCREEN = FrameScreen_Cbox.Text
            If SystemType_Tbox.CustomButton.Text = "+" And SystemType_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If FrameScreen_Cbox.SelectedIndex = 0 Then
                    WDTRdBtn_FLP.Enabled = True
                    WindowType_Tbox.Enabled = True
                ElseIf FrameScreen_Cbox.SelectedIndex = 1 Then
                    WDTRdBtn_FLP.Enabled = False
                    WindowType_Tbox.Enabled = False
                End If
                STWDT_TODO = "SystemType"
                Start_STWDTBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            KMDIPrompts(Me, "Question", "Are you sure you want to Delete?", Nothing, Nothing, True)
            If QuestionPromptAnswer = 6 Then
                If TrueIFSystemType_bool = True Then
                    STWDT_TODO = "SystemType_Delete"

                Else TrueIFSystemType_bool = False
                    STWDT_TODO = "WindowType_Delete"

                End If
                Start_STWDTBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub Rbtn_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            sender.Select
            If sender.Parent.Name = "STRdBtn_FLP" Then
                SystemType_Str = sender.Text
                ST_ID = sender.Tag
                TrueIFSystemType_bool = True
            ElseIf sender.Parent.Name = "WDTRdBtn_FLP" Then
                WindowType_Str = sender.Text
                WDT_ID = sender.Tag
                TrueIFSystemType_bool = False
            End If
        End If
    End Sub
    Private Sub SystemType_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles SystemType_Tbox.ButtonClick
        Try
            SystemType_Str = Trim(SystemType_Tbox.Text)

            If SystemType_Tbox.CustomButton.Text = "+" And SystemType_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If SystemType_Str <> Nothing Or SystemType_Str <> "" Then
                    STWDT_TODO = "SystemType_Insert"
                    Start_STWDTBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "SystemType_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf SystemType_Tbox.CustomButton.Text = "U" And SystemType_Tbox.Style = MetroFramework.MetroColorStyle.Red Then
                If SystemType_Str <> Nothing Or SystemType_Str <> "" Then
                    If ST_ID <> Nothing Then
                        STWDT_TODO = "SystemType_Update"
                        Start_STWDTBGW()
                    Else
                        KMDIPrompts(Me, "UserWarning", "ST_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "WindowType_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            End If

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub Engr_STWDT_Maintenance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) Then
                If TFactorHrs_Num.Value > 23 Then
                    TFactor_Hrs = 23
                End If
                If TFactorMins_Num.Value > 59 Then
                    TFactor_Mins = 59
                End If
                If TFactorSecs_Num.Value > 59 Then
                    TFactor_Secs = 59
                End If
                T_FACTOR = TimeSpan.Parse(TFactorHrs_Num.Value & ":" & TFactorMins_Num.Value & ":" & TFactorSecs_Num.Value)
                Select Case FRAME_OR_SCREEN
                    Case "Frame"
                        If ST_ID <> Nothing Then
                            If WDT_ID <> Nothing Then
                                STWDT_TODO = "Transact_TFactor"
                                Start_STWDTBGW()
                            Else
                                KMDIPrompts(Me, "UserWarning", "WDT_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select Window Type")
                            End If
                        Else
                            KMDIPrompts(Me, "UserWarning", "ST_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                        End If
                    Case "Screen"
                        If ST_ID <> Nothing Then
                            STWDT_TODO = "Transact_TFactor"
                            Start_STWDTBGW()
                        Else
                            KMDIPrompts(Me, "UserWarning", "ST_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                        End If
                End Select

            ElseIf e.KeyCode = Keys.Escape Then
                reset_here()
            ElseIf e.KeyCode = Keys.F5 Then
                STWDT_TODO = "Onload"
                Start_STWDTBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If TrueIFSystemType_bool = True Then
                SystemType_Tbox.UseStyleColors = True
                SystemType_Tbox.Style = MetroFramework.MetroColorStyle.Red
                SystemType_Tbox.CustomButton.Text = "U"
                SystemType_Tbox.Text = Replace(SystemType_Str, "&&", "&")

            Else TrueIFSystemType_bool = False
                WindowType_Tbox.UseStyleColors = True
                WindowType_Tbox.Style = MetroFramework.MetroColorStyle.Red
                WindowType_Tbox.CustomButton.Text = "U"
                WindowType_Tbox.Text = Replace(WindowType_Str, "&&", "&")
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub WindowType_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles WindowType_Tbox.ButtonClick
        Try
            WindowType_Str = Trim(WindowType_Tbox.Text)

            If WindowType_Tbox.CustomButton.Text = "+" And WindowType_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If WindowType_Str <> Nothing Or WindowType_Str <> "" Then
                    STWDT_TODO = "WindowType_Insert"
                    Start_STWDTBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "WindowType_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf WindowType_Tbox.CustomButton.Text = "U" And WindowType_Tbox.Style = MetroFramework.MetroColorStyle.Red Then
                If WindowType_Str <> Nothing Or WindowType_Str <> "" Then
                    If WDT_ID <> Nothing Then
                        STWDT_TODO = "WindowType_Update"
                        Start_STWDTBGW()
                    Else
                        KMDIPrompts(Me, "UserWarning", "WDT_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select Window Type")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "WindowType_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub SystemType_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SystemType_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SystemType_Tbox.CustomButton.PerformClick()
        End If
    End Sub
    Private Sub WindowType_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles WindowType_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            WindowType_Tbox.CustomButton.PerformClick()
        End If
    End Sub
End Class