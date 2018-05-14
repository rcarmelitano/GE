<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShipmentReceivingLog
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
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Shipment_ReceivedTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Shipment_ReceivedTableAdapter()
        Me.InventoryTableAdapter = New GroceryGUI.GEDataSetTableAdapters.InventoryTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ShipmentReceivedBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.InventoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipmentReceivedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipmentReceivedIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKU = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.InventoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentReceivedBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentReceivedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.CheckInToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(456, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'CheckInToolStripMenuItem
        '
        Me.CheckInToolStripMenuItem.Name = "CheckInToolStripMenuItem"
        Me.CheckInToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.CheckInToolStripMenuItem.Text = "Check In"
        '
        'Shipment_ReceivedTableAdapter
        '
        Me.Shipment_ReceivedTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShipmentReceivedIdDataGridViewTextBoxColumn, Me.SKU, Me.InventoryIDDataGridViewTextBoxColumn, Me.DateReceivedDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ShipmentReceivedBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(456, 426)
        Me.DataGridView1.TabIndex = 1
        '
        'ShipmentReceivedBindingSource1
        '
        Me.ShipmentReceivedBindingSource1.DataMember = "Shipment_Received"
        Me.ShipmentReceivedBindingSource1.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource1
        '
        Me.InventoryBindingSource1.DataMember = "Inventory"
        Me.InventoryBindingSource1.DataSource = Me.GEDataSet
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        '
        'ShipmentReceivedBindingSource
        '
        Me.ShipmentReceivedBindingSource.DataMember = "Shipment_Received"
        '
        'ShipmentReceivedIdDataGridViewTextBoxColumn
        '
        Me.ShipmentReceivedIdDataGridViewTextBoxColumn.DataPropertyName = "ShipmentReceivedId"
        Me.ShipmentReceivedIdDataGridViewTextBoxColumn.HeaderText = "ShipmentReceivedId"
        Me.ShipmentReceivedIdDataGridViewTextBoxColumn.Name = "ShipmentReceivedIdDataGridViewTextBoxColumn"
        Me.ShipmentReceivedIdDataGridViewTextBoxColumn.Visible = False
        '
        'SKU
        '
        Me.SKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SKU.DataPropertyName = "inventoryID"
        Me.SKU.DataSource = Me.InventoryBindingSource1
        Me.SKU.DisplayMember = "SKU"
        Me.SKU.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SKU.HeaderText = "SKU"
        Me.SKU.Name = "SKU"
        Me.SKU.ValueMember = "inventoryID"
        '
        'InventoryIDDataGridViewTextBoxColumn
        '
        Me.InventoryIDDataGridViewTextBoxColumn.DataPropertyName = "inventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.HeaderText = "inventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.Name = "InventoryIDDataGridViewTextBoxColumn"
        Me.InventoryIDDataGridViewTextBoxColumn.Visible = False
        '
        'DateReceivedDataGridViewTextBoxColumn
        '
        Me.DateReceivedDataGridViewTextBoxColumn.DataPropertyName = "dateReceived"
        Me.DateReceivedDataGridViewTextBoxColumn.HeaderText = "Date Received"
        Me.DateReceivedDataGridViewTextBoxColumn.Name = "DateReceivedDataGridViewTextBoxColumn"
        Me.DateReceivedDataGridViewTextBoxColumn.Width = 125
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'ShipmentReceivingLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ShipmentReceivingLog"
        Me.Text = "Shipment Receiving Log"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentReceivedBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentReceivedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShipmentReceivedBindingSource As BindingSource
    Friend WithEvents Shipment_ReceivedTableAdapter As GEDataSetTableAdapters.Shipment_ReceivedTableAdapter
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GEDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ShipmentReceivedBindingSource1 As BindingSource
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents InventoryBindingSource1 As BindingSource
    Friend WithEvents ShipmentReceivedIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKU As DataGridViewComboBoxColumn
    Friend WithEvents InventoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateReceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
