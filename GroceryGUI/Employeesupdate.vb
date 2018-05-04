Imports System.Data
Imports System.Data.SqlClient



Public Class Employeesupdate

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    '-----------------------------------------------------------------------------------------------------phone number fomating function
    Function phonenumber(x As String) As String
        Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
    End Function

    '------------------------------------------------------------------------------------------------------------update button click
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click

        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        Button2.Enabled = True


        TextBox2.ReadOnly = False
        TextBox3.ReadOnly = False
        TextBox4.ReadOnly = False
        TextBox5.ReadOnly = False
        TextBox6.ReadOnly = False
    End Sub

    '-------------------------------------------------------------------- validation function for all information
    Private Function validation() As Boolean
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" _
            Or TextBox6.Text = "" Then

            MessageBox.Show("please enter all required infromation", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'If txtFirst.Text = "" Then
            '    lblFR.ForeColor = Color.Red
            'Else
            '    lblFR.ForeColor = Color.Black
            'End If

            'If txtLast.Text = "" Then
            '    lblLR.ForeColor = Color.Red
            'Else
            '    lblLR.ForeColor = Color.Black
            'End If

            'If txtbirthdate.Text = "" Then
            '    lblDR.ForeColor = Color.Red
            'Else
            '    lblDR.ForeColor = Color.Black
            'End If

            'If txtprimary.Text = "" Then
            '    lblPR.ForeColor = Color.Red
            'Else
            '    lblPR.ForeColor = Color.Black
            'End If

            'If txtEmail.Text <> "" And Not txtEmail.Text Like "?*[@]?*.?*" Then
            '    txtEmail.BackColor = Color.FromArgb(255, 252, 100, 113)
            'Else
            '    txtEmail.BackColor = SystemColors.Control
            'End If

            Return False
        End If
        Return True
    End Function
    '----------------------------------------------------------------------------------------------update query
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not validation() Then

            Exit Sub

        End If
        If System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(TextBox3.Text, "^[A-Za-z]+$") Then
            MessageBox.Show("letter")
        Else
            MessageBox.Show("letters only")
            Exit Sub
        End If

        If MessageBox.Show("are you sure you whant to save the changes", "saving",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Dim Command As New SqlCommand("UPDATE Employees SET firstName =@first, lastName =@last, primaryPhone =@Phone,
secondaryPhone = @phone2, employeeDOB =@DOB where employeeID = @employeeID", something)

        Command.Parameters.AddWithValue("@first", TextBox2.Text)
        Command.Parameters.AddWithValue("@last", TextBox3.Text)
        Command.Parameters.AddWithValue("@phone", phonenumber(TextBox4.Text))
        Command.Parameters.AddWithValue("@phone2", phonenumber(TextBox5.Text))
        Command.Parameters.AddWithValue("@DOB", TextBox6.Text)
        Command.Parameters.AddWithValue("@employeeID", TextBox1.Text)

        Try
            something.Open()
            Command.ExecuteNonQuery()
        Catch

        End Try
        Me.Close()
        frmPrimaryForm.Show()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Ask the user if they are sure they want to cancel
        If MessageBox.Show("Are you sure you want to cancel the update?", "Employee Update Cancellation",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            Employees.Show()
        End If
    End Sub

    Private Sub Employeesupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'----------------------------checking to see if all the required information is done 
		If Not validation() Then
			Exit Sub
		End If

		'-----------------------------message box to see if you whant to save 
		If MessageBox.Show("are you sure you whant to save the changes", "saving",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
			Exit Sub
		End If

		'-------CHECKING TO SEE IF TEXTBOX HAS ONLY LETTERS 
		If System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, "^[A-Za-z]+$") Or System.Text.RegularExpressions.Regex.IsMatch(TextBox3.Text, "^[A-Za-z]+$") Then
			MessageBox.Show("letter")
		Else
			MessageBox.Show("letters only")
			Exit Sub
		End If

		Dim Command As New SqlCommand("insert into Employees (employeeID, firstName,lastName, middleInitial, primaryPhone, secondaryPhone, employeeDOB)
values (@empID, @First, @Last, @Middle, @primary, @secondary, @EmDOB)", something)

		Try
			something.Open()
			Command.ExecuteNonQuery()
		Catch

		End Try
		Me.Close()
		frmPrimaryForm.Show()
	End Sub

End Class