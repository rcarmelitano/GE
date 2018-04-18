Public Class frmCustomers
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        ' Hide the current form and open the form to view customer information
        frmNewCustomer.Show()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the current form and display the primaryForm
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub CustomersView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to close the customers list?", "Customers Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
        End If
    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmCustomers_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.CustomersTableAdapter.customerID(Me.GEDataSet.Customers, CType(txtCustomerID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        ' Display the customer history form
        frmCustomerHistory.Show()
    End Sub

    Private Sub txtCustomerID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerID.KeyDown
        ' Search for customer ID using enter key if pressed
        If e.KeyCode = Keys.Enter Then
            Try
                Me.CustomersTableAdapter.customerID(Me.GEDataSet.Customers, CType(txtCustomerID.Text, Integer))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        If e.ColumnIndex <> 11 Then
            Exit Sub
        End If

        Dim V As String = dgvCustomers.Rows(e.RowIndex).Cells(0).Value
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = dgvCustomers.Rows(index)
        frmUpdateCustomer.CustomerIDTextBox.Text = selectedrow.Cells(0).Value.ToString()
        frmUpdateCustomer.txtFirst.Text = selectedrow.Cells(1).Value.ToString()
        frmUpdateCustomer.txtLast.Text = selectedrow.Cells(2).Value.ToString()
        frmUpdateCustomer.txtbirthdate.Text = selectedrow.Cells(3).Value.ToString()
        frmUpdateCustomer.txtprimary.Text = selectedrow.Cells(4).Value.ToString()
        frmUpdateCustomer.txtSecondary.Text = selectedrow.Cells(5).Value.ToString()
        frmUpdateCustomer.txtEmail.Text = selectedrow.Cells(6).Value.ToString()

        Me.Hide()
        frmUpdateCustomer.Show()
    End Sub


End Class