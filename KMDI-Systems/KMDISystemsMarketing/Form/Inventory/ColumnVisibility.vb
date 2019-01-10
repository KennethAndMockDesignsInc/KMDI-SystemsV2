Public Class ColumnVisibility
    Dim columnChkToolTip As New MetroFramework.Components.MetroToolTip
    Dim FormNameGlobal As Form
    Dim DGVStrGlobal As String
    Public Sub CreateMetroChkBoxes(ByVal FormName As Form,
                                   ByVal DgvStr As String)
        FormNameGlobal = FormName
        DGVStrGlobal = DgvStr
        FLP_ColumnInvi.Controls.Clear()
        For Each ctrl In FormName.Controls
            If ctrl.Name = DgvStr Then
                For i = 0 To ctrl.ColumnCount - 1
                    Dim columnChks As New MetroFramework.Controls.MetroCheckBox
                    With columnChks
                        .Name = ctrl.Columns(i).HeaderText
                        .Text = ctrl.Columns(i).HeaderText
                        .Checked = ctrl.Columns(i).Visible
                        columnChkToolTip.SetToolTip(columnChks, .Text)
                        AddHandler .CheckedChanged, AddressOf columnChks_CheckedChanged
                    End With
                    FLP_ColumnInvi.Controls.Add(columnChks)
                Next
            End If
        Next
    End Sub


    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        MKTNG_Inventory.Enabled = True
        MKTNG_Inventory.BringToFront()
        Me.Hide()
    End Sub

    Private Sub ColumnVisibility_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub columnChks_CheckedChanged(sender As Object, e As EventArgs)
        For Each ctrl In FormNameGlobal.Controls
            If ctrl.Name = DGVStrGlobal Then
                ctrl.Columns(sender.Name).Visible = sender.Checked
            End If
        Next
    End Sub

End Class