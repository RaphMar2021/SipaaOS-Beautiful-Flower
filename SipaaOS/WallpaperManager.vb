Imports CrashReporterDotNET
Public Class WallpaperManager
    Private crash As ReportCrash
    Private ex As Exception
    Public Sub SetWallpaper(Image As Bitmap, UI As String)
        If UI = "Desktop" Then
            Desktop.BackgroundImage = Image
        ElseIf UI = "LogonUI" Then
            Logon.BackgroundImage = Image
        Else
            Console.WriteLine("WallpaperManager : SipaaOS needs to exit because the UI String is '' or null or an error is in the string.")

            Application.Exit()
        End If
    End Sub
End Class
