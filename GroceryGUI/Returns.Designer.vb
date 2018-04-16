<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewReturn
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
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReturnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectItem = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnFinalizeReturn = New System.Windows.Forms.Button()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.returnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OrderDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ReturnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ReturnsTableAdapter()
        Me.Order_DetailsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Order_DetailsTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.ViewReturnsToolStripMenuItem, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(789, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(44, 20)
        Me.mnuBack.Text = "Back"
        '
        'ViewReturnsToolStripMenuItem
        '
        Me.ViewReturnsToolStripMenuItem.Name = "ViewReturnsToolStripMenuItem"
        Me.ViewReturnsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.ViewReturnsToolStripMenuItem.Text = "View Returns"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnSearch.Location = New System.Drawing.Point(261, 42)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 27)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(92, 45)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(163, 20)
        Me.txtOrderID.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Order ID:"
        '
        'btnSelectItem
        '
        Me.btnSelectItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnSelectItem.Location = New System.Drawing.Point(518, 33)
        Me.btnSelectItem.Name = "btnSelectItem"
        Me.btnSelectItem.Size = New System.Drawing.Size(112, 36)
        Me.btnSelectItem.TabIndex = 10
        Me.btnSelectItem.Text = "Select Item"
        Me.btnSelectItem.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnSelectAll.Location = New System.Drawing.Point(647, 33)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(112, 36)
        Me.btnSelectAll.TabIndex = 11
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnFinalizeReturn
        '
        Me.btnFinalizeReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnFinalizeReturn.Location = New System.Drawing.Point(317, 371)
        Me.btnFinalizeReturn.Name = "btnFinalizeReturn"
        Me.btnFinalizeReturn.Size = New System.Drawing.Size(154, 37)
        Me.btnFinalizeReturn.TabIndex = 12
        Me.btnFinalizeReturn.Text = "Finalize Return"
        Me.btnFinalizeReturn.UseVisualStyleBackColor = True
        '
        'dgvOrders
        '
        Me.dgvOrders.AllowUserToAddRows = False
        Me.dgvOrders.AllowUserToDeleteRows = False
        Me.dgvOrders.AutoGenerateColumns = False
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.OrderDetailIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.PaidDataGridViewCheckBoxColumn, Me.returnSelect})
        Me.dgvOrders.DataSource = Me.OrderDetailsBindingSource
        Me.dgvOrders.Location = New System.Drawing.Point(13, 81)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowHeadersVisible = False
        Me.dgvOrders.Size = New System.Drawing.Size(756, 284)
        Me.dgvOrders.TabIndex = 13
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderDetailIDDataGridViewTextBoxColumn
        '
        Me.OrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "orderDetailID"
        Me.OrderDetailIDDataGridViewTextBoxColumn.HeaderText = "Order Detail ID"
        Me.OrderDetailIDDataGridViewTextBoxColumn.Name = "OrderDetailIDDataGridViewTextBoxColumn"
        Me.OrderDetailIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Qty."
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaidDataGridViewCheckBoxColumn
        '
        Me.PaidDataGridViewCheckBoxColumn.DataPropertyName = "paid"
        Me.PaidDataGridViewCheckBoxColumn.HeaderText = "Paid"
        Me.PaidDataGridViewCheckBoxColumn.Name = "PaidDataGridViewCheckBoxColumn"
        Me.PaidDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'returnSelect
        '
        Me.returnSelect.HeaderText = "Selected"
        Me.returnSelect.Name = "returnSelect"
        '
        'OrderDetailsBindingSource
        '
        Me.OrderDetailsBindingSource.DataMember = "Order_Details"
        Me.OrderDetailsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReturnsBindingSource
        '
        Me.ReturnsBindingSource.DataMember = "Returns"
        Me.ReturnsBindingSource.DataSource = Me.GEDataSet
        '
        'ReturnsTableAdapter
        '
        Me.ReturnsTableAdapter.ClearBeforeFill = True
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'frmNewReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 428)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.btnFinalizeReturn)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnSelectItem)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmNewReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Return"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectItem As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents btnFinalizeReturn As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ReturnsBindingSource As BindingSource
    Friend WithEvents ReturnsTableAdapter As GEDataSetTableAdapters.ReturnsTableAdapter
    Friend WithEvents OrderDetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As GEDataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents ViewReturnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents returnSelect As DataGridViewCheckBoxColumn
End Class
