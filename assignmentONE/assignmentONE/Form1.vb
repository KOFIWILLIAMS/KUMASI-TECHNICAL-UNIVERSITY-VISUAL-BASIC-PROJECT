Public Class Form1

    Private Sub resetBUTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetBUTO.Click
        TextPrice.Text = ""
        TextTotal.Text = ""
        TextDiscount.Text = ""
        TextExtras.Text = ""
        TextNumber.Text = ""
        TextSub.Text = ""
        TextTax.Text = ""
        TextTrade.Text = ""
        TextYear.Text = ""
        TextVehicle.Text = ""


        RadioNone.Checked = False
        RadioPaint.Checked = False
        RadioUnderCoat.Checked = False
        RadioBOth.Checked = False

        CheckTires.Checked = False
        CheckGPS.Checked = False
        CheckRadio.Checked = False
        CheckMat.Checked = False
        CheckWhole.Checked = False
    End Sub

    Private Sub ButtonCOMPUTER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCOMPUTER.Click

        Dim decimal_Discount As Decimal
        Dim decimal_exterior_extra As Decimal
        Dim decimal_accessory_extra As Decimal
        Dim decimal_total_extra As Decimal
        Dim decimal_total_due As Decimal

        'check if some textbox are not empty
        If TextNumber.Text = "" Then
            MsgBox("Fill the provided spaces")

        Else

            'discount on price if buyer is a wholesaler
            If CheckWhole.Checked Then
                decimal_Discount = Decimal.Round(0.2 * TextPrice.Text)
                TextDiscount.Text = FormatNumber(decimal_Discount)
            Else
                TextDiscount.Text = FormatNumber(0)
            End If

            'extras
            'EXTERIOR EXTRAS
            Const DECIMAL_NO_EXTERIOR As Decimal = 0D
            Const DECIMAL_PAINT_TOUCH_UP As Decimal = 250D
            Const DECIMAL_UNDERCOAT As Decimal = 300D
            Const DECIMAL_BOTH As Decimal = 550D

            'CHECK EXTERIOR EXTRAS
            If RadioNone.Checked = True Then
                decimal_exterior_extra = Decimal.Round(DECIMAL_NO_EXTERIOR, 2)

            ElseIf RadioPaint.Checked = True Then
                decimal_exterior_extra = Decimal.Round(DECIMAL_PAINT_TOUCH_UP, 2)

            ElseIf RadioUnderCoat.Checked = True Then
                decimal_exterior_extra = Decimal.Round(DECIMAL_UNDERCOAT, 2)

            Else
                decimal_exterior_extra = Decimal.Round(DECIMAL_BOTH, 2)
            End If


            'ACCESSORY EXTRAS
            Const DECIMAL_NEW_TIRES As Decimal = 450D
            Const DECIMAL_NEW_HD_RADIO As Decimal = 190.95D
            Const DECIMAL_BUILT_IN_GPS As Decimal = 700D
            Const DECIMAL_NEW_FLOOR_MATS As Decimal = 55D

            'CHECK ACCESSORY EXTRAS
            If CheckTires.Checked = True Then
                decimal_accessory_extra += Decimal.Round(DECIMAL_NEW_TIRES, 2)
            End If
            If CheckRadio.Checked = True Then
                decimal_accessory_extra += Decimal.Round(DECIMAL_NEW_HD_RADIO, 2)
            End If
            If CheckGPS.Checked = True Then
                decimal_accessory_extra += Decimal.Round(DECIMAL_BUILT_IN_GPS, 2)
            End If
            If CheckWhole.Checked = True Then
                decimal_accessory_extra += Decimal.Round(DECIMAL_NEW_FLOOR_MATS, 2)
            End If


            'after checking all extras
            'now, let's add both exterior extras and the accessory extras
            decimal_total_extra = Decimal.Round((decimal_exterior_extra + decimal_accessory_extra), 2)
            'output extras
            TextExtras.Text = FormatNumber(decimal_total_extra)

            'CALCULATE FOR SUBTOTAL
            'which is discount + extras

            TextSub.Text = FormatNumber((TextPrice.Text - decimal_Discount) + decimal_total_extra)

            'CALCULATE SALES TAX
            ' check if wholesale buyer or not
            If CheckWhole.Checked Then
                TextTax.Text = FormatNumber(0)
            Else
                TextTax.Text = FormatNumber(0.05 * TextSub.Text)
            End If


            'total
            'set trade in to zero
            ' TxtTradeIn.Text = FormatNumber(0)
            'decimal_total_due = Decimal.Parse((TxtSubtotal.Text + TxtSaleTax.Text) - TxtTradeIn.Text)

            'TxtTotalDue.Text = FormatCurrency$(decimal_total_due)

        End If

    End Sub

    Private Sub ButtonEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEXIT.Click
        Me.Close()
    End Sub
End Class
