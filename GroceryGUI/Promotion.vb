Public Class frmPromotion
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Ensure that the user wants to close the form
        Me.Close()
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountsToolStripMenuItem.Click
        ' Hide the current form and open the discounts form
        Me.Hide()
        frmDiscounts.Show()
    End Sub

    Private Sub CouponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouponsToolStripMenuItem.Click
        ' Hide the current form and display the coupons form
        Me.Hide()
        frmCoupons.Show()
    End Sub

    Private Sub Promotion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Promotion Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
        End If
    End Sub

    Private Sub ViewPromotionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPromotionsToolStripMenuItem.Click
        ' Display the promotions view form
        frmPromotionsView.Show()
    End Sub

    Private Sub frmPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class