' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmNewGiftCard

    ' Create a new connection to the database for this form
    Dim giftCardConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub ViewGiftCardsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewGiftCardsToolStripMenuItem.Click
        ' Display the gift cards view form
        frmGiftCardsView.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel making a gift card?", "Gift Card Close",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            frmGiftCards.Show()
        End If
    End Sub

    Private Sub frmGiftCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.GEDataSet.Customers)

        ' Disable the control form buttons
        Me.ControlBox = False

        ' Converts the date and time of the datetimepicker to a usable string format
        dtpDateOfPurchase.Format = DateTimePickerFormat.Custom
        dtpDateOfPurchase.CustomFormat = "MM/dd/yyyy"

        ' Do not let the date be before the current date
        dtpDateOfPurchase.MinDate = Date.Now()
        dtpDateOfPurchase.MaxDate = Date.Now()


        ' Get the max id number currently in the database and then add 1
        Dim giftCardID As Int64 = 0
        Dim getMaxgiftCardIDAndIncrement As New SqlCommand("select max(giftCardID) + 1 from Gift_Cards", giftCardConnection)

        ' Fill the giftCardID textbox with the next value through the use of the getMaxgiftCardIDAndIncrement command above
        giftCardConnection.Open()
        getMaxgiftCardIDAndIncrement.ExecuteNonQuery()
        giftCardID = getMaxgiftCardIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtGiftCardID.Text = giftCardID

        ' Close the connection
        giftCardConnection.Close()

    End Sub

    Private Sub btnActivateGiftCard_Click(sender As Object, e As EventArgs) Handles btnActivateGiftCard.Click
        If txtCustomerID.Text <> String.Empty And nudCardTotal.Text Then

            ' Show a message to the user
            MessageBox.Show("The gift card has been created.", "Gift Card")

            ' Add the new return and set the values entered to the attributes of the returns table
            Dim addGiftCard As New SqlCommand("INSERT INTO Gift_Cards (giftCardID, customerID, dateOfPurchase, cardTotal)
                                                VALUES(@giftCardID, @customerID, @dateOfPurchase, @cardTotal)", giftCardConnection)

            addGiftCard.Parameters.AddWithValue("@giftCardID", txtGiftCardID.Text)
            addGiftCard.Parameters.AddWithValue("@customerID", txtCustomerID.Text)
            addGiftCard.Parameters.AddWithValue("@dateOfPurchase", dtpDateOfPurchase.Text)
            addGiftCard.Parameters.AddWithValue("@cardTotal", nudCardTotal.Text)

            ' Open the connection and run the query
            giftCardConnection.Open()
            addGiftCard.ExecuteNonQuery()

            giftCardConnection.Close()

            ' Close the form and display the primary form
            Me.Close()
            frmGiftCards.Show()
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        ' Display a message to the user
        MessageBox.Show("You are able to create a gift card from here, and assign that gift card to a customer of choice, using the grid below.")
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        ' Exit the click event if the user does not click the Add button (column index 3)
        If e.ColumnIndex <> 3 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvCustomers.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtCustomerID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.CustomersTableAdapter.customerName(Me.GEDataSet.Customers, txtCustomerName.Text)
        Catch
            MessageBox.Show("You can only search for a valid last name. Please try again.")
        End Try
    End Sub
End Class