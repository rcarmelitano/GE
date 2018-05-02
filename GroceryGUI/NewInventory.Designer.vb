<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewInventory
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
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreateProduct = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInventoryID = New System.Windows.Forms.TextBox()
        Me.txtUnitCost = New System.Windows.Forms.TextBox()
        Me.txtPurchaseUnit = New System.Windows.Forms.TextBox()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CategoriesTableAdapter()
        Me.SuppliersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.SuppliersTableAdapter()
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DepartmentsTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ViewInventoryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(379, 24)
        Me.MenuStrip1.TabIndex = 60
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ViewInventoryToolStripMenuItem
        '
        Me.ViewInventoryToolStripMenuItem.Name = "ViewInventoryToolStripMenuItem"
        Me.ViewInventoryToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ViewInventoryToolStripMenuItem.Text = "View Inventory"
        '
        'btnCreateProduct
        '
        Me.btnCreateProduct.Location = New System.Drawing.Point(101, 329)
        Me.btnCreateProduct.Name = "btnCreateProduct"
        Me.btnCreateProduct.Size = New System.Drawing.Size(179, 43)
        Me.btnCreateProduct.TabIndex = 66
        Me.btnCreateProduct.Text = "Create Product"
        Me.btnCreateProduct.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Purchase Unit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Inventory ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Unit Cost:"
        '
        'txtInventoryID
        '
        Me.txtInventoryID.Location = New System.Drawing.Point(163, 41)
        Me.txtInventoryID.Name = "txtInventoryID"
        Me.txtInventoryID.ReadOnly = True
        Me.txtInventoryID.Size = New System.Drawing.Size(145, 20)
        Me.txtInventoryID.TabIndex = 90
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Location = New System.Drawing.Point(163, 75)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(145, 20)
        Me.txtUnitCost.TabIndex = 91
        '
        'txtPurchaseUnit
        '
        Me.txtPurchaseUnit.Location = New System.Drawing.Point(163, 109)
        Me.txtPurchaseUnit.Name = "txtPurchaseUnit"
        Me.txtPurchaseUnit.Size = New System.Drawing.Size(145, 20)
        Me.txtPurchaseUnit.TabIndex = 92
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Location = New System.Drawing.Point(80, 149)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(97, 20)
        Me.txtSupplierID.TabIndex = 99
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AutoGenerateColumns = False
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.supplierName, Me.btnAdd})
        Me.dgvSuppliers.DataSource = Me.SuppliersBindingSource
        Me.dgvSuppliers.Location = New System.Drawing.Point(15, 175)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.Size = New System.Drawing.Size(352, 141)
        Me.dgvSuppliers.TabIndex = 97
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplierIDDataGridViewTextBoxColumn.Width = 79
        '
        'supplierName
        '
        Me.supplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.supplierName.DataPropertyName = "supplierName"
        Me.supplierName.HeaderText = "supplierName"
        Me.supplierName.Name = "supplierName"
        Me.supplierName.ReadOnly = True
        Me.supplierName.Width = 96
        '
        'btnAdd
        '
        Me.btnAdd.DataPropertyName = "supplierID"
        Me.btnAdd.HeaderText = ""
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ReadOnly = True
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseColumnTextForButtonValue = True
        Me.btnAdd.Width = 70
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "Supplier ID:"
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.GEDataSet
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'DepartmentsBindingSource
        '
        Me.DepartmentsBindingSource.DataMember = "Departments"
        Me.DepartmentsBindingSource.DataSource = Me.GEDataSet
        '
        'DepartmentsTableAdapter
        '
        Me.DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'frmNewInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 377)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.dgvSuppliers)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPurchaseUnit)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.txtInventoryID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCreateProduct)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmNewInventory"
        Me.Text = "Inventory"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCreateProduct As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtInventoryID As TextBox
    Friend WithEvents txtUnitCost As TextBox
    Friend WithEvents txtPurchaseUnit As TextBox
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents ViewInventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As GEDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As GEDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents supplierName As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As DataGridViewButtonColumn
End Class
