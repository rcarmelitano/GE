Public Class frmDiscountsView
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub frmDiscountsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class