<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrders
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
        Me.NewPurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvPurchaseOrders = New System.Windows.Forms.DataGridView()
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Purchase_OrderTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Purchase_OrderTableAdapter()
        Me.PurchaseOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnDetails = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.NewPurchaseOrderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(746, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewPurchaseOrderToolStripMenuItem
        '
        Me.NewPurchaseOrderToolStripMenuItem.Name = "NewPurchaseOrderToolStripMenuItem"
        Me.NewPurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.NewPurchaseOrderToolStripMenuItem.Text = "New Purchase Order"
        '
        'dgvPurchaseOrders
        '
        Me.dgvPurchaseOrders.AllowUserToAddRows = False
        Me.dgvPurchaseOrders.AllowUserToDeleteRows = False
        Me.dgvPurchaseOrders.AutoGenerateColumns = False
        Me.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPurchaseOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseOrderIDDataGridViewTextBoxColumn, Me.SupplierIDDataGridViewTextBoxColumn, Me.OrderTotalDataGridViewTextBoxColumn, Me.OrderDateDataGridViewTextBoxColumn, Me.StatusIDDataGridViewTextBoxColumn, Me.btnUpdate, Me.btnDetails})
        Me.dgvPurchaseOrders.DataSource = Me.PurchaseOrderBindingSource
        Me.dgvPurchaseOrders.Location = New System.Drawing.Point(12, 27)
        Me.dgvPurchaseOrders.Name = "dgvPurchaseOrders"
        Me.dgvPurchaseOrders.ReadOnly = True
        Me.dgvPurchaseOrders.RowHeadersVisible = False
        Me.dgvPurchaseOrders.Size = New System.Drawing.Size(722, 343)
        Me.dgvPurchaseOrders.TabIndex = 1
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "Purchase_Order"
        Me.PurchaseOrderBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Purchase_OrderTableAdapter
        '
        Me.Purchase_OrderTableAdapter.ClearBeforeFill = True
        '
        'PurchaseOrderIDDataGridViewTextBoxColumn
        '
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.DataPropertyName = "purchaseOrderID"
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.HeaderText = "Purchase Order ID"
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.Name = "PurchaseOrderIDDataGridViewTextBoxColumn"
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderTotalDataGridViewTextBoxColumn
        '
        Me.OrderTotalDataGridViewTextBoxColumn.DataPropertyName = "orderTotal"
        Me.OrderTotalDataGridViewTextBoxColumn.HeaderText = "Order Total"
        Me.OrderTotalDataGridViewTextBoxColumn.Name = "OrderTotalDataGridViewTextBoxColumn"
        Me.OrderTotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "Order Date"
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        Me.OrderDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusIDDataGridViewTextBoxColumn
        '
        Me.StatusIDDataGridViewTextBoxColumn.DataPropertyName = "statusID"
        Me.StatusIDDataGridViewTextBoxColumn.HeaderText = "Status ID"
        Me.StatusIDDataGridViewTextBoxColumn.Name = "StatusIDDataGridViewTextBoxColumn"
        Me.StatusIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ReadOnly = True
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        '
        'btnDetails
        '
        Me.btnDetails.HeaderText = ""
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.ReadOnly = True
        Me.btnDetails.Text = "Details"
        Me.btnDetails.UseColumnTextForButtonValue = True
        '
        'frmPurchaseOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 379)
        Me.Controls.Add(Me.dgvPurchaseOrders)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPurchaseOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Orders"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvPurchaseOrders As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PurchaseOrderBindingSource As BindingSource
    Friend WithEvents Purchase_OrderTableAdapter As GEDataSetTableAdapters.Purchase_OrderTableAdapter
    Friend WithEvents NewPurchaseOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
    Friend WithEvents btnDetails As DataGridViewButtonColumn
End Class
