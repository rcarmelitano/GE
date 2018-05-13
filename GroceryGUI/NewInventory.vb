' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmNewInventory

    ' Public variables with values passed to this form from NewProduct
    Public selectedSKU As String
    Public hasUPC As String

    ' Create a new connection to the database for this form
    Dim inventoryConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub frmNewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If hasUPC = True Then

            ' Autofill the supplier ID for the user for a local produced product
            txtSupplierID.Text = 51
            txtSupplierID.Enabled = False
            Me.SuppliersTableAdapter.getSupplierID(Me.GEDataSet.Suppliers, txtSupplierID.Text)
        Else
            'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
            Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        End If

        ' Get the max id number currently in the database and then add 1
        Dim inventoryID As Integer = 0
        Dim getMaxInventoryIDAndIncrement As New SqlCommand("select max(inventoryID) + 1 from Inventory", inventoryConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        inventoryConnection.Open()
        Dim rowsAffected As Integer = getMaxInventoryIDAndIncrement.ExecuteNonQuery()
        inventoryID = getMaxInventoryIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtInventoryID.Text = inventoryID

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ' Hide the current form and display the new product form
        Me.Hide()
        frmNewProduct.Show()
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
        ' Check to make sure that the user can continue on with the product creation
        If txtInventoryID.Text <> String.Empty And txtSupplierID.Text <> String.Empty And txtUnitCost.Text <> String.Empty Then
            If MessageBox.Show("Are you sure you want to confirm the information entered as inventory data for your new product? 
                 More options and updates may be made by selecting ""Inventory"" on the menu afterwards.", "Inventory Creation",
                            MessageBoxButtons.YesNo) = DialogResult.Yes Then

                ' Create the new inventory
                inventoryConnection.Close()

                ' Add the new inventory and set the values entered to the attributes of the inventory table
                Dim addInventory As New SqlCommand("INSERT INTO Inventory (inventoryID, supplierID, SKU, unitCost, purchaseUnit, reorderAmount, inventoryCount)
                                 VALUES(@inventoryID, @supplierID, @SKU, @unitCost, @purchaseUnit, @reorderAmount, @inventoryCount)", inventoryConnection)

                addInventory.Parameters.AddWithValue("@inventoryID", txtInventoryID.Text)
                addInventory.Parameters.AddWithValue("@supplierID", txtSupplierID.Text)
                addInventory.Parameters.AddWithValue("@SKU", selectedSKU)
                addInventory.Parameters.AddWithValue("@unitCost", txtUnitCost.Text)
                addInventory.Parameters.AddWithValue("@purchaseUnit", txtPurchaseUnit.Text)
                addInventory.Parameters.AddWithValue("@reorderAmount", 0)
                addInventory.Parameters.AddWithValue("@inventoryCount", 0)

                ' Open the connection to the database and pass in the information
                inventoryConnection.Open()
                addInventory.ExecuteNonQuery()

                ' Close the form and return to the menu
                Me.Close()
                frmProductsAndInventoryMenu.Show()
            End If
        End If
    End Sub

    Private Sub ViewInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInventoryToolStripMenuItem.Click
        ' Show the list of current inventory
        frmInventoryView.ShowDialog()
    End Sub
End Class