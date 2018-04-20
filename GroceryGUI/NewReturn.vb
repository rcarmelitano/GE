Public Class frmNewReturn
    Private Sub btnFinalizeReturn_Click(sender As Object, e As EventArgs) Handles btnFinalizeReturn.Click
        ' Show a message to the user
        If MessageBox.Show("          Your return has been finalized." & vbCrLf & "    Do you want to make another return?", "Return",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
            Me.Close()
            frmPrimaryForm.Show()
        End If

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        ' Close the current form and display the primaryForm
        Me.Close()
    End Sub
End Class