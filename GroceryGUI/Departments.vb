Public Class frmDepartments
    Private Sub Departments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        'Disables the control box
        Me.ControlBox = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and display the Categories and Departments menu
        frmCategoriesAndDepartments.Show()
        Me.Close()
    End Sub

    Private Sub mnuNewDepartments_Click(sender As Object, e As EventArgs) Handles mnuNewDepartments.Click
        'Shows the 'addDepartment' form, while closing the current one
        frmAddDepartment.Show()
        Me.Close()
    End Sub

    Private Sub dgvDepartments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDepartments.CellContentClick
        'Checks to see if the user is clicking on the correct cell
        If e.ColumnIndex <> 2 Then
            Exit Sub
        End If


        Dim selectedrow As DataGridViewRow
        selectedrow = dgvDepartments.Rows(e.RowIndex)
        frmAddDepartment.txtDepartmentID.Text = selectedrow.Cells(0).Value.ToString()
        frmAddDepartment.txtDepartmentName.Text = selectedrow.Cells(1).Value.ToString()

        'Control property changes
        frmAddDepartment.txtDepartmentID.Enabled = False
        frmAddDepartment.txtDepartmentID.ReadOnly = True

        frmAddDepartment.txtDepartmentName.Enabled = False
        frmAddDepartment.txtDepartmentName.ReadOnly = True

        frmAddDepartment.btnCreateDepartment.Enabled = False
        frmAddDepartment.btnCreateDepartment.Visible = False

        frmAddDepartment.btnUpdate.Visible = True
        frmAddDepartment.mnuUpdate.Visible = True
        frmAddDepartment.Show()
        Me.Close()

    End Sub
End Class