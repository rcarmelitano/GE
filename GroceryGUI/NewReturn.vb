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
                addReturn.Parameters.AddWithValue("@returnDate", dtpReturnDate.Text)

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
                addReturn.Parameters.AddWithValue("@returnDate", dtpReturnDate.Text)

                rowsAffected = addReturn.ExecuteNonQuery()
            End If
        Else
            ' Output a message to the user
            MessageBox.Show("All fields must be filled to make the return. Please try again.")
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the current form and display the primaryForm
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub frmNewReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Converts the date and time of the datetimepicker to a usable string format
        dtpReturnDate.Format = DateTimePickerFormat.Custom
        dtpReturnDate.CustomFormat = "MM/dd/yyyy hh:mm"





        ' Do not let the date be before the current date
        dtpReturnDate.MinDate = DateAndTime.Now()

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

    ' Reset the quantity to 0 if the user attempts to remove it completely
    Private Sub nudQuantity_TextChanged(sender As Object, e As EventArgs) Handles nudQuantity.TextChanged
        If nudQuantity.Text.Length = 0 Then
            nudQuantity.Text = "0"
        End If
    End Sub

    Private Sub btnOrderID_Click(sender As Object, e As EventArgs) Handles btnOrderID.Click
        Try
            Me.Order_DetailsTableAdapter.OrderIDHistory(Me.GEDataSet.Order_Details, txtOrderID.Text)
        Catch
            ' Display a message to the user and clear the order id textbox and the datagrid
            MessageBox.Show("You cannot enter a invalid Order ID. Please try again.")
            txtOrderID.Clear()

        End Try
    End Sub

    Private Sub dgvOrderDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderDetails.CellContentClick
        If e.ColumnIndex <> 4 Then
            Exit Sub
        End If

        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvOrderDetails.Rows(index)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtOrderDetailID.Text = selectedRow.Cells(0).Value.ToString()

        ' Display the quantiy of the selected order detail in txtQuantity
        nudQuantity.Text = selectedRow.Cells(2).Value.ToString()

        ' Fill the datetimepicker with the current date
        dtpReturnDate.Text = DateAndTime.Now()

        ' Convert the string to an int
        Integer.TryParse(nudQuantity.Text, quantityMax)
    End Sub
End Class