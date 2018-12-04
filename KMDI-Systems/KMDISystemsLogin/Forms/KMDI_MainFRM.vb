Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class KMDI_MainFRM

    Dim Tilecode As String
    Dim ToVisibleMarketingPanel As Integer = 0
    Dim ToVisibleCostingPanel As Integer = 0
    Dim ToVisibleProdPaneL As Integer = 0
    Dim ToVisibleSNOPaneL As Integer = 0
    Dim ToVisibleEngrPaneL As Integer = 0
    Public PrevDBNameCboxSelectedIndex As Integer


    Public Sub CheckCHKBOX()

        Try

            If TileAccessOfLoggedAccount <> Nothing Then
                For searchingTileAccess As Integer = 0 To TileAccessOfLoggedAccount.Length - 1 Step 3
                    Tilecode = TileAccessOfLoggedAccount.Substring(searchingTileAccess, 3)

                    Select Case Tilecode
                        Case EngrSDreq
                            EngrSDRequestTile.Visible = True
                            ToVisibleEngrPaneL = 1
                        Case DelReciepts
                            DeliveryRecieptsTile.Visible = True
                            ToVisibleEngrPaneL = 1
                        Case DR
                            DRTile.Visible = True
                            ToVisibleEngrPaneL = 1
                        Case DrReports
                            DRReportTile.Visible = True
                            ToVisibleEngrPaneL = 1
                            EngrsItineraryTIle.Visible = True
                            ToVisibleEngrPaneL = 1
                        Case EngrSDsubm
                            EngrSDSubmittalTile.Visible = True
                            ToVisibleEngrPaneL = 1

                        Case addendum
                            ProjAssignmentTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case SalesItinerary
                            SalesItineraryTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case SalesMoni
                            SalesMonitoringTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case SUS
                            SUSTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case CallerInfo
                            CallerInfoTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case Collection
                            CollectionTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case ExtDMGs
                            ExterrnalDamagesTile.Visible = True
                            ToVisibleSNOPaneL = 1
                        Case CheckBalance
                            CheckBalTile.Visible = True
                            ToVisibleSNOPaneL = 1

                        Case ProdSDreq
                            ProdSDRequestTile.Visible = True
                            ToVisibleProdPaneL = 1
                        Case CuttList
                            CuttingListTile.Visible = True
                            ToVisibleProdPaneL = 1
                        Case StatsMoni
                            StatusMonitoringTile.Visible = True
                            ToVisibleProdPaneL = 1
                        Case GlassSpecs
                            GlassSpecsTile.Visible = True
                            ToVisibleProdPaneL = 1
                        Case ProdSDSubm
                            ProdSDSubmittalTile.Visible = True
                            ToVisibleProdPaneL = 1

                        Case Request
                            MarketingRequestTile.Visible = True
                            ToVisibleMarketingPanel = 1
                        Case Inventory
                            InventoryTile.Visible = True
                            ToVisibleMarketingPanel = 1
                        Case ArchiFirm
                            ArchiFirmTile.Visible = True
                            ToVisibleMarketingPanel = 1
                        Case WinDoor
                            WinDoorMakerTile.Visible = True
                            ToVisibleCostingPanel = 1

                    End Select
                Next
            Else

                ToVisibleCostingPanel = 0
                ToVisibleEngrPaneL = 0
                ToVisibleMarketingPanel = 0
                ToVisibleProdPaneL = 0
                ToVisibleSNOPaneL = 0

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub LoggedAcctPermissions()
        Select Case AccountType
            Case "Accounting"
                MarketingRequestTile.Visible = True
                InventoryTile.Visible = True
                ArchiFirmTile.Visible = True

                ToVisibleMarketingPanel = 1
                ToVisibleCostingPanel = 1

            Case "AEIC"
                CheckBalTile.Visible = True
                SUSTile.Visible = True
                CollectionTile.Visible = True
                SalesMonitoringTile.Visible = True

                ToVisibleSNOPaneL = 1

            Case "Costing"
                WinDoorMakerTile.Visible = True

                ToVisibleMarketingPanel = 1

            Case "Cutting"
                ProdSDRequestTile.Visible = True
                ProdSDSubmittalTile.Visible = True
                CuttingListTile.Visible = True

                ToVisibleProdPaneL = 1

            Case "Delivery"
                ProdSDRequestTile.Visible = True
                ProdSDSubmittalTile.Visible = True
                GlassSpecsTile.Visible = True

                ToVisibleProdPaneL = 1

            Case "Engineering"
                DRTile.Visible = True
                EngrsItineraryTIle.Visible = True
                DRReportTile.Visible = True
                DeliveryRecieptsTile.Visible = True

                ToVisibleEngrPaneL = 1

            Case "Engr. Manager"
                DRTile.Visible = True
                EngrsItineraryTIle.Visible = True
                DRReportTile.Visible = True
                DeliveryRecieptsTile.Visible = True
                EngrSDRequestTile.Visible = True
                EngrSDSubmittalTile.Visible = True

                ToVisibleEngrPaneL = 1

            Case "Fabrication"
                ProdSDRequestTile.Visible = True
                ProdSDSubmittalTile.Visible = True
                StatusMonitoringTile.Visible = True

                ToVisibleProdPaneL = 1

            Case "Marketing"
                MarketingRequestTile.Visible = True
                InventoryTile.Visible = True
                ArchiFirmTile.Visible = True

                ToVisibleMarketingPanel = 1

            Case "Points"
                CallerInfoTile.Visible = True
                ExterrnalDamagesTile.Visible = True
                SalesItineraryTile.Visible = True
                ProjAssignmentTile.Visible = True

                ToVisibleSNOPaneL = 1

            Case "Purchasing"
                MarketingRequestTile.Visible = True
                InventoryTile.Visible = True
                ArchiFirmTile.Visible = True

                ToVisibleMarketingPanel = 1

            Case "Sales"
                CheckBalTile.Visible = True
                SUSTile.Visible = True
                CollectionTile.Visible = True
                SalesMonitoringTile.Visible = True
                CallerInfoTile.Visible = True
                ExterrnalDamagesTile.Visible = True
                SalesItineraryTile.Visible = True
                ProjAssignmentTile.Visible = True


                ToVisibleSNOPaneL = 1

            Case "SalesMartin"
                CallerInfoTile.Visible = True
                CheckBalTile.Visible = True
                SUSTile.Visible = True
                CollectionTile.Visible = True
                SalesMonitoringTile.Visible = True
                EngrSDSubmittalTile.Visible = True
                ExterrnalDamagesTile.Visible = True
                SalesItineraryTile.Visible = True
                ProjAssignmentTile.Visible = True

                ToVisibleSNOPaneL = 1
                ToVisibleEngrPaneL = 1

        End Select

        If AccountType = "Admin" Or AccountType = "Guest" Then
            EngrSDRequestTile.Visible = True
            DeliveryRecieptsTile.Visible = True
            DRTile.Visible = True
            DRReportTile.Visible = True
            EngrsItineraryTIle.Visible = True
            EngrSDSubmittalTile.Visible = True

            ProjAssignmentTile.Visible = True
            SalesItineraryTile.Visible = True
            SalesMonitoringTile.Visible = True
            SUSTile.Visible = True
            CallerInfoTile.Visible = True
            CollectionTile.Visible = True
            ExterrnalDamagesTile.Visible = True
            CheckBalTile.Visible = True

            ProdSDRequestTile.Visible = True
            CuttingListTile.Visible = True
            StatusMonitoringTile.Visible = True
            GlassSpecsTile.Visible = True
            ProdSDSubmittalTile.Visible = True

            MarketingRequestTile.Visible = True
            InventoryTile.Visible = True
            ArchiFirmTile.Visible = True
            WinDoorMakerTile.Visible = True

            MngeAccTile.Visible = True

            ToVisibleCostingPanel = 1
            ToVisibleEngrPaneL = 1
            ToVisibleMarketingPanel = 1
            ToVisibleProdPaneL = 1
            ToVisibleSNOPaneL = 1
        End If
    End Sub

    Public Sub PanelVisibility()

        If ToVisibleMarketingPanel > 0 Then
            MarketingPanel.Visible = True
        ElseIf ToVisibleMarketingPanel = 0 Then
            MarketingPanel.Visible = False
        End If

        If ToVisibleCostingPanel > 0 Then
            CostingPanel.Visible = True
        ElseIf ToVisibleCostingPanel = 0 Then
            CostingPanel.Visible = False
        End If

        If ToVisibleEngrPaneL > 0 Then
            EngrPanel.Visible = True
        ElseIf ToVisibleEngrPaneL = 0 Then
            EngrPanel.Visible = False
        End If

        If ToVisibleProdPaneL > 0 Then
            ProductionPanel.Visible = True
        ElseIf ToVisibleProdPaneL = 0 Then
            ProductionPanel.Visible = False
        End If

        If ToVisibleSNOPaneL > 0 Then
            SNOpanel.Visible = True
        ElseIf ToVisibleSNOPaneL = 0 Then
            SNOpanel.Visible = False
        End If

    End Sub

    Public Sub TileInvisibility()
        EngrSDRequestTile.Visible = False
        DeliveryRecieptsTile.Visible = False
        DRTile.Visible = False
        DRReportTile.Visible = False
        EngrsItineraryTIle.Visible = False
        EngrSDSubmittalTile.Visible = False
        ProjAssignmentTile.Visible = False
        SalesItineraryTile.Visible = False
        SalesMonitoringTile.Visible = False
        SUSTile.Visible = False
        CallerInfoTile.Visible = False
        CollectionTile.Visible = False
        ExterrnalDamagesTile.Visible = False
        CheckBalTile.Visible = False
        ProdSDRequestTile.Visible = False
        CuttingListTile.Visible = False
        StatusMonitoringTile.Visible = False
        GlassSpecsTile.Visible = False
        ProdSDSubmittalTile.Visible = False
        MarketingRequestTile.Visible = False
        InventoryTile.Visible = False
        ArchiFirmTile.Visible = False
        WinDoorMakerTile.Visible = False

        ToVisibleCostingPanel = 0
        ToVisibleEngrPaneL = 0
        ToVisibleMarketingPanel = 0
        ToVisibleProdPaneL = 0
        ToVisibleSNOPaneL = 0

    End Sub

    Private Sub KMDI_MainFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TileAccessOfLoggedAccount = Nothing
        TileInvisibility()
        KMDI_ACCT_ACCESS_TB_READ_FOR_KMDI_MainFRM(AccountAutonum)

        CheckCHKBOX()
        PanelVisibility()
        LoggedAcctPermissions()
        PanelVisibility()
        NicknameLbl.Text = "Hi I'm " & "" & nickname.ToUpper & "" & " at your Service!"
        PrevDBNameCboxSelectedIndex = DbNameCbox.SelectedIndex
        Me.Width = 800
        Me.Height = 600

    End Sub

    Private Sub MngeAccTile_Click(sender As Object, e As EventArgs) Handles MngeAccTile.Click
        ManageAccounts.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutTile_Click(sender As Object, e As EventArgs) Handles LogoutTile.Click
        Me.Close()
    End Sub

    Private Sub WinDoorMakerTile_Click(sender As Object, e As EventArgs) Handles WinDoorMakerTile.Click
        WinDoorMaker.Show()
        WinDoorMaker.BringToFront()
        WinDoorMaker.MaximizeBox = True
    End Sub

    Private Sub UpdSecTile_Click(sender As Object, e As EventArgs) Handles UpdSecTile.Click
        If Application.OpenForms().OfType(Of AccountUpdate).Any Then
            AccountUpdate.Dispose()
            AccountUpdate.Close()
            AccountUpdate.Show()
            Me.Enabled = False
        Else
            AccountUpdate.Show()
            Me.Enabled = False
        End If
    End Sub

    Private Sub ProjAssignmentTile_Click(sender As Object, e As EventArgs) Handles ProjAssignmentTile.Click
        If Application.OpenForms().OfType(Of ProjectAssignment).Any Then
            ProjectAssignment.Dispose()
        End If
        ProjectAssignment.Show()
    End Sub

    Private Sub ContractListTile_Click(sender As Object, e As EventArgs) Handles ContractListTile.Click
        If Application.OpenForms().OfType(Of Contracts).Any Then
            Contracts.Dispose()
            Contracts.Close()
            Contracts.Show()
        Else
            Contracts.Show()
        End If
    End Sub

    Private Sub RecycleTile_Click(sender As Object, e As EventArgs) Handles RecycleTile.Click
        If Application.OpenForms().OfType(Of Recycle).Any Then
            Recycle.Dispose()
            Recycle.Close()
            Recycle.Show()
        Else
            Recycle.Show()
        End If
    End Sub

    Public DBNameStr_Cbox As String
    Private Sub DbNameCbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DbNameCbox.SelectionChangeCommitted
        If ChangeDB_BGW.IsBusy <> True Then
            LoadingPBOX.Visible = True
            DBNameStr_Cbox = DbNameCbox.Text
            DBnameCboxSelectedIndex = DbNameCbox.SelectedIndex
            MainFRMBody_FLP.Enabled = False
            ChangeDB_BGW.RunWorkerAsync()
        End If
    End Sub

    Private Sub ChangeDB_BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ChangeDB_BGW.DoWork

        Try
            For i As Integer = 0 To 100
                System.Threading.Thread.Sleep(1)
                ChangeDB_BGW.ReportProgress(i)
            Next
            If DBNameStr_Cbox = Nothing Or DBNameStr_Cbox = "" Then

            Else
                KMDISystems_Login_SERVER(DBNameStr_Cbox)
                LoginType = "Relog"
                LoginModule.PrevDBnameCboxSelectedIndex = PrevDBNameCboxSelectedIndex
                KMDISystems_Login(KMDISystems_UserName,
                                  KMDISystems_Password)
            End If

        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Number <> -2 And ex.Number <> 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            End If
        Catch ex2 As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

        If ChangeDB_BGW.CancellationPending = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ChangeDB_BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ChangeDB_BGW.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                '' otherwise it completed normally
                For i = 1 To Application.OpenForms.Count - 1
                    If Not Application.OpenForms.Item(i).ToString.Contains("KMDI_MainFRM") And Not Application.OpenForms.Item(i).ToString.Contains("KMDISystemsLogin") Then
                        Application.OpenForms.Item(i).Hide()
                    End If
                Next
                MainFRMBody_FLP.Enabled = True
                LoadingPBOX.Visible = False
                KMDI_MainFRM_Load(sender, e)
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub

    Private Sub KMDI_MainFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then

            sqlConnection.Close()
            KMDISystemsLogin.UserNameTbox.Clear()
            'LoginModule.KMDISystems_UserName = Nothing
            KMDISystemsLogin.PasswordTbox.Clear()
            'LoginModule.KMDISystems_Password = Nothing
            'KMDISystemsGlobalModule.AccountAutonum = Nothing
            KMDISystemsLogin.UserNameTbox.Select()
            KMDISystemsLogin.Show()

            For Each Form In My.Application.OpenForms
                If Form.name.ToString <> "KMDISystemsLogin" Then
                    Form.hide()
                End If
            Next

            Me.Dispose()

        Else
            e.Cancel = True
        End If
    End Sub

End Class