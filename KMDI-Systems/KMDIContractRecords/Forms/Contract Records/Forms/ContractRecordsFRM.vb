Imports System.ComponentModel
Imports MetroFramework

Public Class ContractRecordsFRM
    Dim sql As New KMDIContractRecordsClass
    Public SearchString As String = Trim(SearchString)

    Public ActionTaken As String
    Public SearchItemFN As String
    Public UserAcctRestrictions As String
    Public SearchScope As String

    Dim stp_Name As String
    Public PDID As String

    Public UnitNo As String
    Public Establishment As String
    Public HouseNo As String
    Public Street As String
    Public Village As String
    Public Brgy As String
    Public CityMunicipality As String
    Public Province As String
    Public Area As String

    Public VProjectLabel As Boolean
    Public VClientsName As Boolean
    Public VCompanyName As Boolean
    Public VPrevOwner As Boolean
    Public VAEIC As Boolean
    Public VEIC As Boolean
    Public VFullAdd As Boolean
    Public VParentJONO As Boolean
    Public VUnitNoV As Boolean
    Public VEstablishment As Boolean
    Public VNo As Boolean
    Public VStreet As Boolean
    Public VVillage As Boolean
    Public VBrgy As Boolean
    Public VTown As Boolean
    Public VProvince As Boolean
    Public VArea As Boolean

    Public JobOrderNoID As String
    Public JOWithImage As Boolean
    Public JOWithItem As Boolean
    Public JOUserView As String

    Public ErrorMessage As String

    Public ContractRecordsBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub ContractRecordsGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractRecordsDGV.ColumnHeaderMouseClick
        Try
            If e.Button = MouseButtons.Right Then

                Dim frm As Form = ContractRecordsViewFRM

                With ContractRecordsViewFRM
                    .Location = New Point(MousePosition)
                    Select Case frm.Visible
                        Case True
                            .BringToFront()
                        Case False
                            .Show()
                            .BringToFront()
                            .OkBTN.Focus()
                    End Select
                End With

            ElseIf e.Button = MouseButtons.Left Then
                Grid_Display()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractRecords_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            AddHandler ContractRecordsBGW.DoWork, AddressOf ContractRecordsBGW_DoWork
            AddHandler ContractRecordsBGW.RunWorkerCompleted, AddressOf ContractRecordsBGW_RunWorkerCompleted
            ChangePBVisibility = AddressOf ChangeVisibility

            LoadInitialSetUp()

        Catch ex As Exception
            ErrorMessage = ex.ToString
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Sub LoadInitialSetUp()
        SearchString = ""
        ActionTaken = "Search"
        SearchItemFN = "InitialF2"

        StartWorker()
    End Sub

    Public Sub StartWorker()
        Try
            If ContractRecordsBGW.IsBusy <> True Then
                ContractRecordsDGV.Columns.Clear()
                ContractRecordsDGV.DataSource = Nothing
                ContractRecordsDGV.DataMember = Nothing
                ContractRecordsBGW.WorkerSupportsCancellation = True
                ContractRecordsBGW.RunWorkerAsync()
            Else
                MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ContractRecordsBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, True)
            ActionTakenByUser()

            sql.ContractRecordsLoad(ActionTaken,
                                    SearchItemFN,
                                    SearchScope,
                                    stp_Name,
                                    SearchString)
        Catch ex As Exception
            ErrorMessage = ex.ToString
            ContractRecordsBGW.WorkerSupportsCancellation = True
            ContractRecordsBGW.CancelAsync()
        End Try

        If ContractRecordsBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        stp_Name = "stp_SearchInitialF2"
                    Case "SecondF2"
                        Select Case SearchScope
                            Case "Broad"
                                stp_Name = "stp_SearchSecondF2Broad"
                            Case "Specific"
                                stp_Name = "stp_SearchSecondF2Specific"
                        End Select
                    Case "ItemSearchInitialF2"
                        stp_Name = "stp_SearchItemSearchInitialF2"
                    Case "ItemSearchSecondF2"
                        stp_Name = "stp_SearchItemSearchSecondF2"
                End Select
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Private Sub ContractRecordsBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 key to refresh the system." & vbCrLf & vbCrLf & ErrorMessage, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                End Select
            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        MetroMessageBox.Show(Me, "Please click OK button or press the Enter key then press F5 to refresh the system." & vbCrLf & vbCrLf & ErrorMessage, "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case "Add"
                    Case "Update"
                    Case "Delete"
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            If sql.ReadHasRows = True Then
                                Grid_Display()
                            Else
                                SearchFRM.Hide()
                                MetroMessageBox.Show(Me, "No items where found in the database. Please refine search.", "No results found.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                SearchFRM.Show()
                                SearchFRM.SearchTbox.Focus()
                            End If
                        Case "Add"
                        Case "Update"
                        Case "Delete"
                    End Select
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Private Sub ContractRecordsDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles ContractRecordsDGV.RowPostPaint
        Try
            'sql.RowPostPaintContractRecords(sender, e)
            rowpostpaint(sender, e)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Grid_Display()
        Try
            Select Case ActionTaken
                Case "Search"
                    Select Case SearchItemFN
                        Case "InitialF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "InitialF2"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("PD_ID").Visible = False
                                .Columns("Company Name").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                        Case "SecondF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "SecondF2"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("PD_ID").Visible = False
                                .Columns("JOB_ORDER_NO").Visible = False
                                .Columns("LOCK").Visible = False
                                .Columns("IMG").Visible = False
                                .Columns("JO#").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                            For ImageCounter As Integer = 0 To ContractRecordsDGV.Rows.Count - 1 Step +1

                                If Not ContractRecordsDGV.Rows(ImageCounter).Cells("IMG").Value = "" Then
                                    ContractRecordsDGV.Rows(ImageCounter).Cells("JO#").Style.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
                                End If

                                If ContractRecordsDGV.Rows(ImageCounter).Cells("LOCK").Value.ToString = "1" Then
                                    ContractRecordsDGV.Rows(ImageCounter).DefaultCellStyle.ForeColor = Color.Black
                                    ContractRecordsDGV.Rows(ImageCounter).DefaultCellStyle.BackColor = Color.Khaki
                                End If

                            Next

                        Case "ItemSearchInitialF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "FFabTB_Join_A2C1"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns(0).Visible = False
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                        Case "ItemSearchSecondF2"
                            With ContractRecordsDGV
                                .DataSource = sql.ds
                                .DataMember = "FFabTB_Join_A2C2"
                                .Select()
                                .DefaultCellStyle.BackColor = Color.White
                                .RowsDefaultCellStyle.Font = New Font("Segoe UI", 12.0!, FontStyle.Regular)
                                .Columns("JOB_ORDER_NO").Visible = False
                                .Columns("PARENTJONO").Visible = False
                                .Columns("UNITNO").Visible = False
                                .Columns("ESTABLISHMENT").Visible = False
                                .Columns("NO").Visible = False
                                .Columns("STREET").Visible = False
                                .Columns("VILLAGE").Visible = False
                                .Columns("BRGY_MUNICIPALITY").Visible = False
                                .Columns("TOWN_DISTRICT").Visible = False
                                .Columns("PROVINCE").Visible = False
                                .Columns("AREA").Visible = False
                                .Columns("IMG").Visible = False
                                .Columns("LOCK").Visible = False
                                .Columns("Project Label").Frozen = True
                                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                            End With

                            For ImageCounter As Integer = 0 To ContractRecordsDGV.Rows.Count - 1 Step +1
                                If Not ContractRecordsDGV.Rows(ImageCounter).Cells("IMG").Value = "" Then
                                    ContractRecordsDGV.Rows(ImageCounter).Cells("JO#").Style.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
                                End If
                            Next

                    End Select
                Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub SearchFn(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, ContractRecordsDGV.KeyDown, ContractRecordsLBL.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F2
                    Dim frm As Form = SearchFRM

                    Select Case frm.Visible
                        Case True
                            SearchFRM.BringToFront()
                        Case False
                            SearchFRM.Show()
                            SearchFRM.TopMost = True
                    End Select
                Case Keys.F5
                    Select Case SearchItemFN
                        Case "InitialF2"
                            LoadInitialSetUp()
                        Case "SecondF2"
                            StartWorker()
                        Case "ItemSearchInitialF2"
                            StartWorker()
                        Case "ItemSearchSecondF2"
                            StartWorker()
                    End Select
                Case Keys.Enter
                    Select Case SearchItemFN
                        Case "InitialF2"
                            ActionTaken = "Search"
                            SearchItemFN = "SecondF2"
                            SearchScope = "Specific"
                            SearchString = PDID
                            StartWorker()
                        Case "SecondF2"
                            OpenScannedContract()
                        Case "ItemSearchInitialF2"
                            SearchString = PDID
                            StartWorker()
                        Case "ItemSearchSecondF2"
                            SearchString = PDID
                            StartWorker()
                    End Select
                Case Keys.Back
                    LoadInitialSetUp()
                Case Keys.Escape
                    e.SuppressKeyPress = True
                    Close()
            End Select

            If e.Control And e.KeyCode = Keys.F Then
                SearchFRM.Show()
                SearchFRM.TopMost = True
            ElseIf e.Alt And e.KeyCode = Keys.A Then
                OpenAddress()
            ElseIf e.Alt And e.KeyCode = Keys.C Then
                Select Case SearchItemFN
                    Case "InitialF2"
                        ActionTaken = "Search"
                        SearchItemFN = "SecondF2"
                        SearchScope = "Specific"
                        SearchString = PDID
                        StartWorker()
                    Case "SecondF2"
                        OpenContractItems()
                    Case "ItemSearchInitialF2"
                        SearchString = PDID
                        StartWorker()
                    Case "ItemSearchSecondF2"
                        SearchString = PDID
                        StartWorker()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractRecordsDGV_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ContractRecordsDGV.RowEnter
        Try
            'SearchString = ContractRecordsDGV.Item("PD_ID", e.RowIndex).Value.ToString
            PDID = ContractRecordsDGV.Item("PD_ID", e.RowIndex).Value.ToString
            Select Case ActionTaken
                Case "Search"
                    ''For add / update of client additional info
                    'ClientBackgroundFRM.JobOrderNoID = ContractRecordsDGV.Item("PARENTJONO", e.RowIndex).Value.ToString

                    ''For update of project address
                    'UpdateProjectAddressFRM.JobOrderNoID = ContractRecordsDGV.Item("PARENTJONO", e.RowIndex).Value.ToString

                    ''For update of owner
                    'UpdateOwnerFRM.JobOrderNoID = ContractRecordsDGV.Item("PARENTJONO", e.RowIndex).Value.ToString

                    Select Case SearchItemFN
                        Case "InitialF2"
                        Case "SecondF2"

                            '// For images of contracts
                            JobOrderNoID = ContractRecordsDGV.Item("JOB_ORDER_NO", e.RowIndex).Value.ToString
                            JOUserView = ContractRecordsDGV.Item("JO#", e.RowIndex).Value.ToString

                            Select Case ContractRecordsDGV.Item("IMG", e.RowIndex).Value.ToString
                                Case "yes"
                                    JOWithImage = True
                                Case Else
                                    JOWithImage = False
                            End Select

                            Select Case ContractRecordsDGV.Item("JO#", e.RowIndex).Value.ToString
                                Case ""
                                    JOWithItem = False
                                Case Nothing
                                    JOWithItem = False
                                Case Else
                                    JOWithItem = True
                            End Select

                            If ContractRecordsDGV.Item("LOCK", e.RowIndex).Value.ToString = "1" Then
                                    'BackloadToolStripMenuItem.Visible = False
                                Else
                                    ''For adding of backloads
                                    'BackloadFrameSash.JobOrderNoID = ContractRecordsDGV.Item("JOB_ORDER_NO", e.RowIndex).Value.ToString
                                    'BackloadToolStripMenuItem.Visible = True
                                    'SearchFRM.Hide()

                                End If
                                Case "ItemSearchInitialF2"
                                Case "ItemSearchSecondF2"
                            End Select
                        Case "Add"
                Case "Update"
                Case "Delete"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContractRecordsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractRecordsDGV.CellMouseClick
        Try
            If ContractRecordsDGV.RowCount >= 0 And e.RowIndex >= 0 Then
                If e.Button = MouseButtons.Right Then
                    Select Case ActionTaken
                        Case "Search"
                            Select Case SearchItemFN
                                Case "InitialF2"
                                    ListOfView()
                                Case "SecondF2"
                                    ListOfView()
                                Case "ItemSearchInitialF2"
                                    ListOfView()
                                Case "ItemSearchSecondF2"
                                    ListOfView()
                            End Select
                            ListOfViewMenuStrip.Show()
                            ListOfViewMenuStrip.Location = New Point(MousePosition.X, MousePosition.Y)
                        Case "Add"
                        Case "Update"
                        Case "Delete"
                    End Select
                ElseIf e.Button = MouseButtons.Left Then
                    Select Case ClientBackgroundFRM.Visible
                        Case True
                            ClientBackgroundFRM.UnitNoTBOX.Text = ContractRecordsDGV.Item("UNITNO", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.EstablishmentTBOX.Text = ContractRecordsDGV.Item("ESTABLISHMENT", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.HouseNoTBOX.Text = ContractRecordsDGV.Item("NO", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.StreetTBOX.Text = ContractRecordsDGV.Item("STREET", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.VillageTBOX.Text = ContractRecordsDGV.Item("VILLAGE", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.BRGYTBOX.Text = ContractRecordsDGV.Item("BRGY_MUNICIPALITY", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.CityMunicipalityTBOX.Text = ContractRecordsDGV.Item("TOWN_DISTRICT", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.ProvinceTBOX.Text = ContractRecordsDGV.Item("PROVINCE", e.RowIndex).Value.ToString
                            ClientBackgroundFRM.AreaTBOX.Text = ContractRecordsDGV.Item("AREA", e.RowIndex).Value.ToString
                    End Select
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ContractRecordsDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ContractRecordsDGV.CellMouseDoubleClick
        If e.Button = MouseButtons.Left Then
            Try
                Select Case ActionTaken
                    Case "Search"
                        Select Case SearchItemFN
                            Case "InitialF2"
                                ActionTaken = "Search"
                                SearchItemFN = "SecondF2"
                                SearchScope = "Specific"
                                SearchString = PDID
                                StartWorker()
                            Case "SecondF2"
                                OpenScannedContract()
                            Case "ItemSearchInitialF2"
                            Case "ItemSearchSecondF2"
                        End Select
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub FrameSashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrameSashToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Frame/Sash"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "F R A M E / S A S H   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub GlassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GlassToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Glass"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "G L A S S   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub ScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScreenToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Screen"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "S C R E E N   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub InstallationMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallationMaterialToolStripMenuItem.Click
        BackloadFrameSash.TypeOfBackload = "Installation Material"
        BackloadFrameSash.Show()
        BackloadFrameSash.BackloadsLBL.Text = "I N S T A L L A T I O N   M A T E R I A L S   B A C K L O A D"
        BackloadFrameSash.BringToFront()
        BackloadFrameSash.LoadInitialSetUp()
    End Sub

    Private Sub ClientsAdditionalInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsAdditionalInfoToolStripMenuItem.Click
        ClientBackgroundFRM.Show()
        ClientBackgroundFRM.BringToFront()
        ClientBackgroundFRM.LoadInitialSetUp()
    End Sub

    Private Sub AddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddressToolStripMenuItem.Click
        OpenAddress()
    End Sub

    Public Sub OpenAddress()
        Try
            UpdateProjectAddressFRM.SearchString = PDID
            Dim frm As Form = UpdateProjectAddressFRM

            Select Case frm.Visible
                Case True
                    UpdateProjectAddressFRM.BringToFront()
                    UpdateProjectAddressFRM.LoadInitialSetUp()
                Case False
                    UpdateProjectAddressFRM.Show()
                    UpdateProjectAddressFRM.LoadInitialSetUp()
            End Select

        Catch ex As Exception
            MetroMessageBox.Show(Me, "The system has encountered an error during address retrieval. After page refresh please try again. If problem persist contact the system dev team for assistance.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub OwnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OwnerToolStripMenuItem.Click
        UpdateOwnerFRM.Show()
        UpdateOwnerFRM.BringToFront()
        UpdateOwnerFRM.NODOwnersNameTBOX.Focus()
        UpdateOwnerFRM.LoadInitialSetUp()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Try
            SearchFRM.Show()
            SearchFRM.TopMost = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        LoadInitialSetUp()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        StartWorker()
    End Sub
    Private Sub ContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractsToolStripMenuItem.Click
        Try
            Select Case SearchItemFN
                Case "InitialF2"
                    ActionTaken = "Search"
                    SearchItemFN = "SecondF2"
                    SearchScope = "Specific"
                    SearchString = PDID
                    StartWorker()
                Case "SecondF2"
                    OpenContractItems()
                Case "ItemSearchInitialF2"
                    SearchString = PDID
                    StartWorker()
                Case "ItemSearchSecondF2"
                    SearchString = PDID
                    StartWorker()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ScannedContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScannedContractsToolStripMenuItem.Click
        OpenScannedContract()
    End Sub

    Public Sub OpenScannedContract()
        Try
            Select Case JOWithImage
                Case True
                    ContractImagesFRM.SearchString = JobOrderNoID

                    Dim frm As Form = ContractImagesFRM
                    SearchFRM.Dispose()

                    Select Case frm.Visible
                        Case True
                            ContractImagesFRM.BringToFront()
                            ContractImagesFRM.LoadInitialSetUp()
                        Case Else
                            ContractImagesFRM.Show()
                    End Select

                Case False
                    MetroMessageBox.Show(Me, "Please coordinate with collections department for a copy of the contract.", "No scanned copy available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub ListOfView()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = True
                        ScannedContractsToolStripMenuItem.Visible = False
                        ContractItemsToolStripMenuItem.Visible = False

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = False

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = True

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True

                    Case "SecondF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = False
                        ScannedContractsToolStripMenuItem.Visible = True
                        ContractItemsToolStripMenuItem.Visible = True

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = True

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = False

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True

                    Case "ItemSearchInitialF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = True
                        ScannedContractsToolStripMenuItem.Visible = False
                        ContractItemsToolStripMenuItem.Visible = False

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = False

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = False

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True

                    Case "ItemSearchSecondF2"
                        '\\View
                        ViewToolStripMenuItem.Visible = True
                        ContractsToolStripMenuItem.Visible = False
                        ScannedContractsToolStripMenuItem.Visible = True
                        ContractItemsToolStripMenuItem.Visible = True

                        '\\Search
                        SearchToolStripMenuItem.Visible = True

                        '\\Refresh
                        RefreshToolStripMenuItem.Visible = True

                        '\\Reload
                        ReloadToolStripMenuItem.Visible = False

                        '\\Update
                        UpdateInfoToolStripMenuItem.Visible = True
                        AddressToolStripMenuItem.Visible = True
                        ClientsAdditionalInfoToolStripMenuItem.Visible = True
                        OwnerToolStripMenuItem.Visible = True

                        '\\Backload
                        BackloadToolStripMenuItem.Visible = True
                        FrameSashToolStripMenuItem.Visible = True
                        GlassToolStripMenuItem.Visible = True
                        ScreenToolStripMenuItem.Visible = True
                        InstallationMaterialToolStripMenuItem.Visible = True
                End Select
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Private Sub ContractRecords_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            If MetroMessageBox.Show(Me, "Do you wish to proceed?", "Contracts form closing", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                KMDI_MainFRM.Show()
                KMDI_MainFRM.BringToFront()
                SearchFRM.Dispose()
                ContractItemsFRM.Dispose()
                ContractImagesFRM.Dispose()
                ContractRecordsViewFRM.Dispose()
                Dispose()
            Else
                e.Cancel = True
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ContractItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractItemsToolStripMenuItem.Click
        OpenContractItems()
    End Sub

    Public Sub OpenContractItems()
        Try
            Select Case JOWithItem
                Case True
                    ContractItemsFRM.SearchString = JobOrderNoID
                    ContractItemsFRM.ContractRecordsLBL.Text = JOUserView

                    Dim frm As Form = ContractItemsFRM
                    SearchFRM.Dispose()

                    Select Case frm.Visible
                        Case True
                            ContractItemsFRM.BringToFront()
                            ContractItemsFRM.LoadInitialSetUp()
                        Case Else
                            ContractItemsFRM.Show()
                    End Select

                Case False
                    MetroMessageBox.Show(Me, "Please coordinate with collections department for a copy of the contract.", "No item information available", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class