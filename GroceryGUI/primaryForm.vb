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
        frmNewAddress.Show()
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

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ' Hide the current form and display the products and inventory menu
        Me.Hide()
        frmProductsAndInventoryMenu.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------------closing form and opening suppliers form
    Private Sub btnSupplierInfo_Click(sender As Object, e As EventArgs) Handles btnSupplierInfo.Click
		Me.Hide()
		frmSuppliers.Show()
	End Sub
    '-------------------------------------------------------------------------------------------------------------employee button clicked 
    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Employees.Show()
        Me.Hide()
    End Sub

    '-----------------------------------------------------------------------------------------------------search for an employee by name or ID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        MainFormEmployeeSearch.ShowDialog()
    End Sub

    Private Sub TextBox1_EnabledChanged(sender As Object, e As EventArgs) Handles TextBox1.EnabledChanged
        If TextBox1.Text <> "" Then

            btnCheckout.Enabled = True
            btnSupplierInfo.Enabled = True
            btnItemReturns.Enabled = True
            btnCustomers.Enabled = True
            btnInventory.Enabled = True
            btnGiftCards.Enabled = True
            btnEmployees.Enabled = True
            btnDeliveries.Enabled = True
            btnReports.Enabled = True
            btnPromotions.Enabled = True
            btnDepartments.Enabled = True
            btnShipments.Enabled = True
            btnPurchaseOrders.Enabled = True
            btnMarketingCampaigns.Enabled = True

        End If
    End Sub

    Private Sub frmPrimaryForm_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If TextBox1.Text = "" Then

            MessageBox.Show("please select an employee")

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnShipments.Click
        NewShinpping.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMarketingCampaigns.Click
        MarketingCampaigns.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        'opens the categories and departments menuuuuuuuu
        Me.Hide()
        frmCategoriesAndDepartments.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnPurchaseOrders.Click
        ' Display the purchase orders form
        Me.Hide()
        frmPurchaseOrders.Show()
    End Sub
End Class