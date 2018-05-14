Public Class ShipmentReceivingLog
    Private Sub ShipmentReceivingLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GEDataSet.Inventory)
        'TODO: This line of code loads data into the 'GEDataSet.Shipment_Received' table. You can move, or remove it, as needed.
        Me.Shipment_ReceivedTableAdapter.Fill(Me.GEDataSet.Shipment_Received)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
        frmPurchaseOrders.Show()
    End Sub

    Private Sub CheckInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckInToolStripMenuItem.Click
        ShipmentCheckIn.Show()
    End Sub
End Class