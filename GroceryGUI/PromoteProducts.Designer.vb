<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoteProducts
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbPromoSel = New System.Windows.Forms.ComboBox()
        Me.lblSelPromo = New System.Windows.Forms.Label()
        Me.lblSelProd = New System.Windows.Forms.Label()
        Me.btnPromote = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ProductsTableAdapter()
        Me.cmbProductSel = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.CategoryIDDataGridViewTextBoxColumn, Me.DepartmentIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.TaxableDataGridViewCheckBoxColumn, Me.UPCDataGridViewTextBoxColumn, Me.RetailUnitDataGridViewTextBoxColumn, Me.RetailCostDataGridViewTextBoxColumn, Me.StatusDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(908, 293)
        Me.DataGridView1.TabIndex = 0
        '
        'cmbPromoSel
        '
        Me.cmbPromoSel.DataSource = Me.PromotionsBindingSource
        Me.cmbPromoSel.DisplayMember = "title"
        Me.cmbPromoSel.FormattingEnabled = True
        Me.cmbPromoSel.Location = New System.Drawing.Point(131, 8)
        Me.cmbPromoSel.Name = "cmbPromoSel"
        Me.cmbPromoSel.Size = New System.Drawing.Size(204, 21)
        Me.cmbPromoSel.TabIndex = 1
        Me.cmbPromoSel.ValueMember = "promotionID"
        '
        'lblSelPromo
        '
        Me.lblSelPromo.AutoSize = True
        Me.lblSelPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSelPromo.Location = New System.Drawing.Point(12, 9)
        Me.lblSelPromo.Name = "lblSelPromo"
        Me.lblSelPromo.Size = New System.Drawing.Size(113, 16)
        Me.lblSelPromo.TabIndex = 2
        Me.lblSelPromo.Text = "Select Promotion:"
        '
        'lblSelProd
        '
        Me.lblSelProd.AutoSize = True
        Me.lblSelProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSelProd.Location = New System.Drawing.Point(12, 44)
        Me.lblSelProd.Name = "lblSelProd"
        Me.lblSelProd.Size = New System.Drawing.Size(98, 16)
        Me.lblSelProd.TabIndex = 3
        Me.lblSelProd.Text = "Select Product:"
        '
        'btnPromote
        '
        Me.btnPromote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnPromote.Location = New System.Drawing.Point(363, 12)
        Me.btnPromote.Name = "btnPromote"
        Me.btnPromote.Size = New System.Drawing.Size(184, 43)
        Me.btnPromote.TabIndex = 4
        Me.btnPromote.Text = "Promote"
        Me.btnPromote.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnReturn.Location = New System.Drawing.Point(738, 395)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(184, 43)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.GEDataSet
        '
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.GEDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'cmbProductSel
        '
        Me.cmbProductSel.DataSource = Me.ProductsBindingSource
        Me.cmbProductSel.DisplayMember = "productName"
        Me.cmbProductSel.FormattingEnabled = True
        Me.cmbProductSel.Location = New System.Drawing.Point(131, 43)
        Me.cmbProductSel.Name = "cmbProductSel"
        Me.cmbProductSel.Size = New System.Drawing.Size(204, 21)
        Me.cmbProductSel.TabIndex = 6
        Me.cmbProductSel.ValueMember = "SKU"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnView.Location = New System.Drawing.Point(15, 395)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(184, 43)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "View Promoted Products"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIDDataGridViewTextBoxColumn.Visible = False
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        Me.DepartmentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentIDDataGridViewTextBoxColumn.Visible = False
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaxableDataGridViewCheckBoxColumn
        '
        Me.TaxableDataGridViewCheckBoxColumn.DataPropertyName = "taxable"
        Me.TaxableDataGridViewCheckBoxColumn.HeaderText = "Taxable"
        Me.TaxableDataGridViewCheckBoxColumn.Name = "TaxableDataGridViewCheckBoxColumn"
        Me.TaxableDataGridViewCheckBoxColumn.ReadOnly = True
        Me.TaxableDataGridViewCheckBoxColumn.Width = 55
        '
        'UPCDataGridViewTextBoxColumn
        '
        Me.UPCDataGridViewTextBoxColumn.DataPropertyName = "UPC"
        Me.UPCDataGridViewTextBoxColumn.HeaderText = "UPC"
        Me.UPCDataGridViewTextBoxColumn.Name = "UPCDataGridViewTextBoxColumn"
        Me.UPCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RetailUnitDataGridViewTextBoxColumn
        '
        Me.RetailUnitDataGridViewTextBoxColumn.DataPropertyName = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.HeaderText = "Retail Unit"
        Me.RetailUnitDataGridViewTextBoxColumn.Name = "RetailUnitDataGridViewTextBoxColumn"
        Me.RetailUnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RetailCostDataGridViewTextBoxColumn
        '
        Me.RetailCostDataGridViewTextBoxColumn.DataPropertyName = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.HeaderText = "Retail Cost"
        Me.RetailCostDataGridViewTextBoxColumn.Name = "RetailCostDataGridViewTextBoxColumn"
        Me.RetailCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewCheckBoxColumn
        '
        Me.StatusDataGridViewCheckBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewCheckBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewCheckBoxColumn.Name = "StatusDataGridViewCheckBoxColumn"
        Me.StatusDataGridViewCheckBoxColumn.ReadOnly = True
        Me.StatusDataGridViewCheckBoxColumn.Width = 50
        '
        'PromoteProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 450)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.cmbProductSel)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnPromote)
        Me.Controls.Add(Me.lblSelProd)
        Me.Controls.Add(Me.lblSelPromo)
        Me.Controls.Add(Me.cmbPromoSel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PromoteProducts"
        Me.Text = "Promote Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbPromoSel As ComboBox
    Friend WithEvents lblSelPromo As Label
    Friend WithEvents lblSelProd As Label
    Friend WithEvents btnPromote As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As GEDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents cmbProductSel As ComboBox
    Friend WithEvents btnView As Button
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
End Class
