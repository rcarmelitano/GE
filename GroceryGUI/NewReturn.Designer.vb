<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnFinalizeReturn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReturnID = New System.Windows.Forms.TextBox()
        Me.txtOrderDetailID = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.OrderDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.dtpReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Order_DetailsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.ReturnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ReturnsTableAdapter()
        Me.GeDataSet1 = New GroceryGUI.GEDataSet()
        Me.btnOrderID = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFinalizeReturn
        '
        Me.btnFinalizeReturn.Location = New System.Drawing.Point(88, 416)
        Me.btnFinalizeReturn.Name = "btnFinalizeReturn"
        Me.btnFinalizeReturn.Size = New System.Drawing.Size(142, 43)
        Me.btnFinalizeReturn.TabIndex = 0
        Me.btnFinalizeReturn.Text = "Finalize Return"
        Me.btnFinalizeReturn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(319, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Return ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Order Detail ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Reason for Return:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date:"
        '
        'txtReturnID
        '
        Me.txtReturnID.Location = New System.Drawing.Point(216, 28)
        Me.txtReturnID.Name = "txtReturnID"
        Me.txtReturnID.ReadOnly = True
        Me.txtReturnID.Size = New System.Drawing.Size(100, 20)
        Me.txtReturnID.TabIndex = 7
        '
        'txtOrderDetailID
        '
        Me.txtOrderDetailID.Location = New System.Drawing.Point(112, 113)
        Me.txtOrderDetailID.Name = "txtOrderDetailID"
        Me.txtOrderDetailID.ReadOnly = True
        Me.txtOrderDetailID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderDetailID.TabIndex = 8
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(112, 305)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(195, 20)
        Me.txtReason.TabIndex = 9
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.AllowUserToDeleteRows = False
        Me.dgvOrderDetails.AutoGenerateColumns = False
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderDetailIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.quantity, Me.price, Me.btnAddID})
        Me.dgvOrderDetails.DataSource = Me.OrderDetailsBindingSource
        Me.dgvOrderDetails.Location = New System.Drawing.Point(12, 145)
        Me.dgvOrderDetails.MultiSelect = False
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.ReadOnly = True
        Me.dgvOrderDetails.RowHeadersVisible = False
        Me.dgvOrderDetails.Size = New System.Drawing.Size(295, 145)
        Me.dgvOrderDetails.TabIndex = 13
        '
        'OrderDetailIDDataGridViewTextBoxColumn
        '
        Me.OrderDetailIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "orderDetailID"
        Me.OrderDetailIDDataGridViewTextBoxColumn.HeaderText = "Order Detail ID"
        Me.OrderDetailIDDataGridViewTextBoxColumn.Name = "OrderDetailIDDataGridViewTextBoxColumn"
        Me.OrderDetailIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderDetailIDDataGridViewTextBoxColumn.Width = 102
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 54
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Visible = False
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.price.DataPropertyName = "price"
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 56
        '
        'btnAddID
        '
        Me.btnAddID.HeaderText = ""
        Me.btnAddID.Name = "btnAddID"
        Me.btnAddID.ReadOnly = True
        Me.btnAddID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnAddID.Text = "Add"
        Me.btnAddID.UseColumnTextForButtonValue = True
        Me.btnAddID.Width = 63
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(112, 342)
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(100, 20)
        Me.nudQuantity.TabIndex = 16
        '
        'dtpReturnDate
        '
        Me.dtpReturnDate.Location = New System.Drawing.Point(112, 377)
        Me.dtpReturnDate.Name = "dtpReturnDate"
        Me.dtpReturnDate.Size = New System.Drawing.Size(195, 20)
        Me.dtpReturnDate.TabIndex = 18
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(112, 77)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderID.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Order ID:"
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'ReturnsBindingSource
        '
        Me.ReturnsBindingSource.DataMember = "Returns"
        Me.ReturnsBindingSource.DataSource = Me.GEDataSet
        '
        'ReturnsTableAdapter
        '
        Me.ReturnsTableAdapter.ClearBeforeFill = True
        '
        'GeDataSet1
        '
        Me.GeDataSet1.DataSetName = "GEDataSet"
        Me.GeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnOrderID
        '
        Me.btnOrderID.Location = New System.Drawing.Point(227, 73)
        Me.btnOrderID.Name = "btnOrderID"
        Me.btnOrderID.Size = New System.Drawing.Size(75, 26)
        Me.btnOrderID.TabIndex = 21
        Me.btnOrderID.Text = "Enter ID"
        Me.btnOrderID.UseVisualStyleBackColor = True
        '
        'frmNewReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 466)
        Me.Controls.Add(Me.btnOrderID)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpReturnDate)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtOrderDetailID)
        Me.Controls.Add(Me.txtReturnID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFinalizeReturn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmNewReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Return"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFinalizeReturn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReturnID As TextBox
    Friend WithEvents txtOrderDetailID As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents OrderDetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As GEDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents nudQuantity As NumericUpDown
    Friend WithEvents ReturnsBindingSource As BindingSource
    Friend WithEvents ReturnsTableAdapter As GEDataSetTableAdapters.ReturnsTableAdapter
    Friend WithEvents GeDataSet1 As GEDataSet
    Friend WithEvents dtpReturnDate As DateTimePicker
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnOrderID As Button
    Friend WithEvents OrderDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents btnAddID As DataGridViewButtonColumn
End Class
