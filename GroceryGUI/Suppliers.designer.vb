<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvSuppliers = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PocFirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PocLastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUpdate = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ShippersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShippersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ShippersTableAdapter()
        Me.SuppliersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.SuppliersTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.mnuNewSupplier})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1468, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'mnuNewSupplier
        '
        Me.mnuNewSupplier.Name = "mnuNewSupplier"
        Me.mnuNewSupplier.Size = New System.Drawing.Size(89, 20)
        Me.mnuNewSupplier.Text = "New Supplier"
        '
        'dgvSuppliers
        '
        Me.dgvSuppliers.AllowUserToAddRows = False
        Me.dgvSuppliers.AllowUserToDeleteRows = False
        Me.dgvSuppliers.AutoGenerateColumns = False
        Me.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuppliers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.PocFirstNameDataGridViewTextBoxColumn, Me.PocLastNameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.FaxNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.Address1DataGridViewTextBoxColumn, Me.Address2DataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZIPDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.btnUpdate})
        Me.dgvSuppliers.DataSource = Me.SuppliersBindingSource
        Me.dgvSuppliers.Location = New System.Drawing.Point(0, 81)
        Me.dgvSuppliers.Name = "dgvSuppliers"
        Me.dgvSuppliers.ReadOnly = True
        Me.dgvSuppliers.RowHeadersVisible = False
        Me.dgvSuppliers.Size = New System.Drawing.Size(1420, 373)
        Me.dgvSuppliers.TabIndex = 2
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PocFirstNameDataGridViewTextBoxColumn
        '
        Me.PocFirstNameDataGridViewTextBoxColumn.DataPropertyName = "pocFirstName"
        Me.PocFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.PocFirstNameDataGridViewTextBoxColumn.Name = "PocFirstNameDataGridViewTextBoxColumn"
        Me.PocFirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PocLastNameDataGridViewTextBoxColumn
        '
        Me.PocLastNameDataGridViewTextBoxColumn.DataPropertyName = "pocLastName"
        Me.PocLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.PocLastNameDataGridViewTextBoxColumn.Name = "PocLastNameDataGridViewTextBoxColumn"
        Me.PocLastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FaxNumberDataGridViewTextBoxColumn
        '
        Me.FaxNumberDataGridViewTextBoxColumn.DataPropertyName = "faxNumber"
        Me.FaxNumberDataGridViewTextBoxColumn.HeaderText = "Fax Number"
        Me.FaxNumberDataGridViewTextBoxColumn.Name = "FaxNumberDataGridViewTextBoxColumn"
        Me.FaxNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-Mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Address1DataGridViewTextBoxColumn
        '
        Me.Address1DataGridViewTextBoxColumn.DataPropertyName = "address1"
        Me.Address1DataGridViewTextBoxColumn.HeaderText = "Address 1"
        Me.Address1DataGridViewTextBoxColumn.Name = "Address1DataGridViewTextBoxColumn"
        Me.Address1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Address2DataGridViewTextBoxColumn
        '
        Me.Address2DataGridViewTextBoxColumn.DataPropertyName = "address2"
        Me.Address2DataGridViewTextBoxColumn.HeaderText = "Address 2"
        Me.Address2DataGridViewTextBoxColumn.Name = "Address2DataGridViewTextBoxColumn"
        Me.Address2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZIPDataGridViewTextBoxColumn
        '
        Me.ZIPDataGridViewTextBoxColumn.DataPropertyName = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.HeaderText = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.Name = "ZIPDataGridViewTextBoxColumn"
        Me.ZIPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        Me.NotesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnUpdate
        '
        Me.btnUpdate.HeaderText = ""
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ReadOnly = True
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseColumnTextForButtonValue = True
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShippersBindingSource
        '
        Me.ShippersBindingSource.DataMember = "Shippers"
        Me.ShippersBindingSource.DataSource = Me.GEDataSet
        '
        'ShippersTableAdapter
        '
        Me.ShippersTableAdapter.ClearBeforeFill = True
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1468, 454)
        Me.Controls.Add(Me.dgvSuppliers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSuppliers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suppliers"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuNewSupplier As ToolStripMenuItem
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ShippersBindingSource As BindingSource
    Friend WithEvents ShippersTableAdapter As GEDataSetTableAdapters.ShippersTableAdapter
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As GEDataSetTableAdapters.SuppliersTableAdapter
	Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PocFirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PocLastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents FaxNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Address1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents Address2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ZIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents btnUpdate As DataGridViewButtonColumn
End Class
