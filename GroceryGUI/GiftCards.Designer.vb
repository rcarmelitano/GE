<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiftCards
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
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewGiftCardsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClearID = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.btnAddID = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dtpDateOfPurchase = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.txtCardTotal = New System.Windows.Forms.TextBox()
        Me.btnActivateGiftCard = New System.Windows.Forms.Button()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.ViewGiftCardsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(376, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ViewGiftCardsToolStripMenuItem
        '
        Me.ViewGiftCardsToolStripMenuItem.Name = "ViewGiftCardsToolStripMenuItem"
        Me.ViewGiftCardsToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ViewGiftCardsToolStripMenuItem.Text = "View Gift Cards"
        '
        'btnClearID
        '
        Me.btnClearID.Location = New System.Drawing.Point(193, 239)
        Me.btnClearID.Name = "btnClearID"
        Me.btnClearID.Size = New System.Drawing.Size(171, 33)
        Me.btnClearID.TabIndex = 59
        Me.btnClearID.Text = "Clear"
        Me.btnClearID.UseVisualStyleBackColor = True
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoGenerateColumns = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn})
        Me.dgvCustomers.DataSource = Me.CustomersBindingSource
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 78)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.Size = New System.Drawing.Size(352, 155)
        Me.dgvCustomers.TabIndex = 58
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
        'btnAddID
        '
        Me.btnAddID.Location = New System.Drawing.Point(12, 239)
        Me.btnAddID.Name = "btnAddID"
        Me.btnAddID.Size = New System.Drawing.Size(171, 33)
        Me.btnAddID.TabIndex = 57
        Me.btnAddID.Text = "Add"
        Me.btnAddID.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(86, 47)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(180, 20)
        Me.txtCustomerID.TabIndex = 60
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(272, 44)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(92, 25)
        Me.btnSearch.TabIndex = 61
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dtpDateOfPurchase
        '
        Me.dtpDateOfPurchase.Location = New System.Drawing.Point(119, 288)
        Me.dtpDateOfPurchase.Name = "dtpDateOfPurchase"
        Me.dtpDateOfPurchase.Size = New System.Drawing.Size(213, 20)
        Me.dtpDateOfPurchase.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Date of Purchase:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "(Starting) Card Total:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     (2.50 minimum)"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'txtCardTotal
        '
        Me.txtCardTotal.Location = New System.Drawing.Point(119, 323)
        Me.txtCardTotal.Name = "txtCardTotal"
        Me.txtCardTotal.Size = New System.Drawing.Size(213, 20)
        Me.txtCardTotal.TabIndex = 65
        Me.txtCardTotal.Text = "2.50"
        '
        'btnActivateGiftCard
        '
        Me.btnActivateGiftCard.Enabled = False
        Me.btnActivateGiftCard.Location = New System.Drawing.Point(121, 366)
        Me.btnActivateGiftCard.Name = "btnActivateGiftCard"
        Me.btnActivateGiftCard.Size = New System.Drawing.Size(134, 33)
        Me.btnActivateGiftCard.TabIndex = 66
        Me.btnActivateGiftCard.Text = "Activate Gift Card"
        Me.btnActivateGiftCard.UseVisualStyleBackColor = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 67
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FirstNameDataGridViewTextBoxColumn.Width = 57
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LastNameDataGridViewTextBoxColumn.Width = 57
        '
        'frmGiftCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 407)
        Me.Controls.Add(Me.btnActivateGiftCard)
        Me.Controls.Add(Me.txtCardTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateOfPurchase)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btnClearID)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.btnAddID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmGiftCards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gift Cards"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewGiftCardsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClearID As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnAddID As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dtpDateOfPurchase As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents txtCardTotal As TextBox
    Friend WithEvents btnActivateGiftCard As Button
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
