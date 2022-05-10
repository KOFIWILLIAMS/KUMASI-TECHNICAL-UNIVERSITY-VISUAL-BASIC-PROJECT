Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    'save
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.Filter = "Text file|*.txt*|All File|*."
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, GroupBox1.Text, True)
        End If
    End Sub
    'print
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtPrint.Visible = False
        ButtSave.Visible = False

        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

        ButtPrint.Visible = True
        ButtSave.Visible = True

        'And Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview Then
        '       '
        '       Me.PrintDocument1.Print()
        '       End If

        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PrintDocument1.Print()
        'End If


        'And PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    
        'End If

        'Dim count As Integer
        'while ButtPrint.Text
        '    count = count + 1
        'End While

        'PrintDocument1.Print()
        'Me.PrintForm1.Print()
        'ButtPrint.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

    Private Sub ButtPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtPrint.Click
        ButtPrint.Visible = False
        ButtSave.Visible = False

        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

        ButtPrint.Visible = True
        ButtSave.Visible = True

        'And Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview Then
        '       '
        '       Me.PrintDocument1.Print()
        '       End If

        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PrintDocument1.Print()
        'End If


        'And PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    
        'End If

        'Dim count As Integer
        'while ButtPrint.Text
        '    count = count + 1
        'End While

        'PrintDocument1.Print()
        'Me.PrintForm1.Print()
        'ButtPrint.Visible = False
    End Sub

    Private Sub ButtSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtSave.Click
        SaveFileDialog1.Filter = "Text file|*.txt*|All File|*."
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, GroupBox1.Text, True)
        End If
    End Sub
End Class
