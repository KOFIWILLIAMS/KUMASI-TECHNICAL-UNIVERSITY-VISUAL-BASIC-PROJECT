Imports MySql.Data.MySqlClient
Public Class paymentForm
    Public Sub Load_Table()
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim tableData1 As New DataTable
        Dim bindingsource As New BindingSource
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family ; pooling = false; convert zero DateTime = true"

        Try

            Dim Query As String
            Query = " SELECT `F_N`, `S_N`, `N_I_N`,`amount`,`date_pay` FROM `register`"
            Dim CMDD = New MySqlCommand(Query, connection)
            adaptor.SelectCommand = CMDD
            adaptor.Fill(tableData1)
            bindingsource.DataSource = tableData1
            Record.DataGridView1.DataSource = bindingsource
            adaptor.Update(tableData1)

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BT_PAY_Click_1(sender As Object, e As EventArgs) Handles BT_PAY.Click
        'pay code
        If amount.Text = "" And P_N.Text = "" Then
            MsgBox("Enter You Details")
        Else
            Dim store As String
            Dim moni As Double = amount.Text
            store = "update ma_family.register Set `amount` = `amount` + '" & moni & "', date_pay ='" + Date_Pay.Text + "' where `P_N` = '" + P_N.Text + "'"
            save(store)
            Record.Load_Table()
            clear(Me)
        End If
    End Sub

End Class