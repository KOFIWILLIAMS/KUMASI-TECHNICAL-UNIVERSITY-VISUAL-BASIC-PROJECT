Imports MySql.Data.MySqlClient

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        Dim store As String
        If userTB.Text = "" Or passwordTB.Text = "" Then
            MsgBox("please Enter your details")
            Exit Sub
        Else
            store = "insert into phama.login(userName, password) values ('" + userTB.Text + "' , '" + passwordTB.Text + "')"
            save(store)
        End If
    End Sub

    Private Sub StoreBT_Click(sender As Object, e As EventArgs) Handles StoreBT.Click
        Dim update_info As String
        update_info = "update phama.login set password = '" + passwordTB.Text + "' where userName='" + userTB.Text + "'"
        save(update_info)
    End Sub

    'login button
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles loginBT.Click
        Try
            If userTB.Text = "" Or passwordTB.Text = "" Then
                MsgBox("fill the spaces")
                Exit Sub
            Else
                connection = New MySqlConnection(cs)
                command = New MySqlCommand("select * from phama.sign_up where Phone_N0 = '" + userTB.Text + "' and Create_Password = '" + passwordTB.Text + "'", connection)
                adaptor = New MySqlDataAdapter(command)
                tb1 = New DataTable
                adaptor.Fill(tb1)
                If tb1.Rows.Count > 0 Then
                    MsgBox("login successful")
                    Rep = userTB.Text
                    home_forms.Show()
                    Me.Close()
                Else
                    MsgBox("UserName and Password not found")
                    clear(Me)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sign_up_form.Show()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
