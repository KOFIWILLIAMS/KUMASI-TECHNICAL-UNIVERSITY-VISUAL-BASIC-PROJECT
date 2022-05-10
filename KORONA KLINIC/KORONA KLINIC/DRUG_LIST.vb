Imports MySql.Data.MySqlClient
Public Class DRUG_LIST

    'Drug list load
    Public Sub DrugsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim adaptor As New MySqlDataAdapter
        Dim tableData1 As New DataTable()
        Dim bindingsource As New BindingSource
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = korona; pooling = false; convert zero DateTime = true"

        Try


            Dim Query As String
            '  Query = " SELECT `DrugsID`, `Name`, `Quantity`, `Unit_Price`, `TotalAmount`, `Sale_Price`, `Profit`, `SaveDeduction`, `Packing_Type`, `Category`, `Alternate_drug`, `Dosage`, `Schedule`, `Expiry`, `DrugStatus` FROM `drugslist_tb`"
            Query = "SELECT `TxtCode`, `DRUG_NAME`, `DRUG_Qty`,`Sale_Unit_Price`,DrugExpiryDate FROM `drug_purchased"
            Dim CMDD = New MySqlCommand(Query, connection)
            adaptor.SelectCommand = CMDD
            adaptor.Fill(tableData1)
            bindingsource.DataSource = tableData1
            MainDataGridView1.DataSource = bindingsource
            adaptor.Update(tableData1)
            'MainDataGridView1.Columns.Add(DataGridViewColumn)
        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Friend Shared Sub DrugListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Private Sub MainDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MainDataGridView1.CellContentClick
        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow
        '    row = Me.MainDataGridView1.Rows(e.RowIndex)
        '    ADD_DRUGS.DrugsID.Text = row.Cells("DrugsID").Value.ToString
        '    ADD_DRUGS.TxtName.Text = row.Cells("Name").Value.ToString
        '    ADD_DRUGS.TxtQuantity.Text = row.Cells("Quantity").Value.ToString
        '    ADD_DRUGS.TxtUnitPrice.Text = row.Cells("Unit_Price").Value.ToString
        '    ADD_DRUGS.TxtPurchasePrice.Text = row.Cells("Purchase_Price").Value.ToString
        '    ADD_DRUGS.TxtSalePrice.Text = row.Cells("Sale_Price").Value.ToString
        '    ADD_DRUGS.TxtProfit.Text = row.Cells("Profit").Value.ToString
        '    ADD_DRUGS.TxtSavingDeduction.Text = row.Cells("SaveDeduction").Value.ToString
        '    ADD_DRUGS.CBX_PackingType.Text = row.Cells("Packing_Type").Value.ToString
        '    ADD_DRUGS.CBX_Category.Text = row.Cells("Category").Value.ToString
        '    ADD_DRUGS.CBX_ALTdrugs.Text = row.Cells("Alternate_drug").Value.ToString
        '    ADD_DRUGS.TxtDosage.Text = row.Cells("Dosage").Value.ToString
        '    ADD_DRUGS.CBX_Schedules.Text = row.Cells("Schedule").Value.ToString
        '    ADD_DRUGS.DTP_ExpiryDate.Text = row.Cells("Expiry").Value
        '    ADD_DRUGS.CBX_DrugStatus.Text = row.Cells("DrugStatus").Value.ToString
        '    ADD_DRUGS.CBX_Category.Text = row.Cells("category").Value.ToString
        '    ADD_DRUGS.CBX_ALTdrugs.Text = row.Cells("Alternate_d                                                                             rug").Value.ToString
        '    ' AddNewDrug.SaveButton.Text = "Save"

        'End If
    End Sub

    Private Sub TxtSearch_box_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch_box.TextChanged
        'search codes
        Try
            connection.Open()
            '`TxtCode`, `DRUG_NAME`, `DRUG_Qty`, `Purchase_Unit_Price`, `Purchase_TotalAmount`, `Sale_Unit_Price`, `DrugCategory`, `DrugExpiryDate`, `Sale_Qty`, `Sale_Total_Amt`
            Dim searchquery As String = "SELECT `TxtCode`, `DRUG_NAME`, `DRUG_Qty`,`Sale_Unit_Price`,DrugExpiryDate FROM `drug_purchased` WHERE  CONCAT(`DRUG_NAME`, `DRUG_Qty`, `DrugExpiryDate`) like '%" & TxtSearch_box.Text & "%' "
            command = New MySqlCommand(searchquery, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            adapter.Fill(table)

            MainDataGridView1.DataSource = table
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        ADD_DRUGS.SaveButton.Visible = False
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New ADD_DRUGS
            PanelDL.Controls.Clear()
            pro.TopLevel = False
            PanelDL.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New ADD_DRUGS
            PanelDL.Controls.Clear()
            pro.TopLevel = False
            PanelDL.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If





        'ADD_DRUGS.SaveButton.Text = "Update"
        'ADD_DRUGS.CBX_Category.Text = ""
        'ADD_DRUGS.CBX_ALTdrugs.Text = ""
        'ADD_DRUGS.CBX_PackingType.Text = ""
        'ADD_DRUGS.CBX_Schedules.Text = ""
        'ADD_DRUGS.CBX_DrugStatus.Text = ""

    End Sub

    Public Sub addBT_Click(sender As Object, e As EventArgs) Handles addBT.Click
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New ADD_DRUGS
            PanelDL.Controls.Clear()
            pro.TopLevel = False
            PanelDL.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New ADD_DRUGS
            PanelDL.Controls.Clear()
            pro.TopLevel = False
            PanelDL.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        ADD_DRUGS.ButtonUPDATE.Visible = False
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        'Dim store As String
        'If ADD_DRUGS.DrugsID.Text = "" Then
        '    MsgBox("please Enter your details")
        '    Exit Sub
        'Else
        '    store = "delete from korona.drugslist_tb where DrugsID = '" & ADD_DRUGS.DrugsID.Text & "' "
        '    delete(store)
        '    DrugsList_Load(sender, e)
        'End If

        'connection = New MySqlConnection

        'Try

        '    connection.Open()
        '    Dim i As Integer = MainDataGridView1.CurrentRow.Index

        '    Dim deletefun As String = "Delete FROM `drugslist_tb` WHERE `DrugsID` =  '" + MainDataGridView1.Item(0, i).Value + "'"
        '    command = New MySqlCommand(deletefun, connection)

        '    MsgBox("Deleted")
        '    'TxtSearch_box_TextChanged(sender, e)
        '    DrugsList_Load(sender, e)
        '    connection.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
End Class