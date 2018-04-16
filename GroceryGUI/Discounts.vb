Public Class frmDiscounts
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Ensure that the user wants to close the form
        Me.Close()
    End Sub

    Private Sub ViewDiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDiscountsToolStripMenuItem.Click
        ' Display the discountsView form
        frmDiscountsView.Show()
    End Sub

    Private Sub frmDiscounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAddDiscount.Enabled = False
    End Sub

    Private Sub Discounts_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Discounts Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPromotion.Show()
        End If
    End Sub
End Class