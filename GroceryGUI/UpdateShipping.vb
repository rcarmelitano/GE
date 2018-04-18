Public Class frmUpdateShipping
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub mnuViewShipments_Click(sender As Object, e As EventArgs) Handles mnuViewShipments.Click
        ' Display the shipping view form
        frmShipmentView.Show()
    End Sub
End Class