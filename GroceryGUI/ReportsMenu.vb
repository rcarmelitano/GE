Public Class frmReportsMenu
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and show the primary form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub
End Class