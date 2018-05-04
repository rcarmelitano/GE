Public Class frmReportsMenu
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and show the primary form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub frmReportsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class