Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class MKTNG_Item
    Public OpenedByToolStripMenu As String
    Public MktngItem_BGW As BackgroundWorker = New BackgroundWorker
    Dim SubClassChkToolTip As New MetroFramework.Components.MetroToolTip
    Public MktngItem_TODO As String
    Dim MainClassSTR, SubClassSTR As String
    Public Sub Start_MktngItemBGW()
        If MktngItem_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            MktngItem_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub MKTNG_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MktngItem_BGW.WorkerSupportsCancellation = True
            MktngItem_BGW.WorkerReportsProgress = True
            AddHandler MktngItem_BGW.DoWork, AddressOf MktngItem_BGW_DoWork
            AddHandler MktngItem_BGW.RunWorkerCompleted, AddressOf MktngItem_BGW_RunWorkerCompleted
            Select Case OpenedByToolStripMenu
                Case "ADD"
                    MktngItem_TODO = "MainClass"
                Case "UPDATE"
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
            End Select
            Start_MktngItemBGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MktngItem_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MktngItem_TODO
                Case "Update_Item"
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
    Private Sub MktngItem_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                ' if BackgroundWorker terminated due to error
                LoadingPB.Visible = False
            Else
                '' otherwise it completed normally
                If sql_Transaction_result = "Committed" Then
                    Select Case MktngItem_TODO
                        Case "Update_Item"
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

                                Dim main_class As String = row("MAIN_CLASS")

                                For Each rbtn In MainClass_FLP.Controls
                                    If rbtn.Name = main_class Then
                                        rbtn.PerformClick
                                    End If
                                Next

                                Dim sub_class As String = row("SUB_CLASS")
                                MsgBox(sub_class)
                                For Each chkbtn In SubClass_FLP.Controls
                                    If chkbtn.Name = sub_class Then
                                        chkbtn.Checked = True
                                    End If
                                Next
                            Next
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
                            Select Case OpenedByToolStripMenu
                                Case "UPDATE"
                                    MktngItem_TODO = "Update_Item"
                                    Start_MktngItemBGW()
                            End Select
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
                        Case "MainClass_Insert"
                            MainClass_Tbox.Clear()
                            MktngItem_TODO = "MainClass"
                            Start_MktngItemBGW()
                        Case "SubClass_Insert"
                            SubClass_Tbox.Clear()
                            MktngItem_TODO = "SubClass"
                            Start_MktngItemBGW()
                    End Select
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
        Mktng_SearchStr = Nothing
        RESET()
        LoadingPB.Visible = False
    End Sub
    Dim MainClassID As Integer
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
                MsgBox("Saved!")
            ElseIf e.KeyCode = Keys.Escape Then
                Close()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub MKTNG_Item_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to Exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
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
End Class