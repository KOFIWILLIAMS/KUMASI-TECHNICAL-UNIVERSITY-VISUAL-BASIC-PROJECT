Public Class home
    'addMemeber.show
    Private Sub addBT_Click(sender As Object, e As EventArgs) Handles addBT.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New Add
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New Add
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub
    'Record.Show()
    Private Sub viewBT_Click(sender As Object, e As EventArgs) Handles viewBT.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New Record
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New Record
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FirstBT_Click(sender As Object, e As EventArgs) Handles FirstBT.Click
        Panel2.Visible = True
        FirstBT.Visible = False
    End Sub

    Private Sub MembershipToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    'Home.Show
    Private Sub HomeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Panel3.Controls.Clear()
            Me.Panel3.Show()
            Me.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Panel3.Controls.Clear()
            Me.Panel3.Show()
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
        payment_Click(sender, e)
    End Sub
    'payment.show
    Private Sub payment_Click(sender As Object, e As EventArgs) Handles payment.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New paymentForm
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New paymentForm
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ATT_BT_Click(sender As Object, e As EventArgs) Handles ATT_BT.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New ATTENDANCE
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New ATTENDANCE
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dATE_TIME.Text = Date.Now.ToString("dd MMM yyy    hh: mm : ss")
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        addBT_Click(sender, e)
    End Sub
    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        viewBT_Click(sender, e)
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        ATT_BT_Click(sender, e)
    End Sub

    Private Sub ASSESSMENT_Click(sender As Object, e As EventArgs) Handles ASSESSMENT.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New ASSESSMENT
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New ASSESSMENT
            Panel3.Controls.Clear()
            pro.TopLevel = False
            Panel3.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class