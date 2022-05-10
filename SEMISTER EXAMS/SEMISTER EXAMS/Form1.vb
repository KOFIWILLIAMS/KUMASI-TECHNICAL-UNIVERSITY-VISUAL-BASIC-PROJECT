Public Class Form1
#Region "Clear all text boxes"
    Public Sub Clear(ByVal c As Control)
        Dim clearTextbox As TextBox
        For Each control As Control In c.Controls
            If TypeOf control Is TextBox Then
                clearTextbox = CType(control, TextBox)
                clearTextbox.Clear()
            End If
            If control.HasChildren Then
                Clear(control)
            End If
        Next
    End Sub
#End Region

#Region "for all calculation"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTresult.Click

        Tpro.Text = Val(CSP.Text) + Val(ESP.Text)
        Tnet.Text = Val(CSN.Text) + Val(ESN.Text)
        Tcomm.Text = Val(CSC.Text) + Val(ESC.Text)
        Tdata.Text = Val(CSD.Text) + Val(ESD.Text)
        Thard.Text = Val(CSH.Text) + Val(ESH.Text)

        'grades for programming
        Dim mark As Integer
        mark = Tpro.Text
        If mark >= 90 And mark <= 100 Then
            Gpro.Text = "A+"
        ElseIf mark >= 80 And mark <= 89 Then
            Gpro.Text = "A"
        ElseIf mark >= 70 And mark <= 79 Then
            Gpro.Text = "B"
        ElseIf mark >= 60 And mark <= 69 Then
            Gpro.Text = "C"
        ElseIf mark >= 50 And mark <= 59 Then
            Gpro.Text = "D"
        ElseIf mark >= 40 And mark <= 49 Then
            Gpro.Text = "E"
        ElseIf mark <= 39 Then
            Gpro.Text = "F"
        End If

        'remarks
        Dim marks As Integer
        marks = Tpro.Text
        If mark >= 90 And mark <= 100 Then
            Rpro.Text = "EXCELLENT"
        ElseIf mark >= 80 And mark <= 89 Then
            Rpro.Text = "VERY GOOD"
        ElseIf mark >= 70 And mark <= 79 Then
            Rpro.Text = "GOOD"
        ElseIf mark >= 60 And mark <= 69 Then
            Rpro.Text = "CREDIT"
        ElseIf mark >= 50 And mark <= 59 Then
            Rpro.Text = "PASS"
        ElseIf mark >= 40 And mark <= 49 Then
            Rpro.Text = "PASS"
        ElseIf mark <= 39 Then
            Rpro.Text = "FAIL"
        End If

        'grades for networking
        Dim A As Integer
        A = Tnet.Text
        If A >= 90 And A <= 100 Then
            Gnet.Text = "A+"
        ElseIf A >= 80 And A <= 89 Then
            Gnet.Text = "A"
        ElseIf A >= 70 And A <= 79 Then
            Gnet.Text = "B"
        ElseIf A >= 60 And A <= 69 Then
            Gnet.Text = "C"
        ElseIf A >= 50 And A <= 59 Then
            Gnet.Text = "D"
        ElseIf A >= 40 And A <= 49 Then
            Gnet.Text = "E"
        ElseIf A <= 39 Then
            Gnet.Text = "F"
        End If

        'REMARKS for networking
        Dim AA As Integer
        AA = Tnet.Text
        If AA >= 90 And AA <= 100 Then
            Rnet.Text = "EXCELLENT"
        ElseIf AA >= 80 And AA <= 89 Then
            Rnet.Text = "VERY GOOD"
        ElseIf AA >= 70 And AA <= 79 Then
            Rnet.Text = "GOOD"
        ElseIf AA >= 60 And AA <= 69 Then
            Rnet.Text = "CREDIT"
        ElseIf AA >= 50 And AA <= 59 Then
            Rnet.Text = "PASS"
        ElseIf AA >= 40 And AA <= 49 Then
            Rnet.Text = "PASS"
        ElseIf AA <= 39 Then
            Rnet.Text = "FAIL"
        End If

        'grades for database
        Dim B As Integer
        B = Tdata.Text
        If B >= 90 And B <= 100 Then
            Gdata.Text = "A+"
        ElseIf B >= 80 And B <= 89 Then
            Gdata.Text = "A"
        ElseIf B >= 70 And B <= 79 Then
            Gdata.Text = "B"
        ElseIf B >= 60 And B <= 69 Then
            Gdata.Text = "C"
        ElseIf B >= 50 And A <= 59 Then
            Gdata.Text = "D"
        ElseIf B >= 40 And B <= 49 Then
            Gdata.Text = "E"
        ElseIf B <= 39 Then
            Gdata.Text = "F"
        End If

        'REMARKS for database
        Dim BB As Integer
        BB = Tdata.Text
        If B >= 90 And B <= 100 Then
            Rdata.Text = "EXCELLENT"
        ElseIf B >= 80 And B <= 89 Then
            Rdata.Text = "VERY GOOD"
        ElseIf B >= 70 And B <= 79 Then
            Rdata.Text = "GOOD"
        ElseIf B >= 60 And B <= 69 Then
            Rdata.Text = "CREDIT"
        ElseIf B >= 50 And A <= 59 Then
            Rdata.Text = "PASS"
        ElseIf B >= 40 And B <= 49 Then
            Rdata.Text = "PASS"
        ElseIf B <= 39 Then
            Rdata.Text = "FAIL"
        End If


        'grades for COMM SKILLS
        Dim C As Integer
        C = Tcomm.Text
        If C >= 90 And C <= 100 Then
            Gcomm.Text = "A+"
        ElseIf C >= 80 And C <= 89 Then
            Gcomm.Text = "A"
        ElseIf C >= 70 And C <= 79 Then
            Gcomm.Text = "B"
        ElseIf C >= 60 And C <= 69 Then
            Gcomm.Text = "C"
        ElseIf C >= 50 And C <= 59 Then
            Gcomm.Text = "D"
        ElseIf C >= 40 And C <= 49 Then
            Gcomm.Text = "E"
        ElseIf C <= 39 Then
            Gcomm.Text = "F"
        End If

        'REMARKS for COMMSKILL
        Dim CC As Integer
        CC = Tcomm.Text
        If C >= 90 And C <= 100 Then
            Rcomm.Text = "EXCELLENT"
        ElseIf C >= 80 And C <= 89 Then
            Rcomm.Text = "VERY GOOD"
        ElseIf C >= 70 And C <= 79 Then
            Rcomm.Text = "GOOD"
        ElseIf C >= 60 And C <= 69 Then
            Rcomm.Text = "CREDIT"
        ElseIf C >= 50 And C <= 59 Then
            Rcomm.Text = "PASS"
        ElseIf C >= 40 And C <= 49 Then
            Rcomm.Text = "PASS"
        ElseIf C <= 39 Then
            Rcomm.Text = "FAIL"
        End If

        'grades for HARDWARE
        Dim D As Integer
        D = Thard.Text
        If D >= 90 And D <= 100 Then
            Gnet.Text = "A+"
        ElseIf D >= 80 And D <= 89 Then
            Ghard.Text = "A"
        ElseIf D >= 70 And D <= 79 Then
            Ghard.Text = "B"
        ElseIf D >= 60 And D <= 69 Then
            Ghard.Text = "C"
        ElseIf D >= 50 And D <= 59 Then
            Ghard.Text = "D"
        ElseIf D >= 40 And D <= 49 Then
            Ghard.Text = "E"
        ElseIf D <= 39 Then
            Ghard.Text = "F"
        End If

        'REMARK FOR HARDWARE
        Dim DD As Integer
        DD = Thard.Text
        If DD >= 90 And DD <= 100 Then
            Rnet.Text = "EXCELLENT"
        ElseIf DD >= 80 And DD <= 89 Then
            Rhard.Text = "VERY GOOD"
        ElseIf DD >= 70 And DD <= 79 Then
            Rhard.Text = "GOOD"
        ElseIf DD >= 60 And DD <= 69 Then
            Rhard.Text = "CREDIT"
        ElseIf DD >= 50 And DD <= 59 Then
            Rhard.Text = "PASS"
        ElseIf DD >= 40 And DD <= 49 Then
            Rhard.Text = "PASS"
        ElseIf DD <= 39 Then
            Rhard.Text = "FAIL"
        End If

        'total score
        TotalScoreLB.Text = (Val(Tpro.Text) + Val(Tnet.Text) + Val(Thard.Text) + Val(Tcomm.Text) + Val(Tdata.Text)) / 5

        'GPA
        Dim DDD As Integer
        DDD = TotalScoreLB.Text
        If DDD >= 85 And DDD <= 100 Then
            GPALB.Text = "4.0  [First Class]"
        ElseIf DDD >= 80 And DDD <= 84 Then
            GPALB.Text = "3.7  [2nd Class Upper]"
        ElseIf DDD >= 75 And DDD <= 79 Then
            GPALB.Text = "3.3  [2nd Class Upper]"
        ElseIf DDD >= 70 And DDD <= 74 Then
            GPALB.Text = "3.0  [2nd Class Upper]"
        ElseIf DDD >= 65 And DDD <= 69 Then
            GPALB.Text = "2.7  [2nd Class lower]"
        ElseIf DDD >= 61 And DDD <= 64 Then
            GPALB.Text = "2.3  [2nd Class Lower]"
        ElseIf DDD >= 58 And DDD <= 60 Then
            GPALB.Text = "2.0  [3rd Class]"
        ElseIf DDD >= 55 And DDD <= 57 Then
            GPALB.Text = "1.7  [Pass]"
        ElseIf DDD >= 50 And DDD <= 54 Then
            GPALB.Text = "1.0  [Pass]"
        ElseIf DDD <= 49 Then
            GPALB.Text = "0.5   [Fail]"
        End If
    End Sub
#End Region

    Private Sub Buttlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttlogin.Click
        'login
        If TBname.Text = "KOFI" And TBindex.Text = "000" Then
            loginBox.Visible = False
        Else
            MessageBox.Show("wrong detail", "exiting", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
        LBname.Text = TBname.Text
        LBindex.Text = TBindex.Text
    End Sub

    Private Sub Buttreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttreset.Click
        TBname.Clear()
        TBindex.Clear()
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


        'If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    PrintDocument1.Print()
        'End If
        'Dim result = MessageBox.Show("Do You Want TO Print", "Printing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If (result = DialogResult.Yes) Then
        '    Marksbox.Visible = False
        'End If
    End Sub
    'clear button
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTprint.Click
        Clear(Me)
        Tpro.Text = "0"
        Thard.Text = "0"
        Tnet.Text = "0"
        Tcomm.Text = "0"
        Tdata.Text = "0"
        Gpro.Text = "0"
        Ghard.Text = "0"
        Gnet.Text = "0"
        Gcomm.Text = "0"
        Gdata.Text = "0"
        Rpro.Text = "-"
        Rhard.Text = "-"
        Rnet.Text = "-"
        Rcomm.Text = "-"
        Rdata.Text = "-"
        TotalScoreLB.Text = "-"
        GPALB.Text = "-"
    End Sub

    Private Sub ButClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'key press
    Private Sub CSC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ESP.KeyPress, ESN.KeyPress, ESH.KeyPress, ESD.KeyPress, ESC.KeyPress, CSP.KeyPress, CSN.KeyPress, CSH.KeyPress, CSD.KeyPress, CSC.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
End Class
