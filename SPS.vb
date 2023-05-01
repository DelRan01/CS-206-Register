Public Class SPS
    'CODE FOR PROGRESS BAR
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles RegTimer.Tick
        RegProgBar.Increment(3)
        If RegProgBar.Value = 100 Then
            Me.Hide()
            RegTimer.Enabled = False
            Login.Show()
        End If
    End Sub
End Class