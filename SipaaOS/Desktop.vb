Imports CoreAudioApi
Public Class Desktop
    Dim Svol As Integer = 0
    'FUNCTION SET VOLUME
    Private Function SetVol() As Integer
        Dim DevEnum As New MMDeviceEnumerator
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        device.AudioEndpointVolume.MasterVolumeLevelScalar = Svol / 100.0F
    End Function

    'FUNCTION GET VOLUME
    Private Function GetVol() As Integer
        Dim MasterMin As Integer = 0
        Dim DevEnum As New MMDeviceEnumerator
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        Dim Vol As Integer = 0

        With device.AudioEndpointVolume
            Vol = CInt(.MasterVolumeLevelScalar * 100)
            If Vol < MasterMin Then
                Vol = MasterMin / 100
            End If
        End With
        Return Vol
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BSOD.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = My.Settings.Username
        Label6.Text = GetVol() & "%"
        Guna2TrackBar1.Value = GetVol()
        If My.Computer.Network.IsAvailable = True Then
            PictureBox4.Image = My.Resources.icons8_wired_network_connection_32
        Else
            PictureBox4.Image = My.Resources.icons8_no_network_connection_32
        End If
        Label5.Text = DateTime.Now.ToString("d")
        Label4.Text = DateTime.Now.ToString("HH:mm")
        Me.Size = My.Settings.ScreenSize
        Me.Location = New Point(0, 0)
        If My.Settings.TaskbarLocation = "Center" Then
            Button1.Location = New Point(Me.Width / 2 - Button1.Width / 2, Button1.Location.Y)
            GroupBox2.Location = New Point(Me.Width / 2 - GroupBox2.Width / 2, GroupBox2.Location.Y)
        Else
            Button1.Location = New Point(3, Button1.Location.Y)
            GroupBox2.Location = New Point(3, GroupBox2.Location.Y)
        End If
        If My.Settings.SaeroEnabled = True Then
            If My.Settings.Theme = "Light" Then
                GroupBox2.FillColor = Color.FromArgb(147, 255, 255, 255)
                GroupBox2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                GroupBox2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(147, 255, 255, 255)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Button1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Button7.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
            ElseIf My.Settings.Theme = "Dark" Then
                GroupBox2.FillColor = Color.FromArgb(147, 0, 0, 0)
                GroupBox2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Button7.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Button1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                GroupBox2.BackColor = Color.FromArgb(0, 0, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(147, 0, 0, 0)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
            Else
                MsgBox("You need to select a theme to apply Saero.")
            End If
        Else
            If My.Settings.Theme = "Light" Then
                GroupBox2.FillColor = Color.FromArgb(255, 255, 255, 255)
                GroupBox2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                GroupBox2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Button7.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.FillColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Button1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Button7.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
            ElseIf My.Settings.Theme = "Dark" Then
                GroupBox2.FillColor = Color.FromArgb(255, 0, 0, 0)
                GroupBox2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Button7.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Button1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                GroupBox2.BackColor = Color.FromArgb(0, 0, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
            End If
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = My.Settings.Username
        Label6.Text = GetVol() & "%"
        Guna2TrackBar1.Value = GetVol()
        If My.Computer.Network.IsAvailable = True Then
            PictureBox4.Image = My.Resources.icons8_wired_network_connection_32
        Else
            PictureBox4.Image = My.Resources.icons8_no_network_connection_32
        End If
        Label5.Text = DateTime.Now.ToString("d")
        Label4.Text = DateTime.Now.ToString("HH:mm")
        Me.Size = My.Settings.ScreenSize
        If My.Settings.TaskbarLocation = "Center" Then
            Button1.Location = New Point(Me.Width / 2 - Button1.Width / 2, Button1.Location.Y)
            GroupBox2.Location = New Point(Me.Width / 2 - GroupBox2.Width / 2, GroupBox2.Location.Y)
        Else
            Button1.Location = New Point(3, Button1.Location.Y)
            GroupBox2.Location = New Point(3, GroupBox2.Location.Y)
        End If
        If My.Settings.SaeroEnabled = True Then
            If My.Settings.Theme = "Light" Then
                GroupBox2.FillColor = Color.FromArgb(147, 255, 255, 255)
                GroupBox2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                GroupBox2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(147, 255, 255, 255)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.FillColor = Color.FromArgb(147, 255, 255, 255)
                Guna2Button1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Button7.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            ElseIf My.Settings.Theme = "Dark" Then
                GroupBox2.FillColor = Color.FromArgb(147, 0, 0, 0)
                GroupBox2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                GroupBox2.BackColor = Color.FromArgb(0, 0, 255, 255)
                Guna2Button1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Button7.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(147, 0, 0, 0)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.FillColor = Color.FromArgb(147, 0, 0, 0)
                Guna2Panel2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            Else
                MsgBox("You need to select a theme to apply Saero.")
            End If
        Else
            If My.Settings.Theme = "Light" Then
                GroupBox2.FillColor = Color.FromArgb(255, 255, 255, 255)
                GroupBox2.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                GroupBox2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Button1.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Button7.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel2.FillColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.ForeColor = Color.FromArgb(255, 0, 0, 0)
            ElseIf My.Settings.Theme = "Dark" Then
                GroupBox2.FillColor = Color.FromArgb(255, 0, 0, 0)
                GroupBox2.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                GroupBox2.BackColor = Color.FromArgb(0, 0, 255, 255)
                Guna2Panel1.FillColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Button1.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Button7.ForeColor = Color.FromArgb(255, 255, 255, 255)
                Guna2Panel1.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.FillColor = Color.FromArgb(255, 0, 0, 0)
                Guna2Panel2.BackColor = Color.FromArgb(0, 255, 255, 255)
                Guna2Panel2.ForeColor = Color.FromArgb(255, 255, 255, 255)
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        GroupBox2.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GroupBox2.Visible = True Then
            GroupBox2.Hide()
        Else
            GroupBox2.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

        GroupBox2.Hide()
        FileExplorer.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        About.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        GroupBox2.Visible = False
        About.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Logon.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GroupBox2.Visible = False
        Settings.Show()
    End Sub

    Private Sub Guna2TrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2TrackBar1.Scroll
        Svol = Guna2TrackBar1.Value
        If Svol < 0 Then
            Svol = 0
        ElseIf Svol > 100 Then
            Svol = 100
        End If

        Label6.Text = GetVol() & "%"
        SetVol()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Guna2Panel2.Visible = False Then
            Guna2Panel2.Show()
        Else
            Guna2Panel2.Hide()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Logon.Timer1.Start()
        Logon.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Sipaint.Show()
    End Sub
End Class
