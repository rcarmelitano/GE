Public Class ShippingAdresses
	Private Sub Billing_AddressesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
		Me.Validate()
		Me.Billing_AddressesBindingSource.EndEdit()
		Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

	End Sub

	Private Sub ShippingAdresses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'GEDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
		Me.Billing_AddressesTableAdapter.Fill(Me.GEDataSet.Billing_Addresses)

	End Sub
End Class