' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmNewInventory
    ' Create a new connection to the database for this form
    Dim inventoryConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub frmNewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)

        ' Get the max id number currently in the database and then add 1
        Dim inventoryID As Integer = 0
        Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(ReturnId) + 1 from Returns", inventoryConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        inventoryConnection.Open()
        Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
        inventoryID = getMaxReturnIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtInventoryID.Text = inventoryID

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Hide the current form and display the new product form
        Me.Hide()
        frmNewProduct.Show()
    End Sub

    Private Sub dgvSuppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSuppliers.CellContentClick
        If e.ColumnIndex <> 2 Then
            Exit Sub
        End If

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvSuppliers.Rows(index)

        ' Grab the selected ID and stick it in the txtSupplierID textbox
        txtSupplierID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub
End Class