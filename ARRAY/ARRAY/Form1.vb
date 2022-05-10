
Private Sub Form1_Load(sender As System.Object, e As System.EventArgs)

End Sub
Public Class Form1
    Private kofi(4) As String
    Private Sub AddAray_Click(sender As System.Object, e As System.EventArgs) Handles AddAray.Click
        clearlist()

        kofi(0) = "zero"
        kofi(1) = "one"
        kofi(2) = "two"
        kofi(3) = "three"
        kofi(4) = "five"

        For num As Integer = 0 To kofi.Length - 1
            ListArray.Items.Add(kofi(num))
        Next
    End Sub
    Private Sub clearlist()
        ListArray.Items.Clear()
    End Sub

    Private Sub sort_Click(sender As System.Object, e As System.EventArgs) Handles sortttt.Click
        clearlist()
        sort_Click.array(kofi)
        For num As Integer = 0 To kofi.Length - 1
            ListArray.Items.Add(kofi(num))
        Next
    End Sub
