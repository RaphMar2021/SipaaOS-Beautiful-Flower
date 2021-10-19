Imports CefSharp.WinForms
Public Class Form1
    Private Browser As ChromiumWebBrowser
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Browser = New ChromiumWebBrowser("google.com")
        Browser.Dock = DockStyle.Fill
        Panel1.Controls.Add(Browser)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Browser.CanGoBack = True Then

        End If
    End Sub
End Class
