Public Class frmCategoriesAndDepartments
    Private Sub btnDepartments_Click(sender As Object, e As EventArgs) Handles btnDepartments.Click
        ' Hide the form and display the Departments form
        Me.Hide()
        frmDepartments.Show()
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        ' Hide the form and display the Categories form
        Me.Hide()
        frmCategories.Show()
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        ' Close the form and show the home form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub frmCategoriesAndDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
    End Sub
End Class