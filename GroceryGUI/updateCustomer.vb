Imports System.Data
Imports System.Data.SqlClient




Public Class frmUpdateCustomer

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the form
        Me.Close()
        frmCustomers.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        ' Display the customer history form
        frmCustomerHistory.Show()
        frmCustomerHistory.LoadDataGrid(CustomerIDTextBox.Text)
    End Sub



    Private Sub frmUpdateCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Gift_CardsTableAdapter.CustomerGiftCards(Me.GEDataSet.Gift_Cards, CustomerIDTextBox.Text)
    End Sub


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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Command As New SqlCommand("UPDATE customers SET firstName =@firstName,lastName =@lastName,customerDOB =@customerDOB,primaryPhone =@primaryPhone,secondaryPhone =@secondaryPhone,email =@email,lineOfCredit =@lineOfCredit,usedLineOfCredit =@usedlineofcredit
                                            where CustomerID = @customerID", something)

        Command.Parameters.AddWithValue("@firstName", txtFirst.Text)
        Command.Parameters.AddWithValue("@lastname", txtLast.Text)
        Command.Parameters.AddWithValue("@customerDOB", txtbirthdate.Text)
        Command.Parameters.AddWithValue("@primaryPhone", txtprimary.Text)
        Command.Parameters.AddWithValue("@secondaryPhone", txtSecondary.Text)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Command As New SqlCommand("INSERT INTO Customers (customerID,firstName,lastName,customerDOB,primaryPhone,secondaryPhone,email)VALUES 
(@customerID,@firstName,@lastName,@customerDOB,@PrimaryPhone,@secondaryPhone,@email)", something)


        Command.Parameters.AddWithValue("@customerID", CustomerIDTextBox.Text)
        Command.Parameters.AddWithValue("@firstName", txtFirst.Text)
        Command.Parameters.AddWithValue("@lastname", txtLast.Text)
        Command.Parameters.AddWithValue("@customerDOB", txtbirthdate.Text)
        Command.Parameters.AddWithValue("@primaryPhone", txtprimary.Text)
        Command.Parameters.AddWithValue("@secondaryPhone", txtSecondary.Text)
        Command.Parameters.AddWithValue("@email", txtEmail.Text)
        Command.Parameters.AddWithValue("@lineOfCredit", txtUsedLineOfCredit.Text)
        Command.Parameters.AddWithValue("@usedlineofcredit", txtUsedLineOfCredit.Text)

        Try
            something.Open()
            Dim rowsaffected As Integer = Command.ExecuteNonQuery()

        Catch

        End Try
    End Sub
End Class

