﻿Public Class frmReport11
    Private Sub frmReport11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False



    End Sub

    Private Sub mnuBack_Click(sender As Object, e As EventArgs) Handles mnuBack.Click
        ' Close the form and show the reports form
        Me.Close()
        frmReportsMenu.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Me.SALES_CROSSTABTableAdapter.Fill(Me.GEStoredProcedures.SALES_CROSSTAB, txtYear.Text)
    End Sub

End Class