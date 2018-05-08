Imports System.Data
Imports System.Data.SqlClient

Public Class MarketingCampaigns
    'Connect to the DB
    Dim CampConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewCampaignsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCampaignsToolStripMenuItem.Click
        CampaignsView.Show()
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs) Handles btnAddPromotion.Click
        Dim addCampaign As New SqlCommand("INSERT INTO Marketing_Campaigns (campaignID, campaignTypeID, title, description, startDate, endDate)
                                                                        VALUES(@campaignID,@campaignTypeID,@title,@description,@startDate,@endDate)", CampConnection)
        addCampaign.Parameters.AddWithValue("@campaignID", campaignID.Text)
        addCampaign.Parameters.AddWithValue("@campaignTypeID", campaignTypeID.Text)
        addCampaign.Parameters.AddWithValue("@title", txtCampaignName.Text)
        addCampaign.Parameters.AddWithValue("@description", txtDescription.Text)
        addCampaign.Parameters.AddWithValue("@startDate", startDatePicker.Text)
        addCampaign.Parameters.AddWithValue("@endDate", endDatePicker.Text)

        ' Open the connection and run the query
        Try
            CampConnection.Open()
            addCampaign.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try



    End Sub

    Private Sub MarketingCampaigns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Campaign_Types' table. You can move, or remove it, as needed.
        Me.Campaign_TypesTableAdapter.Fill(Me.GEDataSet.Campaign_Types)

    End Sub

End Class