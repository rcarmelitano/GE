Public Class frmCCCPayment

    ' String to be shown in the list box
    Dim thisPaymentAndAmount As String

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Checkout Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCCCPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable form controls
        Me.ControlBox = False
    End Sub

    Public Function SubtractOffPayment()

        ' Calculate new total and update the current running total for the label
        DegradingTotalCost -= nudPayment.Value
        frmCheckoutForm.lblTotalAmount.Text = DegradingTotalCost.ToString("C2")

        If frmCheckoutForm.lblTotalAmount.Text = 0.ToString("C2") Then
            ' Make all values say 0
            frmCheckoutForm.lblSubTotalAmount.Text = 0.ToString("C2")
            frmCheckoutForm.lblTaxAmount.Text = 0.ToString("C2")

            ' Disable buttons on the Checkout form
            frmCheckoutForm.btnCash.Enabled = False
            frmCheckoutForm.btnGiftCard.Enabled = False
            frmCheckoutForm.btnCheck.Enabled = False
            frmCheckoutForm.btnCredit.Enabled = False
            frmCheckoutForm.btnPayPal.Enabled = False
            frmCheckoutForm.btnAccount.Enabled = False

            ' Re-enable the checkout (Complete Order) button
            frmCheckoutForm.btnCheckout.Enabled = True
        End If

        thisPaymentAndAmount = (lblTitle.Text.PadRight(15, " ") & vbTab & nudPayment.Value.ToString("C2"))
        frmCheckoutForm.lbCart.Items.Add(thisPaymentAndAmount)
        txtTotalCost.Text = DegradingTotalCost.ToString("N2")
        nudPayment.Maximum = DegradingTotalCost

        Return 0
    End Function

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click

        ' Ask the user if they are sure they want to make a payment
        If MessageBox.Show("Are you sure you want to make the payment?", "Payment",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            ' Call the subtract function if any of the CCC payment types are clicked
            If lblTitle.Text = "Check" Or lblTitle.Text = "Credit/Debit Card" Or lblTitle.Text = "Cash" Then
                If nudPayment.Value > 0 Then
                    SubtractOffPayment()

                    ' Close the CCCPayment form if the DegradingTotal is = to 0
                    If DegradingTotalCost = 0 Then
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("You must enter a value greater than zero for a payment.")
                End If
                MessageBox.Show("The payment has been added to the order.")
                If DegradingTotalCost < 20 Then
                    frmCheckoutForm.btnCredit.Enabled = False
                End If
                If DegradingTotalCost < 20 And lblTitle.Text = "Credit/Debit Card" Then
                    MessageBox.Show("You can no longer make payments with Credit/Debit card.")
                    Me.Close()
                End If
                If lblTitle.Text = "Credit/Debit Card" Then
                    nudPayment.Text = 20.0
                Else
                    nudPayment.Text = 0.00
                End If
            End If
        End If
    End Sub
End Class