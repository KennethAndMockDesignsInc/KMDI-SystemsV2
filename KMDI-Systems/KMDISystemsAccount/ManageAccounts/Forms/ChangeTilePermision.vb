Public Class ChangeTilePermision
    Public tileAccess, AddedAccess, RemovedTileAccess As String

    Public indexofTileAccessCodes As Integer
    Dim containsTIleCode As Boolean

    Dim accounttypehere As String = ManageAccounts.userAccess

    Public Sub CheckCHKBOX()

        Try
            Dim Tilecode As String

            If tileAccess <> Nothing Then
                For searchingTileAccess As Integer = 0 To tileAccess.Length - 1 Step 3
                    Tilecode = tileAccess.Substring(searchingTileAccess, 3)

                    Select Case Tilecode
                        Case EngrSDreq
                            EngrSDRequestChk.CheckState = CheckState.Checked
                        Case DelReciepts
                            DeliveryRecieptsChk.CheckState = CheckState.Checked
                        Case DR
                            DRChk.CheckState = CheckState.Checked
                        Case DrReports
                            DRReportChk.CheckState = CheckState.Checked
                        Case EngrsItinerary
                            EngrsItineraryChk.CheckState = CheckState.Checked
                        Case EngrSDsubm
                            EngrSDSubmittalChk.CheckState = CheckState.Checked

                        Case addendum
                            AddendumChk.CheckState = CheckState.Checked
                        Case SalesItinerary
                            SalesITChk.CheckState = CheckState.Checked
                        Case SalesMoni
                            SalesMonitoringChk.CheckState = CheckState.Checked
                        Case SUS
                            SUSChk.CheckState = CheckState.Checked
                        Case CallerInfo
                            CallerInfoChk.CheckState = CheckState.Checked
                        Case Collection
                            CollectionChk.CheckState = CheckState.Checked
                        Case ExtDMGs
                            ExtDmgsChk.CheckState = CheckState.Checked
                        Case CheckBalance
                            ChkBalanaceCHK.CheckState = CheckState.Checked

                        Case ProdSDreq
                            ProdSDRequestChk.CheckState = CheckState.Checked
                        Case CuttList
                            CuttingListChk.CheckState = CheckState.Checked
                        Case StatsMoni
                            StatusMonitoringChk.CheckState = CheckState.Checked
                        Case GlassSpecs
                            GlassSpecsChk.CheckState = CheckState.Checked
                        Case ProdSDSubm
                            ProdSDSubmittalChk.CheckState = CheckState.Checked

                        Case ArchiFirm
                            ArchFirmChk.CheckState = CheckState.Checked
                        Case Inventory
                            InventoryChk.CheckState = CheckState.Checked
                        Case Request
                            RequestChk.CheckState = CheckState.Checked

                        Case WinDoor
                            WinDoorChk.CheckState = CheckState.Checked
                    End Select
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub LoggedAcctPermissions()
        Select Case accounttypehere
            Case "Accounting"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked

                RequestChk.Enabled = False
                InventoryChk.Enabled = False
                ArchFirmChk.Enabled = False

            Case "AEIC"
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked

                ChkBalanaceCHK.Enabled = False
                SUSChk.Enabled = False
                CollectionChk.Enabled = False
                SalesMonitoringChk.Enabled = False

            Case "Costing"
                WinDoorChk.CheckState = CheckState.Checked

                WinDoorChk.Enabled = False

            Case "Cutting"
                ProdSDRequestChk.CheckState = CheckState.Checked
                ProdSDSubmittalChk.CheckState = CheckState.Checked
                CuttingListChk.CheckState = CheckState.Checked

                ProdSDRequestChk.Enabled = False
                ProdSDSubmittalChk.Enabled = False
                CuttingListChk.Enabled = False

            Case "Delivery"
                ProdSDRequestChk.CheckState = CheckState.Checked
                ProdSDSubmittalChk.CheckState = CheckState.Checked
                GlassSpecsChk.CheckState = CheckState.Checked

                ProdSDRequestChk.Enabled = False
                ProdSDSubmittalChk.Enabled = False
                GlassSpecsChk.Enabled = False

            Case "Engineering"
                DRChk.CheckState = CheckState.Checked
                EngrsItineraryChk.CheckState = CheckState.Checked
                DRReportChk.CheckState = CheckState.Checked
                DeliveryRecieptsChk.CheckState = CheckState.Checked

                DRChk.Enabled = False
                EngrsItineraryChk.Enabled = False
                DRReportChk.Enabled = False
                DeliveryRecieptsChk.Enabled = False

            Case "Engr. Manager"
                DRChk.CheckState = CheckState.Checked
                EngrsItineraryChk.CheckState = CheckState.Checked
                DRReportChk.CheckState = CheckState.Checked
                DeliveryRecieptsChk.CheckState = CheckState.Checked
                EngrSDRequestChk.CheckState = CheckState.Checked
                EngrSDSubmittalChk.CheckState = CheckState.Checked

                DRChk.Enabled = False
                EngrsItineraryChk.Enabled = False
                DRReportChk.Enabled = False
                DeliveryRecieptsChk.Enabled = False
                EngrSDRequestChk.Enabled = False
                EngrSDSubmittalChk.Enabled = False

            Case "Fabrication"
                ProdSDRequestChk.CheckState = CheckState.Checked
                ProdSDSubmittalChk.CheckState = CheckState.Checked
                StatusMonitoringChk.CheckState = CheckState.Checked

                ProdSDRequestChk.Enabled = False
                ProdSDSubmittalChk.Enabled = False
                StatusMonitoringChk.Enabled = False

            Case "Marketing"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked

                RequestChk.Enabled = False
                InventoryChk.Enabled = False
                ArchFirmChk.Enabled = False

            Case "Points"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked

                CallerInfoChk.Enabled = False
                ExtDmgsChk.Enabled = False
                SalesITChk.Enabled = False
                AddendumChk.Enabled = False

            Case "Purchasing"
                RequestChk.CheckState = CheckState.Checked
                InventoryChk.CheckState = CheckState.Checked
                ArchFirmChk.CheckState = CheckState.Checked

                RequestChk.Enabled = False
                InventoryChk.Enabled = False
                ArchFirmChk.Enabled = False

            Case "Sales"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked

                CallerInfoChk.Enabled = False
                ExtDmgsChk.Enabled = False
                SalesITChk.Enabled = False
                AddendumChk.Enabled = False
                ChkBalanaceCHK.Enabled = False
                SUSChk.Enabled = False
                CollectionChk.Enabled = False
                SalesMonitoringChk.Enabled = False

            Case "SalesMartin"
                CallerInfoChk.CheckState = CheckState.Checked
                ExtDmgsChk.CheckState = CheckState.Checked
                SalesITChk.CheckState = CheckState.Checked
                AddendumChk.CheckState = CheckState.Checked
                ChkBalanaceCHK.CheckState = CheckState.Checked
                SUSChk.CheckState = CheckState.Checked
                CollectionChk.CheckState = CheckState.Checked
                SalesMonitoringChk.CheckState = CheckState.Checked
                EngrSDSubmittalChk.CheckState = CheckState.Checked

                CallerInfoChk.Enabled = False
                ExtDmgsChk.Enabled = False
                SalesITChk.Enabled = False
                AddendumChk.Enabled = False
                ChkBalanaceCHK.Enabled = False
                SUSChk.Enabled = False
                CollectionChk.Enabled = False
                SalesMonitoringChk.Enabled = False
                EngrSDSubmittalChk.Enabled = False

            Case "Admin"

            Case "Guest"


        End Select
    End Sub

    Private Sub ChangeTilePermision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddedAccess = ""
        RemovedTileAccess = ""
        KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeTilePermision(ManageAccounts.UsersAutonum)

        LoggedAcctPermissions()
        CheckCHKBOX()
        PwdDecryptTbox.Text = ManageAccounts.password_ManageAccounts
    End Sub

    Private Sub ChangeTilePermision_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ManageAccounts.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub EngrSDRequestChk_Click(sender As Object, e As EventArgs) Handles EngrSDRequestChk.Click
        If EngrSDRequestChk.Checked = False Then

            RemovedTileAccess += EngrSDreq

            containsTIleCode = AddedAccess.Contains(EngrSDreq)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(EngrSDreq)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += EngrSDreq
            Else
                If tileAccess.Contains(EngrSDreq) = False Then
                    AddedAccess += EngrSDreq
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(EngrSDreq)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrSDreq)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub DeliveryRecieptsChk_Click(sender As Object, e As EventArgs) Handles DeliveryRecieptsChk.Click
        If DeliveryRecieptsChk.Checked = False Then
            RemovedTileAccess += DelReciepts
            containsTIleCode = AddedAccess.Contains(DelReciepts)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(DelReciepts)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += DelReciepts
            Else
                If tileAccess.Contains(DelReciepts) = False Then
                    AddedAccess += DelReciepts
                End If
            End If
            containsTIleCode = RemovedTileAccess.Contains(DelReciepts)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(DelReciepts)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub DRChk_Click(sender As Object, e As EventArgs) Handles DRChk.Click
        If DRChk.Checked = False Then
            RemovedTileAccess += DR
            containsTIleCode = AddedAccess.Contains(DR)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(DR)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += DR
            Else
                If tileAccess.Contains(DR) = False Then
                    AddedAccess += DR
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(DR)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(DR)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If


    End Sub

    Private Sub DRReportChk_Click(sender As Object, e As EventArgs) Handles DRReportChk.Click
        If DRReportChk.Checked = False Then
            RemovedTileAccess += DrReports
            containsTIleCode = AddedAccess.Contains(DrReports)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(DrReports)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += DrReports
            Else
                If tileAccess.Contains(DrReports) = False Then
                    AddedAccess += DrReports
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(DrReports)
                Select Case containsTIleCode
                    Case True
                        indexofTileAccessCodes = RemovedTileAccess.IndexOf(DrReports)
                        RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

                End Select

            End If

    End Sub

    Private Sub EngrsItineraryChk_Click(sender As Object, e As EventArgs) Handles EngrsItineraryChk.Click
        If EngrsItineraryChk.Checked = False Then
            RemovedTileAccess += EngrsItinerary
            containsTIleCode = AddedAccess.Contains(EngrsItinerary)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(EngrsItinerary)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += EngrsItinerary
            Else
                If tileAccess.Contains(EngrsItinerary) = False Then
                    AddedAccess += EngrsItinerary
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(EngrsItinerary)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrsItinerary)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub EngrSDSubmittalChk_Click(sender As Object, e As EventArgs) Handles EngrSDSubmittalChk.Click
        If EngrSDSubmittalChk.Checked = False Then
            RemovedTileAccess += EngrSDsubm
            containsTIleCode = AddedAccess.Contains(EngrSDsubm)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(EngrSDsubm)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += EngrSDsubm
            Else
                If tileAccess.Contains(EngrSDsubm) = False Then
                    AddedAccess += EngrSDsubm
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(EngrSDsubm)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(EngrSDsubm)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub AddendumChk_Click(sender As Object, e As EventArgs) Handles AddendumChk.Click
        If AddendumChk.Checked = False Then
            RemovedTileAccess += addendum
            containsTIleCode = AddedAccess.Contains(addendum)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(addendum)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += addendum
            Else
                If tileAccess.Contains(addendum) = False Then
                    AddedAccess += addendum
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(addendum)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(addendum)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub SalesITChk_Click(sender As Object, e As EventArgs) Handles SalesITChk.Click
        If SalesITChk.Checked = False Then
            RemovedTileAccess += SalesItinerary
            containsTIleCode = AddedAccess.Contains(SalesItinerary)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(SalesItinerary)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += SalesItinerary
            Else
                If tileAccess.Contains(SalesItinerary) = False Then
                    AddedAccess += SalesItinerary
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(SalesItinerary)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(SalesItinerary)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub SalesMonitoringChk_Click(sender As Object, e As EventArgs) Handles SalesMonitoringChk.Click
        If SalesMonitoringChk.Checked = False Then
            RemovedTileAccess += SalesMoni
            containsTIleCode = AddedAccess.Contains(SalesMoni)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(SalesMoni)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += SalesMoni
            Else
                If tileAccess.Contains(SalesMoni) = False Then
                    AddedAccess += SalesMoni
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(SalesMoni)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(SalesMoni)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub SUSChk_Click(sender As Object, e As EventArgs) Handles SUSChk.Click
        If SUSChk.Checked = False Then
            RemovedTileAccess += SUS
            containsTIleCode = AddedAccess.Contains(SUS)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(SUS)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += SUS
            Else
                If tileAccess.Contains(SUS) = False Then
                    AddedAccess += SUS
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(SUS)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(SUS)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub CallerInfoChk_Click(sender As Object, e As EventArgs) Handles CallerInfoChk.Click
        If CallerInfoChk.Checked = False Then
            RemovedTileAccess += CallerInfo
            containsTIleCode = AddedAccess.Contains(CallerInfo)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(CallerInfo)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += CallerInfo
            Else
                If tileAccess.Contains(CallerInfo) = False Then
                    AddedAccess += CallerInfo
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(CallerInfo)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(CallerInfo)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub CollectionChk_Click(sender As Object, e As EventArgs) Handles CollectionChk.Click
        If CollectionChk.Checked = False Then
            RemovedTileAccess += Collection
            containsTIleCode = AddedAccess.Contains(Collection)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Collection)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += Collection
            Else
                If tileAccess.Contains(Collection) = False Then
                    AddedAccess += Collection
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(Collection)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Collection)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub ExtDmgsChk_Click(sender As Object, e As EventArgs) Handles ExtDmgsChk.Click
        If ExtDmgsChk.Checked = False Then
            RemovedTileAccess += ExtDMGs
            containsTIleCode = AddedAccess.Contains(ExtDMGs)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ExtDMGs)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += ExtDMGs
            Else
                If tileAccess.Contains(ExtDMGs) = False Then
                    AddedAccess += ExtDMGs
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(ExtDMGs)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ExtDMGs)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub ChkBalanaceCHK_Click(sender As Object, e As EventArgs) Handles ChkBalanaceCHK.Click
        If ChkBalanaceCHK.Checked = False Then
            RemovedTileAccess += CheckBalance
            containsTIleCode = AddedAccess.Contains(CheckBalance)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(CheckBalance)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += CheckBalance
            Else
                If tileAccess.Contains(CheckBalance) = False Then
                    AddedAccess += CheckBalance
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(CheckBalance)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(CheckBalance)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub ProdSDRequestChk_Click(sender As Object, e As EventArgs) Handles ProdSDRequestChk.Click
        If ProdSDRequestChk.Checked = False Then
            RemovedTileAccess += ProdSDreq
            containsTIleCode = AddedAccess.Contains(ProdSDreq)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ProdSDreq)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += ProdSDreq
            Else
                If tileAccess.Contains(ProdSDreq) = False Then
                    AddedAccess += ProdSDreq
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(ProdSDreq)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ProdSDreq)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub CuttingListChk_Click(sender As Object, e As EventArgs) Handles CuttingListChk.Click
        If CuttingListChk.Checked = False Then
            RemovedTileAccess += CuttList
            containsTIleCode = AddedAccess.Contains(CuttList)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(CuttList)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += CuttList
            Else
                If tileAccess.Contains(CuttList) = False Then
                    AddedAccess += CuttList
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(CuttList)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(CuttList)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub StatusMonitoringChk_Click(sender As Object, e As EventArgs) Handles StatusMonitoringChk.Click
        If StatusMonitoringChk.Checked = False Then
            RemovedTileAccess += StatsMoni
            containsTIleCode = AddedAccess.Contains(StatsMoni)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(StatsMoni)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += StatsMoni
            Else
                If tileAccess.Contains(StatsMoni) = False Then
                    AddedAccess += StatsMoni
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(StatsMoni)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(StatsMoni)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub GlassSpecsChk_Click(sender As Object, e As EventArgs) Handles GlassSpecsChk.Click
        If GlassSpecsChk.Checked = False Then
            RemovedTileAccess += GlassSpecs
            containsTIleCode = AddedAccess.Contains(GlassSpecs)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(GlassSpecs)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += GlassSpecs
            Else
                If tileAccess.Contains(GlassSpecs) = False Then
                    AddedAccess += GlassSpecs
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(GlassSpecs)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(GlassSpecs)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub ProdSDSubmittalChk_Click(sender As Object, e As EventArgs) Handles ProdSDSubmittalChk.Click
        If ProdSDSubmittalChk.Checked = False Then
            RemovedTileAccess += ProdSDSubm
            containsTIleCode = AddedAccess.Contains(ProdSDSubm)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ProdSDSubm)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += ProdSDSubm
            Else
                If tileAccess.Contains(ProdSDSubm) = False Then
                    AddedAccess += ProdSDSubm
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(ProdSDSubm)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ProdSDSubm)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub ArchFirmChk_Click(sender As Object, e As EventArgs) Handles ArchFirmChk.Click
        If ArchFirmChk.Checked = False Then
            RemovedTileAccess += ArchiFirm
            containsTIleCode = AddedAccess.Contains(ArchiFirm)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(ArchiFirm)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += ArchiFirm
            Else
                If tileAccess.Contains(ArchiFirm) = False Then
                    AddedAccess += ArchiFirm
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(ArchiFirm)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(ArchiFirm)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub InventoryChk_Click(sender As Object, e As EventArgs) Handles InventoryChk.Click
        If InventoryChk.Checked = False Then
            RemovedTileAccess += Inventory
            containsTIleCode = AddedAccess.Contains(Inventory)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Inventory)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += Inventory
            Else
                If tileAccess.Contains(Inventory) = False Then
                    AddedAccess += Inventory
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(Inventory)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Inventory)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub RequestChk_Click(sender As Object, e As EventArgs) Handles RequestChk.Click
        If RequestChk.Checked = False Then
            RemovedTileAccess += Request
            containsTIleCode = AddedAccess.Contains(Request)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(Request)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += Request
            Else
                If tileAccess.Contains(Request) = False Then
                    AddedAccess += Request
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(Request)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(Request)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

    Private Sub PasswordCharChk_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordCharChk.CheckedChanged
        If PasswordCharChk.CheckState = CheckState.Checked Then
            PwdDecryptTbox.PasswordChar = Nothing
        ElseIf PasswordCharChk.CheckState = CheckState.Unchecked Then
            PwdDecryptTbox.PasswordChar = "*"
        End If
    End Sub

    Private Sub SaveManageBtn_Click(sender As Object, e As EventArgs) Handles SaveManageBtn.Click
        Dim Tcode As String
        FailedCount = 0
        If AddedAccess <> "" Then

            For searchingTileAccess As Integer = 0 To AddedAccess.Length - 1 Step 3
                Tcode = AddedAccess.Substring(searchingTileAccess + 1, 2)
                KMDI_ACCT_ACCESS_TB_INSERT(ManageAccounts.userAccess, Tcode, "0", ManageAccounts.UsersAutonum, "Inserted by: " & nickname & " " & Date.Now)
            Next

        End If

        If RemovedTileAccess <> "" Then
            If tileAccess <> Nothing Then

                For IndexToRemove As Integer = 0 To RemovedTileAccess.Length - 1 Step 3
                    Dim Temp As String = RemovedTileAccess.Substring(IndexToRemove + 1, 2)
                    If tileAccess.Contains(Temp) = True Then
                        KMDI_ACCT_ACCESS_TB_DELETE(Temp, ManageAccounts.UsersAutonum)
                    End If
                Next

            End If

        End If

        If FailedCount <> 0 Then
            MetroFramework.MetroMessageBox.Show(Me, "Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ManageAccounts.Enabled = True
            Me.Dispose()
        End If
    End Sub

    Private Sub WinDoorChk_Click(sender As Object, e As EventArgs) Handles WinDoorChk.Click
        If WinDoorChk.Checked = False Then
            RemovedTileAccess += WinDoor
            containsTIleCode = AddedAccess.Contains(WinDoor)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = AddedAccess.IndexOf(WinDoor)
                    AddedAccess = AddedAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        Else
            If tileAccess Is Nothing Then
                AddedAccess += WinDoor
            Else
                If tileAccess.Contains(WinDoor) = False Then
                    AddedAccess += WinDoor
                End If
            End If

            containsTIleCode = RemovedTileAccess.Contains(WinDoor)
            Select Case containsTIleCode
                Case True
                    indexofTileAccessCodes = RemovedTileAccess.IndexOf(WinDoor)
                    RemovedTileAccess = RemovedTileAccess.Remove(indexofTileAccessCodes, 3)

            End Select

        End If

    End Sub

End Class