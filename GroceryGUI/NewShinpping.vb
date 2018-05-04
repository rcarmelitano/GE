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
        TextBox1.Text = 3
        TextBox2.Text = 5

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

        CheckedListBox1.DataSource = table2
        CheckedListBox1.DisplayMember = "addresses"
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
		frmNewShipping.txtOrderID.Text = TextBox1.Text
		frmNewShipping.ShowDialog()

	End Sub
End Class