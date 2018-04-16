Public Class frmGiftCardsView
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub frmGiftCardsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Gift_Cards' table. You can move, or remove it, as needed.
        Me.Gift_CardsTableAdapter.Fill(Me.GEDataSet.Gift_Cards)
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)

    End Sub
End Class