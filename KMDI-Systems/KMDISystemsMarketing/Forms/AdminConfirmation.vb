Public Class AdminConfirmation
    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        If maxCounter <= 2 Then
            If AdminsCodeTbox.Text.Contains("SekretongMalupet") Then
                MARKETING_INVENTORY_V2_SaveLogs("Button Visible is True, maxCounter = " & maxCounter & ", " & LoginModule.nickname + " " + Today.Date.ToString("MMM d, yyyy") + " " + TimeOfDay & ", By Admin: " & AdminsCodeTbox.Text.Remove(0, 16))
                Inventory.DontClick_Btn.Visible = True
                maxCounter = 0
                Me.Close()
            ElseIf AdminsCodeTbox.Text.Contains("SekretongPetmalu") Then
                MARKETING_INVENTORY_V2_SaveLogs("Button Visible is False, maxCounter = " & maxCounter & ", " & LoginModule.nickname + " " + Today.Date.ToString("MMM d, yyyy") + " " + TimeOfDay & ", By Admin: " & AdminsCodeTbox.Text.Remove(0, 16))
                Inventory.DontClick_Btn.Visible = False
                maxCounter = 0
                Me.Close()
            Else
                maxCounter += 1
                MARKETING_INVENTORY_V2_SaveLogs("User is DENIED, maxCounter = " & maxCounter & ", " & LoginModule.nickname + " " + Today.Date.ToString("MMM d, yyyy") + " " + TimeOfDay)
                MetroFramework.MetroMessageBox.Show(Me, "Denied", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            maxCounter = 0
            MARKETING_INVENTORY_V2_SaveLogs("User is DENIED WITH MAXIMUM attempts, maxCounter = " & maxCounter & ", " & LoginModule.nickname + " " + Today.Date.ToString("MMM d, yyyy") + " " + TimeOfDay)
            MetroFramework.MetroMessageBox.Show(Me, "Maximum Attempts counted! This will be reported to the Admins", "KEEP OUT!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub

    Private Sub AdminsCodeTbox_KeyDown(sender As Object, e As KeyEventArgs) Handles AdminsCodeTbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            MetroTextButton1.PerformClick()
        End If
    End Sub
End Class