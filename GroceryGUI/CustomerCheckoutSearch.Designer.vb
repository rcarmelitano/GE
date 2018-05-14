<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerCheckoutSearch
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.txtCustomerSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CustomerIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CustomerIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomerNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.LastNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.LastNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CustomerNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GrabCustomerFirstNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FirstNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FirstNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GrabCustomerFirstNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomerPrimaryPhoneToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PrimaryPhoneToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PrimaryPhoneToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CustomerPrimaryPhoneToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.EmailToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.EmailToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimaryPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholeSaleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnAddCustomer = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerIDToolStrip.SuspendLayout()
        Me.CustomerNameToolStrip.SuspendLayout()
        Me.GrabCustomerFirstNameToolStrip.SuspendLayout()
        Me.CustomerPrimaryPhoneToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Customer ID:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(443, 80)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(122, 28)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(113, 80)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(132, 22)
        Me.txtCustomerID.TabIndex = 7
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(573, 80)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(96, 28)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoGenerateColumns = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.PrimaryPhoneDataGridViewTextBoxColumn, Me.WholeSaleDataGridViewCheckBoxColumn, Me.btnAddCustomer})
        Me.dgvCustomers.DataSource = Me.CustomersBindingSource
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 115)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowTemplate.Height = 24
        Me.dgvCustomers.Size = New System.Drawing.Size(658, 307)
        Me.dgvCustomers.TabIndex = 11
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
        'txtCustomerSearch
        '
        Me.txtCustomerSearch.Enabled = False
        Me.txtCustomerSearch.Location = New System.Drawing.Point(304, 84)
        Me.txtCustomerSearch.Name = "txtCustomerSearch"
        Me.txtCustomerSearch.ReadOnly = True
        Me.txtCustomerSearch.Size = New System.Drawing.Size(132, 22)
        Me.txtCustomerSearch.TabIndex = 12
        '
        'cmbSearchType
        '
        Me.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"ID", "First Name", "Last Name", "Primary Phone", "Email"})
        Me.cmbSearchType.Location = New System.Drawing.Point(113, 49)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(132, 24)
        Me.cmbSearchType.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search Type:"
        '
        'CustomerIDToolStrip
        '
        Me.CustomerIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerIDToolStripLabel, Me.CustomerIDToolStripTextBox, Me.CustomerIDToolStripButton})
        Me.CustomerIDToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.CustomerIDToolStrip.Name = "CustomerIDToolStrip"
        Me.CustomerIDToolStrip.Size = New System.Drawing.Size(593, 27)
        Me.CustomerIDToolStrip.TabIndex = 15
        Me.CustomerIDToolStrip.Text = "CustomerIDToolStrip"
        Me.CustomerIDToolStrip.Visible = False
        '
        'CustomerIDToolStripLabel
        '
        Me.CustomerIDToolStripLabel.Name = "CustomerIDToolStripLabel"
        Me.CustomerIDToolStripLabel.Size = New System.Drawing.Size(88, 24)
        Me.CustomerIDToolStripLabel.Text = "customerID:"
        '
        'CustomerIDToolStripTextBox
        '
        Me.CustomerIDToolStripTextBox.Name = "CustomerIDToolStripTextBox"
        Me.CustomerIDToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'CustomerIDToolStripButton
        '
        Me.CustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CustomerIDToolStripButton.Name = "CustomerIDToolStripButton"
        Me.CustomerIDToolStripButton.Size = New System.Drawing.Size(89, 24)
        Me.CustomerIDToolStripButton.Text = "customerID"
        '
        'CustomerNameToolStrip
        '
        Me.CustomerNameToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LastNameToolStripLabel, Me.LastNameToolStripTextBox, Me.CustomerNameToolStripButton})
        Me.CustomerNameToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.CustomerNameToolStrip.Name = "CustomerNameToolStrip"
        Me.CustomerNameToolStrip.Size = New System.Drawing.Size(593, 27)
        Me.CustomerNameToolStrip.TabIndex = 16
        Me.CustomerNameToolStrip.Text = "CustomerNameToolStrip"
        Me.CustomerNameToolStrip.Visible = False
        '
        'LastNameToolStripLabel
        '
        Me.LastNameToolStripLabel.Name = "LastNameToolStripLabel"
        Me.LastNameToolStripLabel.Size = New System.Drawing.Size(75, 24)
        Me.LastNameToolStripLabel.Text = "lastName:"
        '
        'LastNameToolStripTextBox
        '
        Me.LastNameToolStripTextBox.Name = "LastNameToolStripTextBox"
        Me.LastNameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'CustomerNameToolStripButton
        '
        Me.CustomerNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CustomerNameToolStripButton.Name = "CustomerNameToolStripButton"
        Me.CustomerNameToolStripButton.Size = New System.Drawing.Size(114, 24)
        Me.CustomerNameToolStripButton.Text = "customerName"
        '
        'GrabCustomerFirstNameToolStrip
        '
        Me.GrabCustomerFirstNameToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GrabCustomerFirstNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstNameToolStripLabel, Me.FirstNameToolStripTextBox, Me.GrabCustomerFirstNameToolStripButton})
        Me.GrabCustomerFirstNameToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.GrabCustomerFirstNameToolStrip.Name = "GrabCustomerFirstNameToolStrip"
        Me.GrabCustomerFirstNameToolStrip.Size = New System.Drawing.Size(593, 27)
        Me.GrabCustomerFirstNameToolStrip.TabIndex = 17
        Me.GrabCustomerFirstNameToolStrip.Text = "GrabCustomerFirstNameToolStrip"
        Me.GrabCustomerFirstNameToolStrip.Visible = False
        '
        'FirstNameToolStripLabel
        '
        Me.FirstNameToolStripLabel.Name = "FirstNameToolStripLabel"
        Me.FirstNameToolStripLabel.Size = New System.Drawing.Size(77, 24)
        Me.FirstNameToolStripLabel.Text = "firstName:"
        '
        'FirstNameToolStripTextBox
        '
        Me.FirstNameToolStripTextBox.Name = "FirstNameToolStripTextBox"
        Me.FirstNameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'GrabCustomerFirstNameToolStripButton
        '
        Me.GrabCustomerFirstNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GrabCustomerFirstNameToolStripButton.Name = "GrabCustomerFirstNameToolStripButton"
        Me.GrabCustomerFirstNameToolStripButton.Size = New System.Drawing.Size(174, 24)
        Me.GrabCustomerFirstNameToolStripButton.Text = "grabCustomerFirstName"
        '
        'CustomerPrimaryPhoneToolStrip
        '
        Me.CustomerPrimaryPhoneToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomerPrimaryPhoneToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimaryPhoneToolStripLabel, Me.PrimaryPhoneToolStripTextBox, Me.CustomerPrimaryPhoneToolStripButton})
        Me.CustomerPrimaryPhoneToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.CustomerPrimaryPhoneToolStrip.Name = "CustomerPrimaryPhoneToolStrip"
        Me.CustomerPrimaryPhoneToolStrip.Size = New System.Drawing.Size(593, 27)
        Me.CustomerPrimaryPhoneToolStrip.TabIndex = 18
        Me.CustomerPrimaryPhoneToolStrip.Text = "CustomerPrimaryPhoneToolStrip"
        Me.CustomerPrimaryPhoneToolStrip.Visible = False
        '
        'PrimaryPhoneToolStripLabel
        '
        Me.PrimaryPhoneToolStripLabel.Name = "PrimaryPhoneToolStripLabel"
        Me.PrimaryPhoneToolStripLabel.Size = New System.Drawing.Size(104, 24)
        Me.PrimaryPhoneToolStripLabel.Text = "primaryPhone:"
        '
        'PrimaryPhoneToolStripTextBox
        '
        Me.PrimaryPhoneToolStripTextBox.Name = "PrimaryPhoneToolStripTextBox"
        Me.PrimaryPhoneToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'CustomerPrimaryPhoneToolStripButton
        '
        Me.CustomerPrimaryPhoneToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CustomerPrimaryPhoneToolStripButton.Name = "CustomerPrimaryPhoneToolStripButton"
        Me.CustomerPrimaryPhoneToolStripButton.Size = New System.Drawing.Size(165, 24)
        Me.CustomerPrimaryPhoneToolStripButton.Text = "customerPrimaryPhone"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripLabel, Me.EmailToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 28)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(593, 27)
        Me.FillByToolStrip.TabIndex = 19
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'EmailToolStripLabel
        '
        Me.EmailToolStripLabel.Name = "EmailToolStripLabel"
        Me.EmailToolStripLabel.Size = New System.Drawing.Size(49, 24)
        Me.EmailToolStripLabel.Text = "email:"
        '
        'EmailToolStripTextBox
        '
        Me.EmailToolStripTextBox.Name = "EmailToolStripTextBox"
        Me.EmailToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrimaryPhoneDataGridViewTextBoxColumn
        '
        Me.PrimaryPhoneDataGridViewTextBoxColumn.DataPropertyName = "primaryPhone"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.HeaderText = "Primary Phone"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.Name = "PrimaryPhoneDataGridViewTextBoxColumn"
        Me.PrimaryPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WholeSaleDataGridViewCheckBoxColumn
        '
        Me.WholeSaleDataGridViewCheckBoxColumn.DataPropertyName = "wholeSale"
        Me.WholeSaleDataGridViewCheckBoxColumn.HeaderText = "Wholesale"
        Me.WholeSaleDataGridViewCheckBoxColumn.Name = "WholeSaleDataGridViewCheckBoxColumn"
        Me.WholeSaleDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.HeaderText = ""
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.ReadOnly = True
        Me.btnAddCustomer.Text = "Add"
        Me.btnAddCustomer.UseColumnTextForButtonValue = True
        Me.btnAddCustomer.Width = 50
        '
        'frmCustomerCheckoutSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 434)
        Me.Controls.Add(Me.CustomerIDToolStrip)
        Me.Controls.Add(Me.CustomerNameToolStrip)
        Me.Controls.Add(Me.GrabCustomerFirstNameToolStrip)
        Me.Controls.Add(Me.CustomerPrimaryPhoneToolStrip)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.txtCustomerSearch)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCustomerCheckoutSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Selection"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerIDToolStrip.ResumeLayout(False)
        Me.CustomerIDToolStrip.PerformLayout()
        Me.CustomerNameToolStrip.ResumeLayout(False)
        Me.CustomerNameToolStrip.PerformLayout()
        Me.GrabCustomerFirstNameToolStrip.ResumeLayout(False)
        Me.GrabCustomerFirstNameToolStrip.PerformLayout()
        Me.CustomerPrimaryPhoneToolStrip.ResumeLayout(False)
        Me.CustomerPrimaryPhoneToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents txtCustomerSearch As TextBox
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerIDToolStrip As ToolStrip
    Friend WithEvents CustomerIDToolStripLabel As ToolStripLabel
    Friend WithEvents CustomerIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents CustomerIDToolStripButton As ToolStripButton
    Friend WithEvents CustomerNameToolStrip As ToolStrip
    Friend WithEvents LastNameToolStripLabel As ToolStripLabel
    Friend WithEvents LastNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents CustomerNameToolStripButton As ToolStripButton
    Friend WithEvents GrabCustomerFirstNameToolStrip As ToolStrip
    Friend WithEvents FirstNameToolStripLabel As ToolStripLabel
    Friend WithEvents FirstNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents GrabCustomerFirstNameToolStripButton As ToolStripButton
    Friend WithEvents CustomerPrimaryPhoneToolStrip As ToolStrip
    Friend WithEvents PrimaryPhoneToolStripLabel As ToolStripLabel
    Friend WithEvents PrimaryPhoneToolStripTextBox As ToolStripTextBox
    Friend WithEvents CustomerPrimaryPhoneToolStripButton As ToolStripButton
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents EmailToolStripLabel As ToolStripLabel
    Friend WithEvents EmailToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrimaryPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WholeSaleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents btnAddCustomer As DataGridViewButtonColumn
End Class
