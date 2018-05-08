Public Class CampaignsView
    Private Sub CampaignsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Marketing_Campaigns' table. You can move, or remove it, as needed.
        Me.Marketing_CampaignsTableAdapter.Fill(Me.GEDataSet.Marketing_Campaigns)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Marketing_CampaignsTableAdapter.FillBy(Me.GEDataSet.Marketing_Campaigns)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class