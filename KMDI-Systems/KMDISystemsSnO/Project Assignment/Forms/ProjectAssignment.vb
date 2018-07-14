Public Class ProjectAssignment
    Private Sub ProjectAssignment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        KMDI_MainFRM.Enabled = True
        Me.Dispose()
    End Sub
End Class