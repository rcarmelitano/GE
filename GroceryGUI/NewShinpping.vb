Imports System.Data
Imports System.Data.SqlClient

Public Class NewShinpping

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    '-----------------------------------------------------------------------------------------------binding sources
    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    '--------------------------------------------------------------------------------------------------form loader
    Private Sub NewShinpping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtshipmentID.Visible = False
        txtShippmentDetailID.Visible = False
        TextBox1.Text = 3
        TextBox2.Text = 5
        RadioButton2.Checked = True
        'testing value 
        Dim orderID As Integer = 5

        'load datagrid based on orderID
        Me.Order_DetailsTableAdapter.orderHistory(Me.GEDataSet.Order_Details, orderID)

        'checking to see if the datagrid is filled
        If Order_DetailsDataGridView.CurrentCell Is Nothing Then
            MessageBox.Show("are you done")
        End If

        'populating combox box
        Dim command As New SqlCommand("select * from Shippers", something)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "shippername"


        Dim command2 As New SqlCommand("select shippingAddress1 + ',' + shippingAddress2 + ',' + shippingCity + ',' + shippingState + ',' +  shippingZip as [addresses] from Shipping_Addresses where customerID = @customer", something)
        command2.Parameters.AddWithValue("@customer", TextBox1.Text)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)

        ListBox1.DataSource = table2
        ListBox1.DisplayMember = "addresses"
        ' CheckedListBox1.ValueMember = "shippingAddressID"

        ' Disable the form controls
        Me.ControlBox = False
    End Sub
    '--------------------------------------------------------------------------------------------------------------------------------for loop for whole order
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        For i As Integer = 0 To Order_DetailsDataGridView.Rows.Count() - 1
            Dim rowalreadyExist As Boolean = False
            Dim check As Boolean
            check = True
            Order_DetailsDataGridView.Rows(i).Cells(0).Value = check
        Next

        Order_DetailsDataGridView.Enabled = False

    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------for loop for split order 
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        For i As Integer = 0 To Order_DetailsDataGridView.Rows.Count() - 1
            Dim rowalreadyExist As Boolean = False
            Dim check As Boolean
            check = False
            Order_DetailsDataGridView.Rows(i).Cells(0).Value = check
        Next

        Order_DetailsDataGridView.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmNewAddress.txtOrderID.Text = TextBox1.Text
        frmNewAddress.ShowDialog()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim command2 As New SqlCommand("SELECT * FROM dbo.Shipping_Methods INNER JOIN dbo.Shippers ON dbo.Shipping_Methods.shipperID = shippers.shipperID WHERE shipperName = @Name", something)
        command2.Parameters.AddWithValue("@Name", ComboBox1.Text)
        Dim adapter2 As New SqlDataAdapter(command2)
        Dim table2 As New DataTable
        adapter2.Fill(table2)

        ComboBox2.DataSource = table2
        ComboBox2.DisplayMember = "title"
        something.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim total As Double
        Dim command3 As New SqlCommand("SELECT price FROM dbo.Shipping_Methods WHERE dbo.Shipping_Methods.title = @method", something)
        command3.Parameters.AddWithValue("@method", ComboBox2.Text)

        Try
            something.Open()
            total = command3.ExecuteScalar
            TextBox4.Text = total.ToString("c2")
        Catch ex As Exception

        End Try
        something.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim shipmentId As Integer
        Dim command As New SqlCommand("SELECT MAX(shipmentId) + 1 FROM shipment", something)

        Try
            something.Open()
            shipmentId = command.ExecuteScalar
            txtshipmentID.Text = shipmentId
        Catch ex As Exception

        End Try
        something.Close()

        Dim shipdetailid As Integer
        Dim command2 As New SqlCommand("SELECT MAX(shipmentDetailsID) + 1 FROM dbo.Shipment_Details", something)


        Try
            something.Open()
            shipdetailid = command2.ExecuteScalar
            txtShippmentDetailID.Text = shipdetailid
        Catch ex As Exception

        End Try

    End Sub

End Class