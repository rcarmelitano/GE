Imports System.Data
Imports System.Data.SqlClient

Public Class frmUpdateCustomer
    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Function phonenumber(x As String) As String
        Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
    End Function

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
		' Close the form
		Me.Close()
		frmCustomers.Show()
	End Sub

	Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
		' Display the customer history form
		frmCustomerHistory.Show()
		Try
			frmCustomerHistory.LoadDataGrid(CustomerIDTextBox.Text)
		Catch ex As Exception
			frmCustomerHistory.Close()
			MessageBox.Show("user has no history", "error",
							MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End Try
	End Sub
	Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFirst.Select()
        Me.Gift_CardsTableAdapter.CustomerGiftCards(Me.GEDataSet.Gift_Cards, CustomerIDTextBox.Text)

		'select max(id) from invoicetable
	End Sub
	'---------------------------------------------------------------------------------------------------------when update button is clicked it enables, and makes it inreable 
	Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
		' Disable ReadOnly for textboxes
		txtFirst.ReadOnly = False
		txtLast.ReadOnly = False
		txtbirthdate.ReadOnly = False
		txtprimary.ReadOnly = False
		txtSecondary.ReadOnly = False
		txtAvailableCredit.ReadOnly = False
		txtUsedLineOfCredit.ReadOnly = False
		txtEmail.ReadOnly = False
		btnsave2.Visible = False
		btnsave2.Enabled = False

		' Enable textboxes
		txtFirst.Enabled = True
		txtLast.Enabled = True
		txtbirthdate.Enabled = True
		txtprimary.Enabled = True
		txtSecondary.Enabled = True
		txtAvailableCredit.Enabled = True
		txtUsedLineOfCredit.Enabled = True
		txtEmail.Enabled = True
		btnSave.Enabled = True
		CheckBox1.Enabled = True
		CheckBox2.Enabled = True
		CheckBox3.Enabled = True
	End Sub
	'----------------------------------------------------------------------------------------------------------------------closing the form
	Private Sub updateCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		' Ask the user if they are sure they want to close the current form
		If MessageBox.Show("Are you sure you want to cancel?", "Customer Update Close",
		   MessageBoxButtons.YesNo) = DialogResult.No Then
			e.Cancel = True
		Else
			' Show the customers form
			frmCustomers.Show()
		End If
	End Sub
    '-------------------------------------------------------------------------------------------query to save an update to a customer 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Command As New SqlCommand("UPDATE customers SET firstName =@firstName,lastName =@lastName,customerDOB =convert(date,@customerDOB),primaryPhone =@primaryPhone,secondaryPhone =@secondaryPhone,email =@email,lineOfCredit =@lineOfCredit,usedLineOfCredit =@usedlineofcredit
                                            where CustomerID = @customerID", something)

        Command.Parameters.AddWithValue("@firstName", txtFirst.Text)
        Command.Parameters.AddWithValue("@lastname", txtLast.Text)
        Command.Parameters.AddWithValue("@customerDOB", txtbirthdate.Text)
        Command.Parameters.AddWithValue("@primaryPhone", phonenumber(txtprimary.Text))
        Command.Parameters.AddWithValue("@secondaryPhone", phonenumber(txtSecondary.Text))
        Command.Parameters.AddWithValue("@email", txtEmail.Text)
        Command.Parameters.AddWithValue("@lineOfCredit", txtUsedLineOfCredit.Text)
        Command.Parameters.AddWithValue("@usedlineofcredit", txtUsedLineOfCredit.Text)
        Command.Parameters.AddWithValue("@customerID", CustomerIDTextBox.Text)

        Try
            something.Open()
            Dim rowsaffected As Integer = Command.ExecuteNonQuery()

        Catch

        End Try

    End Sub
	'------------------------------------------------------------------------------------------query to add a new customer to the database 
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave2.Click


		If txtFirst.Text = "" Or txtLast.Text = "" Or txtbirthdate.Text = "" Or txtprimary.Text = "" Then
			MessageBox.Show("please enter all required infromation", "error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning)
			If txtFirst.Text = "" Then
				lblFR.ForeColor = Color.Red
			ElseIf lblFR.ForeColor = Color.Black Then
			End If

			If txtLast.Text = "" Then
				lblLR.ForeColor = Color.Red
			ElseIf lblLR.ForeColor = Color.Black Then
			End If

			If txtbirthdate.Text = "" Then
				lblDR.ForeColor = Color.Red
			ElseIf lblDR.ForeColor = Color.black Then
			End If

			If txtprimary.Text = "" Then
				lblPR.ForeColor = Color.Red
			ElseIf lblPR.ForeColor = Color.Black Then
			End If

			Exit Sub
		End If

		Dim dblId As Integer = 0
		Dim Command2 As New SqlCommand("select max(customerID) +1 from Customers", something)

		Try
			something.Open()
			Dim rowsaffected As Integer = Command2.ExecuteNonQuery()
			dblId = Command2.ExecuteScalar()
		Catch

		End Try
		something.Close()
		CustomerIDTextBox.Text = dblId


		Dim Command As New SqlCommand("INSERT INTO Customers (customerID,firstName,lastName,customerDOB,primaryPhone,secondaryPhone,email)VALUES 
(@customerID,@firstName,@lastName,convert(date,@customerDOB),@PrimaryPhone,@secondaryPhone,@email)", something)

		Command.Parameters.AddWithValue("@customerID", CustomerIDTextBox.Text)
		Command.Parameters.AddWithValue("@firstName", txtFirst.Text)
		Command.Parameters.AddWithValue("@lastname", txtLast.Text)
		Command.Parameters.AddWithValue("@customerDOB", txtbirthdate.Text)
		Command.Parameters.AddWithValue("@primaryPhone", phonenumber(txtprimary.Text))
		Command.Parameters.AddWithValue("@secondaryPhone", phonenumber(txtSecondary.Text))
		Command.Parameters.AddWithValue("@email", txtEmail.Text)
		Command.Parameters.AddWithValue("@lineOfCredit", txtUsedLineOfCredit.Text)
		Command.Parameters.AddWithValue("@usedlineofcredit", txtUsedLineOfCredit.Text)
		Try
			something.Open()
			Command.ExecuteNonQuery()
		Catch
		End Try
		something.Close()
	End Sub
End Class
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''