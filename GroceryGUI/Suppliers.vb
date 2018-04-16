Public Class frmSuppliers
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        'TODO: This line of code loads data into the 'GEDataSet.Shippers' table. You can move, or remove it, as needed.
        Me.ShippersTableAdapter.Fill(Me.GEDataSet.Shippers)

    End Sub
End Class