Imports System.Data
Imports System.Data.SqlClient


Public Class POSPhoneSearch
    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Function phonenumber(x As String) As String
        Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
    End Function


    Private Sub MaskedTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then


            Dim command As New SqlCommand("select customerid from Customers where primaryPhone = @phone", something)
            command.Parameters.AddWithValue("@phone", phonenumber(MaskedTextBox1.Text))
            Try
                something.Open()
                command.ExecuteNonQuery()
                MessageBox.Show(command.ExecuteScalar())

            Catch ex As System.Exception

            End Try
            something.Close()
        End If
    End Sub

    Private Sub POSPhoneSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class