Imports System.Data
Imports System.Data.SqlClient

Public Class frmNewAddress
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
        Dim dblid As Integer = 0
        Dim dblid1 As Integer = 0

        If validation() = False Then
            Exit Sub
        End If

        If MessageBox.Show("are you sure you whant to save the changes", "saving",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        If ComboBox1.SelectedIndex = 1 Then


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
            command2.Parameters.AddWithValue("@CustomerID", frmUpdateCustomer.CustomerIDTextBox.Text)
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

        ElseIf ComboBox1.SelectedIndex = 2 Then


            Dim command3 As New SqlCommand("select max(BillingAddressID)+1 from Billing_Addresses", something)

            Try
                something.Open()
                command3.ExecuteNonQuery()
                dblid1 = command3.ExecuteScalar()
            Catch

            End Try
            something.Close()
            TextBox1.Text = dblid1


            Dim command4 As New SqlCommand("insert into Billing_Addresses (BillingAddressID,customerID,BillingAddress1,BillingAddress2,BillingCity,BillingState,Billingzip)
        values (@billID, @CustomerID, @bill1, @bill2, @billcity, @billstate, @billzip)", something)

            command4.Parameters.AddWithValue("billID", TextBox1.Text)
            command4.Parameters.AddWithValue("@CustomerID", frmUpdateCustomer.CustomerIDTextBox.Text)
            command4.Parameters.AddWithValue("@bill1", txtShipAddressOne.Text)
            command4.Parameters.AddWithValue("@bill2", txtShipAddressTwo.Text)
            command4.Parameters.AddWithValue("@billCity", txtCity.Text)
            command4.Parameters.AddWithValue("@billState", cmbState.Text)
            command4.Parameters.AddWithValue("@billzip", txtZIP.Text)

            Try
                something.Open()
                command4.ExecuteNonQuery()

            Catch

            End Try
            something.Close()
            Me.Close()


        End If

    End Sub

    Private Sub frmNewShipping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class
