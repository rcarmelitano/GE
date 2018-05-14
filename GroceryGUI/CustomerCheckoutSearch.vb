Public Class frmCustomerCheckoutSearch

    Dim wholeSale As Boolean

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub CustomerCheckoutSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)

        Me.ControlBox = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)

        cmbSearchType.SelectedIndex = -1
        txtCustomerSearch.Text = String.Empty
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (cmbSearchType.Text = "ID") Then
            ' Perform a search for a customer based on the selected search type
            Try
                Me.CustomersTableAdapter.customerID(Me.GEDataSet.Customers, CType(txtCustomerSearch.Text, Integer))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid customer ID, please try again.")
            End Try
        ElseIf (cmbSearchType.Text = "First Name") Then
            Try
                Me.CustomersTableAdapter.grabCustomerFirstName(Me.GEDataSet.Customers, txtCustomerSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid first name, please try again.")
            End Try
        ElseIf (cmbSearchType.Text = "Last Name") Then
            Try
                Me.CustomersTableAdapter.customerName(Me.GEDataSet.Customers, txtCustomerSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid last name, please try again.")
            End Try
        ElseIf (cmbSearchType.Text = "Primary Phone") Then
            Try
                Me.CustomersTableAdapter.customerPrimaryPhone(Me.GEDataSet.Customers, txtCustomerSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid last name, please try again.")
            End Try
        ElseIf (cmbSearchType.Text = "Email") Then
            Try
                Me.CustomersTableAdapter.FillBy(Me.GEDataSet.Customers, txtCustomerSearch.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid last name, please try again.")
            End Try
        End If
    End Sub

    Private Sub cmbSearchType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchType.SelectedIndexChanged
        ' Enable the textbox for customer search if a choice is selected
        If (cmbSearchType.Text <> String.Empty) Then
            txtCustomerSearch.Enabled = True
            txtCustomerSearch.ReadOnly = False
        End If
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        ' Exit if the column index is not equal to 5
        If e.ColumnIndex <> 5 Then
            Exit Sub
        End If

        ' Get the selected customer ID and display it on the checkout form to use for reference and printing
        Dim selectedrow As DataGridViewRow
        selectedrow = dgvCustomers.Rows(e.RowIndex)
        frmCheckoutForm.txtCustomerID.Text = selectedrow.Cells(0).Value.ToString()
        txtCustomerID.Text = selectedrow.Cells(0).Value.ToString()
        frmCheckoutForm.btnCustomerSearch.Enabled = False

        ' Enable the Account button on the checkout form if the customer is a wholesale customer
        wholeSale = selectedrow.Cells(4).Value.ToString()
        If wholeSale = True Then
            frmCheckoutForm.btnAccount.Enabled = True
        End If

        ' Reset the controls
        cmbSearchType.SelectedItem = -1
        txtCustomerSearch.Text = String.Empty
        txtCustomerSearch.Enabled = False
        txtCustomerSearch.ReadOnly = True
        txtCustomerID.Clear()

        ' Close the form
        Me.Close()
    End Sub
End Class