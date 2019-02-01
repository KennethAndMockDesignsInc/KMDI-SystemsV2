Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading.Thread
Imports MetroFramework.Controls
Imports MetroFramework
Public Class MKTNG_Item
    Public OpenedByToolStripMenu As String
    Public MktngItem_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngItem_TODO As String
    Dim MainClassSTR, SubClassSTR, EventStr, QRCode, max_MI As String
    Dim MainClassID As Integer = Nothing, MIC_ID_REF_here As Integer
    Dim arr_SubClassID As New List(Of Integer) '//MISC_ID
    Dim arr_EventID As New List(Of Integer) '//MIE_ID
    Dim Sub_Class_list As New List(Of Integer)
    Dim Events_list As New List(Of Integer)
    Dim Inventoy_Hits_list As New List(Of Integer)
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
    Public Gift_bool, Raffle_bool,
           Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool As Boolean

    Dim MainClassID_toUpdate, SubClassID_toUpdate, EventID_toUpdate As Integer
    Public Sub Start_MktngItemBGW()
        If MktngItem_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            FRM_Pnl.Enabled = False
            MktngItem_BGW.RunWorkerAsync()
        Else
            MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        MainClassSTR = Nothing
        SubClassSTR = Nothing
        EventStr = Nothing
        MainClassID_toUpdate = Nothing
        SubClassID_toUpdate = Nothing
        EventID_toUpdate = Nothing
        With MainClass_Tbox
            .Clear()
            .Style = MetroColorStyle.Teal
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
        With SubClass_Tbox
            .Clear()
            .Style = MetroColorStyle.Teal
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
        With Event_Tbox
            .Clear()
            .Style = MetroColorStyle.Teal
            .UseStyleColors = False
            .CustomButton.Text = "+"
        End With
    End Sub
    Public Sub End_MktngItemBGW()
        Mktng_SearchStr = Nothing
        RESET()
        LoadingPB.Visible = False
        FRM_Pnl.Enabled = True
        FormOnload = False
    End Sub

    Sub Save_Item()
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

        Sub_Class_list.Clear()
        Events_list.Clear()

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
                    Cr8Control = True
                    Mktng_MainClass_Insert(MainClassSTR, "MKTNG_stp_Item_MainClass_Insert")

                Case "MainClass_Update"
                    Mktng_MainClass_Update(MainClassSTR, MainClassID_toUpdate, "MKTNG_stp_Item_MainClass_Update")

                Case "MainClass_Delete"
                    Mktng_MainClass_Delete(MainClassID_toUpdate, "MKTNG_stp_Item_MainClass_Delete")

                Case "SubClass_Insert"
                    Cr8Control = True
                    Mktng_SubClass_Insert(SubClassSTR, MainClassID, "MKTNG_stp_Item_SubClass_Insert")

                Case "SubClass_Update"
                    Mktng_SubClass_Update(SubClassSTR, SubClassID_toUpdate, "MKTNG_stp_Item_SubClass_Update")

                Case "SubClass_Delete"
                    Mktng_SubClass_Delete(SubClassID_toUpdate, "MKTNG_stp_Item_SubClass_Delete")

                Case "Event_Insert"
                    Cr8Control = True
                    Mktng_Event_Insert(EventStr, "MKTNG_stp_Inv_Events_Insert")

                Case "Event_Update"
                    Cr8Control = True
                    Mktng_Event_Update(EventStr, EventID_toUpdate, "MKTNG_stp_Inv_Events_Update")

                Case "Add_Item"
                    Mktng_Inv_ItemInsert("MKTNG_stp_Inv_Item_Insert", ITEM_CODE_here, ITEM_DESC_here, GENDER_here, MARKET_PRICE_here, PURCHASED_PRICE_here,
                                         EffectiveDiscount, QUANTITY_here, PURCHASED_DATE_here, if_Generated_QR_Status, Gift_bool, Raffle_bool,
                                         Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool, MIC_ID_REF_here,
                                         Sub_Class_list, Events_list, M_COLOR_here, BRAND_here, M_SIZE_here, REMARKS_here)

                Case "Update_Item"
                    Mktng_Inv_ItemUpdate("MKTNG_stp_Inv_Item_Update", ITEM_DESC_here, GENDER_here, MARKET_PRICE_here, PURCHASED_PRICE_here,
                                         EffectiveDiscount, PURCHASED_DATE_here, Gift_bool, Raffle_bool,
                                         Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool, MIC_ID_REF_here,
                                        MI_ID, MIP_ID_REF, MIT_ID_REF, Sub_Class_list, Events_list, M_COLOR_here, BRAND_here, M_SIZE_here, REMARKS_here)

                Case "Main_Class_Search_HIT"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(MainClassID_toUpdate, "MKTNG_stp_Item_MainClass_Hit")

                Case "Sub_Class_Search_HIT"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(SubClassID_toUpdate, "MKTNG_stp_Item_SubClass_Hit")

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
                            Width = 100
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
                                             e.ProgressPercentage, Mktng_Cmenu, MetroCheckBoxSize.Tall, False)
                        Case "MetroCheckBox"
                            Chkbox_Properties("Dynamic", Chkbox, ItemName, TagName, Width,
                                              e.ProgressPercentage, Mktng_Cmenu, MetroControlSize, False)
                    End Select


                    Select Case MktngItem_TODO
                        Case "MainClass"
                            If MainClass_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                                MainClass_FLP.Controls.Clear()
                            End If

                            AddHandler Rdbtn.Click, AddressOf ClassRbtn_Clicked
                            AddHandler Rdbtn.MouseDown, AddressOf CreatedControls_MouseDown
                            MainClass_FLP.Controls.Add(Rdbtn)

                        Case "SubClass"
                            If SubClass_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                                SubClass_FLP.Controls.Clear()
                            End If

                            AddHandler Chkbox.MouseDown, AddressOf CreatedControls_MouseDown
                            SubClass_FLP.Controls.Add(Chkbox)

                        Case "Load_Events"
                            If Events_FLP.Controls.Count <> 0 And e.ProgressPercentage = 0 Then
                                Events_FLP.Controls.Clear()
                            End If

                            AddHandler Chkbox.MouseDown, AddressOf CreatedControls_MouseDown
                            Events_FLP.Controls.Add(Chkbox)
                    End Select
                Case False
            End Select

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

                                If Not IsDBNull(row("MIC_ID")) Then
                                    MainClassID = row("MIC_ID")
                                End If
                                If Not IsDBNull(row("MIE_ID")) Then
                                    arr_EventID.Add(row("MIE_ID"))
                                End If
                                If Not IsDBNull(row("MISC_ID")) Then
                                    arr_SubClassID.Add(row("MISC_ID"))
                                End If
                            Next
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()

                        Case "MainClass"
                            Report_BGW_bool = False
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
                            Dim RdBtn As New MetroRadioButton
                            Select Case Cr8Control
                                Case True
                                    RdBtn_Properties("Static", RdBtn, MainClassSTR, InsertedMIC_ID, 150,
                                                     Nothing, Mktng_Cmenu, MetroCheckBoxSize.Tall, False)
                                    MainClass_FLP.Controls.Add(RdBtn)
                                    AddHandler RdBtn.Click, AddressOf ClassRbtn_Clicked
                                    AddHandler RdBtn.MouseDown, AddressOf CreatedControls_MouseDown
                            End Select
                            End_MktngItemBGW()

                        Case "MainClass_Update"
                            For Each ctrl In MainClass_FLP.Controls
                                If ctrl.Tag = MainClassID_toUpdate Then
                                    ctrl.Text = Replace(MainClassSTR, "&", "&&")
                                    GlobalToolTip.SetToolTip(ctrl, ctrl.Text)
                                End If
                            Next
                            reset_here()
                            End_MktngItemBGW()

                        Case "MainClass_Delete"
                            For Each ctrl In MainClass_FLP.Controls
                                If ctrl.Tag = MainClassID_toUpdate Then
                                    MainClass_FLP.Controls.Remove(ctrl)
                                End If
                            Next

                            If SubClass_FLP.Controls.Count <> 0 Then
                                SubClass_FLP.Controls.Clear()
                            End If
                            'For Each items As Integer In Inventoy_Hits_list
                            '    For i = 0 To MKTNG_Inventory.Inv_DGV.Rows.Count - 1
                            '        If items = MKTNG_Inventory.Inv_DGV.Rows(i).Cells("MI_ID").Value Then
                            '            MKTNG_Inventory.Inv_DGV.Rows(i).DefaultCellStyle.BackColor = Color.LightCoral
                            '        End If
                            '    Next
                            'Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)

                            Inventoy_Hits_list.Clear()
                            reset_here()
                            End_MktngItemBGW()

                        Case "Main_Class_Search_HIT"
                            Dim Item_list As String = Nothing, Item_list_log As String = vbCrLf & MainClassSTR & vbCrLf
                            Dim counter As Integer = 0

                            If sqlDataSet.Tables("QUERY_DETAILS").Rows.Count > 0 Then
                                For Each row In sqlBindingSource
                                    counter += 1
                                    Item_list += (counter & ". " & row("ITEM_CODE") & " - " & row("ITEM") & vbCrLf)
                                    Item_list_log += (row("ID").ToString + ". " + row("ITEM") + vbCrLf)
                                    Inventoy_Hits_list.Add(row("ID"))
                                Next
                                KMDIPrompts(Me, "UserWarning", Item_list_log, Nothing, Nothing, True, True,
                                            "Hits detected. Proceed?", MessageBoxButtons.YesNo)
                                If QuestionPromptAnswer = 6 Then
                                    Dim saveFileDialog1 As New SaveFileDialog()

                                    saveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
                                    If saveFileDialog1.ShowDialog = DialogResult.OK Then
                                        My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, Item_list, True)

                                        MktngItem_TODO = "MainClass_Delete"
                                        Start_MktngItemBGW()
                                    End If
                                End If

                            ElseIf sqlDataSet.Tables("QUERY_DETAILS").Rows.Count = 0 Then
                                KMDIPrompts(Me, "Question", "No hits detected. Proceed?", Nothing, Nothing, True)
                                If QuestionPromptAnswer = 6 Then
                                    MktngItem_TODO = "MainClass_Delete"
                                    Start_MktngItemBGW()
                                End If
                            End If
                            End_MktngItemBGW()

                        Case "SubClass_Insert"
                            Dim Chkbox As New MetroCheckBox
                            Select Case Cr8Control
                                Case True
                                    Chkbox_Properties("Static", Chkbox, SubClassSTR, InsertedMISC_ID, 100,
                                                      Nothing, Mktng_Cmenu, MetroCheckBoxSize.Medium, False)
                                    SubClass_FLP.Controls.Add(Chkbox)
                                    AddHandler Chkbox.MouseDown, AddressOf CreatedControls_MouseDown
                            End Select
                            End_MktngItemBGW()

                        Case "SubClass_Update"
                            For Each ctrl In SubClass_FLP.Controls
                                If ctrl.Tag = SubClassID_toUpdate Then
                                    ctrl.Text = Replace(SubClassSTR, "&", "&&")
                                    GlobalToolTip.SetToolTip(ctrl, ctrl.Text)
                                End If
                            Next
                            reset_here()
                            End_MktngItemBGW()

                        Case "SubClass_Delete"
                            For Each ctrl In SubClass_FLP.Controls
                                If ctrl.Tag = SubClassID_toUpdate Then
                                    SubClass_FLP.Controls.Remove(ctrl)
                                End If
                            Next
                            'For Each items As Integer In Inventoy_Hits_list
                            '    For i = 0 To MKTNG_Inventory.Inv_DGV.Rows.Count - 1
                            '        If items = MKTNG_Inventory.Inv_DGV.Rows(i).Cells("MI_ID").Value Then
                            '            MKTNG_Inventory.Inv_DGV.Rows(i).DefaultCellStyle.BackColor = Color.LightCoral
                            '        End If
                            '    Next
                            'Next
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)

                            Inventoy_Hits_list.Clear()
                            reset_here()
                            End_MktngItemBGW()

                        Case "Sub_Class_Search_HIT"
                            Dim Item_list As String = Nothing, Item_list_log As String = vbCrLf & SubClassSTR & vbCrLf
                            Dim counter As Integer = 0

                            If sqlDataSet.Tables("QUERY_DETAILS").Rows.Count > 0 Then
                                For Each row In sqlBindingSource
                                    counter += 1
                                    Item_list += (counter & ". " & row("ITEM_CODE") & " - " & row("ITEM") & vbCrLf)
                                    Item_list_log += (row("ID").ToString + ". " + row("ITEM") + vbCrLf)
                                    Inventoy_Hits_list.Add(row("ID"))
                                Next
                                KMDIPrompts(Me, "UserWarning", Item_list_log, Nothing, Nothing, True, True,
                                            "Hits detected. Proceed?", MessageBoxButtons.YesNo)
                                If QuestionPromptAnswer = 6 Then
                                    Dim saveFileDialog1 As New SaveFileDialog()

                                    saveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
                                    If saveFileDialog1.ShowDialog = DialogResult.OK Then
                                        My.Computer.FileSystem.WriteAllText(saveFileDialog1.FileName, Item_list, True)

                                        MktngItem_TODO = "SubClass_Delete"
                                        Start_MktngItemBGW()
                                    End If
                                End If

                            ElseIf sqlDataSet.Tables("QUERY_DETAILS").Rows.Count = 0 Then
                                KMDIPrompts(Me, "Question", "No hits detected. Proceed?", Nothing, Nothing, True)
                                If QuestionPromptAnswer = 6 Then
                                    MktngItem_TODO = "SubClass_Delete"
                                    Start_MktngItemBGW()
                                End If
                            End If
                            End_MktngItemBGW()

                        Case "Event_Insert"
                            Dim Chkbox As New MetroCheckBox
                            Select Case Cr8Control
                                Case True
                                    Chkbox_Properties("Static", Chkbox, EventStr, InsertedMIE_ID, 246,
                                                      Nothing, Mktng_Cmenu, MetroCheckBoxSize.Tall, False)
                                    Events_FLP.Controls.Add(Chkbox)
                                    AddHandler Chkbox.MouseDown, AddressOf CreatedControls_MouseDown
                            End Select
                            End_MktngItemBGW()

                        Case "Event_Update"
                            For Each ctrl In Events_FLP.Controls
                                If ctrl.Tag = EventID_toUpdate Then
                                    ctrl.Text = Replace(EventStr, "&", "&&")
                                    GlobalToolTip.SetToolTip(ctrl, ctrl.Text)
                                End If
                            Next
                            reset_here()
                            End_MktngItemBGW()

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
                            End_MktngItemBGW()

                        Case "Update_Item"
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("BRAND").Value = BRAND_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("DESCRIPTION").Value = ITEM_DESC_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("COLOR").Value = M_COLOR_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("SIZE").Value = M_SIZE_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("GENDER").Value = GENDER_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("MARKET PRICE").Value = MARKET_PRICE_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("PURCHASED PRICE").Value = PURCHASED_PRICE_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("DISCOUNT").Value = EffectiveDiscount
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("DATE PURCHASED").Value = PURCHASED_DATE_here
                            MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells("REMARKS").Value = REMARKS_here

                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                            End_MktngItemBGW()
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
            MainClassID_toUpdate = sender.Tag
            SubClass_FLP.Controls.Clear()
            MktngItem_TODO = "SubClass"
            Start_MktngItemBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Dim CreatedCtrlEditMode As String
    Private Sub CreatedControls_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            sender.Select
            If sender.Parent.Name = "MainClass_FLP" Then
                MainClassSTR = sender.Text
                MainClassID_toUpdate = sender.Tag
            ElseIf sender.Parent.Name = "SubClass_FLP" Then
                SubClassSTR = sender.Text
                SubClassID_toUpdate = sender.Tag
            ElseIf sender.Parent.Name = "Events_FLP" Then
                EventStr = sender.Text
                EventID_toUpdate = sender.Tag
            End If
            CreatedCtrlEditMode = sender.Parent.Name
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If CreatedCtrlEditMode = "MainClass_FLP" Then
                With MainClass_Tbox
                    .UseStyleColors = True
                    .Style = MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(MainClassSTR, "&&", "&")
                End With

            ElseIf CreatedCtrlEditMode = "SubClass_FLP" Then
                With SubClass_Tbox
                    .UseStyleColors = True
                    .Style = MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(SubClassSTR, "&&", "&")
                End With

            ElseIf CreatedCtrlEditMode = "Events_FLP" Then
                With Event_Tbox
                    .UseStyleColors = True
                    .Style = MetroColorStyle.Red
                    .CustomButton.Text = "U"
                    .Text = Replace(EventStr, "&&", "&")
                End With

            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            'KMDIPrompts(Me, "Question", "Are you sure you want to Delete?", Nothing, Nothing, True)
            'If QuestionPromptAnswer = 6 Then
            If CreatedCtrlEditMode = "MainClass_FLP" Then
                MktngItem_TODO = "Main_Class_Search_HIT"

            ElseIf CreatedCtrlEditMode = "SubClass_FLP" Then
                MktngItem_TODO = "Sub_Class_Search_HIT"

            ElseIf CreatedCtrlEditMode = "Events_FLP" Then

            End If
            Start_MktngItemBGW()
            'End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub MKTNG_Item_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) Then
                Save_Item()
            ElseIf e.KeyCode = Keys.Escape Then
                reset_here()
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
            If MainClass_Tbox.CustomButton.Text = "+" And MainClass_Tbox.Style = MetroColorStyle.Teal Then
                If MainClassSTR <> Nothing Or MainClassSTR <> "" Then
                    MktngItem_TODO = "MainClass_Insert"
                    Start_MktngItemBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", Nothing, Nothing, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf MainClass_Tbox.CustomButton.Text = "U" And MainClass_Tbox.Style = MetroColorStyle.Red Then
                If MainClassSTR <> Nothing Or MainClassSTR <> "" Then
                    If MainClassID_toUpdate <> Nothing Then
                        MktngItem_TODO = "MainClass_Update"
                        Start_MktngItemBGW()
                    Else
                        KMDIPrompts(Me, "UserWarning", "MainClassID_toUpdate is nothing", Nothing, Nothing, True, True, "Select Main Class")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "MainClassSTR is nothing", Nothing, Nothing, True, True, "Field cannot be empty")
                End If
            End If

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub SubClass_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles SubClass_Tbox.ButtonClick
        Try
            SubClassSTR = Trim(SubClass_Tbox.Text)
            If SubClass_Tbox.CustomButton.Text = "+" And SubClass_Tbox.Style = MetroColorStyle.Teal Then
                If SubClassSTR <> Nothing Or SubClassSTR <> "" Then
                    If MainClassID <> Nothing Then
                        MktngItem_TODO = "SubClass_Insert"
                        Start_MktngItemBGW()
                    Else
                        KMDIPrompts(Me, "UserWarning", "Main Class is nothing", Environment.StackTrace, Nothing, True, True, "Select Main Class")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "SubClass_Tbox is nothing", Environment.StackTrace, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf SubClass_Tbox.CustomButton.Text = "U" And SubClass_Tbox.Style = MetroColorStyle.Red Then
                If SubClassSTR <> Nothing Or SubClassSTR <> "" Then
                    If SubClassID_toUpdate <> Nothing Then
                        MktngItem_TODO = "SubClass_Update"
                        Start_MktngItemBGW()
                    Else
                        KMDIPrompts(Me, "UserWarning", "SubClassID_toUpdate is nothing", Nothing, Nothing, True, True, "Select Sub Class")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "SubClass_Tbox is nothing", Nothing, Nothing, True, True, "Field cannot be empty")
                End If
            End If

        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub Event_Tbox_ButtonClick(sender As Object, e As EventArgs) Handles Event_Tbox.ButtonClick
        Try
            EventStr = Trim(Event_Tbox.Text)
            If Event_Tbox.CustomButton.Text = "+" And Event_Tbox.Style = MetroColorStyle.Teal Then
                If EventStr <> Nothing Or EventStr <> "" Then
                    MktngItem_TODO = "Event_Insert"
                    Start_MktngItemBGW()
                Else
                    KMDIPrompts(Me, "UserWarning", "EventStr is nothing", Nothing, Nothing, True, True, "Field cannot be empty")
                End If
            ElseIf Event_Tbox.CustomButton.Text = "U" And Event_Tbox.Style = MetroColorStyle.Red Then
                If EventStr <> Nothing Or EventStr <> "" Then
                    If EventID_toUpdate <> Nothing Then
                        MktngItem_TODO = "Event_Update"
                        Start_MktngItemBGW()
                    Else
                        KMDIPrompts(Me, "UserWarning", "EventID_toUpdate is nothing", Nothing, Nothing, True, True, "Select Event")
                    End If
                Else
                    KMDIPrompts(Me, "UserWarning", "EventStr is nothing", Nothing, Nothing, True, True, "Field cannot be empty")
                End If
            End If
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
                MainClass_Tbox.CustomButton.PerformClick()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub SubClass_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SubClass_Tbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SubClass_Tbox.CustomButton.PerformClick()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub Event_Tbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Event_Tbox.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Event_Tbox.CustomButton.PerformClick()
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