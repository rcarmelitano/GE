Imports System.Data
Imports System.Data.SqlClient
Public Class NewCampType
    Dim CampTypeConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Function getNewID(idname As String, table As String) As Integer
        'Figure out the id of the next campaign
        Dim newID As Integer = 0
        Dim getIDSQL As New SqlCommand("select max(" + idname + ") + 1 from " + table, CampTypeConnection)
        ' Open conn, execute, close conn, return value
        CampTypeConnection.Open()
        newID = getIDSQL.ExecuteScalar()
        CampTypeConnection.Close()
        Return newID
    End Function
    Sub checkConnection()
        'Check if the connection is open and if it is close it
        If CampTypeConnection.State Then
            CampTypeConnection.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkConnection()
        'Get new id
        Dim campID As Integer = getNewID("campaignTypeID", "Campaign_Types")
        'set up insert
        Dim addCampaignType As New SqlCommand("INSERT INTO Campaign_Types (campaignTypeID,title)
                                                                        VALUES(@campaignTypeID,@title)", CampTypeConnection)

        addCampaignType.Parameters.AddWithValue("@campaignTypeID", campID)
        addCampaignType.Parameters.AddWithValue("@title", txtCampTypeName.Text)
        ' Open the connection and run the query
        Try
            CampTypeConnection.Open()
            addCampaignType.ExecuteNonQuery()
            CampTypeConnection.Close()
            MessageBox.Show("New campaign type " + txtCampTypeName.Text + " added successfully.")
            'Clear forms
            txtCampTypeName.Text = ""
        Catch ex As Exception
            MessageBox.Show("Invalid Input")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Exit
        Me.Close()
    End Sub
End Class