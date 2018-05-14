<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShipmentCheckIn
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ProductsTableAdapter()
        Me.lblIDSel = New System.Windows.Forms.Label()
        Me.txtSku = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.InventoryTableAdapter = New GroceryGUI.GEDataSetTableAdapters.InventoryTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logDate = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckIn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.RetailUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.AutoGenerateColumns = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.id, Me.CategoryIDDataGridViewTextBoxColumn, Me.DepartmentIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TaxableDataGridViewCheckBoxColumn, Me.UPCDataGridViewTextBoxColumn, Me.CheckIn, Me.RetailUnitDataGridViewTextBoxColumn, Me.RetailCostDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn})
        Me.dgvProducts.DataSource = Me.ProductsBindingSource
        Me.dgvProducts.Location = New System.Drawing.Point(2, 188)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Size = New System.Drawing.Size(754, 310)
        Me.dgvProducts.TabIndex = 0
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.GEDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'lblIDSel
        '
        Me.lblIDSel.AutoSize = True
        Me.lblIDSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblIDSel.Location = New System.Drawing.Point(12, 32)
        Me.lblIDSel.Name = "lblIDSel"
        Me.lblIDSel.Size = New System.Drawing.Size(95, 16)
        Me.lblIDSel.TabIndex = 1
        Me.lblIDSel.Text = "Selected SKU:"
        '
        'txtSku
        '
        Me.txtSku.Enabled = False
        Me.txtSku.Location = New System.Drawing.Point(113, 31)
        Me.txtSku.Name = "txtSku"
        Me.txtSku.Size = New System.Drawing.Size(200, 20)
        Me.txtSku.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(48, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(113, 64)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(200, 20)
        Me.txtQty.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnAdd.Location = New System.Drawing.Point(25, 138)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(209, 44)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add To Inventory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(67, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date:"
        '
        'logDate
        '
        Me.logDate.Enabled = False
        Me.logDate.Location = New System.Drawing.Point(113, 99)
        Me.logDate.Name = "logDate"
        Me.logDate.Size = New System.Drawing.Size(200, 20)
        Me.logDate.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(757, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'id
        '
        Me.id.DataPropertyName = "SKU"
        Me.id.DataSource = Me.InventoryBindingSource
        Me.id.DisplayMember = "inventoryID"
        Me.id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ValueMember = "SKU"
        Me.id.Visible = False
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        Me.DepartmentIDDataGridViewTextBoxColumn.Visible = False
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 250
        '
        'TaxableDataGridViewCheckBoxColumn
        '
        Me.TaxableDataGridViewCheckBoxColumn.DataPropertyName = "taxable"
        Me.TaxableDataGridViewCheckBoxColumn.HeaderText = "taxable"
        Me.TaxableDataGridViewCheckBoxColumn.Name = "TaxableDataGridViewCheckBoxColumn"
        Me.TaxableDataGridViewCheckBoxColumn.Visible = False
        '
        'UPCDataGridViewTextBoxColumn
        '
        Me.UPCDataGridViewTextBoxColumn.DataPropertyName = "UPC"
        Me.UPCDataGridViewTextBoxColumn.HeaderText = "UPC"
        Me.UPCDataGridViewTextBoxColumn.Name = "UPCDataGridViewTextBoxColumn"
        '
        'CheckIn
        '
        Me.CheckIn.HeaderText = "Check In"
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Text = "Select"
        Me.CheckIn.ToolTipText = "Select this product"
        Me.CheckIn.UseColumnTextForButtonValue = True
        '
        'RetailUnitDataGridViewTextBoxColumn
        '
        Me.RetailUnitDataGridViewTextBoxColumn.DataPropertyName = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.HeaderText = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.Name = "RetailUnitDataGridViewTextBoxColumn"
        Me.RetailUnitDataGridViewTextBoxColumn.Visible = False
        '
        'RetailCostDataGridViewTextBoxColumn
        '
        Me.RetailCostDataGridViewTextBoxColumn.DataPropertyName = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.HeaderText = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.Name = "RetailCostDataGridViewTextBoxColumn"
        Me.RetailCostDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.Visible = False
        '
        'ShipmentCheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 500)
        Me.Controls.Add(Me.logDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSku)
        Me.Controls.Add(Me.lblIDSel)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ShipmentCheckIn"
        Me.Text = "Check In New Shipments"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As GEDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents lblIDSel As Label
    Friend WithEvents txtSku As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GEDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents logDate As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewComboBoxColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxableDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents UPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckIn As DataGridViewButtonColumn
    Friend WithEvents RetailUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
