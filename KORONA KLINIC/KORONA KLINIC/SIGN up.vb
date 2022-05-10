Imports MySql.Data.MySqlClient
Public Class SIGN_up
    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        Dim store As String
        If First_Name.Text = "" Or Sure_Name.Text = "" Then
            MsgBox("please Enter your details")
            Exit Sub
        Else

            store = "INSERT INTO korona.sign_in(`First_Name`, `Sure_Name`, `Email`, `Phone_Num`, `Date_O_Birth`, `PassWord`) values 
('" + First_Name.Text + "' , '" + Sure_Name.Text + "','" + Email.Text + "', '" + Phone_Num.Text + "', '" + Date_O_Birth.Text + "' , '" + PassWord.Text + "')"
            save(store)
            Me.Close()
            Form1.FrontPanel.Show()
        End If

    End Sub

    Private Sub BT_CLEAR_Click(sender As Object, e As EventArgs) Handles BT_CLEAR.Click
        clear(Me)
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles BTN_Update.Click
        If First_Name.Text = "" And Sure_Name.Text = "" Then
            MsgBox("Enter You Details")
        Else

            Dim update As String
            update = "update korona.sign_in Set First_Name = '" + First_Name.Text + "', Sure_Name = '" + Sure_Name.Text + "' ,Email = '" + Email.Text + "', PassWord = '" + PassWord.Text + "',Date_O_Birth = '" + Date_O_Birth.Text + "' where Phone_Num = '" + Phone_Num.Text + "'"
            save(update)
            'Record.Load_Table()
            clear(Me)
        End If
    End Sub
End Class