Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class PD_PertDetails

    Public PD_PertDetails_BGW As BackgroundWorker = New BackgroundWorker

    Dim BGW_TASK As String
    Dim MAIN_CATEGORY As String
    Sub Start_PD_PertDetails_BGW()
        If PD_PertDetails_BGW.IsBusy <> True Then
            LoadingPbox.Visible = True
            PD_PertDetails_BGW.RunWorkerAsync()
        End If
    End Sub
    Private Sub PD_PertDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BGW_TASK = "MainCategory_Cbox"
        QueryBUILD = SelDist & " CATEGORY from KMDI_ADDINFO_TB"

        AddHandler PD_PertDetails_BGW.DoWork, AddressOf PD_PertDetails_BGW_DoWork
        AddHandler PD_PertDetails_BGW.RunWorkerCompleted, AddressOf PD_PertDetails_BGW_RunWorkerCompleted
        Start_PD_PertDetails_BGW()
    End Sub

    Private Sub PD_PertDetails_BGW_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs)
        Try
            If BGW_TASK = "MainCategory_Cbox" Then
                Query_Select(SearchStr)
            ElseIf BGW_TASK = "SubCategory_Cbox" Then
                QueryBUILD = SelDist & " VALUE from KMDI_ADDINFO_TB  WHERE TYPE= 'A' AND CATEGORY = '" & MAIN_CATEGORY & "'"
                Query_Select("")
            ElseIf BGW_TASK = "Value_Cbox" Then
                QueryBUILD = SelDist & " VALUE from KMDI_ADDINFO_TB  WHERE TYPE= 'B' AND CATEGORY = '" & MAIN_CATEGORY & "'"
                Query_Select("")
            End If
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PD_PertDetails_BGW.CancelAsync()
            ElseIf ex.Number = 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PD_PertDetails_BGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                PD_PertDetails_BGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub PD_PertDetails_BGW_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs)
        Try

            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadingPbox.Visible = True
            Else
                '' otherwise it completed normally
                If BGW_TASK = "MainCategory_Cbox" Then
                    MainCategory_Cbox.DataBindings.Clear()
                    MainCategory_Cbox.DataSource = sqlBindingSource
                    MainCategory_Cbox.ValueMember = "CATEGORY"
                ElseIf BGW_TASK = "SubCategory_Cbox" Then
                    SubCategory_Cbox.DataBindings.Clear()
                    SubCategory_Cbox.DataSource = sqlBindingSource
                    SubCategory_Cbox.ValueMember = "VALUE"

                    BGW_TASK = "Value_Cbox"
                    Start_PD_PertDetails_BGW()
                ElseIf BGW_TASK = "Value_Cbox" Then
                    SubCategory_Cbox2.DataBindings.Clear()
                    SubCategory_Cbox2.DataSource = sqlBindingSource
                    SubCategory_Cbox2.ValueMember = "VALUE"
                End If
                LoadingPbox.Visible = False
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub

    Private Sub MainCategory_Cbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MainCategory_Cbox.SelectionChangeCommitted
        MAIN_CATEGORY = MainCategory_Cbox.Text
        BGW_TASK = "SubCategory_Cbox"
        Start_PD_PertDetails_BGW()
    End Sub

    Dim COUNT_ADD As Integer = 0
    Dim SubCategory_Cbox_INITIAL_STRING_LENGTH,
        SubCategory_Cbox_SUCCEDING_STRING_LENGTH As Integer
    Dim STR_LENGTH_PERCENTAGE As Decimal
    Private Sub AddPert_Btn_Click(sender As Object, e As EventArgs) Handles AddPert_Btn.Click
        COUNT_ADD += 1
        If COUNT_ADD = 1 Then
            SubCategory_Cbox_INITIAL_STRING_LENGTH = SubCategory_Cbox.Text.Length
            If SubCategory_Cbox_INITIAL_STRING_LENGTH <= 7 Then
                SubCategory_Cbox_INITIAL_STRING_LENGTH = 17
            End If
            PertDetails_RTbox.Text += SubCategory_Cbox.Text & vbTab & vbTab
        ElseIf COUNT_ADD > 1 Then
            SubCategory_Cbox_SUCCEDING_STRING_LENGTH = SubCategory_Cbox.Text.Length
            STR_LENGTH_PERCENTAGE = SubCategory_Cbox_SUCCEDING_STRING_LENGTH / SubCategory_Cbox_INITIAL_STRING_LENGTH

            PertDetails_RTbox.Text += SubCategory_Cbox.Text

            Dim tab_count As Integer = 1

            If STR_LENGTH_PERCENTAGE <= 0.3 Then
                tab_count = 4
            ElseIf STR_LENGTH_PERCENTAGE > 0.3 And STR_LENGTH_PERCENTAGE <= 0.8 Then
                tab_count = 3
            ElseIf STR_LENGTH_PERCENTAGE > 0.8 And STR_LENGTH_PERCENTAGE <= 1.2 Then
                tab_count = 2
            Else
                tab_count = 1
            End If

            For i = 1 To tab_count
                PertDetails_RTbox.Text += vbTab
            Next
        End If
        PertDetails_RTbox.Text += SubCategory_Cbox2.Text & vbCrLf & vbCrLf

    End Sub

    Private Sub SavePert_Btn_Click(sender As Object, e As EventArgs) Handles SavePert_Btn.Click
        PD_SalesJobOrder.PertDetails_RTbox.Text = PertDetails_RTbox.Text
        Me.Close()
    End Sub
End Class