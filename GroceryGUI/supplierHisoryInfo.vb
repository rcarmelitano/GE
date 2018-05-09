Public Class supplierHisoryInfo
    Private Sub Purchase_Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Purchase_Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Public Sub loadDetails(ByVal orderID As Integer)
        Me.ControlBox = False
        Me.Purchase_Order_DetailsTableAdapter.PurchaseOrderHistory(Me.GEDataSet.Purchase_Order_Details, orderID)
    End Sub


End Class