Public Class KMDI_MainFRM

    Dim Tilecode As String
    Dim ToVisibleMarketingPanel As Integer = 0
    Dim ToVisibleCostingPanel As Integer = 0
    Dim ToVisibleProdPaneL As Integer = 0
    Dim ToVisibleSNOPaneL As Integer = 0
    Dim ToVisibleEngrPaneL As Integer = 0

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
                        Case myList
                            MyListTile.Visible = True
                            ToVisibleCostingPanel = 1
                        Case Accesories
                            AccessoriesTile.Visible = True
                            ToVisibleCostingPanel = 1
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
                MyListTile.Visible = True
                AccessoriesTile.Visible = True

                ToVisibleMarketingPanel = 1
                ToVisibleCostingPanel = 1

            Case "AEIC"
                CheckBalTile.Visible = True
                SUSTile.Visible = True
                CollectionTile.Visible = True
                SalesMonitoringTile.Visible = True

                ToVisibleSNOPaneL = 1

            Case "Costing"
                MyListTile.Visible = True
                AccessoriesTile.Visible = True
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
                MyListTile.Visible = True
                AccessoriesTile.Visible = True

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
            MyListTile.Visible = True
            AccessoriesTile.Visible = True
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

    Private Sub KMDI_MainFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KMDI_ACCT_ACCESS_TB_READ_FOR_KMDI_MainFRM(AccountAutonum)

        CheckCHKBOX()
        PanelVisibility()
        LoggedAcctPermissions()
        PanelVisibility()
        NicknameLbl.Text = "Hi I'm " & """" & nickname.ToUpper & """" & " At your Service!"

    End Sub

    Private Sub MngeAccTile_Click(sender As Object, e As EventArgs) Handles MngeAccTile.Click
        ManageAccounts.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutTile_Click(sender As Object, e As EventArgs) Handles LogoutTile.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            KMDISystemsLogin.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub KMDI_MainFRM_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Me.Dispose()
    End Sub

    Private Sub ReloadMainFrm_Click(sender As Object, e As EventArgs) Handles ReloadMainFrm.Click
        For i As Integer = 0 To 100
            ReloadMainFrm.Value = i
            System.Threading.Thread.Sleep(1)
        Next
        KMDI_MainFRM_Load(sender, e)
    End Sub

    Private Sub WinDoorMakerTile_Click(sender As Object, e As EventArgs) Handles WinDoorMakerTile.Click
        WinDoorMaker.Show()
        WinDoorMaker.BringToFront()
        WinDoorMaker.MaximizeBox = True
    End Sub

    Private Sub UpdSecTile_Click(sender As Object, e As EventArgs) Handles UpdSecTile.Click
        AccountUpdate.Show()
        Me.Enabled = False
    End Sub

    Private Sub ProjAssignmentTile_Click(sender As Object, e As EventArgs) Handles ProjAssignmentTile.Click
        Me.Enabled = False
        ProjectAssignment.Show()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        NotifTile.UseCustomBackColor = True
        NotifTile.BackColor = Color.FromArgb(0, 174, 219)
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        NotifTile.UseCustomBackColor = True
        NotifTile.BackColor = Color.Goldenrod
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        NotifTile.UseCustomBackColor = True
        NotifTile.BackColor = Color.Red
    End Sub
End Class