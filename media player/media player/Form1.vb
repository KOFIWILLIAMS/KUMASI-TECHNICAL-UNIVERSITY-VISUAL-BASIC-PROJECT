Imports WMPLib

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub player_ClickEvent(ByVal sender As Object, ByVal e As AxWMPLib._WMPOCXEvents_ClickEvent) Handles player.ClickEvent
        If (player.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            player.Ctlcontrols.pause()
        Else
            player.Ctlcontrols.play()
        End If
    End Sub

    Private Sub player_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles player.Enter

    End Sub

    Private Sub ControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlToolStripMenuItem.Click
        player.uiMode = "full"
    End Sub

    Private Sub NoControlToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoControlToolStripMenuItem1.Click
        player.uiMode = "none"
    End Sub

    Private Sub AddFilesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddFilesToolStripMenuItem.Click
        OpenFD.InitialDirectory = "C:\Users\DaaVy\Desktop\dax"
        OpenFD.ShowDialog()
        player.URL = OpenFD.FileName()
    End Sub
End Class
