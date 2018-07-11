Public Class WinDoorMaker

    Private Sub WinDoorMaker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        KMDI_MainFRM.Show()
        KMDI_MainFRM.BringToFront()
    End Sub

    Private Sub WinDoorMaker_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class