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

    Dim Item_Frame As Integer = 0, Item_Sash As Integer = 0, Item_Glass As Integer = 0, TE_ID As Integer, ROWINDEX As Integer
    Dim Profile_Type As String = Nothing, Item_Size As String = Nothing
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
        Generate_DGVCols = False
    End Sub
    Sub SAVE()
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
            InsCPanel_TODO = "Search"
            Start_InsCPanelBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub TE_Installation_CPanel_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) And (Fields_Pnl.Visible = True) Then
                If FieldsHeader_Lbl.Text.Contains("Add") Then
                    InsCPanel_TODO = "ADD"
                ElseIf FieldsHeader_Lbl.Text.Contains("Update") Then
                    InsCPanel_TODO = "UPDATE"
                End If
                SAVE()
            ElseIf e.KeyCode = Keys.Escape Then
                reset_here()
                Fields_Pnl.Visible = False
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            KMDIPrompts(Me, "Question", "Are you sure to Delete?", Nothing, Nothing, True, False, Nothing, False, MessageBoxButtons.YesNo)
            If QuestionPromptAnswer = 6 Then
                InsCPanel_TODO = "DELETE"
                Start_InsCPanelBGW()
            End If
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
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Insert("TE_stp_ADD", Profile_Type, Item_Size, Item_Frame, Item_Sash, Item_Glass)
                Case "UPDATE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Update("TE_stp_UPDATE", TE_ID, Profile_Type, Item_Size, Item_Frame, Item_Sash, Item_Glass)
                Case "DELETE"
                    Generate_DGVCols = False
                    Generate_DGVRows = False
                    TMLMNT_Delete("TE_stp_DELETE", TE_ID)
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

    Private Sub AddSidebar_MouseEnterAndHover(sender As Object, e As EventArgs) Handles AddSidebar_Pnl.MouseEnter, AddSidebar_Lbl.MouseEnter,
                                                                                        AddSidebar_Pnl.MouseHover, AddSidebar_Lbl.MouseHover
        AddSidebar_Pnl.BackColor = SystemColors.MenuHighlight
    End Sub

    Private Sub AddSidebar_MouseLeave(sender As Object, e As EventArgs) Handles AddSidebar_Pnl.MouseLeave, AddSidebar_Lbl.MouseLeave
        AddSidebar_Pnl.BackColor = Color.DimGray
    End Sub

    Private Sub TimeElementTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Frame_Tbox.KeyPress, Sash_Tbox.KeyPress, Glass_Tbox.KeyPress
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

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        FieldsHeader_Lbl.Text = "Update item"
        FieldsHeader_Pnl.BackColor = Color.IndianRed
        Fields_Pnl.Visible = True
        ProfileType_Tbox.Select()
        ProfileType_Tbox.Focus()
    End Sub

    Private Sub Exit_Pbtn_Click(sender As Object, e As EventArgs) Handles Exit_Pbtn.Click
        reset_here()
        Fields_Pnl.Visible = False
    End Sub
    Private Sub HrsTbox_TextChanged(sender As Object, e As EventArgs) Handles Frame_Tbox.TextChanged, Sash_Tbox.TextChanged, Glass_Tbox.TextChanged
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

    Private Sub AddSidebar_Click(sender As Object, e As EventArgs) Handles AddSidebar_Pnl.Click, AddSidebar_Lbl.Click
        If Fields_Pnl.Visible = False Then
            FieldsHeader_Lbl.Text = "Add new item"
            FieldsHeader_Pnl.BackColor = SystemColors.MenuHighlight
            Fields_Pnl.Visible = True
            ProfileType_Tbox.Select()
            ProfileType_Tbox.Focus()
        ElseIf Fields_Pnl.Visible = True Then
            Fields_Pnl.Visible = False
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
                                If i = 0 Then
                                    DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i))
                                ElseIf i = 1 Or i = 2 Then
                                    DGVrow_list.Add(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i).ToString)
                                ElseIf i = 3 Or i = 4 Or i = 5 Then
                                    Dim iSpan As TimeSpan = TimeSpan.FromSeconds(Convert.ToInt32(sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item(i)))
                                    'Dim TotalHrs As String = iSpan.Hours.ToString.PadLeft(2, "0"c) & " : " &
                                    '                         iSpan.Minutes.ToString.PadLeft(2, "0"c) & " : " &
                                    '                         iSpan.Seconds.ToString.PadLeft(2, "0"c)

                                    DGVrow_list.Add(iSpan)
                                End If
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
                            reset_here()
                        Case "ADD"
                            InsCpanel_DGV.Rows.Add(InsertedTE_ID, Profile_Type, Item_Size, TimeSpan.FromSeconds(Item_Frame),
                                                   TimeSpan.FromSeconds(Item_Sash), TimeSpan.FromSeconds(Item_Glass))
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()
                        Case "UPDATE"
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("PROFILE TYPE").Value = Profile_Type
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("SIZE").Value = Item_Size
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("FRAME").Value = TimeSpan.FromSeconds(Item_Frame)
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("SASH").Value = TimeSpan.FromSeconds(Item_Sash)
                            InsCpanel_DGV.Rows(ROWINDEX).Cells("GLASS").Value = TimeSpan.FromSeconds(Item_Glass)
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            reset_here()
                            Fields_Pnl.Visible = False
                        Case "DELETE"
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
    Private Sub InsCpanel_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        rowpostpaint(sender, e)
    End Sub
    Private Sub InsCpanel_DGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                With InsCpanel_DGV
                    ROWINDEX = e.RowIndex
                    .Rows(e.RowIndex).Selected = True
                    TE_ID = .Item("TE_ID", e.RowIndex).Value
                    Frame_Tbox.Text = .Item("FRAME", e.RowIndex).Value.TotalSeconds
                    Sash_Tbox.Text = .Item("SASH", e.RowIndex).Value.TotalSeconds
                    Glass_Tbox.Text = .Item("GLASS", e.RowIndex).Value.TotalSeconds
                    'Frame_Tbox.Text = ConvertToSeconds(.Item("FRAME", e.RowIndex).Value)
                    'Sash_Tbox.Text = ConvertToSeconds(.Item("SASH", e.RowIndex).Value)
                    'Glass_Tbox.Text = ConvertToSeconds(.Item("GLASS", e.RowIndex).Value)
                    Size_Tbox.Text = .Item("SIZE", e.RowIndex).Value.ToString
                    ProfileType_Tbox.Text = .Item("PROFILE TYPE", e.RowIndex).Value.ToString
                End With
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
        End Try
    End Sub
    Private Sub InsCpanel_DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                With InsCpanel_DGV
                    ROWINDEX = e.RowIndex
                    .Rows(e.RowIndex).Selected = True
                    TE_ID = .Item("TE_ID", e.RowIndex).Value
                    Frame_Tbox.Text = .Item("FRAME", e.RowIndex).Value.TotalSeconds
                    Sash_Tbox.Text = .Item("SASH", e.RowIndex).Value.TotalSeconds
                    Glass_Tbox.Text = .Item("GLASS", e.RowIndex).Value.TotalSeconds
                    'Frame_Tbox.Text = ConvertToSeconds(.Item("FRAME", e.RowIndex).Value)
                    'Sash_Tbox.Text = ConvertToSeconds(.Item("SASH", e.RowIndex).Value)
                    'Glass_Tbox.Text = ConvertToSeconds(.Item("GLASS", e.RowIndex).Value)
                    Size_Tbox.Text = .Item("SIZE", e.RowIndex).Value.ToString
                    ProfileType_Tbox.Text = .Item("PROFILE TYPE", e.RowIndex).Value.ToString
                End With
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