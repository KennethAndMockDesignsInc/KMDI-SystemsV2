Imports System.ComponentModel

Public Class Project_Details
    Public PD_ID_REF_Str As String = Nothing
    Public ProjectDetails_BGW As BackgroundWorker = New BackgroundWorker
    Public PD_BGW_TODO As String

    Public Sub Start_ProjectDetailsBGW()
        If ProjectDetails_BGW.IsBusy <> True Then
            ProjectDetailsDGV.Enabled = False
            LoadingPB.Visible = True
            ProjectDetails_BGW.RunWorkerAsync()
            If is_CTD_bool = True Then
                SalesJobOrderToolStripMenuItem.Visible = True
            Else
                SalesJobOrderToolStripMenuItem.Visible = False
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub RESET()
        sql_Err_msg = Nothing
        sql_Err_no = Nothing
        sql_Err_StackTrace = Nothing
        sql_Transaction_result = ""
    End Sub

    Private Sub Project_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            ProjectDetails_BGW.WorkerSupportsCancellation = True
            ProjectDetails_BGW.WorkerReportsProgress = True
            AddHandler ProjectDetails_BGW.DoWork, AddressOf ProjectDetails_BGW_DoWork
            AddHandler ProjectDetails_BGW.RunWorkerCompleted, AddressOf ProjectDetails_BGW_RunWorkerCompleted

            SalesJobOrderToolStripMenuItem.Visible = False
            LoadingPB.Visible = True

            PD_BGW_TODO = "Onload"
            Start_ProjectDetailsBGW()
        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Private Sub SearchFn(sender As Object, e As KeyEventArgs) Handles ProjectDetailsDGV.KeyDown, Me.KeyDown, ProjectDetailsLBL.KeyDown
        Try
            If e.KeyCode = Keys.F2 Or (e.Control And e.KeyCode = Keys.F) Then
                PD_SearchFRM.Show()
                PD_SearchFRM.TopMost = True
            ElseIf e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Back Or e.KeyCode = Keys.Escape Then
                is_CTD_bool = False
                is_SalesJobOrder_bool = False
                PD_BGW_TODO = "Onload"
                Start_ProjectDetailsBGW()
            ElseIf e.KeyValue = 93 Then
                PD_ContextMenu.Show()
                PD_ContextMenu.Location = New Point(0, 0)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub
    Private Sub ProjectDetails_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case PD_BGW_TODO
                Case "Onload"
                    SearchStr = ""
                    QUERY_INSTANCE = "Loading_using_SearchString"
                    Query_Select_STP(SearchStr, "PD_stp_ProjectDetails_Onload")
                Case "Search"
                    QUERY_INSTANCE = "Loading_using_SearchString"
                    Query_Select_STP(SearchStr, "PD_stp_ProjectDetails_Search")
                Case "Contracts_Load"
                    QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Query_Select_STP(SearchStr, "PD_stp_ContractDetails_Load")
            End Select
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Private Sub ProjectDetails_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try

            If e.Error IsNot Nothing Or e.Cancelled = True Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "Closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                '' otherwise it completed normally
                If sql_Err_no = -2 Then
                    Dim result As Integer = MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect" & vbCrLf & "Cancel to Exit",
                                                       "Request Timeout", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    If result = DialogResult.OK Then
                        RESET()
                        Start_ProjectDetailsBGW()
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
                        ProjectDetailsDGV.DataSource = Nothing
                        ProjectDetailsDGV.Enabled = True
                        ProjectDetailsDGV.DataSource = sqlBindingSource

                        If is_CTD_bool = True Then
                            ProjectDetailsDGV.Columns("ID").Visible = False
                        End If

                        If ProjectDetailsDGV.Columns.Count <> 0 Then
                            ProjectDetailsDGV.Columns("PD_ID").Visible = False
                        End If

                        With ProjectDetailsDGV
                            .DefaultCellStyle.BackColor = Color.White
                            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                        End With
                        LoadingPB.Visible = False
                        ProjectDetailsDGV.Focus()
                        ProjectDetailsDGV.Select()

                    End If
                Else
                    Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                    Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           "SQL Transaction Error Number: " & sql_Err_no & vbCrLf &
                                           "SQL Transaction Error Message: " & sql_Err_msg & vbCrLf &
                                           "Trace: " & sql_Err_StackTrace & vbCrLf)
                    Log_File.Close()
                    MetroFramework.MetroMessageBox.Show(Me, "Transaction failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            RESET()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Private Sub ProjectDetailsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ProjectDetailsDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        NewProject_Register.Show()
    End Sub

    Private Sub SalesJobOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesJobOrderToolStripMenuItem.Click
        Try
            If Application.OpenForms().OfType(Of PD_SalesJobOrder).Any Then
                PD_SalesJobOrder.BringToFront()
                PD_SalesJobOrder.onformLoad()
            Else
                PD_SalesJobOrder.Show()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Public JO, FULLADDRESS As String

    Private Sub AddendumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddendumToolStripMenuItem.Click
        Try
            If Application.OpenForms().OfType(Of PD_Addendum).Any Then
                PD_Addendum.BringToFront()
                PD_Addendum.onformLoad()
            Else
                PD_Addendum.Show()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub
    Private Sub ProjectDetailsDGV_MouseClick(sender As Object, e As MouseEventArgs) Handles ProjectDetailsDGV.MouseClick
        Try
            If e.Button = MouseButtons.XButton1 Then
                PD_BGW_TODO = "Onload"
                Start_ProjectDetailsBGW()
            ElseIf e.Button = MouseButtons.Right Then
                PD_ContextMenu.Show()
                PD_ContextMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Private Sub ProjectDetailsDGV_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ProjectDetailsDGV.MouseDoubleClick
        Try
            If e.Button = MouseButtons.Left And is_CTD_bool = False Then
                is_CTD_bool = True
                PD_BGW_TODO = "Contracts_Load"
                Start_ProjectDetailsBGW()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Private Sub ProjectDetailsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProjectDetailsDGV.CellMouseClick
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                If e.Button = MouseButtons.Right Then
                    ProjectDetailsDGV.Rows(e.RowIndex).Selected = True
                    PD_ContextMenu.Show()
                    PD_ContextMenu.Location = New Point(MousePosition.X, MousePosition.Y)
                End If
                If is_CTD_bool = True And is_SalesJobOrder_bool = False Then
                    SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                    PD_ID = SearchStr
                ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = False Then
                    SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                    PD_ID = SearchStr
                ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = True Then
                    SearchStr = ProjectDetailsDGV.Item("ID", e.RowIndex).Value.ToString
                    CD_ID = SearchStr
                    JO = ProjectDetailsDGV.Item("JO#", e.RowIndex).Value.ToString
                End If
                FULLADDRESS = ProjectDetailsDGV.Item("ADDRESS", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub

    Private Sub Project_Details_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        Else
            KMDI_MainFRM.BringToFront()
            e.Cancel = False
        End If
    End Sub

    Private Sub ProjectDetailsDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ProjectDetailsDGV.RowEnter
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then

                If is_CTD_bool = True And is_SalesJobOrder_bool = False Then
                    SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                    PD_ID = SearchStr
                ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = False Then
                    SearchStr = ProjectDetailsDGV.Item("PD_ID", e.RowIndex).Value.ToString
                    PD_ID = SearchStr
                ElseIf is_CTD_bool = False Or is_SalesJobOrder_bool = True Then
                    SearchStr = ProjectDetailsDGV.Item("ID", e.RowIndex).Value.ToString
                    CD_ID = SearchStr
                    JO = ProjectDetailsDGV.Item("JO#", e.RowIndex).Value.ToString
                End If
                FULLADDRESS = ProjectDetailsDGV.Item("ADDRESS", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try
    End Sub
End Class