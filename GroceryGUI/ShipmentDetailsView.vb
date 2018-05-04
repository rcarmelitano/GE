Public Class frmShipmentDetailsView
    Private Sub ShipmentDetailsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Shipment_Details' table. You can move, or remove it, as needed.
        Me.Shipment_DetailsTableAdapter.Fill(Me.GEDataSet.Shipment_Details)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the current form
        Me.Close()
    End Sub
End Class