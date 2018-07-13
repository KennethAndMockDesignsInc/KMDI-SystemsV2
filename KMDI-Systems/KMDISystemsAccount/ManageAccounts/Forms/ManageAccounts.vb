Public Class ManageAccounts
    Public UsersAutonum As Integer
    Public userAccess, password_ManageAccounts As String

    Private Sub ManageAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_TB_READ(AccountAutonum)
        KMDI_ACCT_TB_READ_MAXAutonum()
        UserAccessCbox_Popolate()
        MaximizeBox = False
    End Sub

    Private Sub UserAcctDGV_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles UserAcctDGV.RowPostPaint
        rowpostpaint(sender, e)
    End Sub

    Private Sub ManageAccounts_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub UserAccessCbox_Enter(sender As Object, e As EventArgs) Handles UserAccessCbox.Enter
        UserAccessCbox_Popolate()
    End Sub

    Private Sub TilePermisionMenu_Click(sender As Object, e As EventArgs) Handles TilePermisionMenu.Click
        ChangeTilePermision.Show()
        Me.Enabled = False
    End Sub

    Private Sub UserAcctDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserAcctDGV.CellMouseClick
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
            If e.Button = MouseButtons.Right Then
                UserAcctDGV.Rows(e.RowIndex).Selected = True
                Dim r As New Rectangle
                r = UserAcctDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                PermisionMenu.Show()
                PermisionMenu.Location = New Point(MousePosition.X, MousePosition.Y)
            ElseIf e.Button = MouseButtons.Left Then

            End If

            If UserAcctDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                Try
                    FullnameTbox.Text = UserAcctDGV.Item("FULLNAME", e.RowIndex).Value.ToString
                    NicknameTbox.Text = UserAcctDGV.Item("NICKNAME", e.RowIndex).Value.ToString
                    userAccess = UserAcctDGV.Item("ACCTTYPE", e.RowIndex).Value.ToString
                    UserAccessCbox.Text = UserAcctDGV.Item("ACCTTYPE", e.RowIndex).Value.ToString
                    UsersAutonum = UserAcctDGV.Item("AUTONUM", e.RowIndex).Value.ToString
                    password_ManageAccounts = Decrypt(UserAcctDGV.Item("PASSWORD", e.RowIndex).Value.ToString)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

        End If

    End Sub

    Private Sub WritePermisionMenu_Click(sender As Object, e As EventArgs) Handles WritePermisionMenu.Click
        ChangeWritePermision.Show()
        Me.Enabled = False
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click

        If FullnameTbox.Text = "" Or FullnameTbox.Text = Nothing Or NicknameTbox.Text = "" Or
            NicknameTbox.Text = Nothing Or UserAccessCbox.Text = "" Or UserAccessCbox.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Fields cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            KMDI_ACCT_TB_INSERT_ManageAccounts(FullnameTbox.Text,
                                               NicknameTbox.Text,
                                               UserAccessCbox.Text,
                                               AUTONUMforuserNpass,
                                               Encrypt(AUTONUMforuserNpass))
        End If
    End Sub

    Private Sub UpdateUserBtn_Click(sender As Object, e As EventArgs) Handles UpdateUserBtn.Click
        FullnameTbox.Text = Trim(FullnameTbox.Text)
        NicknameTbox.Text = Trim(NicknameTbox.Text)
        UserAccessCbox.Text = Trim(UserAccessCbox.Text)

        If FullnameTbox.Text = "" Or FullnameTbox.Text = Nothing Or NicknameTbox.Text = "" Or
            NicknameTbox.Text = Nothing Or UserAccessCbox.Text = "" Or UserAccessCbox.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Fields cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            KMDI_ACCT_TB_UPDATE_ManageAccounts(FullnameTbox.Text,
                                           NicknameTbox.Text,
                                           UserAccessCbox.Text,
                                           UsersAutonum)
        End If

    End Sub

    Private Sub AcctTypeUpdate_Click(sender As Object, e As EventArgs) Handles AcctTypeUpdate.Click
        UpdateAcctType.Show()
        Me.Enabled = False
    End Sub
End Class