Public Class BSOD
    Private Sub BSOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Size = My.Settings.ScreenSize
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2ProgressBar1.Increment(10)
        If Guna2ProgressBar1.Value = 100 Then
            StartupVisual.Show()
            Me.Close()
        End If
    End Sub
End Class