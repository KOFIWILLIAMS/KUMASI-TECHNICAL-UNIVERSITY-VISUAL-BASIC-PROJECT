Imports MySql.Data.MySqlClient
Public Class ATTENDANCE

    Public connection As MySqlConnection
    Public command, cmd1, cmd2, cmd3, cmd4 As MySqlCommand
    Public adaptor1, adaptor2 As MySqlDataAdapter
    Public tableData1, tableData2, tableData3 As DataTable
    Public bindingsource As BindingSource
    Public cs As String = "server = localhost; userId = root; password = ; database = ma_family ; pooling = false; convert zero DateTime = true"

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs) Handles DatePicker.ValueChanged
        DatePicker.Text = Date.Now
    End Sub

    Private Sub Filter_Click(sender As Object, e As EventArgs) Handles Filter.Click
        Dim searchquery As String = "SELECT `NO.`,`NAME`, `GENDER`, `ATTENDANCE`, `TODAYS_DATE` FROM `attendance` WHERE `TODAYS_DATE` between '" & DateStart.Text & "' and '" & DateEnd.Text & "' "

        Dim command As New MySqlCommand(searchquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridViewATTENDANCE.DataSource = table
    End Sub


    'function
    Public Sub RefreshTable()


        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim table, tableData2 As New DataTable
        Dim bindingsource As New BindingSource
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family; pooling = False; convert zero DateTime = True"

        Try

            Dim Query As String
            Query = "Select * from ma_family.attendance"
            Dim cmd3 = New MySqlCommand(Query, connection)
            adaptor.SelectCommand = cmd3
            adaptor.Fill(tableData2)
            bindingsource.DataSource = tableData2
            DataGridViewATTENDANCE.DataSource = bindingsource
            adaptor.Update(tableData2)

            'number of people
            'Label2.Text = DataGridView1.RowCount.ToString

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    'search function
    Public Sub search_And_Filter(valueToSearch As String)

        Dim searchquery As String = "SELECT `NO.`,`NAME`, `GENDER`, `ATTENDANCE`, `TODAYS_DATE` FROM `attendance` WHERE  CONCAT(`NO.`,`NAME`, `GENDER`, `ATTENDANCE`, `TODAYS_DATE`) like '%" & valueToSearch & "%' And `TODAYS_DATE` between '" & DateStart.Text & "' and '" & DateEnd.Text & "' "

        Dim command As New MySqlCommand(searchquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridViewATTENDANCE.DataSource = table

    End Sub
    'INSERT into member table
    Private Sub ATTENDANCE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor, adaptor1 As New MySqlDataAdapter
        Dim tableData1 As New DataTable
        Dim bindingsource As New BindingSource
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family; pooling = False; convert zero DateTime = True"

        Try

            Dim Query As String
            'Query = "Select * from ma_family.register"
            Query = " Select `F_N`, `S_N`, `ComboBoxGender` FROM `register`"
            Dim cmd2 = New MySqlCommand(Query, connection)
            adaptor1.SelectCommand = cmd2
            adaptor1.Fill(tableData1)
            bindingsource.DataSource = tableData1
            DataGrid.DataSource = bindingsource
            adaptor1.Update(tableData1)


        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()

        End Try

        'filter between two date
        Filter_Click(sender, e)
    End Sub
    'present BT
    Private Sub PRE_BT_Click(sender As Object, e As EventArgs) Handles PRE_BT.Click
        Dim i As Integer = DataGrid.CurrentRow.Index
        Dim store As String
        Dim MEMBER_NAME As String = DataGrid.Item(0, i).Value.ToString + " " + DataGrid.Item(1, i).Value.ToString
        Dim GENDER As String = DataGrid.Item(2, i).Value.ToString
        Dim M_ATTENDANCE As String = "PRESENT"
        'Dim REG_DATE As Date = DatePicker.Text

        store = "insert into ma_family.attendance(`NAME`, `GENDER`, `ATTENDANCE`, `TODAYS_DATE`) VALUES
('" + MEMBER_NAME + "' , '" + GENDER + "','" + M_ATTENDANCE + "', '" + DatePicker.Text + "')"
        save(store)
        'search between date
        Filter_Click(sender, e)

    End Sub
    'absent TB
    Private Sub ABS_BT_Click(sender As Object, e As EventArgs) Handles ABS_BT.Click
        Dim i As Integer = DataGrid.CurrentRow.Index
        Dim store As String
        Dim MEMBER_NAME As String = DataGrid.Item(0, i).Value.ToString + " " + DataGrid.Item(1, i).Value.ToString
        Dim GENDER As String = DataGrid.Item(2, i).Value.ToString
        Dim M_ATTENDANCE As String = "ABSENT"
        'Dim REG_DATE As Date = DatePicker.Text

        store = "insert into ma_family.attendance(`NAME`, `GENDER`, `ATTENDANCE`, `TODAYS_DATE`) VALUES
('" + MEMBER_NAME + "' , '" + GENDER + "','" + M_ATTENDANCE + "', '" + DatePicker.Text + "')"
        save(store)
        'filter between two date
        Filter_Click(sender, e)
        'RefreshTable()
    End Sub

    Private Sub search2_TextChanged(sender As Object, e As EventArgs) Handles search2.TextChanged
        search_And_Filter(search2.Text)
    End Sub

    Private Sub DateTimeS_ValueChanged(sender As Object, e As EventArgs) Handles DateEnd.ValueChanged
        search_And_Filter(DateEnd.Text)
    End Sub
End Class