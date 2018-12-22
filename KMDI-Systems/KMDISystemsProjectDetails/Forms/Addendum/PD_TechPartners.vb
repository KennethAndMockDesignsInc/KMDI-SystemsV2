Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class PD_TechPartners
    Public PD_TechPartners_BGW As BackgroundWorker = New BackgroundWorker
    Public PD_TechPartners_BGW_TODO As String = ""
    Sub Start_PD_TechPartners_BGW()
        If PD_TechPartners_BGW.IsBusy <> True Then

            TP_TabControl.Enabled = False
            LoadingPbox.Visible = True
            PD_TechPartners_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub


    Private Sub PD_TechPartners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nature_Cbox.SelectedIndex = 0
        If ArchDesignDT.Rows.Count > 0 Then
            TechPartners_DGV.Columns.Clear()
            TechPartners_DGV.DataSource = ArchDesignBS
            TechPartners_DGV.Columns("COMP_ID").Visible = False
            TechPartners_DGV.Columns("EMP_ID").Visible = False
            TechPartners_DGV.Columns("TP_ID").Visible = False
            TechPartners_DGV.Columns("TPN_ID").Visible = False
        End If

        PD_TechPartners_BGW.WorkerSupportsCancellation = True
        AddHandler PD_TechPartners_BGW.DoWork, AddressOf PD_TechPartners_BGW_DoWork
        AddHandler PD_TechPartners_BGW.RunWorkerCompleted, AddressOf PD_TechPartners_BGW_RunWorkerCompleted

        PD_TechPartners_BGW_TODO = "POSITION"
        Start_PD_TechPartners_BGW()
    End Sub

    Private Sub PD_TechPartners_BGW_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try
            If PD_TechPartners_BGW_TODO = "POSITION" Then
                QueryBUILD = "SELECT DISTINCT [POSITION]
                              FROM            [A_NEW_TECHNICAL_PARTNERS] 
                              WHERE           [POSITION] <> ''"
                SearchStr = ""
            ElseIf PD_TechPartners_BGW_TODO = "Search_Emp_DGV" Then
                QUERY_INSTANCE = "Loading_using_SearchString"
                QueryBUILD = "SELECT DISTINCT    EMP_ID,
		                                         NAME,
		                                         MOBILENO,
		                                         POSITION " & QueryMidArrays(8) & " WHERE [NAME] <> '' AND [EMP_STATUS] = 1 AND [NAME] LIKE @SearchString "
            ElseIf PD_TechPartners_BGW_TODO = "Search_Comp_DGV" Then
                QUERY_INSTANCE = "Loading_using_SearchString"
                QueryBUILD = "SELECT DISTINCT    [COMP_ID],
                                                 [OFFICENAME] " & QueryMidArrays(8) & " WHERE [OFFICENAME] <> '' AND [COMP_STATUS] = 1 AND [OFFICENAME] LIKE @SearchString "

            ElseIf PD_TechPartners_BGW_TODO = "Suggest_Comp_DGV" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = "SELECT DISTINCT   [COMP_ID],
                                                [OFFICENAME] " & QueryMidArrays(9) & " AND [EMP_ID] = @EqualSearch "
                SearchStr = EMP_ID
            ElseIf PD_TechPartners_BGW_TODO = "Search_for_TP_ID" Then
                SEARCH_TP_ID(COMP_ID, EMP_ID, EMP_POSITION)
            ElseIf PD_TechPartners_BGW_TODO = "Delete_Emp" Then
                If DGV_CLICKED = "Emp_DGV" Then
                    PD_UpdateEmp_Operations(Me, "Delete", EMP_ID)
                ElseIf DGV_CLICKED = "Comp_DGV" Then
                    PD_UpdateComp_Operations(Me, "Delete", COMP_ID)
                End If
            ElseIf PD_TechPartners_BGW_TODO = "INSERT_IN_TP_NATURE" Then
                PD_Addendum_Update_TechPartners(Me, CD_ID, TP_NATURE, COMP_ID, EMP_ID, EMP_POSITION, TP_ID)
            ElseIf PD_TechPartners_BGW_TODO = "Search_if_Deleted" Then
                PD_Addendum_TechPartners_SearchIfDeleted(TP_ID, CD_ID, TP_NATURE)
            ElseIf PD_TechPartners_BGW_TODO = "Return_Deleted_TP_NATURE" Then
                PD_Addendum_TechPartners_ReturnDeletedRow(Me, TPN_ID_SearchIfDeleted)
            End If
            Query_Select(SearchStr)
        Catch ex As SqlException
        'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
        If ex.Number = -2 Then
            MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ex.Number = 1232 Then
            MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PD_TechPartners_BGW.CancelAsync()
        ElseIf ex.Number = 19 Then
            MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PD_TechPartners_BGW.CancelAsync()
        ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
            MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            PD_TechPartners_BGW.CancelAsync()
        End If
        Catch ex2 As Exception
        MessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub PD_TechPartners_BGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                For Each DGV In TP_Tab.Controls
                    If TypeOf DGV Is DataGridView Then
                        DGV.Enabled = True
                        If PD_TechPartners_BGW_TODO.Contains(DGV.Name) Then
                            With DGV
                                .Columns.Clear()
                                .DataSource = Nothing
                                .DataSource = sqlBindingSource
                                .DefaultCellStyle.BackColor = Color.White
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                        End If
                    End If
                Next

                If Comp_DGV.Rows.Count > 0 Then
                    Comp_DGV.ScrollBars = ScrollBars.Both
                ElseIf Comp_DGV.Rows.Count <= 0 Then
                    Comp_DGV.ScrollBars = ScrollBars.None
                End If
                If Emp_DGV.Rows.Count > 0 Then
                    Emp_DGV.ScrollBars = ScrollBars.Both
                ElseIf Emp_DGV.Rows.Count <= 0 Then
                    Emp_DGV.ScrollBars = ScrollBars.None
                End If


                If PD_TechPartners_BGW_TODO.Contains("Comp_DGV") Then
                    Comp_DGV.Columns("COMP_ID").Visible = False

                ElseIf PD_TechPartners_BGW_TODO = "POSITION" Then
                    Position_Cbox.DataBindings.Clear()
                    Position_Cbox.DataSource = sqlBindingSource
                    Position_Cbox.ValueMember = "POSITION"
                    SearchStr = ""
                    PD_TechPartners_BGW_TODO = "Search_Emp_DGV"
                    Start_PD_TechPartners_BGW()

                ElseIf PD_TechPartners_BGW_TODO = "Search_Emp_DGV" Then
                    Emp_DGV.Columns("EMP_ID").Visible = False
                    Emp_DGV.Columns("MOBILENO").Visible = False
                    Emp_DGV.Columns("POSITION").Visible = False

                    PD_TechPartners_BGW_TODO = "Suggest_Comp_DGV"
                    Start_PD_TechPartners_BGW()
                ElseIf PD_TechPartners_BGW_TODO = "Delete_Emp" Then
                    If PD_CountSuccess = 1 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Success", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        PD_CountSuccess = 0
                        PD_TechPartners_BGW_TODO = "POSITION"
                        Start_PD_TechPartners_BGW()
                    End If
                ElseIf PD_TechPartners_BGW_TODO = "Search_for_TP_ID" Then
                    If TP_ID <> Nothing Then
                        PD_TechPartners_BGW_TODO = "Search_if_Deleted"
                    ElseIf TP_ID = Nothing Then
                        PD_TechPartners_BGW_TODO = "INSERT_IN_TP_NATURE"
                    End If
                    Start_PD_TechPartners_BGW()
                ElseIf PD_TechPartners_BGW_TODO = "INSERT_IN_TP_NATURE" Or PD_TechPartners_BGW_TODO = "Return_Deleted_TP_NATURE" Then
                    If PD_CountSuccess = 1 Then
                        If col_invisi_bool = True Then
                            TechPartners_DGV.Columns.Clear()
                            If Nature_Cbox.SelectedIndex = 0 Then
                                ArchDesignDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                ArchDesignBS.DataSource = ArchDesignDT
                                TechPartners_DGV.DataSource = ArchDesignBS
                            ElseIf Nature_Cbox.SelectedIndex = 1 Then
                                IntrDesignDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                IntrDesignBS.DataSource = IntrDesignDT
                                TechPartners_DGV.DataSource = IntrDesignBS
                            ElseIf Nature_Cbox.SelectedIndex = 2 Then
                                ConsMngmtDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                ConsMngmtBS.DataSource = ConsMngmtDT
                                TechPartners_DGV.DataSource = ConsMngmtBS
                            ElseIf Nature_Cbox.SelectedIndex = 3 Then
                                GenConDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                GenConBS.DataSource = GenConDT
                                TechPartners_DGV.DataSource = GenConBS
                            End If

                            TechPartners_DGV.Columns("COMP_ID").Visible = False
                            TechPartners_DGV.Columns("EMP_ID").Visible = False
                            TechPartners_DGV.Columns("TP_ID").Visible = False
                            TechPartners_DGV.Columns("TPN_ID").Visible = False
                            col_invisi_bool = False
                        Else
                            If Nature_Cbox.SelectedIndex = 0 Then
                                ArchDesignDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                ArchDesignBS.DataSource = ArchDesignDT
                                TechPartners_DGV.DataSource = ArchDesignBS
                            ElseIf Nature_Cbox.SelectedIndex = 1 Then
                                IntrDesignDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                IntrDesignBS.DataSource = IntrDesignDT
                                TechPartners_DGV.DataSource = IntrDesignBS
                            ElseIf Nature_Cbox.SelectedIndex = 2 Then
                                ConsMngmtDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                ConsMngmtBS.DataSource = ConsMngmtDT
                                TechPartners_DGV.DataSource = ConsMngmtBS
                            ElseIf Nature_Cbox.SelectedIndex = 3 Then
                                GenConDT.Rows.Add(COMP_NAME, EMP_NAME, Position_Cbox.Text, EMP_MOBILENO, COMP_ID, EMP_ID, TP_ID, TPN_ID)
                                GenConBS.DataSource = GenConDT
                                TechPartners_DGV.DataSource = GenConBS
                            End If
                        End If
                    ElseIf PD_CountSuccess = 0 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Failed", PD_TechPartners_BGW_TODO, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                ElseIf PD_TechPartners_BGW_TODO = "Search_if_Deleted" Then
                    If TPN_ID_SearchIfDeleted <> Nothing Then
                        PD_TechPartners_BGW_TODO = "Return_Deleted_TP_NATURE"
                    ElseIf TPN_ID_SearchIfDeleted = Nothing Then
                        PD_TechPartners_BGW_TODO = "INSERT_IN_TP_NATURE"
                    End If
                    Start_PD_TechPartners_BGW()
                End If
            End If
            TP_TabControl.Enabled = True
            LoadingPbox.Visible = False
        Catch ex As Exception
        MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub PerformSearch()
        SearchStr = Search_Tbox.Text

        If DGV_CLICKED = "Emp_DGV" Then
            Emp_DGV.ScrollBars = ScrollBars.None
            PD_TechPartners_BGW_TODO = "Search_Emp_DGV"
            Start_PD_TechPartners_BGW()
        ElseIf DGV_CLICKED = "Comp_DGV" Then
            Comp_DGV.ScrollBars = ScrollBars.None
            PD_TechPartners_BGW_TODO = "Search_Comp_DGV"
            Start_PD_TechPartners_BGW()
        End If
    End Sub

    Private Sub Search_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Search_Tbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                PerformSearch()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Search_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Search_Tbox.ButtonClick
        Try
            PerformSearch()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Dim DGV_CLICKED As String = "Emp_DGV"
    Private Sub Emp_DGV_MouseClick(sender As Object, e As MouseEventArgs) Handles Emp_DGV.MouseClick
        DGV_CLICKED = "Emp_DGV"
        Emp_DGV.BorderStyle = 1
        Comp_DGV.BorderStyle = 0
    End Sub

    Private Sub Comp_DGV_MouseClick(sender As Object, e As MouseEventArgs) Handles Comp_DGV.MouseClick
        DGV_CLICKED = "Comp_DGV"
        Comp_DGV.BorderStyle = 1
        Emp_DGV.BorderStyle = 0
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Emp_DGV.CellMouseClick, Comp_DGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            If e.Button = MouseButtons.Right Then
                TP_Cmenu.Show()
                TP_Cmenu.Location = New Point(MousePosition.X, MousePosition.Y)
            End If
            If DGV_CLICKED = "Comp_DGV" Then
                Comp_DGV.Rows(e.RowIndex).Selected = True
                COMP_ID = Comp_DGV.Item("COMP_ID", e.RowIndex).Value.ToString
                COMP_NAME = Comp_DGV.Item("OFFICENAME", e.RowIndex).Value.ToString
            ElseIf DGV_CLICKED = "Emp_DGV" Then
                Emp_DGV.Rows(e.RowIndex).Selected = True
                EMP_ID = Emp_DGV.Item("EMP_ID", e.RowIndex).Value.ToString
                EMP_NAME = Emp_DGV.Item("NAME", e.RowIndex).Value.ToString
                EMP_MOBILENO = Emp_DGV.Item("MOBILENO", e.RowIndex).Value.ToString
                EMP_POSITION = Emp_DGV.Item("POSITION", e.RowIndex).Value.ToString
                Position_Cbox.Text = EMP_POSITION
            End If
        End If
    End Sub

    Private Sub Emp_DGV_Click(sender As Object, e As MouseEventArgs) Handles Emp_DGV.Click
        PD_TechPartners_BGW_TODO = "Suggest_Comp_DGV"
        Start_PD_TechPartners_BGW()
    End Sub

    Private Sub Emp_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Emp_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        If DGV_CLICKED = "Comp_DGV" Then
            PD_UpdateCOMP.frm_open_thru = "Add"
            PD_UpdateCOMP.Show()
            PD_UpdateCOMP.BringToFront()
        ElseIf DGV_CLICKED = "Emp_DGV" Then
            PD_UpdateEMP.frm_open_thru = "Add"
            PD_UpdateEMP.Show()
            PD_UpdateEMP.BringToFront()
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If DGV_CLICKED = "Comp_DGV" Then
            PD_UpdateCOMP.frm_open_thru = "Update"
            PD_UpdateCOMP.Show()
            PD_UpdateCOMP.BringToFront()
        ElseIf DGV_CLICKED = "Emp_DGV" Then
            PD_UpdateEMP.frm_open_thru = "Update"
            PD_UpdateEMP.Show()
            PD_UpdateEMP.BringToFront()
        End If
    End Sub

    Private Sub Comp_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles Comp_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub TechPartners_DGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles TechPartners_DGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub Nature_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Nature_Cbox.SelectionChangeCommitted
        TechPartners_DGV.Columns.Clear()
        If Nature_Cbox.SelectedIndex = 0 Then
            ArchDesignBS.DataSource = ArchDesignDT
            TechPartners_DGV.DataSource = ArchDesignBS
        ElseIf Nature_Cbox.SelectedIndex = 1 Then
            IntrDesignBS.DataSource = IntrDesignDT
            TechPartners_DGV.DataSource = IntrDesignBS
        ElseIf Nature_Cbox.SelectedIndex = 2 Then
            ConsMngmtBS.DataSource = ConsMngmtDT
            TechPartners_DGV.DataSource = ConsMngmtBS
        ElseIf Nature_Cbox.SelectedIndex = 3 Then
            GenConBS.DataSource = GenConDT
            TechPartners_DGV.DataSource = GenConBS
        End If
        TechPartners_DGV.Columns("COMP_ID").Visible = False
        TechPartners_DGV.Columns("EMP_ID").Visible = False
        TechPartners_DGV.Columns("TP_ID").Visible = False
        TechPartners_DGV.Columns("TPN_ID").Visible = False
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = 6 Then
            PD_TechPartners_BGW_TODO = "Delete_Emp"
            Start_PD_TechPartners_BGW()
        End If
    End Sub

    Dim col_invisi_bool As Boolean = True
    Dim TP_NATURE As String
    Private Sub Operation_BTN_Click(sender As Object, e As EventArgs) Handles Operation_BTN.Click
        TP_NATURE = Nature_Cbox.Text
        EMP_POSITION = Position_Cbox.Text
        If ArchDesignDT.Rows.Count <> Nothing Or IntrDesignDT.Rows.Count <> Nothing Or
           ConsMngmtDT.Rows.Count <> Nothing Or GenConDT.Rows.Count <> Nothing Then
            col_invisi_bool = False
        End If

        Dim count_occur_emp, row_emp As Integer
        If Nature_Cbox.SelectedIndex = 0 Then
            count_occur_emp = 0
            For Each row In ArchDesignBS
                row_emp = row("EMP_ID")
                If row_emp = EMP_ID Then
                    count_occur_emp += 1
                End If
            Next
        ElseIf Nature_Cbox.SelectedIndex = 1 Then
            count_occur_emp = 0
            For Each row In IntrDesignBS
                row_emp = row("EMP_ID")
                If row_emp = EMP_ID Then
                    count_occur_emp += 1
                End If
            Next
        ElseIf Nature_Cbox.SelectedIndex = 2 Then
            count_occur_emp = 0
            For Each row In ConsMngmtBS
                row_emp = row("EMP_ID")
                If row_emp = EMP_ID Then
                    count_occur_emp += 1
                End If
            Next
        ElseIf Nature_Cbox.SelectedIndex = 3 Then
            count_occur_emp = 0
            For Each row In GenConBS
                row_emp = row("EMP_ID")
                If row_emp = EMP_ID Then
                    count_occur_emp += 1
                End If
            Next
        End If

        If COMP_ID = Nothing Or COMP_NAME = Nothing Or EMP_ID = Nothing Or EMP_NAME = Nothing Or Position_Cbox.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please fill up the filled(s)", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If count_occur_emp = 0 Then
                PD_TechPartners_BGW_TODO = "Search_for_TP_ID"
                Start_PD_TechPartners_BGW()
            ElseIf count_occur_emp > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Duplicate Employee", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Comp_DGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Comp_DGV.RowEnter
        Try
            COMP_ID = Comp_DGV.Item("COMP_ID", e.RowIndex).Value.ToString
            COMP_NAME = Comp_DGV.Item("OFFICENAME", e.RowIndex).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Emp_DGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Emp_DGV.RowEnter
        Try
            EMP_ID = Emp_DGV.Item("EMP_ID", e.RowIndex).Value.ToString
            EMP_NAME = Emp_DGV.Item("NAME", e.RowIndex).Value.ToString
            EMP_MOBILENO = Emp_DGV.Item("MOBILENO", e.RowIndex).Value.ToString
            EMP_POSITION = Emp_DGV.Item("POSITION", e.RowIndex).Value.ToString
            Position_Cbox.Text = EMP_POSITION

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class