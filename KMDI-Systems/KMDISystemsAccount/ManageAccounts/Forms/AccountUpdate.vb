Public Class AccountUpdate

    Public ProfilePicDirectory As String

    Private Sub AccountUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FullnameLlbl.Text = fullname
        NicknameLbl.Text = nickname
        AccountLbl.Text = AccountType
        UsernameLbl.Text = usernamePrint
        userPbox.ImageLocation = PROFILEPATH
    End Sub

    Private Sub AccountUpdate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
        KMDI_MainFRM.Enabled = True
    End Sub

    Private Sub UpdateUserBtn_Click(sender As Object, e As EventArgs) Handles UpdateUserBtn.Click
        NewUserTbox.Text = Trim(NewUserTbox.Text)
        NewPassTbox.Text = Trim(NewPassTbox.Text)
        OldPasswordTbox.Text = Trim(OldPasswordTbox.Text)
        RetypePassTbox.Text = Trim(RetypePassTbox.Text)


        If changePicChk.Checked = True Then
            KMDI_ACCT_TB_UPDATE_ManageAccounts_FOR_AccountUpdate_PicImage(ProfilePicDirectory)
        End If

        If changeUserChk.Checked = True Then
            If NewUserTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Fields cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else
                KMDI_ACCT_TB_UPDATE_ManageAccounts_FOR_AccountUpdate_Username(NewUserTbox.Text)
            End If
        End If

        If changePassChk.Checked = True Then
            If NewPassTbox.Text = Nothing Or OldPasswordTbox.Text = Nothing Or RetypePassTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Fields cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else
                KMDI_ACCT_TB_UPDATE_ManageAccounts_FOR_AccountUpdate_Password(OldPasswordTbox.Text, NewPassTbox.Text, RetypePassTbox.Text)
            End If
        End If


    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Dim openDlg As New OpenFileDialog

        openDlg.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG"
        If openDlg.ShowDialog = DialogResult.OK Then
            ProfilePicDirectory = openDlg.FileName
            userPbox.ImageLocation = ProfilePicDirectory
        End If
    End Sub

    Private Sub changePicChk_CheckedChanged(sender As Object, e As EventArgs) Handles changePicChk.CheckedChanged
        If changePicChk.Checked = True Then
            BrowseBtn.Enabled = True
        Else
            BrowseBtn.Enabled = False
        End If
    End Sub

    Private Sub changeUserChk_CheckedChanged(sender As Object, e As EventArgs) Handles changeUserChk.CheckedChanged
        If changeUserChk.Checked = True Then
            NewUserTbox.Enabled = True
            NewUserTbox.Focus()
        Else
            NewUserTbox.Enabled = False
        End If
    End Sub

    Private Sub changePassChk_CheckedChanged(sender As Object, e As EventArgs) Handles changePassChk.CheckedChanged
        If changePassChk.Checked = True Then
            OldPasswordTbox.Enabled = True
            NewPassTbox.Enabled = True
            RetypePassTbox.Enabled = True
            OldPasswordTbox.Focus()
        Else
            OldPasswordTbox.Enabled = False
            NewPassTbox.Enabled = False
            RetypePassTbox.Enabled = False
        End If
    End Sub
End Class