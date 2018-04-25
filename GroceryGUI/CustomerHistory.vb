Imports System.Data
Imports System.Data.SqlClient



Public Class frmCustomerHistory

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Dim intid As Integer

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
        intid = id
        Me.OrdersTableAdapter.CustomerHistory(Me.GEDataSet.Orders, id)
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Me.OrdersTableAdapter.orderhistoryfilter(Me.GEDataSet.Orders, DPdate1.Value, DPdate2.Value, intid)
    End Sub
End Class
