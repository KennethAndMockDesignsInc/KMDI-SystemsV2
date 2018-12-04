Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class BackloadFRM
    Dim sql As New KMDISystemsBackloadClass
    Public SearchString As String = Trim(SearchString)
    Public ActionTaken As String
    Public DBStatus As String
    Public TypeOfBackload As String

    Public StatusPrevIndex As Integer
    Public ItemPrevIndex As Integer

    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Public UpdateFN As String
    Public DeleteFN As String
    Public AddIFN As String

    Public OtherDetails As String
    Public BackloadedBy As String
    Public StorageLocation As String
    Public ItemClass As String
    Public DateToDismantle As String
    Public ItemID As String

    Public BackloadsBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub BackloadFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        AddHandler BackloadsBGW.DoWork, AddressOf BackloadsBGW_DoWork
        AddHandler BackloadsBGW.RunWorkerCompleted, AddressOf BackloadsBGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility
        TypeOfBackload = "Frame/Sash"

        LoadInitialSetUp()
    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub LoadInitialSetUp()
        SearchString = ""
        DBStatus = "Active"
        ActionTaken = "Search"
        StartWorker()
    End Sub

    Public Sub StartWorker()
        If BackloadsBGW.IsBusy <> True Then
            Select Case ActionTaken
                Case "Search"
                    DBStatus = "Active"
                    BackloadsAtHandDGV.Columns.Clear()
                    BackloadsAtHandDGV.DataSource = Nothing
                    BackloadsAtHandDGV.DataMember = Nothing
                Case "Add"
                Case "Update"
                Case "Delete"
                    DBStatus = "Deleted"
            End Select

            BackloadsBGW.WorkerSupportsCancellation = True
            BackloadsBGW.RunWorkerAsync()
        Else
            StatusTAB.SelectedIndex = StatusPrevIndex
            ItemTypeTAB.SelectedIndex = ItemPrevIndex
            MetroFramework.MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BackloadsBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            sql.Backloads(QueryFunction,
                          QueryBody,
                          QueryCondition,
                          ActionTaken)
        Catch ex As Exception
            MsgBox(ex.ToString)
            BackloadsBGW.WorkerSupportsCancellation = True
            BackloadsBGW.CancelAsync()
        End Try

        If BackloadsBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                QueryFunction = "Select"
                QueryBody = " [BLoads].[Autonum]
                                  ,[Contracts].JOB_ORDER_NO
                                  ,[Contracts].SUB_JO as [JO#]
                                  ,[BLoads].[Item No.]
                                  ,[BLoads].[K#]
                                  ,[BLoads].[Description]
                                  ,[BLoads].[Reason]
                                  ,[BLoads].[Other Details]
                                  ,[BLoads].[Control No.]
                                  ,[BLoads].[Storage Location]
                                  ,[BLoads].[Class]
                                  ,[BLoads].[Width]
                                  ,[BLoads].[Height]
                                  ,[BLoads].[Color]
	                              ,[Contracts].[ACCT_EXEC_INCHARGE] as AEIC
	                              ,[Accounts].[AUTONUM] as  [AEIC ID]
	                              ,[Contracts].[PROJECT_ENGR_INCHARGE] as EIC
	                              ,[Accounts].[AUTONUM] as [EIC ID]
                                  ,[BLoads].[Date to Dismantle]
                                  ,[BLoads].[Backloaded By]
                            From [BACKLOADS][BLoads] 
                                 join [ADDENDUM_TO_CONTRACT_TB][Contracts]
                                    Join [KMDI_ACCT_TB][Accounts]
                                    on [Accounts].[FULLNAME] = [Contracts].[ACCT_EXEC_INCHARGE]
                                 on [BLoads].[JO#] = [Contracts].[JOB_ORDER_NO]"
                QueryCondition = " Where [DB Status] = '" & DBStatus & "' and 
                                   [Item Type] = '" & TypeOfBackload & "' and 
                                   ([BLoads].[K#] like '%" & SearchString & "%' or 
                                   [BLoads].[K#] like '%" & SearchString & "%' or 
                                   [BLoads].[Description] like '%" & SearchString & "%' or 
                                   [BLoads].[Reason] like '%" & SearchString & "%' or 
                                   [Other Details] like '%" & SearchString & "%' or 
                                   [BLoads].[Control No.] like '%" & SearchString & "%' or 
                                   [BLoads].[Storage Location] like '%" & SearchString & "%' or 
                                   [BLoads].[Class] like '%" & SearchString & "%' or 
                                   [BLoads].[Width] like '%" & SearchString & "%' or 
                                   [BLoads].[Height] like '%" & SearchString & "%' or
                                   [BLoads].[Color] like '%" & SearchString & "%' or
                                   [Contracts].[ACCT_EXEC_INCHARGE] like '%" & SearchString & "%' or
                                   [Contracts].[PROJECT_ENGR_INCHARGE] like '%" & SearchString & "%')"

            Case "Add"
            Case "Update"
            Case "Delete"
                QueryFunction = " Update BACKLOADS"
                QueryBody = " set [DB Status] = '" & DBStatus & "'"
                QueryCondition = " Where [Autonum] = '" & ItemID & "'"
        End Select
    End Sub

    Private Sub BackloadsBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        MetroFramework.MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to delete the item. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select

            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        MetroFramework.MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                        MetroFramework.MetroMessageBox.Show(Me, "System was not able to delete the item. Please click OK button or press the Enter key then press F5 key to refresh the system.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            Read = sqlCommand.ExecuteReader
                            If Read.HasRows = True Then
                                Grid_Display()
                            Else
                                BackloadSearchFRM.Hide()
                                MetroFramework.MetroMessageBox.Show(Me, "No items where found in the database. Please refine search.", "No results found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                BackloadSearchFRM.Show()
                                BackloadSearchFRM.SearchTbox.Focus()
                            End If
                        Case "Delete"
                            LoadInitialSetUp()
                            MetroFramework.MetroMessageBox.Show(Me, "Item has been successfully deleted from the system.", "Item has been deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Select
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub Grid_Display()
        Select Case ActionTaken
            Case "Search"
                With BackloadsAtHandDGV
                    .DataSource = sql.ds
                    .DataMember = "BACKLOADS"
                    .Select()
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                    .Columns("Autonum").Visible = False
                    .Columns("JOB_ORDER_NO").Visible = False
                    .Columns("AEIC ID").Visible = False
                    .Columns("EIC ID").Visible = False
                    .Columns("Date to Dismantle").Visible = False
                    .Columns("Backloaded By").Visible = False
                End With
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select

    End Sub

    Private Sub BackloadsAtHandDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BackloadsAtHandDGV.CellMouseClick
        Try
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                If e.Button = MouseButtons.Right Then
                    OtherDetails = BackloadsAtHandDGV.Item("Other Details", e.RowIndex).Value.ToString
                    BackloadedBy = BackloadsAtHandDGV.Item("Backloaded By", e.RowIndex).Value.ToString
                    StorageLocation = BackloadsAtHandDGV.Item("Storage Location", e.RowIndex).Value.ToString
                    ItemClass = BackloadsAtHandDGV.Item("Class", e.RowIndex).Value.ToString
                    DateToDismantle = BackloadsAtHandDGV.Item("Date to Dismantle", e.RowIndex).Value.ToString
                    ItemID = BackloadsAtHandDGV.Item("Autonum", e.RowIndex).Value.ToString
                    BackloadImageFRM.JO = BackloadsAtHandDGV.Item("JOB_ORDER_NO", e.RowIndex).Value.ToString
                    MessageBox.Show(BackloadImageFRM.JO)
                    BackloadsCMS.Show()
                    BackloadsCMS.Location = New Point(MousePosition.X, MousePosition.Y)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        BackloadUpdateFRM.StorageLocationTBOX.Text = StorageLocation
        BackloadUpdateFRM.ItemClassCBOX.Text = ItemClass
        BackloadUpdateFRM.OtherDetailsTBOX.Text = OtherDetails
        BackloadUpdateFRM.BackloadedByTBOX.Text = BackloadedBy
        BackloadUpdateFRM.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ActionTaken = "Delete"
        StartWorker()
    End Sub

    Private Sub StatusTAB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusTAB.SelectedIndexChanged
        Select Case StatusTAB.SelectedIndex
            Case 0
                DBStatus = "Active"
                StartWorker()
                StatusPrevIndex = 0
            Case 1
                MetroFramework.MetroMessageBox.Show(Me, "This function is still under system upgrade. Notice will be posted once upgrade is finish. Thank you.", "Upgrade is on-going", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                StatusTAB.SelectedIndex = 0
                Exit Sub
                DBStatus = "Pending"
                StartWorker()
                StatusPrevIndex = 1
        End Select
    End Sub

    Private Sub ItemTypeTAB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemTypeTAB.SelectedIndexChanged
        Select Case ItemTypeTAB.SelectedIndex
            Case 0
                TypeOfBackload = "Frame/Sash"
                StartWorker()
                ItemPrevIndex = 0
            Case 1
                TypeOfBackload = "Screen"
                StartWorker()
                ItemPrevIndex = 1
            Case 2
                TypeOfBackload = "Glass"
                StartWorker()
                ItemPrevIndex = 2
            Case 3
                MetroFramework.MetroMessageBox.Show(Me, "This function is still under system upgrade. Notice will be posted once upgrade is finish. Thank you.", "Upgrade is on-going", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ItemTypeTAB.SelectedIndex = ItemPrevIndex
                Exit Sub
                TypeOfBackload = "Installation Material"
                StartWorker()
                ItemPrevIndex = 3
        End Select
    End Sub

    Private Sub BackloadFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BackloadSearchFRM.Close()
        BackloadUpdateFRM.Close()
        Me.Hide()
    End Sub

    Private Sub SearchFn(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, BackloadsAtHandDGV.KeyDown, BackloadsLBL.KeyDown, StatusTAB.KeyDown, ItemTypeTAB.KeyDown
        If e.KeyCode = Keys.F2 Or (e.Control And e.KeyCode = Keys.F) Then
            ActionTaken = "Search"
            BackloadSearchFRM.Show()
            BackloadSearchFRM.TopMost = True
        ElseIf e.KeyCode = Keys.F5 Then
            LoadInitialSetUp()
        ElseIf e.KeyCode = Keys.Enter Then
            ActionTaken = "Search"
            StartWorker()
        End If
    End Sub

    Private Sub BackloadsAtHandDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles BackloadsAtHandDGV.RowPostPaint
        sql.RowPostPaintBackload(sender, e)
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        BackloadImageFRM.Show()
    End Sub
End Class