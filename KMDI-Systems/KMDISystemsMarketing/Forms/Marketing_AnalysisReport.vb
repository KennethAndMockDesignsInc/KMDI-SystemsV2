Imports System.Data.SqlClient
Public Class Marketing_AnalysisReport
    Sub StartOverallCP_BGW()
        If Header_BGW.IsBusy <> True Then
            Header_BGW.RunWorkerAsync()
        End If
    End Sub

    Public YearLookBack As String

    Sub YearCboxConfig()
        For i = 1997 To Now.Year - 1
            DateLookBackCbox.Items.Add(i)
        Next
        DateLookBackCbox.Text = Now.Year - 2
        YearLookBack = DateLookBackCbox.Text
    End Sub

    Private Sub Marketing_AnalysisReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toggle_Progressbar_Pnl.BorderStyle = Windows.Forms.BorderStyle.Fixed3D

        YearCboxConfig()

        StartOverallCP_BGW()

    End Sub

    Private Sub DisplaySqlErrors(ByVal exception As SqlException)
        Dim i As Integer

        For i = 0 To exception.Errors.Count - 1
            Console.WriteLine("Index #" & i & ControlChars.NewLine &
            "Error: " & exception.Errors(i).ToString() & ControlChars.NewLine _
            & "Message: " & exception.Errors(i).Message & ControlChars.NewLine _
                    & "Error Number: " & exception.Errors(i).Number & ControlChars.NewLine _
                    & "LineNumber: " & exception.Errors(i).LineNumber & ControlChars.NewLine _
                    & "Source: " & exception.Errors(i).Source & ControlChars.NewLine _
                    & "Procedure: " & exception.Errors(i).Procedure & ControlChars.NewLine)
        Next i
        Console.ReadLine()
    End Sub

    Private Sub OverallCP_BGW_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Header_BGW.DoWork

        Try
            Marketing_AnalysisReport_OverallInventory()
            Marketing_AnalysisReport_OverallCP(YearLookBack)
            AEIC_Monitoring()
            OTHERS_Monitoring()
            Marketing_AnalysisReport_OverallConsumedCP()
            SettedDate_Lbl_Updates()
        Catch ex As SqlException
            'DisplaySqlErrors(ex)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf ex.Number <> -2 And ex.Number <> 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            End If
        Catch ex2 As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex2.Message)
        Finally
            sqlcon.Close()
        End Try

        If Header_BGW.CancellationPending Then
            e.Cancel = True
        End If
    End Sub

    Private Sub OverallCP_BGW_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Header_BGW.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "I will Restart myself. Please wait", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Me.Show()
            ElseIf e.Cancelled Then

                '' otherwise if it was cancelled
                'MetroFramework.MetroMessageBox.Show(Me, "Please exit me", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                '' otherwise it completed normally
#Region "Header"
                OverallCP_lbl.Text = "- " & Format(OverallCPConsumed, "N2") & " / " & Format(OverallCP, "N2")
                Dim Blue_Legend_Max, Blue_Legend_Val As Integer
                Blue_Legend_Max = Math.Round(OverallCP)
                Blue_Legend_Val = Math.Round(OverallCPConsumed)
                Blue_Legend.Maximum = Blue_Legend_Max
                If Blue_Legend_Val > Blue_Legend_Max Then
                    Blue_Legend.Style = MetroFramework.MetroColorStyle.Red
                    Blue_Legend.Value = Blue_Legend_Max
                Else
                    Blue_Legend.Style = MetroFramework.MetroColorStyle.Blue
                    Blue_Legend.Value = Blue_Legend_Val
                End If

                BluePercentCP.Text = Math.Round((Blue_Legend_Val / Blue_Legend_Max) * 100, 2) & "% in Overall Credit Points"

                OverallInvQty_lbl.Text = "- " & OverallConsumedQty & " / " & TotalQty
                Green_Legend.Maximum = TotalQty
                If OverallConsumedQty > TotalQty Then
                    Green_Legend.Style = MetroFramework.MetroColorStyle.Red
                    Green_Legend.Value = TotalQty
                Else
                    Green_Legend.Style = MetroFramework.MetroColorStyle.Green
                    Green_Legend.Value = OverallConsumedQty
                End If
                GreenPercentInvQty.Text = Math.Round((OverallConsumedQty / TotalQty) * 100, 2) & "% in Overall Inventory Quantity"

                OverallInvTotalPrice_lbl.Text = "- " & Format(OverallCPConsumed, "N2") & " / " & Format(OverallInvPrice, "N2")
                Dim Lime_Legend_Max, Lime_Legend_Val As Integer
                Lime_Legend_Max = Math.Round(OverallInvPrice)
                Lime_Legend_Val = Math.Round(OverallCPConsumed)
                Lime_Legend.Maximum = Lime_Legend_Max
                If Lime_Legend_Val > Lime_Legend_Max Then
                    Lime_Legend.Style = MetroFramework.MetroColorStyle.Red
                    Lime_Legend.Value = Lime_Legend_Max
                Else
                    Lime_Legend.Style = MetroFramework.MetroColorStyle.Lime
                    Lime_Legend.Value = Lime_Legend_Val
                End If
                LimePercentInvPrice.Text = Math.Round((Lime_Legend_Val / Lime_Legend_Max) * 100, 2) & "% in Overall Inventory Total Price"
#End Region
#Region "Body"

#Region "BluePercent"
                If GCG_BPercent <> Nothing Or GCG_BPercent <> "" Then
                    GCG_BluePercent.Text = GCG_BPercent
                Else
                    GCG_BluePercent.Text = "0%"
                End If
                If JMC_BPercent <> Nothing Or JMC_BPercent <> "" Then
                    JMC_BluePercent.Text = JMC_BPercent
                Else
                    JMC_BluePercent.Text = "0%"
                End If
                If RLB_BPercent <> Nothing Or RLB_BPercent <> "" Then
                    RLB_BluePercent.Text = RLB_BPercent
                Else
                    RLB_BluePercent.Text = "0%"
                End If
                If WBB_BPercent <> Nothing Or WBB_BPercent <> "" Then
                    WBB_BluePercent.Text = WBB_BPercent
                Else
                    WBB_BluePercent.Text = "0%"
                End If
                If AOS_BPercent <> Nothing Or AOS_BPercent <> "" Then
                    AOS_BluePercent.Text = AOS_BPercent
                Else
                    AOS_BluePercent.Text = "0%"
                End If
                If CCA_BPercent <> Nothing Or CCA_BPercent <> "" Then
                    CCA_BluePercent.Text = CCA_BPercent
                Else
                    CCA_BluePercent.Text = "0%"
                End If
                If JLS_BPercent <> Nothing Or JLS_BPercent <> "" Then
                    JLS_BluePercent.Text = JLS_BPercent
                Else
                    JLS_BluePercent.Text = "0%"
                End If
                If DLN_BPercent <> Nothing Or DLN_BPercent <> "" Then
                    DLN_BluePercent.Text = DLN_BPercent
                Else
                    DLN_BluePercent.Text = "0%"
                End If
                If MLM_BPercent <> Nothing Or MLM_BPercent <> "" Then
                    MLM_BluePercent.Text = MLM_BPercent
                Else
                    MLM_BluePercent.Text = "0%"
                End If
                If LLA_BPercent <> Nothing Or LLA_BPercent <> "" Then
                    LLA_BluePercent.Text = LLA_BPercent
                Else
                    LLA_BluePercent.Text = "0%"
                End If
                If RRE_BPercent <> Nothing Or RRE_BPercent <> "" Then
                    RRE_BluePercent.Text = RRE_BPercent
                Else
                    RRE_BluePercent.Text = "0%"
                End If
                If JMV_BPercent <> Nothing Or JMV_BPercent <> "" Then
                    JMV_BluePercent.Text = JMV_BPercent
                Else
                    JMV_BluePercent.Text = "0%"
                End If
                Others_BluePercent.Text = Others_BPercent

                Others_Blue.Maximum = OverallCP
                If MarketingModule.Others_Blue > OverallCP Then
                    Others_Blue.Style = MetroFramework.MetroColorStyle.Red
                    Others_Blue.Value = OverallCP
                    Others_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    Others_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    Others_Blue.Value = MarketingModule.Others_Blue
                    Others_Blue_Lbl.Text = Format(MarketingModule.Others_Blue, "N2")
                End If

                GCG_Blue.Maximum = OverallCP
                If MarketingModule.GCG_Blue > OverallCP Then
                    GCG_Blue.Style = MetroFramework.MetroColorStyle.Red
                    GCG_Blue.Value = OverallCP
                    GCG_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    GCG_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    GCG_Blue.Value = MarketingModule.GCG_Blue
                    GCG_Blue_Lbl.Text = Format(MarketingModule.GCG_Blue, "N2")
                End If

                JMC_Blue.Maximum = OverallCP
                If MarketingModule.JMC_Blue > OverallCP Then
                    JMC_Blue.Style = MetroFramework.MetroColorStyle.Red
                    JMC_Blue.Value = OverallCP
                    JMC_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    JMC_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    JMC_Blue.Value = MarketingModule.JMC_Blue
                    JMC_Blue_Lbl.Text = Format(MarketingModule.JMC_Blue, "N2")
                End If

                RLB_Blue.Maximum = OverallCP
                If MarketingModule.RLB_Blue > OverallCP Then
                    RLB_Blue.Style = MetroFramework.MetroColorStyle.Red
                    RLB_Blue.Value = OverallCP
                    RLB_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    RLB_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    RLB_Blue.Value = MarketingModule.RLB_Blue
                    RLB_Blue_Lbl.Text = Format(MarketingModule.RLB_Blue, "N2")
                End If

                WBB_Blue.Maximum = OverallCP
                If MarketingModule.WBB_Blue > OverallCP Then
                    WBB_Blue.Style = MetroFramework.MetroColorStyle.Red
                    WBB_Blue.Value = OverallCP
                    WBB_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    WBB_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    WBB_Blue.Value = MarketingModule.WBB_Blue
                    WBB_Blue_Lbl.Text = Format(MarketingModule.WBB_Blue, "N2")
                End If

                AOS_Blue.Maximum = OverallCP
                If MarketingModule.AOS_Blue > OverallCP Then
                    AOS_Blue.Style = MetroFramework.MetroColorStyle.Red
                    AOS_Blue.Value = OverallCP
                    AOS_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    AOS_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    AOS_Blue.Value = MarketingModule.AOS_Blue
                    AOS_Blue_Lbl.Text = Format(MarketingModule.AOS_Blue, "N2")
                End If

                CCA_Blue.Maximum = OverallCP
                If MarketingModule.CCA_Blue > OverallCP Then
                    CCA_Blue.Style = MetroFramework.MetroColorStyle.Red
                    CCA_Blue.Value = OverallCP
                    CCA_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    CCA_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    CCA_Blue.Value = MarketingModule.CCA_Blue
                    CCA_Blue_Lbl.Text = Format(MarketingModule.CCA_Blue, "N2")
                End If

                JLS_Blue.Maximum = OverallCP
                If MarketingModule.JLS_Blue > OverallCP Then
                    JLS_Blue.Style = MetroFramework.MetroColorStyle.Red
                    JLS_Blue.Value = OverallCP
                    JLS_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    JLS_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    JLS_Blue.Value = MarketingModule.JLS_Blue
                    JLS_Blue_Lbl.Text = Format(MarketingModule.JLS_Blue, "N2")
                End If

                DLN_Blue.Maximum = OverallCP
                If MarketingModule.DLN_Blue > OverallCP Then
                    DLN_Blue.Style = MetroFramework.MetroColorStyle.Red
                    DLN_Blue.Value = OverallCP
                    DLN_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    DLN_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    DLN_Blue.Value = MarketingModule.DLN_Blue
                    DLN_Blue_Lbl.Text = Format(MarketingModule.DLN_Blue, "N2")
                End If

                MLM_Blue.Maximum = OverallCP
                If MarketingModule.MLM_Blue > OverallCP Then
                    MLM_Blue.Style = MetroFramework.MetroColorStyle.Red
                    MLM_Blue.Value = OverallCP
                    MLM_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    MLM_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    MLM_Blue.Value = MarketingModule.MLM_Blue
                    MLM_Blue_Lbl.Text = Format(MarketingModule.MLM_Blue, "N2")
                End If

                LLA_Blue.Maximum = OverallCP
                If MarketingModule.LLA_Blue > OverallCP Then
                    LLA_Blue.Style = MetroFramework.MetroColorStyle.Red
                    LLA_Blue.Value = OverallCP
                    LLA_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    LLA_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    LLA_Blue.Value = MarketingModule.LLA_Blue
                    LLA_Blue_Lbl.Text = Format(MarketingModule.MLM_Blue, "N2")
                End If

                RRE_Blue.Maximum = OverallCP
                If MarketingModule.RRE_Blue > OverallCP Then
                    RRE_Blue.Style = MetroFramework.MetroColorStyle.Red
                    RRE_Blue.Value = OverallCP
                    RRE_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    RRE_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    RRE_Blue.Value = MarketingModule.RRE_Blue
                    RRE_Blue_Lbl.Text = Format(MarketingModule.RRE_Blue, "N2")
                End If

                JMV_Blue.Maximum = OverallCP
                If MarketingModule.JMV_Blue > OverallCP Then
                    JMV_Blue.Style = MetroFramework.MetroColorStyle.Red
                    JMV_Blue.Value = OverallCP
                    JMV_Blue_Lbl.Text = Format(OverallCP, "N2")
                Else
                    JMV_Blue.Style = MetroFramework.MetroColorStyle.Blue
                    JMV_Blue.Value = MarketingModule.JMV_Blue
                    JMV_Blue_Lbl.Text = Format(MarketingModule.JMV_Blue, "N2")
                End If

#End Region
#Region "GreenPercent"
                If GCG_GPercent <> Nothing Or GCG_GPercent <> "" Then
                    GCG_GreenPercent.Text = GCG_GPercent
                Else
                    GCG_GreenPercent.Text = "0%"
                End If
                If JMC_GPercent <> Nothing Or JMC_GPercent <> "" Then
                    JMC_GreenPercent.Text = JMC_GPercent
                Else
                    JMC_GreenPercent.Text = "0%"
                End If
                If RLB_GPercent <> Nothing Or RLB_GPercent <> "" Then
                    RLB_GreenPercent.Text = RLB_GPercent
                Else
                    RLB_GreenPercent.Text = "0%"
                End If
                If WBB_GPercent <> Nothing Or WBB_GPercent <> "" Then
                    WBB_GreenPercent.Text = WBB_GPercent
                Else
                    WBB_GreenPercent.Text = "0%"
                End If
                If AOS_GPercent <> Nothing Or AOS_GPercent <> "" Then
                    AOS_GreenPercent.Text = AOS_GPercent
                Else
                    AOS_GreenPercent.Text = "0%"
                End If
                If CCA_GPercent <> Nothing Or CCA_GPercent <> "" Then
                    CCA_GreenPercent.Text = CCA_GPercent
                Else
                    CCA_GreenPercent.Text = "0%"
                End If
                If JLS_GPercent <> Nothing Or JLS_GPercent <> "" Then
                    JLS_GreenPercent.Text = JLS_GPercent
                Else
                    JLS_GreenPercent.Text = "0%"
                End If
                If DLN_GPercent <> Nothing Or DLN_GPercent <> "" Then
                    DLN_GreenPercent.Text = DLN_GPercent
                Else
                    DLN_GreenPercent.Text = "0%"
                End If
                If MLM_GPercent <> Nothing Or MLM_GPercent <> "" Then
                    MLM_GreenPercent.Text = MLM_GPercent
                Else
                    MLM_GreenPercent.Text = "0%"
                End If
                If LLA_GPercent <> Nothing Or LLA_GPercent <> "" Then
                    LLA_GreenPercent.Text = LLA_GPercent
                Else
                    LLA_GreenPercent.Text = "0%"
                End If
                If RRE_GPercent <> Nothing Or RRE_GPercent <> "" Then
                    RRE_GreenPercent.Text = RRE_GPercent
                Else
                    RRE_GreenPercent.Text = "0%"
                End If
                If JMV_GPercent <> Nothing Or JMV_GPercent <> "" Then
                    JMV_GreenPercent.Text = JMV_GPercent
                Else
                    JMV_GreenPercent.Text = "0%"
                End If
                Others_GreenPercent.Text = Others_GPercent

                Others_Green.Maximum = TotalQty
                If MarketingModule.Others_Green > TotalQty Then
                    Others_Green.Style = MetroFramework.MetroColorStyle.Red
                    Others_Green.Value = TotalQty
                    Others_Green_Lbl.Text = TotalQty
                Else
                    Others_Green.Style = MetroFramework.MetroColorStyle.Green
                    Others_Green.Value = MarketingModule.Others_Green
                    Others_Green_Lbl.Text = MarketingModule.Others_Green
                End If

                GCG_Green.Maximum = TotalQty
                If MarketingModule.GCG_Green > TotalQty Then
                    GCG_Green.Style = MetroFramework.MetroColorStyle.Red
                    GCG_Green.Value = TotalQty
                    GCG_Green_Lbl.Text = TotalQty
                Else
                    GCG_Green.Style = MetroFramework.MetroColorStyle.Green
                    GCG_Green.Value = MarketingModule.GCG_Green
                    GCG_Green_Lbl.Text = MarketingModule.GCG_Green
                End If

                JMC_Green.Maximum = TotalQty
                If MarketingModule.JMC_Green > TotalQty Then
                    JMC_Green.Style = MetroFramework.MetroColorStyle.Red
                    JMC_Green.Value = TotalQty
                    JMC_Green_Lbl.Text = TotalQty
                Else
                    JMC_Green.Style = MetroFramework.MetroColorStyle.Green
                    JMC_Green.Value = MarketingModule.JMC_Green
                    JMC_Green_Lbl.Text = MarketingModule.JMC_Green
                End If

                RLB_Green.Maximum = TotalQty
                If MarketingModule.RLB_Green > TotalQty Then
                    RLB_Green.Style = MetroFramework.MetroColorStyle.Red
                    RLB_Green.Value = TotalQty
                    RLB_Green_Lbl.Text = TotalQty
                Else
                    RLB_Green.Style = MetroFramework.MetroColorStyle.Green
                    RLB_Green.Value = MarketingModule.RLB_Green
                    RLB_Green_Lbl.Text = MarketingModule.RLB_Green
                End If

                WBB_Green.Maximum = TotalQty
                If MarketingModule.WBB_Green > TotalQty Then
                    WBB_Green.Style = MetroFramework.MetroColorStyle.Red
                    WBB_Green.Value = TotalQty
                    WBB_Green_Lbl.Text = TotalQty
                Else
                    WBB_Green.Style = MetroFramework.MetroColorStyle.Green
                    WBB_Green.Value = MarketingModule.WBB_Green
                    WBB_Green_Lbl.Text = MarketingModule.WBB_Green
                End If

                AOS_Green.Maximum = TotalQty
                If MarketingModule.AOS_Green > TotalQty Then
                    AOS_Green.Style = MetroFramework.MetroColorStyle.Red
                    AOS_Green.Value = TotalQty
                    AOS_Green_Lbl.Text = TotalQty
                Else
                    AOS_Green.Style = MetroFramework.MetroColorStyle.Green
                    AOS_Green.Value = MarketingModule.AOS_Green
                    AOS_Green_Lbl.Text = MarketingModule.AOS_Green
                End If

                CCA_Green.Maximum = TotalQty
                If MarketingModule.CCA_Green > TotalQty Then
                    CCA_Green.Style = MetroFramework.MetroColorStyle.Red
                    CCA_Green.Value = TotalQty
                    CCA_Green_Lbl.Text = TotalQty
                Else
                    CCA_Green.Style = MetroFramework.MetroColorStyle.Green
                    CCA_Green.Value = MarketingModule.CCA_Green
                    CCA_Green_Lbl.Text = MarketingModule.CCA_Green
                End If

                JLS_Green.Maximum = TotalQty
                If MarketingModule.JLS_Green > TotalQty Then
                    JLS_Green.Style = MetroFramework.MetroColorStyle.Red
                    JLS_Green.Value = TotalQty
                    JLS_Green_Lbl.Text = TotalQty
                Else
                    JLS_Green.Style = MetroFramework.MetroColorStyle.Green
                    JLS_Green.Value = MarketingModule.JLS_Green
                    JLS_Green_Lbl.Text = MarketingModule.JLS_Green
                End If

                DLN_Green.Maximum = TotalQty
                If MarketingModule.DLN_Green > TotalQty Then
                    DLN_Green.Style = MetroFramework.MetroColorStyle.Red
                    DLN_Green.Value = TotalQty
                    DLN_Green_Lbl.Text = TotalQty
                Else
                    DLN_Green.Style = MetroFramework.MetroColorStyle.Green
                    DLN_Green.Value = MarketingModule.DLN_Green
                    DLN_Green_Lbl.Text = MarketingModule.DLN_Green
                End If

                MLM_Green.Maximum = TotalQty
                If MarketingModule.MLM_Green > TotalQty Then
                    MLM_Green.Style = MetroFramework.MetroColorStyle.Red
                    MLM_Green.Value = TotalQty
                    MLM_Green_Lbl.Text = TotalQty
                Else
                    MLM_Green.Style = MetroFramework.MetroColorStyle.Green
                    MLM_Green.Value = MarketingModule.MLM_Green
                    MLM_Green_Lbl.Text = MarketingModule.MLM_Green
                End If

                LLA_Green.Maximum = TotalQty
                If MarketingModule.LLA_Green > TotalQty Then
                    LLA_Green.Style = MetroFramework.MetroColorStyle.Red
                    LLA_Green.Value = TotalQty
                    LLA_Green_Lbl.Text = TotalQty
                Else
                    LLA_Green.Style = MetroFramework.MetroColorStyle.Green
                    LLA_Green.Value = MarketingModule.LLA_Green
                    LLA_Green_Lbl.Text = MarketingModule.LLA_Green
                End If

                RRE_Green.Maximum = TotalQty
                If MarketingModule.RRE_Green > TotalQty Then
                    RRE_Green.Style = MetroFramework.MetroColorStyle.Red
                    RRE_Green.Value = TotalQty
                    RRE_Green_Lbl.Text = TotalQty
                Else
                    RRE_Green.Style = MetroFramework.MetroColorStyle.Green
                    RRE_Green.Value = MarketingModule.RRE_Green
                    RRE_Green_Lbl.Text = MarketingModule.RRE_Green
                End If

                JMV_Green.Maximum = TotalQty
                If MarketingModule.JMV_Green > TotalQty Then
                    JMV_Green.Style = MetroFramework.MetroColorStyle.Red
                    JMV_Green.Value = TotalQty
                    JMV_Green_Lbl.Text = TotalQty
                Else
                    JMV_Green.Style = MetroFramework.MetroColorStyle.Green
                    JMV_Green.Value = MarketingModule.JMV_Green
                    JMV_Green_Lbl.Text = MarketingModule.JMV_Green
                End If

#End Region
#Region "LimePercent"
                If GCG_LPercent <> Nothing Or GCG_LPercent <> "" Then
                    GCG_LimePercent.Text = GCG_LPercent
                Else
                    GCG_LimePercent.Text = "0%"
                End If
                If JMC_LPercent <> Nothing Or JMC_LPercent <> "" Then
                    JMC_LimePercent.Text = JMC_LPercent
                Else
                    JMC_LimePercent.Text = "0%"
                End If
                If RLB_LPercent <> Nothing Or RLB_LPercent <> "" Then
                    RLB_LimePercent.Text = RLB_LPercent
                Else
                    RLB_LimePercent.Text = "0%"
                End If
                If WBB_LPercent <> Nothing Or WBB_LPercent <> "" Then
                    WBB_LimePercent.Text = WBB_LPercent
                Else
                    WBB_LimePercent.Text = "0%"
                End If
                If AOS_LPercent <> Nothing Or AOS_LPercent <> "" Then
                    AOS_LimePercent.Text = AOS_LPercent
                Else
                    AOS_LimePercent.Text = "0%"
                End If
                If CCA_LPercent <> Nothing Or CCA_LPercent <> "" Then
                    CCA_LimePercent.Text = CCA_LPercent
                Else
                    CCA_LimePercent.Text = "0%"
                End If
                If JLS_LPercent <> Nothing Or JLS_LPercent <> "" Then
                    JLS_LimePercent.Text = JLS_LPercent
                Else
                    JLS_LimePercent.Text = "0%"
                End If
                If DLN_LPercent <> Nothing Or DLN_LPercent <> "" Then
                    DLN_LimePercent.Text = DLN_LPercent
                Else
                    DLN_LimePercent.Text = "0%"
                End If
                If MLM_LPercent <> Nothing Or MLM_LPercent <> "" Then
                    MLM_LimePercent.Text = MLM_LPercent
                Else
                    MLM_LimePercent.Text = "0%"
                End If
                If LLA_LPercent <> Nothing Or LLA_LPercent <> "" Then
                    LLA_LimePercent.Text = LLA_LPercent
                Else
                    LLA_LimePercent.Text = "0%"
                End If
                If RRE_LPercent <> Nothing Or RRE_LPercent <> "" Then
                    RRE_LimePercent.Text = RRE_LPercent
                Else
                    RRE_LimePercent.Text = "0%"
                End If
                If JMV_LPercent <> Nothing Or JMV_LPercent <> "" Then
                    JMV_LimePercent.Text = JMV_LPercent
                Else
                    JMV_LimePercent.Text = "0%"
                End If
                Others_LimePercent.Text = Others_LPercent

                Others_Lime.Maximum = OverallInvPrice
                If MarketingModule.Others_Lime > OverallInvPrice Then
                    Others_Lime.Style = MetroFramework.MetroColorStyle.Red
                    Others_Lime.Value = OverallInvPrice
                    Others_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    Others_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    Others_Lime.Value = MarketingModule.Others_Lime
                    Others_Lime_Lbl.Text = Format(MarketingModule.Others_Lime, "N2")
                End If

                GCG_Lime.Maximum = OverallInvPrice
                If MarketingModule.GCG_Lime > OverallInvPrice Then
                    GCG_Lime.Style = MetroFramework.MetroColorStyle.Red
                    GCG_Lime.Value = OverallInvPrice
                    GCG_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    GCG_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    GCG_Lime.Value = MarketingModule.GCG_Lime
                    GCG_Lime_Lbl.Text = Format(MarketingModule.GCG_Lime, "N2")
                End If

                JMC_Lime.Maximum = OverallInvPrice
                If MarketingModule.JMC_Lime > OverallInvPrice Then
                    JMC_Lime.Style = MetroFramework.MetroColorStyle.Red
                    JMC_Lime.Value = OverallInvPrice
                    JMC_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    JMC_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    JMC_Lime.Value = MarketingModule.JMC_Lime
                    JMC_Lime_Lbl.Text = Format(MarketingModule.JMC_Lime, "N2")
                End If

                RLB_Lime.Maximum = OverallInvPrice
                If MarketingModule.RLB_Lime > OverallInvPrice Then
                    RLB_Lime.Style = MetroFramework.MetroColorStyle.Red
                    RLB_Lime.Value = OverallInvPrice
                    RLB_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    RLB_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    RLB_Lime.Value = MarketingModule.RLB_Lime
                    RLB_Lime_Lbl.Text = Format(MarketingModule.RLB_Lime, "N2")
                End If

                WBB_Lime.Maximum = OverallInvPrice
                If MarketingModule.WBB_Lime > OverallInvPrice Then
                    WBB_Lime.Style = MetroFramework.MetroColorStyle.Red
                    WBB_Lime.Value = OverallInvPrice
                    WBB_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    WBB_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    WBB_Lime.Value = MarketingModule.WBB_Lime
                    WBB_Lime_Lbl.Text = Format(MarketingModule.WBB_Lime, "N2")
                End If

                AOS_Lime.Maximum = OverallInvPrice
                If MarketingModule.AOS_Lime > OverallInvPrice Then
                    AOS_Lime.Style = MetroFramework.MetroColorStyle.Red
                    AOS_Lime.Value = OverallInvPrice
                    AOS_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    AOS_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    AOS_Lime.Value = MarketingModule.AOS_Lime
                    AOS_Lime_Lbl.Text = Format(MarketingModule.AOS_Lime, "N2")
                End If

                CCA_Lime.Maximum = OverallInvPrice
                If MarketingModule.CCA_Lime > OverallInvPrice Then
                    CCA_Lime.Style = MetroFramework.MetroColorStyle.Red
                    CCA_Lime.Value = OverallInvPrice
                    CCA_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    CCA_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    CCA_Lime.Value = MarketingModule.CCA_Lime
                    CCA_Lime_Lbl.Text = Format(MarketingModule.CCA_Lime, "N2")
                End If

                JLS_Lime.Maximum = OverallInvPrice
                If MarketingModule.JLS_Lime > OverallInvPrice Then
                    JLS_Lime.Style = MetroFramework.MetroColorStyle.Red
                    JLS_Lime.Value = OverallInvPrice
                    JLS_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    JLS_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    JLS_Lime.Value = MarketingModule.JLS_Lime
                    JLS_Lime_Lbl.Text = Format(MarketingModule.JLS_Lime, "N2")
                End If

                DLN_Lime.Maximum = OverallInvPrice
                If MarketingModule.DLN_Lime > OverallInvPrice Then
                    DLN_Lime.Style = MetroFramework.MetroColorStyle.Red
                    DLN_Lime.Value = OverallInvPrice
                    DLN_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    DLN_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    DLN_Lime.Value = MarketingModule.DLN_Lime
                    DLN_Lime_Lbl.Text = Format(MarketingModule.DLN_Lime, "N2")
                End If

                MLM_Lime.Maximum = OverallInvPrice
                If MarketingModule.MLM_Lime > OverallInvPrice Then
                    MLM_Lime.Style = MetroFramework.MetroColorStyle.Red
                    MLM_Lime.Value = OverallInvPrice
                    MLM_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    MLM_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    MLM_Lime.Value = MarketingModule.MLM_Lime
                    MLM_Lime_Lbl.Text = Format(MarketingModule.MLM_Lime, "N2")
                End If

                LLA_Lime.Maximum = OverallInvPrice
                If MarketingModule.LLA_Lime > OverallInvPrice Then
                    LLA_Lime.Style = MetroFramework.MetroColorStyle.Red
                    LLA_Lime.Value = OverallInvPrice
                    LLA_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    LLA_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    LLA_Lime.Value = MarketingModule.LLA_Lime
                    LLA_Lime_Lbl.Text = Format(MarketingModule.LLA_Lime, "N2")
                End If

                RRE_Lime.Maximum = OverallInvPrice
                If MarketingModule.RRE_Lime > OverallInvPrice Then
                    RRE_Lime.Style = MetroFramework.MetroColorStyle.Red
                    RRE_Lime.Value = OverallInvPrice
                    RRE_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    RRE_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    RRE_Lime.Value = MarketingModule.RRE_Lime
                    RRE_Lime_Lbl.Text = Format(MarketingModule.RRE_Lime, "N2")
                End If

                JMV_Lime.Maximum = OverallInvPrice
                If MarketingModule.JMV_Lime > OverallInvPrice Then
                    JMV_Lime.Style = MetroFramework.MetroColorStyle.Red
                    JMV_Lime.Value = OverallInvPrice
                    JMV_Lime_Lbl.Text = Format(OverallInvPrice, "N2")
                Else
                    JMV_Lime.Style = MetroFramework.MetroColorStyle.Lime
                    JMV_Lime.Value = MarketingModule.JMV_Lime
                    JMV_Lime_Lbl.Text = Format(MarketingModule.JMV_Lime, "N2")
                End If

#End Region

#End Region
                SettedDate_Lbl.Text = "Current year set: " & SettedDate
                StartOverallCP_BGW()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DateLookBackCbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles DateLookBackCbox.SelectionChangeCommitted
        YearLookBack = DateLookBackCbox.Text
        StartOverallCP_BGW()
    End Sub

    Private Sub Marketing_AnalysisReport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MetroFramework.MetroMessageBox.Show(Me, "Are you sure you want to QUIT?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
            If Header_BGW.IsBusy Then
                Header_BGW.CancelAsync()
                e.Cancel = False
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Toggle_List_Pnl_Click(sender As Object, e As EventArgs) Handles Toggle_List_Pnl.Click
        Toggle_List_Pnl.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        Toggle_Progressbar_Pnl.BorderStyle = Windows.Forms.BorderStyle.None

        Dim ctl As Control
        Dim pnlctl As MetroFramework.Controls.MetroPanel

        For Each pnlctl In B4Frm_FLP.Controls

            If pnlctl.Name.Contains("_Pnl") Then
                For Each ctl In pnlctl.Controls
                    If ctl.Name.EndsWith("Blue_Lbl") Then ctl.Visible = True
                    If ctl.Name.EndsWith("Green_Lbl") Then ctl.Visible = True
                    If ctl.Name.EndsWith("Lime_Lbl") Then ctl.Visible = True

                    If ctl.Name.EndsWith("_Blue") Then ctl.Visible = False
                    If ctl.Name.EndsWith("_Green") Then ctl.Visible = False
                    If ctl.Name.EndsWith("_Lime") Then ctl.Visible = False
                Next ctl
            End If

        Next pnlctl
    End Sub

    Private Sub Toggle_Progressbar_Pnl_Click(sender As Object, e As EventArgs) Handles Toggle_Progressbar_Pnl.Click
        Toggle_Progressbar_Pnl.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        Toggle_List_Pnl.BorderStyle = Windows.Forms.BorderStyle.None

        Dim ctl As Control
        Dim pnlctl As MetroFramework.Controls.MetroPanel

        For Each pnlctl In B4Frm_FLP.Controls

            If pnlctl.Name.Contains("_Pnl") Then
                For Each ctl In pnlctl.Controls
                    If ctl.Name.EndsWith("Blue_Lbl") Then ctl.Visible = False
                    If ctl.Name.EndsWith("Green_Lbl") Then ctl.Visible = False
                    If ctl.Name.EndsWith("Lime_Lbl") Then ctl.Visible = False

                    If ctl.Name.EndsWith("_Blue") Then ctl.Visible = True
                    If ctl.Name.EndsWith("_Green") Then ctl.Visible = True
                    If ctl.Name.EndsWith("_Lime") Then ctl.Visible = True
                Next ctl

            End If

        Next pnlctl
    End Sub

    Public MAC_Text As String = "Individual Analysis "

    Sub MAC_Show(ByVal MAC_IndiText As String,
                 ByVal TotalCPConsumed_Text As String,
                 ByVal AE_IDh As Integer,
                 ByVal AEorOthersH As Boolean)

        AEorOthers = AEorOthersH
        AE_ID = AE_IDh
        With Marketing_IndiSales_Analysis

            If AE_ID = 0 Then
                .Text = MAC_Text
            ElseIf AE_ID <> 0 Then
                .Text = MAC_Text & "of " & MAC_IndiText
            End If
            .TotalCPConsumed_lbl.Text = "Overall Total Credit Points Consumed: " & TotalCPConsumed_Text
            .Show()
        End With
    End Sub

    Private Sub Others_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles Others_Lbl.DoubleClick
        MAC_Show(Others_Lbl.Text, Others_Blue_Lbl.Text, 0, False)
    End Sub

    Private Sub GCG_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles GCG_Lbl.DoubleClick
        MAC_Show(GCG_Lbl.Text, GCG_Blue_Lbl.Text, 31, True)
    End Sub

    Private Sub JMC_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles JMC_Lbl.DoubleClick
        MAC_Show(JMC_Lbl.Text, JMC_Blue_Lbl.Text, 82, True)
    End Sub

    Private Sub RLB_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles RLB_Lbl.DoubleClick
        MAC_Show(RLB_Lbl.Text, RLB_Blue_Lbl.Text, 64, True)
    End Sub

    Private Sub WBB_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles WBB_Lbl.DoubleClick
        MAC_Show(WBB_Lbl.Text, WBB_Blue_Lbl.Text, 80, True)
    End Sub

    Private Sub AOS_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles AOS_Lbl.DoubleClick
        MAC_Show(AOS_Lbl.Text, AOS_Blue_Lbl.Text, 54, True)
    End Sub

    Private Sub CCA_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles CCA_Lbl.DoubleClick
        MAC_Show(CCA_Lbl.Text, CCA_Blue_Lbl.Text, 81, True)
    End Sub

    Private Sub JLS_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles JLS_Lbl.DoubleClick
        MAC_Show(JLS_Lbl.Text, JLS_Blue_Lbl.Text, 85, True)
    End Sub

    Private Sub DLN_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles DLN_Lbl.DoubleClick
        MAC_Show(DLN_Lbl.Text, DLN_Blue_Lbl.Text, 50, True)
    End Sub

    Private Sub MLM_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles MLM_Lbl.DoubleClick
        MAC_Show(MLM_Lbl.Text, MLM_Blue_Lbl.Text, 84, True)
    End Sub

    Private Sub LLA_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles LLA_Lbl.DoubleClick
        MAC_Show(LLA_Lbl.Text, LLA_Blue_Lbl.Text, 86, True)
    End Sub

    Private Sub RRE_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles RRE_Lbl.DoubleClick
        MAC_Show(RRE_Lbl.Text, RRE_Blue_Lbl.Text, 68, True)
    End Sub

    Private Sub JMV_Lbl_DoubleClick(sender As Object, e As EventArgs) Handles JMV_Lbl.DoubleClick
        MAC_Show(JMV_Lbl.Text, JMV_Blue_Lbl.Text, 83, True)
    End Sub

    Private Sub Set_Btn_Click(sender As Object, e As EventArgs) Handles Set_Btn.Click
        If MetroFramework.MetroMessageBox.Show(Me, "Set this as Start Year?", "Setting Year", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            GIFT_DATELOOKBACK_UPDATE(DateLookBackCbox.Text & "-07-01")
        End If
    End Sub
End Class