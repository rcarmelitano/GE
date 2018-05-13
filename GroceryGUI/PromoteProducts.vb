Imports System.Data
Imports System.Data.SqlClient
Public Class PromoteProducts
    Dim PProdConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Function getNewID(idname As String, table As String) As Integer
        'Figure out the id of the next campaign
        Dim newID As Integer = 0
        Dim getIDSQL As New SqlCommand("select max(" + idname + ") + 1 from " + table, PProdConnection)
        ' Open conn, execute, close conn, return value
        PProdConnection.Open()
        newID = getIDSQL.ExecuteScalar()
        PProdConnection.Close()
        Return newID
    End Function
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
End Class