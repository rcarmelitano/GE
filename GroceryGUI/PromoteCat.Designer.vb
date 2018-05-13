<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoteCat
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
        Me.lblSelPromo = New System.Windows.Forms.Label()
        Me.cmbPromoSel = New System.Windows.Forms.ComboBox()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.lblSelCat = New System.Windows.Forms.Label()
        Me.cmbCatSel = New System.Windows.Forms.ComboBox()
        Me.btnPromote = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CategoriesTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PromotedCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Promoted_CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Promoted_CategoriesTableAdapter()
        Me.lblDgvLabel = New System.Windows.Forms.Label()
        Me.PromotionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promotion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promoted_DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Promoted_DepartmentsTableAdapter()
        Me.PromotionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DepartmentsTableAdapter()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotedCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelPromo
        '
        Me.lblSelPromo.AutoSize = True
        Me.lblSelPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSelPromo.Location = New System.Drawing.Point(12, 9)
        Me.lblSelPromo.Name = "lblSelPromo"
        Me.lblSelPromo.Size = New System.Drawing.Size(113, 16)
        Me.lblSelPromo.TabIndex = 3
        Me.lblSelPromo.Text = "Select Promotion:"
        '
        'cmbPromoSel
        '
        Me.cmbPromoSel.DataSource = Me.PromotionsBindingSource
        Me.cmbPromoSel.DisplayMember = "title"
        Me.cmbPromoSel.FormattingEnabled = True
        Me.cmbPromoSel.Location = New System.Drawing.Point(131, 8)
        Me.cmbPromoSel.Name = "cmbPromoSel"
        Me.cmbPromoSel.Size = New System.Drawing.Size(190, 21)
        Me.cmbPromoSel.TabIndex = 4
        Me.cmbPromoSel.ValueMember = "promotionID"
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
        'lblSelCat
        '
        Me.lblSelCat.AutoSize = True
        Me.lblSelCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSelCat.Location = New System.Drawing.Point(18, 47)
        Me.lblSelCat.Name = "lblSelCat"
        Me.lblSelCat.Size = New System.Drawing.Size(107, 16)
        Me.lblSelCat.TabIndex = 5
        Me.lblSelCat.Text = "Select Category:"
        '
        'cmbCatSel
        '
        Me.cmbCatSel.DataSource = Me.CategoriesBindingSource
        Me.cmbCatSel.DisplayMember = "name"
        Me.cmbCatSel.FormattingEnabled = True
        Me.cmbCatSel.Location = New System.Drawing.Point(131, 46)
        Me.cmbCatSel.Name = "cmbCatSel"
        Me.cmbCatSel.Size = New System.Drawing.Size(190, 21)
        Me.cmbCatSel.TabIndex = 6
        Me.cmbCatSel.ValueMember = "categoryID"
        '
        'btnPromote
        '
        Me.btnPromote.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnPromote.Location = New System.Drawing.Point(110, 84)
        Me.btnPromote.Name = "btnPromote"
        Me.btnPromote.Size = New System.Drawing.Size(128, 32)
        Me.btnPromote.TabIndex = 7
        Me.btnPromote.Text = "Promote"
        Me.btnPromote.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Button2.Location = New System.Drawing.Point(110, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 32)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = True
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionIDDataGridViewTextBoxColumn, Me.Promotion, Me.Category, Me.CategoryIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PromotedCategoriesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(309, 261)
        Me.DataGridView1.TabIndex = 9
        '
        'PromotedCategoriesBindingSource
        '
        Me.PromotedCategoriesBindingSource.DataMember = "Promoted_Categories"
        Me.PromotedCategoriesBindingSource.DataSource = Me.GEDataSet
        '
        'Promoted_CategoriesTableAdapter
        '
        Me.Promoted_CategoriesTableAdapter.ClearBeforeFill = True
        '
        'lblDgvLabel
        '
        Me.lblDgvLabel.AutoSize = True
        Me.lblDgvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblDgvLabel.Location = New System.Drawing.Point(12, 131)
        Me.lblDgvLabel.Name = "lblDgvLabel"
        Me.lblDgvLabel.Size = New System.Drawing.Size(131, 16)
        Me.lblDgvLabel.TabIndex = 10
        Me.lblDgvLabel.Text = "Existing Connections"
        '
        'PromotionsBindingSource1
        '
        Me.PromotionsBindingSource1.DataMember = "Promotions"
        Me.PromotionsBindingSource1.DataSource = Me.GEDataSet
        '
        'CategoriesBindingSource1
        '
        Me.CategoriesBindingSource1.DataMember = "Categories"
        Me.CategoriesBindingSource1.DataSource = Me.GEDataSet
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        Me.PromotionIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PromotionIDDataGridViewTextBoxColumn.Visible = False
        '
        'Promotion
        '
        Me.Promotion.DataPropertyName = "promotionID"
        Me.Promotion.DataSource = Me.PromotionsBindingSource1
        Me.Promotion.DisplayMember = "title"
        Me.Promotion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Promotion.HeaderText = "Promotion"
        Me.Promotion.Name = "Promotion"
        Me.Promotion.ReadOnly = True
        Me.Promotion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Promotion.ValueMember = "promotionID"
        Me.Promotion.Width = 120
        '
        'Category
        '
        Me.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Category.DataPropertyName = "categoryID"
        Me.Category.DataSource = Me.CategoriesBindingSource1
        Me.Category.DisplayMember = "name"
        Me.Category.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Category.ValueMember = "categoryID"
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIDDataGridViewTextBoxColumn.Visible = False
        '
        'Promoted_DepartmentsTableAdapter
        '
        Me.Promoted_DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'PromotionsBindingSource2
        '
        Me.PromotionsBindingSource2.DataMember = "Promotions"
        Me.PromotionsBindingSource2.DataSource = Me.GEDataSet
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
        'PromoteCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 461)
        Me.Controls.Add(Me.lblDgvLabel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPromote)
        Me.Controls.Add(Me.cmbCatSel)
        Me.Controls.Add(Me.lblSelCat)
        Me.Controls.Add(Me.cmbPromoSel)
        Me.Controls.Add(Me.lblSelPromo)
        Me.Name = "PromoteCat"
        Me.Text = "Promote Category"
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotedCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelPromo As Label
    Friend WithEvents cmbPromoSel As ComboBox
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents lblSelCat As Label
    Friend WithEvents cmbCatSel As ComboBox
    Friend WithEvents btnPromote As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As GEDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PromotedCategoriesBindingSource As BindingSource
    Friend WithEvents Promoted_CategoriesTableAdapter As GEDataSetTableAdapters.Promoted_CategoriesTableAdapter
    Friend WithEvents PromotionsBindingSource1 As BindingSource
    Friend WithEvents CategoriesBindingSource1 As BindingSource
    Friend WithEvents lblDgvLabel As Label
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Promotion As DataGridViewComboBoxColumn
    Friend WithEvents Category As DataGridViewComboBoxColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Promoted_DepartmentsTableAdapter As GEDataSetTableAdapters.Promoted_DepartmentsTableAdapter
    Friend WithEvents PromotionsBindingSource2 As BindingSource
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
End Class
