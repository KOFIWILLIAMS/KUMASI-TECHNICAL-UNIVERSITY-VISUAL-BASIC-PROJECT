Imports MySql.Data.MySqlClient
Module STOWMod
    Public connection As MySqlConnection
    Public command, cmd1, cmd2, cmd3, cmd4 As MySqlCommand
    Public adaptor As MySqlDataAdapter
    Public tableData1, tableData2, tableData3 As DataTable
    Public bindingsource As BindingSource
    Public cs As String = "server = localhost; userId = root; password = ; database = ma_family ; pooling = false; convert zero DateTime = true"
    'clear all textboxes automaticaly
#Region "Clear all text boxes"
    Public Sub clear(c As Control)
        Dim clearTextbox As TextBox
        For Each control As Control In c.Controls
            If TypeOf control Is TextBox Then
                clearTextbox = CType(control, TextBox)
                clearTextbox.Clear()
            End If
            If control.HasChildren Then
                clear(control)
            End If
        Next
    End Sub
#End Region
    'saved codes
#Region "save record"
    Public Sub save(ByVal query As String)
        Try
            connection = New MySqlConnection(cs)
            connection.Open()
            command = New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
            connection.Close()
            MsgBox("information accepted")
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
#End Region

    'update codes
#Region "update record"
    Public Sub update(ByVal query As String)
        Try
            connection = New MySqlConnection(cs)
            connection.Open()
            command = New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
            connection.Close()
            MsgBox("update is sucessfull")
        Catch Ex As Exception
            MsgBox("ex. meessage")
        Finally
            connection.Close()
        End Try
    End Sub
#End Region
    'delet codes
#Region "delete record"
    Public Sub delete(ByVal query As String)
        Try
            connection = New MySqlConnection(cs)
            connection.Open()
            command = New MySqlCommand(query, connection)
            command.ExecuteNonQuery()
            connection.Close()
            MsgBox("deleted sucessfully")
        Catch Ex As Exception
            MsgBox("ex. meessage")
        Finally
            connection.Close()
        End Try
    End Sub
#End Region
    'Public Rep As String = ""
End Module
