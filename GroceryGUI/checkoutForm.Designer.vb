<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCheckoutForm
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
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.retailCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddToCart = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnGiftCard = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnCredit = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbCart = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblSubTotalAmount = New System.Windows.Forms.Label()
        Me.lblDiscountAmount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.btnProductSearch = New System.Windows.Forms.Button()
        Me.btnHotKeys = New System.Windows.Forms.Button()
        Me.btnPayPal = New System.Windows.Forms.Button()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ProductsTableAdapter()
        Me.checkoutButton = New System.Windows.Forms.Button()
        Me.cmbSearchType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SKUCheckoutSearchToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SKUToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SKUToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SKUCheckoutSearchToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UPCToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UPCToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SKUCheckoutSearchToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(128, 544)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(117, 20)
        Me.txtCustomerID.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(537, 541)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(145, 20)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.Text = "1"
        '
        'txtProduct
        '
        Me.txtProduct.Enabled = False
        Me.txtProduct.Location = New System.Drawing.Point(147, 75)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(304, 20)
        Me.txtProduct.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(26, 542)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Search:"
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCustomerSearch.Location = New System.Drawing.Point(251, 536)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(80, 31)
        Me.btnCustomerSearch.TabIndex = 8
        Me.btnCustomerSearch.Text = "Search"
        Me.btnCustomerSearch.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoGenerateColumns = False
        Me.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.UPCDataGridViewTextBoxColumn, Me.retailCost, Me.btnAddToCart})
        Me.dgvProducts.DataSource = Me.ProductsBindingSource
        Me.dgvProducts.Location = New System.Drawing.Point(28, 106)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.Size = New System.Drawing.Size(656, 418)
        Me.dgvProducts.TabIndex = 9
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 54
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UPCDataGridViewTextBoxColumn
        '
        Me.UPCDataGridViewTextBoxColumn.DataPropertyName = "UPC"
        Me.UPCDataGridViewTextBoxColumn.HeaderText = "UPC"
        Me.UPCDataGridViewTextBoxColumn.Name = "UPCDataGridViewTextBoxColumn"
        Me.UPCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'retailCost
        '
        Me.retailCost.DataPropertyName = "retailCost"
        Me.retailCost.HeaderText = "Cost"
        Me.retailCost.Name = "retailCost"
        Me.retailCost.ReadOnly = True
        '
        'btnAddToCart
        '
        Me.btnAddToCart.DataPropertyName = "SKU"
        Me.btnAddToCart.HeaderText = ""
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.ReadOnly = True
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseColumnTextForButtonValue = True
        Me.btnAddToCart.Width = 145
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(465, 540)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBack.Location = New System.Drawing.Point(12, 672)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(81, 37)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Enabled = False
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAccount.Location = New System.Drawing.Point(819, 672)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(81, 37)
        Me.btnAccount.TabIndex = 12
        Me.btnAccount.Text = "Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnGiftCard
        '
        Me.btnGiftCard.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGiftCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnGiftCard.Location = New System.Drawing.Point(918, 624)
        Me.btnGiftCard.Name = "btnGiftCard"
        Me.btnGiftCard.Size = New System.Drawing.Size(81, 37)
        Me.btnGiftCard.TabIndex = 13
        Me.btnGiftCard.Text = "Gift Card"
        Me.btnGiftCard.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnVoid.Location = New System.Drawing.Point(250, 624)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(81, 37)
        Me.btnVoid.TabIndex = 14
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCheck.Location = New System.Drawing.Point(819, 624)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(81, 37)
        Me.btnCheck.TabIndex = 15
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnCredit
        '
        Me.btnCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCredit.Location = New System.Drawing.Point(716, 624)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(81, 37)
        Me.btnCredit.TabIndex = 16
        Me.btnCredit.Text = "Credit"
        Me.btnCredit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnRemove.Location = New System.Drawing.Point(250, 672)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(81, 37)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCash.Location = New System.Drawing.Point(918, 672)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(81, 37)
        Me.btnCash.TabIndex = 18
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.lbCart)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.lblTaxAmount)
        Me.GroupBox1.Controls.Add(Me.lblSubTotalAmount)
        Me.GroupBox1.Controls.Add(Me.lblDiscountAmount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(716, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 578)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total"
        '
        'lbCart
        '
        Me.lbCart.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbCart.FormattingEnabled = True
        Me.lbCart.ItemHeight = 16
        Me.lbCart.Location = New System.Drawing.Point(7, 48)
        Me.lbCart.Name = "lbCart"
        Me.lbCart.Size = New System.Drawing.Size(270, 352)
        Me.lbCart.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(261, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Item                        Price/Unit       Qty."
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblTotalAmount.Location = New System.Drawing.Point(110, 543)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalAmount.TabIndex = 23
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblTaxAmount.Location = New System.Drawing.Point(110, 502)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(0, 18)
        Me.lblTaxAmount.TabIndex = 24
        '
        'lblSubTotalAmount
        '
        Me.lblSubTotalAmount.AutoSize = True
        Me.lblSubTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblSubTotalAmount.Location = New System.Drawing.Point(110, 464)
        Me.lblSubTotalAmount.Name = "lblSubTotalAmount"
        Me.lblSubTotalAmount.Size = New System.Drawing.Size(0, 18)
        Me.lblSubTotalAmount.TabIndex = 25
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.AutoSize = True
        Me.lblDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblDiscountAmount.Location = New System.Drawing.Point(110, 425)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(0, 18)
        Me.lblDiscountAmount.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Discount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(43, 539)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sub-Total:"
        '
        'btnDiscount
        '
        Me.btnDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnDiscount.Location = New System.Drawing.Point(370, 672)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(81, 37)
        Me.btnDiscount.TabIndex = 20
        Me.btnDiscount.Text = "Discount"
        Me.btnDiscount.UseVisualStyleBackColor = True
        '
        'btnProductSearch
        '
        Me.btnProductSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnProductSearch.Location = New System.Drawing.Point(468, 69)
        Me.btnProductSearch.Name = "btnProductSearch"
        Me.btnProductSearch.Size = New System.Drawing.Size(128, 31)
        Me.btnProductSearch.TabIndex = 22
        Me.btnProductSearch.Text = "Search"
        Me.btnProductSearch.UseVisualStyleBackColor = True
        '
        'btnHotKeys
        '
        Me.btnHotKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnHotKeys.Location = New System.Drawing.Point(370, 624)
        Me.btnHotKeys.Name = "btnHotKeys"
        Me.btnHotKeys.Size = New System.Drawing.Size(81, 37)
        Me.btnHotKeys.TabIndex = 23
        Me.btnHotKeys.Text = "HOT KEYS"
        Me.btnHotKeys.UseVisualStyleBackColor = True
        '
        'btnPayPal
        '
        Me.btnPayPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnPayPal.Location = New System.Drawing.Point(716, 672)
        Me.btnPayPal.Name = "btnPayPal"
        Me.btnPayPal.Size = New System.Drawing.Size(81, 37)
        Me.btnPayPal.TabIndex = 24
        Me.btnPayPal.Text = "PayPal"
        Me.btnPayPal.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(876, 10)
        Me.txtEmployeeID.Multiline = True
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(119, 24)
        Me.txtEmployeeID.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(764, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Employee ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1019, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'checkoutButton
        '
        Me.checkoutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutButton.Location = New System.Drawing.Point(489, 624)
        Me.checkoutButton.Name = "checkoutButton"
        Me.checkoutButton.Size = New System.Drawing.Size(153, 85)
        Me.checkoutButton.TabIndex = 30
        Me.checkoutButton.Text = "Checkout"
        Me.checkoutButton.UseVisualStyleBackColor = True
        '
        'cmbSearchType
        '
        Me.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Name", "SKU", "UPC"})
        Me.cmbSearchType.Location = New System.Drawing.Point(147, 48)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(144, 21)
        Me.cmbSearchType.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(46, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Search Type:"
        '
        'SKUCheckoutSearchToolStrip
        '
        Me.SKUCheckoutSearchToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SKUCheckoutSearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SKUToolStripLabel, Me.SKUToolStripTextBox, Me.SKUCheckoutSearchToolStripButton})
        Me.SKUCheckoutSearchToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.SKUCheckoutSearchToolStrip.Name = "SKUCheckoutSearchToolStrip"
        Me.SKUCheckoutSearchToolStrip.Size = New System.Drawing.Size(1019, 25)
        Me.SKUCheckoutSearchToolStrip.TabIndex = 33
        Me.SKUCheckoutSearchToolStrip.Text = "SKUCheckoutSearchToolStrip"
        Me.SKUCheckoutSearchToolStrip.Visible = False
        '
        'SKUToolStripLabel
        '
        Me.SKUToolStripLabel.Name = "SKUToolStripLabel"
        Me.SKUToolStripLabel.Size = New System.Drawing.Size(31, 22)
        Me.SKUToolStripLabel.Text = "SKU:"
        '
        'SKUToolStripTextBox
        '
        Me.SKUToolStripTextBox.Name = "SKUToolStripTextBox"
        Me.SKUToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'SKUCheckoutSearchToolStripButton
        '
        Me.SKUCheckoutSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SKUCheckoutSearchToolStripButton.Name = "SKUCheckoutSearchToolStripButton"
        Me.SKUCheckoutSearchToolStripButton.Size = New System.Drawing.Size(118, 22)
        Me.SKUCheckoutSearchToolStripButton.Text = "SKUCheckoutSearch"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(602, 68)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 31)
        Me.btnRefresh.TabIndex = 34
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UPCToolStripLabel, Me.UPCToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1019, 25)
        Me.FillByToolStrip.TabIndex = 35
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'UPCToolStripLabel
        '
        Me.UPCToolStripLabel.Name = "UPCToolStripLabel"
        Me.UPCToolStripLabel.Size = New System.Drawing.Size(33, 22)
        Me.UPCToolStripLabel.Text = "UPC:"
        '
        'UPCToolStripTextBox
        '
        Me.UPCToolStripTextBox.Name = "UPCToolStripTextBox"
        Me.UPCToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'frmCheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 752)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.SKUCheckoutSearchToolStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.checkoutButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.btnPayPal)
        Me.Controls.Add(Me.btnHotKeys)
        Me.Controls.Add(Me.btnProductSearch)
        Me.Controls.Add(Me.btnDiscount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCredit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnGiftCard)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.btnCustomerSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCheckoutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SKUCheckoutSearchToolStrip.ResumeLayout(False)
        Me.SKUCheckoutSearchToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCustomerSearch As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnGiftCard As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnCredit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDiscount As Button
    Friend WithEvents btnProductSearch As Button
    Friend WithEvents btnHotKeys As Button
    Friend WithEvents btnPayPal As Button
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTaxAmount As Label
    Friend WithEvents lblSubTotalAmount As Label
    Friend WithEvents lblDiscountAmount As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As GEDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents lbCart As ListBox
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UPCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents retailCost As DataGridViewTextBoxColumn
    Friend WithEvents btnAddToCart As DataGridViewButtonColumn
    Friend WithEvents checkoutButton As Button
    Friend WithEvents cmbSearchType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SKUCheckoutSearchToolStrip As ToolStrip
    Friend WithEvents SKUToolStripLabel As ToolStripLabel
    Friend WithEvents SKUToolStripTextBox As ToolStripTextBox
    Friend WithEvents SKUCheckoutSearchToolStripButton As ToolStripButton
    Friend WithEvents btnRefresh As Button
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents UPCToolStripLabel As ToolStripLabel
    Friend WithEvents UPCToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByToolStripButton As ToolStripButton
End Class
