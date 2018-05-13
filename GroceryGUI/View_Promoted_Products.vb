Public Class View_Promoted_Products
    Private Sub View_Promoted_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
        'TODO: This line of code loads data into the 'GEDataSet.Promoted_Products' table. You can move, or remove it, as needed.
        Me.Promoted_ProductsTableAdapter.Fill(Me.GEDataSet.Promoted_Products)

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub
End Class