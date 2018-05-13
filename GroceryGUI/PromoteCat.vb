Imports System.Data
Imports System.Data.SqlClient
Public Class PromoteCat
    Dim PCatConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Sub CheckConnection()
        'Check if the connection is open and if it is close it
        If PCatConnection.State Then
            PCatConnection.Close()
        End If
    End Sub

    Sub ConfirmBox(thingsname As String)
        MessageBox.Show(thingsname + " has successfully been created!")
    End Sub
    Private Sub PromoteCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Promoted_Departments' table. You can move, or remove it, as needed.
        Me.Promoted_DepartmentsTableAdapter.Fill(Me.GEDataSet.Promoted_Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Promoted_Categories' table. You can move, or remove it, as needed.
        Me.Promoted_CategoriesTableAdapter.Fill(Me.GEDataSet.Promoted_Categories)
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnPromote_Click(sender As Object, e As EventArgs) Handles btnPromote.Click
        CheckConnection()
        'Set up command to insert values
        Dim addPromoCat As New SqlCommand("INSERT INTO Promoted_Categories (promotionID,categoryID)
            VALUES(@promotionID,@categoryID)", PCatConnection)

        ' Pass in the values from the controls
        addPromoCat.Parameters.AddWithValue("@promotionID", cmbPromoSel.SelectedValue)
        addPromoCat.Parameters.AddWithValue("@categoryID", cmbCatSel.SelectedValue)

        'Try to execute
        Try
            PCatConnection.Open()
            addPromoCat.ExecuteNonQuery()
            PCatConnection.Close()
            ConfirmBox("Association")
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub
End Class