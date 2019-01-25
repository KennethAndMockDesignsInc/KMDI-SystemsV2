Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Public Class Engr_Time_Factor_Maintenance
    Public TFM_BGW As BackgroundWorker = New BackgroundWorker
    Dim ST_ID, WDT_ID, TFactor_Hrs, TFactor_Mins, TFactor_Secs As Integer
    Dim TFM_TODO, ProfileType_Str, WindowType_Str, FRAME_OR_SCREEN As String
    Dim T_FACTOR As TimeSpan
    Dim ReportBGW_bool, TrueIFProfileType_bool As Boolean
    Dim DGVrow_list As New List(Of Object)
    Sub Start_TFMBGW()
        If TFM_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            Frm_PNL.Enabled = False
            TFM_BGW.RunWorkerAsync()
        Else
            KMDIPrompts(Me, "UserWarning", Nothing, Nothing, Nothing, True, True, "Please Wait!")
        End If
    End Sub
    Sub reset_here()
        Left_Tbox.Clear()
        WindowType_Str = Nothing
        InsertedWDT_ID = Nothing

        Right_Tbox.Clear()
        ProfileType_Str = Nothing
        InsertedST_ID = Nothing
        RESET()
        LoadingPB.Visible = False
        Frm_PNL.Enabled = True
        With Right_Tbox
            .Style = MetroFramework.MetroColorStyle.Silver
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
        With Left_Tbox
            .Style = MetroFramework.MetroColorStyle.Silver
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
    End Sub
    Private Sub Engr_TFM_Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TFM_BGW.WorkerSupportsCancellation = True
            TFM_BGW.WorkerReportsProgress = True
            AddHandler TFM_BGW.DoWork, AddressOf TFM_BGW_DoWork
            AddHandler TFM_BGW.ProgressChanged, AddressOf TFM_BGW_ProgressChanged
            AddHandler TFM_BGW.RunWorkerCompleted, AddressOf TFM_BGW_RunWorkerCompleted
            FrameScreen_Cbox.SelectedIndex = 0
            FRAME_OR_SCREEN = "Frame"
            TFM_TODO = "Onload"
            Start_TFMBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub TFM_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            If TFM_TODO = "ProfileType" Or TFM_TODO = "Onload" Then
                ReportBGW_bool = True
                ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
                Engr_Query_Select_STP("", "ENGR_stp_FRAME_ProfileType")

            ElseIf TFM_TODO = "WindowType" Then
                ReportBGW_bool = True
                ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
                Engr_Query_Select_STP("", "ENGR_stp_TFM_WindowType")

            ElseIf TFM_TODO = "ProfileType_Insert" Then
                Engr_ProfileType_INSERT("ENGR_stp_TFM_ProfileType_Insert", ProfileType_Str, FRAME_OR_SCREEN)

            ElseIf TFM_TODO = "ProfileType_Update" Then
                Engr_ProfileType_UPDATE("ENGR_stp_TFM_ProfileType_Update", ProfileType_Str, FRAME_OR_SCREEN, ST_ID)

            ElseIf TFM_TODO = "ProfileType_Delete" Then
                Engr_ProfileType_DELETE("ENGR_stp_TFM_ProfileType_Delete", ST_ID)

            ElseIf TFM_TODO = "WindowType_Insert" Then
                Engr_WindowType_INSERT("ENGR_stp_TFM_WindowType_Insert", WindowType_Str)

            ElseIf TFM_TODO = "WindowType_Update" Then
                Engr_WindowType_UPDATE("ENGR_stp_TFM_WindowType_Update", WindowType_Str, WDT_ID)

            ElseIf TFM_TODO = "WindowType_Delete" Then
                Engr_WindowType_DELETE("ENGR_stp_TFM_WindowType_Delete", WDT_ID)

            ElseIf TFM_TODO = "Fetch_TFactor" Then
                Select Case FRAME_OR_SCREEN
                    Case "Frame"
                        Engr_Query_Select_T_FACTOR("ENGR_stp_TFM_TFactor_Fetch", ST_ID, WDT_ID)
                    Case "Screen"
                        Engr_Query_Select_T_FACTOR("ENGR_stp_TFM_TFactor_Fetch", ST_ID)
                End Select
            ElseIf TFM_TODO = "Transact_TFactor" Then
                Engr_TFactor_Transact("ENGR_stp_TFM_TFactor_Transact", ST_ID, WDT_ID, T_FACTOR)

            End If

            Select Case ReportBGW_bool
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Rows.Count - 1
                        Sleep(100)
                        TFM_BGW.ReportProgress(i)
                    Next
            End Select
        Catch SQLex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            TFM_BGW.CancelAsync()
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

        If TFM_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TFM_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
            If TFM_TODO = "ProfileType" Or TFM_TODO = "Onload" Then
                If LeftRdBtn_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                    LeftRdBtn_FLP.Controls.Clear()
                End If
                RdBtn_Properties("Dynamic", RdBtn, "SYSTEM_TYPE", "ST_ID", e.ProgressPercentage, TFM_Cmenu)
                AddHandler RdBtn.Click, AddressOf SysRbtn_Clicked
                LeftRdBtn_FLP.Controls.Add(RdBtn)

            ElseIf TFM_TODO = "WindowType" Then
                If RightRdBtn_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                    RightRdBtn_FLP.Controls.Clear()
                End If
                RdBtn_Properties("Dynamic", RdBtn, "WINDOW_TYPE", "WDT_ID", e.ProgressPercentage, TFM_Cmenu)
                AddHandler RdBtn.Click, AddressOf WDTRbtn_Clicked
                RightRdBtn_FLP.Controls.Add(RdBtn)
            End If
            AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
        End Try
    End Sub
    Private Sub TFM_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                ' if BackgroundWorker terminated due to error
                LoadingPB.Visible = False
            Else
                '' otherwise it completed normally
                If sql_Transaction_result = "Committed" Then
                    Select Case TFM_TODO
                        Case "Onload"
                            TFM_TODO = "WindowType"
                            Start_TFMBGW()

                        Case "ProfileType"
                            ReportBGW_bool = False
                            reset_here()

                        Case "WindowType"
                            ReportBGW_bool = False
                            reset_here()

                        Case "ProfileType_Insert"
                            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
                            RdBtn_Properties("Static", RdBtn, ProfileType_Str, InsertedST_ID, Nothing, TFM_Cmenu)
                            LeftRdBtn_FLP.Controls.Add(RdBtn)
                            AddHandler RdBtn.Click, AddressOf SysRbtn_Clicked
                            AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
                            reset_here()

                        Case "ProfileType_Update"
                            For Each ctrl In LeftRdBtn_FLP.Controls
                                If ctrl.Tag = ST_ID Then
                                    ctrl.Text = Replace(ProfileType_Str, "&", "&&")
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            TFM_TODO = "ProfileType"
                            Start_TFMBGW()

                        Case "ProfileType_Delete"
                            For Each ctrl In LeftRdBtn_FLP.Controls
                                If ctrl.Tag = ST_ID Then
                                    LeftRdBtn_FLP.Controls.Remove(ctrl)
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()

                        Case "WindowType_Insert"
                            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
                            RdBtn_Properties("Static", RdBtn, WindowType_Str, InsertedWDT_ID, Nothing, TFM_Cmenu)
                            RightRdBtn_FLP.Controls.Add(RdBtn)
                            AddHandler RdBtn.Click, AddressOf WDTRbtn_Clicked
                            AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
                            reset_here()

                        Case "WindowType_Update"
                            For Each ctrl In RightRdBtn_FLP.Controls
                                If ctrl.Tag = WDT_ID Then
                                    ctrl.Text = Replace(WindowType_Str, "&", "&&")
                                End If
                            Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()

                        Case "WindowType_Delete"
                            For Each ctrl In RightRdBtn_FLP.Controls
                                If ctrl.Tag = WDT_ID Then
                                    RightRdBtn_FLP.Controls.Remove(ctrl)
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
            TFM_TODO = "Fetch_TFactor"
            Start_TFMBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub WDTRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            WDT_ID = sender.Tag
            If ST_ID <> Nothing Then
                TFM_TODO = "Fetch_TFactor"
                Start_TFMBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub FrameScreen_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FrameScreen_Cbox.SelectionChangeCommitted
        Try
            FRAME_OR_SCREEN = FrameScreen_Cbox.Text
            If LeftRdBtn_FLP.Controls.Count <> 0 Then
                LeftRdBtn_FLP.Controls.Clear()
            End If
            If Right_Tbox.CustomButton.Text = "+" And Right_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If FrameScreen_Cbox.SelectedIndex = 0 Then
                    RightRdBtn_FLP.Enabled = True
                    Left_Tbox.Enabled = True
                ElseIf FrameScreen_Cbox.SelectedIndex = 1 Then
                    RightRdBtn_FLP.Enabled = False
                    Left_Tbox.Enabled = False
                End If
                TFM_TODO = "ProfileType"
                Start_TFMBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            KMDIPrompts(Me, "Question", "Are you sure you want to Delete?", Nothing, Nothing, True)
            If QuestionPromptAnswer = 6 Then
                If TrueIFProfileType_bool = True Then
                    TFM_TODO = "ProfileType_Delete"

                Else TrueIFProfileType_bool = False
                    TFM_TODO = "WindowType_Delete"

                End If
                Start_TFMBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub Rbtn_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            sender.Select
            If sender.Parent.Name = "STRdBtn_FLP" Then
                ProfileType_Str = sender.Text
                ST_ID = sender.Tag
                TrueIFProfileType_bool = True
            ElseIf sender.Parent.Name = "WDTRdBtn_FLP" Then
                WindowType_Str = sender.Text
                WDT_ID = sender.Tag
                TrueIFProfileType_bool = False
            End If
        End If
    End Sub
    Private Sub Right_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Right_Tbox.ButtonClick
        Try
            ProfileType_Str = Trim(Right_Tbox.Text)

            If Right_Tbox.CustomButton.Text = "+" And Right_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If ProfileType_Str <> Nothing Or ProfileType_Str <> "" Then
                    TFM_TODO = "ProfileType_Insert"
                    Start_TFMBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "ProfileType_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf Right_Tbox.CustomButton.Text = "U" And Right_Tbox.Style = MetroFramework.MetroColorStyle.Red Then
                If ProfileType_Str <> Nothing Or ProfileType_Str <> "" Then
                    If ST_ID <> Nothing Then
                        TFM_TODO = "ProfileType_Update"
                        Start_TFMBGW()
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

    Private Sub Engr_TFM_Maintenance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
                                TFM_TODO = "Transact_TFactor"
                                Start_TFMBGW()
                            Else
                                KMDIPrompts(Me, "UserWarning", "WDT_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select Window Type")
                            End If
                        Else
                            KMDIPrompts(Me, "UserWarning", "ST_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                        End If
                    Case "Screen"
                        If ST_ID <> Nothing Then
                            TFM_TODO = "Transact_TFactor"
                            Start_TFMBGW()
                        Else
                            KMDIPrompts(Me, "UserWarning", "ST_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                        End If
                End Select

            ElseIf e.KeyCode = Keys.Escape Then
                reset_here()
            ElseIf e.KeyCode = Keys.F5 Then
                TFM_TODO = "Onload"
                Start_TFMBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If TrueIFProfileType_bool = True Then
                With Right_Tbox
                    .UseStyleColors = True
                    .Style = MetroFramework.MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(ProfileType_Str, "&&", "&")
                End With

            Else TrueIFProfileType_bool = False
                With Left_Tbox
                    .UseStyleColors = True
                    .Style = MetroFramework.MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(WindowType_Str, "&&", "&")
                End With
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub WindowType_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Left_Tbox.ButtonClick
        Try
            WindowType_Str = Trim(Left_Tbox.Text)

            If Left_Tbox.CustomButton.Text = "+" And Left_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If WindowType_Str <> Nothing Or WindowType_Str <> "" Then
                    TFM_TODO = "WindowType_Insert"
                    Start_TFMBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "WindowType_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf Left_Tbox.CustomButton.Text = "U" And Left_Tbox.Style = MetroFramework.MetroColorStyle.Red Then
                If WindowType_Str <> Nothing Or WindowType_Str <> "" Then
                    If WDT_ID <> Nothing Then
                        TFM_TODO = "WindowType_Update"
                        Start_TFMBGW()
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
    Private Sub ProfileType_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Right_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Right_Tbox.CustomButton.PerformClick()
        End If
    End Sub
    Private Sub WindowType_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Left_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Left_Tbox.CustomButton.PerformClick()
        End If
    End Sub
End Class