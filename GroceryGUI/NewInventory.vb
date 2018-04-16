Public Class frmNewInventory
    Private Sub frmNewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)

    End Sub
End Class