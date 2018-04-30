Imports System.Data
Imports System.Data.SqlClient

Public Class Employees
    '------------------------------------------------------------------------------------------connection string to the database to write queries 
    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    '-------------------------------------------------------------------------------------------------------------------function to edit the phone number correctly
    Function phonenumber(x As String) As String
        Return x.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "")
    End Function

    '-----------------------------------------------------------------------------------------populates that datagrid for the first time
    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.GEDataSet.Employees)

    End Sub
    '-------------------------------------------------------------------------------------------search when the search button is clicked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.EmployeesTableAdapter.EmployeeID(Me.GEDataSet.Employees, CType(TextBox2.Text, Integer))
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '---------------------------------------------------------------------------------------------------------search when enter is pressed
    Private Sub textbox2_keydown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown, TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.EmployeesTableAdapter.EmployeeID(Me.GEDataSet.Employees, CType(TextBox2.Text, Integer))
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------resets datagrid when text is changed
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Me.EmployeesTableAdapter.Fill(Me.GEDataSet.Employees)
    End Sub

    '---------------------------------------------------------------------------------------------------controls what happens when the back button is clicked
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the current form and display the primaryForm
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    '----------------------------------------------------------------------------------------------------------controls what happens when a newCustomer is clicked
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click

        '-------------------------------------------enable the textbox to become editable 

        Employeesupdate.TextBox2.ReadOnly = False
        Employeesupdate.TextBox3.ReadOnly = False
        Employeesupdate.TextBox4.ReadOnly = False
        Employeesupdate.TextBox5.ReadOnly = False
        Employeesupdate.TextBox6.ReadOnly = False

        '-----------------------------------------enables the text boxes 

        Employeesupdate.TextBox2.Enabled = True
        Employeesupdate.TextBox3.Enabled = True
        Employeesupdate.TextBox4.Enabled = True
        Employeesupdate.TextBox5.Enabled = True
        Employeesupdate.TextBox6.Enabled = True

        Employeesupdate.UpdateToolStripMenuItem.Enabled = False
        Employeesupdate.Show()


    End Sub

    '--------------------------------------------------------------------------------------------------sends data to the new/update employeses table
    Private Sub EmployeesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeesDataGridView.CellContentClick
        If e.ColumnIndex <> 7 Then
            Exit Sub
        End If

        Dim V As String = EmployeesDataGridView.Rows(e.RowIndex).Cells(0).Value
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = EmployeesDataGridView.Rows(index)

        Employeesupdate.TextBox1.Text = selectedrow.Cells(0).Value.ToString()
        Employeesupdate.TextBox2.Text = selectedrow.Cells(1).Value.ToString()
        Employeesupdate.TextBox3.Text = selectedrow.Cells(2).Value.ToString()
        Employeesupdate.TextBox4.Text = selectedrow.Cells(4).Value.ToString()
        Employeesupdate.TextBox5.Text = selectedrow.Cells(5).Value.ToString()
        Employeesupdate.TextBox6.Text = CType(selectedrow.Cells(6).Value, Date).ToString("MMddyyyy")
        Employeesupdate.ShowDialog()
        Employeesupdate.Button1.Enabled = False



    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------tells you how to use the program
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub
End Class