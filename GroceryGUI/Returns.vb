Public Class frmNewReturn
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Me.Order_DetailsTableAdapter.orderID(Me.GEDataSet.Order_Details, CType(txtOrderID.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        ' Close the current form and display the primaryForm
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub btnFinalizeReturn_Click(sender As Object, e As EventArgs) Handles btnFinalizeReturn.Click
        ' Show a message to the user
        If MessageBox.Show("          Your return has been finalized." & vbCrLf & "    Do you want to make another return?", "Return",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
            Me.Close()
            frmPrimaryForm.Show()
        End If

    End Sub

    Private Sub frmReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me.GEDataSet.Order_Details)
        'TODO: This line of code loads data into the 'GEDataSet.Returns' table. You can move, or remove it, as needed.
        Me.ReturnsTableAdapter.Fill(Me.GEDataSet.Returns)
    End Sub

    Private Sub ViewReturnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReturnsToolStripMenuItem.Click
        ' Hide the current form and display the returns view form
        Me.Hide()
        frmReturnsView.Show()
    End Sub
End Class