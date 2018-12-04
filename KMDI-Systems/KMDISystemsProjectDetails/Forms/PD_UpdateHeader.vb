Public Class PD_UpdateHeader

    Public disFormOpenedBy As String
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim countRequired As Integer
        For Each ctrl In ProjectDetails_Page.Controls
            If ctrl.Name.Contains("_Required") = True Then
                ctrl.Text = Trim(ctrl.Text)
                If ctrl.Text = "" Or ctrl.Text = Nothing Then
                    ctrl.Style = MetroFramework.MetroColorStyle.Red
                    ctrl.Select()
                    ctrl.Focus()
                    Warning_Tooltip.Show("fill up this REQUIRED field", ctrl)
                Else
                    countRequired += 1
                End If
            End If
        Next
        If countRequired = 4 Then
            AddressFormat(UnitNo_Tbox.Text,
                                  Establishment_Tbox.Text,
                                  HouseNo_Tbox.Text,
                                  Street_Tbox_Required.Text,
                                  Village_Tbox.Text,
                                  Brgy_Tbox.Text,
                                  City_Tbox_Required.Text,
                                  Province_Tbox_Required.Text)
            If disFormOpenedBy = "Addendum" Then
                PD_Addendum.FullAddress_Tbox.Text = FullAddress
            ElseIf disFormOpenedBy = "SalesJobOrder" Then
                PD_SalesJobOrder.FullAddress_Tbox.Text = FullAddress
            End If
            Me.Close()
        Else
            countRequired = 0
        End If

    End Sub
End Class