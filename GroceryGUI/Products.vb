Public Class frmProducts
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

    End Sub

    Private Sub NewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        ' Close the current form and display the new product form
        Me.Close()
        frmNewProduct.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the current form and show the products and inventory menu again
        Me.Close()
        frmProductsAndInventoryMenu.Show()
    End Sub

    Private Sub dgvProducts_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        If e.ColumnIndex <> 10 Then
            Exit Sub
        End If

        ' Modify the existing NewProduct form so it acts as an update form for Products
        frmNewProduct.txtSKU.Visible = True
        frmNewProduct.txtSKU.Enabled = False
        frmNewProduct.txtSKU.ReadOnly = True
        frmNewProduct.mtxtSKU.Visible = False
        frmNewProduct.mnuUpdate.Visible = True
        frmNewProduct.ViewProductsToolStripMenuItem.Enabled = False
        frmNewProduct.HelpToolStripMenuItem.Enabled = False
        frmNewProduct.cbStatus.Enabled = False
        frmNewProduct.mtxtSKU.Enabled = False
        frmNewProduct.mtxtUPC.Enabled = False
        frmNewProduct.rbNo.Enabled = False
        frmNewProduct.rbYes.Enabled = False
        frmNewProduct.txtProductName.Enabled = False
        frmNewProduct.txtDescription.Enabled = False
        frmNewProduct.txtRetailUnit.Enabled = False
        frmNewProduct.cbTaxable.Enabled = False
        frmNewProduct.txtRetailCost.Enabled = False
        frmNewProduct.btnContinue.Enabled = False
        frmNewProduct.btnAddCategory.Visible = False
        frmNewProduct.btnAddDepartment.Visible = False
        frmNewProduct.mtxtSKU.ReadOnly = True
        frmNewProduct.mtxtUPC.ReadOnly = True
        frmNewProduct.Label9.Visible = False
        frmNewProduct.rbYes.Visible = False
        frmNewProduct.rbNo.Visible = False
        frmNewProduct.Label5.Location = New Point(52, 78)
        frmNewProduct.mtxtUPC.Location = New Point(97, 75)
        frmNewProduct.Label3.Location = New Point(10, 107)
        frmNewProduct.txtProductName.Location = New Point(97, 105)
        frmNewProduct.txtDescription.Location = New Point(97, 135)
        frmNewProduct.Label4.Location = New Point(25, 137)
        frmNewProduct.btnContinue.Visible = False
        frmNewProduct.btnSave.Visible = True

        ' Pass in the values of the selected product to the update product form
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvProducts.Rows(e.RowIndex)
        frmNewProduct.txtSKU.Text = selectedRow.Cells(0).Value.ToString()
        frmNewProduct.txtCategoryID.Text = selectedRow.Cells(1).Value.ToString()
        frmNewProduct.txtDepartmentID.Text = selectedRow.Cells(2).Value.ToString()
        frmNewProduct.txtProductName.Text = selectedRow.Cells(3).Value.ToString()
        frmNewProduct.txtDescription.Text = selectedRow.Cells(4).Value.ToString()
        frmNewProduct.cbTaxable.Checked = selectedRow.Cells(5).Value.ToString()
        frmNewProduct.mtxtUPC.Text = selectedRow.Cells(6).Value.ToString()
        frmNewProduct.txtRetailUnit.Text = selectedRow.Cells(7).Value.ToString()
        frmNewProduct.txtRetailCost.Text = selectedRow.Cells(8).Value.ToString()
        frmNewProduct.cbStatus.Checked = selectedRow.Cells(9).Value.ToString()

        ' Close this form and display the update product form
        frmNewProduct.Show()
        Me.Close()
    End Sub
End Class