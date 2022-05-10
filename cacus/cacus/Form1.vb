Public Class Form1

    Private Sub Button1ClickMethod(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nam9.Click, nam3.Click, opminus.Click, nam4.Click, nam5.Click, nam6.Click, opdvd.Click, nam7.Click, nam8.Click, opadd.Click, opcl.Click, nam0.Click, opdot.Click, optmx.Click, nam1.Click, nam2.Click, opeq.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "nam0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If

        If button.Name = "nam1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If

        If button.Name = "nam2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If

        If button.Name = "nam3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If

        If button.Name = "nam4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If

        If button.Name = "nam5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If

        If button.Name = "nam6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If

        If button.Name = "nam7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If

        If button.Name = "nam8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If

        If button.Name = "nam9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If

        If button.Name = "opadd" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If

        If button.Name = "opdvd" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If

        If button.Name = "opdot" Then
            TextBox1.Text = TextBox1.Text + "."
        End If

        If button.Name = "opminus" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If

        If button.Name = "optmx" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If

        If button.Name = "opcl" Then
            TextBox1.Text = " "
        End If

        If button.Name = "opeq" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If
    End Sub

    Private Sub backSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backSP.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub
End Class
