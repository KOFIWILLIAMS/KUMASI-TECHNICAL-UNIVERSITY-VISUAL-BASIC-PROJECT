Public Class Form1
    Dim vVv As Integer = Nothing
    Dim price As Integer = Nothing
    Dim custmName As String = Nothing
    Dim discount As Double = Nothing
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        vVv = Val(VI.Text)
        price = Val(AM.Text)
        If vVv >= 3 Then
            If price >= 250 Then
                discount = 0.15 * price
                MsgBox("your is discount is " & discount)
            Else
                discount = 0.1 * price
                MsgBox("your discount is " & discount)
            End If
        ElseIf vVv < 3 And price >= 500 Then
            discount = 0.05 * price
            MsgBox("your discount is " & discount)
        End If

    End Sub
End Class
