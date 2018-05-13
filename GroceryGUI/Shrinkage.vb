Public Class frmShrinkage
    Private Sub Shrinkage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.GEDataSet.Status)
        'TODO: This line of code loads data into the 'GEDataSet.Shrinkage' table. You can move, or remove it, as needed.
        Me.ShrinkageTableAdapter.Fill(Me.GEDataSet.Shrinkage)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and display the primary form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub NewShrinkageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewShrinkageToolStripMenuItem.Click
        ' Close the current form and display the NewShrinkage form
        frmNewShrinkage.Show()
        Me.Hide()
    End Sub
End Class