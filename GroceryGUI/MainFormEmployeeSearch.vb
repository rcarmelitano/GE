Public Class MainFormEmployeeSearch
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Private Sub MainFormEmployeeSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.GEDataSet.Employees)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------------------------------------set the id number of the employee working
    Private Sub EmployeesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeesDataGridView.CellContentClick
        If e.ColumnIndex <> 3 Then
            Exit Sub
        End If

        Dim V As String = EmployeesDataGridView.Rows(e.RowIndex).Cells(0).Value
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = EmployeesDataGridView.Rows(index)
        trying = selectedrow.Cells(0).Value.ToString()
        frmPrimaryForm.TextBox1.Text = trying
        frmPrimaryForm.TextBox1.ReadOnly = True
        frmPrimaryForm.TextBox1.Enabled = False
        MessageBox.Show("Employee " + trying + " selected")
        employeeID = trying
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Display the primary home form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub
End Class