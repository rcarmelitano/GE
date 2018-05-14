Imports System.Data
Imports System.Data.SqlClient

Public Class frmUpdateCustomer

	Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Dim total As Integer

    '-------------------------------------------------------------------------------------------------------------------function to edit the phone number correctly
    Function phonenumber(x As String) As String
		Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
	End Function

	'--------------------------------------------------------------------------------------------------------------------------------menu strip back button click
	Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the form
        Me.Close()
        Me.Controls.Clear()
        InitializeComponent()
        Me.frmUpdateCustomer_Load(e, e)
        frmCustomers.Show()

    End Sub

	'------------------------------------------------------------------------------------------------------------------------------button click for customer History
	Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
		' Display the customer history form


		Try
			frmCustomerHistory.LoadDataGrid(CustomerIDTextBox.Text)
			frmCustomerHistory.ShowDialog()
		Catch ex As Exception
			frmCustomerHistory.Close()
			MessageBox.Show("user has no history", "error",
								MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End Try
	End Sub

	'----------------------------------------------------------------------------------------------------------------------------------form loader
	Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.ControlBox = False
		total = txtAvailableCredit.Text
		txtFirst.Select()
		Me.Gift_CardsTableAdapter.CustomerGiftCards(Me.GEDataSet.Gift_Cards, CustomerIDTextBox.Text)

		'select max(id) from invoicetable


		' Disable the form controls

	End Sub

	'---------------------------------------------------------------------------------------------------------when update button is clicked it enables, and makes it inreable 
	'-----------------------------------------------------------------------------------------------------------need to redo. 
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
        btnNew.Visible = False
        btnNew.Enabled = False

        ' Enable textboxes
        txtFirst.Enabled = True
        txtLast.Enabled = True
        txtbirthdate.Enabled = True
        txtprimary.Enabled = True
        txtSecondary.Enabled = True
        txtAvailableCredit.Enabled = True
        txtUsedLineOfCredit.Enabled = True
        txtEmail.Enabled = True
        btnupdate.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
    End Sub

    '----------------------------------------------------------------------------------------------------------------------closing the form
    Private Sub updateCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '----------------------------------- Ask the user if they are sure they want to close the current form
        '	If MessageBox.Show("Are you sure you want to cancel?", "Customer Update Close",
        '	   MessageBoxButtons.YesNo) = DialogResult.No Then
        '		e.Cancel = True
        '	Else
        ' Show the customers form
        '		frmCustomers.Show()
        'End If
    End Sub

    '----------------------------------------------------------------------------------------------------------function for updatecustomer validation(copy)
    Private Function validation() As Boolean
        If txtFirst.Text = "" Or txtLast.Text = "" Or txtbirthdate.Text = "" Or txtprimary.Text = "" _
            Or (txtEmail.Text <> "" And Not txtEmail.Text Like "?*[@]?*.?*") Then

            MessageBox.Show("please enter all required infromation", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If txtFirst.Text = "" Then
                lblFR.ForeColor = Color.Red
            Else
                lblFR.ForeColor = Color.Black
            End If

            If txtLast.Text = "" Then
                lblLR.ForeColor = Color.Red
            Else
                lblLR.ForeColor = Color.Black
            End If

            If txtbirthdate.Text = "" Then
                lblDR.ForeColor = Color.Red
            Else
                lblDR.ForeColor = Color.Black
            End If

            If txtprimary.Text = "" Then
                lblPR.ForeColor = Color.Red
            Else
                lblPR.ForeColor = Color.Black
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

    '-------------------------------------------------------------------------------------------query to save an update to a customer 
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        If Not validation() Then

            Exit Sub

        End If

        If System.Text.RegularExpressions.Regex.IsMatch(txtFirst.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(txtLast.Text, "^[A-Za-z]+$") Then
            MessageBox.Show("letter")
        Else
            MessageBox.Show("letters only")
            Exit Sub
        End If


        '------------------------------------------------checking to see if the line of credit has been changed 
        If txtAvailableCredit.Text <> total Then

            CreditChangeReason.ShowDialog()
            Dim reason As String = CreditChangeReason.RichTextBox1.Text
            MessageBox.Show(reason)
            Dim command2 As New SqlCommand("INSERT INTO CreditAudit (EmployeeId,CustomerId,startamount,newAmount,ChangedOn,reason) 
Values (@EmployeeID, @CustomerId, @Start, @new, @date, @reason)", something)


            command2.Parameters.AddWithValue("@employeeID", trying)
            command2.Parameters.AddWithValue("@CustomerId", CustomerIDTextBox.Text)
            command2.Parameters.AddWithValue("@start", total)
            command2.Parameters.AddWithValue("@new", txtAvailableCredit.Text)
            command2.Parameters.AddWithValue("@date", DateTime.Now)
            command2.Parameters.AddWithValue("@reason", reason)
            CreditChangeReason.Close()


            Try
                something.Open()
                Dim rowsaffected As Integer = command2.ExecuteNonQuery()

            Catch

            End Try
            something.Close()
            Me.Close()
            Me.Controls.Clear()
            InitializeComponent()
            Me.frmUpdateCustomer_Load(e, e)


        End If

        '--------------------------------------------------------------------------------------asking if they are sure they whant to save the changes 
        If MessageBox.Show("are you sure you whant to save the changes", "saving",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub

        End If

        Dim newtotal As Integer
        newtotal = txtAvailableCredit.Text

        Dim Command As New SqlCommand("UPDATE customers SET firstName =@firstName,lastName =@lastName,customerDOB =convert(date,@customerDOB),primaryPhone =@primaryPhone,secondaryPhone =@secondaryPhone,email =@email,lineOfCredit =@lineOfCredit,usedLineOfCredit =@usedlineofcredit
                                            where CustomerID = @customerID", something)

        Command.Parameters.AddWithValue("@firstName", txtFirst.Text)
        Command.Parameters.AddWithValue("@lastname", txtLast.Text)
        Command.Parameters.AddWithValue("@customerDOB", txtbirthdate.Text)
        Command.Parameters.AddWithValue("@primaryPhone", phonenumber(txtprimary.Text))
        Command.Parameters.AddWithValue("@secondaryPhone", phonenumber(txtSecondary.Text))
        Command.Parameters.AddWithValue("@email", txtEmail.Text)
        Command.Parameters.AddWithValue("@lineOfCredit", txtAvailableCredit.Text)
        Command.Parameters.AddWithValue("@usedlineofcredit", txtUsedLineOfCredit.Text)
        Command.Parameters.AddWithValue("@customerID", CustomerIDTextBox.Text)

        Try
            AuditTable.Show()
            something.Open()
            Dim rowsaffected As Integer = Command.ExecuteNonQuery()

        Catch

        End Try


        frmPrimaryForm.Show()
        Me.Close()
        Me.Controls.Clear()
        InitializeComponent()
        Me.frmUpdateCustomer_Load(e, e)
    End Sub

    '------------------------------------------------------------------------------------------query to add a new customer to the database 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        If Not validation() Then

            Exit Sub

        End If
        If System.Text.RegularExpressions.Regex.IsMatch(txtFirst.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(txtLast.Text, "^[A-Za-z]+$") Then
            MessageBox.Show("letter")
        Else
            MessageBox.Show("letters only")
            Exit Sub
        End If


        If txtAvailableCredit.Text > total Or txtAvailableCredit.Text < total Then

            something.Close()
            CreditChangeReason.ShowDialog()
        End If


        If MessageBox.Show("are you sure you whant to save the changes", "saving",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Exit Sub
            Me.Close()
            Me.Controls.Clear()
            InitializeComponent()
            Me.frmUpdateCustomer_Load(e, e)
        End If

        '--------------------------------------------------------------------------------------asking if they are sure they whant to save the changes 
        ' MessageBox.Show("are you sure you whant to save the changes", "saving",
        'MessageBoxButtons.OK, MessageBoxIcon.Question)


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
        Me.Close()
        Me.Controls.Clear()
        InitializeComponent()
        Me.frmUpdateCustomer_Load(e, e)
    End Sub

    Private Sub AddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddressToolStripMenuItem.Click
        ShippingAdresses.ShowDialog()

    End Sub
End Class

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''