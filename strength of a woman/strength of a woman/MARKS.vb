Imports MySql.Data.MySqlClient
Public Class ASSESSMENT
    Public Sub ASSESSMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family; pooling = False; convert zero DateTime = True"

        Try
            connection.Open()
            Dim Query As String
            Query = "Select  `F_N`, `S_N`, `P_N` from `register`"
            Dim cmd1 = New MySqlCommand(Query, connection)
            reader = cmd1.ExecuteReader
            While reader.Read()
                Dim FirstName As String = reader.GetString("F_N")
                Dim secondName As String = reader.GetString("S_N")
                Dim cellNo As String = reader.GetString("P_N")

                SearchByName.Items.Add(FirstName & " " & secondName)
                'how to insect phone no into their textbox
                If SearchByName.Text = FirstName & " " & secondName Then
                    DateOfBirth.Text = cellNo
                End If

            End While

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub SearchByName_TextChanged(sender As Object, e As EventArgs) Handles SearchByName.TextChanged
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family; pooling = False; convert zero DateTime = True"

        Try
            connection.Open()
            Dim Query As String
            Query = "Select  `F_N`, `S_N`, `P_N` from `register`"
            Dim cmd1 = New MySqlCommand(Query, connection)
            reader = cmd1.ExecuteReader
            While reader.Read()
                Dim FirstName As String = reader.GetString("F_N")
                Dim secondName As String = reader.GetString("S_N")
                Dim cellNo As String = reader.GetString("P_N")

                'SearchByName.Items.Add(FirstName & " " & secondName)
                'how to insect phone no into their textbox
                If SearchByName.Text = FirstName & " " & secondName Then
                    DateOfBirth.Text = cellNo
                End If

            End While

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New MySqlConnection
        Dim command As New MySqlCommand
        Dim reader As MySqlDataReader
        connection.ConnectionString =
"server = localhost; userId = root; password = ; database = ma_family; pooling = False; convert zero DateTime = True"

        Try
            connection.Open()
            Dim Query As String
            Query = "Select  `F_N`, `S_N`, `P_N` from `register`"
            Dim cmd1 = New MySqlCommand(Query, connection)
            reader = cmd1.ExecuteReader
            While reader.Read()
                Dim FirstName As String = reader.GetString("F_N")
                Dim secondName As String = reader.GetString("S_N")
                Dim cellNo As String = reader.GetString("P_N")

                ' DataGridAsses.Add(FirstName & " " & secondName)
                'how to insect phone no into their textbox
                If SearchByName.Text = FirstName & " " & secondName Then
                    DateOfBirth.Text = cellNo
                End If

            End While

        Catch Ex As MySqlException
            MsgBox(Ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class