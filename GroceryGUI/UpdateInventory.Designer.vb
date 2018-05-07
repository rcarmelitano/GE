<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateInventory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInventoryID = New System.Windows.Forms.TextBox()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.txtSKU = New System.Windows.Forms.TextBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.txtPurchaseUnit = New System.Windows.Forms.TextBox()
        Me.txtReorderAmount = New System.Windows.Forms.TextBox()
        Me.txtInventoryCount = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.btnCreateProduct = New System.Windows.Forms.Button()
        Me.SuppliersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.SuppliersTableAdapter()
        Me.supplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Supplier ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SKU:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit Cost:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Purchase Unit:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Reorder Amount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Inventory Count:"
        '
        'txtInventoryID
        '
        Me.txtInventoryID.Enabled = False
        Me.txtInventoryID.Location = New System.Drawing.Point(169, 38)
        Me.txtInventoryID.Name = "txtInventoryID"
        Me.txtInventoryID.ReadOnly = True
        Me.txtInventoryID.Size = New System.Drawing.Size(100, 20)
        Me.txtInventoryID.TabIndex = 7
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Enabled = False
        Me.txtSupplierID.Location = New System.Drawing.Point(76, 265)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(93, 20)
        Me.txtSupplierID.TabIndex = 8
        '
        'txtSKU
        '
        Me.txtSKU.Enabled = False
        Me.txtSKU.Location = New System.Drawing.Point(169, 73)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.ReadOnly = True
        Me.txtSKU.Size = New System.Drawing.Size(100, 20)
        Me.txtSKU.TabIndex = 9
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Location = New System.Drawing.Point(169, 109)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(100, 20)
        Me.txtUnitCost.TabIndex = 10
        '
        'txtPurchaseUnit
        '
        Me.txtPurchaseUnit.Location = New System.Drawing.Point(169, 145)
        Me.txtPurchaseUnit.Name = "txtPurchaseUnit"
        Me.txtPurchaseUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchaseUnit.TabIndex = 11
        '
        'txtReorderAmount
        '
        Me.txtReorderAmount.Location = New System.Drawing.Point(168, 184)
        Me.txtReorderAmount.Name = "txtReorderAmount"
        Me.txtReorderAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderAmount.TabIndex = 12
        '
        'txtInventoryCount
        '
        Me.txtInventoryCount.Enabled = False
        Me.txtInventoryCount.Location = New System.Drawing.Point(168, 222)
        Me.txtInventoryCount.Name = "txtInventoryCount"
        Me.txtInventoryCount.ReadOnly = True
        Me.txtInventoryCount.Size = New System.Drawing.Size(100, 20)
        Me.txtInventoryCount.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AutoGenerateColumns = False
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.supplierID, Me.supplierName, Me.btnAdd})
        Me.dgvSuppliers.DataSource = Me.SuppliersBindingSource
        Me.dgvSuppliers.Location = New System.Drawing.Point(12, 291)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.Size = New System.Drawing.Size(352, 141)
        Me.dgvSuppliers.TabIndex = 99
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCreateProduct
        '
        Me.btnCreateProduct.Enabled = False
        Me.btnCreateProduct.Location = New System.Drawing.Point(98, 445)
        Me.btnCreateProduct.Name = "btnCreateProduct"
        Me.btnCreateProduct.Size = New System.Drawing.Size(179, 43)
        Me.btnCreateProduct.TabIndex = 98
        Me.btnCreateProduct.Text = "Save Changes"
        Me.btnCreateProduct.UseVisualStyleBackColor = True
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'supplierID
        '
        Me.supplierID.DataPropertyName = "supplierID"
        Me.supplierID.HeaderText = "Supplier ID"
        Me.supplierID.Name = "supplierID"
        Me.supplierID.ReadOnly = True
        '
        'supplierName
        '
        Me.supplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.supplierName.DataPropertyName = "supplierName"
        Me.supplierName.HeaderText = "Supplier Name"
        Me.supplierName.Name = "supplierName"
        Me.supplierName.ReadOnly = True
        Me.supplierName.Width = 101
        '
        'btnAdd
        '
        Me.btnAdd.DataPropertyName = "supplierID"
        Me.btnAdd.HeaderText = ""
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ReadOnly = True
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseColumnTextForButtonValue = True
        Me.btnAdd.Width = 58
        '
        'frmUpdateInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 495)
        Me.Controls.Add(Me.dgvSuppliers)
        Me.Controls.Add(Me.btnCreateProduct)
        Me.Controls.Add(Me.txtInventoryCount)
        Me.Controls.Add(Me.txtReorderAmount)
        Me.Controls.Add(Me.txtPurchaseUnit)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.txtSKU)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.txtInventoryID)
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
        Me.MaximizeBox = False
        Me.Name = "frmUpdateInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtInventoryID As TextBox
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents txtUnitCost As TextBox
    Friend WithEvents txtPurchaseUnit As TextBox
    Friend WithEvents txtReorderAmount As TextBox
    Friend WithEvents txtInventoryCount As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents btnCreateProduct As Button
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As GEDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents supplierID As DataGridViewTextBoxColumn
    Friend WithEvents supplierName As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As DataGridViewButtonColumn
End Class
