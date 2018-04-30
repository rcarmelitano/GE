<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GEDataSet = New GroceryGUI.GEDataSet()
		Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.OrdersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.OrdersTableAdapter()
		Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
		Me.OrdersDataGridView = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.btnView = New System.Windows.Forms.DataGridViewButtonColumn()
		Me.DPdate1 = New System.Windows.Forms.DateTimePicker()
		Me.DPdate2 = New System.Windows.Forms.DateTimePicker()
		Me.btnsearch = New System.Windows.Forms.Button()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OrdersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.BackToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(566, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'BackToolStripMenuItem
		'
		Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
		Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.BackToolStripMenuItem.Text = "Back"
		'
		'GEDataSet
		'
		Me.GEDataSet.DataSetName = "GEDataSet"
		Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'OrdersBindingSource
		'
		Me.OrdersBindingSource.DataMember = "Orders"
		Me.OrdersBindingSource.DataSource = Me.GEDataSet
		'
		'OrdersTableAdapter
		'
		Me.OrdersTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
		Me.TableAdapterManager.Billing_Addresses1TableAdapter = Nothing
		Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
		Me.TableAdapterManager.Campaign_Targets1TableAdapter = Nothing
		Me.TableAdapterManager.Campaign_TargetsTableAdapter = Nothing
		Me.TableAdapterManager.Categories1TableAdapter = Nothing
		Me.TableAdapterManager.CategoriesTableAdapter = Nothing
		Me.TableAdapterManager.Coupons1TableAdapter = Nothing
		Me.TableAdapterManager.CouponsTableAdapter = Nothing
		Me.TableAdapterManager.CreditAuditTableAdapter = Nothing
		Me.TableAdapterManager.Customers1TableAdapter = Nothing
		Me.TableAdapterManager.CustomersTableAdapter = Nothing
		Me.TableAdapterManager.Departments1TableAdapter = Nothing
		Me.TableAdapterManager.DepartmentsTableAdapter = Nothing
		Me.TableAdapterManager.Discount_Type1TableAdapter = Nothing
		Me.TableAdapterManager.Discount_TypeTableAdapter = Nothing
		Me.TableAdapterManager.Discounts1TableAdapter = Nothing
		Me.TableAdapterManager.DiscountsTableAdapter = Nothing
		Me.TableAdapterManager.Employees1TableAdapter = Nothing
		Me.TableAdapterManager.EmployeesTableAdapter = Nothing
		Me.TableAdapterManager.Gift_Cards1TableAdapter = Nothing
		Me.TableAdapterManager.Gift_CardsTableAdapter = Nothing
		Me.TableAdapterManager.Inventory1TableAdapter = Nothing
		Me.TableAdapterManager.InventoryTableAdapter = Nothing
		Me.TableAdapterManager.Item_Discount1TableAdapter = Nothing
		Me.TableAdapterManager.Item_DiscountTableAdapter = Nothing
		Me.TableAdapterManager.Marketing_Campaigns1TableAdapter = Nothing
		Me.TableAdapterManager.Marketing_CampaignsTableAdapter = Nothing
		Me.TableAdapterManager.Order_Details1TableAdapter = Nothing
		Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
		Me.TableAdapterManager.Order_Discount1TableAdapter = Nothing
		Me.TableAdapterManager.Order_DiscountTableAdapter = Nothing
		Me.TableAdapterManager.Orders1TableAdapter = Nothing
		Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
		Me.TableAdapterManager.Payment_Types1TableAdapter = Nothing
		Me.TableAdapterManager.Payment_TypesTableAdapter = Nothing
		Me.TableAdapterManager.Payments1TableAdapter = Nothing
		Me.TableAdapterManager.PaymentsTableAdapter = Nothing
		Me.TableAdapterManager.Products1TableAdapter = Nothing
		Me.TableAdapterManager.ProductsTableAdapter = Nothing
		Me.TableAdapterManager.Promo_Info_Type1TableAdapter = Nothing
		Me.TableAdapterManager.Promo_Info_TypeTableAdapter = Nothing
		Me.TableAdapterManager.Promoted_Products1TableAdapter = Nothing
		Me.TableAdapterManager.Promoted_ProductsTableAdapter = Nothing
		Me.TableAdapterManager.Promotions1TableAdapter = Nothing
		Me.TableAdapterManager.PromotionsTableAdapter = Nothing
		Me.TableAdapterManager.Purchase_Order_Details1TableAdapter = Nothing
		Me.TableAdapterManager.Purchase_Order_DetailsTableAdapter = Nothing
		Me.TableAdapterManager.Purchase_Order1TableAdapter = Nothing
		Me.TableAdapterManager.Purchase_OrderTableAdapter = Nothing
		Me.TableAdapterManager.Returns1TableAdapter = Nothing
		Me.TableAdapterManager.ReturnsTableAdapter = Nothing
		Me.TableAdapterManager.Shipment_Details1TableAdapter = Nothing
		Me.TableAdapterManager.Shipment_DetailsTableAdapter = Nothing
		Me.TableAdapterManager.Shipment1TableAdapter = Nothing
		Me.TableAdapterManager.ShipmentTableAdapter = Nothing
		Me.TableAdapterManager.Shippers1TableAdapter = Nothing
		Me.TableAdapterManager.ShippersTableAdapter = Nothing
		Me.TableAdapterManager.Shipping_Addresses1TableAdapter = Nothing
		Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
		Me.TableAdapterManager.Shrinkage1TableAdapter = Nothing
		Me.TableAdapterManager.ShrinkageTableAdapter = Nothing
		Me.TableAdapterManager.Status1TableAdapter = Nothing
		Me.TableAdapterManager.StatusTableAdapter = Nothing
		Me.TableAdapterManager.Suppliers1TableAdapter = Nothing
		Me.TableAdapterManager.SuppliersTableAdapter = Nothing
		Me.TableAdapterManager.Trade_Shows1TableAdapter = Nothing
		Me.TableAdapterManager.Trade_ShowsTableAdapter = Nothing
		Me.TableAdapterManager.UpdateOrder = GroceryGUI.GEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'OrdersDataGridView
		'
		Me.OrdersDataGridView.AllowUserToAddRows = False
		Me.OrdersDataGridView.AllowUserToDeleteRows = False
		Me.OrdersDataGridView.AutoGenerateColumns = False
		Me.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.OrdersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.btnView})
		Me.OrdersDataGridView.DataSource = Me.OrdersBindingSource
		Me.OrdersDataGridView.Location = New System.Drawing.Point(0, 68)
		Me.OrdersDataGridView.Name = "OrdersDataGridView"
		Me.OrdersDataGridView.ReadOnly = True
		Me.OrdersDataGridView.RowHeadersVisible = False
		Me.OrdersDataGridView.Size = New System.Drawing.Size(566, 220)
		Me.OrdersDataGridView.TabIndex = 2
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "orderID"
		Me.DataGridViewTextBoxColumn1.HeaderText = "Order ID"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		Me.DataGridViewTextBoxColumn1.Width = 67
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "customerID"
		Me.DataGridViewTextBoxColumn2.HeaderText = "Customer ID"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		Me.DataGridViewTextBoxColumn2.ReadOnly = True
		Me.DataGridViewTextBoxColumn2.Width = 83
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "employeeID"
		Me.DataGridViewTextBoxColumn3.HeaderText = "Employee ID"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		Me.DataGridViewTextBoxColumn3.ReadOnly = True
		Me.DataGridViewTextBoxColumn3.Width = 85
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "purchaseLocation"
		Me.DataGridViewTextBoxColumn4.HeaderText = "Purchase Location"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		Me.DataGridViewTextBoxColumn4.ReadOnly = True
		Me.DataGridViewTextBoxColumn4.Width = 111
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "orderDate"
		Me.DataGridViewTextBoxColumn5.HeaderText = "Order Date"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		Me.DataGridViewTextBoxColumn5.ReadOnly = True
		Me.DataGridViewTextBoxColumn5.Width = 78
		'
		'DataGridViewCheckBoxColumn1
		'
		Me.DataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
		Me.DataGridViewCheckBoxColumn1.DataPropertyName = "status"
		Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
		Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
		Me.DataGridViewCheckBoxColumn1.ReadOnly = True
		Me.DataGridViewCheckBoxColumn1.Width = 43
		'
		'btnView
		'
		Me.btnView.HeaderText = ""
		Me.btnView.Name = "btnView"
		Me.btnView.ReadOnly = True
		Me.btnView.Text = "View"
		Me.btnView.UseColumnTextForButtonValue = True
		Me.btnView.Width = 65
		'
		'DPdate1
		'
		Me.DPdate1.Location = New System.Drawing.Point(59, 42)
		Me.DPdate1.Name = "DPdate1"
		Me.DPdate1.Size = New System.Drawing.Size(186, 20)
		Me.DPdate1.TabIndex = 3
		'
		'DPdate2
		'
		Me.DPdate2.Location = New System.Drawing.Point(283, 42)
		Me.DPdate2.Name = "DPdate2"
		Me.DPdate2.Size = New System.Drawing.Size(186, 20)
		Me.DPdate2.TabIndex = 4
		'
		'btnsearch
		'
		Me.btnsearch.Location = New System.Drawing.Point(488, 42)
		Me.btnsearch.Name = "btnsearch"
		Me.btnsearch.Size = New System.Drawing.Size(75, 23)
		Me.btnsearch.TabIndex = 5
		Me.btnsearch.Text = "Search"
		Me.btnsearch.UseVisualStyleBackColor = True
		'
		'frmCustomerHistory
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(566, 288)
		Me.Controls.Add(Me.btnsearch)
		Me.Controls.Add(Me.DPdate2)
		Me.Controls.Add(Me.DPdate1)
		Me.Controls.Add(Me.OrdersDataGridView)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.Name = "frmCustomerHistory"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Customer History"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OrdersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As GEDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents btnView As DataGridViewButtonColumn
	Friend WithEvents DPdate1 As DateTimePicker
	Friend WithEvents DPdate2 As DateTimePicker
	Friend WithEvents btnsearch As Button
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
End Class
