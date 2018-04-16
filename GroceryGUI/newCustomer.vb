Public Class frmNewCustomer
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub chkWholeSale_CheckedChanged(sender As Object, e As EventArgs) Handles chkWholeSale.CheckedChanged
        ' Enable the line of credit fields if the Wholesale Checkbox is clicked
        If chkWholeSale.Checked = True Then
            txtAvailableCredit.Enabled = True
            txtUsedLineOfCredit.Enabled = True
        Else
            txtAvailableCredit.Enabled = False
            txtUsedLineOfCredit.Enabled = False
            txtAvailableCredit.Clear()
            txtUsedLineOfCredit.Clear()
            txtAvailableCredit.Text = "0.00"
            txtUsedLineOfCredit.Text = "0.00"
        End If
    End Sub

    Private Sub newCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAvailableCredit.Enabled = False
        txtUsedLineOfCredit.Enabled = False
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ' Delete the customer if the user confirms it

    End Sub

    Private Sub frmNewCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure you want to cancel?", "Customer Deletion",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class