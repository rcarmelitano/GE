Imports System.Data
Imports System.Data.SqlClient

Public Class MarketingCampaigns
    'Improve this form by modularizing the addition of a campaign, and add error validation
    'Connect to the DB
    Dim CampConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        'Exit
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub ViewCampaignsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCampaignsToolStripMenuItem.Click
        'Open up campaigns view
        CampaignsView.Show()
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddPromotion.Click
        If MessageBox.Show("          The Marketing Campaign has been created" & vbCrLf & "    Do you want to create another?", "Return",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
            'close connection
            CampConnection.Close()
            'Add values 
            Dim addCampaign As New SqlCommand("INSERT INTO Marketing_Campaigns (campaignID,campaignTypeID,title,description,startDate,endDate)
                                                                        VALUES(@campaignID,@campaignTypeID,@title,@description,@startDate,@endDate)", CampConnection)
            addCampaign.Parameters.AddWithValue("@campaignID", txtCampaignID.Text)
            addCampaign.Parameters.AddWithValue("@campaignTypeID", comboCampType.SelectedValue)
            addCampaign.Parameters.AddWithValue("@title", txtCampaignName.Text)
            addCampaign.Parameters.AddWithValue("@description", txtDescription.Text)
            addCampaign.Parameters.AddWithValue("@startDate", startDatePicker.Text)
            addCampaign.Parameters.AddWithValue("@endDate", endDatePicker.Text)

            ' Open the connection and run the query

            CampConnection.Open()
            addCampaign.ExecuteNonQuery()

            'Exit
            Me.Close()
            frmPrimaryForm.Show()
        Else
            'close connection
            CampConnection.Close()
            'Add values 
            Dim addCampaign As New SqlCommand("INSERT INTO Marketing_Campaigns (campaignID,campaignTypeID,title,description,startDate,endDate)
                                                                        VALUES(@campaignID,@campaignTypeID,@title,@description,@startDate,@endDate)", CampConnection)
            addCampaign.Parameters.AddWithValue("@campaignID", txtCampaignID.Text)
            addCampaign.Parameters.AddWithValue("@campaignTypeID", comboCampType.SelectedValue)
            addCampaign.Parameters.AddWithValue("@title", txtCampaignName.Text)
            addCampaign.Parameters.AddWithValue("@description", txtDescription.Text)
            addCampaign.Parameters.AddWithValue("@startDate", startDatePicker.Text)
            addCampaign.Parameters.AddWithValue("@endDate", endDatePicker.Text)
            CampConnection.Open()
            addCampaign.ExecuteNonQuery()
            'Clear forms
            txtCampaignID.Text = ""
            txtCampaignName.Text = ""
            txtDescription.Text = ""
            'Figure out new campaign ID 
            'Figure out the id of the next campaign
            Dim campaignID As Integer = 0
            Dim getCampaignID As New SqlCommand("select max(campaignID) + 1 from Marketing_Campaigns", CampConnection)
            'Figure out the new campaign id
            campaignID = getCampaignID.ExecuteScalar()
            txtCampaignID.Text = campaignID
        End If


    End Sub

    Private Sub MarketingCampaigns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Campaign_Types' table. You can move, or remove it, as needed.
        Me.Campaign_TypesTableAdapter.Fill(Me.GEDataSet.Campaign_Types)

        ' Convert date picker format 
        startDatePicker.Format = DateTimePickerFormat.Custom
        startDatePicker.CustomFormat = "MM/dd/yyyy"
        endDatePicker.Format = DateTimePickerFormat.Custom
        endDatePicker.CustomFormat = " MM/dd/yyyy"

        'Start and end date should not be before today 
        startDatePicker.MinDate = DateAndTime.Now()
        endDatePicker.MinDate = DateAndTime.Now()

        'Figure out the id of the next campaign
        Dim campaignID As Integer = 0
        Dim getCampaignID As New SqlCommand("select max(campaignID) + 1 from Marketing_Campaigns", CampConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        CampConnection.Open()
        Dim rowsAffected As Integer = getCampaignID.ExecuteNonQuery()
        campaignID = getCampaignID.ExecuteScalar()
        ' Display the new ID
        txtCampaignID.Text = campaignID

    End Sub

End Class