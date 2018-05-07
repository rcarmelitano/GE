Public Class frmNewShrinkage
    Private Sub frmNewShrinkage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Shippers' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GEDataSet.Inventory)
    End Sub
End Class