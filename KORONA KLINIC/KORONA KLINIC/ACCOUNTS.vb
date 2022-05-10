Imports MySql.Data.MySqlClient
Public Class ACCOUNTS
    Public Sub loadd()
        Try
            connection = New MySqlConnection
            Dim command As New MySqlCommand
            Dim adaptor2 As New MySqlDataAdapter
            Dim tableData3 As New DataTable()
            Dim bindingsource As New BindingSource
            connection.ConnectionString =
        "server = localhost; userId = root; password = ; database = korona ; pooling = false; convert zero DateTime = true"

            connection.Open()
            Dim Query As String
            Query = "SELECT `TxtCode` as 'DRUG ID', `DRUG_NAME` as 'DRUG NAME', `DRUG_Qty` as 'DRUG QTY',
`Purchase_Unit_Price` as 'PURCHASE UNIT PRICE', `Purchase_TotalAmount` as 'PURCHASE TOTAL AMT', `Sale_Unit_Price` as 'SALE UNIT PRICE', `DrugCategory` as 'CATEGORY', `DrugExpiryDate` as 'EXPIRY DATE', `Sale_Total_Amt` as 'SALE TOTAL AMT' FROM `drug_purchased`"

            Dim CMDD = New MySqlCommand(Query, connection)
            adaptor2.SelectCommand = CMDD
            adaptor2.Fill(tableData3)
            bindingsource.DataSource = tableData3
            DataGridViewACCOUNT.DataSource = bindingsource
            adaptor2.Update(tableData3)

            'total amount paid
            Dim sum As Double = 0
            For i = 0 To DataGridViewACCOUNT.RowCount - 1
                sum += DataGridViewACCOUNT.Rows(i).Cells(4).Value
            Next
            TOTALamt.Text = sum

            'total profit
            Dim summ As Double = 0
            For i = 0 To DataGridViewACCOUNT.RowCount - 1
                summ += DataGridViewACCOUNT.Rows(i).Cells(4).Value
            Next
            totalPROFIT.Text = sum

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ACCOUNTS_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadd()
    End Sub
End Class
