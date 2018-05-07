Imports System.Data
Imports System.Data.SqlClient

Public Class POSCustomerSearch

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        POSEmailSearch.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        POSPhoneSearch.ShowDialog()
    End Sub

    Private Sub POSCustomerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class