Public Class frmShrinkage
    Private Sub Shrinkage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Shrinkage' table. You can move, or remove it, as needed.
        Me.ShrinkageTableAdapter.Fill(Me.GEDataSet.Shrinkage)

    End Sub
End Class