<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Me.mnuNewDepartments = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvDepartments = New System.Windows.Forms.DataGridView()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DepartmentsTableAdapter()
        Me.mnuClose.SuspendLayout()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuClose
        '
        Me.mnuClose.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuClose.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.mnuNewDepartments})
        Me.mnuClose.Location = New System.Drawing.Point(0, 0)
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuClose.Size = New System.Drawing.Size(419, 28)
        Me.mnuClose.TabIndex = 0
        Me.mnuClose.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'mnuNewDepartments
        '
        Me.mnuNewDepartments.Name = "mnuNewDepartments"
        Me.mnuNewDepartments.Size = New System.Drawing.Size(135, 24)
        Me.mnuNewDepartments.Text = "New Department"
        '
        'dgvDepartments
        '
        Me.dgvDepartments.AllowUserToAddRows = False
        Me.dgvDepartments.AllowUserToDeleteRows = False
        Me.dgvDepartments.AutoGenerateColumns = False
        Me.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DepartmentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.btnUpdate})
        Me.dgvDepartments.DataSource = Me.DepartmentsBindingSource
        Me.dgvDepartments.Location = New System.Drawing.Point(16, 33)
        Me.dgvDepartments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDepartments.Name = "dgvDepartments"
        Me.dgvDepartments.RowHeadersVisible = False
        Me.dgvDepartments.Size = New System.Drawing.Size(387, 308)
        Me.dgvDepartments.TabIndex = 1
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
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Department Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 139
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        Me.btnUpdate.Width = 61
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
        'DepartmentsTableAdapter
        '
        Me.DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 356)
        Me.Controls.Add(Me.dgvDepartments)
        Me.Controls.Add(Me.mnuClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuClose
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDepartments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Departments"
        Me.mnuClose.ResumeLayout(False)
        Me.mnuClose.PerformLayout()
        CType(Me.dgvDepartments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuClose As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvDepartments As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents mnuNewDepartments As ToolStripMenuItem
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class
