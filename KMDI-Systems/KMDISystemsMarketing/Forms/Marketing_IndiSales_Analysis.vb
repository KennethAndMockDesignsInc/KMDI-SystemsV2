Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class Marketing_IndiSales_Analysis

    Public Sub LoadingPBOX_LBL_VISIBILITY(ByVal Visibility As Boolean)
        LoadingPBOX.Enabled = Visibility
        Loading_Pnl.Visible = Visibility
        LoadingPBOX.Visible = Visibility
        LoadingLBL.Visible = Visibility
    End Sub

    Public YearLookBack As String
    Sub YearCboxConfig()
        For i = 1997 To Now.Year
            DateLookBackCbox.Items.Add(i)
        Next
        DateLookBackCbox.Text = Now.Year
        YearLookBack = DateLookBackCbox.Text
    End Sub
    Sub StartAE_Requested_BGW()
        If AE_Requested_BGW.IsBusy <> True Then
            AE_Requested.Columns.Clear()
            AE_Requested.DataSource = Nothing
            AE_Requested.DataMember = Nothing
            AE_Requested_BGW.RunWorkerAsync()
        End If
    End Sub
    Private Sub Marketing_IndiSales_Analysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YearCboxConfig()
        Mode_Selector.SelectedIndex = 0
        ModeSelected = "Regular"

        LoadingPBOX_LBL_VISIBILITY(True)
        StartAE_Requested_BGW()
    End Sub

    Private Sub AE_Requested_BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles AE_Requested_BGW.DoWork
        Try
            Individual_Analysis(ModeSelected, AE_ID, DLBCbox_Year, AEorOthers)
            TotalCPConsumedhere_Lbl_Updates(ModeSelected, AE_ID, DLBCbox_Year, AEorOthers)
        Catch ex As SqlException
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoadingPBOX_LBL_VISIBILITY(False)
                StartAE_Requested_BGW()
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AE_Requested_BGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                AE_Requested_BGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex2.Message)
        Finally
            'sqlcon.Close()
        End Try

        If AE_Requested_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub AE_Requested_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles AE_Requested_BGW.RunWorkerCompleted
        Try
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                LoadingPBOX.Enabled = False
                LoadingLBL.Text = "Error Occured"
            ElseIf e.Cancelled Then
                '' otherwise if it was cancelled
                LoadingPBOX.Enabled = False
                LoadingLBL.Text = "An error occured"
            Else
                '' otherwise it completed normally
                With AE_Requested
                    .DataSource = sqlbs 'sqlbs_INDI
                    .DefaultCellStyle.BackColor = Color.White
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    .Visible = True
                    If AE_ID <> 0 Then
                        .Columns("Sales name").Visible = False
                    End If
                    For i = 0 To .Columns.Count - 1
                        .Columns(i).Width = 200
                    Next
                End With
                TotalCPConsumedhere_lbl.Text = "Total Credit Points Consumed: " & Format(TotalCPConsumedhere_Lbld, "N2")

                LoadingPBOX_LBL_VISIBILITY(False)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public DLBCbox_Year As String = Now.Year.ToString

    Private Sub DateLookBackCbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DateLookBackCbox.SelectionChangeCommitted
        DLBCbox_Year = DateLookBackCbox.Text
        StartAE_Requested_BGW()
    End Sub

    Dim ModeSelected As String

    Private Sub Mode_Selector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Mode_Selector.SelectedIndexChanged
        If Mode_Selector.SelectedIndex = 0 Then
            ModeSelected = "Regular"
        ElseIf Mode_Selector.SelectedIndex = 1 Then
            ModeSelected = "Raffle"
        ElseIf Mode_Selector.SelectedIndex = 2 Then
            ModeSelected = "Special"
        End If
        LoadingPBOX_LBL_VISIBILITY(True)
        StartAE_Requested_BGW()
    End Sub

End Class