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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Shipping_AddressesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Billing_AddressesDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Billing_AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Shipping_AddressesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
        Me.Billing_AddressesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Billing_AddressesTableAdapter()
        Me.Shipping_AddressesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Shipping_AddressesTableAdapter()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Shipping_AddressesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billing_AddressesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Billing_AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipping_AddressesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.NewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Shipping_AddressesDataGridView
        '
        Me.Shipping_AddressesDataGridView.AllowUserToAddRows = False
        Me.Shipping_AddressesDataGridView.AllowUserToDeleteRows = False
        Me.Shipping_AddressesDataGridView.AutoGenerateColumns = False
        Me.Shipping_AddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Shipping_AddressesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Shipping_AddressesDataGridView.DataSource = Me.Shipping_AddressesBindingSource
        Me.Shipping_AddressesDataGridView.Location = New System.Drawing.Point(0, 75)
        Me.Shipping_AddressesDataGridView.Name = "Shipping_AddressesDataGridView"
        Me.Shipping_AddressesDataGridView.ReadOnly = True
        Me.Shipping_AddressesDataGridView.RowHeadersVisible = False
        Me.Shipping_AddressesDataGridView.Size = New System.Drawing.Size(706, 166)
        Me.Shipping_AddressesDataGridView.TabIndex = 4
        '
        'Billing_AddressesDataGridView
        '
        Me.Billing_AddressesDataGridView.AllowUserToAddRows = False
        Me.Billing_AddressesDataGridView.AllowUserToDeleteRows = False
        Me.Billing_AddressesDataGridView.AutoGenerateColumns = False
        Me.Billing_AddressesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Billing_AddressesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Billing_AddressesDataGridView.DataSource = Me.Billing_AddressesBindingSource
        Me.Billing_AddressesDataGridView.Location = New System.Drawing.Point(1, 75)
        Me.Billing_AddressesDataGridView.Name = "Billing_AddressesDataGridView"
        Me.Billing_AddressesDataGridView.ReadOnly = True
        Me.Billing_AddressesDataGridView.RowHeadersVisible = False
        Me.Billing_AddressesDataGridView.Size = New System.Drawing.Size(706, 166)
        Me.Billing_AddressesDataGridView.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(570, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 42)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Shipping"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(76, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Billing"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "billingAddressID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Billing Address ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "billingAddress1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Billing Address 1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "billingAddress2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Billing Address 2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "billingCity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Billing City"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "billingState"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Billing State"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "billingZIP"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Billing ZIP"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Billing_AddressesBindingSource
        '
        Me.Billing_AddressesBindingSource.DataMember = "Billing_Addresses"
        Me.Billing_AddressesBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Shipping_AddressesBindingSource
        '
        Me.Shipping_AddressesBindingSource.DataMember = "Shipping_Addresses"
        Me.Shipping_AddressesBindingSource.DataSource = Me.GEDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Me.Billing_AddressesTableAdapter
        Me.TableAdapterManager.Campaign_Opt_InsTableAdapter = Nothing
        Me.TableAdapterManager.Campaign_TypesTableAdapter = Nothing
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CouponsTableAdapter = Nothing
        Me.TableAdapterManager.CreditAuditTableAdapter = Nothing
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
        Me.TableAdapterManager.Shipping_MethodsTableAdapter = Nothing
        Me.TableAdapterManager.ShrinkageTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Trade_ShowsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroceryGUI.GEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Billing_AddressesTableAdapter
        '
        Me.Billing_AddressesTableAdapter.ClearBeforeFill = True
        '
        'Shipping_AddressesTableAdapter
        '
        Me.Shipping_AddressesTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "shippingAddressID"
        Me.DataGridViewTextBoxColumn8.Frozen = True
        Me.DataGridViewTextBoxColumn8.HeaderText = "Shipping Address ID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn9.Frozen = True
        Me.DataGridViewTextBoxColumn9.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "shippingAddress1"
        Me.DataGridViewTextBoxColumn10.Frozen = True
        Me.DataGridViewTextBoxColumn10.HeaderText = "Shipping Address 1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "shippingAddress2"
        Me.DataGridViewTextBoxColumn11.Frozen = True
        Me.DataGridViewTextBoxColumn11.HeaderText = "Shipping Address 2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "shippingCity"
        Me.DataGridViewTextBoxColumn12.Frozen = True
        Me.DataGridViewTextBoxColumn12.HeaderText = "Shipping City"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "shippingState"
        Me.DataGridViewTextBoxColumn13.Frozen = True
        Me.DataGridViewTextBoxColumn13.HeaderText = "Shipping State"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "shippingZip"
        Me.DataGridViewTextBoxColumn14.Frozen = True
        Me.DataGridViewTextBoxColumn14.HeaderText = "Shipping Zip"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'ShippingAdresses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 241)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Billing_AddressesDataGridView)
        Me.Controls.Add(Me.Shipping_AddressesDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "ShippingAdresses"
        Me.Text = "ShippingAdresses"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Shipping_AddressesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billing_AddressesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Billing_AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipping_AddressesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Shipping_AddressesBindingSource As BindingSource
    Friend WithEvents Shipping_AddressesTableAdapter As GEDataSetTableAdapters.Shipping_AddressesTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Billing_AddressesTableAdapter As GEDataSetTableAdapters.Billing_AddressesTableAdapter
    Friend WithEvents Billing_AddressesBindingSource As BindingSource
    Friend WithEvents Shipping_AddressesDataGridView As DataGridView
    Friend WithEvents Billing_AddressesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
