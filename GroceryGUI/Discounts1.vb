Imports System.Data
Imports System.Data.SqlClient
Public Class Discounts1
    'Connect to the DB
    Dim DisConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub Discounts1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discount_Type' table. You can move, or remove it, as needed.
        Me.Discount_TypeTableAdapter.Fill(Me.GEDataSet.Discount_Type)
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        'Hide bogo stuff
        txtBuy.Hide()
        txtGet.Hide()
        lblBuy.Hide()
        lblGet.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue = 1 Then
            txtBuy.Show()
            txtGet.Show()
            lblBuy.Show()
            lblGet.Show()
        Else
            txtBuy.Hide()
            txtGet.Hide()
            lblBuy.Hide()
            lblGet.Hide()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
        frmPrimaryForm.Show()
    End Sub
End Class