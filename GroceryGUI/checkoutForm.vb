Public Class frmCheckoutForm

	Dim total As Double = 0
	Const tax As Double = 0.082
	Dim subtotatal As Double = 0
	Dim discount As Double = 0
	Dim taxtotal As Double = 0



	'--------------------------------------------------------------------------------------------------------back button clicked 
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
		' Close the form.
		Me.Close()
		frmPrimaryForm.Show()
	End Sub
	'------------------------------------------------------------------------------------------------------------hot key button clicked 
	Private Sub btnHotKeys_Click(sender As Object, e As EventArgs) Handles btnHotKeys.Click
		' Open the quickKeyMenu form
		frmQuickKey.Show()

	End Sub
	'---------------------------------------------------------------------------------------------------------------------------------------handles adding a new customer 
	Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
		' Open the newCustomer form
		frmCustomers.NewCustomerToolStripMenuItem.PerformClick()
		Me.Close()
	End Sub

	'----------------------------------------------------------------------------------------------------------------------------form closing
	Private Sub checkoutForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		' Ask the user if they are sure they want to close the current form
		If MessageBox.Show("Are you sure you want to cancel?", "Checkout Cancellation",
		   MessageBoxButtons.YesNo) = DialogResult.No Then
			e.Cancel = True
		Else
			frmPrimaryForm.Show()
		End If
	End Sub

	'---------------------------------------------------------------------------------------------------------------------opens up custom search
	Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
		POSCustomerSearch.ShowDialog()

	End Sub

	'--------------------------------------------------------------------------------------------------------------------------search through inventory
	Private Sub btnInventorySearch_Click(sender As Object, e As EventArgs) Handles btnInventorySearch.Click

	End Sub

	'-----------------------------------------------------------------------------------------------------------------------form loader
	Private Sub frmCheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
		Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
		'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
		Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

	'-----------------------------------------------------------------------------------------------------------------------setting employee ID
	Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged
		txtEmployeeID.Text = trying
	End Sub

	'-------------------------------------------------------------------------------------------------------------------checking the qunity
	Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
		If txtCustomerID.Text = "" Then
			MessageBox.Show("you must select a customer")
			Exit Sub
		End If
	End Sub

	'----------------------------------------------------------------------------------------------------------------barcode changed
	Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged

	End Sub

	'--------------------------------------------------------------------------------------------------------------------------------------invenotry
	Private Sub txtInventory_TextChanged(sender As Object, e As EventArgs) Handles txtInventory.TextChanged

	End Sub

End Class
