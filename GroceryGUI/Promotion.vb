Imports System.Data
Imports System.Data.SqlClient

Public Class frmPromotion
    'Improve this form by modularizing the addition of a campaign, and add error validation
    'Figure out how to associate promotiosn with products and campaigns
    'Connect to the DB
    Dim PromoConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Ensure that the user wants to close the form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountsToolStripMenuItem.Click
        ' Hide the current form and open the discounts form
        Me.Hide()
        frmDiscounts.Show()
    End Sub

    Private Sub CouponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CouponsToolStripMenuItem.Click
        ' Hide the current form and display the coupons form
        Me.Hide()
        frmCoupons.Show()
    End Sub

    Private Sub Promotion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Promotion Close",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
        End If
    End Sub

    Private Sub ViewPromotionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPromotionsToolStripMenuItem.Click
        ' Display the promotions view form
        frmPromotionsView.Show()
    End Sub

    Private Sub frmPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.GEDataSet.Categories)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)
        ' Convert date picker format 
        startDatePicker.Format = DateTimePickerFormat.Custom
        startDatePicker.CustomFormat = "MM/dd/yyyy"
        endDatePicker.Format = DateTimePickerFormat.Custom
        endDatePicker.CustomFormat = " MM/dd/yyyy"

        'Start and end date should not be before today 
        startDatePicker.MinDate = DateAndTime.Now()
        endDatePicker.MinDate = DateAndTime.Now()
        'Figure out the id of the next promotion
        Dim promoID As Integer = 0
        Dim getPromotionID As New SqlCommand("select max(promotionID) + 1 from Promotions", PromoConnection)
        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        PromoConnection.Open()
        Dim rowsAffected As Integer = getPromotionID.ExecuteNonQuery()
        promoID = getPromotionID.ExecuteScalar()
        ' Display the new ID
        txtPromoID.Text = promoID
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddPromotion.Click
        If MessageBox.Show("          The Promotion has been created" & vbCrLf & "    Do you want to create another?", "Return",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
            'close connection
            PromoConnection.Close()
            'Add values 
            Dim addPromo As New SqlCommand("INSERT INTO Promotions (promotionID,campaignID,promoinfoID,title,description,startDate,endDate)
                                                                        VALUES(@promotionID,@campaignID,@promoInfoID,@title,@description,@startDate,@endDate)", PromoConnection)
            addPromo.Parameters.AddWithValue("@promotionID", txtPromoID.Text)
            addPromo.Parameters.AddWithValue("@campaignID", "1")
            addPromo.Parameters.AddWithValue("@promoInfoID", "1")
            addPromo.Parameters.AddWithValue("@title", txtPromotionName.Text)
            addPromo.Parameters.AddWithValue("@description", txtDescription.Text)
            addPromo.Parameters.AddWithValue("@startDate", startDatePicker.Text)
            addPromo.Parameters.AddWithValue("@endDate", endDatePicker.Text)

            ' Open the connection and run the query

            PromoConnection.Open()
            addPromo.ExecuteNonQuery()

            'Exit
            Me.Close()
            frmPrimaryForm.Show()
        Else
            'close connection
            PromoConnection.Close()
            'Add values 
            Dim addPromo As New SqlCommand("INSERT INTO Promotions (promotionID,campaignID,promoinfoID,title,description,startDate,endDate)
                                                                        VALUES(@promotionID,@campaignID,@promoInfoID,@title,@description,@startDate,@endDate)", PromoConnection)
            addPromo.Parameters.AddWithValue("@promotionID", txtPromoID.Text)
            addPromo.Parameters.AddWithValue("@campaignID", "1")
            addPromo.Parameters.AddWithValue("@promoInfoID", "1")
            addPromo.Parameters.AddWithValue("@title", txtPromotionName.Text)
            addPromo.Parameters.AddWithValue("@description", txtDescription.Text)
            addPromo.Parameters.AddWithValue("@startDate", startDatePicker.Text)
            addPromo.Parameters.AddWithValue("@endDate", endDatePicker.Text)

            ' Open the connection and run the query

            PromoConnection.Open()
            addPromo.ExecuteNonQuery()

            'Clear forms
            txtPromoID.Text = ""
            txtPromotionName.Text = ""
            txtDescription.Text = ""
            'Figure out new campaign ID 
            'Figure out the id of the next campaign
            Dim promoID As Integer = 0
            Dim getPromoID As New SqlCommand("select max(promotionID) + 1 from Promotions", PromoConnection)
            'Figure out the new campaign id
            promoID = getPromoID.ExecuteScalar()
            txtPromoID.Text = promoID
        End If

    End Sub
End Class