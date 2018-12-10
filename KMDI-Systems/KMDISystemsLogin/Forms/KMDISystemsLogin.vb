Imports System.ComponentModel
Imports System.Data.SqlClient
Imports MetroFramework

Public Class KMDISystemsLogin

    Public LoginBGW As BackgroundWorker = New BackgroundWorker
    Private Sub KMDISystemsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AddHandler LoginBGW.DoWork, AddressOf LoginBGW_DoWork
            AddHandler LoginBGW.RunWorkerCompleted, AddressOf LoginBGW_RunWorkerCompleted
            'AddHandler LoginBGW.ProgressChanged, AddressOf LoginBGW_ProgressChanged
            KMDISystemsLogin_AccessPoint = "121.58.229.248,49107"
            MaximizeBox = False
            UserName_TBX.ForeColor = Color.FromArgb(17, 17, 17)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UserNameTbox_TextChanged(sender As Object, e As EventArgs) Handles UserName_TBX.TextChanged
        Try
            KMDISystems_UserName = UserName_TBX.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PasswordTbox_TextChanged(sender As Object, e As EventArgs) Handles Password_TBX.TextChanged
        Try
            KMDISystems_Password = Password_TBX.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            StartWorker()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs)
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub StartWorker()
        Try
            If LoginBGW.IsBusy <> True Then
                KMDISystems_UserName = Trim(KMDISystems_UserName)
                KMDISystems_Password = Trim(KMDISystems_Password)
                Select Case KMDISystems_UserName
                    Case ""
                        Login_TTP.Show("Username is required", UserName_TBX)
                        Exit Sub
                    Case Nothing
                        Login_TTP.Show("Username is required", UserName_TBX)
                        Exit Sub
                    Case Else
                        Select Case KMDISystems_Password
                            Case ""
                                Login_TTP.Show("Password is required", Password_TBX)
                                Exit Sub
                            Case Nothing
                                Login_TTP.Show("Password is required", Password_TBX)
                                Exit Sub
                            Case Else
                                LoginBtn.Visible = False
                                LoadingPBOX.Visible = True
                                UserName_TBX.Enabled = False
                                Password_TBX.Enabled = False
                                LoginBGW.WorkerReportsProgress = True
                                LoginBGW.WorkerSupportsCancellation = True
                                LoginBGW.RunWorkerAsync()
                        End Select
                End Select

            Else
                MetroMessageBox.Show(Me, "System is gathering information.", "Please wait for a moment", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoginBGW_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Try

            Select Case LoginBGW.CancellationPending
                Case True
                    e.Cancel = True
                Case Else
                    KMDISystems_Login_SERVER("KMDIDATA")
                    LoginType = "Fresh"
                    DBnameCboxSelectedIndex = 0
                    PrevDBnameCboxSelectedIndex = 0
            End Select

            Select Case LoginBGW.CancellationPending
                Case True
                    e.Cancel = True
                Case Else
                    KMDISystems_Login(KMDISystems_UserName,
                                      KMDISystems_Password)
            End Select
        Catch ex As SqlException
            'DisplaySqlErrors(ex) 'Galing to sa KMDI_V1 -->Marketing_Analysis.vb (line 28)
            If ex.Number = -2 Then
                MetroMessageBox.Show(Me, "Click ok to Reconnect", "Request Timeout", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                'LoginBtn.PerformClick()
            ElseIf ex.Number = 1232 Then
                MetroMessageBox.Show(Me, "Please check internet connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                LoginBGW.CancelAsync()
            ElseIf ex.Number <> -2 And ex.Number <> 1232 Then
                MetroMessageBox.Show(Me, "Contact dev team for assistance" & vbCrLf & vbCrLf & ex.ToString, "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                LoginBGW.CancelAsync()
            End If
        Catch ex2 As Exception
            MetroMessageBox.Show(Me, ex2.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

        If LoginBGW.CancellationPending = True Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoginBGW_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        Try
            LoadingPBOX.Visible = False
            LoginBtn.Visible = True
            If e.Error IsNot Nothing Then
                '' if BackgroundWorker terminated due to error
                MetroMessageBox.Show(Me, "Contact dev team for assistance" & vbCrLf & vbCrLf & e.Error.ToString, "System Error Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf e.Cancelled = True Then
                '' otherwise if it was cancelled
                UserName_TBX.Enabled = True
                Password_TBX.Enabled = True
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
                        MetroMessageBox.Show(Me, "Login failed! Please Try again", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                        If Application.OpenForms().OfType(Of KMDI_MainFRM).Any Then

                            .DbNameCbox.SelectedIndex = PrevDBnameCboxSelectedIndex

                            KMDISystems_Login_SERVER(.DbNameCbox.Text)
                            LoginType = "Relog"
                            DBnameCboxSelectedIndex = .DbNameCbox.SelectedIndex
                            PrevDBnameCboxSelectedIndex = .PrevDBNameCboxSelectedIndex

                            StartWorker()
                        End If

                    End With
                End If
                UserName_TBX.Enabled = True
                Password_TBX.Enabled = True

            End If

        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
End Class
