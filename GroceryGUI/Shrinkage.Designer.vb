<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShrinkage
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
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewShrinkageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvShrinkage = New System.Windows.Forms.DataGridView()
        Me.ShrinkageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ShrinkageTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ShrinkageTableAdapter()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTableAdapter = New GroceryGUI.GEDataSetTableAdapters.StatusTableAdapter()
        Me.ShrinkageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StatusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShrinkDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuClose.SuspendLayout()
        CType(Me.dgvShrinkage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShrinkageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuClose
        '
        Me.mnuClose.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.NewShrinkageToolStripMenuItem})
        Me.mnuClose.Location = New System.Drawing.Point(0, 0)
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(1048, 24)
        Me.mnuClose.TabIndex = 0
        Me.mnuClose.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewShrinkageToolStripMenuItem
        '
        Me.NewShrinkageToolStripMenuItem.Name = "NewShrinkageToolStripMenuItem"
        Me.NewShrinkageToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.NewShrinkageToolStripMenuItem.Text = "New Shrinkage"
        '
        'dgvShrinkage
        '
        Me.dgvShrinkage.AllowUserToAddRows = False
        Me.dgvShrinkage.AllowUserToDeleteRows = False
        Me.dgvShrinkage.AutoGenerateColumns = False
        Me.dgvShrinkage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShrinkage.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShrinkageIDDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.Status, Me.StatusIDDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.ShrinkDateDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn})
        Me.dgvShrinkage.DataSource = Me.ShrinkageBindingSource
        Me.dgvShrinkage.Location = New System.Drawing.Point(13, 28)
        Me.dgvShrinkage.Name = "dgvShrinkage"
        Me.dgvShrinkage.ReadOnly = True
        Me.dgvShrinkage.RowHeadersVisible = False
        Me.dgvShrinkage.Size = New System.Drawing.Size(1022, 371)
        Me.dgvShrinkage.TabIndex = 1
        '
        'ShrinkageBindingSource
        '
        Me.ShrinkageBindingSource.DataMember = "Shrinkage"
        Me.ShrinkageBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShrinkageTableAdapter
        '
        Me.ShrinkageTableAdapter.ClearBeforeFill = True
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me.GEDataSet
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'ShrinkageIDDataGridViewTextBoxColumn
        '
        Me.ShrinkageIDDataGridViewTextBoxColumn.DataPropertyName = "shrinkageID"
        Me.ShrinkageIDDataGridViewTextBoxColumn.HeaderText = "Shrinkage ID"
        Me.ShrinkageIDDataGridViewTextBoxColumn.Name = "ShrinkageIDDataGridViewTextBoxColumn"
        Me.ShrinkageIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "statusID"
        Me.Status.DataSource = Me.StatusBindingSource
        Me.Status.DisplayMember = "status"
        Me.Status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.ValueMember = "statusID"
        '
        'StatusIDDataGridViewTextBoxColumn
        '
        Me.StatusIDDataGridViewTextBoxColumn.DataPropertyName = "statusID"
        Me.StatusIDDataGridViewTextBoxColumn.HeaderText = "Status ID"
        Me.StatusIDDataGridViewTextBoxColumn.Name = "StatusIDDataGridViewTextBoxColumn"
        Me.StatusIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusIDDataGridViewTextBoxColumn.Visible = False
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShrinkDateDataGridViewTextBoxColumn
        '
        Me.ShrinkDateDataGridViewTextBoxColumn.DataPropertyName = "shrinkDate"
        Me.ShrinkDateDataGridViewTextBoxColumn.HeaderText = "Shrinkage Date"
        Me.ShrinkDateDataGridViewTextBoxColumn.Name = "ShrinkDateDataGridViewTextBoxColumn"
        Me.ShrinkDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetailsDataGridViewTextBoxColumn.Width = 300
        '
        'UnitDataGridViewTextBoxColumn
        '
        Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "unit"
        Me.UnitDataGridViewTextBoxColumn.HeaderText = "Unit"
        Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
        Me.UnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmShrinkage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 414)
        Me.Controls.Add(Me.dgvShrinkage)
        Me.Controls.Add(Me.mnuClose)
        Me.MainMenuStrip = Me.mnuClose
        Me.Name = "frmShrinkage"
        Me.Text = "Shrinkage"
        Me.mnuClose.ResumeLayout(False)
        Me.mnuClose.PerformLayout()
        CType(Me.dgvShrinkage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShrinkageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuClose As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvShrinkage As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ShrinkageBindingSource As BindingSource
    Friend WithEvents ShrinkageTableAdapter As GEDataSetTableAdapters.ShrinkageTableAdapter
    Friend WithEvents NewShrinkageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As GEDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents ShrinkageIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents StatusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShrinkDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
