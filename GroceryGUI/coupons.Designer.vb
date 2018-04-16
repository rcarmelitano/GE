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
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCouponsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPromotionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDiscountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCreateCoupon = New System.Windows.Forms.Button()
        Me.ViewPromotionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPromotionIDSearch = New System.Windows.Forms.Button()
        Me.txtPromotionID = New System.Windows.Forms.TextBox()
        Me.btnRemoveID = New System.Windows.Forms.Button()
        Me.btnAddPromotion = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDiscountIDSearch = New System.Windows.Forms.Button()
        Me.txtDiscountID = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DiscountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.ViewCouponsToolStripMenuItem, Me.ViewPromotionsToolStripMenuItem1, Me.ViewDiscountsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(620, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ViewCouponsToolStripMenuItem
        '
        Me.ViewCouponsToolStripMenuItem.Name = "ViewCouponsToolStripMenuItem"
        Me.ViewCouponsToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ViewCouponsToolStripMenuItem.Text = "View Coupons"
        '
        'ViewPromotionsToolStripMenuItem1
        '
        Me.ViewPromotionsToolStripMenuItem1.Name = "ViewPromotionsToolStripMenuItem1"
        Me.ViewPromotionsToolStripMenuItem1.Size = New System.Drawing.Size(109, 20)
        Me.ViewPromotionsToolStripMenuItem1.Text = "View Promotions"
        '
        'ViewDiscountsToolStripMenuItem
        '
        Me.ViewDiscountsToolStripMenuItem.Name = "ViewDiscountsToolStripMenuItem"
        Me.ViewDiscountsToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ViewDiscountsToolStripMenuItem.Text = "View Discounts"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(242, 123)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(200, 20)
        Me.txtDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Date:"
        '
        'btnCreateCoupon
        '
        Me.btnCreateCoupon.Location = New System.Drawing.Point(191, 464)
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
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'DiscountsBindingSource
        '
        Me.DiscountsBindingSource.DataMember = "Discounts"
        Me.DiscountsBindingSource.DataSource = Me.GEDataSet
        '
        'DiscountsTableAdapter
        '
        Me.DiscountsTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 157)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 301)
        Me.TabControl1.TabIndex = 82
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.btnPromotionIDSearch)
        Me.TabPage1.Controls.Add(Me.txtPromotionID)
        Me.TabPage1.Controls.Add(Me.btnRemoveID)
        Me.TabPage1.Controls.Add(Me.btnAddPromotion)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(601, 275)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Promotion"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionIDDataGridViewTextBoxColumn, Me.description, Me.TitleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PromotionsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(571, 192)
        Me.DataGridView1.TabIndex = 98
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        Me.PromotionIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PromotionIDDataGridViewTextBoxColumn.Width = 89
        '
        'description
        '
        Me.description.DataPropertyName = "description"
        Me.description.HeaderText = "description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Width = 83
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 48
        '
        'btnPromotionIDSearch
        '
        Me.btnPromotionIDSearch.Location = New System.Drawing.Point(216, 10)
        Me.btnPromotionIDSearch.Name = "btnPromotionIDSearch"
        Me.btnPromotionIDSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnPromotionIDSearch.TabIndex = 97
        Me.btnPromotionIDSearch.Text = "Search"
        Me.btnPromotionIDSearch.UseVisualStyleBackColor = True
        '
        'txtPromotionID
        '
        Me.txtPromotionID.Location = New System.Drawing.Point(89, 11)
        Me.txtPromotionID.Name = "txtPromotionID"
        Me.txtPromotionID.Size = New System.Drawing.Size(121, 20)
        Me.txtPromotionID.TabIndex = 95
        '
        'btnRemoveID
        '
        Me.btnRemoveID.Location = New System.Drawing.Point(310, 235)
        Me.btnRemoveID.Name = "btnRemoveID"
        Me.btnRemoveID.Size = New System.Drawing.Size(276, 33)
        Me.btnRemoveID.TabIndex = 94
        Me.btnRemoveID.Text = "Remove"
        Me.btnRemoveID.UseVisualStyleBackColor = True
        '
        'btnAddPromotion
        '
        Me.btnAddPromotion.Location = New System.Drawing.Point(15, 235)
        Me.btnAddPromotion.Name = "btnAddPromotion"
        Me.btnAddPromotion.Size = New System.Drawing.Size(276, 33)
        Me.btnAddPromotion.TabIndex = 93
        Me.btnAddPromotion.Text = "Add"
        Me.btnAddPromotion.UseVisualStyleBackColor = True
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
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.btnDiscountIDSearch)
        Me.TabPage2.Controls.Add(Me.txtDiscountID)
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 275)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Discount"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 33)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(222, 33)
        Me.Button2.TabIndex = 105
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDiscountIDSearch
        '
        Me.btnDiscountIDSearch.Location = New System.Drawing.Point(211, 10)
        Me.btnDiscountIDSearch.Name = "btnDiscountIDSearch"
        Me.btnDiscountIDSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnDiscountIDSearch.TabIndex = 93
        Me.btnDiscountIDSearch.Text = "Search"
        Me.btnDiscountIDSearch.UseVisualStyleBackColor = True
        '
        'txtDiscountID
        '
        Me.txtDiscountID.Location = New System.Drawing.Point(84, 11)
        Me.txtDiscountID.Name = "txtDiscountID"
        Me.txtDiscountID.Size = New System.Drawing.Size(121, 20)
        Me.txtDiscountID.TabIndex = 92
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiscountIDDataGridViewTextBoxColumn, Me.DiscountTypeIDDataGridViewTextBoxColumn, Me.BuyOneDataGridViewTextBoxColumn, Me.GetOneDataGridViewTextBoxColumn, Me.DiscountAmountDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.DiscountsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(15, 37)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(456, 192)
        Me.DataGridView2.TabIndex = 90
        '
        'DiscountIDDataGridViewTextBoxColumn
        '
        Me.DiscountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.FillWeight = 178.1116!
        Me.DiscountIDDataGridViewTextBoxColumn.HeaderText = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.Name = "DiscountIDDataGridViewTextBoxColumn"
        Me.DiscountIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountIDDataGridViewTextBoxColumn.Width = 83
        '
        'DiscountTypeIDDataGridViewTextBoxColumn
        '
        Me.DiscountTypeIDDataGridViewTextBoxColumn.DataPropertyName = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.FillWeight = 157.4129!
        Me.DiscountTypeIDDataGridViewTextBoxColumn.HeaderText = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Name = "DiscountTypeIDDataGridViewTextBoxColumn"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Width = 107
        '
        'BuyOneDataGridViewTextBoxColumn
        '
        Me.BuyOneDataGridViewTextBoxColumn.DataPropertyName = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.FillWeight = 59.493!
        Me.BuyOneDataGridViewTextBoxColumn.HeaderText = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.Name = "BuyOneDataGridViewTextBoxColumn"
        Me.BuyOneDataGridViewTextBoxColumn.ReadOnly = True
        Me.BuyOneDataGridViewTextBoxColumn.Width = 69
        '
        'GetOneDataGridViewTextBoxColumn
        '
        Me.GetOneDataGridViewTextBoxColumn.DataPropertyName = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.FillWeight = 45.26747!
        Me.GetOneDataGridViewTextBoxColumn.HeaderText = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.Name = "GetOneDataGridViewTextBoxColumn"
        Me.GetOneDataGridViewTextBoxColumn.ReadOnly = True
        Me.GetOneDataGridViewTextBoxColumn.Width = 67
        '
        'DiscountAmountDataGridViewTextBoxColumn
        '
        Me.DiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.FillWeight = 59.71498!
        Me.DiscountAmountDataGridViewTextBoxColumn.HeaderText = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.Name = "DiscountAmountDataGridViewTextBoxColumn"
        Me.DiscountAmountDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountAmountDataGridViewTextBoxColumn.Width = 108
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
        Me.dtpStartDate.Location = New System.Drawing.Point(242, 52)
        Me.dtpStartDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpStartDate.TabIndex = 83
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(242, 88)
        Me.dtpEndDate.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpEndDate.TabIndex = 84
        '
        'frmCoupons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 514)
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
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCouponsToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnPromotionIDSearch As Button
    Friend WithEvents txtPromotionID As TextBox
    Friend WithEvents btnRemoveID As Button
    Friend WithEvents btnAddPromotion As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnDiscountIDSearch As Button
    Friend WithEvents txtDiscountID As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DiscountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GetOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ViewPromotionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewDiscountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
