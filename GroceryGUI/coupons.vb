Public Class frmCoupons
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
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

    Private Sub ViewCouponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewCoupons.Click
        ' Show the coupons view form
        frmCouponsView.Show()
    End Sub

    Private Sub frmCoupons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub ViewPromotionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuViewPromotions.Click
        ' Display the promotions form
        frmPromotionsView.Show()
    End Sub

    Private Sub ViewDiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewDiscounts.Click
        ' Display the discounts form
        frmDiscountsView.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        ' Tell the user what to do
        MessageBox.Show("To create a coupon, fill out the information needed below." & vbCrLf & "The tabs allow you to add a Promotion ID for the coupon, as well as a Discount ID." & vbCrLf & vbCrLf & "Both a Promotion ID and a Discount ID are required to create a coupon.")
    End Sub

    Private Sub btnPromotionIDSearch_Click(sender As Object, e As EventArgs) Handles btnPromotionIDSearch.Click
        ' Perform a search for promotion ID
        Try
            Me.PromotionsTableAdapter.promotionID(Me.GEDataSet.Promotions, CType(txtPromotionID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please only enter a valid Promotion ID.")
        End Try
    End Sub

    Private Sub btnDiscountIDSearch_Click(sender As Object, e As EventArgs) Handles btnDiscountIDSearch.Click
        ' Perform a search for discount ID
        Try
            Me.DiscountsTableAdapter.discountID(Me.GEDataSet.Discounts, CType(txtDiscountID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please only enter a valid Discount ID.")
        End Try
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddPromotion.Click
        Try
            ' Store the promotion ID in the textbox and make it read only unless the user hits the clear button, allowing for search again
            txtPromotionID.Text = dgvPromotions.CurrentCell.Value.ToString()
        Catch
            MessageBox.Show("Please only add valid Promotion ID's")
        End Try
    End Sub

    Private Sub btnAddDiscount_Click(sender As Object, e As EventArgs) Handles btnAddDiscount.Click
        Try
            ' Store the promotion ID in the textbox and make it read only unless the user hits the clear button, allowing for search again
            txtDiscountID.Text = dgvDiscounts.CurrentCell.Value.ToString()
        Catch
            MessageBox.Show("Please only add valid Discount ID's")
        End Try
    End Sub
End Class