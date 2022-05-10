Public Class Form1
    Private Sub Data_tableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Data_tableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Data_tableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.data_table' table. You can move, or remove it, as needed.
        Me.Data_tableTableAdapter.Fill(Me.DatabaseDataSet.data_table)

    End Sub
End Class
