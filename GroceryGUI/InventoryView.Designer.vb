<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryView
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
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.InventoryTableAdapter = New GroceryGUI.GEDataSetTableAdapters.InventoryTableAdapter()
        Me.InventoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReorderAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.UnitCostDataGridViewTextBoxColumn, Me.PurchaseUnitDataGridViewTextBoxColumn, Me.ReorderAmountDataGridViewTextBoxColumn, Me.InventoryCountDataGridViewTextBoxColumn})
        Me.dgvInventory.DataSource = Me.InventoryBindingSource
        Me.dgvInventory.Location = New System.Drawing.Point(12, 27)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.Size = New System.Drawing.Size(920, 323)
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
        'InventoryIDDataGridViewTextBoxColumn
        '
        Me.InventoryIDDataGridViewTextBoxColumn.DataPropertyName = "inventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.HeaderText = "Inventory ID"
        Me.InventoryIDDataGridViewTextBoxColumn.Name = "InventoryIDDataGridViewTextBoxColumn"
        Me.InventoryIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
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
        'frmInventoryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 362)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInventoryView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GEDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReorderAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
