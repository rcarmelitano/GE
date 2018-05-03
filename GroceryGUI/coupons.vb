' Include imports for the form
Imports System.Data.SqlClient
Imports System.Data

Public Class frmCoupons

    ' Create a new connection to the database for this form
    Dim couponsConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        ' Close the form
        Me.Close()
        'Display the promotions form
        frmPromotion.Show()
    End Sub

    Private Sub coupons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ask the user if they are sure they want to close the current form
        If MessageBox.Show("Are you sure you want to cancel?", "Coupon Cancellation",
           MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        Else
            frmPromotion.Show()
        End If
    End Sub

    Private Sub ViewCouponsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewCoupons.Click
        ' Show the coupons view form
        frmCouponsView.Show()
    End Sub

    Private Sub frmCoupons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
        Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        'TODO: This line of code loads data into the 'GEDataSet.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.GEDataSet.Promotions)

        ' Converts the date and time of the datetimepicker to a usable string format
        dtpStartDate.Format = DateTimePickerFormat.Custom
        dtpStartDate.CustomFormat = "MM/dd/yyyy"
        dtpEndDate.Format = DateTimePickerFormat.Custom
        dtpEndDate.CustomFormat = "MM/dd/yyyy"

        ' Do not let the date be before the current date
        dtpStartDate.MinDate = DateAndTime.Now()
        dtpEndDate.MinDate = DateAndTime.Now().AddDays(1)

        ' Get the max id number currently in the database and then add 1
        Dim couponID As Integer = 0
        Dim getMaxCouponIDAndIncrement As New SqlCommand("select max(couponID) + 1 from Coupons", couponsConnection)

        ' Fill the couponID textbox with the next value through the use of the getMaxCouponIDAndIncrement command above
        couponsConnection.Open()
        Dim rowsAffected As Integer = getMaxCouponIDAndIncrement.ExecuteNonQuery()
        couponID = getMaxCouponIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtCouponID.Text = couponID

    End Sub

    Private Sub ViewPromotionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuViewPromotions.Click
        ' Display the promotions form
        frmPromotionsView.Show()
    End Sub

    Private Sub ViewDiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewDiscounts.Click
        ' Display the discounts form
        frmDiscountsView.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        ' Tell the user what to do
        MessageBox.Show("To create a coupon, fill out the information needed below." & vbCrLf & "The tabs allow you to add a Promotion ID for the coupon, as well as a Discount ID." & vbCrLf & vbCrLf & "Both a Promotion ID and a Discount ID are required to create a coupon.")
    End Sub

    Private Sub btnDiscountIDSearch_Click(sender As Object, e As EventArgs) Handles btnDiscountIDSearch.Click
        ' Perform a Discount ID Search
        Try
            Me.DiscountsTableAdapter.discountID(Me.GEDataSet.Discounts, CType(txtDiscountIDSearch.Text, Integer))
        Catch ex As System.Exception
            MessageBox.Show("You can only search for a valid discount id. Please try again.")
            txtDiscountID.Clear()
            'TODO: This line of code loads data into the 'GEDataSet.Discounts' table. You can move, or remove it, as needed.
            Me.DiscountsTableAdapter.Fill(Me.GEDataSet.Discounts)
        End Try
    End Sub

    Private Sub btnAddPromotion_Click(sender As Object, e As EventArgs)
        Try
            ' Store the promotion ID in the textbox and make it read only unless the user hits the clear button, allowing for search again
            txtPromotionID.Text = dgvPromotions.CurrentCell.Value.ToString()
        Catch
            MessageBox.Show("Please only add valid Promotion ID's")
        End Try
    End Sub

    Private Sub btnAddDiscount_Click(sender As Object, e As EventArgs)
        Try
            ' Store the promotion ID in the textbox and make it read only unless the user hits the clear button, allowing for search again
            txtDiscountID.Text = dgvDiscounts.CurrentCell.Value.ToString()
        Catch
            MessageBox.Show("Please only add valid Discount ID's")
        End Try
    End Sub

    Private Sub dtpStartDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpStartDate.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub dtpEndDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpEndDate.KeyDown
        e.SuppressKeyPress = True
    End Sub

    Private Sub btnPromotionTitleSearch_Click(sender As Object, e As EventArgs) Handles btnPromotionTitleSearch.Click
        ' Perform a search for promotion ID
        Try
            Me.PromotionsTableAdapter.searchPromotionName(Me.GEDataSet.Promotions, txtPromotionTitle.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("Please only enter a valid Promotion ID.")
        End Try
    End Sub

    Private Sub btnCreateCoupon_Click(sender As Object, e As EventArgs) Handles btnCreateCoupon.Click
        If txtDiscountID.Text <> String.Empty And txtPromotionID.Text <> String.Empty Then

            ' Close the connection
            couponsConnection.Close()

            ' Create a coupon
            Dim addCoupon As New SqlCommand("INSERT INTO Coupons (couponID, discountID, promotionID, couponStartDate, couponEndDate, description)
            VALUES(@couponID, @discountID, @promotionID, @couponStartDate, @couponEndDate, @description)", couponsConnection)

            ' Pass in the values from the controls
            addCoupon.Parameters.AddWithValue("@couponID", txtCouponID.Text)
            addCoupon.Parameters.AddWithValue("@discountID", txtDiscountID.Text)
            addCoupon.Parameters.AddWithValue("@promotionID", txtPromotionID.Text)
            addCoupon.Parameters.AddWithValue("@couponStartDate", dtpStartDate.Text)
            addCoupon.Parameters.AddWithValue("@couponEndDate", dtpEndDate.Text)
            addCoupon.Parameters.AddWithValue("@description", txtDescription.Text)

            ' Open the connection
            couponsConnection.Open()

            ' Run the query
            addCoupon.ExecuteNonQuery()

            ' Close the connection
            couponsConnection.Close()

            ' Close the form and display the primary form
            Me.Close()
            frmPrimaryForm.Show()

        Else
            MessageBox.Show("You must enter all required information in order to create a coupon. Please try again.")
        End If
    End Sub

    Private Sub dgvPromotions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPromotions.CellContentClick
        If e.ColumnIndex <> 3 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvPromotions.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtPromotionID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub dgvDiscounts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiscounts.CellContentClick
        If e.ColumnIndex <> 5 Then
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow
        selectedRow = dgvDiscounts.Rows(e.RowIndex)

        ' Grab the selected ID and stick it in the txtOrderDetailsID textbox
        txtDiscountID.Text = selectedRow.Cells(0).Value.ToString()
    End Sub
End Class