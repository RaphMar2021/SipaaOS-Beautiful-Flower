Public Class Settings
    Private wm As WallpaperManager
    Private dh As DisplayHandler
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = My.Settings.Username
        If My.Settings.SaeroEnabled = True Then
            Label3.Text = "State : True"
        Else
            Label3.Text = "State : False"
        End If

        Label4.Text = "State : " + My.Settings.Theme
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        My.Settings.SaeroEnabled = True
        Label3.Text = "State : True"
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        My.Settings.SaeroEnabled = False
        Label3.Text = "State : False"
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Label4.Text = "State : Dark"
        My.Settings.Theme = "Dark"
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Label4.Text = "State : Light"
        My.Settings.Theme = "Light"
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Label5.Text = "State : Left"
        My.Settings.TaskbarLocation = "Left"
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Label5.Text = "State : Center"
        My.Settings.TaskbarLocation = "Center"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        wm = New WallpaperManager
        wm.SetWallpaper(My.Resources._4913427, "Desktop")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        wm = New WallpaperManager
        wm.SetWallpaper(My.Resources.bg, "Desktop")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        wm = New WallpaperManager
        wm.SetWallpaper(My.Resources.img28, "Desktop")
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        My.Settings.Username = Guna2TextBox1.Text
        Label9.Text = My.Settings.Username
        Guna2TextBox1.Clear()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        My.Settings.Password = Guna2TextBox2.Text
        Guna2TextBox2.Clear()
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles Guna2Button11.Click
        dh = New DisplayHandler
        dh.SetResolution(1920, 1080)
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        dh = New DisplayHandler
        dh.SetResolution(1680, 1050)
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        dh = New DisplayHandler
        dh.SetResolution(1366, 768)
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs) Handles Guna2Button14.Click
        dh = New DisplayHandler
        dh.SetResolution(1280, 720)
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs) Handles Guna2Button15.Click
        dh = New DisplayHandler
        dh.SetResolution(1024, 768)
    End Sub
End Class