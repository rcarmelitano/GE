Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddCategories
    'new sql connection
    Dim categoryConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        'Asks the user if they're certain they want to back out
        If MessageBox.Show("Are you sure you want to cancel creating a Category?", "Category Cancellation",
                        MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmCategories.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmAddAndUpdateCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disables the control box
        Me.ControlBox = False

        'Checks to see if the category ID field is already filled in the case of adding/updating
        If txtCategoryID.Text = String.Empty Then
            Dim categoryID As Integer = 0
            Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(categoryID) + 1 from Categories", categoryConnection)

            ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
            categoryConnection.Open()
            Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
            categoryID = getMaxReturnIDAndIncrement.ExecuteScalar()
            ' Display the new ID
            txtCategoryID.Text = categoryID
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateCategory.Click
        'Checks to see if the user has left any required fields blank before carrying out the operation
        If txtCategoryName.Text <> String.Empty And txtDepartmentID.Text <> String.Empty Then

            categoryConnection.Close()

            ' Add the new category and set the values entered to the attributes of the returns table
            Dim createCategory As New SqlCommand("INSERT INTO Categories (categoryID, departmentID, name)
                                                VALUES(@categoryID, @departmentID, @name)", categoryConnection)

            'Inserts values
            createCategory.Parameters.AddWithValue("@categoryID", txtCategoryID.Text)
            createCategory.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            createCategory.Parameters.AddWithValue("@name", txtCategoryName.Text)


            categoryConnection.Open()
            'Executes
            createCategory.ExecuteNonQuery()

            'Lets the user know they have created a category
            MessageBox.Show("You have successfully created a new Category.")
            categoryConnection.Close()
            'Re-opens the categories form
            frmCategories.Show()
            'Closes the current form
            Me.Close()
        Else
            'Lets the user know they have required fields left empty
            MessageBox.Show("All fields must be filled to create a category. Please try again.")
        End If
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        'Enables controls that are relevant to Updating the Category
        txtCategoryID.Enabled = False
        txtCategoryName.ReadOnly = False
        txtDepartmentID.ReadOnly = False
        txtCategoryName.Enabled = True
        txtDepartmentID.Enabled = True
        btnUpdateCategory.Enabled = True
    End Sub

    Private Sub btnUpdateCategory_Click(sender As Object, e As EventArgs) Handles btnUpdateCategory.Click
        'Checks to see if the user has left any required fields blank before carrying out the operation
        If txtCategoryName.Text <> String.Empty And txtDepartmentID.Text <> String.Empty Then

            categoryConnection.Close()

            'Updates the category with new data
            Dim updateCategory As New SqlCommand("UPDATE Categories SET categoryID =@categoryID, departmentID =@departmentID,name =@name WHERE categoryID = @categoryID", categoryConnection)
            updateCategory.Parameters.AddWithValue("@categoryID", txtCategoryID.Text)
            updateCategory.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            updateCategory.Parameters.AddWithValue("@name", txtCategoryName.Text)

            categoryConnection.Open()
            updateCategory.ExecuteNonQuery()

            'Lets the user know they have updated a category
            MessageBox.Show("You have successfully updated a Category.")
            categoryConnection.Close()
            'Re-opens the categories form
            frmCategories.Show()
            'Closes the current one
            Me.Close()
        Else
            'Lets the user know they have required fields left empty
            MessageBox.Show("All fields must be filled to update a category. Please try again.")
        End If
    End Sub
End Class