Public Class frmCategories
    Private Sub ClsoeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClsoeToolStripMenuItem.Click
        ' Close the form and display the Categories and Departments menu
        frmCategoriesAndDepartments.Show()
        Me.Close()
    End Sub

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)
        Me.ControlBox = False
    End Sub

    Private Sub mnuNewCategory_Click(sender As Object, e As EventArgs) Handles mnuNewCategory.Click
        frmAddCategories.Show()
        Me.Hide()
    End Sub

    Private Sub dgvCategories_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellContentClick
        If e.ColumnIndex <> 3 Then
            Exit Sub
        End If

        Dim selectedrow As DataGridViewRow
        selectedrow = dgvCategories.Rows(e.RowIndex)
        frmAddCategories.txtCategoryID.Text = selectedrow.Cells(0).Value.ToString()
        frmAddCategories.txtDepartmentID.Text = selectedrow.Cells(1).Value.ToString()
        frmAddCategories.txtCategoryName.Text = selectedrow.Cells(2).Value.ToString()

        'Control property changes
        frmAddCategories.txtCategoryID.Enabled = False
        frmAddCategories.txtCategoryID.ReadOnly = True

        frmAddCategories.txtDepartmentID.Enabled = False
        frmAddCategories.txtDepartmentID.ReadOnly = True

        frmAddCategories.txtCategoryName.Enabled = False
        frmAddCategories.txtCategoryName.ReadOnly = True

        frmAddCategories.btnCreateCategory.Enabled = False
        frmAddCategories.btnCreateCategory.Visible = False

        frmAddCategories.btnUpdateCategory.Visible = True
        frmAddCategories.mnuUpdate.Visible = True
        frmAddCategories.Show()
        Me.Close()
    End Sub
End Class