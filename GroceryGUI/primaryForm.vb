Public Class frmPrimaryForm
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the program
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Hide the primaryForm and display the checkoutForm
        frmCheckoutForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ' Hide the primaryForm and display the customerView
        frmCustomers.Show()
        Me.Hide()
    End Sub

    Private Sub btnPromotions_Click(sender As Object, e As EventArgs) Handles btnPromotions.Click
        ' Hide the primaryForm and display the promotions form
        frmPromotion.Show()
        Me.Hide()
    End Sub

    Private Sub btnItemReturns_Click(sender As Object, e As EventArgs) Handles btnItemReturns.Click
        ' Hide the primaryForm and display the returns form
        frmNewReturn.Show()
        Me.Hide()
    End Sub

    Private Sub primaryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to close the program?", "Close Program",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnDeliveries_Click(sender As Object, e As EventArgs) Handles btnDeliveries.Click
        ' Hide the current form and show the shipping form
        Me.Hide()
        frmNewShipping.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ' Hide the current form and display the reports menu form
        Me.Hide()
        frmReportsMenu.Show()
    End Sub

    Private Sub btnGiftCards_Click(sender As Object, e As EventArgs) Handles btnGiftCards.Click
        ' Hide the current form and display the gift cards form
        Me.Hide()
        frmGiftCards.Show()
    End Sub
End Class