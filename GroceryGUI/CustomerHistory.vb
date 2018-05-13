Imports System.Data
Imports System.Data.SqlClient



Public Class frmCustomerHistory

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Dim intid As Integer

    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)
    End Sub

	'--------------------------------------------------------sub to load datagrid
	Public Sub LoadDataGrid(ByVal id As Integer)
        intid = id
        Me.OrdersTableAdapter.CustomerHistory(Me.GEDataSet.Orders, id)
	End Sub
    '------------------------------------------------------------------------------------------------------------------------
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Me.OrdersTableAdapter.orderhistoryfilter(Me.GEDataSet.Orders, DPdate1.Value, DPdate2.Value, intid)
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.OrdersTableAdapter.CustomerHistory(Me.GEDataSet.Orders, intid)
        DPdate1.ResetText()
        DPdate2.ResetText()
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub OrdersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersDataGridView.CellContentClick
		If e.ColumnIndex <> 6 Then
			Exit Sub
		End If

		Try
			frmorderHIstory.loadDetails(OrdersDataGridView.Rows(e.RowIndex).Cells(0).Value)
			frmorderHIstory.ShowDialog()
		Catch ex As Exception

		End Try



    End Sub

    Private Sub frmCustomerHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.GEDataSet.Employees)
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class
