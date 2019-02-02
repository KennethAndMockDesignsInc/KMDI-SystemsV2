Imports Transitions
Public Class Transition_Prototype
    Private Sub Transition_Prototype_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As New Transition(New TransitionType_Acceleration(300))
        If Panel2.Width = 0 Then
            t.add(Panel2, "Width", 273)
            t.run()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t2 As New Transition(New TransitionType_Deceleration(300))
        If Panel2.Width = 273 Then
            t2.add(Panel2, "Width", 0)
            t2.run()
        End If
    End Sub

    Dim transition_mode As String = "Accelerate"
    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        If transition_mode = "Accelerate" Then
            Dim t As New Transition(New TransitionType_Acceleration(300))
            If Panel2.Width = 33 Then
                t.add(Panel2, "Width", 300)
                t.run()
            End If
            transition_mode = "Decelerate"
        ElseIf transition_mode = "Decelerate" Then
            Dim t2 As New Transition(New TransitionType_Deceleration(300))
            If Panel2.Width = 300 Then
                t2.add(Panel2, "Width", 33)
                t2.run()
            End If
            transition_mode = "Accelerate"
        End If
    End Sub
End Class