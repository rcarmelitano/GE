Imports System.Data
Imports System.Data.SqlClient
Public Class UpdatePurchaseOrder
    Dim UPConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub UpdatePurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.GEDataSet.Status)
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        poDate.Format = DateTimePickerFormat.Custom
        poDate.CustomFormat = "MM/dd/yyyy"
        poDate.Text = DateAndTime.Now()
    End Sub

    Sub CheckConnection()
        'Check if the connection is open and if it is close it
        If UPConnection.State Then
            UPConnection.Close()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (cmbSupplier.SelectedValue = 0) Then
            MessageBox.Show("Please select a supplier")
        ElseIf (txtOrderTotal.Text = "") Then
            MessageBox.Show("Please show an order total")
        ElseIf (cmbStatus.SelectedValue = 0) Then
            MessageBox.Show("Please select a status")
        Else
            CheckConnection()
            'Set up query to pass in data
            Dim updatePO As New SqlCommand("UPDATE Purchase_Order SET purchaseOrderID = @purchaseOrderID, supplierID = @supplierID, orderTotal = @orderTotal, orderDate = @orderDate,
                statusID = @statusID WHERE purchaseOrderID = @purchaseOrderID", UPConnection)

            updatePO.Parameters.AddWithValue("@purchaseOrderID", txtPOID.Text)
            updatePO.Parameters.AddWithValue("@supplierID", cmbSupplier.SelectedValue)
            updatePO.Parameters.AddWithValue("@orderTotal", txtOrderTotal.Text)
            updatePO.Parameters.AddWithValue("@orderDate", poDate.Text)
            updatePO.Parameters.AddWithValue("@statusID", cmbStatus.SelectedValue)

            'Call it 
            Try
                UPConnection.Open()
                updatePO.ExecuteNonQuery()
                UPConnection.Close()
                MessageBox.Show("Purchase order updated!")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Invalid Inputs")
            End Try


        End If

    End Sub
End Class