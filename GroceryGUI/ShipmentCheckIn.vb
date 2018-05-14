Imports System.Data
Imports System.Data.SqlClient
Public Class ShipmentCheckIn
    Dim ShipConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    'Holds ID pulled from the DGV and passed into add button
    Dim selectedSKU As String = 0
    Dim selectedID As Integer = 0
    Dim selectedProduct As String
    Private Sub ShipmentCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GEDataSet.Inventory)
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
        logDate.Format = DateTimePickerFormat.Custom
        logDate.CustomFormat = "MM/dd/yyyy"
        logDate.Text = DateAndTime.Now()
    End Sub
    Function getNewID(idname As String, table As String) As Integer
        'Figure out the id of the next campaign
        Dim newID As Integer = 0
        Dim getIDSQL As New SqlCommand("select max(" + idname + ") + 1 from " + table, ShipConnection)
        ' Open conn, execute, close conn, return value
        ShipConnection.Open()
        newID = getIDSQL.ExecuteScalar()
        ShipConnection.Close()
        Return newID
    End Function

    Sub CheckConnection()
        'Check if the connection is open and if it is close it
        If ShipConnection.State Then
            ShipConnection.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        CheckConnection()
        Dim selectedRow As DataGridViewRow
        selectedRow = dgvProducts.Rows(e.RowIndex)
        ' Grab the selected ID and SKU and product name and stick it in the var
        selectedSKU = selectedRow.Cells(0).Value.ToString()
        txtSku.Text = selectedSKU
        selectedProduct = selectedRow.Cells(4).Value.ToString()

        Dim getInvID As New SqlCommand("SELECT inventoryID FROM Inventory WHERE SKU =@SKU",
                                                 ShipConnection)
        getInvID.Parameters.AddWithValue("@SKU", selectedSKU)
        ShipConnection.Open()
        selectedID = getInvID.ExecuteScalar
        ShipConnection.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CheckConnection()
        Dim newQty As Decimal = 0
        Dim oldQty As Decimal = 0
        Dim id As Integer = getNewID("ShipmentReceivedID", "Shipment_Received")
        ' Insert new log entry query
        Dim insertLogEntry As New SqlCommand("INSERT INTO Shipment_Received(ShipmentReceivedID,inventoryID,dateReceived,quantity)
                                                VALUES (@ShipmentReceivedID,@inventoryID,@dateReceived,@quantity)", ShipConnection)
        insertLogEntry.Parameters.AddWithValue("@ShipmentReceivedID", id)
        insertLogEntry.Parameters.AddWithValue("@inventoryID", selectedID)
        insertLogEntry.Parameters.AddWithValue("@dateReceived", logDate.Text)
        insertLogEntry.Parameters.AddWithValue("@quantity", txtQty.Text)
        ' Get existing inventory count
        Dim getInvQty As New SqlCommand("SELECT inventoryCount FROM Inventory WHERE inventoryID=@inventoryID", ShipConnection)
        getInvQty.Parameters.AddWithValue("@inventoryID", selectedID)
        'Query to update qty 
        Dim updateInv As New SqlCommand("UPDATE Inventory SET inventoryCount = @inventoryCount WHERE SKU = @SKU", ShipConnection)
        updateInv.Parameters.AddWithValue("@inventoryCount", newQty)
        updateInv.Parameters.AddWithValue("@SKU", selectedSKU)
        'Try to update log and inventory
        If selectedSKU = "" Then
            MessageBox.Show("You must selected a product to check in!")
        ElseIf txtQty.Text = "" Then
            MessageBox.Show("You must enter a quantity of the product to check in!")
        Else
            Try
                ShipConnection.Open()
                oldQty = getInvQty.ExecuteScalar
                newQty = oldQty + txtQty.Text
                insertLogEntry.ExecuteNonQuery()
                updateInv.ExecuteNonQuery()
                ShipConnection.Close()
                MessageBox.Show(txtQty.Text + " of " + selectedProduct + " has been added to inventory!")
            Catch ex As Exception
                MessageBox.Show("Invalid Inputs")
            End Try
            ShipConnection.Open()

        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class