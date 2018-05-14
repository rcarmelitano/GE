' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmCCCPayment

    ' Create a new connection to the database for this form
    Dim customerConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    ' String to be shown in the list box
    Dim thisPaymentAndAmount As String
    Dim refreshedUsedCredit As Double = 0
    Dim MaxLineOfCredit As Double = 0

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Checkout Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCCCPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)
        ' Disable form controls
        Me.ControlBox = False

        If lblTitle.Text = "PayPal" Then

            ' Get the emails for the customer---------------------------------------CHANGE THIS SO IT ISN'T HERE BUT COMES FROM THE CHECKOUT FORM FOR THE SELECTED CUSTOMER
            Dim customerID As Integer = 2

            ' Create the query to get the customer's email
            Dim getEmail As New SqlCommand("select email from Customers WHERE customerID = @customerID", customerConnection)

            ' Pass in the customer ID as a parameter
            getEmail.Parameters.AddWithValue("@customerID", customerID)

            ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
            customerConnection.Open()
            getEmail.ExecuteNonQuery()
            cbEmail.Text = getEmail.ExecuteScalar()

            ' Close the connection
            customerConnection.Close()
        End If
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

    Public Function SubtractOffPaymentGiftCardAndAccount()

        ' COMPARE THE ENTERED PRICE TO THE TOTAL OF THAT CUSTOMER'S GIFT CARD
        'DO COMPARE IF FOR GIFT CARD HERE

        If lblTitle.Text = "Account" Then

            ' Call query to grab the max credit for the customer 
            ' Grab the new Line of Credit
            Dim MaxCreditLine As New SqlCommand("SELECT lineOfCredit WHERE customerID = @customerID", customerConnection)

            ' Pass in parameter
            MaxCreditLine.Parameters.AddWithValue("@customerID", frmCheckoutForm.txtCustomerID.Text)


            ' Open the connection to the database and pass in the information
            customerConnection.Open()
            MaxLineOfCredit = MaxCreditLine.ExecuteNonQuery()

            ' Close the connection
            customerConnection.Close()



            If nudPayment.Text <= txtTotalCost.Text And nudPayment.Value <= MaxLineOfCredit Then
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





                ' CALL QUERY TO UPDATE THE USED LINE OF CREDIT BY THE AMOUNT ENTERED------------------------------------------------------------
                Dim updateUsedLine As New SqlCommand("UPDATE Customers SET usedLineOfCredit = usedLineOfCredit + @usedLineOfCredit WHERE customerID = @customerID", customerConnection)

                ' Pass in parameter
                updateUsedLine.Parameters.AddWithValue("@customerID", frmCheckoutForm.txtCustomerID.Text)
                updateUsedLine.Parameters.AddWithValue("@usedLineOfCredit", nudPayment.Text)


                ' Open the connection to the database and pass in the information
                customerConnection.Open()
                updateUsedLine.ExecuteNonQuery()

                ' Close the connection
                customerConnection.Close()

                ' Grab the new usedLineOfCredit
                Dim refreshUsedLine As New SqlCommand("SELECT usedLineOfCredit WHERE customerID = @customerID", customerConnection)

                ' Pass in parameter using the list
                refreshUsedLine.Parameters.AddWithValue("@customerID", frmCheckoutForm.txtCustomerID.Text)


                ' Open the connection to the database and pass in the information
                customerConnection.Open()
                refreshedUsedCredit = refreshUsedLine.ExecuteNonQuery()

                ' Close the connection
                customerConnection.Close()




                ' SET MAX TO THE PRICE FOR THE ACCOUNT/GIFT CARD --------------------------------------------------------------------------------------------
                nudPayment.Maximum = refreshedUsedCredit
            Else
                ' Display an erorr message to the user if they do not have the entered amount to pay with
                MessageBox.Show("Your account balance is less than the price you entered. Please try again or pay with a different payment option.")
            End If

            ' Do differently
        ElseIf lblTitle.Text = "Gift Card" Then

            If nudPayment.Text <= txtTotalCost.Text Then
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

            Else
                MessageBox.Show("Your gift card balance is less than the price you entered. Please try again or pay with a different payment option")
            End If
        End If

        Return 0
    End Function

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click

        ' Ask the user if they are sure they want to make a payment
        If MessageBox.Show("Are you sure you want to make the payment?", "Payment",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            ' Call the subtract function if any of the CCC payment types are clicked
            If lblTitle.Text = "Check" Or lblTitle.Text = "Credit/Debit Card" Or lblTitle.Text = "Cash" Or lblTitle.Text = "PayPal" Then
                If nudPayment.Value > 0 Then
                    SubtractOffPayment()

                    ' Close the CCCPayment form if the DegradingTotal is = to 0
                    If DegradingTotalCost = 0 Then
                        Me.Close()
                    End If
                Else
                    ' Display an error message to the user
                    MessageBox.Show("You must enter a value greater than zero for a payment.")
                    Exit Sub
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


                ' Perform a different set of steps if the customer chooses to pay with a gift card or account
            ElseIf lblTitle.Text = "Gift Card" Or lblTitle.Text = "Account" Then

                If nudPayment.Value > 0 Then
                    ' Call the special payment function for gift card and account
                    SubtractOffPaymentGiftCardAndAccount()

                    ' Close the CCCPayment form if the DegradingTotal is = to 0
                    If DegradingTotalCost = 0 Then
                        Me.Close()
                    End If
                Else
                    ' Display an error message to the user
                    MessageBox.Show("You must enter a value greater than zero for a payment.")
                    Exit Sub
                End If
                MessageBox.Show("The payment has been added to the order.")
                If DegradingTotalCost < 20 Then
                    frmCheckoutForm.btnCredit.Enabled = False
                End If
                If DegradingTotalCost < 20 And lblTitle.Text = "Credit/Debit Card" Then
                    MessageBox.Show("You can no longer make payments with Credit/Debit card.")
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class