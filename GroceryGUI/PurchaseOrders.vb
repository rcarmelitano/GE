﻿Public Class frmPurchaseOrders
    Private Sub PurchaseOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Purchase_Order' table. You can move, or remove it, as needed.
        Me.Purchase_OrderTableAdapter.Fill(Me.GEDataSet.Purchase_Order)

        ' Disable the controls on the top of the form
        Me.ControlBox = False
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPurchaseOrders.CellContentClick
        If e.ColumnIndex <> 5 And e.ColumnIndex <> 6 Then
            Exit Sub
        End If

        If e.ColumnIndex = 6 Then
            frmPurchaseOrderDetails.getPurchaseOrderDetails(dgvPurchaseOrders.Rows(e.RowIndex).Cells(0).Value)

            Me.Hide()
            frmPurchaseOrderDetails.Show()
        End If

    End Sub

    Private Sub NewPurchaseOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPurchaseOrderToolStripMenuItem.Click
        NewPurchaseOrder.Show()
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and display the primary form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub
End Class