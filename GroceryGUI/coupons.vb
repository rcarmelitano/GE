Public Class frmCoupons
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
        'Display the promotions form
        frmPromotion.Show()
    End Sub

    Private Sub coupons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Coupon Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPromotion.Show()
        End If
    End Sub

    Private Sub ViewCouponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCouponsToolStripMenuItem.Click
        ' Show the coupons view form
        frmCouponsView.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmCoupons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

    End Sub

    Private Sub ViewPromotionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewPromotionsToolStripMenuItem1.Click
        ' Display the promotions form
        frmPromotionsView.Show()
    End Sub

    Private Sub ViewDiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDiscountsToolStripMenuItem.Click
        ' Display the discounts form
        frmDiscountsView.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Tell the user what to do
        MessageBox.Show("To create a coupon, fill out the information needed below." & vbCrLf & "The tabs allow you to add a Promotion ID for the coupon, as well as a Discount ID." & vbCrLf & vbCrLf & "Both a Promotion ID and a Discount ID are required to create a coupon.")
    End Sub

    Private Sub btnPromotionIDSearch_Click(sender As Object, e As EventArgs) Handles btnPromotionIDSearch.Click

    End Sub

    Private Sub btnDiscountIDSearch_Click(sender As Object, e As EventArgs) Handles btnDiscountIDSearch.Click

    End Sub
End Class