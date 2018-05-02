Public Class supplierhistory
    Dim intid As Integer




    Public Sub LoadDataGrid(ByVal id As Integer)
        intid = id
        Me.Purchase_OrderTableAdapter.PurchaseHistory(Me.GEDataSet.Purchase_Order, id)
    End Sub


    Private Sub Purchase_OrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Purchase_OrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Purchase_OrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)
    End Sub

    Public Sub loadDetails(ByVal ID As Integer)
        Intid = ID
        Me.Purchase_OrderTableAdapter.PurchaseHistory(Me.GEDataSet.Purchase_Order, ID)
    End Sub

    Private Sub Purchase_OrderDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Purchase_OrderDataGridView.CellContentClick
        If e.ColumnIndex <> 7 Then
            Exit Sub
        End If
        supplierHisoryInfo.Show()
        Me.Hide()

        Try
            ' supplierHisoryInfo.

            '  (Purchase_OrderDataGridView.Rows(e.RowIndex).Cells(0).value)

        Catch ex As Exception

        End Try
    End Sub
    '------------------------------------------------------------------------------------------filter by date
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Purchase_OrderTableAdapter.datefilter(Me.GEDataSet.Purchase_Order, DateTimePicker1.Value, DateTimePicker2.Value, intid)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Me.Purchase_OrderTableAdapter.PurchaseHistory(Me.GEDataSet.Purchase_Order, intid)
    End Sub
End Class