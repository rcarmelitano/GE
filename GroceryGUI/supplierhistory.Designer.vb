<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierhistory
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
        Me.Purchase_OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.view = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Purchase_OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Purchase_OrderTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Purchase_OrderTableAdapter()
        Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
        CType(Me.Purchase_OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase_OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Purchase_OrderDataGridView
        '
        Me.Purchase_OrderDataGridView.AllowUserToAddRows = False
        Me.Purchase_OrderDataGridView.AllowUserToDeleteRows = False
        Me.Purchase_OrderDataGridView.AutoGenerateColumns = False
        Me.Purchase_OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Purchase_OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn1, Me.view})
        Me.Purchase_OrderDataGridView.DataSource = Me.Purchase_OrderBindingSource
        Me.Purchase_OrderDataGridView.Location = New System.Drawing.Point(1, 56)
        Me.Purchase_OrderDataGridView.Name = "Purchase_OrderDataGridView"
        Me.Purchase_OrderDataGridView.ReadOnly = True
        Me.Purchase_OrderDataGridView.Size = New System.Drawing.Size(643, 220)
        Me.Purchase_OrderDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "supplierID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "supplierID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "orderTotal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "orderTotal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "orderDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "orderDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "statusID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "statusID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "purchaseOrderID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "purchaseOrderID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'view
        '
        Me.view.HeaderText = "Column1"
        Me.view.Name = "view"
        Me.view.ReadOnly = True
        Me.view.Text = "view"
        Me.view.UseColumnTextForButtonValue = True
        '
        'Purchase_OrderBindingSource
        '
        Me.Purchase_OrderBindingSource.DataMember = "Purchase_Order"
        Me.Purchase_OrderBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(645, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.CloseToolStripMenuItem.Text = "close "
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "back"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(132, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(338, 26)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Purchase_OrderTableAdapter
        '
        Me.Purchase_OrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False

        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing

        Me.TableAdapterManager.Campaign_TargetsTableAdapter = Nothing

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

        Me.TableAdapterManager.Promo_Info_TypeTableAdapter = Nothing

        Me.TableAdapterManager.Promoted_ProductsTableAdapter = Nothing

        Me.TableAdapterManager.PromotionsTableAdapter = Nothing

        Me.TableAdapterManager.Purchase_Order_DetailsTableAdapter = Nothing

        Me.TableAdapterManager.Purchase_OrderTableAdapter = Me.Purchase_OrderTableAdapter

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
        'supplierhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Purchase_OrderDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "supplierhistory"
        Me.Text = "supplierhistory"
        CType(Me.Purchase_OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase_OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents Purchase_OrderBindingSource As BindingSource
    Friend WithEvents Purchase_OrderTableAdapter As GEDataSetTableAdapters.Purchase_OrderTableAdapter
    Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Purchase_OrderDataGridView As DataGridView
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents DateTimePicker2 As DateTimePicker
	Friend WithEvents Button1 As Button
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
	Friend WithEvents view As DataGridViewButtonColumn
	Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
End Class
