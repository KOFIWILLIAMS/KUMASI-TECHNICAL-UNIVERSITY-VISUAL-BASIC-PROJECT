Imports MySql.Data.MySqlClient
Public Class PURCHASE_INVOICE

    Public Sub loaddatagrid()
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim tableData2 As New DataTable()
        Dim bindingsource As New BindingSource
        connection.ConnectionString =
        "server = localhost; userId = root; password = ; database = korona ; pooling = false; convert zero DateTime = true"

        connection.Open()
        Dim Query As String
        Query = "SELECT `TxtCode` as 'DRUG ID', `DRUG_NAME` as 'DRUG NAME', `Original_Drug_Qty` as 'TOTAL QTY', `Purchase_Unit_Price` as 'PURCHASE UNIT PRICE',
        `Purchase_TotalAmount` as 'PURCHASE TOTAL AMT', `Sale_Unit_Price` as 'SALE UNIT PRICE', `DrugCategory` as 'CATEGORY', `DrugExpiryDate` as 'EXPIRY DATE', `Sale_Total_Amt` as 'SALE TOTAL AMT' FROM `drug_purchased`"
        Dim CMDD = New MySqlCommand(Query, connection)
        adaptor.SelectCommand = CMDD
        adaptor.Fill(tableData2)
        bindingsource.DataSource = tableData2
        DataGridViewINVOICE.DataSource = bindingsource
        adaptor.Update(tableData2)
        connection.Close()
    End Sub
    Private Sub PURCHASE_INVOICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddatagrid()

    End Sub

    Private Sub DataGridViewINVOICE_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewINVOICE.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridViewINVOICE.Rows(e.RowIndex)
            TxtCode.Text = row.Cells("DRUG ID").Value.ToString
            TxtName.Text = row.Cells("DRUG NAME").Value.ToString
            TxtQuantity.Text = row.Cells("TOTAL QTY").Value.ToString
            TxtUnitPrice.Text = row.Cells("PURCHASE UNIT PRICE").Value.ToString
            TxtTotalAmount.Text = row.Cells("PURCHASE TOTAL AMT").Value.ToString
            TxtSalePrice.Text = row.Cells("SALE UNIT PRICE").Value.ToString
            'ADD_DRUGS.TxtProfit.Text = row.Cells("Profit").Value.ToString
            '  ADD_DRUGS.TxtSavingDeduction.Text = row.Cells("SaveDeduction").Value.ToString
            '  ADD_DRUGS.CBX_PackingType.Text = row.Cells("Packing_Type").Value.ToString
            CBX_Category.Text = row.Cells("CATEGORY").Value.ToString
            '  ADD_DRUGS.CBX_ALTdrugs.Text = row.Cells("Alternate_drug").Value.ToString
            '    ADD_DRUGS.TxtDosage.Text = row.Cells("Dosage").Value.ToString
            TotalSalePrice.Text = row.Cells("SALE TOTAL AMT").Value.ToString
            DTP_ExpiryDate.Text = row.Cells("EXPIRY DATE").Value
            '   ADD_DRUGS.CBX_DrugStatus.Text = row.Cells("DrugStatus").Value.ToString
            '   ADD_DRUGS.CBX_Category.Text = row.Cells("category").Value.ToString
            '  ADD_DRUGS.CBX_ALTdrugs.Text = row.Cells("Alternate_d                                                                             rug").Value.ToString
            '   AddNewDrug.SaveButton.Text = "Save"

        End If

    End Sub

    Private Sub DataGridViewINVOICE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewINVOICE.CellClick
        DataGridViewINVOICE_CellContentClick(sender, e)
    End Sub

    Private Sub TxtSearch_box_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch_box.TextChanged
        'search codes
        Try
            connection.Open()

            Dim searchquery As String = "SELECT `TxtCode` as 'DRUG ID', `DRUG_NAME` as 'DRUG NAME', `Original_Drug_Qty` as 'TOTAL QTY',
        `Purchase_Unit_Price` as 'PURCHASE UNIT PRICE', `Purchase_TotalAmount` as 'PURCHASE TOTAL AMT',
        `Sale_Unit_Price` as 'SALE UNIT PRICE', `DrugCategory` as 'CATEGORY', `DrugExpiryDate` as 'EXPIRY DATE'
        FROM `drug_purchased`  WHERE  CONCAT(`DRUG_NAME`, `DrugExpiryDate`) like '%" & TxtSearch_box.Text & "%'"
            command = New MySqlCommand(searchquery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridViewINVOICE.DataSource = table
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Delete_Click_1(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim store As String
        If TxtCode.Text = "" Then
            MsgBox("please select your details")
            Exit Sub
        Else
            store = "delete from korona.drug_purchased where txtCode = '" & TxtCode.Text & "' "
            deleted(store)
            loaddatagrid()
        End If
    End Sub

    Private Sub Btn_Edit_Click_1(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If TxtCode.Text = "" Or TxtName.Text = "" Or TxtSalePrice.Text = "" Then
            MsgBox("Enter You Details")
        Else

            Dim info As String
            info = " update korona.drug_purchased Set Purchase_TotalAmount = '" + TxtTotalAmount.Text + "', DRUG_NAME = '" + TxtName.Text + "' ,DRUG_Qty = '" + TxtQuantity.Text + "',Sale_Unit_Price = '" + TxtSalePrice.Text + "', `Sale_Total_Amt` =  '" + TotalSalePrice.Text + "'  where TxtCode = '" + TxtCode.Text + "'"
            save(info)
            MsgBox("information updated")
            loaddatagrid()
            clear(Me)
        End If
    End Sub

    Private Sub BTN_add_Click_1(sender As Object, e As EventArgs) Handles BTN_add.Click
        'insert into database
        Try
            Dim storelink As String
            storelink = " INSERT INTO `drug_purchased`(`TxtCode`, `DRUG_NAME`, `DRUG_Qty`,`Original_Drug_Qty`, `Purchase_Unit_Price`, `PURCHASE_TotalAmount`, `SALE_UNIT_Price`, `DrugCategory`, `DrugExpiryDate`, `Sale_Total_Amt`) VALUES
           ('" + TxtCode.Text + "' ,'" + TxtName.Text + "' , '" + TxtQuantity.Text + "', '" + TxtQuantity.Text + "','" + TxtUnitPrice.Text + "', '" + TxtTotalAmount.Text + "', '" + TxtSalePrice.Text + "' , '" + CBX_Category.Text + "','" + DTP_ExpiryDate.Text + "', '" + TotalSalePrice.Text + "' )" '" + Format(Now, "yyyy-MM-dd") + "')"
            save(storelink)
            MsgBox("information accepted")
            clear(Me)
            '  Load DataGrid
            loaddatagrid()

            'update

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Beep()
        End Try
    End Sub

    Private Sub TxtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles TxtUnitPrice.TextChanged
        TxtTotalAmount.Text = Val(TxtUnitPrice.Text) * Val(TxtQuantity.Text)
    End Sub

    Private Sub TxtSalePrice_TextChanged(sender As Object, e As EventArgs) Handles TxtSalePrice.TextChanged

        TotalSalePrice.Text = Val(TxtSalePrice.Text) * Val(TxtQuantity.Text)

    End Sub


End Class