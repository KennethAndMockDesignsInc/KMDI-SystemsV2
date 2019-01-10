Public Class SearchFRM
    Dim sql As KMDIContractRecordsClass

    Private Sub SearchBTN_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click
        Try
            ContractRecordsFRM.SearchString = Trim(Replace(SearchTbox.Text, "item", ""))
            If SearchTbox.Text = Nothing Then
                SearchTbox.Focus()
            ElseIf SearchTbox.Text.Contains("item") Then
                ContractRecordsFRM.ActionTaken = "Search"
                Select Case ContractRecordsFRM.SearchItemFN
                    Case "InitialF2"
                        ContractRecordsFRM.SearchItemFN = "ItemSearchInitialF2"
                    Case "SecondF2"
                        ContractRecordsFRM.SearchItemFN = "ItemSearchSecondF2"
                End Select
                ContractRecordsFRM.StartWorker()
            Else
                ContractRecordsFRM.ActionTaken = "Search"
                Select Case ContractRecordsFRM.SearchItemFN
                    Case "ItemSearchInitialF2"
                        ContractRecordsFRM.SearchItemFN = "InitialF2"
                    Case "ItemSearchSecondF2"
                        ContractRecordsFRM.SearchItemFN = "SecondF2"
                End Select
                ContractRecordsFRM.SearchScope = "Broad"
                ContractRecordsFRM.StartWorker()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub SearchTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTbox.KeyDown

        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    SearchBTN.PerformClick()
                    e.SuppressKeyPress = True
                Case Keys.Escape
                    Me.Close()
                    ContractRecordsFRM.Focus()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub SearchFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dispose()
            ContractRecordsFRM.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class