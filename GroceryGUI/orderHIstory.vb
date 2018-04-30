Public Class frmorderHIstory


    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Public Sub loadDetails(ByVal orderID As Integer)
        Me.Order_DetailsTableAdapter.orderHistory(Me.GEDataSet.Order_Details, orderID)
    End Sub


    Private Sub orderHIstory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.GEDataSet.Order_Details)
    End Sub
End Class

