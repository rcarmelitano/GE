﻿Public Class frmInventory
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class