Public Class audit
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If RichTextBox1.Text = "" Then
			MessageBox.Show("notes can not be empty", "error",
							MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			Me.Close()
		End If
	End Sub
End Class
