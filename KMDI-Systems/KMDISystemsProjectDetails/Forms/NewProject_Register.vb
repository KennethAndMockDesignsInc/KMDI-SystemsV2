Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class NewProject_Register

    Public CountRequiredField As Integer
    Public CountFilledRequiredField As Integer = 0
    Dim selecting_bool As Boolean
    Public NewProjects_BGW As BackgroundWorker = New BackgroundWorker
    Dim NewProjects_TODO As String

    Sub Reset()
        selecting_bool = True
        For Each TabPages In BreadCrumb_Tab.Controls
            If TypeOf TabPages Is TabPage Then
                For Each CtrlToClear In TabPages.Controls
                    If CtrlToClear.Name.Contains("Tbox") Then
                        CtrlToClear.Clear
                    ElseIf TypeOf CtrlToClear Is ComboBox Then
                        CtrlToClear.SelectedIndex = -1
                        CtrlToClear.Text = Nothing
                    End If
                Next
            End If
        Next
        AEICSelectedDGV.Rows.Clear()
        BreadCrumb_Tab.SelectedIndex = 0
        Next_Btn.Text = "Next"
    End Sub

    Private Sub Next_Btn_Click(sender As Object, e As EventArgs) Handles Next_Btn.Click
        If Next_Btn.Text = "Next" Then

            If Source_Cbox_Required.Text = "Advertorial(s)" Or
            Source_Cbox_Required.Text = "Exhibition" Or
            Source_Cbox_Required.Text = "Saturation" Or
            Source_Cbox_Required.Text = "Website Inquiry" Then
                CountRequiredField = 6
            Else
                CountRequiredField = 7
            End If

            For Each ctrl In ProjectDetails_Page.Controls
                If ctrl.Name.Contains("_Required") = True Then
                    ctrl.Text = Trim(ctrl.Text)
                    If ctrl.Name.Contains("Source_Cbox_Required") = True Then
                        If ctrl.Text = "" Or ctrl.Text = Nothing Then
                            ctrl.Style = MetroFramework.MetroColorStyle.Red
                            ctrl.Select()
                            ctrl.Focus()
                            Warning_Tooltip.Show("fill up this REQUIRED field", ctrl)
                        Else
                            If ctrl.Text <> "Advertorial(s)" And
                               ctrl.Text <> "Exhibition" And
                               ctrl.Text <> "Saturation" And
                               ctrl.Text <> "Website Inquiry" Then
                                If SourceName_Tbox_Required.Text = "" Or SourceName_Tbox_Required.Text = Nothing Then
                                    SourceName_Tbox_Required.Style = MetroFramework.MetroColorStyle.Red
                                    ProjectSource_LBL.Focus()
                                    SourceName_Tbox_Required.Select()
                                    Warning_Tooltip.Show("fill up this REQUIRED field", SourceName_Tbox_Required)
                                Else
                                    CountFilledRequiredField += 2
                                End If
                            Else
                                CountFilledRequiredField += 1
                            End If
                        End If
                    ElseIf ctrl.Name.Contains("SourceName_Tbox_Required") = True Then
                        ' Para maiwasan na daanan ng condition sa ibaba ang SourceName_Tbox_Required
                    ElseIf ctrl.Name.Contains("Owners_Tbox_Required") = True Then
                        If (Owners_Tbox_Required.Text = "" Or Owners_Tbox_Required.Text = Nothing) And
                           (CompanyName_Tbox_Required.Text = "" Or CompanyName_Tbox_Required.Text = Nothing) Then
                            Owners_Tbox_Required.Style = MetroFramework.MetroColorStyle.Red
                            CompanyName_Tbox_Required.Style = MetroFramework.MetroColorStyle.Red
                            Owners_Tbox_Required.Select()
                            Owners_Tbox_Required.Focus()
                            Warning_Tooltip.Show("fill up Owner's or Company's Name field," & vbCrLf & " Either of this is REQUIRED", Owners_Tbox_Required)
                        Else
                            CountFilledRequiredField += 1
                        End If
                    ElseIf ctrl.Name.Contains("CompanyName_Tbox_Required") = True Then
                        ' Para maiwasan na daanan ng condition sa ibaba ang SourceName_Tbox_Required
                    ElseIf ctrl.Name.Contains("Source_Cbox_Required") = False And
                            ctrl.Name.Contains("SourceName_Tbox_Required") = False And
                            ctrl.Name.Contains("Owners_Tbox_Required") = False And
                            ctrl.Name.Contains("CompanyName_Tbox_Required") = False Then
                        If ctrl.Text = Nothing Or ctrl.Text = "" Then
                            ctrl.Style = MetroFramework.MetroColorStyle.Red
                            ctrl.Select()
                            ctrl.Focus()
                            Warning_Tooltip.Show("fill up this REQUIRED field", ctrl)
                        Else
                            CountFilledRequiredField += 1
                        End If
                    End If

                End If
            Next ctrl

            If CountFilledRequiredField = CountRequiredField Then
                If BreadCrumb_Tab.SelectedIndex = 0 Then
                    AddressFormat(UnitNo_Tbox.Text,
                                  Establishment_Tbox.Text,
                                  HouseNo_Tbox.Text,
                                  Street_Tbox_Required.Text,
                                  Village_Tbox.Text,
                                  Brgy_Tbox.Text,
                                  City_Tbox_Required.Text,
                                  Province_Tbox_Required.Text)
                    P1nP2()
                    If MessageBox.Show(Me, "Project Source" & vbCrLf & vbCrLf &
                                vbTab & "Source:    " & Source_Cbox_Required.Text & vbCrLf & vbCrLf &
                                vbTab & "Name of Source:    " & SourceName_Tbox_Required.Text & vbCrLf & vbCrLf &
                                "Owner's Name:  " & Owners_Tbox_Required.Text & vbCrLf & vbCrLf &
                                "Company Name:  " & CompanyName_Tbox_Required.Text & vbCrLf & vbCrLf &
                                "Project Address:   " & FullAddress & vbCrLf & vbCrLf &
                                "Project Classification:   " & P1plusP2 & vbCrLf & vbCrLf &
                                "Competitors:   " & Competitors_Cbox.Text & vbCrLf & vbCrLf,
                                "Please Review!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        selecting_bool = True
                        BreadCrumb_Tab.SelectedIndex += 1
                        selecting_bool = False
                    End If
                ElseIf BreadCrumb_Tab.SelectedIndex = 1 Then
                    If MessageBox.Show(Me, "Details" & vbCrLf & vbCrLf &
                               vbTab & "Name:    " & ClientName_Tbox.Text & vbCrLf & vbCrLf &
                               vbTab & "E-mail:    " & Email_Tbox.Text & vbCrLf & vbCrLf &
                               "Contact Numbers  " & vbCrLf & vbCrLf &
                               vbTab & "(Home):  " & HomeCN_Tbox.Text & vbCrLf & vbCrLf &
                               vbTab & "(Office):   " & OFficeCN_Tbox.Text & vbCrLf & vbCrLf &
                               vbTab & "(Mobile):   " & MobileCN_Tbox.Text & vbCrLf & vbCrLf,
                               "Please Review!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        selecting_bool = True
                        BreadCrumb_Tab.SelectedIndex += 1
                        selecting_bool = False
                    End If
                End If
            End If
            CountFilledRequiredField = 0


        ElseIf Next_Btn.Text = "Finish" Then
            AEICSelectedDGVRows = AEICSelectedDGV.Rows.Count
            Source = Trim(SourceName_Tbox_Required.Text)
            Competitors = Trim(Competitors_Cbox.Text)
            ClientName = Trim(ClientName_Tbox.Text)
            Owners = Trim(Owners_Tbox_Required.Text)
            HomeCN = Trim(HomeCN_Tbox.Text)
            OfficeCn = Trim(OFficeCN_Tbox.Text)
            MobileCN = Trim(MobileCN_Tbox.Text)
            Email = Trim(Email_Tbox.Text)
            Area = Trim(Area_Cbox_Required.Text)
            Company_Name = Trim(CompanyName_Tbox_Required.Text)
            If AEICSelectedDGVRows = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please Assign AEIC", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                BreadCrumb_Tab.Enabled = False
                PrevNxt_PNL.Enabled = False
                NewProjects_TODO = "INSERT"
                Start_NewProjects_BGW()
                'If Insert_BGW.IsBusy = False Then
                '    LoadingPboxRNP.Visible = True
                '    Insert_BGW.RunWorkerAsync()
                'Else
                'End If
            End If
        End If
    End Sub
    Public AEICSelectedDGVRows As Integer

    Public Sub Start_NewProjects_BGW()
        If NewProjects_BGW.IsBusy <> True Then
            If NewProjects_TODO = "AEIC_Load" Then
                Loading_LBL.Visible = True
                LoadingPB.Visible = True
            Else
                LoadingPboxRNP.Visible = True
            End If
            NewProjects_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub NewProject_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'sqlConnection.Close()
            'sqlConnection.ConnectionString = "Data Source='121.58.229.248,49107';Network Library=DBMSSOCN;Initial Catalog='heretosave';User ID='kmdiadmin';Password='kmdiadmin';"
            'AEICListDGV.Columns("AUTONUM1").Visible = False
            'AEICListDGV.Columns("index1").Visible = False
            'AEICSelectedDGV.Columns("AUTONUM").Visible = False
            'AEICSelectedDGV.Columns("index").Visible = False

            NewProjects_BGW.WorkerSupportsCancellation = True
            NewProjects_BGW.WorkerReportsProgress = True
            AddHandler NewProjects_BGW.DoWork, AddressOf NewProjects_BGW_DoWork
            AddHandler NewProjects_BGW.RunWorkerCompleted, AddressOf NewProjects_BGW_RunWorkerCompleted

            selecting_bool = False
            NewProjects_TODO = "Onload"
            Start_NewProjects_BGW()

        Catch ex As Exception
            MessageBox.Show(Me, "Please Refer to Error_Logs.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                       "Error Message: " & ex.Message & vbCrLf &
                                       "Trace: " & ex.StackTrace & vbCrLf)
            Log_File.Close()
        End Try

    End Sub

    Private Sub BreadCrumb_Tab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BreadCrumb_Tab.SelectedIndexChanged
        If BreadCrumb_Tab.SelectedIndex = 0 Then
            Prev_Btn.Visible = False
            Next_Btn.Text = "Next"
            ProjectDetails_Page.Text = "Project Details  "
            ClientDetails_Page.Text = "Client Details  "
            AEIC_Page.Text = "AEIC Assignment"
        ElseIf BreadCrumb_Tab.SelectedIndex = 1 Then
            Prev_Btn.Visible = True
            Next_Btn.Text = "Next"
            ProjectDetails_Page.Text = "Project Details >"
            ClientDetails_Page.Text = "Client Details  "
            AEIC_Page.Text = "AEIC Assignment"
        ElseIf BreadCrumb_Tab.SelectedIndex = 2 Then
            NewProjects_TODO = "AEIC_LOAD"
            Start_NewProjects_BGW()
            Prev_Btn.Visible = True
            Next_Btn.Text = "Finish"
            ProjectDetails_Page.Text = "Project Details >"
            ClientDetails_Page.Text = "Client Details >"
            AEIC_Page.Text = "AEIC Assignment"
        End If
    End Sub

    Private Sub BreadCrumb_Tab_Selecting(sender As Object, e As TabControlCancelEventArgs) Handles BreadCrumb_Tab.Selecting
        If selecting_bool = True Then
            e.Cancel = False
        ElseIf selecting_bool = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BreadCrumb_Tab_Click(sender As Object, e As EventArgs) Handles BreadCrumb_Tab.Click
        selecting_bool = False
    End Sub

    Private Sub Prev_Next_Btn_MouseDown(sender As Object, e As MouseEventArgs) Handles Next_Btn.MouseDown, Prev_Btn.MouseDown
        selecting_bool = True
    End Sub

    Private Sub Prev_Next_Btn_MouseUp(sender As Object, e As MouseEventArgs) Handles Next_Btn.MouseUp, Prev_Btn.MouseUp
        selecting_bool = False
    End Sub

    Private Sub Prev_Btn_Click(sender As Object, e As EventArgs) Handles Prev_Btn.Click
        selecting_bool = True
        BreadCrumb_Tab.SelectedIndex -= 1
        selecting_bool = False
    End Sub

    Private Sub Required_Tbox_Click(sender As Object, e As EventArgs) Handles SourceName_Tbox_Required.Click, Source_Cbox_Required.Click, Area_Cbox_Required.Click, City_Tbox_Required.Click, Street_Tbox_Required.Click, Province_Tbox_Required.Click, Owners_Tbox_Required.Click, CompanyName_Tbox_Required.Click
        For Each ctrl In ProjectDetails_Page.Controls

            If ctrl.Name.Contains("_Required") Then
                Warning_Tooltip.Hide(ctrl)
                ctrl.Style = MetroFramework.MetroColorStyle.Blue
            End If

        Next ctrl
    End Sub
    Private Sub Required_Tbox_Keydown(sender As Object, e As EventArgs) Handles SourceName_Tbox_Required.KeyDown, Source_Cbox_Required.KeyDown, Area_Cbox_Required.KeyDown, City_Tbox_Required.KeyDown, Street_Tbox_Required.KeyDown, Province_Tbox_Required.KeyDown, Owners_Tbox_Required.KeyDown, CompanyName_Tbox_Required.KeyDown
        For Each ctrl In ProjectDetails_Page.Controls

            If ctrl.Name.Contains("_Required") Then
                Warning_Tooltip.Hide(ctrl)
                ctrl.Style = MetroFramework.MetroColorStyle.Blue
            End If

        Next ctrl
    End Sub

    Private Sub AEICListDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles AEICListDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub AEICSelectedDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles AEICSelectedDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    'Private Sub AEIC_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
    '    Try
    '        QueryBUILD = "SELECT     [AUTONUM],
    '                                 [FULLNAME]
    '                      FROM       [KMDI_ACCT_TB] where ACCTTYPE = 'AEIC'"
    '        Query_Select("")
    '    Catch ex As SqlException
    '        'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
    '        If ex.Number = -2 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        ElseIf ex.Number = 1232 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            AEIC_BGW.CancelAsync()
    '        ElseIf ex.Number = 19 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            AEIC_BGW.CancelAsync()
    '        ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
    '            AEIC_BGW.CancelAsync()
    '        End If
    '    Catch ex2 As Exception
    '        MetroFramework.MetroMessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '    End Try
    'End Sub

    'Private Sub AEIC_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
    '    Try

    '        If e.Error IsNot Nothing Then
    '            '' if BackgroundWorker terminated due to error
    '            Loading_LBL.Text = "Error Occured"
    '            LoadingPB.Enabled = False
    '            MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ElseIf e.Cancelled = True Then
    '            '' otherwise if it was cancelled
    '            Loading_LBL.Text = "An Error Occured"
    '            LoadingPB.Enabled = False
    '        Else
    '            '' otherwise it completed normally
    '            Dim rowIndex As Integer = 0
    '            For Each row In sqlBindingSource
    '                AEICListDGV.Rows.Add(row("AUTONUM"), rowIndex, row("FULLNAME"))
    '                rowIndex += 1
    '            Next row
    '            'AEICListDGV.DataSource = sqlBindingSource
    '            With AEICListDGV
    '                .DefaultCellStyle.BackColor = Color.White
    '                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    '            End With
    '            Loading_LBL.Visible = False
    '            LoadingPB.Visible = False
    '        End If

    '    Catch ex As Exception
    '        MetroFramework.MetroMessageBox.Show(Me, ex.Message)
    '    End Try
    'End Sub
    Public AE_ID_ToAddnDel, AE_Fullname_ToAddnDel, AE_Index_ToAddnDel As String

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        AEICSelectedDGV.Rows.Add(AE_ID_ToAddnDel, AE_Index_ToAddnDel, AE_Fullname_ToAddnDel)
        For Each row As DataGridViewRow In AEICListDGV.SelectedRows
            AEICListDGV.Rows.Remove(row)
        Next
    End Sub

    Private Sub AEICSelectedDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AEICSelectedDGV.CellMouseClick
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                If e.Button = MouseButtons.Right Then
                    AEICSelectedDGV.Rows(e.RowIndex).Selected = True
                    Dim r As New Rectangle
                    r = AEICSelectedDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    DeleteToolStripMenuItem.Visible = True
                    AddToolStripMenuItem.Visible = False
                    Register_CMenu.Show()
                    Register_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
                End If
                AE_ID_ToAddnDel = AEICSelectedDGV.Item("AUTONUM", e.RowIndex).Value.ToString
                AE_Fullname_ToAddnDel = AEICSelectedDGV.Item("FULLNAME", e.RowIndex).Value.ToString
                AE_Index_ToAddnDel = AEICSelectedDGV.Item("index", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub OnLoad_BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles OnLoad_BGW.DoWork
    '    Try
    '        QueryBUILD = "SELECT DISTINCT    [COMPETITORS]
    '                      FROM               [A_NEW_PROJECT_DETAILS]
    '                      WHERE              [PD_STATUS] = 1"
    '        Query_Select("")
    '    Catch ex As SqlException
    '        'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
    '        If ex.Number = -2 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        ElseIf ex.Number = 1232 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            OnLoad_BGW.CancelAsync()
    '        ElseIf ex.Number = 19 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            OnLoad_BGW.CancelAsync()
    '        ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
    '            OnLoad_BGW.CancelAsync()
    '        End If
    '    Catch ex2 As Exception
    '        MetroFramework.MetroMessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '    End Try
    'End Sub
    Private Sub NewProjects_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case NewProjects_TODO
                Case "Onload"
                    Query_Select_STP("", "PD_stp_NewProject_COMPETITORS")
                Case "AEIC_LOAD"
                    Query_Select_STP("", "PD_stp_NewProject_AELoad")
                Case "INSERT"
                    For i = 0 To AEICSelectedDGV.Rows.Count - 1
                        arr_AEID.Add(AEICSelectedDGV.Rows(i).Cells("AUTONUM").Value.ToString)
                    Next
                    PD_Inserts_NewProj(Source, P1plusP2, Competitors, UnitNo, Establishment, HouseNo, Street, Village, Brgy,
                                       CityMunicipality, Province, Area, FullAddress, ClientName, Owners, HomeCN, OfficeCn,
                                       MobileCN, Email, Company_Name)
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
    Private Sub NewProjects_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            Select Case NewProjects_TODO
                Case "Onload"
                    With Competitors_Cbox
                        .DataSource = sqlBindingSource
                        .ValueMember = "COMPETITORS"
                        .DisplayMember = "COMPETITORS"
                    End With
                Case "AEIC_LOAD"
                    Dim rowIndex As Integer = 0
                    For Each row In sqlBindingSource
                        AEICListDGV.Rows.Add(row("AUTONUM"), rowIndex, row("FULLNAME"))
                        rowIndex += 1
                    Next row
                    With AEICListDGV
                        .DefaultCellStyle.BackColor = Color.White
                        .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    End With
                    Loading_LBL.Visible = False
                    LoadingPB.Visible = False
                Case "INSERT"
                    If sql_err_bool = True Then
                        If sql_Transaction_result = "Committed" Then
                            MetroFramework.MetroMessageBox.Show(Me, "Success", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Reset()

                            BreadCrumb_Tab.Enabled = True
                            PrevNxt_PNL.Enabled = True
                            LoadingPboxRNP.Visible = False

                            PD_CountSuccess = 0

                            is_CTD_bool = False
                            QueryBUILD = QuerySearchHeadArrays(0) & QueryMidArrays(0) & QueryConditionArrays(0) &
                                 " " & QueryORDERArrays(0)
                            SearchStr = ""
                            Project_Details.Start_ProjectDetailsBGW()

                            selecting_bool = False

                            BreadCrumb_Tab.Enabled = True
                            PrevNxt_PNL.Enabled = True
                            LoadingPboxRNP.Visible = False
                        ElseIf sql_Transaction_result = "Rollback" Then
                            MetroFramework.MetroMessageBox.Show(Me, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
                        Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
                                           "SQL Transaction Error Number: " & sql_Err_no & vbCrLf &
                                           "SQL Transaction Error Message: " & sql_Err_msg & vbCrLf &
                                           "Trace: " & sql_Err_StackTrace & vbCrLf)
                        MetroFramework.MetroMessageBox.Show(Me, "Transaction failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    sql_err_bool = False
                    sql_Err_msg = Nothing
                    sql_Err_no = Nothing
                    sql_Transaction_result = ""
            End Select

            LoadingPboxRNP.Visible = False
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
    'Private Sub OnLoad_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles OnLoad_BGW.RunWorkerCompleted
    '    Try

    '        If e.Error IsNot Nothing Then
    '            '' if BackgroundWorker terminated due to error
    '            MetroFramework.MetroMessageBox.Show(Me, "Please Restart!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ElseIf e.Cancelled = True Then
    '            '' otherwise if it was cancelled
    '            MetroFramework.MetroMessageBox.Show(Me, "Please Restart!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            '' otherwise it completed normally
    '            With Competitors_Cbox
    '                .DataSource = sqlBindingSource
    '                .ValueMember = "COMPETITORS"
    '                .DisplayMember = "COMPETITORS"
    '            End With

    '        End If
    '        LoadingPboxRNP.Visible = False

    '    Catch ex As Exception
    '        MetroFramework.MetroMessageBox.Show(Me, ex.Message)
    '    End Try
    'End Sub

    Public Source, Competitors, ClientName, Owners, HomeCN, OfficeCn, MobileCN, Email, Company_Name As String

    'Private Sub Insert_BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles Insert_BGW.DoWork
    '    Try
    '        'A_NEW_PROJECT_DETAILS_Insert(Me,
    '        '                             Source,
    '        '                             P1plusP2,
    '        '                             Competitors,
    '        '                             UnitNo,
    '        '                             Establishment,
    '        '                             HouseNo,
    '        '                             Street,
    '        '                             Village,
    '        '                             Brgy,
    '        '                             CityMunicipality,
    '        '                             Province,
    '        '                             Area,
    '        '                             FullAddress)
    '        'A_NEW_CLIENT_DETAILS_Insert(Me,
    '        '                            ClientName,
    '        '                            Owners,
    '        '                            HomeCN,
    '        '                            OfficeCn,
    '        '                            MobileCN,
    '        '                            Email,
    '        '                            Company_Name)
    '        'A_NEW_CONTRACT_DETAILS_Insert(InsertedPD_ID, Me)
    '        'A_NEW_OWNERS_TBL_Insert(InsertedPD_ID, InsertedCustID, "Current Owner", Me)
    '        'A_NEW_CONTRACT_QUOTE_NO_Insert(InsertedC_ID, "", "", Me
    '        For i = 0 To AEICSelectedDGV.Rows.Count - 1
    '            arr_AEID.Add(AEICSelectedDGV.Rows(i).Cells("AUTONUM").Value.ToString)
    '            'A_NEW_AE_ASSIGNMENT_Insert(InsertedPD_ID, AUTONUMid, Me)
    '        Next

    '        PD_Inserts_NewProj(Source,
    '                           P1plusP2,
    '                           Competitors,
    '                           UnitNo,
    '                           Establishment,
    '                           HouseNo,
    '                           Street,
    '                           Village,
    '                           Brgy,
    '                           CityMunicipality,
    '                           Province,
    '                           Area,
    '                           FullAddress, ClientName,
    '                           Owners,
    '                           HomeCN,
    '                           OfficeCn,
    '                           MobileCN,
    '                           Email,
    '                           Company_Name)


    '    Catch ex As SqlException
    '        'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
    '        If ex.Number = -2 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Insert_BGW.CancelAsync()
    '        ElseIf ex.Number = 1232 Or ex.Number = 121 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ElseIf ex.Number = 19 Then
    '            MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 And ex.Number <> 121 Then
    '            'MetroFramework.MetroMessageBox.Show(Me, "Transaction Failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
    '            Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
    '                                       "SQL Transaction Error Number: " & ex.Number & vbCrLf &
    '                                       "SQL Transaction Error Message: " & ex.Message)
    '            Log_File.Close()
    '        End If
    '        sql_Err_msg = ex.Message
    '        sql_Err_no = ex.Number
    '        Try
    '            transaction.Rollback()
    '            sql_Transaction_result = "Rollback"
    '        Catch ex2 As Exception
    '            Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
    '            Log_File.WriteLine(vbCrLf & "Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
    '                                       "Rollback Error Message: " & ex2.Message)
    '            Log_File.Close()
    '        End Try
    '    Catch ex22 As Exception
    '        'MetroFramework.MetroMessageBox.Show(Me, ex22.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '    End Try
    'End Sub

    'Private Sub Insert_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Insert_BGW.RunWorkerCompleted
    '    Try

    '        If e.Error IsNot Nothing Then
    '            '' if BackgroundWorker terminated due to error
    '            MetroFramework.MetroMessageBox.Show(Me, "Please Restart!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        ElseIf e.Cancelled = True Then
    '            '' otherwise if it was cancelled
    '            MetroFramework.MetroMessageBox.Show(Me, "Please Restart!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            '' otherwise it completed normally
    '            If (sql_Err_no = "" Or sql_Err_no = Nothing) AndAlso
    '                   (sql_Err_msg = "" Or sql_Err_msg = Nothing) Then
    '                If sql_Transaction_result = "Committed" Then
    '                    MetroFramework.MetroMessageBox.Show(Me, "Success", " ", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '                    Reset()

    '                    BreadCrumb_Tab.Enabled = True
    '                    PrevNxt_PNL.Enabled = True
    '                    LoadingPboxRNP.Visible = False

    '                    PD_CountSuccess = 0

    '                    is_CTD_bool = False
    '                    QueryBUILD = QuerySearchHeadArrays(0) & QueryMidArrays(0) & QueryConditionArrays(0) &
    '                         " " & QueryORDERArrays(0)
    '                    SearchStr = ""
    '                    Project_Details.Start_ProjectDetailsBGW()

    '                    selecting_bool = False


    '                ElseIf sql_Transaction_result = "Rollback" Then
    '                    MetroFramework.MetroMessageBox.Show(Me, "Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                End If
    '            Else
    '                MetroFramework.MetroMessageBox.Show(Me, "Transaction failed", "Contact the Developers", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '                'Log_File = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Error_Logs.txt", True)
    '                'Log_File.WriteLine("Error logs dated " & Date.Now.ToString("dddd, MMMM dd, yyyy HH:mm:ss tt") & vbCrLf &
    '                '           "SQL Transaction Error Number: " & sql_Err_no & vbCrLf &
    '                '           "SQL Transaction Error Message: " & sql_Err_msg & vbCrLf)
    '                'Log_File.Close()

    '            End If
    '            sql_Err_msg = Nothing
    '            sql_Err_no = Nothing
    '            sql_Transaction_result = ""

    '            'Dim CountSelectedAE As Integer
    '            'CountSelectedAE = (AEICSelectedDGV.RowCount) + 5
    '            ''MsgBox("PD_CountSuccess: " & PD_CountSuccess & vbCrLf & "CountSelectedAE: " & CountSelectedAE)
    '            'If PD_CountSuccess = CountSelectedAE Then
    '            '    MetroFramework.MetroMessageBox.Show(Me, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.None)
    '            '    Reset()

    '            '    BreadCrumb_Tab.Enabled = True
    '            '    PrevNxt_PNL.Enabled = True
    '            '    LoadingPboxRNP.Visible = False

    '            '    PD_CountSuccess = 0

    '            '    is_CTD_bool = False
    '            '    QueryBUILD = QuerySearchHeadArrays(0) & QueryMidArrays(0) & QueryConditionArrays(0) &
    '            '             " " & QueryORDERArrays(0)
    '            '    SearchStr = ""
    '            '    Project_Details.Start_ProjectDetailsBGW()

    '            '    selecting_bool = False

    '            'Else
    '            '    MetroFramework.MetroMessageBox.Show(Me, ErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            'End If

    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(Me, ex.Message)
    '    End Try
    'End Sub

    Dim Proj_ClassP1, Proj_ClassP2, P1plusP2 As String

    Private Sub Competitors_Cbox_Enter(sender As Object, e As EventArgs) Handles Competitors_Cbox.Enter
        If NewProjects_BGW.IsBusy Then
            MetroFramework.MetroMessageBox.Show(Me, "Currently Loading", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub P1nP2()
        For Each radctrl1 In P1_Panel.Controls
            If TypeOf radctrl1 Is RadioButton Then
                If radctrl1.Checked = True Then
                    Proj_ClassP1 = radctrl1.Tag
                End If
            End If
        Next

        For Each radctrl2 In P2_Panel.Controls
            If TypeOf radctrl2 Is RadioButton Then
                If radctrl2.Checked = True Then
                    Proj_ClassP2 = radctrl2.Text
                End If
            End If
        Next

        P1plusP2 = Proj_ClassP1 & ", " & Proj_ClassP2
    End Sub

    Private Sub P1nP2_CheckedChanged(sender As Object, e As EventArgs) Handles NewConRBTN.CheckedChanged, RenovMajRBTN.CheckedChanged,
        RenovPartialRBTN.CheckedChanged, CommercialRBTN.CheckedChanged, CondoRBTN.CheckedChanged, HotelRBTN.CheckedChanged, MausoleumRBTN.CheckedChanged,
        ResidentialRBTN.CheckedChanged, ResortRBTN.CheckedChanged, RestaurantRBTN.CheckedChanged, ResthouseRBTN.CheckedChanged, TownhouseRBTN.CheckedChanged

        P1nP2()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        AEICListDGV.Rows.Insert(AE_Index_ToAddnDel, AE_ID_ToAddnDel, AE_Index_ToAddnDel, AE_Fullname_ToAddnDel)
        For Each row As DataGridViewRow In AEICSelectedDGV.SelectedRows
            AEICSelectedDGV.Rows.Remove(row)
        Next
    End Sub

    Private Sub AEICListDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                If e.Button = MouseButtons.Right Then
                    AEICListDGV.Rows(e.RowIndex).Selected = True
                    Dim r As New Rectangle
                    r = AEICListDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    AddToolStripMenuItem.Visible = True
                    DeleteToolStripMenuItem.Visible = False
                    Register_CMenu.Show()
                    Register_CMenu.Location = New Point(MousePosition.X, MousePosition.Y)
                End If
                AE_ID_ToAddnDel = AEICListDGV.Item("AUTONUM1", e.RowIndex).Value.ToString
                AE_Fullname_ToAddnDel = AEICListDGV.Item("FULLNAME1", e.RowIndex).Value.ToString
                AE_Index_ToAddnDel = AEICListDGV.Item("index1", e.RowIndex).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class