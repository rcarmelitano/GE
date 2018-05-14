Imports System.Data
Imports System.Data.SqlClient
Public Class frmNewShrinkage
    Dim shrinkageConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\GE.mdf;Integrated Security=True")
    Private Sub frmNewShrinkage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GEDataSet.Shippers' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.GEDataSet.Inventory)
        Me.ControlBox = False

        Dim shrinkageID As Integer = 0
        Dim getMaxReturnIDAndIncrement As New SqlCommand("select max(shrinkageID) + 1 from Shrinkage", shrinkageConnection)

        ' Fill the returnID textbox with the next value through the use of the getMaxReturnIDAndIncrement command above
        shrinkageConnection.Open()
        Dim rowsAffected As Integer = getMaxReturnIDAndIncrement.ExecuteNonQuery()
        shrinkageID = getMaxReturnIDAndIncrement.ExecuteScalar()
        ' Display the new ID
        txtShrinkageID.Text = shrinkageID

        txtEmployeeID.Text = 4


        ' Converts the date and time of the datetimepicker to a usable string format
        dtpShrinkDate.Format = DateTimePickerFormat.Custom
        dtpShrinkDate.CustomFormat = "MM/dd/yyyy hh:mm"
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to cancel adding Shrinkage?", "Shrinkage Cancellation",
                        MessageBoxButtons.YesNo) = DialogResult.Yes Then
            frmShrinkage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick
        Dim selectedrow As DataGridViewRow
        selectedrow = dgvInventory.Rows(e.RowIndex)

        If e.ColumnIndex <> 3 Then
            Exit Sub
        End If

        Dim tempQuantity As Integer = 0
        tempQuantity = selectedrow.Cells(2).Value

        txtQuantityStorage.Text = tempQuantity

        If tempQuantity = 0 Then
            MessageBox.Show("This item already has no stock, and can't be added as shrinkage.")
            Exit Sub
        End If

        txtSKU.Text = selectedrow.Cells(1).Value.ToString()
        txtStatusID.Enabled = True
        txtQuantity.Enabled = True
        txtDetails.Enabled = True
        txtUnit.Enabled = True
        btnAddToShrinkage.Enabled = True



    End Sub


    Private Sub btnAddToShrinkage_Click(sender As Object, e As EventArgs) Handles btnAddToShrinkage.Click
        If txtQuantity.Text < txtQuantityStorage.Text Then
            If txtStatusID.Text <> "" And txtQuantity.Text <> "" And txtDetails.Text <> "" And txtUnit.Text <> "" Then


                shrinkageConnection.Close()


                Dim dateString As String = String.Empty
                dateString = DateTime.Now


                ' Add the new return and set the values entered to the attributes of the returns table
                Dim addShrinkage As New SqlCommand("INSERT INTO Shrinkage (shrinkageID, employeeID, SKU, statusID, quantity, shrinkDate, details, unit)
                                                VALUES(@shrinkageID, @employeeID, @SKU, @statusID, @quantity, @shrinkDate, @details, @unit)", shrinkageConnection)

                addShrinkage.Parameters.AddWithValue("@shrinkageID", txtShrinkageID.Text)
                addShrinkage.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text)
                addShrinkage.Parameters.AddWithValue("@SKU", txtSKU.Text)
                addShrinkage.Parameters.AddWithValue("@statusID", txtStatusID.Text)
                addShrinkage.Parameters.AddWithValue("@quantity", txtQuantity.Text)
                addShrinkage.Parameters.AddWithValue("@shrinkDate", dateString)
                addShrinkage.Parameters.AddWithValue("@details", txtDetails.Text)
                addShrinkage.Parameters.AddWithValue("@unit", txtUnit.Text)

                Dim newInventory As Integer
                newInventory = txtQuantityStorage.Text - txtQuantity.Text

                Try
                    shrinkageConnection.Open()
                    addShrinkage.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Adding shrinkage has failed due to an unknown error.")
                    Exit Sub
                End Try
                shrinkageConnection.Close()


                ''NEED TO DO; fix this so that it updates inventory with the new inventory count 'newInventory'
                Dim updateInventory As New SqlCommand("UPDATE Inventory SET (inventoryCount = @inventoryCount) WHERE SKU = @SKU", shrinkageConnection)

                updateInventory.Parameters.AddWithValue("@inventoryCount", newInventory.ToString)
                updateInventory.Parameters.AddWithValue("@SKU", txtSKU.Text)

                Try
                    shrinkageConnection.Open()
                    updateInventory.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Adding shrinkage has failed due to an unknown error.")
                    Exit Sub
                End Try

                MessageBox.Show("You have successfully added Shrinkage")
                shrinkageConnection.Close()
                frmShrinkage.Show()
                Me.Close()
            Else
                MessageBox.Show("All fields must be filled to add Shrinkage. Please try again.")
            End If
        Else
            MessageBox.Show("There isn't enough quantity for that amount of shrinkage to be added.")
        End If
    End Sub
End Class