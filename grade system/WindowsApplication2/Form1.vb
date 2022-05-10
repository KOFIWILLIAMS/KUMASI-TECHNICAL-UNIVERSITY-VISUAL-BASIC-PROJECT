Public Class Form1
    Dim mark As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Enter only numbers", MsgBoxStyle.Critical, "error")
        ElseIf TextBox1.Text > 100 Or TextBox1.Text < 0 Then
            MsgBox("marks must be from 0 to 100")
        End If
        mark = Val(TextBox1.Text)
        If mark >= 85 And mark <= 100 Then
            MsgBox("A+")
        ElseIf mark >= 80 And mark <= 84 Then
            MsgBox("A")
        ElseIf mark >= 75 And mark <= 79 Then
            MsgBox("B+")
        ElseIf mark >= 70 And mark <= 74 Then
            MsgBox("B")
        ElseIf mark >= 65 And mark <= 69 Then
            MsgBox("C+")
        ElseIf mark >= 60 And mark <= 64 Then
            MsgBox("C")
        ElseIf mark >= 55 And mark <= 59 Then
            MsgBox("D+")
        ElseIf mark >= 50 And mark <= 54 Then
            MsgBox("D")
        ElseIf mark <= 49 Then
            MsgBox("F")
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
    
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class