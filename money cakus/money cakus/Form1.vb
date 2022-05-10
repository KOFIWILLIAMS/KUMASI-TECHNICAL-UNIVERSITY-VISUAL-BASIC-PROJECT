Public Class Form1

#Region "for convertor"

    ' FOR CONVERTOR
    Dim Nigeria As Double = 0.0163626
    Dim Canada As Double = 4.40922
    Dim USA As Double = 5.80871
    Dim france As Double = 7.74824
    Dim China As Double = 0.831062

    'function for convertor
    Function Currency(ByVal money As Double) As Double
        If ComboBoxSelectCountry.Text = "NIGERIA" Then
            Return Math.Round(Nigeria * money, 2)
        ElseIf ComboBoxSelectCountry.Text = "CANADIAN $" Then
            Return Math.Round(Canada * money, 2)
        ElseIf ComboBoxSelectCountry.Text = "U S A $" Then
            Return Math.Round(USA * money, 2)
        ElseIf ComboBoxSelectCountry.Text = "POUNDS" Then
            Return Math.Round(france * money, 2)
        ElseIf ComboBoxSelectCountry.Text = "CHINA" Then
            Return Math.Round(China * money, 2)
        ElseIf ComboBoxSelectCountry.Text = "ERU" Then
            Return Math.Round(China * money, 2)

        End If
    End Function

#End Region
    'clear all textboxes automaticaly
#Region "Clear all text boxes"
    Public Sub Clear(ByVal c As Control)
        Dim clearTextbox As TextBox
        For Each control As Control In c.Controls
            If TypeOf control Is TextBox Then
                clearTextbox = CType(control, TextBox)
                clearTextbox.Clear()
            End If
            If control.HasChildren Then
                Clear(control)
            End If
        Next
    End Sub
#End Region

    Private Sub ButClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButt.Click
        Clear(Me)
        LAB200.Text = "0.00"
        LAB100.Text = "0.00"
        LAB50.Text = "0.00"
        LAB20.Text = "0.00"
        LAB10.Text = "0.00"
        LAB5.Text = "0.00"
        LAB2.Text = "0.00"
        LAB1.Text = "0.00"
        LAB2P.Text = "0.00"
        LAB1C.Text = "0.00"
        LAB50P.Text = "0.00"
        LAB20P.Text = "0.00"
        LAB10P.Text = "0.00"
        LAB5P.Text = "0.00"
        LAB1P.Text = "0.00"
        LBtotal.Text = "00000.00"
    End Sub

    Private Sub ButClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Dim result = MessageBox.Show("Do You Want TO Exit", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'moni cakus cal button
    Private Sub BTcal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTcal.Click
        LAB200.Text = (200) * Val(TAB200.Text)
        LAB100.Text = (100) * Val(TAB100.Text)
        LAB50.Text = (50) * Val(TAB50.Text)
        LAB20.Text = (20) * Val(TAB20.Text)
        LAB10.Text = (10) * Val(TAB10.Text)
        LAB5.Text = (5) * Val(TAB5.Text)
        LAB2.Text = (2) * Val(TAB2.Text)
        LAB1.Text = (1) * Val(TAB1.Text)
        LAB2P.Text = (2) * Val(TAB2C.Text)
        LAB1C.Text = (1) * Val(TAB1C.Text)
        LAB50P.Text = (0.5) * Val(TAB50P.Text)
        LAB20P.Text = (0.2) * Val(TAB20P.Text)
        LAB10P.Text = (0.1) * Val(TAB10P.Text)
        LAB5P.Text = (0.05) * Val(TAB5P.Text)
        LAB1P.Text = (0.01) * Val(TAB1P.Text)

        LBtotal.Text = Val(LAB200.Text) + Val(LAB100.Text) + Val(LAB50.Text) + Val(LAB20.Text) + Val(LAB10.Text) + Val(LAB5.Text) + Val(LAB2.Text) + Val(LAB1C.Text) + Val(LAB2P.Text) + Val(LAB50P.Text) + Val(LAB20P.Text) + Val(LAB10P.Text) + Val(LAB5P.Text) + Val(LAB1P.Text)

        Dim SAPI As Object
        SAPI = CreateObject("SAPI.SPvoice")
        SAPI.speak("your Amount is" + (LBtotal.Text) + "Ghana Cedis")
    End Sub

    'convert button
    Private Sub ButtConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtConvert.Click
        Dim Ghana_Cedis As Double = CDbl(EnterAmountTB.Text)
        LaBGHc.Text = CStr(Currency(Ghana_Cedis))

        If ComboBoxSelectCountry.Text = "POUNDS" Then
            LaBGHc.Text = " " & Val(LaBGHc.Text)
        ElseIf ComboBoxSelectCountry.Text = "U S A $" Then
            LaBGHc.Text = " " & Val(LaBGHc.Text)
        ElseIf ComboBoxSelectCountry.Text = "CHINA" Then
            LaBGHc.Text = " " & Val(LaBGHc.Text)
        ElseIf ComboBoxSelectCountry.Text = "CANADIAN $" Then
            LaBGHc.Text = " " & Val(LaBGHc.Text)
        ElseIf ComboBoxSelectCountry.Text = "NIGERIA" Then
            LaBGHc.Text = " " & Val(LaBGHc.Text)
        ElseIf ComboBoxSelectCountry.Text = "Choose A County" Then
            MsgBox("Select A Country Of Your Choice", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'COMBOBOX
        ComboBoxSelectCountry.Text = "Choose A Country"
        ComboBoxSelectCountry.Items.Add("POUNDS")
        ComboBoxSelectCountry.Items.Add("U S A $")
        ComboBoxSelectCountry.Items.Add("CHINA")
        ComboBoxSelectCountry.Items.Add("NIGERIA")
        ComboBoxSelectCountry.Items.Add("CANADIAN $")

        ComboBoxSelectCountry.Sorted = True
    End Sub

    Private Sub ButtReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtReset.Click
        ComboBoxSelectCountry.Text = "Choose A Country"
        LaBGHc.Text = "0.00"
        EnterAmountTB.Text = ""
    End Sub

    Private Sub ButtClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtClose.Click
        LaBGHc.Text = "0.00"
        EnterAmountTB.Text = ""
    End Sub
    'ONLI KEYPRESS
#Region "KEY PRESS"
    Private Sub EnterAmountTB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EnterAmountTB.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TAB1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TAB5P.KeyPress, TAB50P.KeyPress, TAB50.KeyPress, TAB5.KeyPress, TAB2C.KeyPress, TAB20P.KeyPress, TAB200.KeyPress, TAB20.KeyPress, TAB2.KeyPress, TAB1P.KeyPress, TAB1C.KeyPress, TAB10P.KeyPress, TAB100.KeyPress, TAB10.KeyPress, TAB1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
#End Region


#Region "Numbers Cakus"

    Private Sub Button1ClickMethod(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nam9.Click, nam3.Click, opminus.Click, nam4.Click, nam5.Click, nam6.Click, opdvd.Click, nam7.Click, nam8.Click, opadd.Click, opcl.Click, nam0.Click, opdot.Click, optmx.Click, nam1.Click, nam2.Click, opeq.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "nam0" Then
            TextBox1.Text = TextBox1.Text + "0"
        End If

        If button.Name = "nam1" Then
            TextBox1.Text = TextBox1.Text + "1"
        End If

        If button.Name = "nam2" Then
            TextBox1.Text = TextBox1.Text + "2"
        End If

        If button.Name = "nam3" Then
            TextBox1.Text = TextBox1.Text + "3"
        End If

        If button.Name = "nam4" Then
            TextBox1.Text = TextBox1.Text + "4"
        End If

        If button.Name = "nam5" Then
            TextBox1.Text = TextBox1.Text + "5"
        End If

        If button.Name = "nam6" Then
            TextBox1.Text = TextBox1.Text + "6"
        End If

        If button.Name = "nam7" Then
            TextBox1.Text = TextBox1.Text + "7"
        End If

        If button.Name = "nam8" Then
            TextBox1.Text = TextBox1.Text + "8"
        End If

        If button.Name = "nam9" Then
            TextBox1.Text = TextBox1.Text + "9"
        End If

        If button.Name = "opadd" Then
            TextBox1.Text = TextBox1.Text + "+"
        End If

        If button.Name = "opdvd" Then
            TextBox1.Text = TextBox1.Text + "/"
        End If

        If button.Name = "opdot" Then
            TextBox1.Text = TextBox1.Text + "."
        End If

        If button.Name = "opminus" Then
            TextBox1.Text = TextBox1.Text + "-"
        End If

        If button.Name = "optmx" Then
            TextBox1.Text = TextBox1.Text + "*"
        End If

        If button.Name = "opcl" Then
            TextBox1.Text = " "
        End If

        If button.Name = "opeq" Then
            Dim equation As String = TextBox1.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            TextBox1.Text = result
        End If
    End Sub

    Private Sub backSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backSP.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub
#End Region

End Class

