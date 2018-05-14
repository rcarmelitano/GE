Public Class frmReport2
    Private Sub frmReport9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False

    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        ' Close the form and show the reports form
        Me.Close()
        frmReportsMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Me.SpInventoryOnHandTableAdapter.Fill(Me.GEStoredProcedures.spInventoryOnHand, 1, txtCategoryID.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SpInventoryOnHandTableAdapter.Fill(Me.GEStoredProcedures.spInventoryOnHand, 0, txtDepartmentID.Text)
    End Sub
End Class