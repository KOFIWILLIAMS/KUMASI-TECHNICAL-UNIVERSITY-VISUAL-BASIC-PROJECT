Public Class sign_up_form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles signUP.Click
        Dim store As String
        If First_Name.Text = "" Or Last_Name.Text = "" Then
            MsgBox("please Enter your details")
            Exit Sub
        Else
            If rd_Male.Checked = True Then
                store = "insert into phama.sign_up(First_Name, Last_Name, Phone_N0,Email, GENDER ,D_O_B, Create_Password, Confirm_Password, Question, Answer ) values ('" + First_Name.Text + "' , '" + Last_Name.Text + "','" + Phone_N0.Text + "', '" + Email.Text + "', '" + rd_Male.Text + "' , '" + D_O_Birth.Text + "', '" + Create_Password.Text + "','" + Confirm_Password.Text + "', '" + Question.Text + "', '" + Answer.Text + "')"
            Else
                store = "insert into phama.sign_up(First_Name, Last_Name, Phone_N0,Email, GENDER ,D_O_B, Create_Password, Confirm_Password, Question, Answer ) values ('" + First_Name.Text + "' , '" + Last_Name.Text + "','" + Phone_N0.Text + "', '" + Email.Text + "', '" + rd_Female.Text + "' , '" + D_O_Birth.Text + "', '" + Create_Password.Text + "','" + Confirm_Password.Text + "', '" + Question.Text + "', '" + Answer.Text + "')"

            End If

            save(store)
            Me.Close()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub rd_Male_CheckedChanged(sender As Object, e As EventArgs) Handles rd_Male.CheckedChanged


    End Sub

    Private Sub rd_Female_CheckedChanged(sender As Object, e As EventArgs) Handles rd_Female.CheckedChanged


    End Sub
End Class