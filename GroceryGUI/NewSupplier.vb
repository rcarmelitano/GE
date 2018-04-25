Imports System.Data
Imports System.Data.SqlClient

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
	'-----------------------------------------------------------------open a form that show supplier history 
	Private Sub mnuhistory_Click(sender As Object, e As EventArgs) Handles mnuhistory.Click

	End Sub

	Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
		'---------------------------------------setting the proprities for the diffrent text boxes 
		txtCompanyName.Enabled = True
		txtFirstName.Enabled = True
		txtLastName.Enabled = True
		txtPhone.Enabled = True
		txtFax.Enabled = True
		txtEmail.Enabled = True
		txtAddressOne.Enabled = True
		txtAddressTwo.Enabled = True
		txtCity.Enabled = True
		txtstate.Enabled = True
		txtZip.Enabled = True
		txtNotes.Enabled = True

		txtCompanyName.ReadOnly = False
		txtFirstName.ReadOnly = False
		txtLastName.ReadOnly = False
		txtPhone.ReadOnly = False
		txtFax.ReadOnly = False
		txtEmail.ReadOnly = False
		txtAddressOne.ReadOnly = False
		txtAddressTwo.ReadOnly = False
		txtCity.ReadOnly = False
		txtstate.ReadOnly = False
		txtZip.ReadOnly = False
		txtNotes.ReadOnly = False
	End Sub
	'-----------------------------------------------------------------------------------------------------------
	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

	End Sub
End Class