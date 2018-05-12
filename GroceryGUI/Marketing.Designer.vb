<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marketing
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
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tabCampaigns = New System.Windows.Forms.TabPage()
        Me.btnAddCamp = New System.Windows.Forms.Button()
        Me.comboCampType = New System.Windows.Forms.ComboBox()
        Me.CampaignTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.campEDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.campSDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtCampDescription = New System.Windows.Forms.TextBox()
        Me.txtCampaignName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.datagridCampaign = New System.Windows.Forms.DataGridView()
        Me.CampaignIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampaignTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarketingCampaignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabPromotions = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampaignIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromoInfoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabDiscounts = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DiscountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Marketing_CampaignsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Marketing_CampaignsTableAdapter()
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.Campaign_TypesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Campaign_TypesTableAdapter()
        Me.tabControl.SuspendLayout()
        Me.tabCampaigns.SuspendLayout()
        CType(Me.CampaignTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridCampaign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketingCampaignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPromotions.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDiscounts.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabCampaigns)
        Me.tabControl.Controls.Add(Me.tabPromotions)
        Me.tabControl.Controls.Add(Me.tabDiscounts)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(924, 610)
        Me.tabControl.TabIndex = 0
        '
        'tabCampaigns
        '
        Me.tabCampaigns.Controls.Add(Me.btnAddCamp)
        Me.tabCampaigns.Controls.Add(Me.comboCampType)
        Me.tabCampaigns.Controls.Add(Me.campEDatePicker)
        Me.tabCampaigns.Controls.Add(Me.campSDatePicker)
        Me.tabCampaigns.Controls.Add(Me.txtCampDescription)
        Me.tabCampaigns.Controls.Add(Me.txtCampaignName)
        Me.tabCampaigns.Controls.Add(Me.Label5)
        Me.tabCampaigns.Controls.Add(Me.Label4)
        Me.tabCampaigns.Controls.Add(Me.Label3)
        Me.tabCampaigns.Controls.Add(Me.Label2)
        Me.tabCampaigns.Controls.Add(Me.Label1)
        Me.tabCampaigns.Controls.Add(Me.datagridCampaign)
        Me.tabCampaigns.Location = New System.Drawing.Point(4, 22)
        Me.tabCampaigns.Name = "tabCampaigns"
        Me.tabCampaigns.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCampaigns.Size = New System.Drawing.Size(916, 584)
        Me.tabCampaigns.TabIndex = 0
        Me.tabCampaigns.Text = "Campaigns"
        Me.tabCampaigns.UseVisualStyleBackColor = True
        '
        'btnAddCamp
        '
        Me.btnAddCamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCamp.Location = New System.Drawing.Point(71, 206)
        Me.btnAddCamp.Name = "btnAddCamp"
        Me.btnAddCamp.Size = New System.Drawing.Size(268, 45)
        Me.btnAddCamp.TabIndex = 37
        Me.btnAddCamp.Text = "Add Campaign"
        Me.btnAddCamp.UseVisualStyleBackColor = True
        '
        'comboCampType
        '
        Me.comboCampType.DataSource = Me.CampaignTypesBindingSource
        Me.comboCampType.DisplayMember = "title"
        Me.comboCampType.FormattingEnabled = True
        Me.comboCampType.Location = New System.Drawing.Point(139, 62)
        Me.comboCampType.Name = "comboCampType"
        Me.comboCampType.Size = New System.Drawing.Size(200, 21)
        Me.comboCampType.TabIndex = 36
        Me.comboCampType.ValueMember = "campaignTypeID"
        '
        'CampaignTypesBindingSource
        '
        Me.CampaignTypesBindingSource.DataMember = "Campaign_Types"
        Me.CampaignTypesBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'campEDatePicker
        '
        Me.campEDatePicker.CustomFormat = "mm/dd/yyyy"
        Me.campEDatePicker.Location = New System.Drawing.Point(139, 168)
        Me.campEDatePicker.Name = "campEDatePicker"
        Me.campEDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.campEDatePicker.TabIndex = 35
        Me.campEDatePicker.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'campSDatePicker
        '
        Me.campSDatePicker.CustomFormat = "mm/dd/yyyy"
        Me.campSDatePicker.Location = New System.Drawing.Point(139, 136)
        Me.campSDatePicker.Name = "campSDatePicker"
        Me.campSDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.campSDatePicker.TabIndex = 34
        Me.campSDatePicker.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'txtCampDescription
        '
        Me.txtCampDescription.Location = New System.Drawing.Point(139, 99)
        Me.txtCampDescription.Name = "txtCampDescription"
        Me.txtCampDescription.Size = New System.Drawing.Size(200, 20)
        Me.txtCampDescription.TabIndex = 33
        '
        'txtCampaignName
        '
        Me.txtCampaignName.Location = New System.Drawing.Point(139, 27)
        Me.txtCampaignName.Name = "txtCampaignName"
        Me.txtCampaignName.Size = New System.Drawing.Size(200, 20)
        Me.txtCampaignName.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(66, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "End Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(63, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Start Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(54, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Campaign Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Campaign Name:"
        '
        'datagridCampaign
        '
        Me.datagridCampaign.AutoGenerateColumns = False
        Me.datagridCampaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridCampaign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CampaignIDDataGridViewTextBoxColumn, Me.CampaignTypeIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn})
        Me.datagridCampaign.DataSource = Me.MarketingCampaignsBindingSource
        Me.datagridCampaign.Location = New System.Drawing.Point(0, 271)
        Me.datagridCampaign.Name = "datagridCampaign"
        Me.datagridCampaign.Size = New System.Drawing.Size(916, 310)
        Me.datagridCampaign.TabIndex = 0
        '
        'CampaignIDDataGridViewTextBoxColumn
        '
        Me.CampaignIDDataGridViewTextBoxColumn.DataPropertyName = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn.HeaderText = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn.Name = "CampaignIDDataGridViewTextBoxColumn"
        '
        'CampaignTypeIDDataGridViewTextBoxColumn
        '
        Me.CampaignTypeIDDataGridViewTextBoxColumn.DataPropertyName = "campaignTypeID"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.HeaderText = "campaignTypeID"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.Name = "CampaignTypeIDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "startDate"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "startDate"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "endDate"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "endDate"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        '
        'MarketingCampaignsBindingSource
        '
        Me.MarketingCampaignsBindingSource.DataMember = "Marketing_Campaigns"
        Me.MarketingCampaignsBindingSource.DataSource = Me.GEDataSet
        '
        'tabPromotions
        '
        Me.tabPromotions.Controls.Add(Me.DataGridView2)
        Me.tabPromotions.Location = New System.Drawing.Point(4, 22)
        Me.tabPromotions.Name = "tabPromotions"
        Me.tabPromotions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPromotions.Size = New System.Drawing.Size(916, 584)
        Me.tabPromotions.TabIndex = 1
        Me.tabPromotions.Text = "Promotions"
        Me.tabPromotions.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionIDDataGridViewTextBoxColumn, Me.CampaignIDDataGridViewTextBoxColumn1, Me.PromoInfoIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn1, Me.StartDateDataGridViewTextBoxColumn1, Me.EndDateDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.PromotionsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(8, 235)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(908, 317)
        Me.DataGridView2.TabIndex = 0
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        '
        'CampaignIDDataGridViewTextBoxColumn1
        '
        Me.CampaignIDDataGridViewTextBoxColumn1.DataPropertyName = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn1.HeaderText = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn1.Name = "CampaignIDDataGridViewTextBoxColumn1"
        '
        'PromoInfoIDDataGridViewTextBoxColumn
        '
        Me.PromoInfoIDDataGridViewTextBoxColumn.DataPropertyName = "promoInfoID"
        Me.PromoInfoIDDataGridViewTextBoxColumn.HeaderText = "promoInfoID"
        Me.PromoInfoIDDataGridViewTextBoxColumn.Name = "PromoInfoIDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn1
        '
        Me.TitleDataGridViewTextBoxColumn1.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn1.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn1.Name = "TitleDataGridViewTextBoxColumn1"
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        '
        'StartDateDataGridViewTextBoxColumn1
        '
        Me.StartDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate"
        Me.StartDateDataGridViewTextBoxColumn1.HeaderText = "startDate"
        Me.StartDateDataGridViewTextBoxColumn1.Name = "StartDateDataGridViewTextBoxColumn1"
        '
        'EndDateDataGridViewTextBoxColumn1
        '
        Me.EndDateDataGridViewTextBoxColumn1.DataPropertyName = "endDate"
        Me.EndDateDataGridViewTextBoxColumn1.HeaderText = "endDate"
        Me.EndDateDataGridViewTextBoxColumn1.Name = "EndDateDataGridViewTextBoxColumn1"
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.GEDataSet
        '
        'tabDiscounts
        '
        Me.tabDiscounts.Controls.Add(Me.DataGridView3)
        Me.tabDiscounts.Location = New System.Drawing.Point(4, 22)
        Me.tabDiscounts.Name = "tabDiscounts"
        Me.tabDiscounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDiscounts.Size = New System.Drawing.Size(916, 584)
        Me.tabDiscounts.TabIndex = 2
        Me.tabDiscounts.Text = "Discounts"
        Me.tabDiscounts.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiscountIDDataGridViewTextBoxColumn, Me.DiscountTypeIDDataGridViewTextBoxColumn, Me.BuyOneDataGridViewTextBoxColumn, Me.GetOneDataGridViewTextBoxColumn, Me.DiscountAmountDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.DiscountsBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(3, 248)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(906, 293)
        Me.DataGridView3.TabIndex = 0
        '
        'DiscountIDDataGridViewTextBoxColumn
        '
        Me.DiscountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.HeaderText = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.Name = "DiscountIDDataGridViewTextBoxColumn"
        '
        'DiscountTypeIDDataGridViewTextBoxColumn
        '
        Me.DiscountTypeIDDataGridViewTextBoxColumn.DataPropertyName = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.HeaderText = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Name = "DiscountTypeIDDataGridViewTextBoxColumn"
        '
        'BuyOneDataGridViewTextBoxColumn
        '
        Me.BuyOneDataGridViewTextBoxColumn.DataPropertyName = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.HeaderText = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.Name = "BuyOneDataGridViewTextBoxColumn"
        '
        'GetOneDataGridViewTextBoxColumn
        '
        Me.GetOneDataGridViewTextBoxColumn.DataPropertyName = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.HeaderText = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.Name = "GetOneDataGridViewTextBoxColumn"
        '
        'DiscountAmountDataGridViewTextBoxColumn
        '
        Me.DiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.HeaderText = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.Name = "DiscountAmountDataGridViewTextBoxColumn"
        '
        'DiscountsBindingSource
        '
        Me.DiscountsBindingSource.DataMember = "Discounts"
        Me.DiscountsBindingSource.DataSource = Me.GEDataSet
        '
        'Marketing_CampaignsTableAdapter
        '
        Me.Marketing_CampaignsTableAdapter.ClearBeforeFill = True
        '
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'DiscountsTableAdapter
        '
        Me.DiscountsTableAdapter.ClearBeforeFill = True
        '
        'Campaign_TypesTableAdapter
        '
        Me.Campaign_TypesTableAdapter.ClearBeforeFill = True
        '
        'Marketing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 607)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "Marketing"
        Me.Text = "Marketing"
        Me.tabControl.ResumeLayout(False)
        Me.tabCampaigns.ResumeLayout(False)
        Me.tabCampaigns.PerformLayout()
        CType(Me.CampaignTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridCampaign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketingCampaignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPromotions.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDiscounts.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabCampaigns As TabPage
    Friend WithEvents tabPromotions As TabPage
    Friend WithEvents tabDiscounts As TabPage
    Friend WithEvents datagridCampaign As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents MarketingCampaignsBindingSource As BindingSource
    Friend WithEvents Marketing_CampaignsTableAdapter As GEDataSetTableAdapters.Marketing_CampaignsTableAdapter
    Friend WithEvents CampaignIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampaignTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampaignIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PromoInfoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DiscountsBindingSource As BindingSource
    Friend WithEvents DiscountsTableAdapter As GEDataSetTableAdapters.DiscountsTableAdapter
    Friend WithEvents DiscountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GetOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents comboCampType As ComboBox
    Friend WithEvents campEDatePicker As DateTimePicker
    Friend WithEvents campSDatePicker As DateTimePicker
    Friend WithEvents txtCampDescription As TextBox
    Friend WithEvents txtCampaignName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CampaignTypesBindingSource As BindingSource
    Friend WithEvents Campaign_TypesTableAdapter As GEDataSetTableAdapters.Campaign_TypesTableAdapter
    Friend WithEvents btnAddCamp As Button
End Class
