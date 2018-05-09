Public Class supplierhistory
    Dim intid As Integer


    Public Sub LoadDataGrid(ByVal id As Integer)
        intid = id
        Me.Purchase_OrderTableAdapter.PurchaseHistory(Me.GEDataSet.Purchase_Order, id)
    End Sub

    '--------------------------------------------------------------------------------------------------validation
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
        If e.ColumnIndex <> 5 Then
            Exit Sub
        End If

        Try
            supplierHisoryInfo.loadDetails(Purchase_OrderDataGridView.Rows(e.RowIndex).Cells(0).Value)
            supplierHisoryInfo.Show()
        Catch ex As Exception

        End Try


    End Sub
    '------------------------------------------------------------------------------------------filter by date

    Private Sub supplierhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub
End Class