Public Class supplierhistory
    Private Sub Purchase_OrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Purchase_OrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Purchase_OrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)
    End Sub

	Public Sub loadDetails(ByVal ID As Integer)
		Me.Purchase_OrderTableAdapter.PurchaseHistory(Me.GEDataSet.Purchase_Order, ID)
	End Sub


End Class