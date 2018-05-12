Imports System.Data
Imports System.Data.SqlClient
Public Class Marketing
    Dim MarketingConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Dim BOGO As Integer = 1
    Dim FlatRateOrder As Integer = 2
    Dim PercentageOrder As Integer = 3
    Dim FlatRateItem As Integer = 4
    Dim PercentageItem As Integer = 5
    Function getCampaignID() As Integer
        'Figure out the id of the next campaign
        Dim campaignID As Integer = 0
        Dim getCampaignIDSQL As New SqlCommand("select max(campaignID) + 1 from Marketing_Campaigns", MarketingConnection)
        ' Open conn, execute, close conn, return value
        MarketingConnection.Open()
        campaignID = getCampaignIDSQL.ExecuteScalar()
        MarketingConnection.Close()
        Return campaignID
    End Function
    Function getPromotionID() As Integer
        'Figure out the ID of the next promoion
        Dim promoID As Integer = 0
        Dim getPromoIDSQL As New SqlCommand("select max(promotionID) + 1 from Promotions", MarketingConnection)
        'Open conn, execute, close conn, return value
        MarketingConnection.Open()
        promoID = getPromoIDSQL.ExecuteScalar()
        MarketingConnection.Close()
        Return promoID
    End Function
    Function getDiscountID() As Integer
        'Figure out the ID of the new discount
        Dim disId As Integer = 0
        Dim getDiscountIDSQL As New SqlCommand("select max(discountID) + 1 from Discounts", MarketingConnection)
        'Open conn, execute close conn, return value
        MarketingConnection.Open()
        disId = getDiscountIDSQL.ExecuteScalar()
        MarketingConnection.Close()
        Return disId
    End Function
    Sub checkConnection()
        'Check if the connection is open and if it is close it
        If MarketingConnection.State Then
            MarketingConnection.Close()
        End If
    End Sub


    Private Sub Promotionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discount_Type' table. You can move, or remove it, as needed.
        Me.Discount_TypeTableAdapter.Fill(Me.GEDataSet.Discount_Type)
        Me.Campaign_TypesTableAdapter.Fill(Me.GEDataSet.Campaign_Types)
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)
        Me.Marketing_CampaignsTableAdapter.Fill(Me.GEDataSet.Marketing_Campaigns)

        ' Convert date picker format 
        campSDatePicker.Format = DateTimePickerFormat.Custom
        campSDatePicker.CustomFormat = "MM/dd/yyyy"
        campEDatePicker.Format = DateTimePickerFormat.Custom
        campEDatePicker.CustomFormat = "MM/dd/yyyy"
        promoEDate.Format = DateTimePickerFormat.Custom
        promoEDate.CustomFormat = "MM/dd/yyyy"
        promoSDate.Format = DateTimePickerFormat.Custom
        promoSDate.CustomFormat = "MM/dd/yyyy"
        'Start and end date should not be before today 
        campSDatePicker.MinDate = DateAndTime.Now()
        campEDatePicker.MinDate = DateAndTime.Now()


    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddCamp.Click
        checkConnection()
        'Get ID of new campaign
        Dim campID As Integer = getCampaignID()
        'Set up query to pass it into the DB
        Dim addCampaign As New SqlCommand("INSERT INTO Marketing_Campaigns (campaignID,campaignTypeID,title,description,startDate,endDate)
                                                                        VALUES(@campaignID,@campaignTypeID,@title,@description,@startDate,@endDate)", MarketingConnection)
        addCampaign.Parameters.AddWithValue("@campaignID", campID)
        addCampaign.Parameters.AddWithValue("@campaignTypeID", comboCampType.SelectedValue)
        addCampaign.Parameters.AddWithValue("@title", txtCampaignName.Text)
        addCampaign.Parameters.AddWithValue("@description", txtCampDescription.Text)
        addCampaign.Parameters.AddWithValue("@startDate", campSDatePicker.Text)
        addCampaign.Parameters.AddWithValue("@endDate", campEDatePicker.Text)

        ' Open the connection and run the query
        Try
            MarketingConnection.Open()
            addCampaign.ExecuteNonQuery()
            Me.Campaign_TypesTableAdapter.Fill(Me.GEDataSet.Campaign_Types)
            Me.Marketing_CampaignsTableAdapter.Fill(Me.GEDataSet.Marketing_Campaigns)
            MarketingConnection.Close()
            'Clear forms
            txtCampaignName.Text = ""
            txtCampDescription.Text = ""
            campSDatePicker.ResetText()
            campEDatePicker.ResetText()
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try

    End Sub

    Private Sub btnAddPromotion_Click_1(sender As Object, e As EventArgs) Handles btnAddPromotion.Click
        checkConnection()
        'Get the id of the new promotion
        Dim promoID As Integer = getPromotionID()
        'Get campaign ID if they want one or set null 
        Dim selectedCampID As Integer = 0
        If (chkCampAssociation.Checked) Then
            selectedCampID = cmbCampPicker.SelectedValue
        ElseIf (chkCampAssociation.Checked = False) Then
            selectedCampID = 0
        End If
        'Set up query to pass in new promo
        Dim addPromo As New SqlCommand("INSERT INTO Promotions (promotionID,campaignID,title,description,startDate,endDate)
                                                                        VALUES(@promotionID,@campaignID,@title,@description,@startDate,@endDate)", MarketingConnection)
        addPromo.Parameters.AddWithValue("@promotionID", promoID)
        addPromo.Parameters.AddWithValue("@campaignID", selectedCampID)
        addPromo.Parameters.AddWithValue("@title", txtPromotionName.Text)
        addPromo.Parameters.AddWithValue("@description", txtPromoDesc.Text)
        addPromo.Parameters.AddWithValue("@startDate", promoSDate.Text)
        addPromo.Parameters.AddWithValue("@endDate", promoEDate.Text)

        'Open the connection and try to run the query
        Try
            MarketingConnection.Open()
            addPromo.ExecuteNonQuery()
            Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)
            MarketingConnection.Close()
            'Clear
            txtPromotionName.Text = ""
            txtPromoDesc.Text = ""
            promoEDate.ResetText()
            promoSDate.ResetText()
            chkCampAssociation.Checked = False
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub

    Private Sub chkCampAssociation_CheckedChanged(sender As Object, e As EventArgs) Handles chkCampAssociation.CheckedChanged
        'Enables or disables the campaign chooser
        If chkCampAssociation.Checked Then
            cmbCampPicker.Enabled = True
        Else
            cmbCampPicker.Enabled = False
        End If
    End Sub

    Private Sub cmbDiscountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDiscountType.SelectedIndexChanged
        'Sets up the discount tab according to the discount type selected in cmbDiscountType
        If ((cmbDiscountType.SelectedValue = FlatRateOrder) Or (cmbDiscountType.SelectedValue = FlatRateItem)) Then
            txtFlatDiscount.Show()
            lblFlatDiscount.Show()
            txtPercentage.Hide()
            lblPercentageDiscount.Hide()
            txtBuyOne.Hide()
            lblBuyOne.Hide()
            txtGetOne.Hide()
            lblGetOne.Hide()
        ElseIf ((cmbDiscountType.SelectedValue = PercentageOrder) Or (cmbDiscountType.SelectedValue = PercentageItem)) Then
            MessageBox.Show("When creating a percent off discount please input a number representing the percent. For example for 10.5% enter 10.5")
            txtFlatDiscount.Hide()
            lblFlatDiscount.Hide()
            txtBuyOne.Hide()
            lblBuyOne.Hide()
            txtGetOne.Hide()
            lblGetOne.Hide()
            txtPercentage.Show()
            lblPercentageDiscount.Show()
        ElseIf (cmbDiscountType.SelectedValue = BOGO) Then
            txtFlatDiscount.Hide()
            lblFlatDiscount.Hide()
            txtPercentage.Hide()
            lblPercentageDiscount.Hide()
            txtBuyOne.Show()
            lblBuyOne.Show()
            txtGetOne.Show()
            lblGetOne.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkConnection()
        Dim discountID As Integer = getDiscountID()

        'Pass in appropraite amount value 
        Dim discountAmount As Integer = 0

        'Whole number for flat rate
        If ((cmbDiscountType.SelectedValue = FlatRateOrder) Or (cmbDiscountType.SelectedValue = FlatRateItem)) Then
            discountAmount = txtFlatDiscount.Text
            'Decimals for percent, have them enter whole numbers for usability
        ElseIf ((cmbDiscountType.SelectedValue = PercentageOrder) Or (cmbDiscountType.SelectedValue = PercentageItem)) Then
            Try
                discountAmount = CDec(Val(txtPercentage.Text) / 100)
            Catch ex As Exception
                MessageBox.Show("When creating a percent off discount please input a number representing the percent. For example for 10.5% enter 10.5")
            End Try
        ElseIf (cmbDiscountType.SelectedValue = BOGO) Then
            'Amount is always 0 for BOGO
            discountAmount = 0
        End If

        'Set up command for passing values into DB
        Dim addDiscount As New SqlCommand("INSERT INTO Discounts (discountID,discountTypeID,buyOne,getOne,discountAmount,promotionID)
                                                                        VALUES(@discountID,@discountTypeID,@buyOne,@getOne,@discountAmount,@promotionID)", MarketingConnection)

        addDiscount.Parameters.AddWithValue("@discountID", discountID)
        addDiscount.Parameters.AddWithValue("@discountTypeID", cmbDiscountType.SelectedValue)
        addDiscount.Parameters.AddWithValue("@buyOne", txtBuyOne.Text)
        addDiscount.Parameters.AddWithValue("@getOne", txtGetOne.Text)
        addDiscount.Parameters.AddWithValue("@discountAmount", discountAmount)
        addDiscount.Parameters.AddWithValue("@promotionID", cmbPromo.SelectedValue)

        'Open the connection and try to run the query
        Try
            MarketingConnection.Open()
            addDiscount.ExecuteNonQuery()
            Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
            MarketingConnection.Close()
            'Clear
            txtBuyOne.Text = ""
            txtGetOne.Text = ""
            txtFlatDiscount.Text = ""
            txtPercentage.Text = ""
            promoEDate.ResetText()
            promoSDate.ResetText()
            chkCampAssociation.Checked = False
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub
End Class