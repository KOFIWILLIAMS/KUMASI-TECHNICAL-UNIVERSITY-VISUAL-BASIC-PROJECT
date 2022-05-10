Public Class Form1
    Private Sub ADD_Click(sender As Object, e As EventArgs) Handles ADD.Click
        TT.Text = Val(N1.Text) + Val(N2.Text)

    End Sub



    Private Sub SU_Click(sender As Object, e As EventArgs) Handles SU.Click
        TT.Text = Val(N1.Text) - Val(N2.Text)
    End Sub



    Private Sub MULTY_Click(sender As Object, e As EventArgs) Handles MULTY.Click
        TT.Text = Val(N1.Text) * Val(N2.Text)
    End Sub


    Private Sub DVD_Click(sender As Object, e As EventArgs) Handles DVD.Click
        TT.Text = Val(N1.Text) / Val(N2.Text)
    End Sub



    Private Sub cl_Click(sender As Object, e As EventArgs) Handles cl.Click
        TT.Text = "00"
        N2.Text = "0"
        N1.Text = "0"
    End Sub
End Class
