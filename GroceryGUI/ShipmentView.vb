Public Class frmShipmentView
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub ShipmentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Shipment' table. You can move, or remove it, as needed.
        Me.ShipmentTableAdapter.Fill(Me.GEDataSet.Shipment)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Display a helpful messagebox to the user
        MessageBox.Show("What you are seeing is a list of all shipments, old and new." & vbCrLf & "If you click the ""View Details"" button for any of the shipments, you can see the selected shipment's details.")
    End Sub
End Class