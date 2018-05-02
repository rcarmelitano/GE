<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POScustumerInfo
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
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.GEDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False

        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing

        Me.TableAdapterManager.Campaign_TargetsTableAdapter = Nothing

        Me.TableAdapterManager.CategoriesTableAdapter = Nothing

        Me.TableAdapterManager.CouponsTableAdapter = Nothing


        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter

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
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AllowUserToAddRows = False
        Me.CustomersDataGridView.AllowUserToDeleteRows = False
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(0, 60)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.ReadOnly = True
        Me.CustomersDataGridView.Size = New System.Drawing.Size(550, 137)
        Me.CustomersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "customerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "customerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "firstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "lastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "primaryPhone"
        Me.DataGridViewTextBoxColumn5.HeaderText = "primaryPhone"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'POScustumerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 197)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Name = "POScustumerInfo"
        Me.Text = "POScustumerInfo"
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
