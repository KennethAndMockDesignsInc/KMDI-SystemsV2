Public Class ChangeWritePermision
    Public AccessAutonum As Integer

    Private Sub ManageUserAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KMDI_ACCT_ACCESS_TB_READ_FOR_ChangeWritePermision(ManageAccounts.UsersAutonum)
        MaximizeBox = False

        AcctTypeTbox.Text = ManageAccounts.UserAccessCbox.Text
        TileAccessCode.Focus()
        WriteCbox.SelectedIndex = 0
    End Sub

    Private Sub ManageUserAccess_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ManageAccounts.Enabled = True
        Me.Dispose()
    End Sub

    Private Sub UserAccessDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserAccessDGV.CellClick, UserAccessDGV.CellEnter

        Dim TileCode As String

        If UserAccessDGV.RowCount >= 0 And e.RowIndex >= 0 Then

            Try

                AccessAutonum = UserAccessDGV.Item("Autonumber", e.RowIndex).Value.ToString
                AcctTypeTbox.Text = UserAccessDGV.Item("Account Type", e.RowIndex).Value.ToString
                TileCode = "|" & UserAccessDGV.Item("Tile", e.RowIndex).Value.ToString
                WriteCbox.Text = UserAccessDGV.Item("Write", e.RowIndex).Value.ToString


                Select Case TileCode
                    Case EngrSDreq
                        TileAccessCode.Text = "Engineer SD Request"
                    Case DelReciepts
                        TileAccessCode.Text = "Delivery Reciepts"
                    Case DR
                        TileAccessCode.Text = "DR"
                    Case DrReports
                        TileAccessCode.Text = "DR Reports"
                    Case EngrsItinerary
                        TileAccessCode.Text = "Engr's Itinerary"
                    Case EngrSDsubm
                        TileAccessCode.Text = "Engr SD Submittal"

                    Case addendum
                        TileAccessCode.Text = "Addendum"
                    Case SalesItinerary
                        TileAccessCode.Text = "Sales Itinerary"
                    Case SalesMoni
                        TileAccessCode.Text = "Sales Monitoring"
                    Case SUS
                        TileAccessCode.Text = "System Used Sales"
                    Case CallerInfo
                        TileAccessCode.Text = "Caller Info"
                    Case Collection
                        TileAccessCode.Text = "Collection"
                    Case ExtDMGs
                        TileAccessCode.Text = "External DMGs"
                    Case CheckBalance
                        TileAccessCode.Text = "Check Balance"

                    Case ProdSDreq
                        TileAccessCode.Text = "Production SD Request"
                    Case CuttList
                        TileAccessCode.Text = "Cutting List"
                    Case StatsMoni
                        TileAccessCode.Text = "Status Monitoring"
                    Case GlassSpecs
                        TileAccessCode.Text = "Glass Specs"
                    Case ProdSDSubm
                        TileAccessCode.Text = "Production SD Submittal"

                    Case ArchiFirm
                        TileAccessCode.Text = "Architectural Firm"
                    Case Inventory
                        TileAccessCode.Text = "Inventory"
                    Case Request
                        TileAccessCode.Text = "Marketing Request"

                    Case WinDoor
                        TileAccessCode.Text = "WinDoor Maker"
                End Select

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub UpdateWriteCode_Click(sender As Object, e As EventArgs) Handles UpdateWriteCode.Click
        KMDI_ACCT_ACCESS_TB_UPDATE(WriteCbox.Text, AccessAutonum, "Updated by: " & nickname & " " & Date.Now)
    End Sub
End Class