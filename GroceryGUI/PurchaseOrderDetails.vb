Public Class frmPurchaseOrderDetails
    Private Sub frmPurchaseOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.GEDataSet.Status)
        'TODO: This line of code loads data into the 'GEDataSet.Purchase_Order_Details' table. You can move, or remove it, as needed.
        'Me.Purchase_Order_DetailsTableAdapter.Fill(Me.GEDataSet.Purchase_Order_Details)

        ' Disable the control box
        Me.ControlBox = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and re-display the purchase orders form
        Me.Close()
        frmPurchaseOrders.Show()
    End Sub

    Public Sub getPurchaseOrderDetails(ByVal orderID As Integer)
        Me.Purchase_Order_DetailsTableAdapter.PurchaseOrderHistory(Me.GEDataSet.Purchase_Order_Details, orderID)
    End Sub
End Class