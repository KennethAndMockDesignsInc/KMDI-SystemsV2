Public Class UpdateAcctType

    Private Sub UpdateAcctType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ManageAccounts.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub UpdateAcctType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_ACCTYPE_READ()
    End Sub

    Private Sub AcctTypeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AcctTypeDGV.CellMouseClick
        Dim autonumACCTtype As String
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then

            If AcctTypeDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                Try
                    AcctTypeNameTbox.Text = AcctTypeDGV.Item("ACCTYPE", e.RowIndex).Value.ToString
                    autonumACCTtype = AcctTypeDGV.Item("Autonumber", e.RowIndex).Value.ToString
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Dim autonumACCTtype As String

    Private Sub AcctTypeDGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles AcctTypeDGV.CellEnter
        If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then

            If AcctTypeDGV.RowCount >= 0 And e.RowIndex >= 0 Then

                Try
                    AcctTypeNameTbox.Text = AcctTypeDGV.Item("ACCTYPE", e.RowIndex).Value.ToString
                    autonumACCTtype = AcctTypeDGV.Item("Autonumber", e.RowIndex).Value.ToString

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub AddAcctTypeBtn_Click(sender As Object, e As EventArgs) Handles AddAcctTypeBtn.Click
        AcctTypeNameTbox.Text = Trim(AcctTypeNameTbox.Text)
        If AcctTypeNameTbox.Text = "" Or AcctTypeNameTbox.Text = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Field(s) cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            KMDI_ACCT_ACCTYPE_TB_INSERT(AcctTypeNameTbox.Text)
        End If
    End Sub

    Private Sub UpdateAcctTypeBtn_Click(sender As Object, e As EventArgs) Handles UpdateAcctTypeBtn.Click
        AcctTypeNameTbox.Text = Trim(AcctTypeNameTbox.Text)
        If autonumACCTtype = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select first", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If AcctTypeNameTbox.Text = "" Or AcctTypeNameTbox.Text = Nothing Then
                MetroFramework.MetroMessageBox.Show(Me, "Field(s) cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else

                KMDI_ACCT_ACCTYPE_TB_UPDATE(AcctTypeNameTbox.Text, autonumACCTtype)
                autonumACCTtype = Nothing
            End If
        End If

    End Sub

    Private Sub DeleteAcctTypeBtn_Click(sender As Object, e As EventArgs) Handles DeleteAcctTypeBtn.Click
        If autonumACCTtype = Nothing Then
            MetroFramework.MetroMessageBox.Show(Me, "Select first", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            KMDI_ACCT_ACCTYPE_TB_DELETE(autonumACCTtype)
            autonumACCTtype = Nothing
        End If

    End Sub
End Class