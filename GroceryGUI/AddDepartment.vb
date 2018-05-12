Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddDepartment
    'Making a sql connection
    Dim departmentConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        'Asking the user if they're sure they want to quit
        If MessageBox.Show("Are you sure you want to cancel creating a Department?", "Department Cancellation",
                        MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmDepartments.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmAddDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disables the control box 
        Me.ControlBox = False

        'Checks to see if the department ID field has been filled yet, and if so, it fills it with one above the current maximum.
        If txtDepartmentID.Text = String.Empty Then
            Dim departmentID As Integer = 0
            Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(departmentID) + 1 from Departments", departmentConnection)
            ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
            departmentConnection.Open()
            Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
            departmentID = getMaxReturnIDAndIncrement.ExecuteScalar()
            ' Display the new ID
            txtDepartmentID.Text = departmentID

        End If



    End Sub

    Private Sub btnCreateDepartment_Click(sender As Object, e As EventArgs) Handles btnCreateDepartment.Click
        'Checks to see if the user has input anything before carrying out the operation
        If txtDepartmentName.Text <> String.Empty Then

            departmentConnection.Close()

            ' Add the new department and set the values entered to the attributes of the returns table
            Dim createDepartment As New SqlCommand("INSERT INTO Departments (departmentID, name)
                                                VALUES(@departmentID, @name)", departmentConnection)

            'Inserts the values
            createDepartment.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            createDepartment.Parameters.AddWithValue("@name", txtDepartmentName.Text)


            departmentConnection.Open()
            'Executes
            createDepartment.ExecuteNonQuery()

            'Lets the user know they have created a department
            MessageBox.Show("You have successfully created a new Department.")
            departmentConnection.Close()
            'Re-opens the departments view form
            frmDepartments.Show()
            'Closes the current form
            Me.Close()
        Else
            'Lets the user know they are missing info in required fields
            MessageBox.Show("All fields must be filled to create a department. Please try again.")
        End If
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        'Enables the relevant fields when the update button is clicked
        txtDepartmentName.Enabled = True
        txtDepartmentName.ReadOnly = False
        btnUpdate.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Checks to see if the user has input anything before carrying out the operation
        If txtDepartmentName.Text <> String.Empty Then

            departmentConnection.Close()

            ' Update the department with updated values

            Dim createDepartment As New SqlCommand("UPDATE Departments SET departmentID =@departmentID,name =@name WHERE departmentID = @departmentID", departmentConnection)

            ' Updates values
            createDepartment.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            createDepartment.Parameters.AddWithValue("@name", txtDepartmentName.Text)


            departmentConnection.Open()
            'Executes
            createDepartment.ExecuteNonQuery()

            'Lets the user know they have successfully updated the department.
            MessageBox.Show("You have successfully updated the Department.")
            departmentConnection.Close()
            'Re-opens the departments view form
            frmDepartments.Show()
            'Closes the current form

            Me.Close()
        Else
            'Lets the user know they are missing info in required fields

            MessageBox.Show("All fields must be filled to update a department. Please try again.")
        End If
    End Sub
End Class