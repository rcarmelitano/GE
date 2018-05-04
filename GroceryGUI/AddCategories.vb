Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddAndUpdateCategories
    Dim categoryConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to cancel creating a Category?", "Category Cancellation",
                        MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmDepartments.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmAddAndUpdateCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim categoryID As Integer = 0
        Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(categoryID) + 1 from Categories", categoryConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        categoryConnection.Open()
        Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
        categoryID = getMaxReturnIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtCategoryID.Text = categoryID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateCategory.Click
        If txtCategoryName.Text <> String.Empty And txtDepartmentID.Text <> String.Empty Then

            categoryConnection.Close()

            ' Add the new return and set the values entered to the attributes of the returns table
            Dim createCategory As New SqlCommand("INSERT INTO Categories (categoryID, departmentID, name)
                                                VALUES(@categoryID, @departmentID, @name)", categoryConnection)

            createCategory.Parameters.AddWithValue("@categoryID", txtCategoryID.Text)
            createCategory.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            createCategory.Parameters.AddWithValue("@name", txtCategoryName.Text)


            categoryConnection.Open()
            createCategory.ExecuteNonQuery()

            MessageBox.Show("You have successfully created a new Department.")
            categoryConnection.Close()
            frmCategories.Show()
            Me.Close()
        Else
            MessageBox.Show("All fields must be filled to create a department. Please try again.")
        End If
    End Sub
End Class