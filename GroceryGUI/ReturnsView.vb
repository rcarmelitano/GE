Public Class frmReturnsView
    Private Sub frmReturnsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Returns' table. You can move, or remove it, as needed.
        Me.ReturnsTableAdapter.Fill(Me.GEDataSet.Returns)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
        frmNewReturn.Show()
    End Sub
End Class