Public Class frmUpdateCustomer
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        ' Display the customer history form
        frmCustomerHistory.Show()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Gift_Cards1TableAdapter.Fill(Me.GEDataSet.Gift_Cards1, CType(Param1ToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Param1ToolStripTextBox.Text = CustomerIDTextBox.Text
        FillToolStripButton.PerformClick()
        FillToolStrip.Hide()
        CheckBox1.Checked = True
        btnSave.Enabled = True
        btnSave.Enabled = False
    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.Gift_Cards1TableAdapter.Fill(Me.GEDataSet.Gift_Cards1, CType(Param1ToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        ' Disable ReadOnly for textboxes
        txtFirst.ReadOnly = False
        txtLast.ReadOnly = False
        txtbirthdate.ReadOnly = False
        txtprimary.ReadOnly = False
        txtSecondary.ReadOnly = False
        txtAvailableCredit.ReadOnly = False
        txtUsedLineOfCredit.ReadOnly = False
        txtEmail.ReadOnly = False

        ' Enable textboxes
        txtFirst.Enabled = True
        txtLast.Enabled = True
        txtbirthdate.Enabled = True
        txtprimary.Enabled = True
        txtSecondary.Enabled = True
        txtAvailableCredit.Enabled = True
        txtUsedLineOfCredit.Enabled = True
        txtEmail.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub updateCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Customer Update Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            ' Show the customers form
            frmCustomers.Show()
        End If
    End Sub
End Class

