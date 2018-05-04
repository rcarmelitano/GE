Public Class CreditChangeReason
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If RichTextBox1.Text = "" Then
			MessageBox.Show("notes can not be empty", "error",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			Me.Hide()
		End If
	End Sub

    Private Sub audit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable the form controls
        Me.ControlBox = False
    End Sub
End Class
