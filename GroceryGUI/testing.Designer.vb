<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class testing
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(testing))
		Me.GEDataSet = New GroceryGUI.GEDataSet()
		Me.CreditAuditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CreditAuditTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CreditAuditTableAdapter()
		Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
		Me.CreditAuditBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
		Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
		Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
		Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
		Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
		Me.CreditAuditBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
		Me.CreditAuditDataGridView = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CreditAuditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CreditAuditBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.CreditAuditBindingNavigator.SuspendLayout()
		CType(Me.CreditAuditDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GEDataSet
		'
		Me.GEDataSet.DataSetName = "GEDataSet"
		Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'CreditAuditBindingSource
		'
		Me.CreditAuditBindingSource.DataMember = "CreditAudit"
		Me.CreditAuditBindingSource.DataSource = Me.GEDataSet
		'
		'CreditAuditTableAdapter
		'
		Me.CreditAuditTableAdapter.ClearBeforeFill = True
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
		Me.TableAdapterManager.CreditAuditTableAdapter = Me.CreditAuditTableAdapter
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
		Me.TableAdapterManager.OrdersTableAdapter = Nothing
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
		'CreditAuditBindingNavigator
		'
		Me.CreditAuditBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
		Me.CreditAuditBindingNavigator.BindingSource = Me.CreditAuditBindingSource
		Me.CreditAuditBindingNavigator.CountItem = Me.BindingNavigatorCountItem
		Me.CreditAuditBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
		Me.CreditAuditBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CreditAuditBindingNavigatorSaveItem})
		Me.CreditAuditBindingNavigator.Location = New System.Drawing.Point(0, 0)
		Me.CreditAuditBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
		Me.CreditAuditBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
		Me.CreditAuditBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
		Me.CreditAuditBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
		Me.CreditAuditBindingNavigator.Name = "CreditAuditBindingNavigator"
		Me.CreditAuditBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
		Me.CreditAuditBindingNavigator.Size = New System.Drawing.Size(800, 25)
		Me.CreditAuditBindingNavigator.TabIndex = 0
		Me.CreditAuditBindingNavigator.Text = "BindingNavigator1"
		'
		'BindingNavigatorMoveFirstItem
		'
		Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
		Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMoveFirstItem.Text = "Move first"
		'
		'BindingNavigatorMovePreviousItem
		'
		Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
		Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
		'
		'BindingNavigatorSeparator
		'
		Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
		'
		'BindingNavigatorPositionItem
		'
		Me.BindingNavigatorPositionItem.AccessibleName = "Position"
		Me.BindingNavigatorPositionItem.AutoSize = False
		Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
		Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
		Me.BindingNavigatorPositionItem.Text = "0"
		Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
		'
		'BindingNavigatorCountItem
		'
		Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
		Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
		Me.BindingNavigatorCountItem.Text = "of {0}"
		Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
		'
		'BindingNavigatorSeparator1
		'
		Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorMoveNextItem
		'
		Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
		Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
		Me.BindingNavigatorMoveNextItem.Text = "Move next"
		'
		'BindingNavigatorMoveLastItem
		'
		Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
		Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
		Me.BindingNavigatorMoveLastItem.Text = "Move last"
		'
		'BindingNavigatorSeparator2
		'
		Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
		Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
		'
		'BindingNavigatorAddNewItem
		'
		Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
		Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
		Me.BindingNavigatorAddNewItem.Text = "Add new"
		'
		'BindingNavigatorDeleteItem
		'
		Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
		Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
		Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
		Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
		Me.BindingNavigatorDeleteItem.Text = "Delete"
		'
		'CreditAuditBindingNavigatorSaveItem
		'
		Me.CreditAuditBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.CreditAuditBindingNavigatorSaveItem.Image = CType(resources.GetObject("CreditAuditBindingNavigatorSaveItem.Image"), System.Drawing.Image)
		Me.CreditAuditBindingNavigatorSaveItem.Name = "CreditAuditBindingNavigatorSaveItem"
		Me.CreditAuditBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
		Me.CreditAuditBindingNavigatorSaveItem.Text = "Save Data"
		'
		'CreditAuditDataGridView
		'
		Me.CreditAuditDataGridView.AutoGenerateColumns = False
		Me.CreditAuditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.CreditAuditDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
		Me.CreditAuditDataGridView.DataSource = Me.CreditAuditBindingSource
		Me.CreditAuditDataGridView.Location = New System.Drawing.Point(0, 98)
		Me.CreditAuditDataGridView.Name = "CreditAuditDataGridView"
		Me.CreditAuditDataGridView.Size = New System.Drawing.Size(788, 220)
		Me.CreditAuditDataGridView.TabIndex = 1
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "AuditId"
		Me.DataGridViewTextBoxColumn1.HeaderText = "AuditId"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		Me.DataGridViewTextBoxColumn1.ReadOnly = True
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId"
		Me.DataGridViewTextBoxColumn2.HeaderText = "EmployeeId"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "CustomerId"
		Me.DataGridViewTextBoxColumn3.HeaderText = "CustomerId"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "startamount"
		Me.DataGridViewTextBoxColumn4.HeaderText = "startamount"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "newAmount"
		Me.DataGridViewTextBoxColumn5.HeaderText = "newAmount"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "ChangedOn"
		Me.DataGridViewTextBoxColumn6.HeaderText = "ChangedOn"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "reason"
		Me.DataGridViewTextBoxColumn7.HeaderText = "reason"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		'
		'testing
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.CreditAuditDataGridView)
		Me.Controls.Add(Me.CreditAuditBindingNavigator)
		Me.Name = "testing"
		Me.Text = "testing"
		CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CreditAuditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CreditAuditBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.CreditAuditBindingNavigator.ResumeLayout(False)
		Me.CreditAuditBindingNavigator.PerformLayout()
		CType(Me.CreditAuditDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GEDataSet As GEDataSet
	Friend WithEvents CreditAuditBindingSource As BindingSource
	Friend WithEvents CreditAuditTableAdapter As GEDataSetTableAdapters.CreditAuditTableAdapter
	Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
	Friend WithEvents CreditAuditBindingNavigator As BindingNavigator
	Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents CreditAuditBindingNavigatorSaveItem As ToolStripButton
	Friend WithEvents CreditAuditDataGridView As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
