Module Module1
    Sub cblev1(ByVal Button1 As Button, ByVal Button2 As Button)
        If Button2.Text = "" Then
            Button2.Text = Button1.Text
            Button1.Text = ""
        End If

    End Sub
End Module
