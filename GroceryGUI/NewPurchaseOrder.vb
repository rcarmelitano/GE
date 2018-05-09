Imports System.Data.SqlClient
Imports System.Data

Public Class NewPurchaseOrder

    Dim purchaseOrderID As String

    ' Create a new connection to the database for this form
    Dim PurchaseOrderConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub NewPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.GEDataSet.Suppliers)
        ' Converts the date and time of the datetimepicker to a usable string format
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "MM/dd/yyyy"

        ' Do not let the date be before the current date
        dtpDate.MinDate = DateAndTime.Now()
        dtpDate.MaxDate = DateAndTime.Now()

        ' Get the max id number currently in the database and then add 1
        Dim purchaseOrderID As Integer = 0
        Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(purchaseOrderID) + 1 from Purchase_Order", PurchaseOrderConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        PurchaseOrderConnection.Open()
        getMaxReturnIDAndIncrement.ExecuteNonQuery()
        purchaseOrderID = getMaxReturnIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtPurchaseOrderID.Text = purchaseOrderID

        ' Get rid of form control buttons
        Me.ControlBox = False
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If txtPurchaseOrderID.Text <> String.Empty And cmbStatusID.Text <> String.Empty And txtSupplierID.Text <> String.Empty And txtOrderTotal.Text <> String.Empty Then

            If MessageBox.Show("Do you wish to continue and save your changes?", "Purchase Order Placement",
            MessageBoxButtons.YesNo) = DialogResult.Yes Then

                PurchaseOrderConnection.Close()


                ' Add the new return and set the values entered to the attributes of the returns table
                Dim addPurchaseOrder As New SqlCommand("INSERT INTO Purchase_Order (purchaseOrderID, supplierID, orderTotal, orderDate, statusID)
                                                VALUES(@purchaseOrderID, @supplierID, @orderTotal, @orderDate, @statusID)", PurchaseOrderConnection)
                Dim statusINT As Integer = 0

                If cmbStatusID.SelectedIndex = 0 Then
                    statusINT = "6"
                ElseIf cmbStatusID.SelectedIndex = 1 Then
                    statusINT = "7"
                ElseIf cmbStatusID.SelectedIndex = 2 Then
                    statusINT = "8"
                End If

                addPurchaseOrder.Parameters.AddWithValue("@purchaseOrderID", txtPurchaseOrderID.Text)
                addPurchaseOrder.Parameters.AddWithValue("@supplierID", txtSupplierID.Text)
                addPurchaseOrder.Parameters.AddWithValue("@orderTotal", txtOrderTotal.Text)
                addPurchaseOrder.Parameters.AddWithValue("@orderDate", dtpDate.Text)
                addPurchaseOrder.Parameters.AddWithValue("@statusID", statusINT)

                ' Open the connection and run the query
                PurchaseOrderConnection.Open()
                addPurchaseOrder.ExecuteNonQuery()

                ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
                PurchaseOrderConnection.Close()

                purchaseOrderID = txtPurchaseOrderID.Text
                NewPurchaseOrderDetails.txtPurchaseOrderID.Text = purchaseOrderID

                NewPurchaseOrderDetails.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Please fill out all of the information to continue the process.")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex <> 2 Then
            Exit Sub
        End If

        Dim selectedSupplierRow As DataGridViewRow
        selectedSupplierRow = DataGridView1.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtSupplierID.Text = selectedSupplierRow.Cells(0).Value.ToString()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to cancel placing a purchase order?", "Cancel Purchase Order",
   MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            frmPurchaseOrders.Show()
        End If
    End Sub
End Class