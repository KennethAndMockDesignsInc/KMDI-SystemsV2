Public Class KMDISystemsLogin
    Public KMDISystemsLogin_AccessPoint As String = "192.168.1.21,49107"

    Private Sub KMDISystemsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTypeCbox.SelectedIndex = 0
        MaximizeBox = False

    End Sub
    Public Sub Login()
        Try
            KMDISystems_Login_SERVER("KMDIDATA")

            KMDISystems_Login(KMDISystems_UserName,
                  KMDISystems_Password, "Fresh", 0, 0)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

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

    Private Sub UserNameTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles UserNameTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginBtn.PerformClick()
        End If
    End Sub

    Private Sub PasswordTbox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTbox.TextChanged
        KMDISystems_Password = PasswordTbox.Text
    End Sub

    Private Sub PasswordTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginBtn.PerformClick()
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Try
            KMDISystems_UserName = Trim(KMDISystems_UserName)
            KMDISystems_Password = Trim(KMDISystems_Password)
            If KMDISystems_UserName = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            ElseIf KMDISystems_Password = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try

        Login()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        KMDI_MainFRM.Dispose()
        Me.Close()
    End Sub

    Private Sub KMDISystemsLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Dispose()
        Me.Dispose()
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

End Class
