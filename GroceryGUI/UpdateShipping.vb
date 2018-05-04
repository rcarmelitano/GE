Public Class frmUpdateShipping
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form if the user confirms it
        If MessageBox.Show("Are you sure you want to cancel?", "Shipment Update Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Display the primary form
            frmPrimaryForm.Show()
        End If
    End Sub

    Private Sub mnuViewShipments_Click(sender As Object, e As EventArgs) Handles mnuViewShipments.Click
        ' Display the shipping view form
        frmShipmentView.Show()
    End Sub

    Private Sub btnCreateShipment_Click(sender As Object, e As EventArgs) Handles btnCreateShipment.Click
        ' Show a message to the user
        MessageBox.Show("Your shipment has been updated.", "Shipment Update Confirmation", MessageBoxButtons.OK)



    End Sub

    Private Sub frmUpdateShipping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class