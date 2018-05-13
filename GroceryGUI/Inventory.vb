' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmInventory

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        'TODO: This line of code loads data into the 'GEDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GEDataSet.Inventory)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form and display the product and inventory menu
        frmProductsAndInventoryMenu.Show()
        Me.Close()
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        If e.ColumnIndex <> 7 Then
            Exit Sub
        End If

        ' Pass in the values of the selected product to the updateInventory form
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvInventory.Rows(e.RowIndex)
        frmUpdateInventory.txtInventoryID.Text = selectedRow.Cells(0).Value.ToString()
        frmUpdateInventory.txtSupplierID.Text = selectedRow.Cells(1).Value.ToString()
        frmUpdateInventory.txtSKU.Text = selectedRow.Cells(2).Value.ToString()
        frmUpdateInventory.txtUnitCost.Text = selectedRow.Cells(3).Value.ToString()
        frmUpdateInventory.txtPurchaseUnit.Text = selectedRow.Cells(4).Value.ToString()
        frmUpdateInventory.txtReorderAmount.Text = selectedRow.Cells(5).Value.ToString()
        frmUpdateInventory.txtInventoryCount.Text = selectedRow.Cells(6).Value.ToString()

        ' Alter the properties of certain controls
        frmUpdateInventory.txtUnitCost.Enabled = False
        frmUpdateInventory.txtPurchaseUnit.Enabled = False
        frmUpdateInventory.txtReorderAmount.Enabled = False
        frmUpdateInventory.btnAdd.Visible = False

        ' Close the form and display the UpdateInventory form
        Me.Close()
        frmUpdateInventory.Show()
    End Sub
End Class