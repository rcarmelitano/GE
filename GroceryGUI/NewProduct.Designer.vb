<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewProduct
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
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddDepartment = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DepartmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddCategory = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CategoriesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CategoryIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CategoryIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CategoryIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CategoryIDToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CategoryIDToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CategoryIDToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.CategoryIDToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CategoriesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CategoriesTableAdapter()
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DepartmentsTableAdapter()
        Me.DepartmentIDSearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DepartmentIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DepartmentIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DepartmentIDSearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTaxable = New System.Windows.Forms.CheckBox()
        Me.txtUPC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRetailUnit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.CheckBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.txtRetailCost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbYes = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mtxtSKU = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.CategoryIDToolStrip.SuspendLayout()
        Me.CategoryIDToolStrip1.SuspendLayout()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartmentIDSearchToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(97, 219)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.ReadOnly = True
        Me.txtDepartmentID.Size = New System.Drawing.Size(97, 20)
        Me.txtDepartmentID.TabIndex = 104
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Location = New System.Drawing.Point(435, 219)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.ReadOnly = True
        Me.txtCategoryID.Size = New System.Drawing.Size(97, 20)
        Me.txtCategoryID.TabIndex = 103
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.AutoGenerateColumns = False
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn1, Me.btnAddDepartment})
        Me.dgvDepartments.DataSource = Me.DepartmentsBindingSource1
        Me.dgvDepartments.Location = New System.Drawing.Point(9, 250)
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.ReadOnly = True
        Me.dgvDepartments.RowHeadersVisible = False
        Me.dgvDepartments.Size = New System.Drawing.Size(273, 141)
        Me.dgvDepartments.TabIndex = 101
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        Me.DepartmentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentIDDataGridViewTextBoxColumn.Width = 76
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Width = 58
        '
        'btnAddDepartment
        '
        Me.btnAddDepartment.HeaderText = ""
        Me.btnAddDepartment.Name = "btnAddDepartment"
        Me.btnAddDepartment.ReadOnly = True
        Me.btnAddDepartment.Text = "Add"
        Me.btnAddDepartment.UseColumnTextForButtonValue = True
        Me.btnAddDepartment.Width = 53
        '
        'DepartmentsBindingSource1
        '
        Me.DepartmentsBindingSource1.DataMember = "Departments"
        Me.DepartmentsBindingSource1.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Department ID:"
        '
        'dgvCategories
        '
        Me.dgvCategories.AllowUserToAddRows = False
        Me.dgvCategories.AllowUserToDeleteRows = False
        Me.dgvCategories.AutoGenerateColumns = False
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.btnAddCategory})
        Me.dgvCategories.DataSource = Me.CategoriesBindingSource2
        Me.dgvCategories.Location = New System.Drawing.Point(366, 250)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.ReadOnly = True
        Me.dgvCategories.RowHeadersVisible = False
        Me.dgvCategories.Size = New System.Drawing.Size(274, 141)
        Me.dgvCategories.TabIndex = 97
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIDDataGridViewTextBoxColumn.Width = 76
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 58
        '
        'btnAddCategory
        '
        Me.btnAddCategory.DataPropertyName = "categoryID"
        Me.btnAddCategory.HeaderText = ""
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.ReadOnly = True
        Me.btnAddCategory.Text = "Add"
        Me.btnAddCategory.UseColumnTextForButtonValue = True
        Me.btnAddCategory.Width = 65
        '
        'CategoriesBindingSource2
        '
        Me.CategoriesBindingSource2.DataMember = "Categories"
        Me.CategoriesBindingSource2.DataSource = Me.GEDataSet
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Category ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.ViewProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 105
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'ViewProductsToolStripMenuItem
        '
        Me.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem"
        Me.ViewProductsToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ViewProductsToolStripMenuItem.Text = "View Products"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CategoryIDToolStrip
        '
        Me.CategoryIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoryIDToolStripLabel, Me.CategoryIDToolStripTextBox, Me.CategoryIDToolStripButton})
        Me.CategoryIDToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.CategoryIDToolStrip.Name = "CategoryIDToolStrip"
        Me.CategoryIDToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.CategoryIDToolStrip.TabIndex = 106
        Me.CategoryIDToolStrip.Text = "CategoryIDToolStrip"
        Me.CategoryIDToolStrip.Visible = False
        '
        'CategoryIDToolStripLabel
        '
        Me.CategoryIDToolStripLabel.Name = "CategoryIDToolStripLabel"
        Me.CategoryIDToolStripLabel.Size = New System.Drawing.Size(67, 22)
        Me.CategoryIDToolStripLabel.Text = "categoryID:"
        '
        'CategoryIDToolStripTextBox
        '
        Me.CategoryIDToolStripTextBox.Name = "CategoryIDToolStripTextBox"
        Me.CategoryIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'CategoryIDToolStripButton
        '
        Me.CategoryIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CategoryIDToolStripButton.Name = "CategoryIDToolStripButton"
        Me.CategoryIDToolStripButton.Size = New System.Drawing.Size(68, 22)
        Me.CategoryIDToolStripButton.Text = "categoryID"
        '
        'CategoryIDToolStrip1
        '
        Me.CategoryIDToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoryIDToolStripLabel1, Me.CategoryIDToolStripTextBox1, Me.CategoryIDToolStripButton1})
        Me.CategoryIDToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.CategoryIDToolStrip1.Name = "CategoryIDToolStrip1"
        Me.CategoryIDToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.CategoryIDToolStrip1.TabIndex = 107
        Me.CategoryIDToolStrip1.Text = "CategoryIDToolStrip1"
        Me.CategoryIDToolStrip1.Visible = False
        '
        'CategoryIDToolStripLabel1
        '
        Me.CategoryIDToolStripLabel1.Name = "CategoryIDToolStripLabel1"
        Me.CategoryIDToolStripLabel1.Size = New System.Drawing.Size(67, 22)
        Me.CategoryIDToolStripLabel1.Text = "categoryID:"
        '
        'CategoryIDToolStripTextBox1
        '
        Me.CategoryIDToolStripTextBox1.Name = "CategoryIDToolStripTextBox1"
        Me.CategoryIDToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'CategoryIDToolStripButton1
        '
        Me.CategoryIDToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CategoryIDToolStripButton1.Name = "CategoryIDToolStripButton1"
        Me.CategoryIDToolStripButton1.Size = New System.Drawing.Size(68, 22)
        Me.CategoryIDToolStripButton1.Text = "categoryID"
        '
        'CategoriesBindingSource1
        '
        Me.CategoriesBindingSource1.DataMember = "Categories"
        Me.CategoriesBindingSource1.DataSource = Me.GEDataSet
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
        'DepartmentsBindingSource
        '
        Me.DepartmentsBindingSource.DataMember = "Departments"
        Me.DepartmentsBindingSource.DataSource = Me.GEDataSet
        '
        'DepartmentsTableAdapter
        '
        Me.DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'DepartmentIDSearchToolStrip
        '
        Me.DepartmentIDSearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentIDToolStripLabel, Me.DepartmentIDToolStripTextBox, Me.DepartmentIDSearchToolStripButton})
        Me.DepartmentIDSearchToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.DepartmentIDSearchToolStrip.Name = "DepartmentIDSearchToolStrip"
        Me.DepartmentIDSearchToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.DepartmentIDSearchToolStrip.TabIndex = 108
        Me.DepartmentIDSearchToolStrip.Text = "DepartmentIDSearchToolStrip"
        Me.DepartmentIDSearchToolStrip.Visible = False
        '
        'DepartmentIDToolStripLabel
        '
        Me.DepartmentIDToolStripLabel.Name = "DepartmentIDToolStripLabel"
        Me.DepartmentIDToolStripLabel.Size = New System.Drawing.Size(83, 22)
        Me.DepartmentIDToolStripLabel.Text = "departmentID:"
        '
        'DepartmentIDToolStripTextBox
        '
        Me.DepartmentIDToolStripTextBox.Name = "DepartmentIDToolStripTextBox"
        Me.DepartmentIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DepartmentIDSearchToolStripButton
        '
        Me.DepartmentIDSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DepartmentIDSearchToolStripButton.Name = "DepartmentIDSearchToolStripButton"
        Me.DepartmentIDSearchToolStripButton.Size = New System.Drawing.Size(119, 22)
        Me.DepartmentIDSearchToolStripButton.Text = "departmentIDSearch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "SKU:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(97, 137)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Product Name:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(97, 170)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(185, 20)
        Me.txtDescription.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Description:"
        '
        'cbTaxable
        '
        Me.cbTaxable.AutoSize = True
        Me.cbTaxable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbTaxable.Location = New System.Drawing.Point(376, 103)
        Me.cbTaxable.Name = "cbTaxable"
        Me.cbTaxable.Size = New System.Drawing.Size(67, 17)
        Me.cbTaxable.TabIndex = 116
        Me.cbTaxable.Text = "Taxable:"
        Me.cbTaxable.UseVisualStyleBackColor = True
        '
        'txtUPC
        '
        Me.txtUPC.Location = New System.Drawing.Point(97, 101)
        Me.txtUPC.Name = "txtUPC"
        Me.txtUPC.ReadOnly = True
        Me.txtUPC.Size = New System.Drawing.Size(100, 20)
        Me.txtUPC.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "UPC:"
        '
        'txtRetailUnit
        '
        Me.txtRetailUnit.Location = New System.Drawing.Point(429, 46)
        Me.txtRetailUnit.Name = "txtRetailUnit"
        Me.txtRetailUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtRetailUnit.TabIndex = 120
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Retail Unit:"
        '
        'cbStatus
        '
        Me.cbStatus.AutoSize = True
        Me.cbStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbStatus.Checked = True
        Me.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatus.Location = New System.Drawing.Point(384, 75)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(59, 17)
        Me.cbStatus.TabIndex = 121
        Me.cbStatus.Text = "Status:"
        Me.cbStatus.UseVisualStyleBackColor = True
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(228, 409)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(190, 45)
        Me.btnContinue.TabIndex = 122
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'txtRetailCost
        '
        Me.txtRetailCost.Location = New System.Drawing.Point(429, 133)
        Me.txtRetailCost.Name = "txtRetailCost"
        Me.txtRetailCost.Size = New System.Drawing.Size(100, 20)
        Me.txtRetailCost.TabIndex = 124
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Retail Cost:"
        '
        'rbYes
        '
        Me.rbYes.AutoSize = True
        Me.rbYes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbYes.Location = New System.Drawing.Point(94, 75)
        Me.rbYes.Name = "rbYes"
        Me.rbYes.Size = New System.Drawing.Size(43, 17)
        Me.rbYes.TabIndex = 125
        Me.rbYes.TabStop = True
        Me.rbYes.Text = "Yes"
        Me.rbYes.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbNo.Location = New System.Drawing.Point(158, 75)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 126
        Me.rbNo.TabStop = True
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Hotkey Item:"
        '
        'mtxtSKU
        '
        Me.mtxtSKU.Location = New System.Drawing.Point(97, 46)
        Me.mtxtSKU.Mask = "AAAAAA-000-000"
        Me.mtxtSKU.Name = "mtxtSKU"
        Me.mtxtSKU.Size = New System.Drawing.Size(100, 20)
        Me.mtxtSKU.TabIndex = 128
        '
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 461)
        Me.Controls.Add(Me.mtxtSKU)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbNo)
        Me.Controls.Add(Me.rbYes)
        Me.Controls.Add(Me.txtRetailCost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.txtRetailUnit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUPC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbTaxable)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CategoryIDToolStrip)
        Me.Controls.Add(Me.CategoryIDToolStrip1)
        Me.Controls.Add(Me.DepartmentIDSearchToolStrip)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.txtCategoryID)
        Me.Controls.Add(Me.dgvDepartments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCategories)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmNewProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewProduct"
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.CategoryIDToolStrip.ResumeLayout(False)
        Me.CategoryIDToolStrip.PerformLayout()
        Me.CategoryIDToolStrip1.ResumeLayout(False)
        Me.CategoryIDToolStrip1.PerformLayout()
        CType(Me.CategoriesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartmentIDSearchToolStrip.ResumeLayout(False)
        Me.DepartmentIDSearchToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCategories As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As GEDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents CategoriesBindingSource1 As BindingSource
    Friend WithEvents CategoryIDToolStrip As ToolStrip
    Friend WithEvents CategoryIDToolStripLabel As ToolStripLabel
    Friend WithEvents CategoryIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents CategoryIDToolStripButton As ToolStripButton
    Friend WithEvents CategoriesBindingSource2 As BindingSource
    Friend WithEvents CategoryIDToolStrip1 As ToolStrip
    Friend WithEvents CategoryIDToolStripLabel1 As ToolStripLabel
    Friend WithEvents CategoryIDToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents CategoryIDToolStripButton1 As ToolStripButton
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents DepartmentsBindingSource1 As BindingSource
    Friend WithEvents DepartmentIDSearchToolStrip As ToolStrip
    Friend WithEvents DepartmentIDToolStripLabel As ToolStripLabel
    Friend WithEvents DepartmentIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents DepartmentIDSearchToolStripButton As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTaxable As CheckBox
    Friend WithEvents txtUPC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRetailUnit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbStatus As CheckBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents txtRetailCost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddDepartment As DataGridViewButtonColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddCategory As DataGridViewButtonColumn
    Friend WithEvents rbYes As RadioButton
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents mtxtSKU As MaskedTextBox
End Class
