' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmUpdateGiftCard

    ' Create a new connection to the database for this form
    Dim giftCardConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    ' Public variable to increase the passed in minimum and later increment them
    Public newMinimum As Integer

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        If MessageBox.Show("Are you sure you want to cancel?", "Gift Card Refill Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            frmGiftCards.Show()
        End If
    End Sub

    Private Sub btnRefillGiftCard_Click(sender As Object, e As EventArgs) Handles btnRefillGiftCard.Click
        If MessageBox.Show("Are you sure you want to save your changes?", "Gift Card Refill",
        MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim addProduct As New SqlCommand("UPDATE Gift_Cards SET giftCardID = @giftCardID, customerID = @customerID,
                                            dateOfPurchase = @dateOfPurchase, cardTotal = @cardTotal where giftCardID = @giftCardID", giftCardConnection)

            addProduct.Parameters.AddWithValue("@giftCardID", txtGiftCardID.Text)
            addProduct.Parameters.AddWithValue("@customerID", txtCustomerID.Text)
            addProduct.Parameters.AddWithValue("@dateOfPurchase", dtpDateOfPurchase.Text)
            addProduct.Parameters.AddWithValue("@cardTotal", nudCardTotal.Text)

            ' Open the connection to the database and pass in the information
            giftCardConnection.Open()
            addProduct.ExecuteNonQuery()

            ' Close the connection
            giftCardConnection.Close()

            ' Display a message to the user, close the form, and reopen the gift cards form
            MessageBox.Show("The gift card has been refilled.")
            Me.Close()
            frmGiftCards.Show()
        End If
    End Sub

    Private Sub frmUpdateGiftCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Disable the form controls
        Me.ControlBox = False

        ' Converts the date and time of the datetimepicker to a usable string format
        dtpDateOfPurchase.Format = DateTimePickerFormat.Custom
        dtpDateOfPurchase.CustomFormat = "MM/dd/yyyy"

        'Calculate the minimum and output it
        txtCurrentTotal.Text = newMinimum
        newMinimum += 5
        nudCardTotal.Minimum = newMinimum
    End Sub
End Class