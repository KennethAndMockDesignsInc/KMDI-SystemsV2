Imports System.ComponentModel
Public Class ProjectAssignment

    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangeVisibility As PBVisibilityDelegate


    Public Delegate Sub ArchDesignPBVisibilityDelegate(ByVal ArchDesignVisibility As Boolean)
    Dim ArchDesignChangeVisibility As ArchDesignPBVisibilityDelegate

    Dim BGWReported As Boolean = True   'Flag to check progress report completed or not
    Public SearchPATboxString As String = ""
    Public SearchADTboxString As String = ""

    Sub StartLoadProjAssignDGV_BGW()
        If LoadProjAssignDGV_BGW.IsBusy <> True Then
            ProjAssignDGV.Columns.Clear()
            ProjAssignDGV.DataSource = Nothing
            ProjAssignDGV.DataMember = Nothing
            LoadProjAssignDGV_BGW.RunWorkerAsync()
        End If
    End Sub
    Sub StartLoadArchDesignDGV_BGW()
        If LoadArchDesignDGV_BGW.IsBusy <> True Then
            ArchDesignDGV.Columns.Clear()
            ArchDesignDGV.DataSource = Nothing
            ArchDesignDGV.DataMember = Nothing
            LoadArchDesignDGV_BGW.RunWorkerAsync()
        End If
    End Sub

    Public Sub ArchLoadingPbox_LBL_VISIBILITY(ByVal ArchDesignVisibility As Boolean)
        ArchLoadingPbox.Enabled = ArchDesignVisibility
        ArchLoadingPbox.Visible = ArchDesignVisibility
        ArchLoadingLBL.Visible = ArchDesignVisibility
    End Sub

    Public Sub LoadingPBOX_LBL_VISIBILITY(ByVal Visibility As Boolean)
        LoadingPBOX.Enabled = Visibility
        LoadingPBOX.Visible = Visibility
        LoadingLBL.Visible = Visibility
    End Sub
    Private Sub ProjectAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 800
        Me.Height = 600
        Populate_AEAssignedCBox()
        '' call this method to start your asynchronous Task.
        ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
        StartLoadProjAssignDGV_BGW()

        ArchDesignChangeVisibility = AddressOf ArchLoadingPbox_LBL_VISIBILITY
        StartLoadArchDesignDGV_BGW()
    End Sub

    Public ColumnToInvi As Integer = 0
    Private Sub LoadProjAssignDGV_BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles LoadProjAssignDGV_BGW.DoWork
        Me.Invoke(ChangeVisibility, True)

        Try
            SearchORLoadProjAssignDGV(SearchPATboxString)
            For ColumnToInvi = -1 To sqlDataSet.Tables("PROJ_ASSIGN").Columns.Count - 5
                If LoadProjAssignDGV_BGW.CancellationPending Then
                    'LoadProjAssignDGV_BGW.ReportProgress(ColumnToInvi)
                    Exit For
                    e.Cancel = True
                Else
                    While Not BGWReported
                        Application.DoEvents()
                    End While

                    'Add some sleep to simulate a long running operation
                    Threading.Thread.Sleep(10)

                    BGWReported = False
                End If
                LoadProjAssignDGV_BGW.ReportProgress(ColumnToInvi)
            Next
        Catch ex As Exception
            LoadProjAssignDGV_BGW.CancelAsync()
            MsgBox(ex.ToString)
        Finally
            sqlConnection.Close()
        End Try

        If LoadProjAssignDGV_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadArchDesignDGV_BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles LoadArchDesignDGV_BGW.DoWork
        Me.Invoke(ArchDesignChangeVisibility, True)
        Try
            SearchORLoadArchDesignDGV(SearchADTboxString)
        Catch ex As Exception
            LoadArchDesignDGV_BGW.CancelAsync()
            MsgBox(ex.ToString)
        Finally
            archsqlConnection.Close()
        End Try

        If LoadArchDesignDGV_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadProjAssignDGV_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles LoadProjAssignDGV_BGW.RunWorkerCompleted
        Try


            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                LoadingPBOX.Enabled = False
                LoadingLBL.Text = "Error Occured"
            ElseIf e.Cancelled Then
                '' otherwise if it was cancelled
                LoadingPBOX.Enabled = False
                LoadingLBL.Text = "An error occured"
            Else
                '' otherwise it completed normally

                If ProjAssignDGV.Columns("CLIENTS NAME").Visible = True AndAlso
                   ProjAssignDGV.Columns("CLIENTS ADDRESS").Visible = True AndAlso
                   ProjAssignDGV.Columns("COMPANY NAME").Visible = True Then
                    With ProjAssignDGV
                        .DataSource = sqlBindingSource
                        .DefaultCellStyle.BackColor = Color.White
                        .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                        .Visible = True
                    End With

                    Me.Invoke(ChangeVisibility, False)
                Else
                    LoadingPBOX.Enabled = False
                    LoadingLBL.Text = "An error occured"
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadArchDesignDGV_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles LoadArchDesignDGV_BGW.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                ArchLoadingPbox.Enabled = False
                ArchLoadingLBL.Text = "Error Occured"
            ElseIf e.Cancelled Then
                '' otherwise if it was cancelled
                ArchLoadingPbox.Enabled = False
                ArchLoadingLBL.Text = "An error occured"
            Else
                '' otherwise it completed normally

                With ArchDesignDGV
                    .DataSource = archsqlBindingSource
                    .Columns(0).Visible = False
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .Visible = True
                End With

                Me.Invoke(ArchDesignChangeVisibility, False)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProjAssignDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ProjAssignDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub LoadProjAssignDGV_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles LoadProjAssignDGV_BGW.ProgressChanged
        Try
            If ProjAssignDGV.DataSource Is Nothing Then
                ProjAssignDGV.DataSource = sqlBindingSource
            End If

            ProjAssignDGV.Columns(ColumnToInvi).Visible = False
            BGWReported = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ProjectAssignment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If LoadProjAssignDGV_BGW.IsBusy Or LoadArchDesignDGV_BGW.IsBusy Then
            MetroFramework.MetroMessageBox.Show(Me, "Currently loading, Please wait!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        Else
            If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub SearchPATbox_ButtonClick(sender As Object, e As EventArgs) Handles SearchPATbox.ButtonClick
        ProjAssignDGV.Visible = False
        ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
        StartLoadProjAssignDGV_BGW()
    End Sub

    Private Sub SearchPATbox_TextChanged(sender As Object, e As EventArgs) Handles SearchPATbox.TextChanged
        SearchPATboxString = SearchPATbox.Text
    End Sub

    Private Sub SearchPATbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchPATbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ProjAssignDGV.Visible = False
            ChangeVisibility = AddressOf LoadingPBOX_LBL_VISIBILITY
            StartLoadProjAssignDGV_BGW()
        End If
    End Sub

    Private Sub SearchArch_TextChanged(sender As Object, e As EventArgs) Handles SearchArch.TextChanged
        SearchADTboxString = SearchArch.Text
    End Sub

    Private Sub ArchDesignDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ArchDesignDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub SearchArch_ButtonClick(sender As Object, e As EventArgs) Handles SearchArch.ButtonClick
        ArchDesignDGV.Visible = False
        ArchDesignChangeVisibility = AddressOf ArchLoadingPbox_LBL_VISIBILITY
        StartLoadArchDesignDGV_BGW()
    End Sub

    Private Sub SearchArch_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchArch.KeyDown
        If e.KeyCode = Keys.Enter Then
            ArchDesignDGV.Visible = False
            ArchDesignChangeVisibility = AddressOf ArchLoadingPbox_LBL_VISIBILITY
            StartLoadArchDesignDGV_BGW()
        End If
    End Sub

    Dim PA_AUTONUMBER, SOURCE, REFFERED_BY, CLIENTS_NAME, CLIENTS_CONTACT_NO, CLIENTS_CONTACT_NO_OFFICE, CLIENTS_CONTACT_NO_MOBILE,
        CLIENTS_EMAIL_ADD, UNIT_NO, ESTABLISHMENT, HOUSE_NO, STREET, VILLAGE, BARANGAY, TOWN, PROVINCE, AREA, CLIENTS_ADDRESS, PROJECT_STATUS,
        PRESENTATION, SITE_MEETINGS, ARCHITECTURAL_DISCUSSIONS, SUBMITTAL_REVISION_OF_QUOTES, TRIAL_CLOSING, CLOSING_NEGOTIATION, CLOSED_PA, CLOSED_OPTION,
        CLOSED_FULL_PARTIAL, AE_ASSIGNED_CODE, COMPETITORS, COMPANY_NAME, QUOTE_NO, QUOTE_DATE, CUST_REF_NO, PROFILE_FINISH, PROJECT_CLASSIFICATION, CONSTRUCTION_STAGE,
        SITE_MEETING_SCHEDULE, WIP As String

    Private Sub RenovRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles RenovRBTN.CheckedChanged
        If RenovRBTN.Checked = True Then
            Renov_PNL.Visible = True
        Else
            Renov_PNL.Visible = False
        End If
    End Sub

    Private Sub NewConRBTN_CheckedChanged(sender As Object, e As EventArgs) Handles NewConRBTN.CheckedChanged
        If NewConRBTN.Checked = True Then
            Renov_PNL.Visible = False
        Else
            Renov_PNL.Visible = True
        End If
    End Sub

    Private Sub ProjAssignDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProjAssignDGV.CellClick
        If ProjAssignDGV.RowCount >= 0 And e.RowIndex >= 0 Then
            PA_AUTONUMBER = ProjAssignDGV.Item("PA_AUTONUMBER", e.RowIndex).Value.ToString
            SOURCE = ProjAssignDGV.Item("SOURCE", e.RowIndex).Value.ToString
            REFFERED_BY = ProjAssignDGV.Item("REFFERED_BY", e.RowIndex).Value.ToString
            CLIENTS_NAME = ProjAssignDGV.Item("CLIENTS NAME", e.RowIndex).Value.ToString
            CLIENTS_CONTACT_NO = ProjAssignDGV.Item("CLIENTS_CONTACT_NO", e.RowIndex).Value.ToString
            CLIENTS_CONTACT_NO_OFFICE = ProjAssignDGV.Item("CLIENTS_CONTACT_NO_OFFICE", e.RowIndex).Value.ToString
            CLIENTS_CONTACT_NO_MOBILE = ProjAssignDGV.Item("CLIENTS_CONTACT_NO_MOBILE", e.RowIndex).Value.ToString
            CLIENTS_EMAIL_ADD = ProjAssignDGV.Item("CLIENTS_EMAIL_ADD", e.RowIndex).Value.ToString
            UNIT_NO = ProjAssignDGV.Item("UNIT_NO", e.RowIndex).Value.ToString
            ESTABLISHMENT = ProjAssignDGV.Item("ESTABLISHMENT", e.RowIndex).Value.ToString
            HOUSE_NO = ProjAssignDGV.Item("HOUSE_NO", e.RowIndex).Value.ToString
            STREET = ProjAssignDGV.Item("STREET", e.RowIndex).Value.ToString
            VILLAGE = ProjAssignDGV.Item("VILLAGE", e.RowIndex).Value.ToString
            BARANGAY = ProjAssignDGV.Item("BARANGAY", e.RowIndex).Value.ToString
            TOWN = ProjAssignDGV.Item("TOWN", e.RowIndex).Value.ToString
            PROVINCE = ProjAssignDGV.Item("PROVINCE", e.RowIndex).Value.ToString
            AREA = ProjAssignDGV.Item("AREA", e.RowIndex).Value.ToString
            CLIENTS_ADDRESS = ProjAssignDGV.Item("CLIENTS ADDRESS", e.RowIndex).Value.ToString
            PROJECT_STATUS = ProjAssignDGV.Item("PROJECT_STATUS", e.RowIndex).Value.ToString
            PRESENTATION = ProjAssignDGV.Item("PRESENTATION", e.RowIndex).Value.ToString
            SITE_MEETINGS = ProjAssignDGV.Item("SITE_MEETINGS", e.RowIndex).Value.ToString
            ARCHITECTURAL_DISCUSSIONS = ProjAssignDGV.Item("ARCHITECTURAL_DISCUSSIONS", e.RowIndex).Value.ToString
            SUBMITTAL_REVISION_OF_QUOTES = ProjAssignDGV.Item("SUBMITTAL_REVISION_OF_QUOTES", e.RowIndex).Value.ToString
            TRIAL_CLOSING = ProjAssignDGV.Item("TRIAL_CLOSING", e.RowIndex).Value.ToString
            CLOSING_NEGOTIATION = ProjAssignDGV.Item("CLOSING_NEGOTIATION", e.RowIndex).Value.ToString
            CLOSED_PA = ProjAssignDGV.Item("CLOSED", e.RowIndex).Value.ToString
            CLOSED_OPTION = ProjAssignDGV.Item("CLOSED_OPTION", e.RowIndex).Value.ToString
            CLOSED_FULL_PARTIAL = ProjAssignDGV.Item("CLOSED_FULL_PARTIAL", e.RowIndex).Value.ToString
            'AE_ASSIGNED_CODE = ProjAssignDGV.Item("AE_ASSIGNED_CODE", e.RowIndex).Value.ToString
            COMPETITORS = ProjAssignDGV.Item("COMPETITORS", e.RowIndex).Value.ToString
            COMPANY_NAME = ProjAssignDGV.Item("COMPANY NAME", e.RowIndex).Value.ToString
            QUOTE_NO = ProjAssignDGV.Item("QUOTE_NO", e.RowIndex).Value.ToString
            QUOTE_DATE = ProjAssignDGV.Item("QUOTE_DATE", e.RowIndex).Value.ToString
            CUST_REF_NO = ProjAssignDGV.Item("CUST_REF_NO", e.RowIndex).Value.ToString
            PROFILE_FINISH = ProjAssignDGV.Item("PROFILE_FINISH", e.RowIndex).Value.ToString
            PROJECT_CLASSIFICATION = ProjAssignDGV.Item("PROJECT_CLASSIFICATION", e.RowIndex).Value.ToString
            CONSTRUCTION_STAGE = ProjAssignDGV.Item("CONSTRUCTION_STAGE", e.RowIndex).Value.ToString
            SITE_MEETING_SCHEDULE = ProjAssignDGV.Item("SITE_MEETING_SCHEDULE", e.RowIndex).Value.ToString
            WIP = ProjAssignDGV.Item("WIP", e.RowIndex).Value.ToString

            SourceCbox.Text = SOURCE
            RefferedByTbox.Text = REFFERED_BY
            CustNameTbox.Text = CLIENTS_NAME
            ClientsNameLbl.Text = CLIENTS_NAME
            CompanyNameTbox.Text = COMPANY_NAME
            CompanyNameLbl.Text = COMPANY_NAME
            ClientsContactNoTbox.Text = CLIENTS_CONTACT_NO
            ClientsContactNoOfficeTbox.Text = CLIENTS_CONTACT_NO_OFFICE
            ClientsContactNoMobileTbox.Text = CLIENTS_CONTACT_NO_MOBILE
            ClientsEmailAddTbox.Text = CLIENTS_EMAIL_ADD
            UnitNoTbox.Text = UNIT_NO
            EstablishmentTbox.Text = ESTABLISHMENT
            HouseNoTbox.Text = HOUSE_NO
            StreetTbox.Text = STREET
            VillageTbox.Text = VILLAGE
            BrgyTbox.Text = BARANGAY
            TownTbox.Text = TOWN
            ProvinceTbox.Text = PROVINCE
            AreaCbox.Text = AREA
            Competitors_Tbox.Text = COMPETITORS
            CustRefNo_Tbox.Text = CUST_REF_NO
            ConstructionStageTbox.Text = CONSTRUCTION_STAGE
            SiteMeetingScheduleTbox.Text = SITE_MEETING_SCHEDULE

            GetAE_ASSIGNED()
            ProjStatsLbl.Text = PROJECT_STATUS
            Select Case PROJECT_STATUS
                Case "Presentation"
                    PresentationRBtn.Checked = True
                    ProjStatsTbox.Text = PRESENTATION
                Case "Site Meetings"
                    SiteMeetingRBtn.Checked = True
                    ProjStatsTbox.Text = SITE_MEETINGS
                Case "Architectural Discussions"
                    ArchDisRBTN.Checked = True
                    ProjStatsTbox.Text = ARCHITECTURAL_DISCUSSIONS
                Case "Submittal/Revision of Quotes"
                    SubmitRevQuotesRBTN.Checked = True
                    ProjStatsTbox.Text = SUBMITTAL_REVISION_OF_QUOTES
                Case "Trial Closing"
                    TrialClosingRBtn.Checked = True
                    ProjStatsTbox.Text = TRIAL_CLOSING
                Case "Closing Negotiation"
                    ClosingRBtn.Checked = True
                    ProjStatsTbox.Text = CLOSING_NEGOTIATION
                Case "Closed"
                    ClosedRBTN.Checked = True
                    ProjStatsTbox.Text = CLOSED_PA
                    If CLOSED_OPTION = "Yes" Then
                        Closed_PNL.Visible = True
                        If CLOSED_FULL_PARTIAL = "Full" Then
                            ClosedFull_RBtn.Checked = True
                        ElseIf CLOSED_FULL_PARTIAL = "Partial" Then
                            ClosedPartial_RBtn.Checked = True
                        End If
                    Else
                        Closed_PNL.Visible = False
                    End If
                Case "Work in progress"
                    WIPRBtn.Checked = True
                    ProjStatsTbox.Text = WIP
            End Select

            If PROJECT_STATUS <> "Closed" Then
                Closed_PNL.Visible = False
            End If
        End If
    End Sub

    Sub GetAE_ASSIGNED()
        Try

            Dim loopnum As Integer = 0

            AES_AssignedTBox.Clear()

            SearchAE_AssignedCode(PA_AUTONUMBER)

            Dim sqldsrowCount As Integer = sqlDataSet.Tables("AE_ASSIGNED").Rows.Count

            For Each row As DataRow In sqlDataSet.Tables("AE_ASSIGNED").Rows
                loopnum += 1
                Dim AE_ASSIGNED_CODE As String = row.Item(0)
                SearchAE_AssignedFULLNAME(AE_ASSIGNED_CODE)

                If sqldsrowCount > 1 Then
                    If loopnum < sqldsrowCount Then
                        AES_AssignedTBox.Text += AE_ASSIGNED_FULLNAME + " & "
                    ElseIf loopnum = sqldsrowCount Then
                        AES_AssignedTBox.Text += AE_ASSIGNED_FULLNAME
                    End If
                Else
                    AES_AssignedTBox.Text = AE_ASSIGNED_FULLNAME
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class