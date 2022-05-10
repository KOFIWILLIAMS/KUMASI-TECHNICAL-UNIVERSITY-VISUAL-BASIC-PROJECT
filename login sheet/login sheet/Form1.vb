Public Class Form1
    Private Sub Buttlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttlogin.Click
        If TBUN.Text = "WAGES" And TBPW.Text = "COFY" Then
            LOGINPAGE.Visible = False
        Else
            MessageBox.Show("wrong detail", "exiting", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub Buttreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttreset.Click
        TBPW.Clear()
        TBUN.Clear()
    End Sub

    Private Sub Buttexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttexit.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTNXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNXT.Click
        BTNXT.SelectNextControl()

    End Sub

    Private Sub LOGINPAGE_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINPAGE.Enter

    End Sub

    Private Sub TBUN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBUN.TextChanged

    End Sub
End Class
