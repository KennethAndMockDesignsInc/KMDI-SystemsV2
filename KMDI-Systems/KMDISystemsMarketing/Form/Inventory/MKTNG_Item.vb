Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class MKTNG_Item
    Public OpenedByToolStripMenu As String
    Public MktngItem_BGW As BackgroundWorker = New BackgroundWorker
    Public MktngItem_TODO As String
    Public Sub Start_MktngItemBGW()
        If MktngItem_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            MktngItem_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub MKTNG_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MktngItem_BGW.WorkerSupportsCancellation = True
        MktngItem_BGW.WorkerReportsProgress = True
        AddHandler MktngItem_BGW.DoWork, AddressOf MktngItem_BGW_DoWork
        AddHandler MktngItem_BGW.RunWorkerCompleted, AddressOf MktngItem_BGW_RunWorkerCompleted
        MktngItem_TODO = "MainClass"
        Start_MktngItemBGW()
    End Sub

    Private Sub MktngItem_BGW_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Select Case MktngItem_TODO
                Case "MainClass"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(Me, "1", "MKTNG_stp_Item_MainClass")
                Case "SubClass"
                    Mktng_QUERY_INSTANCE = "Loading_using_EqualSearch"
                    Mktng_Query_Select_STP(Me, Mktng_SearchStr, "MKTNG_stp_Item_SubClass")
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
                        Case "MainClass"
                            For Each row In sqlBindingSource
                                Dim ClassRbtn As New MetroFramework.Controls.MetroRadioButton
                                With ClassRbtn
                                    .Name = row("MAIN_CLASS")
                                    .Text = row("MAIN_CLASS")
                                    .Tag = row("MIC_ID")
                                    .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                                    AddHandler .CheckedChanged, AddressOf ClassRbtn_CheckedChanged
                                    MainClass_FLP.Controls.Add(ClassRbtn)
                                End With
                            Next
                        Case "SubClass"
                            For Each row In sqlBindingSource
                                Dim SubClassChk As New MetroFramework.Controls.MetroCheckBox
                                With SubClassChk
                                    .Name = row("SUB_CLASS")
                                    .Text = row("SUB_CLASS")
                                    .Tag = row("MICS_ID")
                                    .FontSize = MetroFramework.MetroCheckBoxSize.Tall
                                    'AddHandler .CheckedChanged, AddressOf ClassRbtn_CheckedChanged
                                    SubClass_FLP.Controls.Add(SubClassChk)
                                End With
                            Next
                    End Select
                End If
            End If
            RESET()
            LoadingPB.Visible = False
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, True)
        End Try
    End Sub
    Private Sub ClassRbtn_CheckedChanged(sender As Object, e As EventArgs)
        Mktng_SearchStr = sender.Tag
        MktngItem_TODO = "SubClass"
        Start_MktngItemBGW()
    End Sub

    Private Sub MKTNG_Item_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If (e.Control And e.KeyCode = Keys.S) Then
                MsgBox("Saved!")
            ElseIf e.KeyCode = Keys.Escape Then
                Close()
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
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
End Class