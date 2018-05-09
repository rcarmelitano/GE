<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewShrinkage
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtShrinkageID = New System.Windows.Forms.TextBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtStatusID = New System.Windows.Forms.TextBox()
        Me.txtSKU = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.btnAddToShrinkage = New System.Windows.Forms.Button()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.InventoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New GroceryGUI.GEDataSetTableAdapters.InventoryTableAdapter()
        Me.InventoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddShrinkage = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtQuantityStorage = New System.Windows.Forms.TextBox()
        Me.dtpShrinkDate = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shrinkage ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SKU:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Shrink Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 458)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Details:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(408, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'txtShrinkageID
        '
        Me.txtShrinkageID.Enabled = False
        Me.txtShrinkageID.Location = New System.Drawing.Point(143, 41)
        Me.txtShrinkageID.Name = "txtShrinkageID"
        Me.txtShrinkageID.ReadOnly = True
        Me.txtShrinkageID.Size = New System.Drawing.Size(137, 20)
        Me.txtShrinkageID.TabIndex = 9
        '
        'txtDetails
        '
        Me.txtDetails.Enabled = False
        Me.txtDetails.Location = New System.Drawing.Point(143, 413)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(137, 20)
        Me.txtDetails.TabIndex = 10
        '
        'txtUnit
        '
        Me.txtUnit.Enabled = False
        Me.txtUnit.Location = New System.Drawing.Point(143, 455)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(137, 20)
        Me.txtUnit.TabIndex = 12
        '
        'txtQuantity
        '
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Location = New System.Drawing.Point(143, 332)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(137, 20)
        Me.txtQuantity.TabIndex = 13
        '
        'txtStatusID
        '
        Me.txtStatusID.Enabled = False
        Me.txtStatusID.Location = New System.Drawing.Point(143, 291)
        Me.txtStatusID.Name = "txtStatusID"
        Me.txtStatusID.Size = New System.Drawing.Size(137, 20)
        Me.txtStatusID.TabIndex = 14
        '
        'txtSKU
        '
        Me.txtSKU.Enabled = False
        Me.txtSKU.Location = New System.Drawing.Point(143, 123)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.ReadOnly = True
        Me.txtSKU.Size = New System.Drawing.Size(137, 20)
        Me.txtSKU.TabIndex = 15
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(143, 82)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(137, 20)
        Me.txtEmployeeID.TabIndex = 16
        '
        'btnAddToShrinkage
        '
        Me.btnAddToShrinkage.Enabled = False
        Me.btnAddToShrinkage.Location = New System.Drawing.Point(85, 486)
        Me.btnAddToShrinkage.Name = "btnAddToShrinkage"
        Me.btnAddToShrinkage.Size = New System.Drawing.Size(246, 36)
        Me.btnAddToShrinkage.TabIndex = 17
        Me.btnAddToShrinkage.Text = "Add to Shrinkage"
        Me.btnAddToShrinkage.UseVisualStyleBackColor = True
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.AutoGenerateColumns = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.InventoryCountDataGridViewTextBoxColumn, Me.btnAddShrinkage})
        Me.dgvInventory.DataSource = Me.InventoryBindingSource1
        Me.dgvInventory.Location = New System.Drawing.Point(12, 160)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.Size = New System.Drawing.Size(384, 117)
        Me.dgvInventory.TabIndex = 18
        '
        'InventoryBindingSource1
        '
        Me.InventoryBindingSource1.DataMember = "Inventory"
        Me.InventoryBindingSource1.DataSource = Me.GEDataSet
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.GEDataSet
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
        Me.InventoryIDDataGridViewTextBoxColumn.Width = 70
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
        'InventoryCountDataGridViewTextBoxColumn
        '
        Me.InventoryCountDataGridViewTextBoxColumn.DataPropertyName = "inventoryCount"
        Me.InventoryCountDataGridViewTextBoxColumn.HeaderText = "Inventory Count"
        Me.InventoryCountDataGridViewTextBoxColumn.Name = "InventoryCountDataGridViewTextBoxColumn"
        Me.InventoryCountDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryCountDataGridViewTextBoxColumn.Width = 103
        '
        'btnAddShrinkage
        '
        Me.btnAddShrinkage.HeaderText = ""
        Me.btnAddShrinkage.Name = "btnAddShrinkage"
        Me.btnAddShrinkage.ReadOnly = True
        Me.btnAddShrinkage.Text = "Add Item"
        Me.btnAddShrinkage.UseColumnTextForButtonValue = True
        '
        'txtQuantityStorage
        '
        Me.txtQuantityStorage.Location = New System.Drawing.Point(296, 102)
        Me.txtQuantityStorage.Name = "txtQuantityStorage"
        Me.txtQuantityStorage.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityStorage.TabIndex = 19
        Me.txtQuantityStorage.Visible = False
        '
        'dtpShrinkDate
        '
        Me.dtpShrinkDate.Enabled = False
        Me.dtpShrinkDate.Location = New System.Drawing.Point(141, 373)
        Me.dtpShrinkDate.Name = "dtpShrinkDate"
        Me.dtpShrinkDate.Size = New System.Drawing.Size(195, 20)
        Me.dtpShrinkDate.TabIndex = 20
        '
        'frmNewShrinkage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 534)
        Me.Controls.Add(Me.dtpShrinkDate)
        Me.Controls.Add(Me.txtQuantityStorage)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.btnAddToShrinkage)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.txtSKU)
        Me.Controls.Add(Me.txtStatusID)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtShrinkageID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewShrinkage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Shrinkage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtShrinkageID As TextBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtStatusID As TextBox
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents btnAddToShrinkage As Button
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GEDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryBindingSource1 As BindingSource
    Friend WithEvents InventoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddShrinkage As DataGridViewButtonColumn
    Friend WithEvents txtQuantityStorage As TextBox
    Friend WithEvents dtpShrinkDate As DateTimePicker
End Class
