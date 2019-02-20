Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class MKTNG_AddQuantity
    Public MKTNG_AddQuantity_BGW As BackgroundWorker = New BackgroundWorker
    Dim Quantity_here As Integer
    Public Sub Start_MKTNG_AddQuantity_BGW()
        If MKTNG_AddQuantity_BGW.IsBusy <> True Then
            LoadingPB.Visible = True
            MKTNG_AddQuantity_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub MKTNG_AddQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MKTNG_AddQuantity_BGW.WorkerSupportsCancellation = True
        MKTNG_AddQuantity_BGW.WorkerReportsProgress = True
        AddHandler MKTNG_AddQuantity_BGW.DoWork, AddressOf MKTNG_AddQuantity_DoWork
        AddHandler MKTNG_AddQuantity_BGW.RunWorkerCompleted, AddressOf MKTNG_AddQuantity_RunWorkerCompleted
    End Sub
    Private Sub MKTNG_AddQuantity_DoWork(sender As Object, e As DoWorkEventArgs)
        Try
            Mktng_Inv_ItemUpdateQTY("MKTNG_stp_Inv_Item_UpdateQTY", MI_ID, Quantity_here)
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            'Dito ako naglagay ng SqlException dahil hindi makaCancel ang BGW sa ibang Class
            sql_err_bool = True
            MKTNG_AddQuantity_BGW.CancelAsync()
            KMDIPrompts(Me, "SqlError", ex.Message, ex.StackTrace, ex.Number, True)
            Try
                transaction.Rollback()
                sql_Transaction_result = "Rollback"
            Catch ex2 As Exception
                KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace)
            End Try
        End Try

        If MKTNG_AddQuantity_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub
    Private Sub MKTNG_AddQuantity_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Or e.Cancelled = True Then
                ' if BackgroundWorker terminated due to error
                LoadingPB.Visible = False
            Else
                If sql_Transaction_result = "Committed" Then
                    MKTNG_Inventory.Inv_DGV.Rows(INV_DGV_ROWINDEX).Cells(7).Value = NEW_QUANTITY
                    KMDIPrompts(Me, "Success", Nothing, Nothing, Nothing, True)
                    Me.Dispose()
                    OpenedByFormName.Enabled = True
                    OpenedByFormName.BringToFront()
                End If
            End If
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
        LoadingPB.Visible = False
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        Try
            Quantity_here = Val(QTYTbox.Text)
            Start_MKTNG_AddQuantity_BGW()
        Catch ex As Exception
            KMDIPrompts(Me, "DotNetError", ex.Message, ex.StackTrace, Nothing, True)
        End Try
    End Sub

    Private Sub QTYTbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles QTYTbox.KeyPress
        Try
            If (Not IsNumeric(e.KeyChar) And e.KeyChar <> "-" And
                e.KeyChar <> ControlChars.Back) Then
                e.Handled = True
                Throw New Exception()
            Else
                If sender.Text.IndexOf("-") >= 0 Then
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
            KMDIPrompts(Me, "UserWarning", "Invalid value", Environment.StackTrace, Nothing, True, True, "Numbers only")
        End Try
    End Sub

    Private Sub MKTNG_AddQuantity_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MKTNG_Inventory.Enabled = True
        MKTNG_Inventory.BringToFront()
        Dispose()
    End Sub
End Class