Public Class frmCouponsView
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub frmCouponsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Coupons' table. You can move, or remove it, as needed.
        Me.CouponsTableAdapter.Fill(Me.GEDataSet.Coupons)

    End Sub
End Class