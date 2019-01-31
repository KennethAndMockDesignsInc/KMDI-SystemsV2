Imports MetroFramework.Controls

Public Class MHC_Prototype
    Private Sub MHC_Prototype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Chk_FLP.Controls.Count <> 0 Then
            Chk_FLP.Controls.Clear()
        End If
        If Tbox_FLP.Controls.Count <> 0 Then
            Tbox_FLP.Controls.Clear()
        End If
    End Sub

    Dim CtrlCounter As Integer
    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        Try
            CtrlCounter += 1

            Dim TotalSecs As Integer = Nothing
            TotalSecs = (Hrs_Tbox.Text * 3600) + (Mins_Tbox.Text * 60) + Secs_Tbox.Text

            Dim Windoor_CHK As New MetroCheckBox
            Dim Windoor_TBOX As New MetroTextBox
            With Windoor_CHK
                .Name = CtrlCounter
                .Margin = New Padding(5)
                .Text = WindoorType_Tbox.Text
                .FontSize = MetroFramework.MetroCheckBoxSize.Small
                .FontWeight = MetroFramework.MetroCheckBoxWeight.Regular
                .Size = New Size(113, 15)
                .Tag = TotalSecs
                GlobalToolTip.SetToolTip(Windoor_CHK, .Name)
                AddHandler Windoor_CHK.CheckedChanged, AddressOf Chk_CheckChanged
            End With

            With Windoor_TBOX
                .Name = CtrlCounter
                .Margin = New Padding(1)
                .FontSize = MetroFramework.MetroTextBoxSize.Small
                .FontWeight = MetroFramework.MetroTextBoxWeight.Regular
                .Size = New Size(145, 23)
                .WaterMark = "# of Panels"
                .WaterMarkFont = New Font("Segoe UI", 12, FontStyle.Italic, GraphicsUnit.Pixel)
                GlobalToolTip.SetToolTip(Windoor_TBOX, .Name)
            End With

            Chk_FLP.Controls.Add(Windoor_CHK)
            Threading.Thread.Sleep(100)
            Tbox_FLP.Controls.Add(Windoor_TBOX)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Chk_CheckChanged(sender As Object, e As EventArgs)
        Try
            If sender.Checked = True Then
                For Each ctrl In Tbox_FLP.Controls
                    If ctrl.Name = sender.Name Then
                        ctrl.Enabled = True
                    End If
                Next
            ElseIf sender.Checked = False Then
                For Each ctrl In Tbox_FLP.Controls
                    If ctrl.Name = sender.Name Then
                        ctrl.Enabled = False
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class