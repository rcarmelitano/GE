<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.NewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ProductsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ProductsTableAdapter()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UpdateProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.NewProductToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1324, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewProductToolStripMenuItem
        '
        Me.NewProductToolStripMenuItem.Name = "NewProductToolStripMenuItem"
        Me.NewProductToolStripMenuItem.Size = New System.Drawing.Size(106, 24)
        Me.NewProductToolStripMenuItem.Text = "New Product"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoGenerateColumns = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.CategoryIDDataGridViewTextBoxColumn, Me.DepartmentIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TaxableDataGridViewCheckBoxColumn, Me.UPCDataGridViewTextBoxColumn, Me.RetailUnitDataGridViewTextBoxColumn, Me.RetailCostDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn, Me.UpdateProduct, Me.DeleteProduct})
        Me.dgvProducts.DataSource = Me.ProductsBindingSource
        Me.dgvProducts.Location = New System.Drawing.Point(16, 33)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.Size = New System.Drawing.Size(1295, 506)
        Me.dgvProducts.TabIndex = 1
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 65
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIDDataGridViewTextBoxColumn.Width = 105
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        Me.DepartmentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentIDDataGridViewTextBoxColumn.Width = 122
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 122
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 70
        '
        'TaxableDataGridViewCheckBoxColumn
        '
        Me.TaxableDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TaxableDataGridViewCheckBoxColumn.DataPropertyName = "taxable"
        Me.TaxableDataGridViewCheckBoxColumn.HeaderText = "taxable"
        Me.TaxableDataGridViewCheckBoxColumn.Name = "TaxableDataGridViewCheckBoxColumn"
        Me.TaxableDataGridViewCheckBoxColumn.ReadOnly = True
        Me.TaxableDataGridViewCheckBoxColumn.Width = 59
        '
        'UPCDataGridViewTextBoxColumn
        '
        Me.UPCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UPCDataGridViewTextBoxColumn.DataPropertyName = "UPC"
        Me.UPCDataGridViewTextBoxColumn.HeaderText = "UPC"
        Me.UPCDataGridViewTextBoxColumn.Name = "UPCDataGridViewTextBoxColumn"
        Me.UPCDataGridViewTextBoxColumn.ReadOnly = True
        Me.UPCDataGridViewTextBoxColumn.Width = 65
        '
        'RetailUnitDataGridViewTextBoxColumn
        '
        Me.RetailUnitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RetailUnitDataGridViewTextBoxColumn.DataPropertyName = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.HeaderText = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.Name = "RetailUnitDataGridViewTextBoxColumn"
        Me.RetailUnitDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailUnitDataGridViewTextBoxColumn.Width = 93
        '
        'RetailCostDataGridViewTextBoxColumn
        '
        Me.RetailCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RetailCostDataGridViewTextBoxColumn.DataPropertyName = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.HeaderText = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.Name = "RetailCostDataGridViewTextBoxColumn"
        Me.RetailCostDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailCostDataGridViewTextBoxColumn.Width = 96
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StatusDataGridViewCheckBoxColumn.Width = 52
        '
        'UpdateProduct
        '
        Me.UpdateProduct.HeaderText = ""
        Me.UpdateProduct.Name = "UpdateProduct"
        Me.UpdateProduct.Text = "Update"
        Me.UpdateProduct.ToolTipText = "Update Product"
        Me.UpdateProduct.UseColumnTextForButtonValue = True
        Me.UpdateProduct.Width = 51
        '
        'DeleteProduct
        '
        Me.DeleteProduct.HeaderText = ""
        Me.DeleteProduct.Name = "DeleteProduct"
        Me.DeleteProduct.Text = "Delete"
        Me.DeleteProduct.ToolTipText = "Delete a Product"
        Me.DeleteProduct.UseColumnTextForButtonValue = True
        Me.DeleteProduct.Width = 51
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 554)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As GEDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxableDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents UPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents UpdateProduct As DataGridViewButtonColumn
    Friend WithEvents DeleteProduct As DataGridViewButtonColumn
End Class
