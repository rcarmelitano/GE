Imports System.Data
Imports System.Data.SqlClient
Public Class Marketing
    Dim MarketingConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Function getCampaignID() As Integer
        'Figure out the id of the next campaign
        Dim campaignID As Integer = 0
        Dim getCampaignIDSQL As New SqlCommand("select max(campaignID) + 1 from Marketing_Campaigns", MarketingConnection)
        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        MarketingConnection.Open()
        campaignID = getCampaignIDSQL.ExecuteScalar()
        MarketingConnection.Close()
        Return campaignID
    End Function


    Private Sub Promotionary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Campaign_TypesTableAdapter.Fill(Me.GEDataSet.Campaign_Types)
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)
        Me.Marketing_CampaignsTableAdapter.Fill(Me.GEDataSet.Marketing_Campaigns)

        ' Convert date picker format 
        campSDatePicker.Format = DateTimePickerFormat.Custom
        campSDatePicker.CustomFormat = "MM/dd/yyyy"
        campEDatePicker.Format = DateTimePickerFormat.Custom
        campEDatePicker.CustomFormat = "MM/dd/yyyy"
        'Start and end date should not be before today 
        campSDatePicker.MinDate = DateAndTime.Now()
        campEDatePicker.MinDate = DateAndTime.Now()


    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddCamp.Click
        Dim campID As Integer = getCampaignID()
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
End Class