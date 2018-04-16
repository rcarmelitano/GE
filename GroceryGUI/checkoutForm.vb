﻿Public Class frmCheckoutForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the form.
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub btnHotKeys_Click(sender As Object, e As EventArgs) Handles btnHotKeys.Click
        ' Open the quickKeyMenu form
        frmQuickKey.Show()
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        ' Open the newCustomer form
        frmNewCustomer.Show()
    End Sub

    Private Sub checkoutForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Checkout Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
        End If
    End Sub

    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click

    End Sub

    Private Sub btnInventorySearch_Click(sender As Object, e As EventArgs) Handles btnInventorySearch.Click

    End Sub

    Private Sub frmCheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GEDataSet.Inventory)
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

    End Sub
End Class
