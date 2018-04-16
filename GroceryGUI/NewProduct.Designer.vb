<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProduct
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
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.btnClearDepartmentID = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.btnSearchDepartmentID = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClearCategoryID = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSearchCategoryID = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CategoriesTableAdapter()
        Me.DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DepartmentsTableAdapter()
        Me.CategoryIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CategoryIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CategoryIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CategoryIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DepartmentIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DepartmentIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DepartmentIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DepartmentIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.CategoryIDToolStrip.SuspendLayout()
        Me.DepartmentIDToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(519, 220)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(113, 20)
        Me.txtDepartmentID.TabIndex = 104
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Location = New System.Drawing.Point(165, 220)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(126, 20)
        Me.txtCategoryID.TabIndex = 103
        '
        'btnClearDepartmentID
        '
        Me.btnClearDepartmentID.Location = New System.Drawing.Point(520, 398)
        Me.btnClearDepartmentID.Name = "btnClearDepartmentID"
        Me.btnClearDepartmentID.Size = New System.Drawing.Size(98, 39)
        Me.btnClearDepartmentID.TabIndex = 102
        Me.btnClearDepartmentID.Text = "Clear"
        Me.btnClearDepartmentID.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentIDDataGridViewTextBoxColumn1, Me.NameDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.DepartmentsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(438, 251)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(273, 141)
        Me.DataGridView2.TabIndex = 101
        '
        'DepartmentsBindingSource
        '
        Me.DepartmentsBindingSource.DataMember = "Departments"
        Me.DepartmentsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearchDepartmentID
        '
        Me.btnSearchDepartmentID.Location = New System.Drawing.Point(638, 218)
        Me.btnSearchDepartmentID.Name = "btnSearchDepartmentID"
        Me.btnSearchDepartmentID.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchDepartmentID.TabIndex = 100
        Me.btnSearchDepartmentID.Text = "Search"
        Me.btnSearchDepartmentID.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Department ID:"
        '
        'btnClearCategoryID
        '
        Me.btnClearCategoryID.Location = New System.Drawing.Point(179, 398)
        Me.btnClearCategoryID.Name = "btnClearCategoryID"
        Me.btnClearCategoryID.Size = New System.Drawing.Size(98, 39)
        Me.btnClearCategoryID.TabIndex = 98
        Me.btnClearCategoryID.Text = "Clear"
        Me.btnClearCategoryID.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CategoriesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(96, 251)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(274, 141)
        Me.DataGridView1.TabIndex = 97
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.GEDataSet
        '
        'btnSearchCategoryID
        '
        Me.btnSearchCategoryID.Location = New System.Drawing.Point(297, 218)
        Me.btnSearchCategoryID.Name = "btnSearchCategoryID"
        Me.btnSearchCategoryID.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCategoryID.TabIndex = 96
        Me.btnSearchCategoryID.Text = "Search"
        Me.btnSearchCategoryID.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Category ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.ViewProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 105
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
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
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'DepartmentsTableAdapter
        '
        Me.DepartmentsTableAdapter.ClearBeforeFill = True
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
        'DepartmentIDToolStrip
        '
        Me.DepartmentIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartmentIDToolStripLabel, Me.DepartmentIDToolStripTextBox, Me.DepartmentIDToolStripButton})
        Me.DepartmentIDToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.DepartmentIDToolStrip.Name = "DepartmentIDToolStrip"
        Me.DepartmentIDToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.DepartmentIDToolStrip.TabIndex = 107
        Me.DepartmentIDToolStrip.Text = "DepartmentIDToolStrip"
        Me.DepartmentIDToolStrip.Visible = False
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
        'DepartmentIDToolStripButton
        '
        Me.DepartmentIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DepartmentIDToolStripButton.Name = "DepartmentIDToolStripButton"
        Me.DepartmentIDToolStripButton.Size = New System.Drawing.Size(84, 22)
        Me.DepartmentIDToolStripButton.Text = "departmentID"
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "Category ID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CategoryIDDataGridViewTextBoxColumn.Width = 69
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.NameDataGridViewTextBoxColumn.Width = 41
        '
        'DepartmentIDDataGridViewTextBoxColumn1
        '
        Me.DepartmentIDDataGridViewTextBoxColumn1.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn1.HeaderText = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn1.Name = "DepartmentIDDataGridViewTextBoxColumn1"
        Me.DepartmentIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DepartmentIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DepartmentIDDataGridViewTextBoxColumn1.Width = 96
        '
        'NameDataGridViewTextBoxColumn1
        '
        Me.NameDataGridViewTextBoxColumn1.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn1.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn1.Name = "NameDataGridViewTextBoxColumn1"
        Me.NameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn1.Width = 58
        '
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.CategoryIDToolStrip)
        Me.Controls.Add(Me.DepartmentIDToolStrip)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.txtCategoryID)
        Me.Controls.Add(Me.btnClearDepartmentID)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnSearchDepartmentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClearCategoryID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearchCategoryID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewProduct"
        Me.Text = "NewProduct"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.CategoryIDToolStrip.ResumeLayout(False)
        Me.CategoryIDToolStrip.PerformLayout()
        Me.DepartmentIDToolStrip.ResumeLayout(False)
        Me.DepartmentIDToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents btnClearDepartmentID As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnSearchDepartmentID As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearCategoryID As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearchCategoryID As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As GEDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents CategoryIDToolStrip As ToolStrip
    Friend WithEvents CategoryIDToolStripLabel As ToolStripLabel
    Friend WithEvents CategoryIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents CategoryIDToolStripButton As ToolStripButton
    Friend WithEvents DepartmentIDToolStrip As ToolStrip
    Friend WithEvents DepartmentIDToolStripLabel As ToolStripLabel
    Friend WithEvents DepartmentIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents DepartmentIDToolStripButton As ToolStripButton
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
