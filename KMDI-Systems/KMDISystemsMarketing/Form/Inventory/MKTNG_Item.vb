Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class MKTNG_Item
    Public OpenedByToolStripMenu As String
    Public MktngItem_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngItem_TODO As String
    Dim SubClassChkToolTip As New MetroFramework.Components.MetroToolTip
    Dim MainClassSTR, SubClassSTR, QRCode, max_MI As String
    Dim MainClassID As Integer
    Dim arr_SubClassID As New List(Of Integer) '//MISC_ID
    Dim arr_EventID As New List(Of Integer) '//MIE_ID
    Dim Load_Update_bool,if_Generated_QR_Status As Boolean

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

    Sub Save_Item()
        ITEM_CODE = Trim(ItemCodeTbox.Text)
        BRAND = Trim(BrandTbox.Text)
        ITEM_DESC = Trim(ItemDesTbox.Text)
        M_COLOR = Trim(ColorTbox.Text)
        M_SIZE = Trim(SizeTbox.Text)
        GENDER = Trim(GenPrefCbox.Text)
        MARKET_PRICE = Trim(MarketPriceTbox.Text)
        PURCHASED_PRICE = Trim(PurchasedPriceTbox.Text)
        PURCHASED_DATE = Trim(PurchasedDateTbox.Text)
    End Sub

    Private Sub MKTNG_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MktngItem_BGW.WorkerSupportsCancellation = True
            MktngItem_BGW.WorkerReportsProgress = True
            AddHandler MktngItem_BGW.DoWork, AddressOf MktngItem_BGW_DoWork
            AddHandler MktngItem_BGW.ProgressChanged, AddressOf MktngItem_BGW_ProgressChanged
            AddHandler MktngItem_BGW.RunWorkerCompleted, AddressOf MktngItem_BGW_RunWorkerCompleted
            Select Case OpenedByToolStripMenu
                Case "ADD"
                    MktngItem_TODO = "MainClass"
                Case "UPDATE"
                    reset_here()
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
            Start_MktngItemBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MktngItem_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MktngItem_TODO
                Case "Load_Update_Item"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(MI_ID, "MKTNG_stp_Inv_FetchItem")
                Case "MainClass"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Item_MainClass")
                Case "SubClass"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(MainClassID, "MKTNG_stp_Item_SubClass")
                Case "MainClass_Insert"
                    Mktng_MainClass_Insert(MainClassSTR, "MKTNG_stp_Item_MainClass_Insert")
                Case "SubClass_Insert"
                    Mktng_SubClass_Insert(SubClassSTR, MainClassID, "MKTNG_stp_Item_SubClass_Insert")
                Case "Load_Events"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Inv_Events")
                Case "QR"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP("1", "MKTNG_stp_Inv_MAXID")
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

    Private Sub MktngItem_BGW_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)

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

                                Gift_Chk.Checked = row("GIFT")
                                Raffle_Chk.Checked = row("RAFFLE")

                                MainClassID = row("MIC_ID")
                                arr_SubClassID.Add(row("MISC_ID"))
                                arr_EventID.Add(row("MIE_ID"))
                            Next
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()
                        Case "MainClass"
                            MainClass_FLP.Controls.Clear()
                            For Each row In sqlBindingSource
                                Dim ClassRbtn As New MetroFramework.Controls.MetroRadioButton
                                With ClassRbtn
                                    .Name = row("MAIN_CLASS")
                                    .Text = row("MAIN_CLASS")
                                    .Tag = row("MIC_ID")
                                    .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                                    SubClassChkToolTip.SetToolTip(ClassRbtn, .Text)
                                    AddHandler .Click, AddressOf ClassRbtn_Clicked
                                    MainClass_FLP.Controls.Add(ClassRbtn)
                                End With
                            Next
                            MktngItem_TODO = "Load_Events"
                            Start_MktngItemBGW()
                        Case "SubClass"
                            SubClass_FLP.Controls.Clear()
                            For Each row In sqlBindingSource
                                Dim SubClassChk As New MetroFramework.Controls.MetroCheckBox
                                With SubClassChk
                                    .Name = row("SUB_CLASS")
                                    .Text = row("SUB_CLASS")
                                    .Tag = row("MISC_ID")
                                    .FontSize = MetroFramework.MetroCheckBoxSize.Medium
                                    SubClassChkToolTip.SetToolTip(SubClassChk, .Text)
                                    SubClass_FLP.Controls.Add(SubClassChk)
                                End With
                            Next
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
                            Events_FLP.Controls.Clear()
                            For Each row In sqlBindingSource
                                Dim EventsChk As New MetroFramework.Controls.MetroCheckBox
                                With EventsChk
                                    .Name = row("EVENT")
                                    .Text = row("EVENT")
                                    .Tag = row("MIE_ID")
                                    .Size = New Size(246, 25)
                                    .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                                    SubClassChkToolTip.SetToolTip(EventsChk, .Text)
                                    Events_FLP.Controls.Add(EventsChk)
                                End With
                            Next
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
                    End Select
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
                Save_Item()
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