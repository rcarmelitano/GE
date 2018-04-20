Public Class frmSuppliers
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        'TODO: This line of code loads data into the 'GEDataSet.Shippers' table. You can move, or remove it, as needed.
        Me.ShippersTableAdapter.Fill(Me.GEDataSet.Shippers)







    End Sub

    Private Sub dgvSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellContentClick



        If e.ColumnIndex <> 13 Then
            Exit Sub
        End If
        NewSupplier.Show()

    End Sub
End Class