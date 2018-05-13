<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventory
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.InventoryTableAdapter = New GroceryGUI.GEDataSetTableAdapters.InventoryTableAdapter()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.SuppliersTableAdapter()
        Me.InventoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(810, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIDDataGridViewTextBoxColumn, Me.Supplier, Me.SupplierIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.UnitCostDataGridViewTextBoxColumn, Me.PurchaseUnitDataGridViewTextBoxColumn, Me.ReorderAmountDataGridViewTextBoxColumn, Me.InventoryCountDataGridViewTextBoxColumn, Me.btnUpdate})
        Me.dgvInventory.DataSource = Me.InventoryBindingSource
        Me.dgvInventory.Location = New System.Drawing.Point(12, 27)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.Size = New System.Drawing.Size(786, 367)
        Me.dgvInventory.TabIndex = 1
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
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.GEDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'InventoryIDDataGridViewTextBoxColumn
        '
        Me.InventoryIDDataGridViewTextBoxColumn.DataPropertyName = "inventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.HeaderText = "Inventory ID"
        Me.InventoryIDDataGridViewTextBoxColumn.Name = "InventoryIDDataGridViewTextBoxColumn"
        Me.InventoryIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Supplier
        '
        Me.Supplier.DataPropertyName = "supplierID"
        Me.Supplier.DataSource = Me.SuppliersBindingSource
        Me.Supplier.DisplayMember = "supplierName"
        Me.Supplier.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Supplier.HeaderText = "Supplier"
        Me.Supplier.Name = "Supplier"
        Me.Supplier.ValueMember = "supplierID"
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Visible = False
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitCostDataGridViewTextBoxColumn
        '
        Me.UnitCostDataGridViewTextBoxColumn.DataPropertyName = "unitCost"
        Me.UnitCostDataGridViewTextBoxColumn.HeaderText = "Unit Cost"
        Me.UnitCostDataGridViewTextBoxColumn.Name = "UnitCostDataGridViewTextBoxColumn"
        Me.UnitCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaseUnitDataGridViewTextBoxColumn
        '
        Me.PurchaseUnitDataGridViewTextBoxColumn.DataPropertyName = "purchaseUnit"
        Me.PurchaseUnitDataGridViewTextBoxColumn.HeaderText = "Purchase Unit"
        Me.PurchaseUnitDataGridViewTextBoxColumn.Name = "PurchaseUnitDataGridViewTextBoxColumn"
        Me.PurchaseUnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReorderAmountDataGridViewTextBoxColumn
        '
        Me.ReorderAmountDataGridViewTextBoxColumn.DataPropertyName = "reorderAmount"
        Me.ReorderAmountDataGridViewTextBoxColumn.HeaderText = "Reorder Amount"
        Me.ReorderAmountDataGridViewTextBoxColumn.Name = "ReorderAmountDataGridViewTextBoxColumn"
        Me.ReorderAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InventoryCountDataGridViewTextBoxColumn
        '
        Me.InventoryCountDataGridViewTextBoxColumn.DataPropertyName = "inventoryCount"
        Me.InventoryCountDataGridViewTextBoxColumn.HeaderText = "Inventory Count"
        Me.InventoryCountDataGridViewTextBoxColumn.Name = "InventoryCountDataGridViewTextBoxColumn"
        Me.InventoryCountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        Me.btnUpdate.Width = 65
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 403)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GEDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As GEDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents InventoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Supplier As DataGridViewComboBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReorderAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class
