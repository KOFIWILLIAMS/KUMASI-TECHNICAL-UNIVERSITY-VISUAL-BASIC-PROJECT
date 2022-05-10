Public Class Form1
    Dim kof, koo As Integer
    Private Sub BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT.Click
        koo = Val(TB.Text)
        For kof = 0 To koo Step 2
            result.Items.Add(kof & ",")
        Next
    End Sub

    Private Sub odd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles odd.Click
        koo = Val(TB.Text)
        For kof = 1 To koo Step 2
            result.Items.Add(kof & ",")
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TB.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If kof < 1 Then
            koo = 1
        Else
            koo = kof * koo * (kof - 1)
        End If
        result.Items.Add(koo & ",")
    End Sub
End Class
