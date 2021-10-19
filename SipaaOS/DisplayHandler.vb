Public Class DisplayHandler
    Public Sub SetResolution(width As Integer, height As Integer)
        My.Settings.ScreenSize = New Point(width, height)
        My.Settings.Save()
    End Sub

    Public Function GetResolution()
        Return My.Settings.ScreenSize
    End Function
End Class
