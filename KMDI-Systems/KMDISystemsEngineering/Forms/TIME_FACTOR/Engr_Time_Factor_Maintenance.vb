Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Threading.Thread
Imports ComponentFactory.Krypton.Toolkit
Public Class Engr_Time_Factor_Maintenance
    Public TFM_BGW As BackgroundWorker = New BackgroundWorker
    Dim Left_ID, Right_ID, TFactor_Hrs, TFactor_Mins, TFactor_Secs As Integer
    Dim TFM_TODO, RightTbox_Str, LeftTbox_Str, WINDOOR_PART As String
    Dim T_FACTOR As TimeSpan
    Dim ReportBGW_bool, TrueIFProfileType_bool, CreateRadioBtn, TrueIfLeft_bool As Boolean
    Sub Start_TFMBGW()
        If TFM_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            Frm_PNL.Enabled = False
            TFM_BGW.RunWorkerAsync()
        Else
            KMDIPrompts(Me, "UserWarning", Nothing, Nothing, Nothing, True, True, "Please Wait!")
        End If
    End Sub
    Public Function ConvertToSeconds(ByVal Hrs As Integer,
                                     ByVal Mins As Integer,
                                     ByVal Secs As Integer) As Integer
        Dim TotalSecs As Integer = Nothing
        TotalSecs = (Hrs * 3600) + (Mins * 60) + Secs
        Return TotalSecs
    End Function
    Sub reset_here()
        Right_Tbox.Clear()
        LeftTbox_Str = Nothing
        InsertedTFM_ID = Nothing

        Left_Tbox.Clear()
        RightTbox_Str = Nothing

        RESET()
        LoadingPB.Visible = False
        Frm_PNL.Enabled = True
        With Left_Tbox
            .Style = MetroFramework.MetroColorStyle.Silver
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
        With Right_Tbox
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
            WindoorType_Cbox.SelectedIndex = 0
            WINDOOR_PART = "Frame"
            TFM_TODO = "ProfileType"
            Start_TFMBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub TFM_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            If TFM_TODO = "ProfileType" Or TFM_TODO = "MeshType" Then
                ReportBGW_bool = True
                CreateRadioBtn = True
                ENGR_QUERY_INSTANCE = "Loading_using_EqualSearch"
                Engr_Query_Select_STP(WINDOOR_PART, "ENGR_stp_TFM_RightPanel_Load")

            ElseIf TFM_TODO = "WindoorType" Or TFM_TODO = "ScreenType" Then
                ReportBGW_bool = True
                CreateRadioBtn = True
                ENGR_QUERY_INSTANCE = "Loading_using_EqualSearch"
                Engr_Query_Select_STP(WINDOOR_PART, "ENGR_stp_TFM_LeftPanel_Load")

            Else TFM_TODO = "TFM_Insert"
                CreateRadioBtn = True
                Select Case TrueIfLeft_bool
                    Case True
                        Engr_TFM_INSERT("ENGR_stp_TFM_LeftPanel_Insert", WINDOOR_PART, LeftTbox_Str)
                    Case False
                        Engr_TFM_INSERT("ENGR_stp_TFM_RightPanel_Insert", WINDOOR_PART, RightTbox_Str)
                End Select
            End If

            'If TFM_TODO = "ProfileType" Or TFM_TODO = "Onload" Then
            '    ReportBGW_bool = True
            '    ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
            '    Engr_Query_Select_STP("", "ENGR_stp_FRAME_ProfileType")

            'ElseIf TFM_TODO = "WindoorType" Then
            '    ReportBGW_bool = True
            '    ENGR_QUERY_INSTANCE = "Loading_using_SearchString"
            '    Engr_Query_Select_STP("", "ENGR_stp_TFM_WindoorType")

            'ElseIf TFM_TODO = "ProfileType_Insert" Then
            '    Engr_ProfileType_INSERT("ENGR_stp_TFM_ProfileType_Insert", RightTbox_Str, WINDOOR_PART)

            'ElseIf TFM_TODO = "ProfileType_Update" Then
            '    Engr_ProfileType_UPDATE("ENGR_stp_TFM_ProfileType_Update", RightTbox_Str, WINDOOR_PART, Left_ID)

            'ElseIf TFM_TODO = "ProfileType_Delete" Then
            '    Engr_ProfileType_DELETE("ENGR_stp_TFM_ProfileType_Delete", Left_ID)

            'ElseIf TFM_TODO = "WindoorType_Insert" Then
            '    Engr_WindoorType_INSERT("ENGR_stp_TFM_WindoorType_Insert", LeftTbox_Str)

            'ElseIf TFM_TODO = "WindoorType_Update" Then
            '    Engr_WindoorType_UPDATE("ENGR_stp_TFM_WindoorType_Update", LeftTbox_Str, Right_ID)

            'ElseIf TFM_TODO = "WindoorType_Delete" Then
            '    Engr_WindoorType_DELETE("ENGR_stp_TFM_WindoorType_Delete", Right_ID)

            'ElseIf TFM_TODO = "Fetch_TFactor" Then
            '    Select Case WINDOOR_PART
            '        Case "Frame"
            '            Engr_Query_Select_T_FACTOR("ENGR_stp_TFM_TFactor_Fetch", Left_ID, Right_ID)
            '        Case "Screen"
            '            Engr_Query_Select_T_FACTOR("ENGR_stp_TFM_TFactor_Fetch", Left_ID)
            '    End Select
            'ElseIf TFM_TODO = "Transact_TFactor" Then
            '    Engr_TFactor_Transact("ENGR_stp_TFM_TFactor_Transact", Left_ID, Right_ID, T_FACTOR)

            'End If

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
            Dim ItemName As String = Nothing, TagName As String = Nothing

            Select Case CreateRadioBtn
                Case True
                    If TFM_TODO = "ProfileType" Then
                        ItemName = "PROFILE_TYPE"
                        TagName = "PT_ID"
                    ElseIf TFM_TODO = "MeshType" Then
                        ItemName = "MESH_TYPE"
                        TagName = "MESH_ID"
                    ElseIf TFM_TODO = "WindoorType" Then
                        ItemName = "WINDOOR_TYPE"
                        TagName = "WDRT_ID"
                    ElseIf TFM_TODO = "ScreenType" Then
                        ItemName = "SCREEN_TYPE"
                        TagName = "SCR_ID"
                    End If

                    RdBtn_Properties("Dynamic", RdBtn, ItemName, TagName, e.ProgressPercentage, TFM_Cmenu)

                    If TFM_TODO = "ProfileType" Or TFM_TODO = "MeshType" Then
                        If LeftRdBtn_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                            LeftRdBtn_FLP.Controls.Clear()
                        End If

                        AddHandler RdBtn.Click, AddressOf LeftRbtn_Clicked
                        LeftRdBtn_FLP.Controls.Add(RdBtn)

                    ElseIf TFM_TODO = "WindoorType" Or TFM_TODO = "ScreenType" Then
                        If RightRdBtn_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                            RightRdBtn_FLP.Controls.Clear()
                        End If

                        AddHandler RdBtn.Click, AddressOf RightRbtn_Clicked
                        RightRdBtn_FLP.Controls.Add(RdBtn)
                    End If

                    AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
                Case False
            End Select

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            reset_here()
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
                        Case "ProfileType"
                            ReportBGW_bool = False
                            CreateRadioBtn = False
                            TFM_TODO = "WindoorType"
                            Start_TFMBGW()

                        Case "WindoorType"
                            ReportBGW_bool = False
                            CreateRadioBtn = False
                            reset_here()

                        Case "MeshType"
                            ReportBGW_bool = False
                            CreateRadioBtn = False
                            TFM_TODO = "ScreenType"
                            Start_TFMBGW()

                        Case "ScreenType"
                            CreateRadioBtn = False
                            ReportBGW_bool = False
                            reset_here()

                        Case "TFM_Insert"
                            Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
                            Select Case CreateRadioBtn
                                Case True
                                    Select Case TrueIfLeft_bool
                                        Case True
                                            RdBtn_Properties("Static", RdBtn, LeftTbox_Str, InsertedTFM_ID, Nothing, TFM_Cmenu)
                                            LeftRdBtn_FLP.Controls.Add(RdBtn)
                                            AddHandler RdBtn.Click, AddressOf LeftRbtn_Clicked
                                        Case False
                                            RdBtn_Properties("Static", RdBtn, RightTbox_Str, InsertedTFM_ID, Nothing, TFM_Cmenu)
                                            RightRdBtn_FLP.Controls.Add(RdBtn)
                                            AddHandler RdBtn.Click, AddressOf RightRbtn_Clicked
                                    End Select
                                    AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown

                                Case False
                            End Select
                            reset_here()
                            CreateRadioBtn = False


                            'Case "ProfileType_Update"
                            '    For Each ctrl In LeftRdBtn_FLP.Controls
                            '        If ctrl.Tag = Left_ID Then
                            '            ctrl.Text = Replace(RightTbox_Str, "&", "&&")
                            '        End If
                            '    Next
                            '    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            '    TFM_TODO = "ProfileType"
                            '    Start_TFMBGW()

                            'Case "ProfileType_Delete"
                            '    For Each ctrl In LeftRdBtn_FLP.Controls
                            '        If ctrl.Tag = Left_ID Then
                            '            LeftRdBtn_FLP.Controls.Remove(ctrl)
                            '        End If
                            '    Next
                            '    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            '    reset_here()

                            'Case "WindoorType_Insert"
                            '    Dim RdBtn As New MetroFramework.Controls.MetroRadioButton
                            '    RdBtn_Properties("Static", RdBtn, LeftTbox_Str, InsertedWDT_ID, Nothing, TFM_Cmenu)
                            '    RightRdBtn_FLP.Controls.Add(RdBtn)
                            '    AddHandler RdBtn.Click, AddressOf RightRbtn_Clicked
                            '    AddHandler RdBtn.MouseDown, AddressOf Rbtn_MouseDown
                            '    reset_here()

                            'Case "WindoorType_Update"
                            '    For Each ctrl In RightRdBtn_FLP.Controls
                            '        If ctrl.Tag = Right_ID Then
                            '            ctrl.Text = Replace(LeftTbox_Str, "&", "&&")
                            '        End If
                            '    Next
                            '    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            '    reset_here()

                            'Case "WindoorType_Delete"
                            '    For Each ctrl In RightRdBtn_FLP.Controls
                            '        If ctrl.Tag = Right_ID Then
                            '            RightRdBtn_FLP.Controls.Remove(ctrl)
                            '        End If
                            '    Next
                            '    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            '    reset_here()

                            'Case "Fetch_TFactor"
                            '    If sqlDataSet.Tables("QUERY_DETAILS").Rows.Count <> 0 Then
                            '        Dim TFactor_str As String = Replace(sqlDataSet.Tables("QUERY_DETAILS").Rows(0).Item("T_FACTOR").ToString, ":", "")
                            '        TFactor_Hrs = Convert.ToInt32(TFactor_str.Substring(0, 2))
                            '        TFactor_Mins = Convert.ToInt32(TFactor_str.Substring(2, 2))
                            '        TFactor_Secs = Convert.ToInt32(TFactor_str.Substring(4, 2))

                            '        TFactorHrs_Num.Value = TFactor_Hrs
                            '        TFactorMins_Num.Value = TFactor_Mins
                            '        TFactorSecs_Num.Value = TFactor_Secs
                            '    ElseIf sqlDataSet.Tables("QUERY_DETAILS").Rows.Count = 0 Then
                            '        TFactorHrs_Num.Value = 0
                            '        TFactorMins_Num.Value = 0
                            '        TFactorSecs_Num.Value = 0
                            '    End If
                            '    reset_here()

                            'Case "Transact_TFactor"
                            '    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            '    reset_here()

                    End Select
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            reset_here()
        End Try
    End Sub
    Private Sub LeftRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            Left_ID = sender.Tag
            'TFM_TODO = "Fetch_TFactor"
            'Start_TFMBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub RightRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            Right_ID = sender.Tag
            'If Left_ID <> Nothing Then
            '    TFM_TODO = "Fetch_TFactor"
            '    Start_TFMBGW()
            'End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub FrameScreen_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles WindoorType_Cbox.SelectionChangeCommitted
        Try
            WINDOOR_PART = WindoorType_Cbox.Text
            If LeftRdBtn_FLP.Controls.Count <> 0 Then
                LeftRdBtn_FLP.Controls.Clear()
            End If
            If RightRdBtn_FLP.Controls.Count <> 0 Then
                RightRdBtn_FLP.Controls.Clear()
            End If
            If Left_Tbox.CustomButton.Text = "+" And Left_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                Select Case WINDOOR_PART
                    Case "Frame"
                        Left_Tbox.WaterMark = "System Type"
                        Right_Tbox.WaterMark = "Window Type"
                        TFM_TODO = "ProfileType"
                        Start_TFMBGW()
                    Case "Screen"
                        Left_Tbox.WaterMark = "Mesh Type"
                        Right_Tbox.WaterMark = "Screen Type"
                        TFM_TODO = "MeshType"
                        Start_TFMBGW()
                End Select
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
                    TFM_TODO = "WindoorType_Delete"

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
                RightTbox_Str = sender.Text
                Left_ID = sender.Tag
                TrueIFProfileType_bool = True
            ElseIf sender.Parent.Name = "WDTRdBtn_FLP" Then
                LeftTbox_Str = sender.Text
                Right_ID = sender.Tag
                TrueIFProfileType_bool = False
            End If
        End If
    End Sub
    Private Sub Left_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Left_Tbox.ButtonClick
        Try
            LeftTbox_Str = Trim(Left_Tbox.Text)
            TrueIfLeft_bool = True
            If Left_Tbox.CustomButton.Text = "+" And Left_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If LeftTbox_Str <> Nothing Or LeftTbox_Str <> "" Then
                    TFM_TODO = "TFM_Insert"
                    Start_TFMBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "RightTbox_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
                'ElseIf Right_Tbox.CustomButton.Text = "U" And Right_Tbox.Style = MetroFramework.MetroColorStyle.Red Then
                '    If RightTbox_Str <> Nothing Or RightTbox_Str <> "" Then
                '        If Left_ID <> Nothing Then
                '            TFM_TODO = "ProfileType_Update"
                '            Start_TFMBGW()
                '        Else
                '            KMDIPrompts(Me, "UserWarning", "Left_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                '        End If
                '    Else
                '        KMDIPrompts(Me, "UserWarning", "LeftTbox_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                '    End If
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
                Select Case WINDOOR_PART
                    Case "Frame"
                        If Left_ID <> Nothing Then
                            If Right_ID <> Nothing Then
                                TFM_TODO = "Transact_TFactor"
                                Start_TFMBGW()
                            Else
                                KMDIPrompts(Me, "UserWarning", "Right_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select Window Type")
                            End If
                        Else
                            KMDIPrompts(Me, "UserWarning", "Left_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                        End If
                    Case "Screen"
                        If Left_ID <> Nothing Then
                            TFM_TODO = "Transact_TFactor"
                            Start_TFMBGW()
                        Else
                            KMDIPrompts(Me, "UserWarning", "Left_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select System Type")
                        End If
                End Select

            ElseIf e.KeyCode = Keys.Escape Then
                reset_here()
            ElseIf e.KeyCode = Keys.F5 Then
                TFM_TODO = "ProfileType"
                Start_TFMBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If TrueIFProfileType_bool = True Then
                With Left_Tbox
                    .UseStyleColors = True
                    .Style = MetroFramework.MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(RightTbox_Str, "&&", "&")
                End With

            Else TrueIFProfileType_bool = False
                With Right_Tbox
                    .UseStyleColors = True
                    .Style = MetroFramework.MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(LeftTbox_Str, "&&", "&")
                End With
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub Right_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Right_Tbox.ButtonClick
        Try
            RightTbox_Str = Trim(Right_Tbox.Text)
            TrueIfLeft_bool = False

            If Right_Tbox.CustomButton.Text = "+" And Right_Tbox.Style = MetroFramework.MetroColorStyle.Silver Then
                If RightTbox_Str <> Nothing Or RightTbox_Str <> "" Then
                    TFM_TODO = "TFM_Insert"
                    Start_TFMBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "LeftTbox_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
                'ElseIf Right_Tbox.CustomButton.Text = "U" And Right_Tbox.Style = MetroFramework.MetroColorStyle.Red Then
                '    If LeftTbox_Str <> Nothing Or LeftTbox_Str <> "" Then
                '        If Right_ID <> Nothing Then
                '            TFM_TODO = "WindoorType_Update"
                '            Start_TFMBGW()
                '        Else
                '            KMDIPrompts(Me, "UserWarning", "Right_ID is Empty", Environment.StackTrace, Nothing, True, True, "Please select Window Type")
                '        End If
                '    Else
                '        KMDIPrompts(Me, "UserWarning", "LeftTbox_Str is Empty", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                '    End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub ProfileType_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Left_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Left_Tbox.CustomButton.PerformClick()
        End If
    End Sub
    Private Sub WindoorType_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Right_Tbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Right_Tbox.CustomButton.PerformClick()
        End If
    End Sub
End Class