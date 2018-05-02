Imports System.Data
Imports System.Data.SqlClient

Public Class frmSuppliers

	'-------------------connection string to the database----------------------------------------------------------------------------------------
	Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


	'------------------function to allow me to format phone numbers correctly-----------------------------------------------------------------------


	Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
		Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
		'TODO: This line of code loads data into the 'GEDataSet.Shippers' table. You can move, or remove it, as needed.
		Me.ShippersTableAdapter.Fill(Me.GEDataSet.Shippers)
	End Sub
	'--------------------------------------------------------------------------------------------------------------------------------------------
	Private Sub dgvSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellContentClick

		'---------------------------------button click on the datagrid--------------------------------------------------------------------------
		If e.ColumnIndex <> 13 Then
			Exit Sub
		End If

		Dim V As String = dgvSuppliers.Rows(e.RowIndex).Cells(0).Value
		Dim index As Integer
		index = e.RowIndex
		Dim selectedrow As DataGridViewRow
		selectedrow = dgvSuppliers.Rows(index)
		'frmUpdateCustomer.CustomerIDTextBox.Text = selectedrow.Cells(0).Value.ToString()
		NewSupplier.txtSupplierID.Text = selectedrow.Cells(0).Value.ToString()
		NewSupplier.txtCompanyName.Text = selectedrow.Cells(1).Value.ToString()
		NewSupplier.txtFirstName.Text = selectedrow.Cells(2).Value.ToString()
		NewSupplier.txtLastName.Text = selectedrow.Cells(3).Value.ToString()
		NewSupplier.txtFax.Text = selectedrow.Cells(4).Value.ToString()
		NewSupplier.txtFax.Text = selectedrow.Cells(5).Value.ToString()
		NewSupplier.txtEmail.Text = selectedrow.Cells(6).Value.ToString()
		NewSupplier.txtAddressOne.Text = selectedrow.Cells(7).Value.ToString()
		NewSupplier.txtAddressTwo.Text = selectedrow.Cells(8).Value.ToString()
		NewSupplier.txtCity.Text = selectedrow.Cells(9).Value.ToString()
		NewSupplier.txtstate.Text = selectedrow.Cells(10).Value.ToString()
		NewSupplier.txtZip.Text = selectedrow.Cells(11).Value.ToString()
		NewSupplier.txtNotes.Text = selectedrow.Cells(12).Value.ToString()

		Me.Close()
		NewSupplier.Show()
	End Sub

	Private Sub mnuNewSupplier_Click(sender As Object, e As EventArgs) Handles mnuNewSupplier.Click
		'---------------------------------------------make forms readable, and enabled 
		NewSupplier.txtCompanyName.Enabled = True
		NewSupplier.txtSupplierID.Enabled = False
        NewSupplier.mnuhistory.Enabled = False
        NewSupplier.UpdateToolStripMenuItem.Enabled = False
        NewSupplier.txtFirstName.Enabled = True
		NewSupplier.txtLastName.Enabled = True
		NewSupplier.txtFax.Enabled = True
		NewSupplier.txtFax.Enabled = True
		NewSupplier.txtEmail.Enabled = True
		NewSupplier.txtAddressOne.Enabled = True
		NewSupplier.txtAddressTwo.Enabled = True
		NewSupplier.txtCity.Enabled = True
		NewSupplier.txtstate.Enabled = True
		NewSupplier.txtZip.Enabled = True
        NewSupplier.txtNotes.Enabled = True
        NewSupplier.btnsave2.Enabled = True

        NewSupplier.txtCompanyName.ReadOnly = False
		NewSupplier.txtSupplierID.ReadOnly = True
		NewSupplier.txtFirstName.ReadOnly = False
		NewSupplier.txtLastName.ReadOnly = False
		NewSupplier.txtFax.ReadOnly = False
		NewSupplier.txtFax.ReadOnly = False
		NewSupplier.txtEmail.ReadOnly = False
		NewSupplier.txtAddressOne.ReadOnly = False
		NewSupplier.txtAddressTwo.ReadOnly = False
		NewSupplier.txtCity.ReadOnly = False
		NewSupplier.txtZip.ReadOnly = False
        NewSupplier.txtNotes.ReadOnly = False
        NewSupplier.txtPhone.Enabled = True
        NewSupplier.txtPhone.ReadOnly = False

        '------------------------------------------------------------------------------------------------------------
        NewSupplier.Show()
		Me.Close()
	End Sub

	Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
		Me.Close()
		frmPrimaryForm.Show()
		'---------------------------------------------------------------------------------------------------------------------
	End Sub
End Class