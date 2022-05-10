Public Class Form1

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        If UserName.Text = "winner" And Password.Text = "000" Then
            Panel1.Visible = False
        Else : MessageBox.Show("wrong details", "exiting", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        UserName.Clear()
        Password.Clear()
    End Sub

    Private Sub exit_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_bt.Click
        Dim result = MessageBox.Show("Do You Want To Exit", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel1.Visible = True
    End Sub
End Class
