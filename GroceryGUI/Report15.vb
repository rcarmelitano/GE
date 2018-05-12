Public Class frmReport15
    Private Sub Report15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        ' Close the form and show the reports form
        Me.Close()
        frmReportsMenu.Show()
    End Sub

End Class