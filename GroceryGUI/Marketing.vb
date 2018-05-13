Imports System.Data
Imports System.Data.SqlClient
Public Class Marketing
    Dim MarketingConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Dim BOGO As Integer = 1
    Dim FlatRateOrder As Integer = 2
    Dim PercentageOrder As Integer = 3
    Dim FlatRateItem As Integer = 4
    Dim PercentageItem As Integer = 5
    Function getNewID(idname As String, table As String) As Integer
        'Figure out the id of the next campaign
        Dim newID As Integer = 0
        Dim getIDSQL As New SqlCommand("select max(" + idname + ") + 1 from " + table, MarketingConnection)
        ' Open conn, execute, close conn, return value
        MarketingConnection.Open()
        newID = getIDSQL.ExecuteScalar()
        MarketingConnection.Close()
        Return newID
    End Function

    Sub CheckConnection()
        'Check if the connection is open and if it is close it
        If MarketingConnection.State Then
            MarketingConnection.Close()
        End If
    End Sub

    Sub ConfirmBox(thingsname As String)
        MessageBox.Show(thingsname + " has successfully been created!")
    End Sub

    Private Sub Marketing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Marketing Cancelation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
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
        cpnEDate.Format = DateTimePickerFormat.Custom
        cpnEDate.CustomFormat = "MM/dd/yyyy"
        cpnSDate.Format = DateTimePickerFormat.Custom
        cpnSDate.CustomFormat = "MM/dd/yyyy"
        'Start and end date should not be before today 
        campEDatePicker.MinDate = DateAndTime.Now().AddDays(1)
        campSDatePicker.MinDate = DateAndTime.Now()
        promoEDate.MinDate = DateAndTime.Now().AddDays(1)
        promoSDate.MinDate = DateAndTime.Now()
        cpnEDate.MinDate = DateAndTime.Now().AddDays(1)
        cpnSDate.MinDate = DateAndTime.Now()

    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddCamp.Click
        CheckConnection()
        'Get ID of new campaign
        Dim campID As Integer = getNewID("campaignID", "Marketing_Campaigns")
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
            ConfirmBox(txtCampaignName.Text)
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
        CheckConnection()
        'Get the id of the new promotion
        Dim promoID As Integer = getNewID("promotionID", "Promotions")
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
            ConfirmBox(txtPromotionName.Text)
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
            MessageBox.Show("When creating a percent off discount please input a decimal representing the percent off. For example 10.5% would be .150")
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
        CheckConnection()
        Dim discountID As Integer = getNewID("discountID", "Discounts")

        'Pass in appropraite amount value 
        Dim discountAmount As Decimal = 0

        'Whole number for flat rate
        If ((cmbDiscountType.SelectedValue = FlatRateOrder) Or (cmbDiscountType.SelectedValue = FlatRateItem)) Then
            discountAmount = txtFlatDiscount.Text
            'Decimals for percent
        ElseIf ((cmbDiscountType.SelectedValue = PercentageOrder) Or (cmbDiscountType.SelectedValue = PercentageItem)) Then
            discountAmount = txtPercentage.Text
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
            ConfirmBox("Discount")
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

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        'Show campaign type form
        NewCampType.Show()
    End Sub

    Private Sub btnDiscountIDSearch_Click(sender As Object, e As EventArgs) Handles btnDiscountIDSearch.Click
        ' Perform a Discount ID Search
        Try
            Me.DiscountsTableAdapter.discountID(Me.GEDataSet.Discounts, CType(txtDiscountIDSearch.Text, Integer))
        Catch ex As System.Exception
            MessageBox.Show("You can only search for a valid discount id. Please try again.")
            txtDiscountID.Clear()
            'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
            Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        End Try
    End Sub

    Private Sub btnPromotionTitleSearch_Click(sender As Object, e As EventArgs) Handles btnPromotionTitleSearch.Click
        ' Perform a search for promotion ID
        Try
            Me.PromotionsTableAdapter.searchPromotionName(Me.GEDataSet.Promotions, txtPromotionTitle.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please only enter a valid Promotion ID.")
        End Try
    End Sub

    Private Sub btnAddDiscount_Click(sender As Object, e As EventArgs)
        Try
            ' Store the discount ID in the textbox and make it read only unless the user hits the clear button, allowing for search again
            txtDiscountID.Text = dgvDiscounts.CurrentCell.Value.ToString()
        Catch
            MessageBox.Show("Please only add valid Discount ID's")
        End Try
    End Sub

    Private Sub btnAddPromotion1_Click(sender As Object, e As EventArgs) Handles btnAddCamp.Click
        Try
            ' Store the promotion ID in the textbox and make it read only unless the user hits the clear button, allowing for search again
            txtPromotionID.Text = dgvPromotions.CurrentCell.Value.ToString()
        Catch
            MessageBox.Show("Please only add valid Promotion ID's")
        End Try
    End Sub

    Private Sub dgvPromotions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromotions.CellContentClick
        If e.ColumnIndex <> 3 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvPromotions.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtPromotionID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub dgvDiscounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiscounts.CellContentClick
        If e.ColumnIndex <> 5 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvDiscounts.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtDiscountID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckConnection()
        'Get id
        Dim newCpnID As Integer = getNewID("couponID", "Coupons")

        ' Create a coupon
        Dim addCoupon As New SqlCommand("INSERT INTO Coupons (couponID, discountID, promotionID, couponStartDate, couponEndDate, description)
            VALUES(@couponID, @discountID, @promotionID, @couponStartDate, @couponEndDate, @description)", MarketingConnection)

        ' Pass in the values from the controls
        addCoupon.Parameters.AddWithValue("@couponID", newCpnID)
        addCoupon.Parameters.AddWithValue("@discountID", txtDiscountID.Text)
        addCoupon.Parameters.AddWithValue("@promotionID", txtPromotionID.Text)
        addCoupon.Parameters.AddWithValue("@couponStartDate", cpnSDate.Text)
        addCoupon.Parameters.AddWithValue("@couponEndDate", cpnEDate.Text)
        addCoupon.Parameters.AddWithValue("@description", txtCpnDescription.Text)

        'Open the connection and try to run the query
        Try
            MarketingConnection.Open()
            addCoupon.ExecuteNonQuery()
            MarketingConnection.Close()
            ConfirmBox("Coupon")
            'Clear
            txtDiscountID.Text = ""
            txtPromotionID.Text = ""
            txtCpnDescription.Text = ""
            cpnEDate.ResetText()
            cpnSDate.ResetText()
            chkCampAssociation.Checked = False
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmCouponsView.Show()
    End Sub

    Private Sub btnPromoProducts_Click(sender As Object, e As EventArgs) Handles btnPromoProducts.Click
        PromoteProducts.Show()
    End Sub

    Private Sub btnPromoteCat_Click(sender As Object, e As EventArgs) Handles btnPromoteCat.Click
        PromoteCat.Show()
    End Sub

    Private Sub btnPromoteDept_Click(sender As Object, e As EventArgs) Handles btnPromoteDept.Click
        PromoteDept.Show()
    End Sub
End Class