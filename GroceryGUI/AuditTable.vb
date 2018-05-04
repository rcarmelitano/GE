Public Class AuditTable
	Private Sub CreditAuditBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
		Me.Validate()
		Me.CreditAuditBindingSource.EndEdit()
		Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

	End Sub

	Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.CreditAudit' table. You can move, or remove it, as needed.
        Me.CreditAuditTableAdapter.Fill(Me.GEDataSet.CreditAudit)
    End Sub

    Private Sub CreditAuditBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CreditAuditBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    Private Sub CreditAuditBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.CreditAuditBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub
End Class