Public Class home_forms
    Private Sub home_forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click
        'Product.Show()
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New Product
            Panel2.Controls.Clear()
            pro.TopLevel = False
            Panel2.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New Product
            Panel2.Controls.Clear()
            pro.TopLevel = False
            Panel2.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub InvoiiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiiceToolStripMenuItem.Click

    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        Employee.Show()
    End Sub

    Private Sub IncomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomeToolStripMenuItem.Click

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'maximized and mini
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UpDateProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpDateProductToolStripMenuItem.Click

    End Sub
End Class