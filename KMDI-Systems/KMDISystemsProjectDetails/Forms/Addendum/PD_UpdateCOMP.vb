Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class PD_UpdateCOMP
    Public PD_UpdateCOMP_BGW As BackgroundWorker = New BackgroundWorker
    Dim PD_UpdateCOMP_BGW_TODO As String = ""

    Public frm_open_thru As String

    Sub Start_PD_UpdateCOMP_BGW()
        If PD_UpdateCOMP_BGW.IsBusy <> True Then

            Comp_TabControl.Enabled = False
            LoadingPbox.Visible = True
            PD_UpdateCOMP_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub reset()
        CompName_Tbox.Clear()
        CompAddress_Tbox.Clear()
        CompCPno_Tbox.Clear()
        CompSec_Tbox.Clear()
        CompRemarks_Tbox.Clear()
    End Sub

    Private Sub PD_UpdateCOMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PD_UpdateCOMP_BGW.WorkerSupportsCancellation = True
        AddHandler PD_UpdateCOMP_BGW.DoWork, AddressOf PD_UpdateCOMP_BGW_DoWork
        AddHandler PD_UpdateCOMP_BGW.RunWorkerCompleted, AddressOf PD_UpdateCOMP_BGW_RunWorkerCompleted

        If frm_open_thru = "Add" Then
            Reset()
            CompName_Tbox.Focus()
        ElseIf frm_open_thru = "Update" Then
            PD_UpdateCOMP_BGW_TODO = "POPULATE_FIELDS"
            Start_PD_UpdateCOMP_BGW()
        End If
    End Sub

    Private Sub PD_UpdateCOMP_BGW_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try
            If PD_UpdateCOMP_BGW_TODO = "POPULATE_FIELDS" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = "SELECT * FROM [A_NEW_COMPANY_DETAILS] WHERE [COMP_ID] = @EqualSearch"
                Query_Select(COMP_ID)
            ElseIf PD_UpdateCOMP_BGW_TODO = "OPERATIONS_EMP" Then
                If frm_open_thru = "Add" Then
                    PD_UpdateComp_Operations(Me, frm_open_thru, "", CompName, CompAddress, CompCPNO, CompSec, CompRemarks)
                ElseIf frm_open_thru = "Update" Then
                    PD_UpdateComp_Operations(Me, frm_open_thru, COMP_ID, CompName, CompAddress, CompCPNO, CompSec, CompRemarks)
                End If
            End If
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PD_UpdateCOMP_BGW.CancelAsync()
            ElseIf ex.Number = 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PD_UpdateCOMP_BGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                PD_UpdateCOMP_BGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MessageBox.Show(ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Dim CompName, CompAddress, CompCPNO, CompSec, CompRemarks As String

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        CompName = CompName_Tbox.Text
        CompAddress = CompAddress_Tbox.Text
        CompCPNO = CompCPno_Tbox.Text
        CompSec = CompSec_Tbox.Text
        CompRemarks = CompRemarks_Tbox.Text

        PD_UpdateCOMP_BGW_TODO = "OPERATIONS_EMP"
        Start_PD_UpdateCOMP_BGW()
    End Sub

    Private Sub CompCPno_Tbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompCPno_Tbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PD_UpdateCOMP_BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rownum As Integer = sqlBindingSource.Count

                If PD_UpdateCOMP_BGW_TODO = "POPULATE_FIELDS" Then
                    If rownum <> 0 Or rownum <> Nothing Then
                        For Each row In sqlBindingSource
                            CompName = row("OFFICENAME")
                            CompAddress = row("OFFICEADDRESS")
                            CompCPNO = row("CONTACTNO")
                            CompSec = row("OFFICEASSISTANT")
                            CompRemarks = row("REMARKS")
                        Next
                    End If
                    CompName_Tbox.Text = CompName
                    CompAddress_Tbox.Text = CompAddress
                    CompCPno_Tbox.Text = CompCPNO
                    CompSec_Tbox.Text = CompSec
                    CompRemarks_Tbox.Text = CompRemarks

                ElseIf PD_UpdateCOMP_BGW_TODO = "OPERATIONS_EMP" Then
                    If PD_CountSuccess = 1 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        PD_CountSuccess = 0
                        If frm_open_thru = "Add" Then
                            reset()
                        ElseIf frm_open_thru = "Update" Then
                            PD_TechPartners.PD_TechPartners_BGW_TODO = "POSITION"
                            PD_TechPartners.Start_PD_TechPartners_BGW()
                            PD_TechPartners.BringToFront()
                            Me.Close()
                        End If
                    End If
                End If

                Comp_TabControl.Enabled = True
                LoadingPbox.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class