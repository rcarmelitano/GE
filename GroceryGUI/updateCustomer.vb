Public Class frmUpdateCustomer
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the form and display the customers form
        Me.Close()
        frmCustomers.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        ' Display the customer history form
        frmCustomerHistory.Show()
    End Sub

    Private Sub updateCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Promotion Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class