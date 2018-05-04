Public Class frmorderHIstory


    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

	Public Sub loadDetails(ByVal orderID As Integer)
		Me.ControlBox = False
		Me.Order_DetailsTableAdapter.orderHistory(Me.GEDataSet.Order_Details, orderID)
	End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form and display the customer history form
        Me.Close()
        frmCustomerHistory.Show()
    End Sub
End Class

