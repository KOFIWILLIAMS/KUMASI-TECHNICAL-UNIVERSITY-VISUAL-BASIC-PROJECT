Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub VOICE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VOICE.Click
        Dim SAPI As Object
        SAPI = CreateObject("SAPI.SPvoice")
        SAPI.speak(main.Text)
    End Sub

    Private Sub EDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDIT.Click
        Dim result = MessageBox.Show("Do You Want TO Edit", "Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            main.ReadOnly = False
        End If
    End Sub

    Private Sub BKGD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BKGD.Click
        Dim backgroundcolor As New ColorDialog
        If backgroundcolor.ShowDialog = Windows.Forms.DialogResult.OK Then
            main.BackColor = backgroundcolor.Color
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTEXTCOLOR.Click
        Dim forgroundcolor As New ColorDialog
        If forgroundcolor.ShowDialog = Windows.Forms.DialogResult.OK Then
            main.ForeColor = forgroundcolor.Color
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXIT.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub ButtonSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSAVE.Click
        'code for saving 
        SaveFileDialog1.Filter = "Text file (*.txt)|*.txt"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
            FileClose(1)
        End If
    End Sub

    Private Sub ButtonIMPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIMPORT.Click
        'code for importing 
        Dim koffy As String
        Dim cofy As String
        OpenFileDialog1.Filter = "Text file (*.txt) |*.txt"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Try
                FileOpen(1, SaveFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1) 'read lines from file
                    cofy = LineInput(1)
                    koffy = koffy & cofy & vbCrLf
                Loop
                main.Text = koffy ' display 
                main.Select(1, 0) ' remove text selction 
            Catch
                MsgBox("BBF")
            End Try
        End If
    End Sub
End Class
