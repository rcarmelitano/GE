<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerHistory
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
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondaryPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineOfCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsedLineOfCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholeSaleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TaxExemptDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.CustomerDOBDataGridViewTextBoxColumn, Me.PrimaryPhoneDataGridViewTextBoxColumn, Me.SecondaryPhoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.LineOfCreditDataGridViewTextBoxColumn, Me.UsedLineOfCreditDataGridViewTextBoxColumn, Me.WholeSaleDataGridViewCheckBoxColumn, Me.TaxExemptDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1124, 349)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerDOBDataGridViewTextBoxColumn
        '
        Me.CustomerDOBDataGridViewTextBoxColumn.DataPropertyName = "customerDOB"
        Me.CustomerDOBDataGridViewTextBoxColumn.HeaderText = "customerDOB"
        Me.CustomerDOBDataGridViewTextBoxColumn.Name = "CustomerDOBDataGridViewTextBoxColumn"
        Me.CustomerDOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimaryPhoneDataGridViewTextBoxColumn
        '
        Me.PrimaryPhoneDataGridViewTextBoxColumn.DataPropertyName = "primaryPhone"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.HeaderText = "primaryPhone"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.Name = "PrimaryPhoneDataGridViewTextBoxColumn"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SecondaryPhoneDataGridViewTextBoxColumn
        '
        Me.SecondaryPhoneDataGridViewTextBoxColumn.DataPropertyName = "secondaryPhone"
        Me.SecondaryPhoneDataGridViewTextBoxColumn.HeaderText = "secondaryPhone"
        Me.SecondaryPhoneDataGridViewTextBoxColumn.Name = "SecondaryPhoneDataGridViewTextBoxColumn"
        Me.SecondaryPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LineOfCreditDataGridViewTextBoxColumn
        '
        Me.LineOfCreditDataGridViewTextBoxColumn.DataPropertyName = "lineOfCredit"
        Me.LineOfCreditDataGridViewTextBoxColumn.HeaderText = "lineOfCredit"
        Me.LineOfCreditDataGridViewTextBoxColumn.Name = "LineOfCreditDataGridViewTextBoxColumn"
        Me.LineOfCreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsedLineOfCreditDataGridViewTextBoxColumn
        '
        Me.UsedLineOfCreditDataGridViewTextBoxColumn.DataPropertyName = "usedLineOfCredit"
        Me.UsedLineOfCreditDataGridViewTextBoxColumn.HeaderText = "usedLineOfCredit"
        Me.UsedLineOfCreditDataGridViewTextBoxColumn.Name = "UsedLineOfCreditDataGridViewTextBoxColumn"
        Me.UsedLineOfCreditDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WholeSaleDataGridViewCheckBoxColumn
        '
        Me.WholeSaleDataGridViewCheckBoxColumn.DataPropertyName = "wholeSale"
        Me.WholeSaleDataGridViewCheckBoxColumn.HeaderText = "wholeSale"
        Me.WholeSaleDataGridViewCheckBoxColumn.Name = "WholeSaleDataGridViewCheckBoxColumn"
        Me.WholeSaleDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TaxExemptDataGridViewCheckBoxColumn
        '
        Me.TaxExemptDataGridViewCheckBoxColumn.DataPropertyName = "taxExempt"
        Me.TaxExemptDataGridViewCheckBoxColumn.HeaderText = "taxExempt"
        Me.TaxExemptDataGridViewCheckBoxColumn.Name = "TaxExemptDataGridViewCheckBoxColumn"
        Me.TaxExemptDataGridViewCheckBoxColumn.ReadOnly = True
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1148, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'frmCustomerHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 385)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCustomerHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaryPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecondaryPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LineOfCreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsedLineOfCreditDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WholeSaleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TaxExemptDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
