Imports System.Data.SqlClient
Imports System.Data

Public Class NewPurchaseOrderDetails
    Dim productSKU As String
    Dim costOfProduct As Double = 0
    Dim finalTotal As Double = 0
    ' counter
    Dim count As Integer = 0

    Dim PurchaseOrderConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub NewPurchaseOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

        ' Get rid of form control buttons
        Me.ControlBox = False

        ' Get the max id number currently in the database and then add 1
        Dim orderDetailID As Integer = 0
        Dim getMaxOrderDetailIDAndIncrement As New SqlCommand("select max(orderDetailID) + 1 from Purchase_Order_Details", PurchaseOrderConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        PurchaseOrderConnection.Open()
        getMaxOrderDetailIDAndIncrement.ExecuteNonQuery()
        orderDetailID = getMaxOrderDetailIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtOrderDetailID.Text = orderDetailID
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

        PurchaseOrderConnection.Close()

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvProducts.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        productSKU = selectedRow.Cells(0).Value.ToString()
        txtSKU.Text = selectedRow.Cells(0).Value.ToString()


        Dim getProductCost As New SqlCommand("SELECT retailCost FROM Products WHERE SKU = @SKU",
                                                 PurchaseOrderConnection)

        getProductCost.Parameters.AddWithValue("@SKU", productSKU)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        PurchaseOrderConnection.Open()

        Dim rowsAffected As Integer = getProductCost.ExecuteNonQuery()
        costOfProduct = getProductCost.ExecuteScalar()

        ' Close the connection
        PurchaseOrderConnection.Close()


        If count = 0 Then
            ' Calculate total
            finalTotal += (nupQuantity.Text * costOfProduct)
            txtOrderTotal.Text = finalTotal

            count = 1
        Else
            finalTotal = (nupQuantity.Text * costOfProduct)
            txtOrderTotal.Text = finalTotal
        End If

        txtSKU.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnPlacePurchaseOrder.Click

        If txtSKU.Text <> String.Empty And txtUnitOfPurchase.Text <> String.Empty Then
            ' Show a message to the user
            If MessageBox.Show("The purchase order has been placed." & vbCrLf & "Would you like to add another product to this same purchase order?", "Purchase Order Confirmation",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
                PurchaseOrderConnection.Close()



                Dim addProduct As New SqlCommand("UPDATE Purchase_Order SET orderTotal = @orderTotal where purchaseOrderID = @purchaseOrderID", PurchaseOrderConnection)

                addProduct.Parameters.AddWithValue("@orderTotal", finalTotal)
                addProduct.Parameters.AddWithValue("@purchaseOrderID", txtPurchaseOrderID.Text)

                PurchaseOrderConnection.Open()
                ' Open the connection to the database and pass in the information
                addProduct.ExecuteNonQuery()


                ' Add the new return and set the values entered to the attributes of the returns table
                Dim addPurchaseOrder As New SqlCommand("INSERT INTO Purchase_Order_Details (orderDetailID, purchaseOrderID, SKU, quantity, statusID, unit, note)
                                                VALUES(@orderDetailID, @purchaseOrderID, @SKU, @quantity, @statusID, @unit, @note)", PurchaseOrderConnection)
                Dim statusINT As Integer = 0


                PurchaseOrderConnection.Close()


                If cmbStatusID.Text = "Order Placed" Then
                    statusINT = "6"
                End If

                addPurchaseOrder.Parameters.AddWithValue("@orderDetailID", txtOrderDetailID.Text)
                addPurchaseOrder.Parameters.AddWithValue("@purchaseOrderID", txtPurchaseOrderID.Text)
                addPurchaseOrder.Parameters.AddWithValue("@SKU", txtSKU.Text)
                addPurchaseOrder.Parameters.AddWithValue("@quantity", nupQuantity.Text)
                addPurchaseOrder.Parameters.AddWithValue("@statusID", statusINT)
                addPurchaseOrder.Parameters.AddWithValue("@unit", txtUnitOfPurchase.Text)
                addPurchaseOrder.Parameters.AddWithValue("@note", txtNote.Text)

                ' Open the connection and run the query
                PurchaseOrderConnection.Open()
                addPurchaseOrder.ExecuteNonQuery()

                ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
                PurchaseOrderConnection.Close()

                ' Close the form and display the primary form
                frmPurchaseOrders.Show()
                Me.Close()

            Else
                count = 0

                PurchaseOrderConnection.Open()


                ' Add the new return and set the values entered to the attributes of the returns table
                Dim addPurchaseOrder As New SqlCommand("INSERT INTO Purchase_Order_Details (orderDetailID, purchaseOrderID, SKU, quantity, statusID, unit, note)
                                                VALUES(@orderDetailID, @purchaseOrderID, @SKU, @quantity, @statusID, @unit, @note)", PurchaseOrderConnection)
                Dim statusINT As Integer = 0




                If cmbStatusID.Text = "Order Placed" Then
                    statusINT = "6"
                End If

                addPurchaseOrder.Parameters.AddWithValue("@orderDetailID", txtOrderDetailID.Text)
                addPurchaseOrder.Parameters.AddWithValue("@purchaseOrderID", txtPurchaseOrderID.Text)
                addPurchaseOrder.Parameters.AddWithValue("@SKU", txtSKU.Text)
                addPurchaseOrder.Parameters.AddWithValue("@quantity", nupQuantity.Text)
                addPurchaseOrder.Parameters.AddWithValue("@statusID", statusINT)
                addPurchaseOrder.Parameters.AddWithValue("@unit", txtUnitOfPurchase.Text)
                addPurchaseOrder.Parameters.AddWithValue("@note", txtNote.Text)

                ' Open the connection and run the query
                addPurchaseOrder.ExecuteNonQuery()


                ' Reset the form controls
                txtOrderDetailID.Clear()
                txtNote.Clear()
                txtOrderTotal.Clear()
                txtSKU.Clear()
                txtUnitOfPurchase.Clear()
                nupQuantity.Text = 0

                ' Grab the current max ID and increment it by 1 for the next product to be added to the purchase order
                Dim orderDetailID As Integer = 0
                Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(orderDetailID) + 1 from Purchase_Order_Details", PurchaseOrderConnection)

                getMaxReturnIDAndIncrement.ExecuteNonQuery()
                orderDetailID = getMaxReturnIDAndIncrement.ExecuteScalar()

                ' Display the new ID
                txtOrderDetailID.Text = orderDetailID

                ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
                PurchaseOrderConnection.Close()
            End If
        Else
            ' Output a message to the user
            MessageBox.Show("All fields must be filled to complete the purchase order. Please try again.")
        End If
    End Sub
End Class