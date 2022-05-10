Public Class Form1


    Private Sub CALCULATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULATE.Click
        Dim NNppEERR As Decimal
        Dim PAYMENTasV As Decimal
        Dim PpRatte As Decimal
        Dim MonthlyPay As Decimal

        Dim rraattee = (RATE.Text / 100)
        Dim COFY = rraattee / PPY.Text
        Dim EXPO = -(N_Y.Text) * PPY.Text

        If PPY.Text = "" Or N_Y.Text = "" Or PV.Text = "" Or RATE.Text = "" Then
            MsgBox("Please Provide All Necessary Info")
        Else

            'nper cal
            NNppEERR = PPY.Text * N_Y.Text
            nper.Text = Decimal.Round(NNppEERR, 2)

            'rate cal
            Dim rraatte = (RATE.Text / 100)
            PpRatte = rraatte / PPY.Text
            P_rate.Text = Decimal.Round(PpRatte, 3)

            'payment calculation 
            PAYMENTasV = PV.Text * ((COFY) / (1 - (1 + COFY) ^ EXPO))
            payment.Text = Decimal.Round(PAYMENTasV, 3)

            loanAmt.Text = payment.Text * NNppEERR

            interest.Text = loanAmt.Text - PV.Text

            'monthly paymnt for loan
            MonthlyPay = interest.Text / NNppEERR
            averMonInt.Text = Decimal.Round(MonthlyPay, 2)
        End If
    End Sub

    Private Sub RESET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESET.Click
        payment.Text = "000"
        averMonInt.Text = "000"
        loanAmt.Text = "000"
        interest.Text = "000"
        nper.Text = "000"
        P_rate.Text = "000"

        PV.Text = " "
        PPY.Text = " "
        N_Y.Text = " "
        RATE.Text = " "
    End Sub
End Class
