Imports System.Data
Imports System.Data.SqlClient
Public Class PromoteProducts
    Dim PProdConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Sub CheckConnection()
        'Check if the connection is open and if it is close it
        If PProdConnection.State Then
            PProdConnection.Close()
        End If
    End Sub

    Sub ConfirmBox(thingsname As String)
        MessageBox.Show(thingsname + " has successfully been created!")
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()
    End Sub

    Private Sub PromoteProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

    End Sub

    Private Sub btnPromote_Click(sender As Object, e As EventArgs) Handles btnPromote.Click
        CheckConnection()
        'Set up query to pass it into the DB
        Dim addProdPromo As New SqlCommand("INSERT INTO Promoted_products (SKU,promotionID)
                                                                        VALUES(@SKU,@promotionID)", PProdConnection)
        addProdPromo.Parameters.AddWithValue("@SKU", cmbProductSel.SelectedValue)
        addProdPromo.Parameters.AddWithValue("@promotionID", cmbPromoSel.SelectedValue)


        ' Open the connection and run the query
        Try
            PProdConnection.Open()
            addProdPromo.ExecuteNonQuery()
            PProdConnection.Close()
            Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
            ConfirmBox("Association")
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        View_Promoted_Products.Show()
    End Sub
End Class