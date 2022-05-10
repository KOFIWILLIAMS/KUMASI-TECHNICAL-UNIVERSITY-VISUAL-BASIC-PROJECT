Public Class main
    Private Sub IPHONEBTN_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPHONEBTN.Click
        IPONEPNL.Height = IPHONEBTN.Height
        IPONEPNL.Top = IPHONEBTN.Top
        iphonePanel.Visible = True
        samsungpanel.Visible = False
        nokiapanel.Visible = False
        infinixpanel.Visible = False
        huaweipanel.Visible = False
        aboutpanel.Visible = False
        watchpanel.Visible = False
    End Sub

    Private Sub SAMBTN_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAMBTN.Click
        SAMPNL.Height = SAMBTN.Height
        SAMPNL.Top = SAMBTN.Top
        iphonePanel.Visible = False
        samsungpanel.Visible = True
        nokiapanel.Visible = False
        infinixpanel.Visible = False
        huaweipanel.Visible = False
        aboutpanel.Visible = False
        watchpanel.Visible = False
    End Sub

    Private Sub NOKIABTN_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NOKIABTN.Click
        NOKIAPNL.Height = NOKIABTN.Height
        NOKIAPNL.Top = NOKIABTN.Top
        iphonePanel.Visible = False
        samsungpanel.Visible = False
        nokiapanel.Visible = True
        infinixpanel.Visible = False
        huaweipanel.Visible = False
        aboutpanel.Visible = False
        watchpanel.Visible = False
    End Sub

    Private Sub INFINIXBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFINIXBTN.Click
        INFINIXPNL.Height = INFINIXBTN.Height
        INFINIXPNL.Top = INFINIXBTN.Top
        iphonePanel.Visible = False
        samsungpanel.Visible = False
        nokiapanel.Visible = False
        infinixpanel.Visible = True
        huaweipanel.Visible = False
        aboutpanel.Visible = False
        watchpanel.Visible = False
    End Sub

    Private Sub HUWAIEBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HUAWEIBTN.Click
        HUAWEIPNL.Height = HUAWEIBTN.Height
        HUAWEIPNL.Top = HUAWEIBTN.Top
        iphonePanel.Visible = False
        samsungpanel.Visible = False
        nokiapanel.Visible = False
        infinixpanel.Visible = False
        huaweipanel.Visible = True
        aboutpanel.Visible = False
        watchpanel.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WATCHBTN.Click
        WATCHPNL.Height = WATCHBTN.Height
        WATCHPNL.Top = WATCHBTN.Top
        iphonePanel.Visible = False
        samsungpanel.Visible = False
        nokiapanel.Visible = False
        infinixpanel.Visible = False
        huaweipanel.Visible = False
        aboutpanel.Visible = False
        watchpanel.Visible = True
    End Sub

    Private Sub Buttlogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttlogin.Click
        If TBUN.Text = "WAGES" And TBPW.Text = "COFY" Then
            LOGINPAGE.Visible = False
        Else
            MessageBox.Show("wrong detail", "exiting", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub Buttreset_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttreset.Click
        TBPW.Clear()
        TBUN.Clear()
    End Sub

    Private Sub Buttexit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttexit.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub ABTBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABTBTN.Click
        ABTPNL.Height = ABTBTN.Height
        ABTPNL.Top = ABTBTN.Top
        iphonePanel.Visible = False
        samsungpanel.Visible = False
        nokiapanel.Visible = False
        infinixpanel.Visible = False
        huaweipanel.Visible = False
        aboutpanel.Visible = True
        watchpanel.Visible = False
    End Sub
End Class
