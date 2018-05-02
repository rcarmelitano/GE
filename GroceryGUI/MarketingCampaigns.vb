Public Class MarketingCampaigns
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ViewCampaignsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCampaignsToolStripMenuItem.Click
        CampaignsView.Show()
    End Sub
End Class