<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoupons
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

    'Required by the Windows Form Designer!
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewCoupons = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewPromotions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewDiscounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreateCoupon = New System.Windows.Forms.Button()
        Me.ViewPromotionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtPromotionTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvPromotions = New System.Windows.Forms.DataGridView()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.btnPromotionTitleSearch = New System.Windows.Forms.Button()
        Me.txtPromotionID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiscountIDSearch = New System.Windows.Forms.TextBox()
        Me.btnDiscountIDSearch = New System.Windows.Forms.Button()
        Me.txtDiscountID = New System.Windows.Forms.TextBox()
        Me.dgvDiscounts = New System.Windows.Forms.DataGridView()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.PromotionIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PromotionIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PromotionIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.PromotionIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DiscountIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DiscountIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DiscountIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DiscountIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCouponID = New System.Windows.Forms.TextBox()
        Me.SearchPromotionNameToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TitleToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TitleToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SearchPromotionNameToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.DiscountIDToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.DiscountIDToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.DiscountIDToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.DiscountIDToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DiscountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddDiscountID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddPromotionID = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvPromotions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDiscounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PromotionIDToolStrip.SuspendLayout()
        Me.DiscountIDToolStrip.SuspendLayout()
        Me.SearchPromotionNameToolStrip1.SuspendLayout()
        Me.DiscountIDToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.mnuViewCoupons, Me.mnuViewPromotions, Me.mnuViewDiscounts, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(620, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'mnuViewCoupons
        '
        Me.mnuViewCoupons.Name = "mnuViewCoupons"
        Me.mnuViewCoupons.Size = New System.Drawing.Size(95, 20)
        Me.mnuViewCoupons.Text = "View Coupons"
        '
        'mnuViewPromotions
        '
        Me.mnuViewPromotions.Name = "mnuViewPromotions"
        Me.mnuViewPromotions.Size = New System.Drawing.Size(109, 20)
        Me.mnuViewPromotions.Text = "View Promotions"
        '
        'mnuViewDiscounts
        '
        Me.mnuViewDiscounts.Name = "mnuViewDiscounts"
        Me.mnuViewDiscounts.Size = New System.Drawing.Size(99, 20)
        Me.mnuViewDiscounts.Text = "View Discounts"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(236, 163)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 20)
        Me.txtDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Date:"
        '
        'btnCreateCoupon
        '
        Me.btnCreateCoupon.Location = New System.Drawing.Point(191, 507)
        Me.btnCreateCoupon.Name = "btnCreateCoupon"
        Me.btnCreateCoupon.Size = New System.Drawing.Size(238, 41)
        Me.btnCreateCoupon.TabIndex = 9
        Me.btnCreateCoupon.Text = "Create Coupon"
        Me.btnCreateCoupon.UseVisualStyleBackColor = True
        '
        'ViewPromotionsToolStripMenuItem
        '
        Me.ViewPromotionsToolStripMenuItem.Name = "ViewPromotionsToolStripMenuItem"
        Me.ViewPromotionsToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.ViewPromotionsToolStripMenuItem.Text = "View Promotions"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 195)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 301)
        Me.TabControl1.TabIndex = 82
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.txtPromotionTitle)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dgvPromotions)
        Me.TabPage1.Controls.Add(Me.btnPromotionTitleSearch)
        Me.TabPage1.Controls.Add(Me.txtPromotionID)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(601, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Promotion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtPromotionTitle
        '
        Me.txtPromotionTitle.Location = New System.Drawing.Point(384, 10)
        Me.txtPromotionTitle.Name = "txtPromotionTitle"
        Me.txtPromotionTitle.Size = New System.Drawing.Size(121, 20)
        Me.txtPromotionTitle.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Promotion Name:"
        '
        'dgvPromotions
        '
        Me.dgvPromotions.AllowUserToAddRows = False
        Me.dgvPromotions.AllowUserToDeleteRows = False
        Me.dgvPromotions.AutoGenerateColumns = False
        Me.dgvPromotions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPromotions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.description, Me.btnAddPromotionID})
        Me.dgvPromotions.DataSource = Me.PromotionsBindingSource
        Me.dgvPromotions.Location = New System.Drawing.Point(15, 37)
        Me.dgvPromotions.Name = "dgvPromotions"
        Me.dgvPromotions.ReadOnly = True
        Me.dgvPromotions.RowHeadersVisible = False
        Me.dgvPromotions.Size = New System.Drawing.Size(571, 232)
        Me.dgvPromotions.TabIndex = 98
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPromotionTitleSearch
        '
        Me.btnPromotionTitleSearch.Location = New System.Drawing.Point(511, 8)
        Me.btnPromotionTitleSearch.Name = "btnPromotionTitleSearch"
        Me.btnPromotionTitleSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnPromotionTitleSearch.TabIndex = 97
        Me.btnPromotionTitleSearch.Text = "Search"
        Me.btnPromotionTitleSearch.UseVisualStyleBackColor = True
        '
        'txtPromotionID
        '
        Me.txtPromotionID.Enabled = False
        Me.txtPromotionID.Location = New System.Drawing.Point(89, 11)
        Me.txtPromotionID.Name = "txtPromotionID"
        Me.txtPromotionID.ReadOnly = True
        Me.txtPromotionID.Size = New System.Drawing.Size(121, 20)
        Me.txtPromotionID.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Promotion ID:"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtDiscountIDSearch)
        Me.TabPage2.Controls.Add(Me.btnDiscountIDSearch)
        Me.TabPage2.Controls.Add(Me.txtDiscountID)
        Me.TabPage2.Controls.Add(Me.dgvDiscounts)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Discount"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Discount ID:"
        '
        'txtDiscountIDSearch
        '
        Me.txtDiscountIDSearch.Location = New System.Drawing.Point(384, 11)
        Me.txtDiscountIDSearch.Name = "txtDiscountIDSearch"
        Me.txtDiscountIDSearch.Size = New System.Drawing.Size(121, 20)
        Me.txtDiscountIDSearch.TabIndex = 94
        '
        'btnDiscountIDSearch
        '
        Me.btnDiscountIDSearch.Location = New System.Drawing.Point(511, 9)
        Me.btnDiscountIDSearch.Name = "btnDiscountIDSearch"
        Me.btnDiscountIDSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnDiscountIDSearch.TabIndex = 93
        Me.btnDiscountIDSearch.Text = "Search"
        Me.btnDiscountIDSearch.UseVisualStyleBackColor = True
        '
        'txtDiscountID
        '
        Me.txtDiscountID.Enabled = False
        Me.txtDiscountID.Location = New System.Drawing.Point(84, 11)
        Me.txtDiscountID.Name = "txtDiscountID"
        Me.txtDiscountID.ReadOnly = True
        Me.txtDiscountID.Size = New System.Drawing.Size(121, 20)
        Me.txtDiscountID.TabIndex = 92
        '
        'dgvDiscounts
        '
        Me.dgvDiscounts.AllowUserToAddRows = False
        Me.dgvDiscounts.AllowUserToDeleteRows = False
        Me.dgvDiscounts.AutoGenerateColumns = False
        Me.dgvDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiscounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiscountIDDataGridViewTextBoxColumn, Me.DiscountTypeIDDataGridViewTextBoxColumn, Me.BuyOneDataGridViewTextBoxColumn, Me.GetOneDataGridViewTextBoxColumn, Me.DiscountAmountDataGridViewTextBoxColumn, Me.btnAddDiscountID})
        Me.dgvDiscounts.DataSource = Me.DiscountsBindingSource
        Me.dgvDiscounts.Location = New System.Drawing.Point(15, 37)
        Me.dgvDiscounts.Name = "dgvDiscounts"
        Me.dgvDiscounts.ReadOnly = True
        Me.dgvDiscounts.RowHeadersVisible = False
        Me.dgvDiscounts.Size = New System.Drawing.Size(571, 232)
        Me.dgvDiscounts.TabIndex = 90
        '
        'DiscountsBindingSource
        '
        Me.DiscountsBindingSource.DataMember = "Discounts"
        Me.DiscountsBindingSource.DataSource = Me.GEDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Discount ID:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(236, 92)
        Me.dtpStartDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartDate.TabIndex = 83
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(236, 128)
        Me.dtpEndDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 84
        '
        'PromotionIDToolStrip
        '
        Me.PromotionIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PromotionIDToolStripLabel, Me.PromotionIDToolStripTextBox, Me.PromotionIDToolStripButton})
        Me.PromotionIDToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.PromotionIDToolStrip.Name = "PromotionIDToolStrip"
        Me.PromotionIDToolStrip.Size = New System.Drawing.Size(620, 25)
        Me.PromotionIDToolStrip.TabIndex = 85
        Me.PromotionIDToolStrip.Text = "PromotionIDToolStrip"
        Me.PromotionIDToolStrip.Visible = False
        '
        'PromotionIDToolStripLabel
        '
        Me.PromotionIDToolStripLabel.Name = "PromotionIDToolStripLabel"
        Me.PromotionIDToolStripLabel.Size = New System.Drawing.Size(78, 22)
        Me.PromotionIDToolStripLabel.Text = "promotionID:"
        '
        'PromotionIDToolStripTextBox
        '
        Me.PromotionIDToolStripTextBox.Name = "PromotionIDToolStripTextBox"
        Me.PromotionIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'PromotionIDToolStripButton
        '
        Me.PromotionIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PromotionIDToolStripButton.Name = "PromotionIDToolStripButton"
        Me.PromotionIDToolStripButton.Size = New System.Drawing.Size(79, 22)
        Me.PromotionIDToolStripButton.Text = "promotionID"
        '
        'DiscountIDToolStrip
        '
        Me.DiscountIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscountIDToolStripLabel, Me.DiscountIDToolStripTextBox, Me.DiscountIDToolStripButton})
        Me.DiscountIDToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.DiscountIDToolStrip.Name = "DiscountIDToolStrip"
        Me.DiscountIDToolStrip.Size = New System.Drawing.Size(620, 25)
        Me.DiscountIDToolStrip.TabIndex = 86
        Me.DiscountIDToolStrip.Text = "DiscountIDToolStrip"
        Me.DiscountIDToolStrip.Visible = False
        '
        'DiscountIDToolStripLabel
        '
        Me.DiscountIDToolStripLabel.Name = "DiscountIDToolStripLabel"
        Me.DiscountIDToolStripLabel.Size = New System.Drawing.Size(67, 22)
        Me.DiscountIDToolStripLabel.Text = "discountID:"
        '
        'DiscountIDToolStripTextBox
        '
        Me.DiscountIDToolStripTextBox.Name = "DiscountIDToolStripTextBox"
        Me.DiscountIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DiscountIDToolStripButton
        '
        Me.DiscountIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DiscountIDToolStripButton.Name = "DiscountIDToolStripButton"
        Me.DiscountIDToolStripButton.Size = New System.Drawing.Size(68, 22)
        Me.DiscountIDToolStripButton.Text = "discountID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Coupon ID:"
        '
        'txtCouponID
        '
        Me.txtCouponID.Enabled = False
        Me.txtCouponID.Location = New System.Drawing.Point(236, 57)
        Me.txtCouponID.Name = "txtCouponID"
        Me.txtCouponID.ReadOnly = True
        Me.txtCouponID.Size = New System.Drawing.Size(121, 20)
        Me.txtCouponID.TabIndex = 87
        '
        'SearchPromotionNameToolStrip1
        '
        Me.SearchPromotionNameToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitleToolStripLabel1, Me.TitleToolStripTextBox1, Me.SearchPromotionNameToolStripButton1})
        Me.SearchPromotionNameToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.SearchPromotionNameToolStrip1.Name = "SearchPromotionNameToolStrip1"
        Me.SearchPromotionNameToolStrip1.Size = New System.Drawing.Size(620, 25)
        Me.SearchPromotionNameToolStrip1.TabIndex = 90
        Me.SearchPromotionNameToolStrip1.Text = "SearchPromotionNameToolStrip1"
        Me.SearchPromotionNameToolStrip1.Visible = False
        '
        'TitleToolStripLabel1
        '
        Me.TitleToolStripLabel1.Name = "TitleToolStripLabel1"
        Me.TitleToolStripLabel1.Size = New System.Drawing.Size(30, 22)
        Me.TitleToolStripLabel1.Text = "title:"
        '
        'TitleToolStripTextBox1
        '
        Me.TitleToolStripTextBox1.Name = "TitleToolStripTextBox1"
        Me.TitleToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'SearchPromotionNameToolStripButton1
        '
        Me.SearchPromotionNameToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchPromotionNameToolStripButton1.Name = "SearchPromotionNameToolStripButton1"
        Me.SearchPromotionNameToolStripButton1.Size = New System.Drawing.Size(134, 22)
        Me.SearchPromotionNameToolStripButton1.Text = "searchPromotionName"
        '
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'DiscountsTableAdapter
        '
        Me.DiscountsTableAdapter.ClearBeforeFill = True
        '
        'DiscountIDToolStrip1
        '
        Me.DiscountIDToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiscountIDToolStripLabel1, Me.DiscountIDToolStripTextBox1, Me.DiscountIDToolStripButton1})
        Me.DiscountIDToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.DiscountIDToolStrip1.Name = "DiscountIDToolStrip1"
        Me.DiscountIDToolStrip1.Size = New System.Drawing.Size(620, 25)
        Me.DiscountIDToolStrip1.TabIndex = 91
        Me.DiscountIDToolStrip1.Text = "DiscountIDToolStrip1"
        Me.DiscountIDToolStrip1.Visible = False
        '
        'DiscountIDToolStripLabel1
        '
        Me.DiscountIDToolStripLabel1.Name = "DiscountIDToolStripLabel1"
        Me.DiscountIDToolStripLabel1.Size = New System.Drawing.Size(67, 22)
        Me.DiscountIDToolStripLabel1.Text = "discountID:"
        '
        'DiscountIDToolStripTextBox1
        '
        Me.DiscountIDToolStripTextBox1.Name = "DiscountIDToolStripTextBox1"
        Me.DiscountIDToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'DiscountIDToolStripButton1
        '
        Me.DiscountIDToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DiscountIDToolStripButton1.Name = "DiscountIDToolStripButton1"
        Me.DiscountIDToolStripButton1.Size = New System.Drawing.Size(68, 22)
        Me.DiscountIDToolStripButton1.Text = "discountID"
        '
        'DiscountIDDataGridViewTextBoxColumn
        '
        Me.DiscountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.FillWeight = 178.1116!
        Me.DiscountIDDataGridViewTextBoxColumn.HeaderText = "Discount ID"
        Me.DiscountIDDataGridViewTextBoxColumn.Name = "DiscountIDDataGridViewTextBoxColumn"
        Me.DiscountIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountIDDataGridViewTextBoxColumn.Width = 83
        '
        'DiscountTypeIDDataGridViewTextBoxColumn
        '
        Me.DiscountTypeIDDataGridViewTextBoxColumn.DataPropertyName = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.FillWeight = 157.4129!
        Me.DiscountTypeIDDataGridViewTextBoxColumn.HeaderText = "Discount Type ID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Name = "DiscountTypeIDDataGridViewTextBoxColumn"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Width = 107
        '
        'BuyOneDataGridViewTextBoxColumn
        '
        Me.BuyOneDataGridViewTextBoxColumn.DataPropertyName = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.FillWeight = 59.493!
        Me.BuyOneDataGridViewTextBoxColumn.HeaderText = "Buy One"
        Me.BuyOneDataGridViewTextBoxColumn.Name = "BuyOneDataGridViewTextBoxColumn"
        Me.BuyOneDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuyOneDataGridViewTextBoxColumn.Width = 69
        '
        'GetOneDataGridViewTextBoxColumn
        '
        Me.GetOneDataGridViewTextBoxColumn.DataPropertyName = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.FillWeight = 45.26747!
        Me.GetOneDataGridViewTextBoxColumn.HeaderText = "Get One"
        Me.GetOneDataGridViewTextBoxColumn.Name = "GetOneDataGridViewTextBoxColumn"
        Me.GetOneDataGridViewTextBoxColumn.ReadOnly = True
        Me.GetOneDataGridViewTextBoxColumn.Width = 67
        '
        'DiscountAmountDataGridViewTextBoxColumn
        '
        Me.DiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.FillWeight = 59.71498!
        Me.DiscountAmountDataGridViewTextBoxColumn.HeaderText = "Discount Amount"
        Me.DiscountAmountDataGridViewTextBoxColumn.Name = "DiscountAmountDataGridViewTextBoxColumn"
        Me.DiscountAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountAmountDataGridViewTextBoxColumn.Width = 108
        '
        'btnAddDiscountID
        '
        Me.btnAddDiscountID.HeaderText = ""
        Me.btnAddDiscountID.Name = "btnAddDiscountID"
        Me.btnAddDiscountID.ReadOnly = True
        Me.btnAddDiscountID.Text = "Add"
        Me.btnAddDiscountID.UseColumnTextForButtonValue = True
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "Promotion ID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        Me.PromotionIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PromotionIDDataGridViewTextBoxColumn.Width = 89
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 52
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 230
        '
        'btnAddPromotionID
        '
        Me.btnAddPromotionID.HeaderText = ""
        Me.btnAddPromotionID.Name = "btnAddPromotionID"
        Me.btnAddPromotionID.ReadOnly = True
        Me.btnAddPromotionID.Text = "Add"
        Me.btnAddPromotionID.UseColumnTextForButtonValue = True
        '
        'frmCoupons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 553)
        Me.Controls.Add(Me.SearchPromotionNameToolStrip1)
        Me.Controls.Add(Me.DiscountIDToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCouponID)
        Me.Controls.Add(Me.PromotionIDToolStrip)
        Me.Controls.Add(Me.DiscountIDToolStrip)
        Me.Controls.Add(Me.dtpEndDate)
        Me.Controls.Add(Me.dtpStartDate)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCreateCoupon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCoupons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupons"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvPromotions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDiscounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PromotionIDToolStrip.ResumeLayout(False)
        Me.PromotionIDToolStrip.PerformLayout()
        Me.DiscountIDToolStrip.ResumeLayout(False)
        Me.DiscountIDToolStrip.PerformLayout()
        Me.SearchPromotionNameToolStrip1.ResumeLayout(False)
        Me.SearchPromotionNameToolStrip1.PerformLayout()
        Me.DiscountIDToolStrip1.ResumeLayout(False)
        Me.DiscountIDToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuViewCoupons As ToolStripMenuItem
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCreateCoupon As Button
    Friend WithEvents ViewPromotionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents DiscountsBindingSource As BindingSource
    Friend WithEvents DiscountsTableAdapter As GEDataSetTableAdapters.DiscountsTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvPromotions As DataGridView
    Friend WithEvents btnPromotionTitleSearch As Button
    Friend WithEvents txtPromotionID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnDiscountIDSearch As Button
    Friend WithEvents txtDiscountID As TextBox
    Friend WithEvents dgvDiscounts As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents mnuViewPromotions As ToolStripMenuItem
    Friend WithEvents mnuViewDiscounts As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents PromotionIDToolStrip As ToolStrip
    Friend WithEvents PromotionIDToolStripLabel As ToolStripLabel
    Friend WithEvents PromotionIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents PromotionIDToolStripButton As ToolStripButton
    Friend WithEvents DiscountIDToolStrip As ToolStrip
    Friend WithEvents DiscountIDToolStripLabel As ToolStripLabel
    Friend WithEvents DiscountIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents DiscountIDToolStripButton As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCouponID As TextBox
    Friend WithEvents txtPromotionTitle As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiscountIDSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SearchPromotionNameToolStrip1 As ToolStrip
    Friend WithEvents TitleToolStripLabel1 As ToolStripLabel
    Friend WithEvents TitleToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents SearchPromotionNameToolStripButton1 As ToolStripButton
    Friend WithEvents DiscountIDToolStrip1 As ToolStrip
    Friend WithEvents DiscountIDToolStripLabel1 As ToolStripLabel
    Friend WithEvents DiscountIDToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents DiscountIDToolStripButton1 As ToolStripButton
    Friend WithEvents DiscountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GetOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAddDiscountID As DataGridViewButtonColumn
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents btnAddPromotionID As DataGridViewButtonColumn
End Class
