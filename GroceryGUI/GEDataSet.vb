Partial Class GEDataSet
    Partial Public Class PromotionsDataTable
        Private Sub PromotionsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            ''If (e.Column.ColumnName = Me.promoInfoIDColumn.ColumnName) Then
            'Add user code here
            ''  End If

        End Sub

    End Class
End Class

Namespace GEDataSetTableAdapters
    Partial Public Class Marketing_CampaignsTableAdapter
    End Class
End Namespace
