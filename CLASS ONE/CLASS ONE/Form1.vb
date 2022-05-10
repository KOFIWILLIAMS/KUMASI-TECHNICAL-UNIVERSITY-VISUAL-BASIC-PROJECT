Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Dim ButtonDialogResult As DialogResult =
        '    MessageBox.Show("do you want to exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        '                    MessageBoxDefaultButton.Button2)
        'If ButtonDialogResult =
        '        Windows.Forms.DialogResult.Yes Then
        '    Me.Close()
        'End If
        Me.Close()
    End Sub


End Class
