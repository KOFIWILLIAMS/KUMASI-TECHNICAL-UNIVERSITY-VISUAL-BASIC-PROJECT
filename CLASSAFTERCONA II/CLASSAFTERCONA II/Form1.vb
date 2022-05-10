Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CON As New OleDb.OleDbConnection
        CON.ConnectionString =
           "PROVIDER = Microsoft.ACE.OLEDB.12.0;DataSources = D:\SCHOOL\VISUAL BASIC\assignmentTWO\WindowsApplication1/Database.accdb"
        CON.Open()
        MsgBox("succesfull")
    End Sub
End Class
