<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipmentView
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
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvShipments = New System.Windows.Forms.DataGridView()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ShipmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShipmentTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ShipmentTableAdapter()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShipmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipperIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShippingAddressIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShippingCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrackingNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeWentOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvShipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(945, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'dgvShipments
        '
        Me.dgvShipments.AllowUserToAddRows = False
        Me.dgvShipments.AllowUserToDeleteRows = False
        Me.dgvShipments.AutoGenerateColumns = False
        Me.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShipments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShipmentIDDataGridViewTextBoxColumn, Me.ShipperIDDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.ShippingAddressIDDataGridViewTextBoxColumn, Me.ShippingCostDataGridViewTextBoxColumn, Me.TrackingNumberDataGridViewTextBoxColumn, Me.TimeWentOutDataGridViewTextBoxColumn, Me.DateAndTimeReceivedDataGridViewTextBoxColumn, Me.btnView})
        Me.dgvShipments.DataSource = Me.ShipmentBindingSource
        Me.dgvShipments.Location = New System.Drawing.Point(12, 27)
        Me.dgvShipments.Name = "dgvShipments"
        Me.dgvShipments.ReadOnly = True
        Me.dgvShipments.RowHeadersVisible = False
        Me.dgvShipments.Size = New System.Drawing.Size(921, 302)
        Me.dgvShipments.TabIndex = 1
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShipmentBindingSource
        '
        Me.ShipmentBindingSource.DataMember = "Shipment"
        Me.ShipmentBindingSource.DataSource = Me.GEDataSet
        '
        'ShipmentTableAdapter
        '
        Me.ShipmentTableAdapter.ClearBeforeFill = True
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ShipmentIDDataGridViewTextBoxColumn
        '
        Me.ShipmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ShipmentIDDataGridViewTextBoxColumn.DataPropertyName = "shipmentID"
        Me.ShipmentIDDataGridViewTextBoxColumn.HeaderText = "Shipment ID"
        Me.ShipmentIDDataGridViewTextBoxColumn.Name = "ShipmentIDDataGridViewTextBoxColumn"
        Me.ShipmentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipmentIDDataGridViewTextBoxColumn.Width = 90
        '
        'ShipperIDDataGridViewTextBoxColumn
        '
        Me.ShipperIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ShipperIDDataGridViewTextBoxColumn.DataPropertyName = "shipperID"
        Me.ShipperIDDataGridViewTextBoxColumn.HeaderText = "Shipper ID"
        Me.ShipperIDDataGridViewTextBoxColumn.Name = "ShipperIDDataGridViewTextBoxColumn"
        Me.ShipperIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShipperIDDataGridViewTextBoxColumn.Width = 82
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 92
        '
        'ShippingAddressIDDataGridViewTextBoxColumn
        '
        Me.ShippingAddressIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ShippingAddressIDDataGridViewTextBoxColumn.DataPropertyName = "shippingAddressID"
        Me.ShippingAddressIDDataGridViewTextBoxColumn.HeaderText = "Shipping Address ID"
        Me.ShippingAddressIDDataGridViewTextBoxColumn.Name = "ShippingAddressIDDataGridViewTextBoxColumn"
        Me.ShippingAddressIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShippingAddressIDDataGridViewTextBoxColumn.Width = 107
        '
        'ShippingCostDataGridViewTextBoxColumn
        '
        Me.ShippingCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ShippingCostDataGridViewTextBoxColumn.DataPropertyName = "shippingCost"
        Me.ShippingCostDataGridViewTextBoxColumn.HeaderText = "Shipping Cost"
        Me.ShippingCostDataGridViewTextBoxColumn.Name = "ShippingCostDataGridViewTextBoxColumn"
        Me.ShippingCostDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShippingCostDataGridViewTextBoxColumn.Width = 89
        '
        'TrackingNumberDataGridViewTextBoxColumn
        '
        Me.TrackingNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TrackingNumberDataGridViewTextBoxColumn.DataPropertyName = "trackingNumber"
        Me.TrackingNumberDataGridViewTextBoxColumn.HeaderText = "Tracking Number"
        Me.TrackingNumberDataGridViewTextBoxColumn.Name = "TrackingNumberDataGridViewTextBoxColumn"
        Me.TrackingNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.TrackingNumberDataGridViewTextBoxColumn.Width = 105
        '
        'TimeWentOutDataGridViewTextBoxColumn
        '
        Me.TimeWentOutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TimeWentOutDataGridViewTextBoxColumn.DataPropertyName = "timeWentOut"
        Me.TimeWentOutDataGridViewTextBoxColumn.HeaderText = "Time Went Out"
        Me.TimeWentOutDataGridViewTextBoxColumn.Name = "TimeWentOutDataGridViewTextBoxColumn"
        Me.TimeWentOutDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeWentOutDataGridViewTextBoxColumn.Width = 80
        '
        'DateAndTimeReceivedDataGridViewTextBoxColumn
        '
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn.DataPropertyName = "dateAndTimeReceived"
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn.HeaderText = "Date And Time Received"
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn.Name = "DateAndTimeReceivedDataGridViewTextBoxColumn"
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateAndTimeReceivedDataGridViewTextBoxColumn.Width = 139
        '
        'btnView
        '
        Me.btnView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.btnView.HeaderText = ""
        Me.btnView.Name = "btnView"
        Me.btnView.ReadOnly = True
        Me.btnView.Text = "View Details"
        Me.btnView.ToolTipText = "View Shipment Details"
        Me.btnView.UseColumnTextForButtonValue = True
        Me.btnView.Width = 5
        '
        'frmShipmentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 341)
        Me.Controls.Add(Me.dgvShipments)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmShipmentView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Shipments"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvShipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents dgvShipments As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ShipmentBindingSource As BindingSource
    Friend WithEvents ShipmentTableAdapter As GEDataSetTableAdapters.ShipmentTableAdapter
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShipmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipperIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShippingAddressIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShippingCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrackingNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeWentOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAndTimeReceivedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnView As DataGridViewButtonColumn
End Class
