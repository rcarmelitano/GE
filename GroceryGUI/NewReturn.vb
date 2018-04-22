' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmNewReturn

    ' Create a new connection to the database for this form
    Dim returnsConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    ' Make value to hold the max quantity
    Dim quantityMax As Integer = 0


    Private Sub btnFinalizeReturn_Click(sender As Object, e As EventArgs) Handles btnFinalizeReturn.Click

        If nudQuantity.Text <= quantityMax And txtOrderDetailID.Text <> String.Empty And txtReason.Text <> String.Empty Then
            ' Show a message to the user
            If MessageBox.Show("          Your return has been finalized." & vbCrLf & "    Do you want to make another return?", "Return",
                           MessageBoxButtons.YesNo) = DialogResult.No Then

                returnsConnection.Close()

                ' Add the new return and set the values entered to the attributes of the returns table
                Dim addReturn As New SqlCommand("INSERT INTO [Returns] (ReturnId, orderDetailID, reason, quantity, returnDate)
                                                VALUES(@ReturnId, @orderDetailID, @reason, @quantity, @returnDate)", returnsConnection)

                addReturn.Parameters.AddWithValue("@ReturnId", txtReturnID.Text)
                addReturn.Parameters.AddWithValue("@orderDetailID", txtOrderDetailID.Text)
                addReturn.Parameters.AddWithValue("@reason", txtReason.Text)
                addReturn.Parameters.AddWithValue("@quantity", nudQuantity.Text)
                addReturn.Parameters.AddWithValue("@returnDate", txtReturnDate.Text)

                returnsConnection.Open()
                Dim rowsAffected As Integer = addReturn.ExecuteNonQuery()

                ' Close the form and display the primary form
                Me.Close()
                frmPrimaryForm.Show()
            Else
                ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
                returnsConnection.Close()

                ' Increment the Return ID and prepare for a new return--------------
                ' Get the max id number currently in the database and then add 1
                Dim returnID As Integer = 0
                Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(ReturnId) + 1 from Returns", returnsConnection)

                returnsConnection.Open()
                Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
                returnID = getMaxReturnIDAndIncrement.ExecuteScalar()

                ' Display the new ID
                txtReturnID.Text = returnID


                ' Add the new return and set the values entered to the attributes of the returns table
                Dim addReturn As New SqlCommand("INSERT INTO [Returns] (ReturnId, orderDetailID, reason, quantity, returnDate)
                                                VALUES(@ReturnId, @orderDetailID, @reason, @quantity, @returnDate)", returnsConnection)

                addReturn.Parameters.AddWithValue("@ReturnId", txtReturnID.Text)
                addReturn.Parameters.AddWithValue("@orderDetailID", txtOrderDetailID.Text)
                addReturn.Parameters.AddWithValue("@reason", txtReason.Text)
                addReturn.Parameters.AddWithValue("@quantity", nudQuantity.Text)
                addReturn.Parameters.AddWithValue("@returnDate", txtReturnDate.Text)

                rowsAffected = addReturn.ExecuteNonQuery()
            End If
        Else
            ' Output a message to the user
            MessageBox.Show("You have entered an invalid quantity, please try again.")
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the current form and display the primaryForm
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub frmNewReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Returns' table. You can move, or remove it, as needed.
        Me.ReturnsTableAdapter.Fill(Me.GEDataSet.Returns)
        'TODO: This line of code loads data into the 'GEDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.GEDataSet.Order_Details)


        ' Get the max id number currently in the database and then add 1
        Dim returnID As Integer = 0
        Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(ReturnId) + 1 from Returns", returnsConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        returnsConnection.Open()
        Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
        returnID = getMaxReturnIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtReturnID.Text = returnID

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
            txtOrderDetailID.Text = dgvOrderDetails.Item(0, dgvOrderDetails.CurrentCell.Value - 1).Value

            ' Display the quantiy of the selected order detail in txtQuantity
            nudQuantity.Text = dgvOrderDetails.Item(2, dgvOrderDetails.CurrentCell.Value - 1).Value

            ' Convert the string to an int
            Integer.TryParse(nudQuantity.Text, quantityMax)
        Catch
            MessageBox.Show("You can only add a Customer ID." & vbCrLf & "Click an ID from the list and press the ""Add"" button to add it to the textbox.")

            ' Clear the quantity and order details id textbox
            nudQuantity.Text = String.Empty
            txtOrderDetailID.Clear()
        End Try
    End Sub

    ' Reset the quantity to 0 if the user attempts to remove it completely
    Private Sub nudQuantity_TextChanged(sender As Object, e As EventArgs) Handles nudQuantity.TextChanged
        If nudQuantity.Text.Length = 0 Then
            nudQuantity.Text = "0"
        End If
    End Sub
End Class