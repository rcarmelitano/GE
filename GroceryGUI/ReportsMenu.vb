Public Class frmReportsMenu
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the form and show the primary form
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub frmReportsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Opens the Report 12 Form
        Me.Close()
        frmReport12.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'Opens the Report 13 Form
        Me.Close()
        frmReport13.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Opens the Report 14 Form
        Me.Close()
        frmReport14.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Opens the Report 15 Form
        Me.Close()
        frmReport15.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Opens the Report 9 Form
        Me.Close()
        frmReport9.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Opens the Report 2 Form
        Me.Close()
        frmReport2.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Opens the Report 11 Form
        Me.Close()
        frmReport11.Show()
    End Sub
End Class