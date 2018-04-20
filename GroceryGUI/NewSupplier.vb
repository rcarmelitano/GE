Imports System.Data
Imports System.Data.SqlClient

Public Class NewSupplier

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Command As New SqlCommand("select * from", something)

        Command.Parameters.AddWithValue(txtId.Text, "@customerID")
        ' Command.Parameters.AddWithValue("@firstName", txtFirst.Text)
        ' Command.Parameters.AddWithValue("@lastname", txtLast.Text)
        ' Command.Parameters.AddWithValue("@customerDOB", MaskedBirthDate.Text)
        ' Command.Parameters.AddWithValue("@primaryPhone", MaskedPrimaryPhone.Text)
        ' Command.Parameters.AddWithValue("@secondaryPhone", MaskedSecondaryPhone.Text)
        ' Command.Parameters.AddWithValue("@email", txtEmail.Text)
        '  Command.Parameters.AddWithValue("@lineOfCredit", txtUsedLineOfCredit.Text)
        '  Command.Parameters.AddWithValue("@usedlineofcredit", txtUsedLineOfCredit.Text)

        Try
            something.Open()
            Dim rowsaffected As Integer = Command.ExecuteNonQuery()

        Catch

        End Try
    End Sub
End Class