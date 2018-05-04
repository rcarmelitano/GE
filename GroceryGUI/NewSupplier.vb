Imports System.Data
Imports System.Data.SqlClient


'-------------------------------------------------------------------------------------------------------------------function to edit the phone number correctly

Public Class NewSupplier

    '---------------------------------------------connection string to the database 
    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    '------------------------------------------------function for formating the phone numbers 
    Function phonenumber(x As String) As String
        Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
    End Function
    '-----------------------------------------------------back button ask if they are sure they want to quick
    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click

        Dim res = MessageBox.Show("are you sure that you whant to close", "error",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        Me.Close()
        frmPrimaryForm.Show()
    End Sub
    ' Display the customer history form

    '-----------------------------------------------------------------open a form that show supplier history 
    Private Sub mnuhistory_Click(sender As Object, e As EventArgs) Handles mnuhistory.Click

		Try
			supplierhistory.loadDetails(txtSupplierID.Text)
			supplierhistory.ShowDialog()
		Catch ex As Exception
            supplierhistory.Close()
            MessageBox.Show("user has no history", "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        '---------------------------------------setting the proprities for the diffrent text boxes 
        txtCompanyName.Enabled = True
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtFax.Enabled = True
        txtFax.Enabled = True
        txtEmail.Enabled = True
        txtAddressOne.Enabled = True
        txtAddressTwo.Enabled = True
        txtCity.Enabled = True
        txtstate.Enabled = True
        txtZip.Enabled = True
        txtNotes.Enabled = True
        btnUpdate.Enabled = True

        txtCompanyName.ReadOnly = False
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtFax.ReadOnly = False
        txtFax.ReadOnly = False
        txtEmail.ReadOnly = False
        txtAddressOne.ReadOnly = False
        txtAddressTwo.ReadOnly = False
		txtCity.ReadOnly = False
		txtZip.ReadOnly = False
        txtNotes.ReadOnly = False
    End Sub
    '-----------------------------------------------------------------------------------------------------------

    '-----------------------------------------------------------------------------------------------------function for validation
    Private Function validation() As Boolean
		If txtCompanyName.Text = "" Or txtFirstName.Text = "" Or txtPhone.Text = "" _
			Or (txtEmail.Text <> "" And Not txtEmail.Text Like "?*[@]?*.?*") _
		Then
			MessageBox.Show("please enter all required infromation", "error",
						MessageBoxButtons.OK, MessageBoxIcon.Warning)




			If txtCompanyName.Text = "" Then
				lblCO.ForeColor = Color.Red
			Else
				lblCO.ForeColor = Color.Black
			End If

			If txtFirstName.Text = "" Then
				lblFR.ForeColor = Color.Red
			Else
				lblFR.ForeColor = Color.Black
			End If

			If txtLastName.Text = "" Then
				lblLM.ForeColor = Color.Red
			Else
				lblLM.ForeColor = Color.Black
			End If

			If txtPhone.Text = "" Then
				lblPH.ForeColor = Color.Red
			Else
				lblPH.ForeColor = Color.Black
			End If

			If txtFax.Text = "" Then
				lblFX.ForeColor = Color.Red
			Else
				lblFX.ForeColor = Color.Black
			End If

			If txtAddressOne.Text = "" Then
				lblAD1.ForeColor = Color.Red
			Else
				lblAD1.ForeColor = Color.Black
			End If

			If txtCity.Text = "" Then
				lblCT.ForeColor = Color.Red
			Else
				lblCT.ForeColor = Color.Black
			End If

			If txtstate.Text = "" Then
				lblST.ForeColor = Color.Red
			Else
				lblST.ForeColor = Color.Black
			End If

			If txtZip.Text = "" Then
				lblZP.ForeColor = Color.Red
			Else
				lblZP.ForeColor = Color.Black
			End If


			If txtEmail.Text <> "" And Not txtEmail.Text Like "?*[@]?*.?*" Then
				txtEmail.BackColor = Color.FromArgb(255, 252, 100, 113)
			Else
				txtEmail.BackColor = SystemColors.Control
			End If

			Return False
		End If
		Return True
    End Function
    '-------------------------------------------------------------------------------------------------update supplier 
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If Not validation() Then

            Exit Sub

        End If

        If System.Text.RegularExpressions.Regex.IsMatch(txtCompanyName.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, "^[A-Za-z]+$") Then
            MessageBox.Show("letter")
        Else
            MessageBox.Show("letters only")

        End If


        MessageBox.Show("are you sure you whant to save the changes", "saving",
                        MessageBoxButtons.OK, MessageBoxIcon.Question)


        Dim Command As New SqlCommand("update suppliers SET supplierName=@supplierName,pocFirstName=@firstName,pocLastName=@lastName,phoneNumber=@phone,faxNumber=@fax,
email=@email,address1=@address1,address2=@address2,city= @city,[state]= @state,zip = @zip, notes = @note
        where supplierId =@supplierID", something)





        Command.Parameters.AddWithValue("@supplierName", txtCompanyName.Text)
        Command.Parameters.AddWithValue("@firstName", txtFirstName.Text)
        Command.Parameters.AddWithValue("@lastName", txtLastName.Text)
        Command.Parameters.AddWithValue("@phone", phonenumber(txtPhone.Text))
        Command.Parameters.AddWithValue("@fax", phonenumber(txtFax.Text))
        Command.Parameters.AddWithValue("@email", txtEmail.Text)
        Command.Parameters.AddWithValue("@address1", txtAddressOne.Text)
        Command.Parameters.AddWithValue("@address2", txtAddressTwo.Text)
        Command.Parameters.AddWithValue("@city", txtCity.Text)
        Command.Parameters.AddWithValue("@state", txtstate.Text)
        Command.Parameters.AddWithValue("@zip", txtZip.Text)
        Command.Parameters.AddWithValue("@note", txtNotes.Text)
        Command.Parameters.AddWithValue("@supplierID", txtSupplierID.Text)
        Try
            something.Open()
            Dim rowsaffected As Integer = Command.ExecuteNonQuery()

        Catch

        End Try
        something.Close()
        Me.Close()
        frmSuppliers.Show()

    End Sub

    '----------------------------------------------------------------------------------------------------add a new supplier 
    Private Sub btnsave2_Click(sender As Object, e As EventArgs) Handles btnsave2.Click



		If Not validation() Then

			Exit Sub

		End If

		If System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(txtLastName.Text, "^[A-Za-z]+$") Then
            MessageBox.Show("letter")
        Else
            MessageBox.Show("letters only")
            Exit Sub
        End If

        If MessageBox.Show("are you sure you whant to save the changes", "saving",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub

        End If

        Dim dblId As Integer = 0
		Dim Command2 As New SqlCommand("select max(SupplierID) +1 from Suppliers", something)

		Try
            something.Open()
            Dim rowsaffected As Integer = Command2.ExecuteNonQuery()
            dblId = Command2.ExecuteScalar()
        Catch

        End Try
        something.Close()
        txtSupplierID.Text = dblId



        Dim Command As New SqlCommand("INSERT INTO Suppliers (SupplierID,SupplierName,pocFirstName,pocLastName,phoneNumber,faxNumber,email,address1,address2,city,state,zip,notes)VALUES 
(@supplierID,@supplierName,@firstName,@lastName,@phone, @fax,@email,@address1,@address2,@city,@state,@zip,@note)", something)

		Command.Parameters.AddWithValue("@supplierID", txtSupplierID.Text)
		Command.Parameters.AddWithValue("@supplierName", txtCompanyName.Text)
        Command.Parameters.AddWithValue("@firstName", txtFirstName.Text)
        Command.Parameters.AddWithValue("@lastName", txtLastName.Text)
        Command.Parameters.AddWithValue("@phone", phonenumber(txtPhone.Text))
        Command.Parameters.AddWithValue("@fax", phonenumber(txtFax.Text))
        Command.Parameters.AddWithValue("@email", txtEmail.Text)
        Command.Parameters.AddWithValue("@address1", txtAddressOne.Text)
        Command.Parameters.AddWithValue("@address2", txtAddressTwo.Text)
        Command.Parameters.AddWithValue("@city", txtCity.Text)
        Command.Parameters.AddWithValue("@state", txtstate.Text)
        Command.Parameters.AddWithValue("@zip", txtZip.Text)
        Command.Parameters.AddWithValue("@note", txtNotes.Text)

		Try
            something.Open()
            Command.ExecuteNonQuery()

        Catch
        End Try
        something.Close()

    End Sub

    Private Sub NewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class