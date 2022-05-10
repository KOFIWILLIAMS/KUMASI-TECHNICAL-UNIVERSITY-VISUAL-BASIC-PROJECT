Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles TOPPanel.Paint

    End Sub

    Private Sub BTsignUP_Click(sender As Object, e As EventArgs) Handles BTsignUP.Click
        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New SIGN_up
            FrontPanel.Controls.Clear()
            pro.TopLevel = False
            FrontPanel.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New SIGN_up
            FrontPanel.Controls.Clear()
            pro.TopLevel = False
            FrontPanel.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LEFTPanel.Enabled = False
        RIGHTPanel.Enabled = False
        MenuStrip1.Enabled = False
        'LabWelcom.Visible = False
        PURCHASE_INVOICE.loaddatagrid()
    End Sub

    Private Sub ButLOGIN_Click(sender As Object, e As EventArgs) Handles ButLOGIN.Click
        If emailTB.Text = "0" And passwordTB.Text = "1" Then
            LEFTPanel.Enabled = True
            RIGHTPanel.Enabled = True
            FrontPanel.Visible = False
            MenuStrip1.Enabled = True
            'LabWelcom.Visible = True

        End If
    End Sub

    Private Sub ButtonDrugs_Click(sender As Object, e As EventArgs) Handles ButtonDrugs.Click
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New DRUG_LIST
            MAINPanel.Controls.Clear()
            pro.TopLevel = False
            MAINPanel.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New DRUG_LIST
            MAINPanel.Controls.Clear()
            pro.TopLevel = False
            MAINPanel.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ButtonIVOICE_Click(sender As Object, e As EventArgs) Handles ButtonIVOICE.Click
        If WindowState = FormWindowState.Maximized Then
            Dim pro1 As New PURCHASE_INVOICE
            MAINPanel.Controls.Clear()
            pro1.TopLevel = False
            MAINPanel.Controls.Add(pro1)
            pro1.Show()
            pro1.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro1 As New PURCHASE_INVOICE
            MAINPanel.Controls.Clear()
            pro1.TopLevel = False
            MAINPanel.Controls.Add(pro1)
            pro1.Show()
            pro1.WindowState = FormWindowState.Normal
        End If
    End Sub


    Private Sub HomeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem1.Click

        Me.Cursor = Cursors.WaitCursor
        If WindowState = FormWindowState.Maximized Then
            MAINPanel.Controls.Clear()
            MAINPanel.Controls.Add(LEFTPanel)
            MAINPanel.Controls.Add(RIGHTPanel)
            'MAINPanel.Controls.Add(LabWel)
            'MAINPanel.Controls.Add(Pictur)
            ' Pictur.Controls.Add(LabWelcom)
            MAINPanel.Show()
            Me.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            MAINPanel.Controls.Clear()
            MAINPanel.Controls.Add(LEFTPanel)
            MAINPanel.Controls.Add(RIGHTPanel)
            'Pictur.Controls.Add(LabWelcom)
            ' MAINPanel.Controls.Add(LabWel)
            ' MAINPanel.Controls.Add(RIGHTPanel)
            ' Picture.Controls.Add(LabWelcom)
            MAINPanel.Show()
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Cursor = Cursors.Default

        'LEFTPanel.Show()
        'FrontPanel.Show()
        'RIGHTPanel.Show()
        'Picture.Show()

    End Sub

    Private Sub DrugListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrugListToolStripMenuItem.Click
        ButtonDrugs_Click(sender, e)
    End Sub
    Private Sub Buttondruglist_Click(sender As Object, e As EventArgs) Handles Buttondruglist.Click
        ButtonDrugs_Click(sender, e)
    End Sub
    Private Sub AddNewDrugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewDrugToolStripMenuItem.Click
        'DRUG_LIST.addBT_Click(sender, e)
        ButtonSELL_Click(sender, e)
    End Sub

    Private Sub InoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InoiceToolStripMenuItem.Click
        ButtonIVOICE_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        emailTB.Text = "0"
        passwordTB.Text = "1"
    End Sub

    Private Sub ButtonSELL_Click(sender As Object, e As EventArgs) Handles ButtonSELL.Click
        'DRUG_LIST.addBT_Click(sender, e)
        'If WindowState = FormWindowState.Maximized Then
        '    Dim pro As New ADD_DRUGS
        '    MAINPanel.Controls.Clear()
        '    pro.TopLevel = False
        '    MAINPanel.Controls.Add(pro)
        '    pro.Show()
        '    pro.WindowState = FormWindowState.Maximized
        'ElseIf WindowState = FormWindowState.Normal Then
        '    Dim pro As New ADD_DRUGS
        '    MAINPanel.Controls.Clear()
        '    pro.TopLevel = False
        '    MAINPanel.Controls.Add(pro)
        '    pro.Show()
        '    pro.WindowState = FormWindowState.Normal
        'End If

        If WindowState = FormWindowState.Maximized Then
            Dim pro11 As New ADD_DRUGS
            MAINPanel.Controls.Clear()
            pro11.TopLevel = False
            MAINPanel.Controls.Add(pro11)
            pro11.Show()
            pro11.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro11 As New ADD_DRUGS
            MAINPanel.Controls.Clear()
            pro11.TopLevel = False
            MAINPanel.Controls.Add(pro11)
            pro11.Show()
            pro11.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ButtonACCOUNTS_Click(sender As Object, e As EventArgs) Handles ButtonACCOUNTS.Click
        If WindowState = FormWindowState.Maximized Then
            Dim pro As New ACCOUNTS
            MAINPanel.Controls.Clear()
            pro.TopLevel = False
            MAINPanel.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Normal Then
            Dim pro As New ACCOUNTS
            MAINPanel.Controls.Clear()
            pro.TopLevel = False
            MAINPanel.Controls.Add(pro)
            pro.Show()
            pro.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        ButtonACCOUNTS_Click(sender, e)
    End Sub
End Class
