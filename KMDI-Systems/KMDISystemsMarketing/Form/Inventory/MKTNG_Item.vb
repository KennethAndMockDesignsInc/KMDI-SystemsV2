Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Threading.Thread
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
    Dim Load_Update_bool,if_Generated_QR_Status As Boolean
    Dim EffectiveDiscount As Decimal = 0

    Public Sub Start_MktngItemBGW()
        If MktngItem_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            MktngItem_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub reset_here()
        ITEM_CODE = Nothing
        BRAND = Nothing
        ITEM_DESC = Nothing
        M_COLOR = Nothing
        M_SIZE = Nothing
        GENDER = Nothing
        MARKET_PRICE = Nothing
        PURCHASED_PRICE = Nothing
        QUANTITY = Nothing
        PURCHASED_DATE = Nothing
        REMARKS = Nothing
        ITEM_PICTURE = Nothing
    End Sub

    Sub Add_Item()
        ITEM_CODE = Trim(ItemCodeTbox.Text)
        BRAND = Trim(BrandTbox.Text)
        ITEM_DESC = Trim(ItemDesTbox.Text)
        M_COLOR = Trim(ColorTbox.Text)
        M_SIZE = Trim(SizeTbox.Text)
        GENDER = Trim(GenPrefCbox.Text)
        PURCHASED_DATE = PurchasedDate_dtp.Value
        Gift_bool = GiftPurpose_Chk.Checked
        Raffle_bool = RafflePurpose_Chk.Checked
        Tier1_bool = Tier1_Chk.Checked
        Tier2_bool = Tier2_Chk.Checked
        Tier3_bool = Tier3_Chk.Checked
        Tier4_bool = Tier4_Chk.Checked
        Tier5_bool = Tier5_Chk.Checked
        Tier6_bool = Tier6_Chk.Checked
        Tier7_bool = Tier7_Chk.Checked

        If MarketPriceTbox.Text <> "" Or MarketPriceTbox.Text <> Nothing Then
            MARKET_PRICE = Convert.ToDecimal(MarketPriceTbox.Text)
        Else
            MARKET_PRICE = Nothing
        End If
        If PurchasedPriceTbox.Text <> "" Or PurchasedPriceTbox.Text <> Nothing Then
            PURCHASED_PRICE = Convert.ToDecimal(PurchasedPriceTbox.Text)
        End If
        If MARKET_PRICE <> 0.0 Then
            EffectiveDiscount = (1 - (PURCHASED_PRICE / MARKET_PRICE)) * 100
        Else
            EffectiveDiscount = 0.0
        End If


        Dim tier_checked As Integer = 0
        Dim purpose_checked As Integer = 0
        Dim MainClass_Checked As Integer = 0
        Dim SubClass_Checked As Integer = 0
        Dim Event_Checked As Integer = 0

        For Each tier_chk In FRM_Pnl.Controls
            If tier_chk.Name.Contains("Tier") And tier_chk.Name.Contains("Chk") Then
                tier_checked += 1
            ElseIf tier_chk.Name.Contains("Purpose_Chk") Then
                purpose_checked += 1
            End If
        Next
        For Each MainClass_rbtn In MainClass_FLP.Controls
            If MainClass_rbtn.Checked = True Then
                MainClass_Checked += 1
                MIC_ID_REF = MainClass_rbtn.Tag
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

        If ITEM_CODE <> Nothing Or ITEM_CODE <> "" Then
            If BRAND <> Nothing Or BRAND <> "" Then
                If ITEM_DESC <> Nothing Or ITEM_DESC <> "" Then
                    If MARKET_PRICE <> 0.0 Then
                        If PurchasedPriceTbox.Text <> "" Or PurchasedPriceTbox.Text <> Nothing Then
                            If PURCHASED_DATE <> Nothing Or PURCHASED_DATE <> "" Then
                                If tier_checked > 0 Then
                                    If purpose_checked > 0 Then
                                        If MainClass_Checked > 0 Then
                                            If SubClass_Checked > 0 Then
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
                                            ElseIf SubClass_Checked = 0 Then
                                                KMDIPrompts(Me, "UserWarning", "SubClass_Checked is Empty", Environment.StackTrace, Nothing, True, True, "Sub Classification cannot be empty")
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
                    MarketPriceTbox.Text = MARKET_PRICE
                    PurchasedPriceTbox.Text = PURCHASED_PRICE
                    PurchasedDateTbox.Text = PURCHASED_DATE.ToString("MMM. dd, yyyy")
                    RemarksTbox.Text = REMARKS
                    If ItemCodeTbox.Text <> Nothing Or ItemCodeTbox.Text <> "" Then
                        ItemCodeTbox.Enabled = False
                    End If
            End Select
            'Start_MktngItemBGW()
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
                    MainClass_FLP.Controls.Clear()
                    Report_BGW_bool = True
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Item_MainClass")
                Case "SubClass"
                    SubClass_FLP.Controls.Clear()
                    Report_BGW_bool = True
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(MainClassID, "MKTNG_stp_Item_SubClass")
                Case "Load_Events"
                    Events_FLP.Controls.Clear()
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
                    Mktng_Inv_ItemInsert("MKTNG_stp_Inv_Item_Insert", ITEM_CODE, ITEM_DESC, GENDER, MARKET_PRICE, PURCHASED_PRICE,
                                         EffectiveDiscount, QUANTITY, PURCHASED_DATE, if_Generated_QR_Status, Gift_bool, Raffle_bool,
                                         Tier1_bool, Tier2_bool, Tier3_bool, Tier4_bool, Tier5_bool, Tier6_bool, Tier7_bool, MIC_ID_REF,
                                         Sub_Class_list, Events_list, M_COLOR, BRAND, M_SIZE, REMARKS)
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
            sql_err_bool = True
            MktngItem_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        End Try

        If MktngItem_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Public Sub MktngItem_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Try
            Select Case MktngItem_TODO
                Case "MainClass"
                    Dim ClassRbtn As New MetroFramework.Controls.MetroRadioButton
                    With ClassRbtn
                        .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MAIN_CLASS").ToString
                        .Text = .Name
                        .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MIC_ID").ToString
                        .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                        SubClassChkToolTip.SetToolTip(ClassRbtn, .Text)
                        AddHandler .Click, AddressOf ClassRbtn_Clicked
                        MainClass_FLP.Controls.Add(ClassRbtn)
                    End With
                Case "SubClass"
                    Dim SubClassChk As New MetroFramework.Controls.MetroCheckBox
                    With SubClassChk
                        .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("SUB_CLASS").ToString
                        .Text = .Name
                        .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MISC_ID").ToString
                        .FontSize = MetroFramework.MetroCheckBoxSize.Medium
                        SubClassChkToolTip.SetToolTip(SubClassChk, .Text)
                        SubClass_FLP.Controls.Add(SubClassChk)
                    End With
                Case "Load_Events"
                    Dim EventsChk As New MetroFramework.Controls.MetroCheckBox
                    With EventsChk
                        .Name = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("EVENT").ToString
                        .Text = .Name
                        .Tag = sqlDataSet.Tables("QUERY_DETAILS").Rows(e.ProgressPercentage).Item("MIE_ID").ToString
                        .Size = New Size(246, 25)
                        .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                        SubClassChkToolTip.SetToolTip(EventsChk, .Text)
                        Events_FLP.Controls.Add(EventsChk)
                    End With
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
                                arr_SubClassID.Add(row("MISC_ID"))
                                arr_EventID.Add(row("MIE_ID"))
                            Next
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()
                        Case "MainClass"
                            Report_BGW_bool = False
                            MktngItem_TODO = "Load_Events"
                            Start_MktngItemBGW()
                        Case "SubClass"
                            Report_BGW_bool = False
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
                        Case "MainClass_Insert"
                            MainClass_Tbox.Clear()
                            MktngItem_TODO = "MainClass"
                            Start_MktngItemBGW()
                        Case "SubClass_Insert"
                            SubClass_Tbox.Clear()
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()
                        Case "Load_Events"
                            Report_BGW_bool = False
                            Select Case OpenedByToolStripMenu
                                Case "UPDATE"
                                    MktngItem_TODO = "Load_Update_Item"
                                    Start_MktngItemBGW()
                                Case "ADD"
                                    MktngItem_TODO = "QR"
                                    Start_MktngItemBGW()
                            End Select
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
                        Case "Add_Item"
                            KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                    End Select
                Else
                    KMDIPrompts(Me, "Failed", "Failed in Inserting Item", Environment.StackTrace, Nothing, True)
                End If
            End If
            Mktng_SearchStr = Nothing
            RESET()
            LoadingPB.Visible = False
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub
    Private Sub ClassRbtn_Clicked(sender As Object, e As EventArgs)
        Try
            MainClassID = sender.Tag
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
                If MainClassSTR = Nothing Or MainClassSTR = "" Then
                    KMDIPrompts(Me, "DotNetError", Nothing, Nothing, Nothing, True, True, "Field cannot be empty")
                Else
                    MktngItem_TODO = "MainClass_Insert"
                End If
            Case "SUB"
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

    'Private Sub PurchasedPriceTbox_TextChanged(sender As Object, e As EventArgs) Handles PurchasedPriceTbox.TextChanged
    '    Try
    '        PURCHASED_PRICE = PurchasedPriceTbox.Text
    '        If PURCHASED_PRICE > MARKET_PRICE Then
    '            PurchasedPriceTbox.Text = MARKET_PRICE
    '        End If
    '        PurchasedPriceTbox.Text = PURCHASED_PRICE.ToString("N2")
    '    Catch ex As Exception
    '        KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
    '    End Try
    'End Sub

    'Private Sub MarketPriceTbox_TextChanged(sender As Object, e As EventArgs) Handles MarketPriceTbox.TextChanged
    '    Try
    '        MARKET_PRICE = MarketPriceTbox.Text
    '        MarketPriceTbox.Text = MARKET_PRICE.ToString("N2")
    '    Catch ex As Exception
    '        KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
    '    End Try
    'End Sub

    Private Sub Prices_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MarketPriceTbox.KeyPress, PurchasedPriceTbox.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar) And e.KeyChar <> "." And
                e.KeyChar <> ControlChars.Back) Then
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