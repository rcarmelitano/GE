Public Class frmCategories
    Private Sub ClsoeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClsoeToolStripMenuItem.Click
        ' Close the form and display the Categories and Departments menu
        frmCategoriesAndDepartments.Show()
        Me.Close()
    End Sub

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)

    End Sub

    Private Sub mnuNewCategory_Click(sender As Object, e As EventArgs) Handles mnuNewCategory.Click
        frmAddAndUpdateCategories.Show()
        Me.Hide()
    End Sub
End Class