Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddDepartment
    Dim departmentConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        If MessageBox.Show("Are you sure you want to cancel creating a Department?", "Department Cancellation",
                        MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmDepartments.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmAddDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False

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
        If txtDepartmentName.Text <> String.Empty Then

            departmentConnection.Close()

            ' Add the new return and set the values entered to the attributes of the returns table
            Dim createDepartment As New SqlCommand("INSERT INTO Departments (departmentID, name)
                                                VALUES(@departmentID, @name)", departmentConnection)

            createDepartment.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            createDepartment.Parameters.AddWithValue("@name", txtDepartmentName.Text)


            departmentConnection.Open()
            createDepartment.ExecuteNonQuery()

            MessageBox.Show("You have successfully created a new Department.")
            departmentConnection.Close()
            frmDepartments.Show()
            Me.Close()
        Else
            MessageBox.Show("All fields must be filled to create a department. Please try again.")
        End If
    End Sub

    Private Sub mnuUpdate_Click(sender As Object, e As EventArgs) Handles mnuUpdate.Click
        txtDepartmentName.Enabled = True
        txtDepartmentName.ReadOnly = False
        btnUpdate.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtDepartmentName.Text <> String.Empty Then

            departmentConnection.Close()

            ' Update the department with updated values

            Dim createDepartment As New SqlCommand("UPDATE Departments SET departmentID =@departmentID,name =@name WHERE departmentID = @departmentID", departmentConnection)

            createDepartment.Parameters.AddWithValue("@departmentID", txtDepartmentID.Text)
            createDepartment.Parameters.AddWithValue("@name", txtDepartmentName.Text)


            departmentConnection.Open()
            createDepartment.ExecuteNonQuery()

            MessageBox.Show("You have successfully updated the Department.")
            departmentConnection.Close()
            frmDepartments.Show()
            Me.Close()
        Else
            MessageBox.Show("All fields must be filled to update a department. Please try again.")
        End If
    End Sub
End Class