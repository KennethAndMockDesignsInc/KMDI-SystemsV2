Imports System.ComponentModel
Imports MetroFramework

Public Class UpdateProjectAddressFRM
    Dim sql As New KMDIContractRecordsClass

    Public ActionTaken As String
    Public SearchString As String

    Public RequiredField As Boolean

    'Public QueryFunction As String
    'Public QueryBody As String
    'Public QueryCondition As String

    Dim stp_Name As String

    Public UpdateProjectAddressBGW As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub PBVisibilityDelegate(ByVal Visibility As Boolean)
    Dim ChangePBVisibility As PBVisibilityDelegate

    Private Sub UpdateProjectAddressFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler UpdateProjectAddressBGW.DoWork, AddressOf UpdateProjectAddressBGW_DoWork
        AddHandler UpdateProjectAddressBGW.RunWorkerCompleted, AddressOf UpdateProjectAddressBGW_RunWorkerCompleted
        ChangePBVisibility = AddressOf ChangeVisibility
    End Sub

    Public Sub ChangeVisibility(ByVal Visibility As Boolean)
        LoadingPB.Visible = Visibility
    End Sub

    Public Sub RefreshUI()
        UnitNo_TBX.Clear()
        Establishment_TBX.Clear()
        HouseNo_TBX.Clear()
        Street__Required_TBX.Clear()
        Village_TBX.Clear()
        Brgy_TBX.Clear()
        CityMunicipality__Required_TBX.Clear()
        Province__Required_TBX.Clear()
        Area__Required_CBX.SelectedIndex = -1
        FullAddress = ""
        ActionTaken = "Search"
    End Sub

    Public Sub LoadInitialSetUp()
        RefreshUI()
        ActionTaken = "Search"
        StartWorker()
    End Sub

    Public Sub ActionTakenByUser()
        Select Case ActionTaken
            Case "Search"
                stp_Name = "stp_AddressUpdateSearch"
                'QueryFunction = "SELECT [UNITNO]
                      '                 ,[ESTABLISHMENT]
                      '                 ,[NO]
                      '                 ,[STREET]
                      '                 ,[VILLAGE]
                      '                 ,[BRGY_MUNICIPALITY]
                      '                 ,[TOWN_DISTRICT]
                   '                    ,[PROVINCE]
                      '                 ,[AREA]"
                'QueryBody = " FROM [A_NEW_PROJECT_DETAILS]"
                'QueryCondition = " WHERE [PD_ID] = @SearchString"
            Case "Add"
            Case "Update"
                stp_Name = "stp_AddressUpdate"
                'QueryFunction = "UPDATE "
                'QueryBody = " [A_NEW_PROJECT_DETAILS] SET [UNITNO] = @UnitNo,
                '                                            [ESTABLISHMENT] = @Establishment,
                '                                            [NO] = @HouseNo,
                '                                            [STREET] = @Street,
                '                                            [VILLAGE] = @Village,
                '                                            [BRGY_MUNICIPALITY] = @Brgy,
                '                                            [TOWN_DISTRICT] = @CityMunicipality,
                '                                            [PROVINCE] = @Province,
                '                                            [AREA] = @Area,
                '                                            [FULLADD] = @FullAddress"
                'QueryCondition = " WHERE [PD_ID] = @SearchString"
            Case "Delete"
        End Select
    End Sub

    Public Sub StartWorker()
        If UpdateProjectAddressBGW.IsBusy <> True Then
            UpdateProjectAddressBGW.WorkerSupportsCancellation = True
            UpdateProjectAddressBGW.RunWorkerAsync()
        Else
            Select Case ActionTaken
                Case "Search"
                    MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Add"
                Case "Update"
                    MetroMessageBox.Show(Me, "System is updating its information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case "Delete"
            End Select
        End If
    End Sub

    Private Sub UpdateProjectAddressBGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        Me.Invoke(ChangePBVisibility, True)
        ActionTakenByUser()

        Try
            sql.ProjectAddress(ActionTaken,
                               stp_Name,
                               SearchString,
                               UnitNo,
                               Establishment,
                               HouseNo,
                               Street,
                               Village,
                               Brgy,
                               CityMunicipality,
                               Province,
                               Area,
                               FullAddress)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            UpdateProjectAddressBGW.WorkerSupportsCancellation = True
            UpdateProjectAddressBGW.CancelAsync()
        End Try

        If UpdateProjectAddressBGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub UpdateProjectAddressBGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            Me.Invoke(ChangePBVisibility, False)
            If e.Cancelled = True Then
                Select Case ActionTaken
                    Case "Search"
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of address information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    Case "Add"
                    Case "Update"
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of address information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    Case "Delete"
                End Select
            ElseIf e.Error IsNot Nothing Then
                Select Case ActionTaken
                    Case "Search"
                        MetroMessageBox.Show(Me, "The system has encountered an error during recovery of address information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    Case "Add"
                    Case "Update"
                        MetroMessageBox.Show(Me, "The system has encountered an error during update of address information. This page will now close to refresh database information.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.Close()
                    Case "Delete"
                End Select
            Else
                Try
                    Select Case ActionTaken
                        Case "Search"
                            If Read.HasRows = True Then
                                UI_Display()
                            Else
                                MetroMessageBox.Show(Me, "The system has encountered an error during recovery of address information. This page will now close.", "Error has been found.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Me.Close()
                            End If
                        Case "Add"
                        Case "Update"
                            If MetroMessageBox.Show(Me, "Information has been succesfully updated in the database. Do you want to close this page?", "Information has been saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                Me.Close()
                            Else
                                LoadInitialSetUp()
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
                With Read
                    .Read()
                    'UnitNo_TBX.Text = Replace(.Item("UNITNO").ToString, "`", "'")
                    'Establishment_TBX.Text = Replace(.Item("ESTABLISHMENT").ToString, "`", "'")
                    'HouseNo_TBX.Text = Replace(.Item("NO").ToString, "`", "'")
                    'Street__Required_TBX.Text = Replace(.Item("STREET").ToString, "`", "'")
                    'Village_TBX.Text = Replace(.Item("VILLAGE").ToString, "`", "'")
                    'Brgy_TBX.Text = Replace(.Item("BRGY_MUNICIPALITY").ToString, "`", "'")
                    'CityMunicipality__Required_TBX.Text = Replace(.Item("TOWN_DISTRICT").ToString, "`", "'")
                    'Province__Required_TBX.Text = Replace(.Item("PROVINCE").ToString, "`", "'")
                    'Area__Required_CBX.Text = Replace(.Item("AREA").ToString, "`", "'")
                    UnitNo_TBX.Text = .Item(0).ToString
                    Establishment_TBX.Text = .Item(1).ToString
                    HouseNo_TBX.Text = .Item(2).ToString
                    Street__Required_TBX.Text = .Item(3).ToString
                    Village_TBX.Text = .Item(4).ToString
                    Brgy_TBX.Text = .Item(5).ToString
                    CityMunicipality__Required_TBX.Text = .Item(6).ToString
                    Province__Required_TBX.Text = .Item(7).ToString
                    Area__Required_CBX.Text = .Item(8).ToString
                    .Close()
                End With
            Case "Add"
            Case "Update"
            Case "Delete"
        End Select
    End Sub

    Public Sub Format()
        UnitNo = Trim(Replace(UnitNo_TBX.Text, ",", ""))
        Establishment = Trim(Replace(Establishment_TBX.Text, ",", ""))
        HouseNo = Trim(Replace(HouseNo_TBX.Text, ",", ""))
        Street = Trim(Replace(Street__Required_TBX.Text, ",", ""))
        Village = Trim(Replace(Village_TBX.Text, ",", ""))
        Brgy = Trim(Replace(Brgy_TBX.Text, ",", ""))
        CityMunicipality = Trim(Replace(CityMunicipality__Required_TBX.Text, ",", ""))
        Province = Trim(Replace(Province__Required_TBX.Text, ",", ""))
        FullAddress = ""

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
        Area = Trim(Replace(Area__Required_CBX.Text, ",", ""))
    End Sub

    Public Sub CheckRequired()
        Try
            Select Case Street
                Case ""
                    Street__Required_TBX.UseStyleColors = True
                    Street__Required_TBX.Focus()
                    Address_TTP.Show("This fill is required.", Street__Required_TBX)
                    RequiredField = False
                    Exit Sub
                Case Nothing
                    Street__Required_TBX.UseStyleColors = True
                    Street__Required_TBX.Focus()
                    Address_TTP.Show("This fill is required.", Street__Required_TBX)
                    RequiredField = False
                    Exit Sub
            End Select

            Select Case CityMunicipality
                Case ""
                    CityMunicipality__Required_TBX.UseStyleColors = True
                    CityMunicipality__Required_TBX.Focus()
                    Address_TTP.Show("This fill is required.", CityMunicipality__Required_TBX)
                    RequiredField = False
                    Exit Sub
                Case Nothing
                    CityMunicipality__Required_TBX.UseStyleColors = True
                    CityMunicipality__Required_TBX.Focus()
                    Address_TTP.Show("This fill is required.", CityMunicipality__Required_TBX)
                    RequiredField = False
                    Exit Sub
            End Select

            Select Case Province
                Case ""
                    Province__Required_TBX.UseStyleColors = True
                    Province__Required_TBX.Focus()
                    Address_TTP.Show("This fill is required.", Province__Required_TBX)
                    RequiredField = False
                    Exit Sub
                Case Nothing
                    Province__Required_TBX.UseStyleColors = True
                    Province__Required_TBX.Focus()
                    Address_TTP.Show("This fill is required.", Province__Required_TBX)
                    RequiredField = False
                    Exit Sub
            End Select

            Select Case Area
                Case ""
                    Area__Required_CBX.UseStyleColors = True
                    Area__Required_CBX.Focus()
                    Address_TTP.Show("This fill is required.", Area__Required_CBX)
                    RequiredField = False
                    Exit Sub
                Case Nothing
                    Area__Required_CBX.UseStyleColors = True
                    Area__Required_CBX.Focus()
                    Address_TTP.Show("This fill is required.", Area__Required_CBX)
                    RequiredField = False
                    Exit Sub
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        Try
            Format()
            CheckRequired()

            Select Case RequiredField
                Case True
                    If MetroMessageBox.Show(Me, "Do you wish to proceed?", "System address update information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        ActionTaken = "Update"
                        StartWorker()
                    End If
                Case False
                    RequiredField = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateProjectAddressFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ContractRecordsFRM.BringToFront()
            ContractRecordsFRM.StartWorker()
            ContractRecordsFRM.Focus()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub KeysDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown, UnitNo_TBX.KeyDown,
                                                                                    Establishment_TBX.KeyDown, HouseNo_TBX.KeyDown,
                                                                                    Street__Required_TBX.KeyDown, Brgy_TBX.KeyDown,
                                                                                    CityMunicipality__Required_TBX.KeyDown, Province__Required_TBX.KeyDown,
                                                                                    Area__Required_CBX.KeyDown, UpdateBTN.KeyDown

        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    e.SuppressKeyPress = True
                    ContractRecordsFRM.Focus()
                Case Keys.Enter
                    e.SuppressKeyPress = True
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class