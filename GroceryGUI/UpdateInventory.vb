' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmUpdateInventory

    ' Create a new connection to the database for this form
    Dim inventoryConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and display the inventory form again
        If MessageBox.Show("Are you sure you want to cancel?", "Cancel Update",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Display the inventory form
            Me.Close()
            frmInventory.Show()
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        ' Alter the properties of certain controls
        txtUnitCost.Enabled = True
        txtPurchaseUnit.Enabled = True
        txtReorderAmount.Enabled = True
        btnCreateProduct.Enabled = True
        btnAdd.Visible = True

    End Sub

    Private Sub frmUpdateInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)

    End Sub

    Private Sub dgvSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellContentClick
        If e.ColumnIndex <> 2 Then
            Exit Sub
        End If

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvSuppliers.Rows(index)

        ' Grab the selected ID and stick it in the txtSupplierID textbox
        txtSupplierID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub btnCreateProduct_Click(sender As Object, e As EventArgs) Handles btnCreateProduct.Click
        If txtUnitCost.Text <> String.Empty And txtSupplierID.Text <> String.Empty Then

            If MessageBox.Show("Are you sure you want to save your changes?", "Inventory Update",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

                ' Create the new product
                inventoryConnection.Close()

                Dim updateInventory As New SqlCommand("UPDATE Inventory SET inventoryID = @inventoryID, supplierID = @supplierID, SKU = @SKU, unitCost = @unitCost,
                purchaseUnit = @purchaseUnit, reorderAmount = @reorderAmount, inventoryCount = @inventoryCount WHERE inventoryID = @inventoryID", inventoryConnection)

                updateInventory.Parameters.AddWithValue("@inventoryID", txtInventoryID.Text)
                updateInventory.Parameters.AddWithValue("@supplierID", txtSupplierID.Text)
                updateInventory.Parameters.AddWithValue("@SKU", txtSKU.Text)
                updateInventory.Parameters.AddWithValue("@unitCost", txtUnitCost.Text)
                updateInventory.Parameters.AddWithValue("@purchaseUnit", txtPurchaseUnit.Text)
                updateInventory.Parameters.AddWithValue("@reorderAmount", txtReorderAmount.Text)
                updateInventory.Parameters.AddWithValue("@inventoryCount", txtInventoryCount.Text)

                ' Open the connection to the database and pass in the information
                inventoryConnection.Open()
                updateInventory.ExecuteNonQuery()

                MessageBox.Show("The selected inventory instance has been updated.")
                Me.Close()
                frmInventory.Show()
            End If
        Else
            ' Display an error message to the user
            MessageBox.Show("You must fill out all of the required information to Update. Please try again.")
        End If
    End Sub
End Class