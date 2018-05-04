Public Class frmGiftCards
    Private Sub ViewGiftCardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewGiftCardsToolStripMenuItem.Click
        ' Display the gift cards view form
        frmGiftCardsView.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub frmGiftCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)

        ' Enable the create button if information is filled in
        If txtCustomerID.Text = String.Empty Then
            btnActivateGiftCard.Enabled = False
        ElseIf txtCardTotal.Text = String.Empty Then
            btnActivateGiftCard.Enabled = False
        Else
            btnActivateGiftCard.Enabled = True
        End If


        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    ' Grab the information of the selected cell for the customer id and store it in the text box for customer id
    Private Sub btnAddID_Click(sender As Object, e As EventArgs) Handles btnAddID.Click
        Try
            txtCustomerID.Text = dgvCustomers.Item(0, dgvCustomers.CurrentCell.Value - 1).Value
        Catch
            MessageBox.Show("You can only add a Customer ID." & vbCrLf & "Click an ID from the list and press the ""Add"" button to add it to the textbox.")
        End Try
    End Sub

    Private Sub btnClearID_Click(sender As Object, e As EventArgs) Handles btnClearID.Click
        ' Clear the customerID textbox
        txtCustomerID.Clear()
    End Sub

    Private Sub btnActivateGiftCard_Click(sender As Object, e As EventArgs) Handles btnActivateGiftCard.Click

    End Sub

    Private Sub GiftCards_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel making a gift card?", "Gift Card Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
        End If
    End Sub
End Class