Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class ClientBackgroundFRM
    Dim sql As New KMDIContractRecordsClass
    Public AdditionalInfo As String
    Public UnitNo As String
    Public Establishment As String
    Public HouseNo As String
    Public Street As String
    Public Village As String
    Public Brgy As String
    Public CityMunicipality As String
    Public Province As String
    Public Area As String
    Public FullAddress As String
    Public ActionTaken As String
    Public JobOrderNoID As String
    Public SearchItemFN As String

    Public QueryFunction As String
    Public QueryBody As String
    Public QueryCondition As String

    Public ClientBackgroundBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub BackloadFrameSash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler ClientBackgroundBGW.DoWork, AddressOf ClientBackgroundBGW_DoWork
        AddHandler ClientBackgroundBGW.RunWorkerCompleted, AddressOf ClientBackgroundBGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility
    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub RefreshUI()
        AdditionalInfoTBOX.Clear()
        UnitNoTBOX.Clear()
        EstablishmentTBOX.Clear()
        HouseNoTBOX.Clear()
        StreetTBOX.Clear()
        VillageTBOX.Clear()
        BRGYTBOX.Clear()
        CityMunicipalityTBOX.Clear()
        ProvinceTBOX.Clear()
        AreaTBOX.Clear()
        FullAddress = ""
    End Sub

    Public Sub LoadInitialSetUp()
        RefreshUI()
        ActionTaken = "Search"
        SearchItemFN = "InitialF2"
        AddUpdateBTN.Text = "Update"
        StartWorker()
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        QueryFunction = "Select"
                        QueryBody = " [PARENTJONO]
                                     ,[UNITNO]
                                     ,[ESTABLISHMENT]
                                     ,[NO]
                                     ,[STREET]
                                     ,[VILLAGE]
                                     ,[BRGY_MUNICIPALITY]
                                     ,[TOWN_DISTRICT]
                                     ,[PROVINCE]
                                     ,[AREA]
                                     ,[FULLADD]
                                     ,[Client Background]
                                     From [CLIENTBACKGROUND]"
                        QueryCondition = " Where [PARENTJONO] = '" & JobOrderNoID & "'"
                    Case "SecondF2"
                        QueryFunction = "Select"
                        QueryBody = " [PARENTJONO]
                                     ,[UNITNO]
                                     ,[ESTABLISHMENT]
                                     ,[NO]
                                     ,[STREET]
                                     ,[VILLAGE]
                                     ,[BRGY_MUNICIPALITY]
                                     ,[TOWN_DISTRICT]
                                     ,[PROVINCE]
                                     ,[AREA]
                                     ,[FULLADD]
                                     From [ADDENDUM_TO_CONTRACT_TB]"
                        QueryCondition = " Where [PARENTJONO] = '" & JobOrderNoID & "' and
                                                 [PARENTJONO] = [JOB_ORDER_NO]"
                End Select
            Case "Add"
                QueryFunction = "Insert into "
                QueryBody = " [CLIENTBACKGROUND] ([PARENTJONO],
                                        [UNITNO],
                                        [ESTABLISHMENT],
                                        [NO],
                                        [STREET],
                                        [VILLAGE],
                                        [BRGY_MUNICIPALITY],
                                        [TOWN_DISTRICT],
                                        [PROVINCE],
                                        [AREA],
                                        [FULLADD],
                                        [Client Background],
                                        [Inputted By])                                                   
                                 VALUES ('" & JobOrderNoID & "'," &
                                         "'" & UnitNo & "'," &
                                         "'" & Establishment & "'," &
                                         "'" & HouseNo & "'," &
                                         "'" & Street & "'," &
                                         "'" & Village & "'," &
                                         "'" & Brgy & "'," &
                                         "'" & CityMunicipality & "'," &
                                         "'" & Province & "'," &
                                         "'" & Area & "'," &
                                         "'" & FullAddress & "'," &
                                         "'" & AdditionalInfo & "', " &
                                         "'" & KMDISystemsGlobalModule.AccountAutonum & "')"
                QueryCondition = ""
            Case "Update"
                QueryFunction = "Update "
                QueryBody = " [CLIENTBACKGROUND] set [PARENTJONO] = '" & JobOrderNoID & "'," &
                                                 "[UNITNO] = '" & UnitNo & "'," &
                                                 "[ESTABLISHMENT] = '" & Establishment & "'," &
                                                 "[NO] = '" & HouseNo & "'," &
                                                 "[STREET] = '" & Street & "'," &
                                                 "[VILLAGE] = '" & Village & "'," &
                                                 "[BRGY_MUNICIPALITY] = '" & Brgy & "'," &
                                                 "[TOWN_DISTRICT] = '" & CityMunicipality & "'," &
                                                 "[PROVINCE] = '" & Province & "'," &
                                                 "[AREA] = '" & Area & "'," &
                                                 "[FULLADD] = '" & FullAddress & "'," &
                                                 "[Client Background] = '" & AdditionalInfo & "'," &
                                                 "[Updated By] = '" & KMDISystemsGlobalModule.AccountAutonum & "'"
                QueryCondition = " Where [PARENTJONO] = '" & JobOrderNoID & "'"
            Case "Delete"
        End Select
    End Sub

    Public Sub StartWorker()
        If ClientBackgroundBGW.IsBusy <> True Then
            ClientBackgroundBGW.WorkerSupportsCancellation = True
            ClientBackgroundBGW.RunWorkerAsync()
        Else
            Select Case ActionTaken
                Case "Search"
                    MetroFramework.MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Add"
                    MetroFramework.MetroMessageBox.Show(Me, "System is adding information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Update"
                    MetroFramework.MetroMessageBox.Show(Me, "System is updating its information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Delete"
            End Select
        End If
    End Sub

    Private Sub ClientBackgroundBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            'sql.ProjectInfo(QueryFunction,
            '                QueryBody,
            '                QueryCondition,
            '                ActionTaken,
            '                SearchItemFN)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            ClientBackgroundBGW.WorkerSupportsCancellation = True
            ClientBackgroundBGW.CancelAsync()
        End Try

        If ClientBackgroundBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ClientBackgroundBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Add"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error while adding information to the database. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Update"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error while updating information to the database. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Delete"
                End Select
            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Add"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error while adding information to the database. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Update"
                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error while updating information to the database. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                            Me.Hide()
                        End If
                    Case "Delete"
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            Select Case SearchItemFN
                                Case "InitialF2"
                                    If Read.HasRows = True Then
                                        UI_Display()
                                    Else
                                        SearchItemFN = "SecondF2"
                                        AddUpdateBTN.Text = "Add"
                                        StartWorker()
                                    End If
                                Case "SecondF2"
                                    If Read.HasRows = True Then
                                        UI_Display()
                                    Else
                                        If MetroFramework.MetroMessageBox.Show(Me, "System has encountered an error. Please check your connection. Do you want to close this page?", "Error has been found.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                                            Me.Hide()
                                        End If
                                    End If
                            End Select
                        Case "Add"
                            FullAddress = ""
                            If MetroFramework.MetroMessageBox.Show(Me, "Information has been succesfully added to the database. Do you want to close this page?", "Information has been saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Me.Hide()
                            Else
                                AddUpdateBTN.Text = "Update"
                            End If
                        Case "Update"
                            FullAddress = ""
                            If MetroFramework.MetroMessageBox.Show(Me, "Information has been succesfully updated in the database. Do you want to close this page?", "Information has been saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Me.Hide()
                            End If
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

    Public Sub UI_Display()
        Select Case ActionTaken
            Case "Search"
                Select Case SearchItemFN
                    Case "InitialF2"
                        With Read
                            .Read()
                            UnitNoTBOX.Text = .Item("UNITNO").ToString
                            EstablishmentTBOX.Text = .Item("ESTABLISHMENT").ToString
                            HouseNoTBOX.Text = .Item("NO").ToString
                            StreetTBOX.Text = .Item("STREET").ToString
                            VillageTBOX.Text = .Item("VILLAGE").ToString
                            BRGYTBOX.Text = .Item("BRGY_MUNICIPALITY").ToString
                            CityMunicipalityTBOX.Text = .Item("TOWN_DISTRICT").ToString
                            ProvinceTBOX.Text = .Item("PROVINCE").ToString
                            AreaTBOX.Text = .Item("AREA").ToString
                            AdditionalInfoTBOX.Text = Replace(.Item("Client Background").ToString, "`", "'")
                            .Close()
                        End With
                    Case "SecondF2"
                        With Read
                            .Read()
                            UnitNoTBOX.Text = .Item("UNITNO").ToString
                            EstablishmentTBOX.Text = .Item("ESTABLISHMENT").ToString
                            HouseNoTBOX.Text = .Item("NO").ToString
                            StreetTBOX.Text = .Item("STREET").ToString
                            VillageTBOX.Text = .Item("VILLAGE").ToString
                            BRGYTBOX.Text = .Item("BRGY_MUNICIPALITY").ToString
                            CityMunicipalityTBOX.Text = .Item("TOWN_DISTRICT").ToString
                            ProvinceTBOX.Text = .Item("PROVINCE").ToString
                            AreaTBOX.Text = .Item("AREA").ToString
                            AdditionalInfoTBOX.Text = ""
                            .Close()
                        End With
                End Select
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select


    End Sub

    Public Sub Format()
        UnitNo = Trim(Replace(Replace(UnitNoTBOX.Text, "'", "`"), ",", ""))
        Establishment = Trim(Replace(Replace(EstablishmentTBOX.Text, "'", "`"), ",", ""))
        HouseNo = Trim(Replace(Replace(HouseNoTBOX.Text, "'", "`"), ",", ""))
        Street = Trim(Replace(Replace(StreetTBOX.Text, "'", "`"), ",", ""))
        Village = Trim(Replace(Replace(VillageTBOX.Text, "'", "`"), ",", ""))
        Brgy = Trim(Replace(Replace(BRGYTBOX.Text, "'", "`"), ",", ""))
        CityMunicipality = Trim(Replace(Replace(CityMunicipalityTBOX.Text, "'", "`"), ",", ""))
        Province = Trim(Replace(Replace(ProvinceTBOX.Text, "'", "`"), ",", ""))

        Select Case UnitNo
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = UnitNo
        End Select

        Select Case Establishment
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & Establishment
        End Select

        Select Case HouseNo
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & HouseNo
        End Select

        Select Case Street
            Case ""
                FullAddress = FullAddress
            Case Else
                FullAddress = FullAddress & " " & Street
        End Select

        Select Case Village
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                FullAddress = FullAddress & " " & Village
                            Case Else
                                FullAddress = FullAddress & ", " & Village
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                FullAddress = FullAddress & " " & Village
                            Case Else
                                FullAddress = FullAddress & ", " & Village
                        End Select
                End Select
        End Select

        Select Case Brgy
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & " " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & ", " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & " " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        FullAddress = FullAddress & ", " & Brgy
                                    Case Else
                                        FullAddress = FullAddress & ", " & Brgy
                                End Select
                        End Select
                End Select
        End Select

        Select Case CityMunicipality
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & " " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & " " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                            Case Else
                                                FullAddress = FullAddress & ", " & CityMunicipality
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        Select Case Province
            Case ""
                FullAddress = FullAddress
            Case Else
                Select Case HouseNo
                    Case ""
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & " " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                        End Select
                    Case Else
                        Select Case Street
                            Case ""
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & " " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                            Case Else
                                Select Case Village
                                    Case ""
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                    Case Else
                                        Select Case Brgy
                                            Case ""
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                            Case Else
                                                Select Case CityMunicipality
                                                    Case ""
                                                        FullAddress = FullAddress & ", " & Province
                                                    Case Else
                                                        FullAddress = FullAddress & ", " & Province
                                                End Select
                                        End Select
                                End Select
                        End Select
                End Select
        End Select

        FullAddress = Trim(FullAddress)
        Area = Trim(Replace(AreaTBOX.Text, ",", ""))

        AdditionalInfo = Trim(Replace(AdditionalInfoTBOX.Text, "'", "`"))
    End Sub

    Private Sub AddUpdateBTN_Click(sender As Object, e As EventArgs) Handles AddUpdateBTN.Click
        Try
            ActionTaken = AddUpdateBTN.Text
            Format()
            MessageBox.Show(FullAddress)
            'StartWorker()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub RefreshBTN_Click(sender As Object, e As EventArgs) Handles RefreshBTN.Click
        RefreshUI()
    End Sub

    Private Sub ClientBackgroundFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            ContractRecordsFRM.Focus()
        End If
    End Sub

    Private Sub ClientBackgroundFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
        ContractRecordsFRM.Focus()
    End Sub
End Class