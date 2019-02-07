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

    Dim Item_Frame As Integer = 0, Item_Sash As Integer = 0, Item_Glass As Integer = 0, TE_ID As Integer, ROWINDEX As Integer,
        SCR_ID As Integer, Item_Screen As Integer = 0,
        HDL_ID As Integer, Item_Handle As Integer = 0
    Dim Profile_Type As String = Nothing, Item_Size As String = Nothing, Screen_Type As String = Nothing, Handle_Type As String = Nothing
    Public Sub Start_InsCPanelBGW()
        If InsCPanel_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            Frm_PNL.Enabled = False
            InsCPanel_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub reset_here()
        TE_ID = Nothing
        ProfileType_Tbox.Clear()
        Size_Tbox.Clear()
        Frame_Tbox.Clear()
        Sash_Tbox.Clear()
        Glass_Tbox.Clear()

        SCR_ID = Nothing
        ScreenType_Tbox.Clear()
        ScreenTime_Tbox.Clear()

        HDL_ID = Nothing
        HandleType_Tbox.Clear()
        HandleTime_Tbox.Clear()
        Generate_DGVCols = False
        Generate_DGVRows = False
    End Sub
    Sub SAVE()
        If WindoorPart_Cbox.SelectedIndex = 0 Then
            Profile_Type = Trim(ProfileType_Tbox.Text)
            Item_Size = Trim(Size_Tbox.Text)
            Item_Frame = Val(Frame_Tbox.Text)
            Item_Sash = Val(Sash_Tbox.Text)
            Item_Glass = Val(Glass_Tbox.Text)

            If Profile_Type <> Nothing Or Profile_Type <> "" Then
                If Item_Size <> Nothing Or Item_Size <> "" Then
                    Start_InsCPanelBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "Item_Size is empty", Environment.StackTrace, Nothing, True, True, "Size cannot be empty")
                End If
            Else
                KMDIPrompts(Me, "UserWarning", "Profile Type is empty", Environment.StackTrace, Nothing, True, True, "Profile Type cannot be empty")
            End If
        ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
            Screen_Type = Trim(ScreenType_Tbox.Text)
            Item_Screen = Val(ScreenTime_Tbox.Text)
            If Screen_Type <> Nothing Or Screen_Type <> "" Then
                Start_InsCPanelBGW()
            Else
                KMDIPrompts(Me, "UserWarning", "Screen Type is empty", Environment.StackTrace, Nothing, True, True, "Screen Type cannot be empty")
            End If
        ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
            Handle_Type = Trim(HandleType_Tbox.Text)
            Item_Handle = Val(HandleTime_Tbox.Text)
            If Handle_Type <> Nothing Or Handle_Type <> "" Then
                Start_InsCPanelBGW()
            Else
                KMDIPrompts(Me, "UserWarning", "Handle Type is empty", Environment.StackTrace, Nothing, True, True, "Handle Type cannot be empty")
            End If
        End If
    End Sub
    Public Function ConvertToSeconds(Optional Hrs As Integer = 0,
                                     Optional Mins As Integer = 0,
                                     Optional Secs As Integer = 0) As Integer
        Dim TotalSecs As Integer = Nothing
        TotalSecs = (Hrs * 3600) + (Mins * 60) + Secs

        Return TotalSecs
    End Function
    Private Sub TE_Installation_CPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            InsCPanel_BGW.WorkerSupportsCancellation = True
            InsCPanel_BGW.WorkerReportsProgress = True
            AddHandler InsCPanel_BGW.DoWork, AddressOf InsCPanel_BGW_DoWork
            AddHandler InsCPanel_BGW.ProgressChanged, AddressOf InsCPanel_BGW_ProgressChanged
            AddHandler InsCPanel_BGW.RunWorkerCompleted, AddressOf InsCPanel_BGW_RunWorkerCompleted

            WindoorPart_Cbox.SelectedIndex = 0

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub InsCPanel_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case InsCPanel_TODO
                '// Start of Frame
                Case "Frame"
                    Generate_DGVCols = True
                    TMLMNT_QUERY_INSTANCE = "Loading_using_SearchString"
                    TMLMNT_Query_Select_STP("", "TE_stp_FShGL_Search")
                Case "Frame_ADD"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Frame_Insert("TE_stp_FShGL_ADD", Profile_Type, Item_Size, Item_Frame, Item_Sash, Item_Glass)
                Case "Frame_UPDATE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Frame_Update("TE_stp_FShGL_UPDATE", TE_ID, Profile_Type, Item_Size, Item_Frame, Item_Sash, Item_Glass)
                Case "Frame_DELETE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Frame_Delete("TE_stp_FShGL_DELETE", TE_ID)
                    '// End of Frame

                    '// Start of Screen
                Case "Screen"
                    Generate_DGVCols = True
                    TMLMNT_QUERY_INSTANCE = "Loading_using_SearchString"
                    TMLMNT_Query_Select_STP("", "TE_stp_Screen_Search")
                Case "Screen_ADD"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Screen_Insert("TE_stp_Screen_ADD", Screen_Type, Item_Screen)
                Case "Screen_UPDATE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Screen_Update("TE_stp_Screen_UPDATE", SCR_ID, Screen_Type, Item_Screen)
                Case "Screen_DELETE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Screen_Delete("TE_stp_Screen_DELETE", SCR_ID)
                    '// End of Screen

                    '// Start of Handle
                Case "Handle"
                    Generate_DGVCols = True
                    TMLMNT_QUERY_INSTANCE = "Loading_using_SearchString"
                    TMLMNT_Query_Select_STP("", "TE_stp_Handle_Search")
                Case "Handle_ADD"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Handle_Insert("TE_stp_Handle_ADD", Handle_Type, Item_Handle)
                Case "Handle_UPDATE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Handle_Update("TE_stp_Handle_UPDATE", HDL_ID, Handle_Type, Item_Handle)
                Case "Handle_DELETE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Handle_Delete("TE_stp_Handle_DELETE", HDL_ID)
                    '// End of Handle

            End Select

            Select Case Generate_DGVCols
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                        'Console.WriteLine(InsCPanel_TODO & " Columns " & i & ". " & sqlDataSet.Tables("QUERY_DETAILS").Columns(i).ToString)
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
                        'Console.WriteLine(InsCPanel_TODO & " Rows " & i & ". " & sqlDataSet.Tables("QUERY_DETAILS").Rows.Count)
                        Sleep(10)
                        InsCPanel_BGW.ReportProgress(i)
                    Next
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
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
                        If Not DGV_Pnl.Controls.Contains(InsCpanel_DGV) Then
                            DGV_Properties(InsCpanel_DGV, "InsCpanel_DGV")
                            DGV_Pnl.Controls.Add(InsCpanel_DGV)
                            InsCpanel_DGV.MultiSelect = False
                            AddHandler InsCpanel_DGV.RowPostPaint, AddressOf InsCpanel_DGV_RowPostPaint
                            AddHandler InsCpanel_DGV.RowEnter, AddressOf InsCpanel_DGV_RowEnter
                            AddHandler InsCpanel_DGV.CellMouseClick, AddressOf InsCpanel_DGV_CellMouseClick
                        End If
                    End If
                    Dim dgvCol As New DataGridViewColumn
                    Dim cell As DataGridViewCell = New DataGridViewTextBoxCell()
                    If e.ProgressPercentage < sqlDataSet.Tables("QUERY_DETAILS").Columns.Count Then
                        If InsCPanel_TODO = "Frame" Then
                            With dgvCol
                                .Name = sqlDataSet.Tables("QUERY_DETAILS").Columns(e.ProgressPercentage).ToString
                                .HeaderText = dgvCol.Name
                                .CellTemplate = cell
                                .SortMode = DataGridViewColumnSortMode.Automatic
                                If .Name = "TE_ID" Or .Name = "TE_STATUS" Then
                                    .Visible = False
                                End If
                                If .Name = "TE_ID" Then
                                    .ValueType = GetType(Integer)
                                End If
                                If .Name = "PROFILE TYPE" Or .Name = "SIZE" Then
                                    .ValueType = GetType(String)
                                End If
                                If .Name = "FRAME" Or .Name = "SASH" Or .Name = "GLASS" Then
                                    .ValueType = GetType(TimeSpan)
                                End If
                            End With
                        ElseIf InsCPanel_TODO = "Screen" Then
                            With dgvCol
                                .Name = sqlDataSet.Tables("QUERY_DETAILS").Columns(e.ProgressPercentage).ToString
                                .HeaderText = dgvCol.Name
                                .CellTemplate = cell
                                .SortMode = DataGridViewColumnSortMode.Automatic
                                If .Name = "SCR_ID" Or .Name = "SCR_STATUS" Then
                                    .Visible = False
                                End If
                                If .Name = "SCR_ID" Then
                                    .ValueType = GetType(Integer)
                                End If
                                If .Name = "SCREEN TYPE" Then
                                    .ValueType = GetType(String)
                                End If
                                If .Name = "TIME" Then
                                    .ValueType = GetType(TimeSpan)
                                End If
                            End With
                        ElseIf InsCPanel_TODO = "Handle" Then
                            With dgvCol
                                .Name = sqlDataSet.Tables("QUERY_DETAILS").Columns(e.ProgressPercentage).ToString
                                .HeaderText = dgvCol.Name
                                .CellTemplate = cell
                                .SortMode = DataGridViewColumnSortMode.Automatic
                                If .Name = "HDL_ID" Or .Name = "HDL_STATUS" Then
                                    .Visible = False
                                End If
                                If .Name = "HDL_ID" Then
                                    .ValueType = GetType(Integer)
                                End If
                                If .Name = "HANDLE TYPE" Then
                                    .ValueType = GetType(String)
                                End If
                                If .Name = "TIME" Then
                                    .ValueType = GetType(TimeSpan)
                                End If
                            End With
                        End If
                        InsCpanel_DGV.Columns.Add(dgvCol)
                        'Console.WriteLine("Columns " & e.ProgressPercentage & " created")
                    End If
            End Select


            Select Case Generate_DGVRows
                Case True
                    Select Case Generate_DGVCols
                        Case True
                            Generate_DGVCols = False
                        Case False
                            DGVrow_list.Clear()
                            If InsCPanel_TODO = "Frame" Then
                                For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                                    If i = 0 Then
                                        DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))
                                    ElseIf i = 1 Or i = 2 Then
                                        DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i).ToString)
                                    ElseIf i = 3 Or i = 4 Or i = 5 Then
                                        DGVrow_list.Add(TimeSpan.FromSeconds(Convert.ToInt32(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))))
                                    End If
                                Next
                            ElseIf InsCPanel_TODO = "Screen" Then
                                For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                                    If i = 0 Then
                                        DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))
                                    ElseIf i = 1 Then
                                        DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i).ToString)
                                    ElseIf i = 2 Then
                                        DGVrow_list.Add(TimeSpan.FromSeconds(Convert.ToInt32(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))))
                                    End If
                                Next
                            ElseIf InsCPanel_TODO = "Handle" Then
                                For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Columns.Count - 1
                                    If i = 0 Then
                                        DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))
                                    ElseIf i = 1 Then
                                        DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i).ToString)
                                    ElseIf i = 2 Then
                                        DGVrow_list.Add(TimeSpan.FromSeconds(Convert.ToInt32(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))))
                                    End If
                                Next
                            End If
                            InsCpanel_DGV.Rows.Add(DGVrow_list.ToArray)
                            'Console.WriteLine("Rows " & e.ProgressPercentage & " created")
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
                        Case "Frame"
                            reset_here()
                        Case "Frame_ADD"
                            InsCpanel_DGV.Rows.Add(InsertedTE_ID, Profile_Type, Item_Size, TimeSpan.FromSeconds(Item_Frame),
                                                   TimeSpan.FromSeconds(Item_Sash), TimeSpan.FromSeconds(Item_Glass))
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()
                        Case "Frame_UPDATE"
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("PROFILE TYPE").Value = Profile_Type
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("SIZE").Value = Item_Size
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("FRAME").Value = TimeSpan.FromSeconds(Item_Frame)
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("SASH").Value = TimeSpan.FromSeconds(Item_Sash)
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("GLASS").Value = TimeSpan.FromSeconds(Item_Glass)
                            reset_here()
                            FrameFields_Pnl.Visible = False
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                        Case "Frame_DELETE"
                            InsCpanel_DGV.Rows.RemoveAt(ROWINDEX)
                            reset_here()

                        Case "Screen"
                            reset_here()
                        Case "Screen_ADD"
                            InsCpanel_DGV.Rows.Add(InsertedSCR_ID, Screen_Type, TimeSpan.FromSeconds(Item_Screen))
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()
                        Case "Screen_UPDATE"
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("SCREEN TYPE").Value = Screen_Type
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("TIME").Value = TimeSpan.FromSeconds(Item_Screen)
                            reset_here()
                            ScreenFields_Pnl.Visible = False
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                        Case "Screen_DELETE"
                            InsCpanel_DGV.Rows.RemoveAt(ROWINDEX)
                            reset_here()

                        Case "Handle"
                            reset_here()
                        Case "Handle_ADD"
                            InsCpanel_DGV.Rows.Add(InsertedHDL_ID, Handle_Type, TimeSpan.FromSeconds(Item_Handle))
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()
                        Case "Handle_UPDATE"
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("HANDLE TYPE").Value = Handle_Type
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("TIME").Value = TimeSpan.FromSeconds(Item_Handle)
                            reset_here()
                            HandleFields_Pnl.Visible = False
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                        Case "Handle_DELETE"
                            InsCpanel_DGV.Rows.RemoveAt(ROWINDEX)
                            reset_here()
                    End Select
                End If
            End If
            RESET()
            LoadingPB.Visible = False
            Frm_PNL.Enabled = True
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
            Frm_PNL.Enabled = True
        End Try
    End Sub
    Private Sub TE_Installation_CPanel_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) Then
                If FrameFields_Pnl.Visible = True Then
                    If FieldsHeader_Lbl.Text.Contains("Add") Then
                        InsCPanel_TODO = "Frame_ADD"
                    ElseIf FieldsHeader_Lbl.Text.Contains("Update") Then
                        InsCPanel_TODO = "Frame_UPDATE"
                    End If
                ElseIf ScreenFields_Pnl.Visible = True Then
                    If ScreenHeader_Lbl.Text.Contains("Add") Then
                        InsCPanel_TODO = "Screen_ADD"
                    ElseIf ScreenHeader_Lbl.Text.Contains("Update") Then
                        InsCPanel_TODO = "Screen_UPDATE"
                    End If
                ElseIf HandleFields_Pnl.Visible = True Then
                    If HandleHeader_lbl.Text.Contains("Add") Then
                        InsCPanel_TODO = "Handle_ADD"
                    ElseIf HandleHeader_lbl.Text.Contains("Update") Then
                        InsCPanel_TODO = "Handle_UPDATE"
                    End If
                End If
                SAVE()
            ElseIf e.KeyCode = Keys.Escape Then
                reset_here()
                FrameFields_Pnl.Visible = False
                ScreenFields_Pnl.Visible = False
                HandleFields_Pnl.Visible = False
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            KMDIPrompts(Me, "Question", "Are you sure to Delete?", Nothing, Nothing, True, False, Nothing, False, MessageBoxButtons.YesNo)

            If QuestionPromptAnswer = 6 Then
                If WindoorPart_Cbox.SelectedIndex = 0 Then
                    InsCPanel_TODO = "Frame_DELETE"
                ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
                    InsCPanel_TODO = "Screen_DELETE"
                ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
                    InsCPanel_TODO = "Handle_DELETE"
                End If
                Start_InsCPanelBGW()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub AddSidebar_MouseEnterAndHover(sender As Object, e As EventArgs) Handles AddSidebar_Pnl.MouseEnter, AddSidebar_Lbl.MouseEnter,
                                                                                        AddSidebar_Pnl.MouseHover, AddSidebar_Lbl.MouseHover
        AddSidebar_Pnl.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub AddSidebar_MouseLeave(sender As Object, e As EventArgs) Handles AddSidebar_Pnl.MouseLeave, AddSidebar_Lbl.MouseLeave
        AddSidebar_Pnl.BackColor = Color.DimGray
    End Sub

    Private Sub TimeElementTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Frame_Tbox.KeyPress, Sash_Tbox.KeyPress,
                                                                                           Glass_Tbox.KeyPress, ScreenTime_Tbox.KeyPress,
                                                                                           HandleTime_Tbox.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar)) And (e.KeyChar <> ControlChars.Back) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "UserWarning", "Invalid value", Environment.StackTrace, Nothing, True, True, "Numbers only")
        End Try
    End Sub

    Private Sub ExitHandle_Btn_Click(sender As Object, e As EventArgs) Handles ExitHandle_Btn.Click
        reset_here()
        HandleFields_Pnl.Visible = False
    End Sub

    Private Sub ExitScreen_Btn_Click(sender As Object, e As EventArgs) Handles ExitScreen_Btn.Click
        reset_here()
        ScreenFields_Pnl.Visible = False
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If WindoorPart_Cbox.SelectedIndex = 0 Then
            FieldsHeader_Lbl.Text = "Update item"
            FrameFieldsHeader_Pnl.BackColor = Color.IndianRed
            FrameFields_Pnl.Visible = True
            ProfileType_Tbox.Select()
            ProfileType_Tbox.Focus()
        ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
            ScreenHeader_Lbl.Text = "Update item"
            ScreenFieldsHeader_Pnl.BackColor = Color.IndianRed
            ScreenFields_Pnl.Visible = True
            ScreenType_Tbox.Select()
            ScreenType_Tbox.Focus()
        ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
            HandleHeader_lbl.Text = "Update item"
            HandleFieldsHeader_Pnl.BackColor = Color.IndianRed
            HandleFields_Pnl.Visible = True
            HandleType_Tbox.Select()
            HandleType_Tbox.Focus()
        End If
    End Sub

    Private Sub Exit_Pbtn_Click(sender As Object, e As EventArgs) Handles Exit_Pbtn.Click
        reset_here()
        FrameFields_Pnl.Visible = False
    End Sub
    Private Sub HrsTbox_TextChanged(sender As Object, e As EventArgs) Handles Frame_Tbox.TextChanged, Sash_Tbox.TextChanged,
                                                                              Glass_Tbox.TextChanged, ScreenTime_Tbox.TextChanged,
                                                                              HandleTime_Tbox.TextChanged
        Try
            Dim iSpan As TimeSpan = TimeSpan.FromSeconds(Val(sender.Text))
            Dim TotalHrs As String

            TotalHrs = iSpan.Hours.ToString.PadLeft(2, "0"c) & " : " &
                       iSpan.Minutes.ToString.PadLeft(2, "0"c) & " : " &
                       iSpan.Seconds.ToString.PadLeft(2, "0"c)

            If sender.Name = "Frame_Tbox" Then
                FrameHrs_Lbl.Text = TotalHrs
            ElseIf sender.Name = "Sash_Tbox" Then
                SashHrs_Lbl.Text = TotalHrs
            ElseIf sender.Name = "Glass_Tbox" Then
                GlassHrs_Lbl.Text = TotalHrs
            ElseIf sender.Name = "ScreenTime_Tbox" Then
                ScreenTime_Lbl.Text = TotalHrs
            ElseIf sender.Name = "HandleTime_Tbox" Then
                HandleTime_Lbl.Text = TotalHrs
            End If
        Catch ex As Exception
            If ex.Message = "TimeSpan overflowed because the duration is too long." Then
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True, True,
                            "Input not allowed")
                sender.Clear()
            Else
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            End If
        End Try
    End Sub

    Private Sub WindoorPart_Cbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WindoorPart_Cbox.SelectedIndexChanged
        InsCpanel_DGV.Columns.Clear()
        InsCpanel_DGV.Rows.Clear()
        FrameFields_Pnl.Visible = False
        ScreenFields_Pnl.Visible = False
        HandleFields_Pnl.Visible = False

        If WindoorPart_Cbox.SelectedIndex = 0 Then
            InsCPanel_TODO = "Frame"
        ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
            InsCPanel_TODO = "Screen"
        ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
            InsCPanel_TODO = "Handle"
        End If
        Start_InsCPanelBGW()
    End Sub

    Private Sub AddSidebar_Click(sender As Object, e As EventArgs) Handles AddSidebar_Pnl.Click, AddSidebar_Lbl.Click
        If WindoorPart_Cbox.SelectedIndex = 0 Then
            If FrameFields_Pnl.Visible = False Then
                FieldsHeader_Lbl.Text = "Add new item"
                FrameFieldsHeader_Pnl.BackColor = SystemColors.MenuHighlight
                FrameFields_Pnl.Visible = True
                ProfileType_Tbox.Select()
                ProfileType_Tbox.Focus()
            ElseIf FrameFields_Pnl.Visible = True Then
                FrameFields_Pnl.Visible = False
            End If
        ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
            If ScreenFields_Pnl.Visible = False Then
                ScreenHeader_Lbl.Text = "Add new item"
                ScreenFieldsHeader_Pnl.BackColor = SystemColors.MenuHighlight
                ScreenFields_Pnl.Visible = True
                ScreenType_Tbox.Select()
                ScreenType_Tbox.Focus()
            ElseIf ScreenFields_Pnl.Visible = True Then
                ScreenFields_Pnl.Visible = False
            End If
        ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
            If HandleFields_Pnl.Visible = False Then
                HandleHeader_lbl.Text = "Add new item"
                HandleFieldsHeader_Pnl.BackColor = SystemColors.MenuHighlight
                HandleFields_Pnl.Visible = True
                HandleType_Tbox.Select()
                HandleType_Tbox.Focus()
            ElseIf HandleFields_Pnl.Visible = True Then
                HandleFields_Pnl.Visible = False
            End If
        End If

    End Sub
    Private Sub InsCpanel_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub
    Private Sub InsCpanel_DGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                ROWINDEX = e.RowIndex
                InsCpanel_DGV.Rows(e.RowIndex).Selected = True
                If WindoorPart_Cbox.SelectedIndex = 0 Then
                    With InsCpanel_DGV
                        TE_ID = .Item("TE_ID", e.RowIndex).Value
                        Frame_Tbox.Text = .Item("FRAME", e.RowIndex).Value.TotalSeconds
                        Sash_Tbox.Text = .Item("SASH", e.RowIndex).Value.TotalSeconds
                        Glass_Tbox.Text = .Item("GLASS", e.RowIndex).Value.TotalSeconds
                        Size_Tbox.Text = .Item("SIZE", e.RowIndex).Value.ToString
                        ProfileType_Tbox.Text = .Item("PROFILE TYPE", e.RowIndex).Value.ToString
                    End With
                ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
                    With InsCpanel_DGV
                        SCR_ID = .Item("SCR_ID", e.RowIndex).Value
                        ScreenType_Tbox.Text = .Item("SCREEN TYPE", e.RowIndex).Value.ToString
                        ScreenTime_Tbox.Text = .Item("TIME", e.RowIndex).Value.TotalSeconds
                    End With
                ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
                    With InsCpanel_DGV
                        HDL_ID = .Item("HDL_ID", e.RowIndex).Value
                        HandleType_Tbox.Text = .Item("HANDLE TYPE", e.RowIndex).Value.ToString
                        HandleTime_Tbox.Text = .Item("TIME", e.RowIndex).Value.TotalSeconds
                    End With
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub InsCpanel_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                ROWINDEX = e.RowIndex
                InsCpanel_DGV.Rows(e.RowIndex).Selected = True
                If WindoorPart_Cbox.SelectedIndex = 0 Then
                    With InsCpanel_DGV
                        TE_ID = .Item("TE_ID", e.RowIndex).Value
                        Frame_Tbox.Text = .Item("FRAME", e.RowIndex).Value.TotalSeconds
                        Sash_Tbox.Text = .Item("SASH", e.RowIndex).Value.TotalSeconds
                        Glass_Tbox.Text = .Item("GLASS", e.RowIndex).Value.TotalSeconds
                        Size_Tbox.Text = .Item("SIZE", e.RowIndex).Value.ToString
                        ProfileType_Tbox.Text = .Item("PROFILE TYPE", e.RowIndex).Value.ToString
                    End With
                ElseIf WindoorPart_Cbox.SelectedIndex = 1 Then
                    With InsCpanel_DGV
                        SCR_ID = .Item("SCR_ID", e.RowIndex).Value
                        ScreenType_Tbox.Text = .Item("SCREEN TYPE", e.RowIndex).Value.ToString
                        ScreenTime_Tbox.Text = .Item("TIME", e.RowIndex).Value.TotalSeconds
                    End With
                ElseIf WindoorPart_Cbox.SelectedIndex = 2 Then
                    With InsCpanel_DGV
                        HDL_ID = .Item("HDL_ID", e.RowIndex).Value
                        HandleType_Tbox.Text = .Item("HANDLE TYPE", e.RowIndex).Value.ToString
                        HandleTime_Tbox.Text = .Item("TIME", e.RowIndex).Value.TotalSeconds
                    End With
                End If
                If e.Button = MouseButtons.Right Then
                    TE_Cmenu.Show()
                    TE_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
End Class