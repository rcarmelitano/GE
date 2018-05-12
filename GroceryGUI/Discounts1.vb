Imports System.Data
Imports System.Data.SqlClient
Public Class Discounts1
    'Connect to the DB
    Dim DisConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub Discounts1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discount_Type' table. You can move, or remove it, as needed.
        Me.Discount_TypeTableAdapter.Fill(Me.GEDataSet.Discount_Type)
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        'Hide bogo stuff
        txtBuy.Hide()
        txtGet.Hide()
        lblBuy.Hide()
        lblGet.Hide()
        'Hide flat rate stuff
        txtAmount.Hide()
        lblAmount.Hide()
        'Figure out the id of the next campaign
        Dim disID As Integer = 0
        Dim getdisID As New SqlCommand("select max(discountID) + 1 from Discounts", DisConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        DisConnection.Open()
        Dim rowsAffected As Integer = getdisID.ExecuteNonQuery()
        disID = getdisID.ExecuteScalar()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedValue = 1 Then
            txtBuy.Show()
            txtGet.Show()
            lblBuy.Show()
            lblGet.Show()
            lblAmount.Hide()
            txtAmount.Hide()
        Else
            txtBuy.Hide()
            txtGet.Hide()
            lblBuy.Hide()
            lblGet.Hide()
            lblAmount.Show()
            txtAmount.Show()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
        frmPrimaryForm.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If MessageBox.Show("          The Marketing Campaign has been created" & vbCrLf & "    Do you want to create another?", "Return",
                          MessageBoxButtons.YesNo) = DialogResult.No Then
            'close connection
            DisConnection.Close()
            'Add values 
            Dim addDiscount As New SqlCommand("INSERT INTO Discounts (discountID,discountTypeID,buyOne,getOne,discountAmount)
                                                                        VALUES(@discountID,@discountTypeID,@buyOne,@getOne,@discountAmount)", DisConnection)

            addDiscount.Parameters.AddWithValue("@discountTypeID", ComboBox1.SelectedValue)
            addDiscount.Parameters.AddWithValue("@buyOne", txtBuy.Text)
            addDiscount.Parameters.AddWithValue("@getOne", txtGet.Text)
            addDiscount.Parameters.AddWithValue("@discountAmount", txtAmount.Text)
            ' Open the connection and run the query

            DisConnection.Open()
            addDiscount.ExecuteNonQuery()

            'Exit
            Me.Close()
            frmPrimaryForm.Show()
        Else
            'close connection
            DisConnection.Close()
            'Add values 
            Dim addDiscount As New SqlCommand("INSERT INTO Discounts (discountID,discountTypeID,buyOne,getOne,discountAmount)
                                                                        VALUES(@discountID,@discountTypeID,@buyOne,@getOne,@discountAmount)", DisConnection)

            addDiscount.Parameters.AddWithValue("@discountTypeID", ComboBox1.SelectedValue)
            addDiscount.Parameters.AddWithValue("@buyOne", txtBuy.Text)
            addDiscount.Parameters.AddWithValue("@getOne", txtGet.Text)
            addDiscount.Parameters.AddWithValue("@discountAmount", txtAmount.Text)
            DisConnection.Open()
            addDiscount.ExecuteNonQuery()
            'Clear forms
            txtAmount.Text = ""
            txtBuy.Text = ""
            txtDisName.Text = ""
            txtGet.Text = ""
            'Figure out new campaign ID 
            'Figure out the id of the next campaign
            Dim disID As Integer = 0
            Dim getDisID As New SqlCommand("select max(discountID) + 1 from Discounts", DisConnection)
            'Figure out the new campaign id
            disID = getDisID.ExecuteScalar()
        End If
    End Sub
End Class