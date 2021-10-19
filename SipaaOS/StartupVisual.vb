Public Class StartupVisual
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StartupVisual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point(0, 0)
        My.Settings.ScreenSize = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
        If My.Settings.Theme = "Light" Then
            Me.BackColor = Color.White
            Label1.ForeColor = Color.Black
        End If
        Me.Size = My.Settings.ScreenSize
        Desktop.Size = My.Settings.ScreenSize
        Label1.Location = New Point(Me.Width / 2 - Label1.Width / 2, Label1.Location.Y)
        Guna2ProgressBar1.Location = New Point(Me.Width / 2 - Guna2ProgressBar1.Width / 2, Guna2ProgressBar1.Location.Y)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Settings.ScreenSize = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
        Guna2ProgressBar1.Increment(5)
        If Guna2ProgressBar1.Value = 90 Then
            Logon.Timer1.Start()
        End If
        If Guna2ProgressBar1.Value = 100 Then
            Logon.Show()
            Me.Close()
        End If
        Me.Size = My.Settings.ScreenSize
        Desktop.Size = My.Settings.ScreenSize
        Label1.Location = New Point(Me.Width / 2 - Label1.Width / 2, Label1.Location.Y)
        Guna2ProgressBar1.Location = New Point(Me.Width / 2 - Guna2ProgressBar1.Width / 2, Guna2ProgressBar1.Location.Y)
    End Sub
End Class