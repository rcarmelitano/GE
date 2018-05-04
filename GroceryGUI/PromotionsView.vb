Public Class frmPromotionsView
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub PromotionsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class