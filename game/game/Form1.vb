Public Class Form1
    Dim SCORE As Integer
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Top -= 5
        Label2.Top -= 5
        Label3.Top -= 5

        timer.Text = "SCORE : " & SCORE

        SPEED()
    End Sub

    Sub SPEED()
        If SCORE >= 10 And SCORE <= 20 Then
            Timer1.Interval = 80

        ElseIf SCORE >= 30 And SCORE <= 40 Then
            Timer1.Interval = 60

        ElseIf SCORE >= 50 And SCORE <= 60 Then
            Timer1.Interval = 40

        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label1.Location.Y < -50 Or Label2.Location.Y < -50 Or Label3.Location.Y < -50 Then

            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False

            GAMEover.Visible = True

            timer.Visible = False

            result.Visible = True
            result.Text = " YOUR SCORE IS : " & vbCrLf & SCORE

            CLOSEr.Visible = True
            RESERT.Visible = True


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEr.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub RESERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESERT.Click
        Me.Hide()
        Dim openanother As New Form1
        openanother.Show()
    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        SCORE += 5
        Label2.Location = New Point(317, 313)
    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        SCORE += 5
        Label3.Location = New Point(506, 388)
    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        SCORE += 5
        Label1.Location = New Point(167, 479)
    End Sub
End Class
