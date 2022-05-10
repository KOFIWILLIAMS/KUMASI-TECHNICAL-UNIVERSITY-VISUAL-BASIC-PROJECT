Public Class Form1

    Private Sub even_Click(sender As System.Object, e As System.EventArgs) Handles even.Click
        Dim nu As Integer
        Dim nuum As Integer
        nuum = Val(data.Text)
        For nu = 1 To nuum Step 2
            MsgBox(Str(nu) & vbCrLf)
        Next
    End Sub
End Class
