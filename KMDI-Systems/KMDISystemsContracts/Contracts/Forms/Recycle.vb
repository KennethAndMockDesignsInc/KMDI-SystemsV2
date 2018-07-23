Public Class Recycle
    Private Sub Recycle_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F AndAlso Keys.Control Then
            SearchContract.Show()
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.F AndAlso Keys.Control Then
            SearchContract.Show()
        End If
    End Sub
End Class