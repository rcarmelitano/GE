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
        Me.retailCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddToCart = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.btnCheckout = New System.Windows.Forms.Button()
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
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.ProductsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ProductsTableAdapter()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SKUCheckoutSearchToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(171, 670)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(155, 22)
        Me.txtCustomerID.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Location = New System.Drawing.Point(716, 666)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(192, 22)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.Text = "1"
        '
        'txtProduct
        '
        Me.txtProduct.Enabled = False
        Me.txtProduct.Location = New System.Drawing.Point(196, 92)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(404, 22)
        Me.txtProduct.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 667)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(35, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Product Search:"
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCustomerSearch.Location = New System.Drawing.Point(335, 660)
        Me.btnCustomerSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(107, 38)
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
        Me.dgvProducts.Enabled = False
        Me.dgvProducts.Location = New System.Drawing.Point(37, 130)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.Size = New System.Drawing.Size(875, 514)
        Me.dgvProducts.TabIndex = 9
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(620, 665)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quantity:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBack.Location = New System.Drawing.Point(16, 827)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(108, 46)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Enabled = False
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAccount.Location = New System.Drawing.Point(1092, 827)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(108, 46)
        Me.btnAccount.TabIndex = 12
        Me.btnAccount.Text = "Account"
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnGiftCard
        '
        Me.btnGiftCard.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGiftCard.Enabled = False
        Me.btnGiftCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnGiftCard.Location = New System.Drawing.Point(1224, 768)
        Me.btnGiftCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGiftCard.Name = "btnGiftCard"
        Me.btnGiftCard.Size = New System.Drawing.Size(108, 46)
        Me.btnGiftCard.TabIndex = 13
        Me.btnGiftCard.Text = "Gift Card"
        Me.btnGiftCard.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVoid.Enabled = False
        Me.btnVoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnVoid.Location = New System.Drawing.Point(333, 768)
        Me.btnVoid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(108, 46)
        Me.btnVoid.TabIndex = 14
        Me.btnVoid.Text = "Void"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCheck.Location = New System.Drawing.Point(1092, 768)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(108, 46)
        Me.btnCheck.TabIndex = 15
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnCredit
        '
        Me.btnCredit.Enabled = False
        Me.btnCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCredit.Location = New System.Drawing.Point(955, 768)
        Me.btnCredit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Size = New System.Drawing.Size(108, 46)
        Me.btnCredit.TabIndex = 16
        Me.btnCredit.Text = "Credit"
        Me.btnCredit.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnRemove.Location = New System.Drawing.Point(333, 827)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(108, 46)
        Me.btnRemove.TabIndex = 17
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Enabled = False
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCash.Location = New System.Drawing.Point(1224, 827)
        Me.btnCash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(108, 46)
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
        Me.GroupBox1.Location = New System.Drawing.Point(955, 49)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(377, 711)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total"
        '
        'lbCart
        '
        Me.lbCart.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbCart.Enabled = False
        Me.lbCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbCart.FormattingEnabled = True
        Me.lbCart.ItemHeight = 20
        Me.lbCart.Location = New System.Drawing.Point(9, 59)
        Me.lbCart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbCart.Name = "lbCart"
        Me.lbCart.Size = New System.Drawing.Size(360, 420)
        Me.lbCart.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 31)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(324, 25)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Item                        Price/Unit       Qty."
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblTotalAmount.Location = New System.Drawing.Point(147, 668)
        Me.lblTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(0, 24)
        Me.lblTotalAmount.TabIndex = 23
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.AutoSize = True
        Me.lblTaxAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblTaxAmount.Location = New System.Drawing.Point(147, 618)
        Me.lblTaxAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(0, 24)
        Me.lblTaxAmount.TabIndex = 24
        '
        'lblSubTotalAmount
        '
        Me.lblSubTotalAmount.AutoSize = True
        Me.lblSubTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblSubTotalAmount.Location = New System.Drawing.Point(147, 571)
        Me.lblSubTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubTotalAmount.Name = "lblSubTotalAmount"
        Me.lblSubTotalAmount.Size = New System.Drawing.Size(0, 24)
        Me.lblSubTotalAmount.TabIndex = 25
        '
        'lblDiscountAmount
        '
        Me.lblDiscountAmount.AutoSize = True
        Me.lblDiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblDiscountAmount.Location = New System.Drawing.Point(147, 523)
        Me.lblDiscountAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscountAmount.Name = "lblDiscountAmount"
        Me.lblDiscountAmount.Size = New System.Drawing.Size(0, 24)
        Me.lblDiscountAmount.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 527)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Discount:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 618)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tax:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 663)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 571)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sub-Total:"
        '
        'btnDiscount
        '
        Me.btnDiscount.Enabled = False
        Me.btnDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnDiscount.Location = New System.Drawing.Point(493, 827)
        Me.btnDiscount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(108, 46)
        Me.btnDiscount.TabIndex = 20
        Me.btnDiscount.Text = "Discount"
        Me.btnDiscount.UseVisualStyleBackColor = True
        '
        'btnProductSearch
        '
        Me.btnProductSearch.Enabled = False
        Me.btnProductSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnProductSearch.Location = New System.Drawing.Point(624, 85)
        Me.btnProductSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProductSearch.Name = "btnProductSearch"
        Me.btnProductSearch.Size = New System.Drawing.Size(171, 38)
        Me.btnProductSearch.TabIndex = 22
        Me.btnProductSearch.Text = "Search"
        Me.btnProductSearch.UseVisualStyleBackColor = True
        '
        'btnHotKeys
        '
        Me.btnHotKeys.Enabled = False
        Me.btnHotKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.btnHotKeys.Location = New System.Drawing.Point(493, 768)
        Me.btnHotKeys.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHotKeys.Name = "btnHotKeys"
        Me.btnHotKeys.Size = New System.Drawing.Size(108, 46)
        Me.btnHotKeys.TabIndex = 23
        Me.btnHotKeys.Text = "HOT KEYS"
        Me.btnHotKeys.UseVisualStyleBackColor = True
        '
        'btnPayPal
        '
        Me.btnPayPal.Enabled = False
        Me.btnPayPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnPayPal.Location = New System.Drawing.Point(955, 827)
        Me.btnPayPal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPayPal.Name = "btnPayPal"
        Me.btnPayPal.Size = New System.Drawing.Size(108, 46)
        Me.btnPayPal.TabIndex = 24
        Me.btnPayPal.Text = "PayPal"
        Me.btnPayPal.UseVisualStyleBackColor = True
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(1168, 12)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmployeeID.Multiline = True
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.ReadOnly = True
        Me.txtEmployeeID.Size = New System.Drawing.Size(157, 29)
        Me.txtEmployeeID.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(1019, 12)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 24)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Employee ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1359, 28)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'btnCheckout
        '
        Me.btnCheckout.Enabled = False
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.Location = New System.Drawing.Point(652, 768)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(204, 105)
        Me.btnCheckout.TabIndex = 30
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'cmbSearchType
        '
        Me.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchType.Enabled = False
        Me.cmbSearchType.FormattingEnabled = True
        Me.cmbSearchType.Items.AddRange(New Object() {"Name", "SKU", "UPC"})
        Me.cmbSearchType.Location = New System.Drawing.Point(196, 59)
        Me.cmbSearchType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbSearchType.Name = "cmbSearchType"
        Me.cmbSearchType.Size = New System.Drawing.Size(191, 24)
        Me.cmbSearchType.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(61, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Search Type:"
        '
        'SKUCheckoutSearchToolStrip
        '
        Me.SKUCheckoutSearchToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SKUCheckoutSearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SKUToolStripLabel, Me.SKUToolStripTextBox, Me.SKUCheckoutSearchToolStripButton})
        Me.SKUCheckoutSearchToolStrip.Location = New System.Drawing.Point(0, 30)
        Me.SKUCheckoutSearchToolStrip.Name = "SKUCheckoutSearchToolStrip"
        Me.SKUCheckoutSearchToolStrip.Size = New System.Drawing.Size(1359, 31)
        Me.SKUCheckoutSearchToolStrip.TabIndex = 33
        Me.SKUCheckoutSearchToolStrip.Text = "SKUCheckoutSearchToolStrip"
        Me.SKUCheckoutSearchToolStrip.Visible = False
        '
        'SKUToolStripLabel
        '
        Me.SKUToolStripLabel.Name = "SKUToolStripLabel"
        Me.SKUToolStripLabel.Size = New System.Drawing.Size(39, 28)
        Me.SKUToolStripLabel.Text = "SKU:"
        '
        'SKUToolStripTextBox
        '
        Me.SKUToolStripTextBox.Name = "SKUToolStripTextBox"
        Me.SKUToolStripTextBox.Size = New System.Drawing.Size(132, 31)
        '
        'SKUCheckoutSearchToolStripButton
        '
        Me.SKUCheckoutSearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SKUCheckoutSearchToolStripButton.Name = "SKUCheckoutSearchToolStripButton"
        Me.SKUCheckoutSearchToolStripButton.Size = New System.Drawing.Size(145, 28)
        Me.SKUCheckoutSearchToolStripButton.Text = "SKUCheckoutSearch"
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(803, 84)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(107, 38)
        Me.btnRefresh.TabIndex = 34
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UPCToolStripLabel, Me.UPCToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 30)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1359, 31)
        Me.FillByToolStrip.TabIndex = 35
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'UPCToolStripLabel
        '
        Me.UPCToolStripLabel.Name = "UPCToolStripLabel"
        Me.UPCToolStripLabel.Size = New System.Drawing.Size(39, 28)
        Me.UPCToolStripLabel.Text = "UPC:"
        '
        'UPCToolStripTextBox
        '
        Me.UPCToolStripTextBox.Name = "UPCToolStripTextBox"
        Me.UPCToolStripTextBox.Size = New System.Drawing.Size(132, 31)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 28)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 65
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 127
        '
        'UPCDataGridViewTextBoxColumn
        '
        Me.UPCDataGridViewTextBoxColumn.DataPropertyName = "UPC"
        Me.UPCDataGridViewTextBoxColumn.HeaderText = "UPC"
        Me.UPCDataGridViewTextBoxColumn.Name = "UPCDataGridViewTextBoxColumn"
        Me.UPCDataGridViewTextBoxColumn.ReadOnly = True
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
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'frmCheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 926)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.SKUCheckoutSearchToolStrip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSearchType)
        Me.Controls.Add(Me.btnCheckout)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmCheckoutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SKUCheckoutSearchToolStrip.ResumeLayout(False)
        Me.SKUCheckoutSearchToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnCheckout As Button
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
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
