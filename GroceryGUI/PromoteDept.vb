Imports System.Data
Imports System.Data.SqlClient
Public Class PromoteDept
    Dim PDepConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub PromoteDept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Promoted_Departments' table. You can move, or remove it, as needed.
        Me.Promoted_DepartmentsTableAdapter.Fill(Me.GEDataSet.Promoted_Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Departments' table. You can move, or remove it, as needed.
        Me.DepartmentsTableAdapter.Fill(Me.GEDataSet.Departments)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

    End Sub
    Sub CheckConnection()
        'Check if the connection is open and if it is close it
        If PDepConnection.State Then
            PDepConnection.Close()
        End If
    End Sub

    Sub ConfirmBox(thingsname As String)
        MessageBox.Show(thingsname + " has successfully been created!")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckConnection()
        'Set up command to insert values
        Dim addPromoCat As New SqlCommand("INSERT INTO Promoted_Departments (promotionID,departmentID)
            VALUES(@promotionID,@departmentID)", PDepConnection)

        ' Pass in the values from the controls
        addPromoCat.Parameters.AddWithValue("@promotionID", cmbPromoSel.SelectedValue)
        addPromoCat.Parameters.AddWithValue("@departmentID", cmbDeptSel.SelectedValue)

        'Try to execute
        Try
            PDepConnection.Open()
            addPromoCat.ExecuteNonQuery()
            PDepConnection.Close()
            ConfirmBox("Association")
        Catch ex As Exception
            MessageBox.Show("Invalid Inputs")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class