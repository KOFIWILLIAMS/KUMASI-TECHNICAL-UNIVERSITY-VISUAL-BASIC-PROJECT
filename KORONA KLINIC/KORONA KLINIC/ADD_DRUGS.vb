Imports MySql.Data.MySqlClient
Public Class ADD_DRUGS
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
            Query = " SELECT `SALES_ID` as 'No.', `D_NAME` as 'DRUG NAME', `QUANTITY` , `AMOUNT`,  `CATEGORY`,`DATE`    FROM  `korona`.`SALES_APPOINTMENT` WHERE  `DATE`  between '" & DateStart.Text & "' and '" & DateEnd.Text & "' "
            Dim CMDD = New MySqlCommand(Query, connection)
            adaptor2.SelectCommand = CMDD
            adaptor2.Fill(tableData3)
            bindingsource.DataSource = tableData3
            DataGridBUY.DataSource = bindingsource
            adaptor2.Update(tableData3)

            'total amount paid
            Dim sum As Double = 0
            For i = 0 To DataGridBUY.RowCount - 1
                sum += DataGridBUY.Rows(i).Cells(2).Value
            Next
            TOTALamt.Text = sum

            ''total profit
            'Dim summ As Double = 0
            'For i = 0 To DataGridBUY.RowCount - 1
            '    summ += DataGridBUY.Rows(i).Cells(4).Value
            'Next
            'totalPROFIT.Text = sum

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    'insert into sale appointment  / update drug purchase
    Public Sub insert_sales()

        Dim sto As String
        sto = "INSERT INTO `sales_appointment`(`D_NAME`, `QUANTITY`, `SELLING_)P`, `AMOUNT`, `QTY_IN_STOCK`, `CATEGORY`, `Date`) VALUES
    ('" + ComboBoxNAME.Text + "' ,'" + TxtQuantity.Text + "' , '" + TxtSaleUnitPrice.Text + "', '" + amountTB.Text + "', '" + TxtAvailabeQty.Text + "', '" + Category.Text + "' , '" + Format(Now, "yyyy-MM-dd") + "')"
        save(sto)
        'clear(Me)

        'update main table

        Dim info As String
        info = " update korona.drug_purchased Set Purchase_TotalAmount = Purchase_TotalAmount - '" + amountTB.Text + "', DRUG_Qty = DRUG_Qty - '" + TxtQuantity.Text + "' where TxtCode = '" + TxtCode.Text + "'"
        save(info)

        MsgBox("Sales made successfully.")
        loadd()


        'Select Case`D_NAME`, `QUANTITY`, `SELLING_)P`, `AMOUNT`, `SALES_ID`, `QTY_IN_STOCK`, `CATEGORY`, `DATE` FROM `sales_appointment` WHERE 1
    End Sub

    '    Private Sub SaveButton_Click_1(sender As Object, e As EventArgs) Handles SaveButton.Click
    '        Dim store As String
    '        If DrugsID.Text = "" Or TxtName.Text = "" Or TxtSalePrice.Text = "" Then
    '            MsgBox("please Enter your details")
    '            Exit Sub
    '        Else

    '            store = "insert into korona.drugslist_tb (`DrugsID`, `Name`, `Quantity`, `Unit_Price`, `Purchase_Price`, `Sale_Price`, `Profit`, `SaveDeduction`, `Packing_Type`, `Category`, `Alternate_drug`, `Dosage`, `Schedule`, `Expiry`, `DrugStatus`) VALUES
    '('" + DrugsID.Text + "','" + TxtName.Text + "' , '" + TxtQuantity.Text + "','" + TxtUnitPrice.Text + "', '" + TxtPurchasePrice.Text + "', '" + TxtSalePrice.Text + "' , '" + TxtProfit.Text + "', '" + TxtSavingDeduction.Text + "','" + CBX_PackingType.Text + "', '" + CBX_Category.Text + "','" + CBX_ALTdrugs.Text + "','" + TxtDosage.Text + "','" + CBX_Schedules.Text + "','" + DTP_ExpiryDate.Text + "','" + CBX_DrugStatus.Text + "')"
    '            save(store)
    '            clear(Me)
    '        End If


    '        '        Dim storeLink As String
    '        '        If SaveButton.Text = "Save" Then
    '        '            If TxtName.Text = "" Or TxtSalePrice.Text = "" Then
    '        '                MsgBox("please Enter your details")
    '        '                Exit Sub
    '        '            Else
    '        '                Try

    '        '                    storeLink = "INSERT INTO `drugslist_tb` (`DrugsID`, `Name`, `Quantity`, `Unit_Price`, `Purchase_Price`, `Sale_Price`, `Profit`, `SaveDeduction`, `Packing_Type`, `Category`, `Alternate_drug`, `Dosage`, `Schedule`, `Expiry`, `DrugStatus`) VALUES 
    '        '('" + DrugID.Text + "'" + TxtName.Text + "' , '" + TxtQuantity.Text + "','" + TxtUnitPrice.Text + "', '" + TxtPurchasePrice.Text + "', '" + TxtSalePrice.Text + "' , '" + TxtProfit.Text + "', '" + TxtSavingDeduction.Text + "','" + CBX_PackingType.Text + "', '" + CBX_Category.Text + "','" + CBX_ALTdrugs.Text + "','" + TxtDosage.Text + "','" + CBX_Schedules.Text + "','" + DTP_ExpiryDate.Text + "','" + CBX_DrugStatus.Text + "')"
    '        '                    save(storeLink)
    '        '                    'Me.Close()

    '        '                    'DRUG_LIST.DrugListToolStripMenuItem_Click(sender, e)
    '        '                    'ADD_DRUGS.DrugsList_Load()
    '        '                    clear(Me)

    '        '                Catch ex As Exception
    '        '                    MessageBox.Show(ex.Message)
    '        '                End Try
    '        '            End If

    '        '        Else

    '        '            If TxtName.Text = "" Or TxtSalePrice.Text = "" Then
    '        '                MsgBox("please Enter your details")
    '        '                Exit Sub
    '        '            Else
    '        '                Try
    '        '                    storeLink = "update `drugslist_tb` Set `Name` = '" + TxtName.Text + "', `Quantity` = '" + TxtQuantity.Text + "' ,`Unit_Price` = '" + TxtUnitPrice.Text + "',`Purchase_Price` = '" + TxtPurchasePrice.Text + "',`Sale_Price` = '" + TxtSalePrice.Text + "',`Profit` = '" + TxtProfit.Text + "',`SaveDeduction` = '" + TxtSavingDeduction.Text + "',`Packing_Type` = '" + CBX_PackingType.Text + "',`category` = '" + CBX_Category.Text + "',`alternate_drug` = '" + CBX_ALTdrugs.Text + "',`dosage` = '" + TxtDosage.Text + "',`schedule` = '" + CBX_Schedules.Text + "',`schedule` = '" + CBX_Schedules.Text + "',`expiry` = '" + DTP_ExpiryDate.Text + "',`DrugStatus` = '" + CBX_DrugStatus.Text + "' where `DrugsID` = '" + DrugID.Text + "'"
    '        '                    'Update(storeLink)
    '        '                    Me.Close()
    '        '                    'Form1.DrugListToolStripMenuItem_Click(sender, e)
    '        '                    clear(Me)

    '        '                Catch ex As Exception
    '        '                    MessageBox.Show(ex.Message)
    '        '                End Try
    '        '            End If
    '        '        End If
    '    End Sub

    '    Private Sub ButtonUPDATE_Click(sender As Object, e As EventArgs) Handles ButtonUPDATE.Click
    '        If DrugsID.Text = "" Or TxtName.Text = "" Or TxtSalePrice.Text = "" Then
    '            MsgBox("Enter You Details")
    '        Else

    '            Dim info As String
    '            info = " update korona.drugslist_tb Set Purchase_Price = '" + TxtPurchasePrice.Text + "', Name = '" + TxtName.Text + "' ,Quantity = '" + TxtQuantity.Text + "' where DrugsID = '" + DrugsID.Text + "'"
    '            save(info)
    '            'Record.Load_Table()
    '            clear(Me)
    '        End If

    '    End Sub

    Private Sub ADD_DRUGS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadd()
        'fill combobox from database using MySqlDataAdapter
        'Try
        checkconnection()
        connection.Open()
        Dim adapter2 As New MySqlDataAdapter("SELECT * FROM `korona`.`drug_purchased`", connection)
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        ComboBoxNAME.DataSource = table2
        ComboBoxNAME.ValueMember = "TxtCode"
        ComboBoxNAME.DisplayMember = "DRUG_NAME"
        connection.Close()
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub



    'Try

    '    connection.Open()
    '    Dim myReader As MySqlDataReader
    '    connection = New MySqlConnection
    '    Dim query As String = "SELECT * FROM `korona`.`drug_purchased` where Drug_name = '" & ComboBoxNAME.Text & "'"
    '    Dim command As New MySqlCommand(query, connection)
    '    myReader = command.ExecuteReader()
    '    While myReader.Read()
    '        Dim selectname = myReader.GetString("DRUG_NAME")
    '        ComboBoxNAME.Items.Add(selectname)
    '        ' Select Case`TxtCode`, `DRUG_NAME`, `DRUG_Qty`, `Drug_Unit_Price`, `Purchase_Price`, `DrugSalePrice`, `DrugCategory`, `DrugExpiryDate` FROM `drug_purch
    '    End While
    '    connection.Close()
    'Catch ex As Exception
    '    MsgBox(ex.Message)
    ''End Try

    'Try
    '    connection.Open()
    '    ' Dim query As String = "SELECT * FROM korona.drug_purchased"
    '    ' Dim command As New MySqlCommand(query, connection)
    '    Dim adaptor As New MySqlDataAdapter("SELECT * FROM korona.drug_purchased", command)
    '    Dim tableData2 As New DataTable()
    '    adaptor.Fill(tableData2)

    '    ComboBoxNAME.DataSource = tableData2
    '    ComboBoxNAME.DisplayMember = "DRUG_NAME"
    '    ComboBoxNAME.ValueMember = "TxtCode"
    '    connection.Close()
    'Catch ex As Exception
    '    MsgBox(ex.Message)

    'End Try


    Private Sub ComboBoxNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNAME.SelectedIndexChanged
        Try
            checkconnection()
            connection.Open()
            If ComboBoxNAME.Text = "" Then

            Else
                Dim table As New DataTable()
                'Select Case`TxtCode`, `DRUG_NAME`, `DRUG_Qty`, `Purchase_Unit_Price`, `Purchase_TotalAmount`, `Sale_Unit_Price`, `DrugCategory`, `DrugExpiryDate`, `Sale_Qty`, `Sale_Total_Amt` FROM `drug_purchased`
                'SELECT `TxtCode`, `DRUG_NAME`, `DRUG_Qty`, `Purchase_Unit_Price`, `Purchase_TotalAmount`, `Sale_Unit_Price`, `DrugCategory`, `DrugExpiryDate`, `Sale_Qty`, `Sale_Total_Amt` FROM `drug_purchased
                Dim adapter2 As New MySqlDataAdapter("SELECT `TxtCode`, `DRUG_NAME`, `DRUG_Qty`, `Purchase_Unit_Price`, `Purchase_TotalAmount`, `Sale_Unit_Price`, `DrugCategory`, `DrugExpiryDate`, `Sale_Qty`, `Sale_Total_Amt` FROM `drug_purchased` where `txtCode` = " & ComboBoxNAME.SelectedValue, connection)
                    adapter2.Fill(table)
                TxtCode.Text = table(0)(0)
                Category.Text = table(0)(6)
                TxtSaleUnitPrice.Text = table(0)(5)
                TxtAvailabeQty.Text = table(0)(2)
                DTP_ExpiryDate.Value = table(0)(7)

            End If
            connection.Close()
        Catch ex As Exception
            ' MsgBox(ex.Message)

        End Try


    End Sub

    Sub checkconnection()
        If ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    Private Sub TxtQuantity_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantity.TextChanged

        If Val(TxtQuantity.Text) > Val(TxtAvailabeQty.Text) Then
            MsgBox("Quantity Is out Of stock")
        Else
            amountTB.Text = Val(TxtQuantity.Text) * Val(TxtSaleUnitPrice.Text)

        End If

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'insert into database
        Try
            'datecheck
            Dim checkExpired As Integer
            checkExpired = DateDiff(DateInterval.Month, Now.Date, DTP_ExpiryDate.Value)
            If checkExpired < 1 Then
                MsgBox("Expired Date Is near")
                'DTP_ExpiryDate.CalendarMonthBackground = Color.Red
            Else

                connection.Open()


                insert_sales()
            End If
            'Load DataGrid

            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ButtonUPDATE_Click(sender As Object, e As EventArgs) Handles ButtonUPDATE.Click

        Dim info As String
        Dim NewQuantity = TxtQuantity.Text
        Dim newStock = TxtAvailabeQty.Text
        info = " update `korona`.`selling_table` Set `QUANTITY` = `QUANTITY` + '" & NewQuantity & " ',  `IN_STOCK` =`IN_STOCK` - '" & newStock & "', `SELLING_P` = '" + TxtSaleUnitPrice.Text + "', `D_NAME` = '" + ComboBoxNAME.Text + "' where `DRUG_ID` = '" + TxtCode.Text + "'"
        save(info)
        'loaddatagrid()
        loadd()
        clear(Me)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        'after delete update the main table by adding the deleted values
        Dim info As String
        info = " update korona.drug_purchased Set Purchase_TotalAmount = Purchase_TotalAmount + '" + amountTB.Text + "', DRUG_Qty = DRUG_Qty + '" + TxtQuantity.Text + "' where TxtCode = '" + TxtCode.Text + "'"
        save(info)

        Dim deletequery As String
        If DataGridBUY.RowCount = 0 Then
            deletequery = " Truncate korona.sales_appointment"
            deleted(deletequery)
            MsgBox("Delete successful")
        Else




            'deletequery = " delete from korona.sales_appointment  where `SALES_ID` = '" & DataGridBUY.Item("No.", i).Value.ToString & "' "
            'deletequery = " delete from korona.sales_appointment  where SALES_ID = '" & DataGridBUY.SelectedRows(i).Cells(0).Value.ToString & "' "

            MsgBox("Deleted  ")

        End If





        loadd()



    End Sub

    'refresh table
    Private Sub DateStart_ValueChanged(sender As Object, e As EventArgs) Handles DateStart.ValueChanged
        loadd()
    End Sub

    Private Sub DateEnd_ValueChanged(sender As Object, e As EventArgs) Handles DateEnd.ValueChanged
        loadd()
    End Sub

    Private Sub DataGridBUY_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBUY.CellContentClick
        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow
        '    row = Me.DataGridBUY.Rows(e.RowIndex)

        '    Dim numberID As Integer = row.Cells("No.").Value.ToString


    End Sub
End Class