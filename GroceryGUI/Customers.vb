Imports System.Data
Imports System.Data.SqlClient


Public Class frmCustomers
    '------------------------------------------------------------------------------------------connection string to the database to write queries 
    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    '-----------------------------------------------------------------------------------------------------controls new customer click
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        ' Hide the current form and open the form to view customer information
        frmUpdateCustomer.txtFirst.ReadOnly = False
        frmUpdateCustomer.txtLast.ReadOnly = False
        frmUpdateCustomer.txtbirthdate.ReadOnly = False
        frmUpdateCustomer.txtprimary.ReadOnly = False
        frmUpdateCustomer.txtSecondary.ReadOnly = False
        frmUpdateCustomer.txtAvailableCredit.ReadOnly = False
        frmUpdateCustomer.txtUsedLineOfCredit.ReadOnly = False
        frmUpdateCustomer.txtEmail.ReadOnly = False
        frmUpdateCustomer.btnupdate.Enabled = False
        frmUpdateCustomer.btnupdate.Visible = False
        frmUpdateCustomer.btnNew.Visible = True
        frmUpdateCustomer.btnNew.Enabled = True
        ' Enable textboxes
        frmUpdateCustomer.txtFirst.Enabled = True
        frmUpdateCustomer.txtLast.Enabled = True
        frmUpdateCustomer.txtbirthdate.Enabled = True
        frmUpdateCustomer.txtprimary.Enabled = True
        frmUpdateCustomer.txtSecondary.Enabled = True
        frmUpdateCustomer.txtAvailableCredit.Enabled = True
        frmUpdateCustomer.txtUsedLineOfCredit.Enabled = True
        frmUpdateCustomer.txtEmail.Enabled = True
        frmUpdateCustomer.CheckBox1.Enabled = True
        frmUpdateCustomer.CheckBox2.Enabled = True
        frmUpdateCustomer.CheckBox3.Enabled = True
        frmUpdateCustomer.ShowDialog()




    End Sub

    '---------------------------------------------------------------------------------------------------------controls back button click
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
		' Close the current form and display the primaryForm
		Me.Close()
		frmPrimaryForm.Show()
	End Sub
    '--------------------------------------------------------------------------------------------------code for when the form loads
    Private Sub frmCustomers_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
		Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub
    '------------------------------------------------------------------------------------------------search through customers
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
		Try
			Me.CustomersTableAdapter.customerID(Me.GEDataSet.Customers, CType(txtCustomerID.Text, Integer))
		Catch ex As System.Exception
			System.Windows.Forms.MessageBox.Show(ex.Message)
		End Try
	End Sub
    '---------------------------------------------------------------------------------------------------------search when enter is pressed
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
    '--------------------------------------------------------------------------------------------------sends data to the new/update customer table
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
        frmUpdateCustomer.txtbirthdate.Text = CType(selectedrow.Cells(3).Value, Date).ToString("MMddyyyy")
        frmUpdateCustomer.txtprimary.Text = selectedrow.Cells(4).Value.ToString()
        frmUpdateCustomer.txtSecondary.Text = selectedrow.Cells(5).Value.ToString()
		frmUpdateCustomer.txtEmail.Text = selectedrow.Cells(6).Value.ToString()
		frmUpdateCustomer.txtAvailableCredit.Text = selectedrow.Cells(7).Value.ToString()
		frmUpdateCustomer.txtUsedLineOfCredit.Text = selectedrow.Cells(8).Value.ToString()

		frmUpdateCustomer.CheckBox3.Checked = selectedrow.Cells(9).Value

        Me.Close()
        frmUpdateCustomer.Show()

    End Sub

	Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged
		Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)
	End Sub
End Class