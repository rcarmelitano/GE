Public Class supplierHisoryInfo
    Private Sub Purchase_Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.Purchase_Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Private Sub supplierHisoryInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Purchase_Order_Details' table. You can move, or remove it, as needed.
        Me.Purchase_Order_DetailsTableAdapter.Fill(Me.GEDataSet.Purchase_Order_Details)

    End Sub
End Class