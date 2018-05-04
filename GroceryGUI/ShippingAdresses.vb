Imports System.Data
Imports System.Data.SqlClient


Public Class ShippingAdresses
    Dim ID As Integer
    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub Shipping_AddressesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Shipping_AddressesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Private Sub ShippingAdresses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ID = frmUpdateCustomer.CustomerIDTextBox.Text
        Me.ControlBox = False
        Me.Shipping_AddressesTableAdapter.CustomerAddress(Me.GEDataSet.Shipping_Addresses, frmUpdateCustomer.CustomerIDTextBox.Text)
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        frmNewShipping.ShowDialog()
    End Sub
End Class