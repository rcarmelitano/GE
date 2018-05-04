Public Class frmProductsAndInventoryMenu
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the form and show the home form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub btnCreateProducts_Click(sender As Object, e As EventArgs) Handles btnCreateProduct.Click
        ' Hide the form and display the products form
        Me.Hide()
        frmNewProduct.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        ' Hide the current form and display the products form
        Me.Hide()
        frmProducts.Show()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ' Hide the current form and display the inventory form
        Me.Hide()
        frmInventory.Show()
    End Sub

    Private Sub frmProductsAndInventoryMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class