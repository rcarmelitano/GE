<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategories
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
        Me.mnuClose = New System.Windows.Forms.MenuStrip()
        Me.ClsoeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.CategoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CategoriesTableAdapter()
        Me.mnuClose.SuspendLayout()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuClose
        '
        Me.mnuClose.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClsoeToolStripMenuItem, Me.mnuNewCategory})
        Me.mnuClose.Location = New System.Drawing.Point(0, 0)
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(422, 24)
        Me.mnuClose.TabIndex = 0
        Me.mnuClose.Text = "MenuStrip1"
        '
        'ClsoeToolStripMenuItem
        '
        Me.ClsoeToolStripMenuItem.Name = "ClsoeToolStripMenuItem"
        Me.ClsoeToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ClsoeToolStripMenuItem.Text = "Close"
        '
        'mnuNewCategory
        '
        Me.mnuNewCategory.Name = "mnuNewCategory"
        Me.mnuNewCategory.Size = New System.Drawing.Size(94, 20)
        Me.mnuNewCategory.Text = "New Category"
        '
        'dgvCategories
        '
        Me.dgvCategories.AllowUserToAddRows = False
        Me.dgvCategories.AllowUserToDeleteRows = False
        Me.dgvCategories.AutoGenerateColumns = False
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CategoryIDDataGridViewTextBoxColumn, Me.DepartmentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.btnUpdate})
        Me.dgvCategories.DataSource = Me.CategoriesBindingSource
        Me.dgvCategories.Location = New System.Drawing.Point(12, 28)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.RowHeadersVisible = False
        Me.dgvCategories.Size = New System.Drawing.Size(398, 343)
        Me.dgvCategories.TabIndex = 1
        '
        'CategoryIDDataGridViewTextBoxColumn
        '
        Me.CategoryIDDataGridViewTextBoxColumn.DataPropertyName = "categoryID"
        Me.CategoryIDDataGridViewTextBoxColumn.HeaderText = "Category ID"
        Me.CategoryIDDataGridViewTextBoxColumn.Name = "CategoryIDDataGridViewTextBoxColumn"
        Me.CategoryIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "Department ID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        Me.DepartmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Category Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 96
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        Me.btnUpdate.Width = 61
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.GEDataSetBindingSource
        '
        'GEDataSetBindingSource
        '
        Me.GEDataSetBindingSource.DataSource = Me.GEDataSet
        Me.GEDataSetBindingSource.Position = 0
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'frmCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 383)
        Me.Controls.Add(Me.dgvCategories)
        Me.Controls.Add(Me.mnuClose)
        Me.MainMenuStrip = Me.mnuClose
        Me.Name = "frmCategories"
        Me.Text = "Categories"
        Me.mnuClose.ResumeLayout(False)
        Me.mnuClose.PerformLayout()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuClose As MenuStrip
    Friend WithEvents ClsoeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvCategories As DataGridView
    Friend WithEvents GEDataSetBindingSource As BindingSource
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As GEDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents mnuNewCategory As ToolStripMenuItem
    Friend WithEvents CategoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class
