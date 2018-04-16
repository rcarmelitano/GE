Public Class frmProducts
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

    End Sub

    Private Sub NewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProductToolStripMenuItem.Click
        ' Close the current form and display the new product form
        Me.Close()
        frmNewProduct.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the current form
        Me.Close()
    End Sub
End Class