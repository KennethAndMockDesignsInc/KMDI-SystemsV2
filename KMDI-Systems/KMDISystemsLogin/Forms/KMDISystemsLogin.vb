Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class KMDISystemsLogin

    Private Sub KMDISystemsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDISystemsLogin_AccessPoint = "192.168.1.21,49107"
        ConnectionTypeCbox.SelectedIndex = 0
        MaximizeBox = False
    End Sub
    Public Sub Login()
        KMDISystems_Login_SERVER("KMDIDATA")
        LoginType = "Fresh"
        DBnameCboxSelectedIndex = 0
        PrevDBnameCboxSelectedIndex = 0
        KMDISystems_Login(KMDISystems_UserName,
                          KMDISystems_Password)
    End Sub

    Private Sub ConnectionTypeCbox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ConnectionTypeCbox.SelectionChangeCommitted
        If ConnectionTypeCbox.SelectedIndex = 0 Then
            KMDISystemsLogin_AccessPoint = "192.168.1.21,49107"
        ElseIf ConnectionTypeCbox.SelectedIndex = 1 Then
            KMDISystemsLogin_AccessPoint = "121.58.229.248,49107"
        End If
    End Sub

    Private Sub UserNameTbox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTbox.TextChanged
        KMDISystems_UserName = UserNameTbox.Text
    End Sub

    Private Sub PasswordTbox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTbox.TextChanged
        KMDISystems_Password = PasswordTbox.Text
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If Login_BGW.IsBusy <> True Then
            Loading_Pnl.Visible = True
            Login_Pnl.Visible = False
            ConnectionTypeCbox.Enabled = False
            UserNameTbox.Enabled = False
            PasswordTbox.Enabled = False
            Login_BGW.RunWorkerAsync()
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub ConnectionTypeCbox_Enter(sender As Object, e As EventArgs) Handles ConnectionTypeCbox.Enter
        ConnectionTypeLbl.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub ConnectionTypeCbox_Leave(sender As Object, e As EventArgs) Handles ConnectionTypeCbox.Leave
        ConnectionTypeLbl.ForeColor = Color.White
    End Sub

    Private Sub UserNameTbox_Enter(sender As Object, e As EventArgs) Handles UserNameTbox.Enter
        UserNameLbl.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub UserNameTbox_Leave(sender As Object, e As EventArgs) Handles UserNameTbox.Leave
        UserNameLbl.ForeColor = Color.White
    End Sub

    Private Sub PasswordTbox_Enter(sender As Object, e As EventArgs) Handles PasswordTbox.Enter
        PasswordLbl.ForeColor = Color.DeepSkyBlue
    End Sub

    Private Sub PasswordTbox_Leave(sender As Object, e As EventArgs) Handles PasswordTbox.Leave
        PasswordLbl.ForeColor = Color.White
    End Sub

    Private Sub Login_BGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles Login_BGW.DoWork

        Try
            KMDISystems_UserName = Trim(KMDISystems_UserName)
            KMDISystems_Password = Trim(KMDISystems_Password)
            If KMDISystems_UserName = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Login_BGW.CancelAsync()
            ElseIf KMDISystems_Password = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Login_BGW.CancelAsync()
            Else
                Login()
            End If
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroFramework.MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                LoginBtn.PerformClick()
            ElseIf ex.Number = 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Please check internet connection", "Network Disconnected?", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Login_BGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 Then
                MetroFramework.MetroMessageBox.Show(Me, "Contact the Programmers now", "You need some help?", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Login_BGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

        If Login_BGW.CancellationPending = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Login_BGW_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Login_BGW.RunWorkerCompleted
        Try

            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroFramework.MetroMessageBox.Show(Me, "Error Occured", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                Loading_Pnl.Visible = False
                Login_Pnl.Visible = True
                ConnectionTypeCbox.Enabled = True
                UserNameTbox.Enabled = True
                PasswordTbox.Enabled = True
            Else
                '' otherwise it completed normally
                If AccountAutonum <> "" Or AccountAutonum IsNot Nothing Or AccountAutonum <> Nothing Then
                    If AccountType = "Admin" Then
                        With KMDI_MainFRM
                            .Show()
                            .DbNameCbox.Items.Clear()
                            .DbNameCbox.Items.Insert(0, "KMDIDATA")
                            .DbNameCbox.Items.Insert(1, "HAUSERDB")
                            .DbNameCbox.Items.Insert(2, "HERETOSAVE")
                            .DbNameCbox.Items.Insert(3, "KMDI_Systems")
                            .DbNameCbox.SelectedIndex = DBnameCboxSelectedIndex
                        End With
                    Else
                        With KMDI_MainFRM
                            .Show()
                            .DbNameCbox.Items.Clear()
                            .DbNameCbox.Items.Insert(0, "KMDIDATA")
                            .DbNameCbox.Items.Insert(1, "HAUSERDB")
                            .DbNameCbox.Items.Insert(2, "KMDI_Systems")
                            .DbNameCbox.SelectedIndex = DBnameCboxSelectedIndex
                        End With
                    End If
                    If LoginType = "Fresh" Then
                        Me.Hide()
                    ElseIf LoginType = "Relog" Then
                    End If
                Else
                    With KMDI_MainFRM
                        MetroFramework.MetroMessageBox.Show(Me, "Login failed! Please Try again", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        If Application.OpenForms().OfType(Of KMDI_MainFRM).Any Then

                            .DbNameCbox.SelectedIndex = PrevDBnameCboxSelectedIndex

                            KMDISystems_Login_SERVER(.DbNameCbox.Text)
                            LoginType = "Relog"
                            DBnameCboxSelectedIndex = .DbNameCbox.SelectedIndex
                            PrevDBnameCboxSelectedIndex = .PrevDBNameCboxSelectedIndex

                            KMDISystems_Login(KMDISystems_UserName,
                                              KMDISystems_Password)
                        End If

                    End With
                End If
                Loading_Pnl.Visible = False
                Login_Pnl.Visible = True
                ConnectionTypeCbox.Enabled = True
                UserNameTbox.Enabled = True
                PasswordTbox.Enabled = True

            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
End Class
