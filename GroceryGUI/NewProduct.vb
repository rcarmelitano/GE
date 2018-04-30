' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmNewProduct

    ' Create a new connection to the database for this form
    Dim productConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)

        ' Disable the Status checkbox
        cbStatus.Enabled = False
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

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        ' Check to make sure that the user can continue on with the product creation
        If mtxtSKU.Text <> String.Empty And txtProductName.Text <> String.Empty And txtDescription.Text <> String.Empty And txtDepartmentID.Text <> String.Empty And txtRetailUnit.Text <> String.Empty And txtRetailCost.Text <> String.Empty And txtCategoryID.Text <> String.Empty Then
            ' Hide the current form and display the next form (NewInventory) to continue the new product process
            Me.Hide()
            frmNewInventory.Show()
        Else
            ' Display an error message to the user
            MessageBox.Show("You must fill out all of the required information to continue. Please try again.")
        End If
    End Sub

    Private Sub dgvDepartments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellContentClick
        ' Do nothing if the column index of 2 is not selected
        If e.ColumnIndex <> 2 Then
            Exit Sub
        End If

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvDepartments.Rows(index)

        ' Grab the selected ID and stick it in the txtDepartmentID textbox
        txtDepartmentID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub dgvCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellContentClick
        ' Do nothing if the column index of 2 is not selected
        If e.ColumnIndex <> 2 Then
            Exit Sub
        End If

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvCategories.Rows(index)

        ' Grab the selected ID and stick it in the txtCategoryID textbox
        txtCategoryID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub rbNo_CheckedChanged(sender As Object, e As EventArgs) Handles rbNo.CheckedChanged
        ' Get the max UPC number currently in the database and then add 1
        Dim UPC As Integer = 0
        Dim getMaxUPCAndIncrement As New SqlCommand("select max(UPC) + 1 from Products", productConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxUPCAndIncrement command above
        productConnection.Open()
        Dim rowsAffected As Integer = getMaxUPCAndIncrement.ExecuteNonQuery()
        UPC = getMaxUPCAndIncrement.ExecuteScalar()
        ' Display the new UPC
        txtUPC.Text = UPC
    End Sub
End Class