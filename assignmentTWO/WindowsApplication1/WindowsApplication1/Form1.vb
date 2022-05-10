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

    Private Sub Address_3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Address_3TextBox.TextChanged

    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        Data_tableBindingSource.MoveFirst()
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Data_tableBindingSource.MovePrevious()
    End Sub

    Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
        Data_tableBindingSource.MoveNext()
    End Sub

    Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
        Data_tableBindingSource.MoveLast()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Data_tableBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DatabaseDataSet)
            MsgBox("sucess")
        Catch ex As Exception
            MsgBox("Error occur, Please recheck")
        End Try
    End Sub

    Private Sub BTN_Update_Click(sender As Object, e As EventArgs) Handles BTN_Update.Click
        Try
            Data_tableBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DatabaseDataSet)
            MsgBox("sucess")
        Catch ex As Exception
            MsgBox("try again")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
