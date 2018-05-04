Imports System.Data
Imports System.Data.SqlClient

Public Class frmNewShipping
	Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


	Function phonenumber(x As String) As String
		Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
	End Function

	Private Function validation() As Boolean
		If ComboBox1.Text = "" Or txtShipAddressOne.Text = "" Or txtCity.Text = "" Or cmbState.Text = "" _
			Or txtZIP.Text = "" Then


			MessageBox.Show("please enter all required infromation", "error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning)


            If System.Text.RegularExpressions.Regex.IsMatch(txtCity.Text, "^[A-Za-z]+$") Then
            Else
                Return False
            End If
            Return True
        End If
		Return True
	End Function

    Private Sub btnCreateShipment_Click(sender As Object, e As EventArgs) Handles btnCreateShipment.Click

        If validation() = False Then
            Exit Sub
        End If

        If MessageBox.Show("are you sure you whant to save the changes", "saving",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim dblid As Integer = 0
        Dim command As New SqlCommand("select max(shippingAddressID)+1 from Shipping_Addresses", something)

        Try
            something.Open()
            command.ExecuteNonQuery()
            dblid = command.ExecuteScalar()
        Catch

        End Try
        something.Close()
        TextBox1.Text = dblid


        Dim command2 As New SqlCommand("insert into Shipping_Addresses (shippingAddressID,customerID,shippingAddress1,shippingAddress2,shippingCity,shippingState,shippingzip)
        values (@shippingID, @CustomerID, @shipAddress1, @shipAddress2, @shipCity, @shipState, @shipzip)", something)

        command2.Parameters.AddWithValue("shippingID", TextBox1.Text)
        command2.Parameters.AddWithValue("@CustomerID", txtOrderID.Text)
        command2.Parameters.AddWithValue("@shipAddress1", txtShipAddressOne.Text)
        command2.Parameters.AddWithValue("@shipAddress2", txtShipAddressTwo.Text)
        command2.Parameters.AddWithValue("@shipCity", txtCity.Text)
        command2.Parameters.AddWithValue("@shipState", cmbState.Text)
        command2.Parameters.AddWithValue("@shipzip", txtZIP.Text)

        Try
            something.Open()
            command2.ExecuteNonQuery()

        Catch

        End Try
        something.Close()
        Me.Close()
    End Sub

    Private Sub frmNewShipping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class
