Imports MetroFramework.Controls

Public Class MHC_Prototype
    Private Sub Chk_CheckChanged(sender As Object, e As EventArgs) Handles Awning_Chk.CheckedChanged, Casement_Chk.CheckedChanged, Fixed_Chk.CheckedChanged, Louver_Chk.CheckedChanged
        Try
            For Each ctrl In Combo_PNL.Controls
                If ctrl.Name.Contains("Tbox") Then
                    If sender.Tag = ctrl.Tag Then
                        ctrl.Enabled = sender.Checked
                        If ctrl.Enabled = True Then
                            ctrl.Focus()
                        Else
                            ctrl.Clear()
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim windoor_Area As Decimal
            Dim FS_Total_Secs, GL_Total_Secs As Integer

            windoor_Area = (Width_Tbox.Text * Height_Tbox.Text) / (10 ^ 6)
            Size_LbL.Text = "Area: " & windoor_Area.ToString("N2") & " "
            If windoor_Area > 0 And windoor_Area < 1 Then
                Size_LbL.Text += "Extra Small"
                FS_Total_Secs = (1 * 3600) + (0 * 60) + 8
                GL_Total_Secs = (0 * 3600) + (6 * 60) + 20

            ElseIf windoor_Area >= 1 And windoor_Area <= 2.25 Then
                Size_LbL.Text += "Small"
                FS_Total_Secs = (1 * 3600) + (5 * 60) + 31
                GL_Total_Secs = (0 * 3600) + (8 * 60) + 0

            ElseIf windoor_Area > 2.25 And windoor_Area <= 4.1 Then
                Size_LbL.Text += "Medium"
                FS_Total_Secs = (1 * 3600) + (37 * 60) + 41
                GL_Total_Secs = (0 * 3600) + (14 * 60) + 8

            ElseIf windoor_Area > 4.1 And windoor_Area <= 5.65 Then
                Size_LbL.Text += "Large"
                FS_Total_Secs = (2 * 3600) + (9 * 60) + 33
                GL_Total_Secs = (0 * 3600) + (12 * 60) + 5

            ElseIf windoor_Area > 5.65 Then
                Size_LbL.Text += "Extra Large"
                FS_Total_Secs = (2 * 3600) + (33 * 60) + 11
                GL_Total_Secs = (0 * 3600) + (12 * 60) + 53

            End If

            Dim OverallSecs, TotalPanels As Integer
            For Each ctrl In Combo_PNL.Controls
                If ctrl.Name.Contains("TboxW") And ctrl.Text <> Nothing Then
                    TotalPanels += Val(ctrl.Text)
                End If
            Next

            OverallSecs = FS_Total_Secs + (GL_Total_Secs * TotalPanels) +
                          (((0 * 3600) + (3 * 60) + 58) * TotalPanels)

            Dim iSpan As TimeSpan = TimeSpan.FromSeconds(OverallSecs)

            TT_Tbox.Text = "Total Time : " & iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" &
                                             iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                                             iSpan.Seconds.ToString.PadLeft(2, "0"c)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class