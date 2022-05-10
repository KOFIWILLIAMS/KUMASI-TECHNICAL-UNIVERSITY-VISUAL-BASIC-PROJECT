Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BteXIT.Click
        Dim MessageExitString As String = "Do you please want to exit?"
        Dim BtnDialogResult As DialogResult = MessageBox.Show(MessageExitString, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If BtnDialogResult = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()

        End If

    End Sub

    Private Sub BrESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrESET.Click
        'reset all textbox controls
        NameTB.Clear()
        iDtB.Clear()
        GrossTB.Clear()
        depTB.Clear()
        PayTB.Clear()
        hoursTB.Clear()
        taxTB.Clear()
        BeneTB.Clear()
        NetTB.Clear()

        'reset all radiobuttton controls
        RSrb.Checked = True
        R4rb.Checked = False
        NRPrb.Checked = False


        'reset all checkboxes controls
        CHI.Checked = False
        CPI.Checked = False
        CWI.Checked = True

        'set cursor on name textbox
        NameTB.Focus()

    End Sub

    Private Sub bTcAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTcAL.Click
        'parse textbox  value to memory variables
        Dim hoursworkedDecimal As Decimal
        Dim payrateDecimal As Decimal
        Dim grosspayDecimal As Decimal
        Dim federalTaxDecimal As Decimal
        Dim benefitsCostDecimal As Decimal
        Dim netPaydecimal As Decimal

        'CHECK NAME, DEPARTMET, EMPLOYEE ID ,WORK HOUR, PAY RATE

        If NameTB.Text = "" Or hoursTB.Text = "" Or PayTB.Text = "" Then
            MsgBox("Please Provide All Necessary Info")

        Else

            Try

            Catch ex As Exception

            End Try

            'compute gross pay
            hoursworkedDecimal = Decimal.Parse(hoursTB.Text, Globalization.NumberStyles.Number)
            payrateDecimal = Decimal.Parse(PayTB.Text, Globalization.NumberStyles.Currency)


            If hoursworkedDecimal <= 40D Then
                'calculate regular pay by time
                grosspayDecimal = Decimal.Round(hoursworkedDecimal * payrateDecimal, 2)

            Else
                'calcalute overtime ie. regular pay + overtime
                grosspayDecimal = Decimal.Round((40D * payrateDecimal) + ((hoursworkedDecimal - 40D) * payrateDecimal * 1.5D), 2)


            End If

            Try
            Catch ex As Exception
                MessageBox.Show("Check to ensure no data values are missing." & ControlChars.NewLine & ex.Message, "compute Button Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            GrossTB.Text = grosspayDecimal.ToString("C2")


            'compute federal tax

            'TAX RATE CONSTANT
            Const TAX_RATE_08_DECIMAL As Decimal = 0.08D
            Const TAX_RATE_18_DECIMAL As Decimal = 0.18D
            Const TAX_RATE_28_DECIMAL As Decimal = 0.28D
            Const TAX_LEVEL_08_DECIMAL As Decimal = 985D
            Const TAX_LEVEL_18_DECIMAL As Decimal = 2450D
            'Const TAX_LEVEL_28_DECIMAL As Decimal = 0.08D

            If grosspayDecimal <= TAX_LEVEL_08_DECIMAL Then
                '8% tax 
                federalTaxDecimal = Decimal.Round(TAX_RATE_08_DECIMAL * grosspayDecimal, 2)

            ElseIf grosspayDecimal <= TAX_LEVEL_18_DECIMAL Then
                '18% tax
                federalTaxDecimal = Decimal.Round(TAX_RATE_18_DECIMAL * grosspayDecimal, 2)
            Else
                '28% tax
                federalTaxDecimal = Decimal.Round(TAX_RATE_28_DECIMAL * grosspayDecimal, 2)


            End If
            taxTB.Text = federalTaxDecimal.ToString("N")


            'compute insurance benefits deduction
            Const MEDICAL_RATE_DECIMAL As Decimal = 35.75D
            Const LIFE_RATE_DECIMAL As Decimal = 18.35D
            Const DENTAL_RATE_DECIMAL As Decimal = 4D

            'CHECK ON MEDICAL INSURANCE 
            If CHI.Checked Then
                benefitsCostDecimal += MEDICAL_RATE_DECIMAL
            End If

            'CHECK ON LIFE INSURANCE
            If CPI.Checked Then
                benefitsCostDecimal += LIFE_RATE_DECIMAL
            End If

            'CHECK ON DENTAL INSURANCE 
            If CWI.Checked Then
                benefitsCostDecimal += DENTAL_RATE_DECIMAL
            End If

            BeneTB.Text = benefitsCostDecimal.ToString("N")


            'compute retirement benefits deduction

            Const RETIREMENT_STANDARD_DECIMAL As Decimal = 0.05D
            Const RETIREMENT_401A_DECIMAL As Decimal = 0.08D

            If RSrb.Checked Then
                benefitsCostDecimal += Decimal.Round(RETIREMENT_401A_DECIMAL * grosspayDecimal, 2)
            ElseIf R4rb.Checked Then
                benefitsCostDecimal += Decimal.Round(RETIREMENT_STANDARD_DECIMAL * grosspayDecimal, 2)
            Else
                'no retirement plan
                NRPrb.Checked = True
            End If
            BeneTB.Text = benefitsCostDecimal.ToString("N")

            'compute for net pay
            netPaydecimal = grosspayDecimal - federalTaxDecimal - benefitsCostDecimal
            NetTB.Text = netPaydecimal.ToString("C")
            'Output Result

        End If

    End Sub
End Class
