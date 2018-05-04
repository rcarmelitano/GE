<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingAdresses
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
		Me.GEDataSet = New GroceryGUI.GEDataSet()
		Me.Billing_AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.Billing_AddressesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Billing_AddressesTableAdapter()
		Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
		Me.Billing_AddressesDataGridView = New System.Windows.Forms.DataGridView()
		Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
		CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Billing_AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Billing_AddressesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GEDataSet
		'
		Me.GEDataSet.DataSetName = "GEDataSet"
		Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Billing_AddressesBindingSource
		'
		Me.Billing_AddressesBindingSource.DataMember = "Billing_Addresses"
		Me.Billing_AddressesBindingSource.DataSource = Me.GEDataSet
		'
		'Billing_AddressesTableAdapter
		'
		Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
		'
		'TableAdapterManager
		'
		Me.TableAdapterManager.BackupDataSetBeforeUpdate = False

        Me.TableAdapterManager.Billing_AddressesTableAdapter = Me.Billing_AddressesTableAdapter

        Me.TableAdapterManager.CategoriesTableAdapter = Nothing

        Me.TableAdapterManager.CouponsTableAdapter = Nothing

        Me.TableAdapterManager.CustomersTableAdapter = Nothing

        Me.TableAdapterManager.DepartmentsTableAdapter = Nothing

        Me.TableAdapterManager.Discount_TypeTableAdapter = Nothing

        Me.TableAdapterManager.DiscountsTableAdapter = Nothing

        Me.TableAdapterManager.EmployeesTableAdapter = Nothing

        Me.TableAdapterManager.Gift_CardsTableAdapter = Nothing

        Me.TableAdapterManager.InventoryTableAdapter = Nothing

        Me.TableAdapterManager.Item_DiscountTableAdapter = Nothing

        Me.TableAdapterManager.Marketing_CampaignsTableAdapter = Nothing

        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing

        Me.TableAdapterManager.Order_DiscountTableAdapter = Nothing

        Me.TableAdapterManager.OrdersTableAdapter = Nothing

        Me.TableAdapterManager.Payment_TypesTableAdapter = Nothing

        Me.TableAdapterManager.PaymentsTableAdapter = Nothing

        Me.TableAdapterManager.ProductsTableAdapter = Nothing

        Me.TableAdapterManager.Promoted_ProductsTableAdapter = Nothing

        Me.TableAdapterManager.PromotionsTableAdapter = Nothing

        Me.TableAdapterManager.Purchase_Order_DetailsTableAdapter = Nothing

        Me.TableAdapterManager.Purchase_OrderTableAdapter = Nothing

        Me.TableAdapterManager.ReturnsTableAdapter = Nothing

        Me.TableAdapterManager.Shipment_DetailsTableAdapter = Nothing

        Me.TableAdapterManager.ShipmentTableAdapter = Nothing

        Me.TableAdapterManager.ShippersTableAdapter = Nothing

        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing

        Me.TableAdapterManager.ShrinkageTableAdapter = Nothing

        Me.TableAdapterManager.StatusTableAdapter = Nothing

        Me.TableAdapterManager.SuppliersTableAdapter = Nothing

        Me.TableAdapterManager.Trade_ShowsTableAdapter = Nothing
		Me.TableAdapterManager.UpdateOrder = GroceryGUI.GEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
		'
		'Billing_AddressesDataGridView
		'
		Me.Billing_AddressesDataGridView.AutoGenerateColumns = False
		Me.Billing_AddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Billing_AddressesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
		Me.Billing_AddressesDataGridView.DataSource = Me.Billing_AddressesBindingSource
		Me.Billing_AddressesDataGridView.Location = New System.Drawing.Point(0, 145)
		Me.Billing_AddressesDataGridView.Name = "Billing_AddressesDataGridView"
		Me.Billing_AddressesDataGridView.Size = New System.Drawing.Size(800, 306)
		Me.Billing_AddressesDataGridView.TabIndex = 1
		'
		'DataGridViewTextBoxColumn1
		'
		Me.DataGridViewTextBoxColumn1.DataPropertyName = "billingAddressID"
		Me.DataGridViewTextBoxColumn1.HeaderText = "billingAddressID"
		Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
		'
		'DataGridViewTextBoxColumn2
		'
		Me.DataGridViewTextBoxColumn2.DataPropertyName = "customerID"
		Me.DataGridViewTextBoxColumn2.HeaderText = "customerID"
		Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
		'
		'DataGridViewTextBoxColumn3
		'
		Me.DataGridViewTextBoxColumn3.DataPropertyName = "billingAddress1"
		Me.DataGridViewTextBoxColumn3.HeaderText = "billingAddress1"
		Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
		'
		'DataGridViewTextBoxColumn4
		'
		Me.DataGridViewTextBoxColumn4.DataPropertyName = "billingAddress2"
		Me.DataGridViewTextBoxColumn4.HeaderText = "billingAddress2"
		Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
		'
		'DataGridViewTextBoxColumn5
		'
		Me.DataGridViewTextBoxColumn5.DataPropertyName = "billingCity"
		Me.DataGridViewTextBoxColumn5.HeaderText = "billingCity"
		Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
		'
		'DataGridViewTextBoxColumn6
		'
		Me.DataGridViewTextBoxColumn6.DataPropertyName = "billingState"
		Me.DataGridViewTextBoxColumn6.HeaderText = "billingState"
		Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
		'
		'DataGridViewTextBoxColumn7
		'
		Me.DataGridViewTextBoxColumn7.DataPropertyName = "billingZIP"
		Me.DataGridViewTextBoxColumn7.HeaderText = "billingZIP"
		Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
		'
		'ShippingAdresses
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Billing_AddressesDataGridView)
		Me.Name = "ShippingAdresses"
		Me.Text = "ShippingAdresses"
		CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Billing_AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Billing_AddressesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GEDataSet As GEDataSet
	Friend WithEvents Billing_AddressesBindingSource As BindingSource
	Friend WithEvents Billing_AddressesTableAdapter As GEDataSetTableAdapters.Billing_AddressesTableAdapter
	Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
	Friend WithEvents Billing_AddressesDataGridView As DataGridView
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
