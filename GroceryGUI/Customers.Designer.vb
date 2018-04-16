﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomers
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
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondaryPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.NewCustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(718, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(289, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 34)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(120, 45)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(163, 20)
        Me.txtCustomerID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer ID:"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoGenerateColumns = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.CustomerDOBDataGridViewTextBoxColumn, Me.PrimaryPhoneDataGridViewTextBoxColumn, Me.SecondaryPhoneDataGridViewTextBoxColumn, Me.Edit, Me.Delete})
        Me.dgvCustomers.DataSource = Me.CustomersBindingSource
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 82)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.Size = New System.Drawing.Size(694, 315)
        Me.dgvCustomers.TabIndex = 7
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 86
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.Width = 76
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.Width = 76
        '
        'CustomerDOBDataGridViewTextBoxColumn
        '
        Me.CustomerDOBDataGridViewTextBoxColumn.DataPropertyName = "customerDOB"
        Me.CustomerDOBDataGridViewTextBoxColumn.HeaderText = "customerDOB"
        Me.CustomerDOBDataGridViewTextBoxColumn.Name = "CustomerDOBDataGridViewTextBoxColumn"
        Me.CustomerDOBDataGridViewTextBoxColumn.Width = 98
        '
        'PrimaryPhoneDataGridViewTextBoxColumn
        '
        Me.PrimaryPhoneDataGridViewTextBoxColumn.DataPropertyName = "primaryPhone"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.HeaderText = "primaryPhone"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.Name = "PrimaryPhoneDataGridViewTextBoxColumn"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.Width = 96
        '
        'SecondaryPhoneDataGridViewTextBoxColumn
        '
        Me.SecondaryPhoneDataGridViewTextBoxColumn.DataPropertyName = "secondaryPhone"
        Me.SecondaryPhoneDataGridViewTextBoxColumn.HeaderText = "secondaryPhone"
        Me.SecondaryPhoneDataGridViewTextBoxColumn.Name = "SecondaryPhoneDataGridViewTextBoxColumn"
        Me.SecondaryPhoneDataGridViewTextBoxColumn.Width = 112
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForButtonValue = True
        Me.Edit.Width = 65
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 65
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 409)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaryPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecondaryPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
End Class
