Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading.Thread
Imports MetroFramework.Controls
Imports MetroFramework

Public Class MKTNG_Item
    Public OpenedByToolStripMenu As String
    Public MktngItem_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngItem_TODO As String
    Dim SubClassChkToolTip As New MetroFramework.Components.MetroToolTip
    Dim MainClassSTR, SubClassSTR, QRCode, max_MI As String
    Dim MainClassID As Integer
    Dim arr_SubClassID As New List(Of Integer) '//MISC_ID
    Dim arr_EventID As New List(Of Integer) '//MIE_ID
    Dim Sub_Class_list As New List(Of Integer)
    Dim Events_list As New List(Of Integer)
    Dim Load_Update_bool, if_Generated_QR_Status, Cr8Control, FormOnload As Boolean
    Dim EffectiveDiscount As Decimal = 0

    Dim MI_ID_here As String
    Dim ITEM_CODE_here As String
    Dim BRAND_here As String
    Dim ITEM_DESC_here As String
    Dim M_COLOR_here As String
    Dim M_SIZE_here As String
    Dim GENDER_here As String
    Dim MARKET_PRICE_here As Decimal
    Dim PURCHASED_PRICE_here As Decimal
    Dim QUANTITY_here As String
    Dim PURCHASED_DATE_here As Date
    Dim REMARKS_here As String
    Dim ITEM_PICTURE_here As String
    Dim MIC_ID_REF_here As Integer
    Public Gift_bool, Raffle_bool,
           Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool As Boolean

    Public Sub Start_MktngItemBGW()
        If MktngItem_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            FRM_Pnl.Enabled = False
            MktngItem_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub reset_here()
        ITEM_CODE_here = Nothing
        BRAND_here = Nothing
        ITEM_DESC_here = Nothing
        M_COLOR_here = Nothing
        M_SIZE_here = Nothing
        GENDER_here = Nothing
        MARKET_PRICE_here = Nothing
        PURCHASED_PRICE_here = Nothing
        QUANTITY_here = Nothing
        PURCHASED_DATE_here = Nothing
        REMARKS_here = Nothing
        ITEM_PICTURE_here = Nothing
    End Sub
    Public Sub End_MktngItemBGW()
        Mktng_SearchStr = Nothing
        RESET()
        LoadingPB.Visible = False
        FRM_Pnl.Enabled = True
        FormOnload = False
    End Sub

    Sub Add_Item()
        ITEM_CODE_here = Trim(ItemCodeTbox.Text)
        BRAND_here = Trim(BrandTbox.Text)
        ITEM_DESC_here = Trim(ItemDesTbox.Text)
        M_COLOR_here = Trim(ColorTbox.Text)
        M_SIZE_here = Trim(SizeTbox.Text)
        GENDER_here = Trim(GenPrefCbox.Text)
        PURCHASED_DATE_here = PurchasedDate_dtp.Value
        REMARKS_here = Trim(RemarksTbox.Text)

        Gift_bool = GiftPurpose_Chk.Checked
        Raffle_bool = RafflePurpose_Chk.Checked
        Tier1_bool = Tier1_Chk.Checked
        Tier2_bool = Tier2_Chk.Checked
        Tier3_bool = Tier3_Chk.Checked
        Tier4_bool = Tier4_Chk.Checked
        Tier5_bool = Tier5_Chk.Checked
        Tier6_bool = Tier6_Chk.Checked
        Tier7_bool = Tier7_Chk.Checked

        If QuantityTbox.Text <> Nothing Or QuantityTbox.Text <> "" Then
            QUANTITY_here = Val(QuantityTbox.Text)
        End If
        If MarketPriceTbox.Text <> "" Or MarketPriceTbox.Text <> Nothing Then
            MARKET_PRICE_here = Convert.ToDecimal(MarketPriceTbox.Text)
        Else
            MARKET_PRICE_here = Nothing
        End If
        If PurchasedPriceTbox.Text <> "" Or PurchasedPriceTbox.Text <> Nothing Then
            PURCHASED_PRICE_here = Convert.ToDecimal(PurchasedPriceTbox.Text)
        End If
        If MARKET_PRICE_here <> 0.0 Then
            EffectiveDiscount = (1 - (PURCHASED_PRICE_here / MARKET_PRICE_here)) * 100
        Else
            EffectiveDiscount = 0.0
        End If


        Dim tier_checked As Integer = 0
        Dim purpose_checked As Integer = 0
        Dim MainClass_Checked As Integer = 0
        Dim SubClass_Checked As Integer = 0
        Dim Event_Checked As Integer = 0

        For Each tier_chk In FRM_Pnl.Controls
            If (tier_chk.Name.Contains("Tier") And tier_chk.Name.Contains("Chk")) Then
                If tier_chk.Checked = True Then
                    tier_checked += 1
                End If
            ElseIf tier_chk.Name.Contains("Purpose_Chk") Then
                If tier_chk.Checked = True Then
                    purpose_checked += 1
                End If
            End If
        Next
        For Each MainClass_rbtn In MainClass_FLP.Controls
            If MainClass_rbtn.Checked = True Then
                MainClass_Checked += 1
                MIC_ID_REF_here = MainClass_rbtn.Tag
            End If
        Next
        For Each SubClass_chkBox In SubClass_FLP.Controls
            If SubClass_chkBox.Checked = True Then
                SubClass_Checked += 1
                Sub_Class_list.Add(SubClass_chkBox.Tag)
            End If
        Next
        For Each Event_chkBox In Events_FLP.Controls
            If Event_chkBox.Checked = True Then
                Event_Checked += 1
                Events_list.Add(Event_chkBox.Tag)
            End If
        Next

        If ITEM_CODE_here <> Nothing Or ITEM_CODE_here <> "" Then
            If BRAND_here <> Nothing Or BRAND_here <> "" Then
                If ITEM_DESC_here <> Nothing Or ITEM_DESC_here <> "" Then
                    If MARKET_PRICE_here <> 0.0 Then
                        If PurchasedPriceTbox.Text <> "" Or PurchasedPriceTbox.Text <> Nothing Then
                            If PurchasedDateTbox.Text <> Nothing Or PurchasedDateTbox.Text <> "" Then
                                If tier_checked > 0 Then
                                    If purpose_checked > 0 Then
                                        If MainClass_Checked > 0 Then
                                            If Event_Checked > 0 Then
                                                If OpenedByToolStripMenu = "ADD" Then
                                                    MktngItem_TODO = "Add_Item"
                                                ElseIf OpenedByToolStripMenu = "UPDATE" Then
                                                    MktngItem_TODO = "Update_Item"
                                                End If
                                                Start_MktngItemBGW()
                                            ElseIf Event_Checked = 0 Then
                                                KMDIPrompts(Me, "UserWarning", "Event_Checked is Empty", Environment.StackTrace, Nothing, True, True, "Event Tags cannot be empty")
                                            End If
                                        ElseIf MainClass_Checked = 0 Then
                                            KMDIPrompts(Me, "UserWarning", "MainClass_Checked is Empty", Environment.StackTrace, Nothing, True, True, "Main Classification cannot be empty")
                                        End If
                                    ElseIf purpose_checked = 0 Then
                                        KMDIPrompts(Me, "UserWarning", "purpose_checked is Empty", Environment.StackTrace, Nothing, True, True, "Purpose cannot be empty")
                                    End If
                                ElseIf tier_checked = 0 Then
                                    KMDIPrompts(Me, "UserWarning", "tier_checked is Empty", Environment.StackTrace, Nothing, True, True, "Tier cannot be empty")
                                End If
                            Else
                                KMDIPrompts(Me, "UserWarning", "PURCHASED_DATE is Empty", Environment.StackTrace, Nothing, True, True, "Purchased Date cannot be empty")
                            End If
                        Else
                            KMDIPrompts(Me, "UserWarning", "PURCHASED_PRICE is Empty", Environment.StackTrace, Nothing, True, True, "Purchased Price cannot be empty")
                        End If
                    Else
                        KMDIPrompts(Me, "UserWarning", "MARKET_PRICE is Empty", Environment.StackTrace, Nothing, True, True, "Market Price cannot be zero")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "ITEM_DESC is Empty", Environment.StackTrace, Nothing, True, True, "Item Description cannot be empty")
                End If
            Else
                KMDIPrompts(Me, "UserWarning", "BRAND is Empty", Environment.StackTrace, Nothing, True, True, "Brand cannot be empty")
            End If
        Else
            KMDIPrompts(Me, "UserWarning", "ItemCode is Empty", Environment.StackTrace, Nothing, True, True, "Item Code cannot be empty")
        End If

    End Sub

    Private Sub MKTNG_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MktngItem_BGW.WorkerSupportsCancellation = True
            MktngItem_BGW.WorkerReportsProgress = True
            AddHandler MktngItem_BGW.DoWork, AddressOf MktngItem_BGW_DoWork
            AddHandler MktngItem_BGW.ProgressChanged, AddressOf MktngItem_BGW_ProgressChanged
            AddHandler MktngItem_BGW.RunWorkerCompleted, AddressOf MktngItem_BGW_RunWorkerCompleted
            GenPrefCbox.SelectedIndex = 0
            'MainClass_FLP.Controls.Clear()
            FormOnload = True
            Select Case OpenedByToolStripMenu
                Case "ADD"
                    MktngItem_TODO = "MainClass"
                Case "UPDATE"
                    'reset_here()
                    Load_Update_bool = True
                    MktngItem_TODO = "MainClass"
                    ItemCodeTbox.Text = ITEM_CODE
                    BrandTbox.Text = BRAND
                    ItemDesTbox.Text = ITEM_DESC
                    ColorTbox.Text = M_COLOR
                    SizeTbox.Text = M_SIZE
                    GenPrefCbox.Text = GENDER
                    QuantityTbox.Text = QUANTITY
                    MarketPriceTbox.Text = MARKET_PRICE.ToString("N2")
                    PurchasedPriceTbox.Text = PURCHASED_PRICE.ToString("N2")
                    PurchasedDateTbox.Text = PURCHASED_DATE.ToString("MMM. dd, yyyy")
                    RemarksTbox.Text = REMARKS
                    QuantityTbox.Enabled = False
                    If ItemCodeTbox.Text <> Nothing Or ItemCodeTbox.Text <> "" Then
                        ItemCodeTbox.Enabled = False
                    End If
            End Select
            Start_MktngItemBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Dim Report_BGW_bool As Boolean = False
    Private Sub MktngItem_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MktngItem_TODO
                Case "Load_Update_Item"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(MI_ID, "MKTNG_stp_Inv_FetchItem")
                Case "MainClass"
                    Cr8Control = True
                    Report_BGW_bool = True
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Item_MainClass")
                Case "SubClass"
                    Report_BGW_bool = True
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(MainClassID, "MKTNG_stp_Item_SubClass")
                Case "Load_Events"
                    Report_BGW_bool = True
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Inv_Events")
                Case "QR"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Inv_MAXID")
                Case "MainClass_Insert"
                    Mktng_MainClass_Insert(MainClassSTR, "MKTNG_stp_Item_MainClass_Insert")
                Case "SubClass_Insert"
                    Mktng_SubClass_Insert(SubClassSTR, MainClassID, "MKTNG_stp_Item_SubClass_Insert")
                Case "Add_Item"
                    Mktng_Inv_ItemInsert("MKTNG_stp_Inv_Item_Insert", ITEM_CODE_here, ITEM_DESC_here, GENDER_here, MARKET_PRICE_here, PURCHASED_PRICE_here,
                                         EffectiveDiscount, QUANTITY_here, PURCHASED_DATE_here, if_Generated_QR_Status, Gift_bool, Raffle_bool,
                                         Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool, MIC_ID_REF_here,
                                         Sub_Class_list, Events_list, M_COLOR_here, BRAND_here, M_SIZE_here, REMARKS_here)
                Case "Update_Item"
            End Select

            Select Case Report_BGW_bool
                Case True
                    For i = 0 To sqlDataSet.Tables("QUERY_DETAILS").Rows.Count - 1
                        Sleep(100)
                        MktngItem_BGW.ReportProgress(i)
                    Next
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            MktngItem_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        Catch ex2 As Exception
            KMDIPrompts(Me, "DotNetError", ex2.Message, ex2.StackTrace, Nothing, True)
        End Try

        If MktngItem_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub MktngItem_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Dim Rdbtn As New MetroRadioButton
            Dim Chkbox As New MetroCheckBox
            Dim MetroControlSize As New MetroCheckBoxSize
            Dim ItemName As String = Nothing, TagName As String = Nothing, ControlType As String = Nothing
            Dim Width As Integer

            Select Case Cr8Control
                Case True
                    Select Case MktngItem_TODO
                        Case "MainClass"
                            ItemName = "MAIN_CLASS"
                            TagName = "MIC_ID"
                            Width = 150
                            ControlType = "MetroRadioButton"

                        Case "SubClass"
                            ItemName = "SUB_CLASS"
                            TagName = "MISC_ID"
                            Width = 150
                            MetroControlSize = MetroCheckBoxSize.Medium
                            ControlType = "MetroCheckBox"

                        Case "Load_Events"
                            ItemName = "EVENT"
                            TagName = "MIE_ID"
                            Width = 246
                            MetroControlSize = MetroCheckBoxSize.Tall
                            ControlType = "MetroCheckBox"

                    End Select

                    Select Case ControlType
                        Case "MetroRadioButton"
                            RdBtn_Properties("Dynamic", Rdbtn, ItemName, TagName, Width,
                                             e.ProgressPercentage, Nothing, MetroCheckBoxSize.Tall, False)
                        Case "MetroCheckBox"
                            Chkbox_Properties("Dynamic", Chkbox, ItemName, TagName, Width,
                                              e.ProgressPercentage, Nothing, MetroControlSize, False)
                    End Select


                    Select Case MktngItem_TODO
                        Case "MainClass"
                            If MainClass_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                                MainClass_FLP.Controls.Clear()
                            End If

                            AddHandler Rdbtn.Click, AddressOf ClassRbtn_Clicked
                            MainClass_FLP.Controls.Add(Rdbtn)

                        Case "SubClass"
                            If SubClass_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                                SubClass_FLP.Controls.Clear()
                            End If

                            SubClass_FLP.Controls.Add(Chkbox)

                        Case "Load_Events"
                            If Events_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                                Events_FLP.Controls.Clear()
                            End If

                            Events_FLP.Controls.Add(Chkbox)
                    End Select

                Case False
            End Select




            'Select Case MktngItem_TODO
            '    Case "MainClass"
            '        With ClassRbtn
            '            .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MAIN_CLASS").ToString
            '            .Text = .Name
            '            .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MIC_ID").ToString
            '            .FontSize = MetroFramework.MetroCheckBoxSize.Tall
            '            SubClassChkToolTip.SetToolTip(ClassRbtn, .Text)
            '            AddHandler .Click, AddressOf ClassRbtn_Clicked
            '            MainClass_FLP.Controls.Add(ClassRbtn)
            '        End With
            '    Case "SubClass"
            '        Dim SubClassChk As New MetroFramework.Controls.MetroCheckBox
            '        With SubClassChk
            '            .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("SUB_CLASS").ToString
            '            .Text = .Name
            '            .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MISC_ID").ToString
            '            .FontSize = MetroFramework.MetroCheckBoxSize.Medium
            '            SubClassChkToolTip.SetToolTip(SubClassChk, .Text)
            '            SubClass_FLP.Controls.Add(SubClassChk)
            '        End With
            '    Case "Load_Events"
            '        Dim EventsChk As New MetroFramework.Controls.MetroCheckBox
            '        With EventsChk
            '            .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("EVENT").ToString
            '            .Text = .Name
            '            .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MIE_ID").ToString
            '            .Size = New Size(246, 25)
            '            .FontSize = MetroFramework.MetroCheckBoxSize.Tall
            '            SubClassChkToolTip.SetToolTip(EventsChk, .Text)
            '            Events_FLP.Controls.Add(EventsChk)
            '        End With
            'End Select
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
            LoadingPB.Visible = False
        End Try
    End Sub

    Private Sub MktngItem_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                ' if BackgroundWorker terminated due to error
                LoadingPB.Visible = False
                FRM_Pnl.Enabled = True
            Else
                '' otherwise it completed normally
                If sql_Transaction_result = "Committed" Then
                    Select Case MktngItem_TODO
                        Case "Load_Update_Item"
                            For Each row In sqlBindingSource
                                Tier1_Chk.Checked = row("TIER 1")
                                Tier2_Chk.Checked = row("TIER 2")
                                Tier3_Chk.Checked = row("TIER 3")
                                Tier4_Chk.Checked = row("TIER 4")
                                Tier5_Chk.Checked = row("TIER 5")
                                Tier6_Chk.Checked = row("TIER 6")
                                Tier7_Chk.Checked = row("TIER 7")

                                GiftPurpose_Chk.Checked = row("GIFT")
                                RafflePurpose_Chk.Checked = row("RAFFLE")

                                MainClassID = row("MIC_ID")
                                arr_EventID.Add(row("MIE_ID"))
                                If Not IsDBNull(row("MISC_ID")) Then
                                    arr_SubClassID.Add(row("MISC_ID"))
                                End If
                            Next
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()

                        Case "MainClass"
                            Report_BGW_bool = False
                            'Events_FLP.Controls.Clear()
                            If FormOnload = True Then
                                MktngItem_TODO = "Load_Events"
                                Start_MktngItemBGW()
                            End If

                        Case "SubClass"
                            Report_BGW_bool = False

                            If FormOnload = True Then
                                Select Case Load_Update_bool
                                    Case True
                                        For Each rbtn In MainClass_FLP.Controls
                                            If rbtn.Tag = MainClassID Then
                                                rbtn.Checked = True
                                            End If
                                        Next
                                        For Each chkbox In SubClass_FLP.Controls
                                            For Each id As Integer In arr_SubClassID
                                                If chkbox.Tag = id Then
                                                    chkbox.Checked = True
                                                End If
                                            Next
                                        Next
                                        For Each chkbox In Events_FLP.Controls
                                            For Each Eid As Integer In arr_EventID
                                                If chkbox.Tag = Eid Then
                                                    chkbox.Checked = True
                                                End If
                                            Next
                                        Next
                                        Load_Update_bool = False
                                End Select
                            End If
                            End_MktngItemBGW()

                        Case "MainClass_Insert"
                            'MainClass_Tbox.Clear()
                            MktngItem_TODO = "MainClass"
                            Start_MktngItemBGW()

                        Case "SubClass_Insert"
                            'SubClass_Tbox.Clear()
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()

                        Case "Load_Events"
                            Report_BGW_bool = False
                            If FormOnload = True Then
                                Select Case OpenedByToolStripMenu
                                    Case "UPDATE"
                                        MktngItem_TODO = "Load_Update_Item"
                                        Start_MktngItemBGW()
                                    Case "ADD"
                                        MktngItem_TODO = "QR"
                                        Start_MktngItemBGW()
                                End Select
                            End If

                        Case "QR"
                            For Each row In sqlBindingSource
                                max_MI = row("MAX_ID").ToString
                            Next
                            '5 6 _ _ _ _ _   _ _   _ _ _ _
                            'K M 0 0 0 0 1   1 2   M M Y Y
                            '    ItemCodes   UID   MMYY NOW
                            If max_MI <> "" Then
                                max_MI += 1
                                Dim MICount As Integer = max_MI.Count
                                Dim ZEROES As String = Nothing

                                For i = MICount + 1 To 5
                                    ZEROES += "0"
                                Next

                                QRCode = "56" & ZEROES & max_MI & AccountAutonum & Now.ToString("MMyy")
                                ItemCodeTbox.Text = QRCode
                            Else
                                QRCode = "56" & "00001" & AccountAutonum & Now.ToString("MMyy")
                                ItemCodeTbox.Text = QRCode
                            End If
                            if_Generated_QR_Status = True
                            End_MktngItemBGW()

                        Case "Add_Item"
                            MKTNG_Inventory.Inv_DGV.Rows.Add(InsertedMI_ID, ITEM_CODE_here, BRAND_here, ITEM_DESC_here,
                                                             M_COLOR_here, M_SIZE_here, GENDER_here, QUANTITY_here, MARKET_PRICE_here,
                                                             PURCHASED_PRICE_here, EffectiveDiscount, PURCHASED_DATE, REMARKS_here)
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)

                    End Select
                Else
                    KMDIPrompts(Me, "Failed", "Failed in Inserting Item", Environment.StackTrace, Nothing, True)
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub ClassRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            MainClassID = sender.Tag
            SubClass_FLP.Controls.Clear()
            MktngItem_TODO = "SubClass"
            Start_MktngItemBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MKTNG_Item_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) Then
                If OpenedByToolStripMenu = "ADD" Then
                    Add_Item()
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                Close()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MKTNG_Item_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            reset_here()
            e.Cancel = True
        Else
            MKTNG_Inventory.BringToFront()

            'PD_UpdateHeader.Dispose()
            'PD_SearchFRM.Dispose()
            'NewProject_Register.Dispose()

            'PD_Addendum.Dispose()
            'PD_TechPartners.Dispose()
            'PD_UpdateCOMP.Dispose()
            'PD_UpdateEMP.Dispose()

            'PD_SalesJobOrder.Dispose()
            'PD_PertDetails.Dispose()
            'PD_JoAttach.Dispose()

            Dispose()

            e.Cancel = False
        End If
    End Sub
    Sub classification_insert(ByVal MODE As String)
        Select Case MODE
            Case "MAIN"
                'MainClass_FLP.Controls.Clear()
                If MainClassSTR = Nothing Or MainClassSTR = "" Then
                    KMDIPrompts(Me, "DotNetError", Nothing, Nothing, Nothing, True, True, "Field cannot be empty")
                Else
                    MktngItem_TODO = "MainClass_Insert"
                End If
            Case "SUB"
                SubClass_FLP.Controls.Clear()
                If SubClassSTR = Nothing Or SubClassSTR = "" Then
                    KMDIPrompts(Me, "DotNetError", Nothing, Nothing, Nothing, True, True, "Field cannot be empty")
                Else
                    MktngItem_TODO = "SubClass_Insert"
                End If
        End Select
        Start_MktngItemBGW()
    End Sub
    Private Sub ItemCodeTbox_ButtonClick(sender As Object, e As EventArgs) Handles ItemCodeTbox.ButtonClick
        Try
            MktngItem_TODO = "QR"
            Start_MktngItemBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub PurchasedDate_dtp_Enter(sender As Object, e As EventArgs) Handles PurchasedDate_dtp.Enter
        PurchasedDateTbox.Text = PurchasedDate_dtp.Value.ToString("MMM. dd, yyyy")
    End Sub

    Private Sub MainClass_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles MainClass_Tbox.ButtonClick
        Try
            MainClassSTR = Trim(MainClass_Tbox.Text)
            classification_insert("MAIN")
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub SubClass_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles SubClass_Tbox.ButtonClick
        Try
            SubClassSTR = Trim(SubClass_Tbox.Text)
            classification_insert("SUB")
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub PurchasedPriceTbox_TextChanged(sender As Object, e As EventArgs) Handles PurchasedPriceTbox.TextChanged
        Try
            If PurchasedPriceTbox.Text = Nothing Or PurchasedPriceTbox.Text = "" Then
                PURCHASED_PRICE_here = 0.0
            Else
                PURCHASED_PRICE_here = PurchasedPriceTbox.Text
                If PURCHASED_PRICE_here > MARKET_PRICE_here Then
                    PurchasedPriceTbox.Text = MARKET_PRICE_here
                End If
            End If
            'PurchasedPriceTbox.Text = PURCHASED_PRICE.ToString("N2")
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MarketPriceTbox_TextChanged(sender As Object, e As EventArgs) Handles MarketPriceTbox.TextChanged
        Try
            If MarketPriceTbox.Text = Nothing Or MarketPriceTbox.Text = "" Then
                MARKET_PRICE_here = 0.0
            Else
                MARKET_PRICE_here = MarketPriceTbox.Text
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub Prices_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MarketPriceTbox.KeyPress, PurchasedPriceTbox.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar) And e.KeyChar <> "." And
                e.KeyChar <> ControlChars.Back And e.KeyChar <> ",") Then
                e.Handled = True
                Throw New Exception()
            Else
                If sender.Text.IndexOf(".") >= 0 Then
                    If (Not IsNumeric(e.KeyChar) And e.KeyChar <> ControlChars.Back) Then
                        e.Handled = True
                        Throw New Exception()
                    Else
                        e.Handled = False
                    End If
                Else
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "UserWarning", "Invalid value", Environment.StackTrace, Nothing, True, True, "Numbers with one(1) decimal only")
        End Try
    End Sub

    Private Sub MarketPriceTbox_Leave(sender As Object, e As EventArgs) Handles MarketPriceTbox.Leave
        Try
            MarketPriceTbox.Text = MARKET_PRICE_here.ToString("N2")
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub PurchasedPriceTbox_Leave(sender As Object, e As EventArgs) Handles PurchasedPriceTbox.Leave
        Try
            PurchasedPriceTbox.Text = PURCHASED_PRICE_here.ToString("N2")
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub QuantityTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QuantityTbox.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar)) And (e.KeyChar <> ControlChars.Back) Then
                e.Handled = True
                Throw New Exception()
            Else
                e.Handled = False
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "UserWarning", "Invalid value", Environment.StackTrace, Nothing, True, True, "Numbers with one(1) decimal only")
        End Try
    End Sub

    Private Sub MainClass_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles MainClass_Tbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                MainClassSTR = Trim(MainClass_Tbox.Text)
                classification_insert("MAIN")
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub SubClass_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SubClass_Tbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SubClassSTR = Trim(SubClass_Tbox.Text)
                classification_insert("SUB")
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub PurchasedDate_dtp_Leave(sender As Object, e As EventArgs) Handles PurchasedDate_dtp.Leave
        PurchasedDateTbox.Text = PurchasedDate_dtp.Value.ToString("MMM. dd, yyyy")
    End Sub

    Private Sub PurchasedDate_dtp_ValueChanged(sender As Object, e As EventArgs) Handles PurchasedDate_dtp.ValueChanged
        PurchasedDateTbox.Text = PurchasedDate_dtp.Value.ToString("MMM. dd, yyyy")
    End Sub
End Class