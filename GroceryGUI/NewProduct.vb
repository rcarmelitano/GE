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

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Cancel",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Display the menu for Products and Inventory
            Me.Close()
            frmProductsAndInventoryMenu.Show()
        End If
    End Sub

    Private Sub ViewProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        ' Display the list of existing products
        frmProductsView.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check to make sure that the user can continue on with the product creation
        If txtProductName.Text <> String.Empty And txtDescription.Text <> String.Empty And txtDepartmentID.Text <> String.Empty And txtRetailUnit.Text <> String.Empty And txtRetailCost.Text <> String.Empty And txtCategoryID.Text <> String.Empty Then

            If MessageBox.Show("Are you sure you want to save your changes?", "Product Update",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

                ' Create the new product
                productConnection.Close()

                Dim addProduct As New SqlCommand("UPDATE Products SET SKU = @SKU,categoryID = @categoryID,departmentID =@departmentID,productName =@productName,description =@description,taxable =@taxable,UPC =@UPC,retailUnit =@retailUnit,
                                                 retailCost = @retailCost, status = @status where SKU = @SKU", productConnection)

                addProduct.Parameters.AddWithValue("@SKU", txtSKU.Text)
                addProduct.Parameters.AddWithValue("@categoryID", txtCategoryID.Text)
                addProduct.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
                addProduct.Parameters.AddWithValue("@productName", txtProductName.Text)
                addProduct.Parameters.AddWithValue("@description", txtDescription.Text)
                addProduct.Parameters.AddWithValue("@taxable", cbTaxable.Checked)
                addProduct.Parameters.AddWithValue("@UPC", mtxtUPC.Text)
                addProduct.Parameters.AddWithValue("@retailUnit", txtRetailUnit.Text)
                addProduct.Parameters.AddWithValue("@retailCost", txtRetailCost.Text)
                addProduct.Parameters.AddWithValue("@status", cbStatus.Checked)

                ' Open the connection to the database and pass in the information
                productConnection.Open()
                addProduct.ExecuteNonQuery()

                MessageBox.Show("The product has been updated.")
                Me.Close()
                frmProducts.Show()
            End If
        Else
            ' Display an error message to the user
            MessageBox.Show("You must fill out all of the required information to Update. Please try again.")
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        ' Check to make sure that the user can continue on with the product creation
        If mtxtSKU.Text <> String.Empty And txtProductName.Text <> String.Empty And txtDescription.Text <> String.Empty And txtDepartmentID.Text <> String.Empty And txtRetailUnit.Text <> String.Empty And txtRetailCost.Text <> String.Empty And txtCategoryID.Text <> String.Empty Then

            ' Check for duplicated UPC and/or SKU
            Dim checkSKU As New SqlCommand("select SKU from Products where SKU LIKE @SKU", productConnection)
            Dim checkUPC As New SqlCommand("select UPC from Products where UPC LIKE @UPC", productConnection)

            If checkSKU.Parameters.Contains(mtxtSKU.Text) Then
                MessageBox.Show("The SKU you have entered is the same as a pre-existing SKU in the database. Please change the SKU and try again.")

                ' Exit
                Exit Sub
            ElseIf checkSKU.Parameters.Contains(mtxtUPC.Text) Then
                MessageBox.Show("The UPC you have entered is the same as a pre-existing UPC in the database. Please change the UPC and try again.")

                ' Exit
                Exit Sub
            End If

            If MessageBox.Show("You are about to create a new product with the information entered as shown. Would you like to create this product?", "Product Creation",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

                ' Create the new product
                productConnection.Close()

                ' Add the new product and set the values entered to the attributes of the products table
                Dim addProduct As New SqlCommand("INSERT INTO Products (SKU, categoryID, departmentID, productName, description, taxable, UPC,
                                                retailUnit, retailCost, status)
                                                VALUES(@SKU, @categoryID, @departmentID, @productName, @description, @taxable, @UPC,
                                                @retailUnit, @retailCost, @status)", productConnection)

                addProduct.Parameters.AddWithValue("@SKU", mtxtSKU.Text)
                addProduct.Parameters.AddWithValue("@categoryID", txtCategoryID.Text)
                addProduct.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
                addProduct.Parameters.AddWithValue("@productName", txtProductName.Text)
                addProduct.Parameters.AddWithValue("@description", txtDescription.Text)
                addProduct.Parameters.AddWithValue("@taxable", cbTaxable.Checked)
                addProduct.Parameters.AddWithValue("@UPC", mtxtUPC.Text)
                addProduct.Parameters.AddWithValue("@retailUnit", txtRetailUnit.Text)
                addProduct.Parameters.AddWithValue("@retailCost", txtRetailCost.Text)
                addProduct.Parameters.AddWithValue("@status", cbStatus.Checked)

                ' Open the connection to the database and pass in the information
                productConnection.Open()
                addProduct.ExecuteNonQuery()

                ' Pass the value of the SKU over to the New Inventory form
                frmNewInventory.selectedSKU = mtxtSKU.Text
                frmNewInventory.hasUPC = rbYes.Checked

                ' Hide the current form and display the next form (NewInventory) to continue the new product process
                Me.Hide()
                frmNewInventory.Show()
            End If
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
        ' Enable the UPC box
        mtxtUPC.Enabled = True
        mtxtUPC.ReadOnly = False
        frmNewInventory.txtUnitCost.Enabled = True
        frmNewInventory.txtUnitCost.ReadOnly = False
    End Sub

    Private Sub rbYes_CheckedChanged(sender As Object, e As EventArgs) Handles rbYes.CheckedChanged
        ' Disable the UPC box and clear the text
        mtxtUPC.Clear()
        mtxtUPC.Enabled = False
        mtxtUPC.ReadOnly = True
        frmNewInventory.txtUnitCost.Enabled = False
        frmNewInventory.txtUnitCost.ReadOnly = True
        frmNewInventory.txtUnitCost.Text = "0.0000"
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        ' Enable all the buttons that should be enabled
        ViewProductsToolStripMenuItem.Enabled = True
        HelpToolStripMenuItem.Enabled = True
        cbStatus.Enabled = True
        txtProductName.Enabled = True
        txtDescription.Enabled = True
        txtRetailUnit.Enabled = True
        cbTaxable.Enabled = True
        txtRetailCost.Enabled = True
        btnContinue.Enabled = True
        btnAddCategory.Visible = True
        btnAddDepartment.Visible = True
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Display a message to the user
        MessageBox.Show("Creating a product is a two step process, fill out the information seen here and once finished, press the ""Continue"" button to proceed to the second step.")
    End Sub
End Class