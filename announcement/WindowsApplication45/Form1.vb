Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim X As String = InputBox("ENTER YOUR NAME:", "NAME", )
        Dim Y As String = InputBox("ENTER YOUR CLASS SCORE:", "CLASS SCORE", )
        Dim A As String = InputBox("ENTER YOUR EXAMS SCORE:", "EXAMS SCORE", )
        Dim G As String = InputBox("ENTER TOTAL MARKS:", "TOTAL MARKS", )
        Dim K As String = InputBox("ENTER TOTAL GRADE:", "GRADE", )

        DataGridView1.Rows.Add(X, Y, A, G, K)

    End Sub
End Class
