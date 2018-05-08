﻿' Include imports for the form
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

    Public UPCString As String
    Public UPCInt As Integer = 0

    ' Set the initial cost of the product to 0
    Dim costOfProduct As Double = 0

    Public Function ProductPrice() As Double

        ' Store the entered quantity in the quantity variable
        quantity = CInt(txtQuantity.Text)

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
        ' Perform a search for a product name
        Try
            Me.ProductsTableAdapter.productNameSearchCheckout(Me.GEDataSet.Products, txtProduct.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("You can only search for a valid product name, please try again.")
        End Try
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------form loader
    Private Sub frmCheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)

        ' Disable the form controls
        Me.ControlBox = False

        ' Autofill in the employeeID for whichever employee signed into the program at the start
        txtEmployeeID.Text = employeeID
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

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        ' Ask the user if they are sure that they want to void the order
        If MessageBox.Show("Are you sure you want to void the order?", "Checkout Void",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            ' Reset the controls
            txtQuantity.Text = String.Empty
            txtBarcode.Text = String.Empty
            txtCustomerID.Text = String.Empty
            lbCart.Items.Clear()
            lblDiscountAmount.Text = String.Empty
            lblSubTotalAmount.Text = String.Empty
            lblTaxAmount.Text = String.Empty
            lblTotalAmount.Text = String.Empty

            ' Reset values
            quantity = 0
            subTotal = 0
            subTotalFinal = 0
            discount = 0
            taxTotal = 0
            total = 0

            'TODO: This line of code loads data into the 'GEDataSet.Products' table. You can move, or remove it, as needed.
            Me.ProductsTableAdapter.Fill(Me.GEDataSet.Products)
        End If
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        ' Make sure the UPC is 12 digits in length
        If txtBarcode.Text.Length = 12 Then

            UPCString = txtBarcode.Text

            Integer.TryParse(txtBarcode.Text, UPCInt)

            Dim arg = New DataGridViewCellEventArgs(Nothing, Nothing)
            dgvProducts_CellContentClick(Me.dgvProducts, arg)
        End If
    End Sub

    Private Sub checkoutButton_Click(sender As Object, e As EventArgs) Handles checkoutButton.Click
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to checkout?", "Checkout Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            MessageBox.Show("Please select a payment option")

            'Enabling payment buttons
            btnGiftCard.Enabled = True
            btnCash.Enabled = True
            btnCheck.Enabled = True
            btnCredit.Enabled = True
            btnPayPal.Enabled = True
            'Disabling further edit buttons
            btnVoid.Enabled = False
            btnRemove.Enabled = False
            btnHotKeys.Enabled = False

        End If

    End Sub

    Private Sub btnCredit_Click(sender As Object, e As EventArgs) Handles btnCredit.Click

    End Sub
End Class