Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class PD_UpdateEMP
    Public PD_UpdateEMP_BGW As BackgroundWorker = New BackgroundWorker
    Dim PD_UpdateEMP_BGW_TODO As String = ""

    Public frm_open_thru As String

    Sub Start_PD_UpdateEMP_BGW()
        If PD_UpdateEMP_BGW.IsBusy <> True Then

            Emp_TabControl.Enabled = False
            LoadingPbox.Visible = True
            PD_UpdateEMP_BGW.RunWorkerAsync()
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please Wait!", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Sub reset()
        EmpAF_Tbox.Clear()
        EmpCPno_Tbox.Clear()
        EmpEmail_Tbox.Clear()
        EmpName_Tbox.Clear()
        EmpAFRel_Cbox.SelectedIndex = -1
        EmpAFType_Cbox.SelectedIndex = -1
        EmpGender_Cbox.SelectedIndex = -1
        EmpBday_DTP.Value = Now
    End Sub
    Private Sub PD_UpdateEMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PD_UpdateEMP_BGW.WorkerSupportsCancellation = True
        AddHandler PD_UpdateEMP_BGW.DoWork, AddressOf PD_UpdateEMP_BGW_DoWork
        AddHandler PD_UpdateEMP_BGW.RunWorkerCompleted, AddressOf PD_UpdateEMP_BGW_RunWorkerCompleted

        If frm_open_thru = "Add" Then
            reset()
            EmpName_Tbox.Focus()
        ElseIf frm_open_thru = "Update" Then
            PD_UpdateEMP_BGW_TODO = "POPULATE_FIELDS"
            Start_PD_UpdateEMP_BGW()
        End If
    End Sub

    Private Sub PD_UpdateEMP_BGW_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try
            If PD_UpdateEMP_BGW_TODO = "POPULATE_FIELDS" Then
                QUERY_INSTANCE = "Loading_using_EqualSearch"
                QueryBUILD = "SELECT * FROM [A_NEW_EMPLOYEE_DETAILS] WHERE [EMP_ID] = @EqualSearch"
                Query_Select(EMP_ID)
            ElseIf PD_UpdateEMP_BGW_TODO = "OPERATIONS_EMP" Then
                If frm_open_thru = "Add" Then
                    PD_UpdateEmp_Operations(Me, frm_open_thru, "", EmpName, EmpBday, EmpGender, EmpCPno, EmpEmail, EmpAF, EmpAFType,
                                            EmpAFRel)
                ElseIf frm_open_thru = "Update" Then
                    PD_UpdateEmp_Operations(Me, frm_open_thru, EMP_ID, EmpName, EmpBday, EmpGender, EmpCPno, EmpEmail, EmpAF, EmpAFType,
                                            EmpAFRel)
                End If
            End If
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PD_UpdateEMP_BGW.CancelAsync()
            ElseIf ex.Number = 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Sorry our server is under maintenance." & vbCrLf & "Please be patient, will come back A.S.A.P", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Error)
                PD_UpdateEMP_BGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 And ex.Number <> 19 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                PD_UpdateEMP_BGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MessageBox.Show(ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
    Dim EmpName, EmpCPno, EmpEmail, EmpAFRel, EmpAFType, EmpGender, EmpBday, EmpAF As String

    Private Sub EmpCPno_Tbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmpCPno_Tbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EmpAF_Tbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmpAF_Tbox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = 46 Then
            If EmpAF_Tbox.Text.Contains(".") = True Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If

    End Sub

    Private Sub Save_Btn_Click(sender As Object, e As EventArgs) Handles Save_Btn.Click
        EmpName = EmpName_Tbox.Text
        EmpAF = EmpAF_Tbox.Text
        EmpCPno = EmpCPno_Tbox.Text
        EmpEmail = EmpEmail_Tbox.Text
        EmpAFRel = EmpAFRel_Cbox.Text
        EmpAFType = EmpAFType_Cbox.Text
        EmpGender = EmpGender_Cbox.Text
        EmpBday = EmpBday_DTP.Value.ToShortDateString
        If EmpName <> Nothing And EmpAF <> Nothing And (EmpCPno <> Nothing OrElse EmpEmail <> Nothing) And
           EmpAFRel <> Nothing And EmpAFType <> Nothing And EmpGender <> Nothing Then
            If EmpEmail.Contains("@") And EmpEmail.Contains(".") Then
                PD_UpdateEMP_BGW_TODO = "OPERATIONS_EMP"
                Start_PD_UpdateEMP_BGW()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "Email is Invalid")
            End If
        Else
            MetroFramework.MetroMessageBox.Show(Me, "Please fill up the FIELDS!")
        End If
    End Sub

    Private Sub PD_UpdateEMP_BGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim rownum As Integer = sqlBindingSource.Count

                If PD_UpdateEMP_BGW_TODO = "POPULATE_FIELDS" Then
                    If rownum <> 0 Or rownum <> Nothing Then
                        For Each row In sqlBindingSource
                            EmpName = row("NAME")
                            EmpAF = row("AF")
                            EmpCPno = row("MOBILENO")
                            EmpEmail = row("EMAIL")
                            EmpAFRel = row("AFRELEASING")
                            EmpAFType = row("AFTYPE")
                            EmpGender = row("GENDER")
                            EmpBday = row("BIRTHDAY")
                        Next
                    End If
                    EmpName_Tbox.Text = EmpName
                    EmpAF_Tbox.Text = EmpAF
                    EmpCPno_Tbox.Text = EmpCPno
                    EmpEmail_Tbox.Text = EmpEmail
                    EmpAFRel_Cbox.Text = EmpAFRel
                    EmpAFType_Cbox.Text = EmpAFType
                    EmpGender_Cbox.Text = EmpGender
                    If EmpCPno <> Nothing Or EmpCPno <> "" Then

                    End If
                    If EmpBday = "" Or EmpBday = Nothing Then
                        EmpBday_DTP.Value = Now
                    Else
                        EmpBday_DTP.Value = EmpBday
                    End If
                ElseIf PD_UpdateEMP_BGW_TODO = "OPERATIONS_EMP" Then
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
            End If
            Emp_TabControl.Enabled = True
            LoadingPbox.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class