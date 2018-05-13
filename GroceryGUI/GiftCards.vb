Public Class frmGiftCards
    Private Sub frmGiftCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)
        'TODO: This line of code loads data into the 'GEDataSet.Gift_Cards' table. You can move, or remove it, as needed.
        Me.Gift_CardsTableAdapter.Fill(Me.GEDataSet.Gift_Cards)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGiftCards.CellContentClick
        ' Check if the button is clicked or not
        If e.ColumnIndex <> 4 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvGiftCards.Rows(e.RowIndex)
        frmUpdateGiftCard.txtGiftCardID.Text = selectedRow.Cells(0).Value.ToString()
        frmUpdateGiftCard.txtCustomerID.Text = selectedRow.Cells(1).Value.ToString()
        frmUpdateGiftCard.dtpDateOfPurchase.Text = selectedRow.Cells(2).Value.ToString()
        frmUpdateGiftCard.newMinimum = selectedRow.Cells(3).Value.ToString()

        ' Show the update giftcard form
        Me.Close()
        frmUpdateGiftCard.Show()
    End Sub

    Private Sub NewGiftCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGiftCardToolStripMenuItem.Click
        ' Close the form and open the new gift card form
        Me.Close()
        frmNewGiftCard.Show()
    End Sub
End Class