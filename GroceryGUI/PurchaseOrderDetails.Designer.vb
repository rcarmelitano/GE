<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseOrderDetails
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
        Me.dgvPurchaseOrderDetails = New System.Windows.Forms.DataGridView()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.PurchaseOrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Purchase_Order_DetailsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Purchase_Order_DetailsTableAdapter()
        Me.OrderDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPurchaseOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'dgvPurchaseOrderDetails
        '
        Me.dgvPurchaseOrderDetails.AllowUserToAddRows = False
        Me.dgvPurchaseOrderDetails.AllowUserToDeleteRows = False
        Me.dgvPurchaseOrderDetails.AutoGenerateColumns = False
        Me.dgvPurchaseOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPurchaseOrderDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderDetailIDDataGridViewTextBoxColumn, Me.PurchaseOrderIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.StatusIDDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn})
        Me.dgvPurchaseOrderDetails.DataSource = Me.PurchaseOrderDetailsBindingSource
        Me.dgvPurchaseOrderDetails.Location = New System.Drawing.Point(12, 27)
        Me.dgvPurchaseOrderDetails.Name = "dgvPurchaseOrderDetails"
        Me.dgvPurchaseOrderDetails.ReadOnly = True
        Me.dgvPurchaseOrderDetails.RowHeadersVisible = False
        Me.dgvPurchaseOrderDetails.Size = New System.Drawing.Size(755, 340)
        Me.dgvPurchaseOrderDetails.TabIndex = 1
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseOrderDetailsBindingSource
        '
        Me.PurchaseOrderDetailsBindingSource.DataMember = "Purchase_Order_Details"
        Me.PurchaseOrderDetailsBindingSource.DataSource = Me.GEDataSet
        '
        'Purchase_Order_DetailsTableAdapter
        '
        Me.Purchase_Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'OrderDetailIDDataGridViewTextBoxColumn
        '
        Me.OrderDetailIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "orderDetailID"
        Me.OrderDetailIDDataGridViewTextBoxColumn.HeaderText = "Order Detail ID"
        Me.OrderDetailIDDataGridViewTextBoxColumn.Name = "OrderDetailIDDataGridViewTextBoxColumn"
        Me.OrderDetailIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderDetailIDDataGridViewTextBoxColumn.Width = 102
        '
        'PurchaseOrderIDDataGridViewTextBoxColumn
        '
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.DataPropertyName = "purchaseOrderID"
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.HeaderText = "Purchase Order ID"
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.Name = "PurchaseOrderIDDataGridViewTextBoxColumn"
        Me.PurchaseOrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 54
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 71
        '
        'StatusIDDataGridViewTextBoxColumn
        '
        Me.StatusIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StatusIDDataGridViewTextBoxColumn.DataPropertyName = "statusID"
        Me.StatusIDDataGridViewTextBoxColumn.HeaderText = "Status ID"
        Me.StatusIDDataGridViewTextBoxColumn.Name = "StatusIDDataGridViewTextBoxColumn"
        Me.StatusIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusIDDataGridViewTextBoxColumn.Width = 70
        '
        'UnitDataGridViewTextBoxColumn
        '
        Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "unit"
        Me.UnitDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
        Me.UnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoteDataGridViewTextBoxColumn.Width = 220
        '
        'frmPurchaseOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 379)
        Me.Controls.Add(Me.dgvPurchaseOrderDetails)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPurchaseOrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Details"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPurchaseOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvPurchaseOrderDetails As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PurchaseOrderDetailsBindingSource As BindingSource
    Friend WithEvents Purchase_Order_DetailsTableAdapter As GEDataSetTableAdapters.Purchase_Order_DetailsTableAdapter
    Friend WithEvents OrderDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
