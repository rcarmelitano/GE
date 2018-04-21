Public Class frmNewReturn
    Private Sub btnFinalizeReturn_Click(sender As Object, e As EventArgs) Handles btnFinalizeReturn.Click
        ' Show a message to the user
        If MessageBox.Show("          Your return has been finalized." & vbCrLf & "    Do you want to make another return?", "Return",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
            Me.Close()
            frmPrimaryForm.Show()
        End If

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the current form and display the primaryForm
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub frmNewReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.GEDataSet.Order_Details)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
            txtOrderDetailID.Text = dgvOrderDetails.Item(0, dgvOrderDetails.CurrentCell.Value - 1).Value

            ' Display the quantiy of the selected order detail in txtQuantity
            nudQuantity.Text = dgvOrderDetails.Item(2, dgvOrderDetails.CurrentCell.Value - 1).Value
        Catch
            MessageBox.Show("You can only add a Customer ID." & vbCrLf & "Click an ID from the list and press the ""Add"" button to add it to the textbox.")

            ' Clear the quantity and order details id textbox
            nudQuantity.Text = String.Empty
            txtOrderDetailID.Clear()
        End Try
    End Sub
End Class