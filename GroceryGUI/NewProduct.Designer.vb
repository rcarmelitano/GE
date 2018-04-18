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
        Me.btnClearDepartmentID = New System.Windows.Forms.Button()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.btnSearchDepartmentID = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClearCategoryID = New System.Windows.Forms.Button()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSearchCategoryID = New System.Windows.Forms.Button()
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
        Me.txtDepartmentID.Location = New System.Drawing.Point(93, 226)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(113, 20)
        Me.txtDepartmentID.TabIndex = 104
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Location = New System.Drawing.Point(438, 226)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(126, 20)
        Me.txtCategoryID.TabIndex = 103
        '
        'btnClearDepartmentID
        '
        Me.btnClearDepartmentID.Location = New System.Drawing.Point(94, 404)
        Me.btnClearDepartmentID.Name = "btnClearDepartmentID"
        Me.btnClearDepartmentID.Size = New System.Drawing.Size(98, 39)
        Me.btnClearDepartmentID.TabIndex = 102
        Me.btnClearDepartmentID.Text = "Clear"
        Me.btnClearDepartmentID.UseVisualStyleBackColor = True
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.AutoGenerateColumns = False
        Me.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn1})
        Me.dgvDepartments.DataSource = Me.DepartmentsBindingSource1
        Me.dgvDepartments.Location = New System.Drawing.Point(12, 257)
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
        Me.DepartmentIDDataGridViewTextBoxColumn.Width = 96
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Width = 58
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
        'btnSearchDepartmentID
        '
        Me.btnSearchDepartmentID.Location = New System.Drawing.Point(212, 224)
        Me.btnSearchDepartmentID.Name = "btnSearchDepartmentID"
        Me.btnSearchDepartmentID.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchDepartmentID.TabIndex = 100
        Me.btnSearchDepartmentID.Text = "Search"
        Me.btnSearchDepartmentID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Department ID:"
        '
        'btnClearCategoryID
        '
        Me.btnClearCategoryID.Location = New System.Drawing.Point(452, 404)
        Me.btnClearCategoryID.Name = "btnClearCategoryID"
        Me.btnClearCategoryID.Size = New System.Drawing.Size(98, 39)
        Me.btnClearCategoryID.TabIndex = 98
        Me.btnClearCategoryID.Text = "Clear"
        Me.btnClearCategoryID.UseVisualStyleBackColor = True
        '
        'dgvCategories
        '
        Me.dgvCategories.AllowUserToAddRows = False
        Me.dgvCategories.AllowUserToDeleteRows = False
        Me.dgvCategories.AutoGenerateColumns = False
        Me.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.dgvCategories.DataSource = Me.CategoriesBindingSource2
        Me.dgvCategories.Location = New System.Drawing.Point(369, 257)
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
        Me.CategoryIDDataGridViewTextBoxColumn.Width = 84
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 58
        '
        'CategoriesBindingSource2
        '
        Me.CategoriesBindingSource2.DataMember = "Categories"
        Me.CategoriesBindingSource2.DataSource = Me.GEDataSet
        '
        'btnSearchCategoryID
        '
        Me.btnSearchCategoryID.Location = New System.Drawing.Point(570, 224)
        Me.btnSearchCategoryID.Name = "btnSearchCategoryID"
        Me.btnSearchCategoryID.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCategoryID.TabIndex = 96
        Me.btnSearchCategoryID.Text = "Search"
        Me.btnSearchCategoryID.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(366, 229)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
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
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 457)
        Me.Controls.Add(Me.CategoryIDToolStrip)
        Me.Controls.Add(Me.CategoryIDToolStrip1)
        Me.Controls.Add(Me.DepartmentIDSearchToolStrip)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.txtCategoryID)
        Me.Controls.Add(Me.btnClearDepartmentID)
        Me.Controls.Add(Me.dgvDepartments)
        Me.Controls.Add(Me.btnSearchDepartmentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClearCategoryID)
        Me.Controls.Add(Me.dgvCategories)
        Me.Controls.Add(Me.btnSearchCategoryID)
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
    Friend WithEvents btnClearDepartmentID As Button
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents btnSearchDepartmentID As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearCategoryID As Button
    Friend WithEvents dgvCategories As DataGridView
    Friend WithEvents btnSearchCategoryID As Button
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
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoriesBindingSource2 As BindingSource
    Friend WithEvents CategoryIDToolStrip1 As ToolStrip
    Friend WithEvents CategoryIDToolStripLabel1 As ToolStripLabel
    Friend WithEvents CategoryIDToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents CategoryIDToolStripButton1 As ToolStripButton
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentsBindingSource1 As BindingSource
    Friend WithEvents DepartmentIDSearchToolStrip As ToolStrip
    Friend WithEvents DepartmentIDToolStripLabel As ToolStripLabel
    Friend WithEvents DepartmentIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents DepartmentIDSearchToolStripButton As ToolStripButton
End Class
