Imports System.Data
Imports System.Data.SqlClient
Public Class POSEmailSearch
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text <> "" And Not TextBox1.Text Like "?*[@]?*.?*" Then
                MessageBox.Show("please enter a correct email")
                Exit Sub
            End If
        End If

        Dim command As New SqlCommand("select customerid from Customers where email = @email", something)
        command.Parameters.AddWithValue("@email", TextBox1.Text)
        Try
            something.Open()
            command.ExecuteNonQuery()
            MessageBox.Show(command.ExecuteScalar())

        Catch ex As System.Exception

        End Try
        something.Close()

    End Sub

    Private Sub POSEmailSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class