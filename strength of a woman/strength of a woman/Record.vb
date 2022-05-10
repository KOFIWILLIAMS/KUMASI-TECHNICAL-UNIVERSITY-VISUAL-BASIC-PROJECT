Imports MySql.Data.MySqlClient
Public Class Record

    'Load_Table()
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
            Query = " SELECT `F_N`, `S_N`, `ComboBoxGender`, `N_I_N`, `P_N`, `Date_O_B`, `P_O_B`, `G_P_A`, `ComboBoxMarital`,`amount`,`date_pay` FROM `register`"
            Dim CMDD = New MySqlCommand(Query, connection)
            adaptor.SelectCommand = CMDD
            adaptor.Fill(tableData1)
            bindingsource.DataSource = tableData1
            DataGridView1.DataSource = bindingsource
            adaptor.Update(tableData1)

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Public Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            Add.F_N.Text = row.Cells("F_N").Value.ToString
            Add.S_N.Text = row.Cells("S_N").Value.ToString
            Add.ComboBoxGender.Text = row.Cells("ComboBoxGender").Value.ToString
            Add.N_I_N.Text = row.Cells("N_I_N").Value.ToString
            Add.P_N.Text = row.Cells("P_N").Value.ToString
            Add.P_N.Text = row.Cells("G_P_A").Value.ToString
            Add.P_N.Text = row.Cells("ComboBoxMarital").Value.ToString

            paymentForm.F_N.Text = row.Cells("F_N").Value.ToString
            paymentForm.P_N.Text = row.Cells("P_N").Value.ToString
            'paymentForm.amount.Text = row.Cells("amount").Value.ToString

        End If
    End Sub

    'refresh
    Private Sub BT_REFRESH_Click(sender As Object, e As EventArgs) Handles BT_REFRESH.Click

        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim tableData1 As New DataTable
        Dim bindingsource As New BindingSource
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family; pooling = False; convert zero DateTime = True"

        Try

            Dim Query As String
            'Query = "Select * from ma_family.register"
            Query = " Select `F_N`, `S_N`, `ComboBoxGender`, `N_I_N`, `P_N`, `Date_O_B`, `P_O_B`, `G_P_A`, `ComboBoxMarital`,`amount`,`date_pay` FROM `register`"
            Dim cmd2 = New MySqlCommand(Query, connection)
            adaptor.SelectCommand = cmd2
            adaptor.Fill(tableData1)
            bindingsource.DataSource = tableData1
            DataGridView1.DataSource = bindingsource
            adaptor.Update(tableData1)

            'number of people
            Label2.Text = DataGridView1.RowCount.ToString

            'total amount paid
            Dim sum As Double = 0
            For i = 0 To DataGridView1.RowCount - 1
                sum += DataGridView1.Rows(i).Cells(9).Value
            Next
            Label5.Text = sum

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub
    'update
    Private Sub BT_UPDATE_Click(sender As Object, e As EventArgs) Handles BT_UPDATE.Click
        'loading add form for update
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            home.Panel3.Controls.Clear()
            Add.TopLevel = False
            home.Panel3.Controls.Add(Add)
            Add.Show()
            Add.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            home.Panel3.Controls.Clear()
            Add.TopLevel = False
            home.Panel3.Controls.Add(Add)
            Add.Show()
            Add.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
        Add.BT_SAVE.Visible = False
        Add.BTupdate.Visible = True

    End Sub
    'search function
    Public Sub SearchFilter(valueToSearch As String)

        Dim searchquery As String = "SELECT `F_N`, `S_N`, `ComboBoxGender`, `N_I_N`, `P_N`, `Date_O_B`, `P_O_B`, `G_P_A`, `ComboBoxMarital`,`amount`,`date_pay` FROM `register` WHERE  CONCAT(`F_N`, `S_N`, `P_N`) like '%" & valueToSearch & "%' "

        Dim command As New MySqlCommand(searchquery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    'search
    Private Sub searchTB_TextChanged(sender As Object, e As EventArgs) Handles searchTB.TextChanged
        SearchFilter(searchTB.Text)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Dim connection As MySqlConnection = Nothing
        'Try
        '    Dim picture = "SELECT * image from ma_family.register"
        '    Dim imageData As Byte() = Direct
        '    Dim newImage As Image = Nothing
        '    If Not imageData Is Nothing Then
        '        Using ms As New MemoryStreams.WrIte(imageData, 0, newImage = Image.FromStream)
        '        End Using image1.Image = newImage
        '    End If
        'Catch ex As Exception
        '    ReportError(ex)
        'End Try
    End Sub
    'delete
    Private Sub BT_DELETE_Click(sender As Object, e As EventArgs) Handles BT_DELETE.Click
        Dim store As String
        If Add.F_N.Text = "" Then
            MsgBox("please Enter your details")
            Exit Sub
        Else
            store = "delete from ma_family.register where F_N = '" & Add.F_N.Text & "' "
            delete(store)
            Load_Table()
        End If
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BT_REFRESH_Click(sender, e)
    End Sub

    Private Sub addBT_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New Add
            home.Panel3.Controls.Clear()
            pro.TopLevel = False
            home.Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New Add
            home.Panel3.Controls.Clear()
            pro.TopLevel = False
            home.Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow
        '    Dim selectedname As String
        '    row = Me.DataGridView1.Rows(e.RowIndex)
        '    selectedname = row.Cells("F_N").Value.ToString
        'End If
        'Dim showpic As Image = "SELECT `PicBox` FROM `register` WHERE F_N = " bennet " "
        '    PictureBox2.Image = showpic
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles paY.Click

        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            home.Panel3.Controls.Clear()
            paymentForm.TopLevel = False
            home.Panel3.Controls.Add(paymentForm)
            paymentForm.Show()
            paymentForm.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            home.Panel3.Controls.Clear()
            paymentForm.TopLevel = False
            home.Panel3.Controls.Add(paymentForm)
            paymentForm.Show()
            paymentForm.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

End Class