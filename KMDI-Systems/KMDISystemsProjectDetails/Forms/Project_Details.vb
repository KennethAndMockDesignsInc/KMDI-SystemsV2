Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Project_Details
    Public PD_ID_REF_Str As String = Nothing


    Public Sub Start_ProjectDetailsBGW()
        If ProjectDetailsBGW.IsBusy <> True Then
            ProjectDetailsDGV.Enabled = False
            LoadingPB.Visible = True
            ProjectDetailsBGW.RunWorkerAsync()
            If is_CTD_bool = True Then
                SalesJobOrderToolStripMenuItem.Visible = True
            Else
                SalesJobOrderToolStripMenuItem.Visible = False
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Private Sub Project_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        SalesJobOrderToolStripMenuItem.Visible = False
        LoadingPB.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    'Sub EnterToContract()
    '    is_CTD_bool = True
    '    QUERY_INSTANCE = "Loading_using_PD_ID"
    '    QueryBUILD = QuerySearchHeadArrays(1) &
    '                     " FROM (" & QuerySearchHeadArrays(2) & QueryMidArrays(1) & ") AS EI_ACCT_TBL " &
    '                     " RIGHT JOIN (" & QuerySearchHeadArrays(3) & QueryMidArrays(2) & ") AS CTD_PD_OWN_CLD_TBL " &
    '                     " LEFT JOIN (" & QuerySearchHeadArrays(4) & QueryMidArrays(3) & ") AS AE_ACCT_TBL " &
    '                     " ON	CTD_PD_OWN_CLD_TBL.PD_ID = AE_ACCT_TBL.PD_ID_REF
    '                               ON	EI_ACCT_TBL.PD_ID_REF = CTD_PD_OWN_CLD_TBL.PD_ID " & QueryConditionArrays(1) &
    '                     " " & QueryORDERArrays(1)
    '    Start_ProjectDetailsBGW()
    'End Sub

    Sub PD_DGV_DoubleCLick()
        is_CTD_bool = True
        ProjectDetailsLBL.Text = "C O N T R A C T   D E T A I L S"
        QUERY_INSTANCE = "Loading_using_EqualSearch"
        QueryBUILD = QuerySearchHeadArrays(1) &
                     " FROM (" & QuerySearchHeadArrays(2) & QueryMidArrays(1) & ") AS EI_ACCT_TBL " &
                     " RIGHT JOIN (" & QuerySearchHeadArrays(3) & QueryMidArrays(2) & ") AS CTD_PD_OWN_CLD_TBL " &
                     " LEFT JOIN (" & QuerySearchHeadArrays(4) & QueryMidArrays(3) & ") AS AE_ACCT_TBL " &
                     " ON	CTD_PD_OWN_CLD_TBL.PD_ID = AE_ACCT_TBL.PD_ID_REF
                               ON	EI_ACCT_TBL.PD_ID_REF = CTD_PD_OWN_CLD_TBL.PD_ID " & QueryConditionArrays(1) &
                     " " & QueryORDERArrays(1)
        Start_ProjectDetailsBGW()
    End Sub

    Sub BackToProject()
        is_CTD_bool = False
        is_SalesJobOrder_bool = False
        ProjectDetailsLBL.Text = "P R O J E C T   D E T A I L S"
        QUERY_INSTANCE = "Loading_using_SearchString"
        SearchStr = ""
        QueryBUILD = QuerySearchHeadArrays(0) & QueryMidArrays(0) & QueryConditionArrays(0) &
                         " " & QueryORDERArrays(0)
        Start_ProjectDetailsBGW()
    End Sub

    Private Sub SearchFn(sender As Object, e As KeyEventArgs) Handles ProjectDetailsDGV.KeyDown, Me.KeyDown, ProjectDetailsLBL.KeyDown
        If e.KeyCode = Keys.F2 Or (e.Control And e.KeyCode = Keys.F) Then
            PD_SearchFRM.Show()
            PD_SearchFRM.TopMost = True
        ElseIf e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Back Or e.KeyCode = Keys.Escape Then
            BackToProject()
            'ElseIf e.KeyCode = Keys.Enter And is_CTD_bool = False Then
            '    ProjectDetailsDGV.ClearSelection
            '    PD_DGV_DoubleCLick()
        ElseIf e.KeyValue = 93 Then
            PD_ContextMenu.Show()
            PD_ContextMenu.Location = New Point(0, 0)
        End If
    End Sub
    Private Sub ProjectDetailsBGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles ProjectDetailsBGW.DoWork
        Try
            Query_Select(SearchStr)
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProjectDetailsBGW.CancelAsync()
            ElseIf ex.Number = 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProjectDetailsBGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                ProjectDetailsBGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MessageBox.Show(ex2.ToString)
        End Try
    End Sub

    Private Sub ProjectDetailsBGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles ProjectDetailsBGW.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Or e.Cancelled = True Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                '' otherwise it completed normally
                ProjectDetailsDGV.DataSource = Nothing
                ProjectDetailsDGV.Enabled = True
                ProjectDetailsDGV.DataSource = sqlBindingSource

                'If is_CTD_bool = True And is_SalesJobOrder_bool = False Then
                'ProjectDetailsDGV.Columns("PD_ID").Visible = False
                'ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = False Then
                '    ProjectDetailsDGV.Columns("PD_ID").Visible = False
                'Else
                If is_CTD_bool = True Then
                    ProjectDetailsDGV.Columns("ID").Visible = False
                End If

                ProjectDetailsDGV.Columns("PD_ID").Visible = False

                With ProjectDetailsDGV
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                End With
                LoadingPB.Visible = False
                ProjectDetailsDGV.Focus()
                ProjectDetailsDGV.Select()
            End If

        Catch ex As Exception
            MessageBox.Show(Me, ex.Message)
        End Try
    End Sub

    Private Sub ProjectDetailsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ProjectDetailsDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            sqlConnection.Close()
            sqlConnection.ConnectionString = sqlcnstr
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Number = 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            End If
            BackgroundWorker1.CancelAsync()
        Catch ex2 As Exception
            MessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Or e.Cancelled = True Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                'QueryBuilder("SELECT PD", "PD JOIN CTD", "WHERE PD.*")
                SearchStr = ""
                QUERY_INSTANCE = "Loading_using_SearchString"
                QueryBUILD = QuerySearchHeadArrays(0) & QueryMidArrays(0) & QueryConditionArrays(0) &
                             " " & QueryORDERArrays(0)
                Start_ProjectDetailsBGW()
            End If

        Catch ex As Exception
            MessageBox.Show(Me, ex.Message)
        End Try
    End Sub

    'Private Sub ProjectDetailsDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProjectDetailsDGV.CellMouseDoubleClick
    '    If ProjectDetailsDGV.RowCount >= 0 And e.RowIndex >= 0 Then
    '        If e.Button = MouseButtons.Left And is_CTD_bool = False Then
    '            PD_DGV_DoubleCLick()
    '        End If
    '    End If
    'End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        NewProject_Register.Show()
    End Sub

    'Private Sub ProjectDetailsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProjectDetailsDGV.CellMouseClick
    '    Try
    '        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
    '            If e.Button = MouseButtons.Right Then
    '                ProjectDetailsDGV.Rows(e.RowIndex).Selected = True
    '                Dim r As New Rectangle
    '                r = ProjectDetailsDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
    '                PD_ContextMenu.Show()
    '                PD_ContextMenu.Location = New Point(MousePosition.X, MousePosition.Y)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub SalesJobOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesJobOrderToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of PD_SalesJobOrder).Any Then
            PD_SalesJobOrder.BringToFront()
            PD_SalesJobOrder.onformLoad()
        Else
            PD_SalesJobOrder.Show()
        End If
    End Sub

    Public JO, FULLADDRESS As String

    Private Sub AddendumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddendumToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of PD_Addendum).Any Then
            PD_Addendum.BringToFront()
            PD_Addendum.onformLoad()
        Else
            PD_Addendum.Show()
        End If
    End Sub
    Private Sub ProjectDetailsDGV_MouseClick(sender As Object, e As MouseEventArgs) Handles ProjectDetailsDGV.MouseClick
        Try
            If e.Button = MouseButtons.XButton1 Then
                BackToProject()
            ElseIf e.Button = MouseButtons.Right Then
                'ProjectDetailsDGV.Rows(e.RowIndex).Selected = True
                'Dim r As New Rectangle
                'r = ProjectDetailsDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                PD_ContextMenu.Show()
                PD_ContextMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProjectDetailsDGV_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ProjectDetailsDGV.MouseDoubleClick
        'If ProjectDetailsDGV.RowCount >= 0 And e.RowIndex >= 0 Then
        If e.Button = MouseButtons.Left And is_CTD_bool = False Then
            PD_DGV_DoubleCLick()
        End If
        'End If
    End Sub

    Private Sub ProjectDetailsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProjectDetailsDGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            If e.Button = MouseButtons.Right Then
                ProjectDetailsDGV.Rows(e.RowIndex).Selected = True
                PD_ContextMenu.Show()
                PD_ContextMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
            If is_CTD_bool = True And is_SalesJobOrder_bool = False Then
                SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                'FULLADDRESS = ProjectDetailsDGV.Item("ADDRESS", e.RowIndex).Value.ToString
                PD_ID = SearchStr
            ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = False Then
                SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                PD_ID = SearchStr
            ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = True Then
                SearchStr = ProjectDetailsDGV.Item("ID", e.RowIndex).Value.ToString
                C_ID = SearchStr
                JO = ProjectDetailsDGV.Item("JO#", e.RowIndex).Value.ToString
            End If
            FULLADDRESS = ProjectDetailsDGV.Item("ADDRESS", e.RowIndex).Value.ToString
        End If
    End Sub

    Private Sub ProjectDetailsDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ProjectDetailsDGV.RowEnter
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then

                If is_CTD_bool = True And is_SalesJobOrder_bool = False Then
                    SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                    'FULLADDRESS = ProjectDetailsDGV.Item("ADDRESS", e.RowIndex).Value.ToString
                    PD_ID = SearchStr
                ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = False Then
                    SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                    PD_ID = SearchStr
                ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = True Then
                    SearchStr = ProjectDetailsDGV.Item("ID", e.RowIndex).Value.ToString
                    C_ID = SearchStr
                    JO = ProjectDetailsDGV.Item("JO#", e.RowIndex).Value.ToString
                End If
                FULLADDRESS = ProjectDetailsDGV.Item("ADDRESS", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class