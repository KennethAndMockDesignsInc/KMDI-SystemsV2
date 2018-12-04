Public Class PD_JoAttach
    Private Sub JoAttach_Btn_Click(sender As Object, e As EventArgs) Handles JoAttach_Btn.Click
        If JoAttach_Cbox.SelectedIndex <> -1 Then
            JoAttach_RTbox.Text += JoAttach_Cbox.Text & vbCrLf
        End If
    End Sub

    Private Sub JOAttachSave_Btn_Click(sender As Object, e As EventArgs) Handles JOAttachSave_Btn.Click
        PD_SalesJobOrder.JoAttach_RTbox.Text = JoAttach_RTbox.Text
        Me.Close()
    End Sub
End Class