Public Class frmNewProduct
    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)

    End Sub

    ' Performs a search for category ID
    Private Sub btnSearchCategoryID_Click(sender As Object, e As EventArgs) Handles btnSearchCategoryID.Click
        Try
            Me.CategoriesTableAdapter.categoryID(Me.GEDataSet.Categories, CType(txtCategoryID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Performs a search for Department ID
    Private Sub btnSearchDepartmentID_Click(sender As Object, e As EventArgs) Handles btnSearchDepartmentID.Click
        Try
            Me.DepartmentsTableAdapter.departmentID(Me.GEDataSet.Departments, CType(txtDepartmentID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class