Public Class frmNewProduct

    Private Sub btnSearchCategoryID_Click(sender As Object, e As EventArgs) Handles btnSearchCategoryID.Click
        ' Perform a search for category ID
        Try
            Me.CategoriesTableAdapter.categoryID(Me.GEDataSet.Categories, CType(txtCategoryID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please enter a valid Category ID.")
        End Try

        If txtCategoryID.Text = String.Empty Then
            'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
            Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)
        End If
    End Sub

    Private Sub btnSearchDepartmentID_Click(sender As Object, e As EventArgs) Handles btnSearchDepartmentID.Click
        ' Perform a search for department ID
        Try
            Me.DepartmentsTableAdapter.departmentIDSearch(Me.GEDataSet.Departments, CType(txtDepartmentID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please enter a valid Category ID.")
        End Try
    End Sub

    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub NewProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel making a new product?", "Product Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            ' Display the menu for Products and Inventory
            frmProductsAndInventoryMenu.Show()
        End If
    End Sub

    Private Sub ViewProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        ' Display the list of existing products
        frmProductsView.Show()
    End Sub
End Class