' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmCheckoutForm

    ' Create a new connection to the database for this form
    Dim productConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Public selectedRow As DataGridViewRow

    ' Declare variables to use for calculations
    Dim quantity As Integer = 0
    Dim subTotal As Double = 0
    Dim subTotalFinal As Double = 0
    Dim discount As Double = 0
    Dim taxTotal As Double = 0
    Dim total As Double = 0
    Dim productSKU As String
    Dim checkoutCounter As Integer = 0
    Dim productStockAmount As Integer = 0
    Dim productStockCounterForSubExit As Integer = 0
    Dim inStoreString As String = "In_Store"

    Public UPCString As String
    Public UPCInt As Integer = 0
    Dim printOrderID As String = String.Empty
    Dim nextOrderID As Integer = 0
    Dim newOrderDetailID As Integer = 0


    ' Lists used for printing/orders
    Public SKUList As New List(Of String)  
    Public PriceList As New List(Of Double)
    Public QuantityList As New List(Of Integer)

    ' Set the initial cost of the product to 0
    Dim costOfProduct As Double = 0

    Public Function ProductPrice() As Double

        ' Store the entered quantity in the quantity variable
        quantity = CInt(txtQuantity.Text)


        ' Add to the Quantity String List
        QuantityList.Add(quantity)

        ' Create a query to grab the cost of the selected product by SKU from the click event when this function is called
        Dim getProductCost As New SqlCommand("SELECT retailCost FROM Products WHERE SKU = @SKU",
                                                 productConnection)

        getProductCost.Parameters.AddWithValue("@SKU", productSKU)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        productConnection.Open()

        Dim rowsAffected As Integer = getProductCost.ExecuteNonQuery()
        costOfProduct = getProductCost.ExecuteScalar()

        ' Close the connection
        productConnection.Close()

        ' Add to the Price String List
        PriceList.Add(costOfProduct)


        ' Multiply the cost of the selected product by the quantity and then pass it into a constant subTotalFinal variable
        subTotal += (costOfProduct * quantity)
        subTotalFinal += subTotal

        lblSubTotalAmount.Text = subTotalFinal.ToString("C2")

        ' Return the price of the product
        Return subTotal

    End Function

    Public Function CalculateTax() As Double

        ' Calculate the tax total
        taxTotal += (subTotal * TAX)

        ' Display the tax total
        lblTaxAmount.Text = taxTotal.ToString("C2")

        ' Return the tax total
        Return taxTotal
    End Function

    Public Function TotalCost() As Double

        ' Final Total Cost
        total = (subTotalFinal + taxTotal)

        ' Display the tax total
        lblTotalAmount.Text = total.ToString("C2")

        ' Return the final total
        Return total
    End Function

    '--------------------------------------------------------------------------------------------------------back button clicked 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Close the form.
        Me.Close()
        frmPrimaryForm.Show()
    End Sub
    '------------------------------------------------------------------------------------------------------------hot key button clicked 
    Private Sub btnHotKeys_Click(sender As Object, e As EventArgs) Handles btnHotKeys.Click
        ' Open the quickKeyMenu form
        frmQuickKey.Show()

    End Sub
    '---------------------------------------------------------------------------------------------------------------------------------------handles adding a new customer 
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        ' Open the newCustomer form
        frmCustomers.NewCustomerToolStripMenuItem.PerformClick()
        Me.Close()
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------form closing
    Private Sub checkoutForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Checkout Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPrimaryForm.Show()
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------------------opens up custom search
    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        POSCustomerSearch.ShowDialog()

    End Sub

    '--------------------------------------------------------------------------------------------------------------------------search through inventory
    Private Sub btnProductSearch_Click(sender As Object, e As EventArgs) Handles btnProductSearch.Click

        If (cmbSearchType.Text = "Name") Then
            ' Perform a search for a product name
            Try
                Me.ProductsTableAdapter.productNameSearchCheckout(Me.GEDataSet.Products, txtProduct.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid product name, please try again.")
            End Try
        ElseIf (cmbSearchType.Text = "SKU") Then
            Try
                Me.ProductsTableAdapter.SKUCheckoutSearch(Me.GEDataSet.Products, txtProduct.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid product SKU, please try again.")
            End Try
        ElseIf (cmbSearchType.Text = "UPC") Then
            Try
                Me.ProductsTableAdapter.FillBy(Me.GEDataSet.Products, txtProduct.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show("You can only search for a valid product UPC, please try again.")
            End Try
        End If

    End Sub

    '-----------------------------------------------------------------------------------------------------------------------form loader
    Private Sub frmCheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

        ' Disable the form controls
        Me.ControlBox = False

        ' Autofill in the employeeID for whichever employee signed into the program at the start
        txtEmployeeID.Text = employeeID

        txtCustomerID.Text = 1
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------setting employee ID
    Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged
        txtEmployeeID.Text = trying
    End Sub

    '-------------------------------------------------------------------------------------------------------------------checking the qunity
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        ' Reset the quantity and prevent it from being 0
        If txtQuantity.Text = "0" Or txtQuantity.Text = "" Then
            txtQuantity.Text = "1"
        End If


        'If txtCustomerID.Text = "" Then
        'MessageBox.Show("you must select a customer")
        'Exit Sub
        'End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------barcode changed


    '--------------------------------------------------------------------------------------------------------------------------------------invenotry
    Private Sub txtProduct_TextChanged(sender As Object, e As EventArgs) Handles txtProduct.TextChanged

    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick
        ' Check if the add to cart button has been clicked
        If e.ColumnIndex <> 4 Then
            Exit Sub
        End If

        ' Reset the (not final) product cost
        subTotal = 0




        'Dim rowIndex As Integer = 0

        'If txtBarcode.Text <> String.Empty Then

        'If UPCString.Length = 12 Then
        'For i As Integer = 0 To dgvProducts.Rows.Count
        'If (dgvProducts.SelectedCells(UPCInt).Value.ToString().Equals(UPCInt)) Then

        ' Set the new rowIndex
        'rowIndex = i
        'End If
        'Next
        'selectedRow = dgvProducts.Rows(rowIndex)
        'End If
        'txtBarcode.Text = String.Empty
        ' End If

        ' If UPCString = String.Empty Then
        selectedRow = dgvProducts.Rows(e.RowIndex)
        ' End If



        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        productSKU = selectedRow.Cells(0).Value.ToString()



        ' Create a query to get the product inventorycount
        Dim getStockAmount As New SqlCommand("SELECT inventoryCount FROM Inventory WHERE SKU = @SKU",
                                                 productConnection)

        getStockAmount.Parameters.AddWithValue("@SKU", productSKU)

        ' Open the connection
        productConnection.Open()

        getStockAmount.ExecuteNonQuery()
        productStockAmount = getStockAmount.ExecuteScalar()

        ' Close the connection
        productConnection.Close()

        If productStockAmount = 0 Then
            ' Display a message and reset the quantity
            MessageBox.Show("This product is out of stock.")
            productStockCounterForSubExit = 1
        ElseIf CInt(txtQuantity.Text) > productStockAmount Then
            ' Reset the quantity and display a message
            MessageBox.Show("There isn't enough stock to support this product purchase." & vbCrLf & "The current product stock is " & productStockAmount.ToString())
            productStockCounterForSubExit = 1
        End If

        If productStockCounterForSubExit = 1 Then
            productStockCounterForSubExit = 0
            Exit Sub
        End If


        ' Add to the SKU String List
        SKUList.Add(productSKU)


        ' Try to get the information for the selected product
        Try
            ' Check if the quantity entered is 1 or greater
            If txtQuantity.Text >= 1 Then
                ' Call the function ProductPrice to get the price of the selected product
                ProductPrice()
            Else
                ' Display an error message to the user
                MessageBox.Show("You must purchase at least one of a selected product to add the product to your cart, please try again.")
                Exit Sub
            End If
        Catch
            ' Display an error message to the user
            MessageBox.Show("You can only enter numeric quantities for a product, please try again.")
            Exit Sub
        End Try

        ' Call the function to calculate the total tax for the selected product
        CalculateTax()

        ' Call the function to calculate the total cost of the product (WITH TAX!)
        TotalCost()

        ' Display the information for the product in the listbox
        lbCart.Items.Add(productSKU.ToString().PadRight(15, " ") & vbTab & costOfProduct & vbTab & "           " & quantity)
    End Sub

    Public Function voidFunction()
        ' Reset the controls
        txtQuantity.Text = String.Empty
        'txtBarcode.Text = String.Empty
        txtCustomerID.Text = String.Empty
        lbCart.Items.Clear()
        lblDiscountAmount.Text = String.Empty
        lblSubTotalAmount.Text = String.Empty
        lblTaxAmount.Text = String.Empty
        lblTotalAmount.Text = String.Empty
        dgvProducts.Enabled = True
        btnRefresh.Enabled = True
        btnCustomerSearch.Enabled = True
        btnCheckout.Enabled = True
        cmbSearchType.Enabled = True
        txtProduct.Enabled = True
        txtQuantity.Enabled = True
        btnProductSearch.Enabled = True
        btnHotKeys.Enabled = True
        btnRemove.Enabled = True
        btnCheckout.Text = "Checkout"

        btnGiftCard.Enabled = False
        btnCash.Enabled = False
        btnCheck.Enabled = False
        btnCredit.Enabled = False
        btnPayPal.Enabled = False

        ' Reset values
        quantity = 0
        subTotal = 0
        subTotalFinal = 0
        discount = 0
        taxTotal = 0
        total = 0
        productSKU = String.Empty
        UPCString = String.Empty
        UPCInt = 0
        checkoutCounter = 0

        FinalTotalCost = 0
        DegradingTotalCost = 0

        ' Reset the initial cost of the product
        Dim costOfProduct As Double = 0

        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
    End Function

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

        If btnCheckout.Text = "Checkout" Then
            ' Ask the user if they are sure that they want to void the order
            If MessageBox.Show("Are you sure you want to void the order?", "Checkout Void",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Call the void function
                voidFunction()
            End If
        ElseIf btnCheckout.Text = "Complete Order" Then
            ' Do not ask to void and just call the void function
            voidFunction()
        End If
    End Sub

    '  Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs)
    ' Make sure the UPC is 12 digits in length
    ' If txtBarcode.Text.Length = 12 Then

    '        UPCString = txtBarcode.Text
    '
    'Integer.TryParse(txtBarcode.Text, UPCInt)

    'Dim arg = New DataGridViewCellEventArgs(Nothing, Nothing)
    '        dgvProducts_CellContentClick(Me.dgvProducts, arg)
    'End If
    'End Sub

    Private Sub checkoutButton_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        ' Ask the user if they are sure they want to close the current form
        If lblTotalAmount.Text <> "0" And lblTotalAmount.Text <> String.Empty Then
            If MessageBox.Show("Are you sure you want to checkout?", "Checkout",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If checkoutCounter = 0 Then
                    MessageBox.Show("Please select a payment option")


                    'Global total for use in other forms
                    FinalTotalCost = lblTotalAmount.Text

                    'Degrading total cost
                    DegradingTotalCost = FinalTotalCost


                    'Refreshes the table.
                    Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

                    'Enabling payment buttons
                    btnGiftCard.Enabled = True
                    btnCash.Enabled = True
                    btnCheck.Enabled = True
                    If DegradingTotalCost >= 20 Then
                        btnCredit.Enabled = True
                    End If
                    btnPayPal.Enabled = True
                    'Disabling further edit buttons
                    btnRemove.Enabled = False
                    btnHotKeys.Enabled = False
                    dgvProducts.Enabled = False
                    txtProduct.Clear()
                    txtProduct.Enabled = False
                    cmbSearchType.SelectedIndex = -1
                    cmbSearchType.Enabled = False
                    btnCheckout.Enabled = False
                    btnCustomerSearch.Enabled = False
                    btnRefresh.Enabled = False
                    txtQuantity.Clear()
                    txtQuantity.Enabled = False
                    btnProductSearch.Enabled = False

                    ' Increment the checkout counter
                    checkoutCounter = 1
                    btnCheckout.Text = "Complete Order"
                ElseIf checkoutCounter = 1 Then

                    MessageBox.Show("Order Complete.")
                    checkoutCounter = 0

                    ' Do the printing and adding the order to order details and orders here --------------------------


                    ' Create query to grab the max orderID + 1 (the order just made)------------------------
                    Dim getOrderIDForTable As New SqlCommand("SELECT max(orderID) + 1 FROM Orders", productConnection)

                    ' Open the connection
                    productConnection.Open()

                    getOrderIDForTable.ExecuteNonQuery()
                    nextOrderID = getOrderIDForTable.ExecuteScalar()

                    ' Create a coupon
                    Dim addOrder As New SqlCommand("INSERT INTO Orders (orderID, customerID, employeeID, purchaseLocation, orderDate, status)
                    VALUES(@orderID, @customerID, @employeeID, @purchaseLocation, @orderDate, @status)", productConnection)

                    ' Pass in the values from the controls
                    addOrder.Parameters.AddWithValue("@orderID", nextOrderID)
                    addOrder.Parameters.AddWithValue("@customerID", txtCustomerID.Text)
                    addOrder.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text)
                    addOrder.Parameters.AddWithValue("@purchaseLocation", inStoreString)
                    addOrder.Parameters.AddWithValue("@orderDate", DateTime.Now.ToString())
                    addOrder.Parameters.AddWithValue("@status", "1")

                    ' Run the query
                    addOrder.ExecuteNonQuery()

                    ' Close the connection
                    productConnection.Close()






                    ' Update InventoryCount in Inventory here---------------------------DO FOR EACH PRODUCT HERE USING THE SKUStringList-------------------------------
                    ' For Each SKU As String In SKUList
                    ' Create query to update inventory count based on SKU
                    'Dim updateInventory As New SqlCommand("UPDATE Inventory SET inventoryCount = @inventoryCount WHERE SKU = @SKU", productConnection)

                    ' Pass in parameter using the list
                    'updateInventory.Parameters.AddWithValue("@SKU", SKU)

                    ' Open the connection to the database and pass in the information
                    'productConnection.Open()
                    'updateInventory.ExecuteNonQuery()

                    ' Close the connection
                    'productConnection.Close()
                    'Next



                    '
                    '
                    'DONE
                    '
                    ' Need to get max + 1 order detail ID for this below--
                    Dim getMaxAndNextOrderDetailID As New SqlCommand("SELECT max(orderDetailID) + 1 FROM Order_Details", productConnection)

                    ' Open the connection
                    productConnection.Open()
                    MessageBox.Show(getMaxAndNextOrderDetailID.ExecuteScalar)
                    getMaxAndNextOrderDetailID.ExecuteNonQuery()

                    ' Pass in Order Detail ID to use for creating a new order detail -------------------------------------vvvv
                    newOrderDetailID = getMaxAndNextOrderDetailID.ExecuteScalar()

                    ' Close the connection
                    productConnection.Close()






                    'Dim quantityArray() As String
                    '
                    ' For Each Quantityy As String In QuantityList
                    ' quantityArray
                    ' Next



                    'Dim joinedAllLists = From SKU In SKUList
                    'Join Quantityy In QuantityList
                    'On SKU.ToString Equals Quantityy.ToString
                    'Join Price In PriceList
                    'On Quantityy.ToString Equals Price
                    'Select Case New With {SKUList, PriceList, QuantityList}


                    ' Add query for Order Details here----------------------

                    For i As Integer = 0 To SKUList.Count - 1
                        ' Create query to add data into order details
                        Dim addData As New SqlCommand("INSERT INTO Order_Details (orderDetailID, orderID, SKU, quantity, price, paid)
                    VALUES(@orderDetailID, @orderID, @SKU, @quantity, @price, @paid)", productConnection)

                        ' Pass in parameter using the list
                        addData.Parameters.AddWithValue("@orderDetailID", newOrderDetailID.ToString)
                        addData.Parameters.AddWithValue("@orderID", nextOrderID.ToString)
                        addData.Parameters.AddWithValue("@SKU", SKUList.Item(i))
                        addData.Parameters.AddWithValue("@quantity", QuantityList.Item(i))
                        addData.Parameters.AddWithValue("@price", PriceList.Item(i))
                        addData.Parameters.AddWithValue("@paid", "1")


                        ' Open the connection to the database and pass in the information
                        productConnection.Open()
                        addData.ExecuteNonQuery()

                        ' Close the connection
                        productConnection.Close()

                        ' Increment the Order Detail ID to the next ID number
                        newOrderDetailID += 1
                    Next








                    If MessageBox.Show("Would you like to print a receipt?", "Order Receipt",
                    MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        ' Open print dialog window to print
                        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            ' Set printer settings
                            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                            ' Print Receipt
                            PrintDocument1.Print()
                        End If
                    End If

                    ' AFTER EVERYTHING ABOVE IS DONE, CALL VOID TO CLEAR THE ENTIRE FORM -------------------------------------------------------
                    btnVoid.PerformClick()
                End If
            End If
        Else
            MessageBox.Show("You cannot checkout with no products.")
        End If
    End Sub

    Private Sub btnCredit_Click(sender As Object, e As EventArgs) Handles btnCredit.Click

        ' Change the title of the CCCPayment form
        frmCCCPayment.lblTitle.Text = "Credit/Debit Card"

        If frmCCCPayment.lblTitle.Text = "Credit/Debit Card" Then
            frmCCCPayment.lblTitle.Location = New Point(100, 37)
        End If

        frmCCCPayment.txtTotalCost.Text = DegradingTotalCost

        frmCCCPayment.nudPayment.Minimum = 20
        frmCCCPayment.nudPayment.Maximum = DegradingTotalCost

        'Displays CCCPayment
        frmCCCPayment.Show()
    End Sub

    Private Sub cmbSearchType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchType.SelectedIndexChanged
        If (cmbSearchType.Text <> String.Empty) Then
            txtProduct.Enabled = True
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Refreshes the table.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Try
            If lbCart.SelectedIndex > -1 Then
                Dim costOfProductSelected As Double = 0
                productSKU = String.Empty
                Dim selectedProduct As String = String.Empty
                Dim subTotal2 As Double = 0

                Dim newQuantity As Integer = 0

                selectedProduct = productSKU

                Dim selectedLength As Integer = selectedProduct.Length

                Dim newProductSubstringed As String = selectedProduct.Substring(selectedLength)



                'Dim removeQuantity As Double = CInt(selectedProduct.Substring(0, selectedProduct.IndexOf("           ")))
                Dim newSKU As String = lbCart.SelectedItem.ToString().Split("           ")(0)



                ' Create a query to grab the cost of the selected product by SKU from the click event when this function is called
                Dim removeCostAmount As New SqlCommand("SELECT retailCost FROM Products WHERE SKU = @SKU",
                                                         productConnection)

                removeCostAmount.Parameters.AddWithValue("@SKU", newSKU)

                ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
                productConnection.Open()

                removeCostAmount.ExecuteNonQuery()

                costOfProductSelected = removeCostAmount.ExecuteScalar()


                newQuantity = lbCart.SelectedItem.ToString.Split("           ").Last



                ' Close the connection
                productConnection.Close()

                If subTotalFinal > 0 Then

                    If subTotalFinal > 0 Then
                        ' Update the totals and redisplay them to the user
                        subTotalFinal -= (costOfProductSelected * newQuantity)



                        ' Remove a selected item from the user's Cart
                        lbCart.Items.RemoveAt(lbCart.SelectedIndex)


                        taxTotal -= (costOfProductSelected * TAX)

                        total = (subTotalFinal + taxTotal)


                        If subTotalFinal < 0 Or taxTotal < 0 Or total < 0 Then
                            subTotalFinal = 0
                            taxTotal = 0
                            total = 0
                        End If

                        lblSubTotalAmount.Text = subTotalFinal.ToString
                        lblTaxAmount.Text = taxTotal.ToString
                        lblTotalAmount.Text = total.ToString
                    End If
                Else
                    MessageBox.Show("Your cart is empty, you cannot remove any products from a empty cart.")
                End If
            End If
        Catch
            MessageBox.Show("IF you wish to remove products from your cart, select the product from the right hand side list and then click the ""Remove"" button.")
        End Try
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        ' Change the title of the CCCPayment form
        frmCCCPayment.lblTitle.Text = "Check"

        frmCCCPayment.txtTotalCost.Text = DegradingTotalCost
        frmCCCPayment.nudPayment.Maximum = DegradingTotalCost
        'Displays CCCPayment
        frmCCCPayment.Show()
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click

        ' Change the title of the CCCPayment form
        frmCCCPayment.lblTitle.Text = "Cash"

        frmCCCPayment.txtTotalCost.Text = DegradingTotalCost
        frmCCCPayment.nudPayment.Maximum = DegradingTotalCost
        'Displays CCCPayment
        frmCCCPayment.Show()
    End Sub

    Private Sub btnPayPal_Click(sender As Object, e As EventArgs) Handles btnPayPal.Click
        ' Change the title of the CCCPayment form
        frmCCCPayment.lblTitle.Text = "PayPal"

        frmCCCPayment.txtTotalCost.Text = DegradingTotalCost
        frmCCCPayment.nudPayment.Maximum = DegradingTotalCost
        frmCCCPayment.cbEmail.Visible = True
        frmCCCPayment.lblEmail.Visible = True
        frmCCCPayment.nudPayment.Location = New Point(150, 167)
        frmCCCPayment.lblPaymentAmount.Location = New Point(94, 168)
        frmCCCPayment.lblEmail.Location = New Point(107, 138)
        frmCCCPayment.cbEmail.Location = New Point(150, 132)
        'Displays CCCPayment
        frmCCCPayment.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim intVerticalPosition As Integer = 0          ' Vertical position for printing
        Dim finalVerticalPosition As Integer = 0        ' Final vertical position for printing

        ' Print Confirmation Report Header
        e.Graphics.DrawString("Receipt", New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 150, 10)

        ' Print Time and Date
        e.Graphics.DrawString("Date and Time: " & Now.ToString(), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 10, 38)

        ' Print Column Heading for Products, Price, and Quantity
        e.Graphics.DrawString(String.Format("{0, 5} ", "Products"), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 10, 66)
        e.Graphics.DrawString(String.Format("{0, 5} ", "Price"), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 160, 66)
        e.Graphics.DrawString(String.Format("{0, 5} ", "Qty."), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 290, 66)

        intVerticalPosition = 90

        ' DO FOR EACH LIST BUT CHANGE THE X AXIS SO THEY CAN ALL DO THIS NO MATTER WHAT

        For Each SKU As String In SKUList


            ' Print SKU's
            e.Graphics.DrawString(String.Format("{0, 3} ", SKU), New Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 10, intVerticalPosition)

            intVerticalPosition += 28

        Next

        intVerticalPosition = 90

        For Each Price As String In PriceList
            ' Print Price
            e.Graphics.DrawString(String.Format("{0, 3} ", Price), New Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 160, intVerticalPosition)

            intVerticalPosition += 28
        Next

        intVerticalPosition = 90

        For Each Quantity As String In QuantityList
            ' Print Quantity
            e.Graphics.DrawString(String.Format("{0, 3} ", Quantity), New Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 290, intVerticalPosition)

            intVerticalPosition += 28

            finalVerticalPosition = intVerticalPosition
        Next

        ' Print the Total
        e.Graphics.DrawString(String.Format("{0, 3} ", "Total: " & FinalTotalCost), New Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 10, finalVerticalPosition + 64)

        finalVerticalPosition += 14


        ' Create query to grab the max orderID (the order just made)
        Dim getOrderID As New SqlCommand("SELECT max(orderID) FROM Orders", productConnection)

        ' Open the connection
        productConnection.Open()

        getOrderID.ExecuteNonQuery()
        printOrderID = getOrderID.ExecuteScalar()

        ' Close the connection
        productConnection.Close()


        e.Graphics.DrawString(String.Format("{0, 3} ", "Order Number: " & printOrderID), New Font("Courier New", 9, FontStyle.Regular), Brushes.Black, 10, finalVerticalPosition)
    End Sub
End Class