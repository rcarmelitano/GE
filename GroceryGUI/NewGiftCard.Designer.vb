<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewGiftCard
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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddCustomerID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.dtpDateOfPurchase = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActivateGiftCard = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.nudCardTotal = New System.Windows.Forms.NumericUpDown()
        Me.txtGiftCardID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomerNameToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FirstNameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FirstNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.CustomerNameToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCardTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerNameToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.ViewGiftCardsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoGenerateColumns = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.btnAddCustomerID})
        Me.dgvCustomers.DataSource = Me.CustomersBindingSource
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 134)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.Size = New System.Drawing.Size(352, 196)
        Me.dgvCustomers.TabIndex = 58
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 71
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FirstNameDataGridViewTextBoxColumn.Width = 80
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LastNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.LastNameDataGridViewTextBoxColumn.Width = 64
        '
        'btnAddCustomerID
        '
        Me.btnAddCustomerID.HeaderText = ""
        Me.btnAddCustomerID.Name = "btnAddCustomerID"
        Me.btnAddCustomerID.ReadOnly = True
        Me.btnAddCustomerID.Text = "Add"
        Me.btnAddCustomerID.UseColumnTextForButtonValue = True
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(86, 106)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(113, 20)
        Me.txtCustomerID.TabIndex = 60
        '
        'dtpDateOfPurchase
        '
        Me.dtpDateOfPurchase.Location = New System.Drawing.Point(119, 344)
        Me.dtpDateOfPurchase.Name = "dtpDateOfPurchase"
        Me.dtpDateOfPurchase.Size = New System.Drawing.Size(213, 20)
        Me.dtpDateOfPurchase.TabIndex = 62
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Date of Purchase:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Card Total:"
        '
        'btnActivateGiftCard
        '
        Me.btnActivateGiftCard.Location = New System.Drawing.Point(121, 424)
        Me.btnActivateGiftCard.Name = "btnActivateGiftCard"
        Me.btnActivateGiftCard.Size = New System.Drawing.Size(134, 33)
        Me.btnActivateGiftCard.TabIndex = 66
        Me.btnActivateGiftCard.Text = "Activate Gift Card"
        Me.btnActivateGiftCard.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(86, 75)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(113, 20)
        Me.txtCustomerName.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Last Name:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(205, 73)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 69
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'nudCardTotal
        '
        Me.nudCardTotal.DecimalPlaces = 2
        Me.nudCardTotal.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCardTotal.Location = New System.Drawing.Point(119, 384)
        Me.nudCardTotal.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudCardTotal.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudCardTotal.Name = "nudCardTotal"
        Me.nudCardTotal.ReadOnly = True
        Me.nudCardTotal.Size = New System.Drawing.Size(213, 20)
        Me.nudCardTotal.TabIndex = 70
        Me.nudCardTotal.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'txtGiftCardID
        '
        Me.txtGiftCardID.Enabled = False
        Me.txtGiftCardID.Location = New System.Drawing.Point(86, 43)
        Me.txtGiftCardID.Name = "txtGiftCardID"
        Me.txtGiftCardID.ReadOnly = True
        Me.txtGiftCardID.Size = New System.Drawing.Size(113, 20)
        Me.txtGiftCardID.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Gift Card ID:"
        '
        'CustomerNameToolStrip
        '
        Me.CustomerNameToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstNameToolStripLabel, Me.FirstNameToolStripTextBox, Me.CustomerNameToolStripButton})
        Me.CustomerNameToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.CustomerNameToolStrip.Name = "CustomerNameToolStrip"
        Me.CustomerNameToolStrip.Size = New System.Drawing.Size(384, 25)
        Me.CustomerNameToolStrip.TabIndex = 73
        Me.CustomerNameToolStrip.Text = "CustomerNameToolStrip"
        Me.CustomerNameToolStrip.Visible = False
        '
        'FirstNameToolStripLabel
        '
        Me.FirstNameToolStripLabel.Name = "FirstNameToolStripLabel"
        Me.FirstNameToolStripLabel.Size = New System.Drawing.Size(62, 22)
        Me.FirstNameToolStripLabel.Text = "firstName:"
        '
        'FirstNameToolStripTextBox
        '
        Me.FirstNameToolStripTextBox.Name = "FirstNameToolStripTextBox"
        Me.FirstNameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'CustomerNameToolStripButton
        '
        Me.CustomerNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CustomerNameToolStripButton.Name = "CustomerNameToolStripButton"
        Me.CustomerNameToolStripButton.Size = New System.Drawing.Size(93, 22)
        Me.CustomerNameToolStripButton.Text = "customerName"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'frmNewGiftCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 463)
        Me.Controls.Add(Me.CustomerNameToolStrip)
        Me.Controls.Add(Me.txtGiftCardID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudCardTotal)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnActivateGiftCard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateOfPurchase)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmNewGiftCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Gift Card"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCardTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerNameToolStrip.ResumeLayout(False)
        Me.CustomerNameToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewGiftCardsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents dtpDateOfPurchase As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents btnActivateGiftCard As Button
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddCustomerID As DataGridViewButtonColumn
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents nudCardTotal As NumericUpDown
    Friend WithEvents txtGiftCardID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CustomerNameToolStrip As ToolStrip
    Friend WithEvents FirstNameToolStripLabel As ToolStripLabel
    Friend WithEvents FirstNameToolStripTextBox As ToolStripTextBox
    Friend WithEvents CustomerNameToolStripButton As ToolStripButton
End Class
