<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplierHisoryInfo
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
        Me.Purchase_Order_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_Order_DetailsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Purchase_Order_DetailsTableAdapter()
        Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
        Me.Purchase_Order_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTableAdapter = New GroceryGUI.GEDataSetTableAdapters.StatusTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase_Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Purchase_Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchase_Order_DetailsBindingSource
        '
        Me.Purchase_Order_DetailsBindingSource.DataMember = "Purchase_Order_Details"
        Me.Purchase_Order_DetailsBindingSource.DataSource = Me.GEDataSet
        '
        'Purchase_Order_DetailsTableAdapter
        '
        Me.Purchase_Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
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
        Me.TableAdapterManager.Purchase_Order_DetailsTableAdapter = Me.Purchase_Order_DetailsTableAdapter
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
        'Purchase_Order_DetailsDataGridView
        '
        Me.Purchase_Order_DetailsDataGridView.AutoGenerateColumns = False
        Me.Purchase_Order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Purchase_Order_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Status, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Purchase_Order_DetailsDataGridView.DataSource = Me.Purchase_Order_DetailsBindingSource
        Me.Purchase_Order_DetailsDataGridView.Location = New System.Drawing.Point(0, 90)
        Me.Purchase_Order_DetailsDataGridView.Name = "Purchase_Order_DetailsDataGridView"
        Me.Purchase_Order_DetailsDataGridView.Size = New System.Drawing.Size(767, 220)
        Me.Purchase_Order_DetailsDataGridView.TabIndex = 1
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me.GEDataSet
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "orderDetailID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "purchaseOrderID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PO ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 45
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SKU"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SKU"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 45
        '
        'Status
        '
        Me.Status.DataPropertyName = "statusID"
        Me.Status.DataSource = Me.StatusBindingSource
        Me.Status.DisplayMember = "status"
        Me.Status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ValueMember = "statusID"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "statusID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "statusID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "unit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'supplierHisoryInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 307)
        Me.Controls.Add(Me.Purchase_Order_DetailsDataGridView)
        Me.Name = "supplierHisoryInfo"
        Me.Text = "supplierHisoryInfo"
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase_Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Purchase_Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents Purchase_Order_DetailsBindingSource As BindingSource
    Friend WithEvents Purchase_Order_DetailsTableAdapter As GEDataSetTableAdapters.Purchase_Order_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Purchase_Order_DetailsDataGridView As DataGridView
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As GEDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
