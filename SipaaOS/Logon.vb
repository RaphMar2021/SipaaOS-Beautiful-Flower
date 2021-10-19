Public Class Logon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Guna2TextBox1.Text = My.Settings.Password Then
            Desktop.Show()
            Me.Close()
        Else
            MsgBox("Password is incorrect.", vbExclamation + vbOKOnly, "Sipaa Logon Screen Service")
        End If

    End Sub

    Private Sub Logon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SaeroEnabled = True Then
            If My.Settings.Theme = "Light" Then
                Button1.FillColor = Color.FromArgb(147, 255, 255, 255)
                Button1.ForeColor = Color.FromArgb(255, 0, 0, 0)
            ElseIf My.Settings.Theme = "Dark" Then
                Button1.FillColor = Color.FromArgb(147, 0, 0, 0)
                Button1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            End If
        Else
            If My.Settings.Theme = "Light" Then
                Button1.FillColor = Color.FromArgb(255, 255, 255, 255)
                Button1.ForeColor = Color.FromArgb(255, 0, 0, 0)
            ElseIf My.Settings.Theme = "Dark" Then
                Button1.FillColor = Color.FromArgb(255, 0, 0, 0)
                Button1.ForeColor = Color.FromArgb(255, 255, 255, 255)
            End If
        End If
        Label2.Text = My.Settings.Username
        Me.Location = New Point(0, 0)
        Me.Size = My.Settings.ScreenSize
        PictureBox2.Location = New Point(Me.Width / 2 - PictureBox2.Width / 2, Label2.Location.Y - PictureBox2.Height - 4)
        PictureBox2.Location = New Point(Me.Width / 2 - PictureBox2.Width / 2, Label2.Location.Y - PictureBox2.Height - 4)
        Guna2TextBox1.Location = New Point(Me.Width / 2 - Guna2TextBox1.Width / 2, Me.Height / 2 - Guna2TextBox1.Height / 2)
        Label2.Location = New Point(Me.Width / 2 - Label2.Width / 2, Guna2TextBox1.Location.Y - Label2.Height - 4)
        If My.Settings.Password = "" Then
            Guna2TextBox1.Visible = False
            Button1.Location = New Point(Me.Width / 2 - Button1.Width / 2, Guna2TextBox1.Location.Y)
        Else
            Button1.Location = New Point(Me.Width / 2 - Button1.Width / 2, Guna2TextBox1.Location.Y + Button1.Height + 4)
        End If
        Timer1.Start()
        Me.Size = My.Settings.ScreenSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Location = New Point(Me.Width / 2 - PictureBox2.Width / 2, Label2.Location.Y - PictureBox2.Height - 4)
        Guna2TextBox1.Location = New Point(Me.Width / 2 - Guna2TextBox1.Width / 2, Me.Height / 2 - Guna2TextBox1.Height / 2)
        Label2.Location = New Point(Me.Width / 2 - Label2.Width / 2, Guna2TextBox1.Location.Y - Label2.Height - 4)
        If My.Settings.Password = "" Then
            Guna2TextBox1.Visible = False
            Button1.Location = New Point(Me.Width / 2 - Button1.Width / 2, Guna2TextBox1.Location.Y)
        Else
            Button1.Location = New Point(Me.Width / 2 - Button1.Width / 2, Guna2TextBox1.Location.Y + Button1.Height + 4)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub
End Class