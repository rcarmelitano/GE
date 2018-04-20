Public Class frmCustomerHistory
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Public Sub LoadDataGrid(ByVal id As Integer)
        Me.OrdersTableAdapter.CustomerHistory(Me.GEDataSet.Orders, id)
    End Sub

    Private Sub OrdersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersDataGridView.CellContentClick
        If e.ColumnIndex <> 6 Then
            Exit Sub
        End If



    End Sub
End Class