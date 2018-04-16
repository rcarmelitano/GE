Public Class frmNewShipping

    ' Holds the shipping cost
    Dim shippingCost As Double = 0

    Private Sub mnuViewShipments_Click(sender As Object, e As EventArgs) Handles mnuViewShipments.Click
        ' Hide the current form and display the shipping view form
        Me.Hide()

    End Sub

    Private Sub rdoBtnLocalYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtnLocalYes.CheckedChanged
        ' Disable cmbCouriers
        cmbCouriers.Enabled = False
    End Sub

    Private Sub UpdateShipmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateShipmentToolStripMenuItem.Click
        ' Close the form and open the update shipping form
        Me.Close()
        frmUpdateShipping.Show()
    End Sub

    Private Sub NewShipment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel? All entered information will be lost.", "New Shipment Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form and show the primary form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub rdoBtnLocalNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBtnLocalNo.CheckedChanged
        ' Enable cmbCouriers
        cmbCouriers.Enabled = True
        ' Clear any selected courier
        cmbCouriers.Text = String.Empty
    End Sub

    Private Sub btnCreateShipment_Click(sender As Object, e As EventArgs) Handles btnCreateShipment.Click
        ' Display the shipment Confirmation screen
        frmShipmentConfirmation.Show()
    End Sub

    Private Sub cmbCouriers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCouriers.SelectedIndexChanged
        If cmbCouriers.SelectedIndex = 0 Then
            shippingCost = 7.0
            lblPrice.Text = shippingCost.ToString("N2")
        ElseIf cmbCouriers.SelectedIndex = 1 Then
            shippingCost = 7.5
            lblPrice.Text = shippingCost.ToString("N2")
        ElseIf cmbCouriers.SelectedIndex = 2 Then
            shippingCost = 7.05
            lblPrice.Text = shippingCost
        End If
    End Sub
End Class
