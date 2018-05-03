Imports System.Data
Imports System.Data.SqlClient

Public Class NewShinpping

    Dim something As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")


    Public Sub showmyrecords()
        Dim command2 As New SqlCommand("select * from Shipping_Addresses", something)
        Dim adapter As New SqlDataAdapter(command2)
        Dim table As New DataTable
        adapter.Fill(table)
        Dim myrow As DataRow

        For Each myrow In table.Rows
            ListView1.Items.Add(myrow.Item(0))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myrow.Item(1))
        Next
    End Sub

    '-----------------------------------------------------------------------------------------------binding sources
    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GEDataSet)

    End Sub

    '--------------------------------------------------------------------------------------------------form loader
    Private Sub NewShinpping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Order_Details' table. You can move, or remove it, as needed.
        'Me.Order_DetailsTableAdapter.Fill(Me.GEDataSet.Order_Details

        TextBox1.Text = 2
        TextBox2.Text = 5

        'testing value 
        Dim orderID As Integer = 5

        showmyrecords()


        '-------------------------------------------------------------------------------load datagrid based on orderID
        Me.Order_DetailsTableAdapter.orderHistory(Me.GEDataSet.Order_Details, orderID)

        '---------------------------------------------------------------checking to see if the datagrid is filled
        If Order_DetailsDataGridView.CurrentCell Is Nothing Then
            MessageBox.Show("are you done")
        End If

        '------------------------------------------------------------------------populating combox box
        Dim command As New SqlCommand("select * from Shippers", something)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "shipperName"



    End Sub
End Class