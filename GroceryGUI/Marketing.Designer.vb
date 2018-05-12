<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Marketing
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
        Me.MarketingCampaignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabPromotions = New System.Windows.Forms.TabPage()
        Me.chkCampAssociation = New System.Windows.Forms.CheckBox()
        Me.cmbCampPicker = New System.Windows.Forms.ComboBox()
        Me.btnAddPromotion = New System.Windows.Forms.Button()
        Me.promoEDate = New System.Windows.Forms.DateTimePicker()
        Me.promoSDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPromoDesc = New System.Windows.Forms.TextBox()
        Me.txtPromotionName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabDiscounts = New System.Windows.Forms.TabPage()
        Me.lblGetOne = New System.Windows.Forms.Label()
        Me.txtGetOne = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbPromo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbDiscountType = New System.Windows.Forms.ComboBox()
        Me.DiscountTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBuyOne = New System.Windows.Forms.TextBox()
        Me.lblBuyOne = New System.Windows.Forms.Label()
        Me.lblFlatDiscount = New System.Windows.Forms.Label()
        Me.txtFlatDiscount = New System.Windows.Forms.TextBox()
        Me.lblPercentageDiscount = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Marketing_CampaignsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Marketing_CampaignsTableAdapter()
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.Campaign_TypesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Campaign_TypesTableAdapter()
        Me.Discount_TypeTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Discount_TypeTableAdapter()
        Me.CampaignTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampaignIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampaignTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampaignTypeID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarketingCampaignsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DiscountTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campaign = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CampaignIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DiscountTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampaignTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketingCampaignsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tabCampaigns)
        Me.tabControl.Controls.Add(Me.tabPromotions)
        Me.tabControl.Controls.Add(Me.tabDiscounts)
        Me.tabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.tabCampaigns.Location = New System.Drawing.Point(4, 27)
        Me.tabCampaigns.Name = "tabCampaigns"
        Me.tabCampaigns.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCampaigns.Size = New System.Drawing.Size(916, 579)
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
        Me.comboCampType.Size = New System.Drawing.Size(200, 26)
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
        Me.campEDatePicker.Size = New System.Drawing.Size(200, 24)
        Me.campEDatePicker.TabIndex = 35
        Me.campEDatePicker.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'campSDatePicker
        '
        Me.campSDatePicker.CustomFormat = "mm/dd/yyyy"
        Me.campSDatePicker.Location = New System.Drawing.Point(139, 136)
        Me.campSDatePicker.Name = "campSDatePicker"
        Me.campSDatePicker.Size = New System.Drawing.Size(200, 24)
        Me.campSDatePicker.TabIndex = 34
        Me.campSDatePicker.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'txtCampDescription
        '
        Me.txtCampDescription.Location = New System.Drawing.Point(139, 99)
        Me.txtCampDescription.Name = "txtCampDescription"
        Me.txtCampDescription.Size = New System.Drawing.Size(200, 24)
        Me.txtCampDescription.TabIndex = 33
        '
        'txtCampaignName
        '
        Me.txtCampaignName.Location = New System.Drawing.Point(139, 27)
        Me.txtCampaignName.Name = "txtCampaignName"
        Me.txtCampaignName.Size = New System.Drawing.Size(200, 24)
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
        Me.datagridCampaign.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CampaignIDDataGridViewTextBoxColumn, Me.CampaignTypeIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.CampaignTypeID, Me.DescriptionDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn})
        Me.datagridCampaign.DataSource = Me.MarketingCampaignsBindingSource
        Me.datagridCampaign.Location = New System.Drawing.Point(0, 257)
        Me.datagridCampaign.Name = "datagridCampaign"
        Me.datagridCampaign.Size = New System.Drawing.Size(916, 324)
        Me.datagridCampaign.TabIndex = 0
        '
        'MarketingCampaignsBindingSource
        '
        Me.MarketingCampaignsBindingSource.DataMember = "Marketing_Campaigns"
        Me.MarketingCampaignsBindingSource.DataSource = Me.GEDataSet
        '
        'tabPromotions
        '
        Me.tabPromotions.Controls.Add(Me.chkCampAssociation)
        Me.tabPromotions.Controls.Add(Me.cmbCampPicker)
        Me.tabPromotions.Controls.Add(Me.btnAddPromotion)
        Me.tabPromotions.Controls.Add(Me.promoEDate)
        Me.tabPromotions.Controls.Add(Me.promoSDate)
        Me.tabPromotions.Controls.Add(Me.txtPromoDesc)
        Me.tabPromotions.Controls.Add(Me.txtPromotionName)
        Me.tabPromotions.Controls.Add(Me.Label7)
        Me.tabPromotions.Controls.Add(Me.Label8)
        Me.tabPromotions.Controls.Add(Me.Label9)
        Me.tabPromotions.Controls.Add(Me.Label10)
        Me.tabPromotions.Controls.Add(Me.DataGridView2)
        Me.tabPromotions.Location = New System.Drawing.Point(4, 27)
        Me.tabPromotions.Name = "tabPromotions"
        Me.tabPromotions.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPromotions.Size = New System.Drawing.Size(916, 579)
        Me.tabPromotions.TabIndex = 1
        Me.tabPromotions.Text = "Promotions"
        Me.tabPromotions.UseVisualStyleBackColor = True
        '
        'chkCampAssociation
        '
        Me.chkCampAssociation.AutoSize = True
        Me.chkCampAssociation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkCampAssociation.Location = New System.Drawing.Point(35, 63)
        Me.chkCampAssociation.Name = "chkCampAssociation"
        Me.chkCampAssociation.Size = New System.Drawing.Size(89, 20)
        Me.chkCampAssociation.TabIndex = 27
        Me.chkCampAssociation.Text = "Campaign"
        Me.chkCampAssociation.UseVisualStyleBackColor = True
        '
        'cmbCampPicker
        '
        Me.cmbCampPicker.DataSource = Me.MarketingCampaignsBindingSource
        Me.cmbCampPicker.DisplayMember = "title"
        Me.cmbCampPicker.Enabled = False
        Me.cmbCampPicker.FormattingEnabled = True
        Me.cmbCampPicker.Location = New System.Drawing.Point(139, 62)
        Me.cmbCampPicker.Name = "cmbCampPicker"
        Me.cmbCampPicker.Size = New System.Drawing.Size(195, 26)
        Me.cmbCampPicker.TabIndex = 26
        Me.cmbCampPicker.ValueMember = "campaignID"
        '
        'btnAddPromotion
        '
        Me.btnAddPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPromotion.Location = New System.Drawing.Point(71, 206)
        Me.btnAddPromotion.Name = "btnAddPromotion"
        Me.btnAddPromotion.Size = New System.Drawing.Size(268, 45)
        Me.btnAddPromotion.TabIndex = 24
        Me.btnAddPromotion.Text = "Add Promotion"
        Me.btnAddPromotion.UseVisualStyleBackColor = True
        '
        'promoEDate
        '
        Me.promoEDate.Location = New System.Drawing.Point(139, 178)
        Me.promoEDate.Name = "promoEDate"
        Me.promoEDate.Size = New System.Drawing.Size(195, 24)
        Me.promoEDate.TabIndex = 23
        '
        'promoSDate
        '
        Me.promoSDate.Location = New System.Drawing.Point(139, 140)
        Me.promoSDate.Name = "promoSDate"
        Me.promoSDate.Size = New System.Drawing.Size(195, 24)
        Me.promoSDate.TabIndex = 22
        '
        'txtPromoDesc
        '
        Me.txtPromoDesc.Location = New System.Drawing.Point(139, 99)
        Me.txtPromoDesc.Name = "txtPromoDesc"
        Me.txtPromoDesc.Size = New System.Drawing.Size(195, 24)
        Me.txtPromoDesc.TabIndex = 21
        '
        'txtPromotionName
        '
        Me.txtPromotionName.Location = New System.Drawing.Point(139, 27)
        Me.txtPromotionName.Name = "txtPromotionName"
        Me.txtPromotionName.Size = New System.Drawing.Size(195, 24)
        Me.txtPromotionName.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Start Date:*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "End Date:*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(40, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Description:*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Promotion Name:*"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionIDDataGridViewTextBoxColumn, Me.campaign, Me.CampaignIDDataGridViewTextBoxColumn1, Me.TitleDataGridViewTextBoxColumn1, Me.DescriptionDataGridViewTextBoxColumn1, Me.StartDateDataGridViewTextBoxColumn1, Me.EndDateDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.PromotionsBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 257)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(916, 335)
        Me.DataGridView2.TabIndex = 0
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.GEDataSet
        '
        'tabDiscounts
        '
        Me.tabDiscounts.Controls.Add(Me.lblGetOne)
        Me.tabDiscounts.Controls.Add(Me.txtGetOne)
        Me.tabDiscounts.Controls.Add(Me.Label15)
        Me.tabDiscounts.Controls.Add(Me.cmbPromo)
        Me.tabDiscounts.Controls.Add(Me.Button1)
        Me.tabDiscounts.Controls.Add(Me.Label14)
        Me.tabDiscounts.Controls.Add(Me.cmbDiscountType)
        Me.tabDiscounts.Controls.Add(Me.txtBuyOne)
        Me.tabDiscounts.Controls.Add(Me.lblBuyOne)
        Me.tabDiscounts.Controls.Add(Me.lblFlatDiscount)
        Me.tabDiscounts.Controls.Add(Me.txtFlatDiscount)
        Me.tabDiscounts.Controls.Add(Me.lblPercentageDiscount)
        Me.tabDiscounts.Controls.Add(Me.txtPercentage)
        Me.tabDiscounts.Controls.Add(Me.DataGridView3)
        Me.tabDiscounts.Location = New System.Drawing.Point(4, 27)
        Me.tabDiscounts.Name = "tabDiscounts"
        Me.tabDiscounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDiscounts.Size = New System.Drawing.Size(916, 579)
        Me.tabDiscounts.TabIndex = 2
        Me.tabDiscounts.Text = "Discounts"
        Me.tabDiscounts.UseVisualStyleBackColor = True
        '
        'lblGetOne
        '
        Me.lblGetOne.AutoSize = True
        Me.lblGetOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblGetOne.Location = New System.Drawing.Point(212, 135)
        Me.lblGetOne.Name = "lblGetOne"
        Me.lblGetOne.Size = New System.Drawing.Size(91, 16)
        Me.lblGetOne.TabIndex = 62
        Me.lblGetOne.Text = "Get this many:"
        '
        'txtGetOne
        '
        Me.txtGetOne.Location = New System.Drawing.Point(309, 131)
        Me.txtGetOne.Name = "txtGetOne"
        Me.txtGetOne.Size = New System.Drawing.Size(67, 24)
        Me.txtGetOne.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label15.Location = New System.Drawing.Point(49, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 16)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Promotion"
        '
        'cmbPromo
        '
        Me.cmbPromo.DataSource = Me.PromotionsBindingSource
        Me.cmbPromo.DisplayMember = "title"
        Me.cmbPromo.FormattingEnabled = True
        Me.cmbPromo.Location = New System.Drawing.Point(139, 62)
        Me.cmbPromo.Name = "cmbPromo"
        Me.cmbPromo.Size = New System.Drawing.Size(195, 26)
        Me.cmbPromo.TabIndex = 59
        Me.cmbPromo.ValueMember = "promotionID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Button1.Location = New System.Drawing.Point(66, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(268, 45)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Add Discount"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label14.Location = New System.Drawing.Point(27, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Discount Type"
        '
        'cmbDiscountType
        '
        Me.cmbDiscountType.DataSource = Me.DiscountTypeBindingSource
        Me.cmbDiscountType.DisplayMember = "discountType"
        Me.cmbDiscountType.FormattingEnabled = True
        Me.cmbDiscountType.Location = New System.Drawing.Point(139, 99)
        Me.cmbDiscountType.Name = "cmbDiscountType"
        Me.cmbDiscountType.Size = New System.Drawing.Size(195, 26)
        Me.cmbDiscountType.TabIndex = 56
        Me.cmbDiscountType.ValueMember = "discountTypeID"
        '
        'DiscountTypeBindingSource
        '
        Me.DiscountTypeBindingSource.DataMember = "Discount_Type"
        Me.DiscountTypeBindingSource.DataSource = Me.GEDataSet
        '
        'txtBuyOne
        '
        Me.txtBuyOne.Location = New System.Drawing.Point(139, 131)
        Me.txtBuyOne.Name = "txtBuyOne"
        Me.txtBuyOne.Size = New System.Drawing.Size(67, 24)
        Me.txtBuyOne.TabIndex = 49
        '
        'lblBuyOne
        '
        Me.lblBuyOne.AutoSize = True
        Me.lblBuyOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblBuyOne.Location = New System.Drawing.Point(34, 135)
        Me.lblBuyOne.Name = "lblBuyOne"
        Me.lblBuyOne.Size = New System.Drawing.Size(93, 16)
        Me.lblBuyOne.TabIndex = 48
        Me.lblBuyOne.Text = "Buy this many:"
        '
        'lblFlatDiscount
        '
        Me.lblFlatDiscount.AutoSize = True
        Me.lblFlatDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblFlatDiscount.Location = New System.Drawing.Point(34, 135)
        Me.lblFlatDiscount.Name = "lblFlatDiscount"
        Me.lblFlatDiscount.Size = New System.Drawing.Size(88, 16)
        Me.lblFlatDiscount.TabIndex = 50
        Me.lblFlatDiscount.Text = "Flat Discount:"
        Me.lblFlatDiscount.Visible = False
        '
        'txtFlatDiscount
        '
        Me.txtFlatDiscount.Location = New System.Drawing.Point(139, 131)
        Me.txtFlatDiscount.Name = "txtFlatDiscount"
        Me.txtFlatDiscount.Size = New System.Drawing.Size(195, 24)
        Me.txtFlatDiscount.TabIndex = 51
        Me.txtFlatDiscount.Visible = False
        '
        'lblPercentageDiscount
        '
        Me.lblPercentageDiscount.AutoSize = True
        Me.lblPercentageDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblPercentageDiscount.Location = New System.Drawing.Point(34, 135)
        Me.lblPercentageDiscount.Name = "lblPercentageDiscount"
        Me.lblPercentageDiscount.Size = New System.Drawing.Size(81, 16)
        Me.lblPercentageDiscount.TabIndex = 52
        Me.lblPercentageDiscount.Text = "Percentage:"
        Me.lblPercentageDiscount.Visible = False
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(139, 131)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(195, 24)
        Me.txtPercentage.TabIndex = 53
        Me.txtPercentage.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiscountIDDataGridViewTextBoxColumn, Me.Column1, Me.DiscountTypeIDDataGridViewTextBoxColumn, Me.BuyOneDataGridViewTextBoxColumn, Me.GetOneDataGridViewTextBoxColumn, Me.DiscountAmountDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.DiscountsBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(0, 257)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(916, 324)
        Me.DataGridView3.TabIndex = 0
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
        'Discount_TypeTableAdapter
        '
        Me.Discount_TypeTableAdapter.ClearBeforeFill = True
        '
        'CampaignTypesBindingSource1
        '
        Me.CampaignTypesBindingSource1.DataMember = "Campaign_Types"
        Me.CampaignTypesBindingSource1.DataSource = Me.GEDataSet
        '
        'CampaignIDDataGridViewTextBoxColumn
        '
        Me.CampaignIDDataGridViewTextBoxColumn.DataPropertyName = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.CampaignIDDataGridViewTextBoxColumn.Name = "CampaignIDDataGridViewTextBoxColumn"
        Me.CampaignIDDataGridViewTextBoxColumn.Width = 45
        '
        'CampaignTypeIDDataGridViewTextBoxColumn
        '
        Me.CampaignTypeIDDataGridViewTextBoxColumn.DataPropertyName = "campaignTypeID"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.HeaderText = "campaignTypeID"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.Name = "CampaignTypeIDDataGridViewTextBoxColumn"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'CampaignTypeID
        '
        Me.CampaignTypeID.DataPropertyName = "campaignTypeID"
        Me.CampaignTypeID.DataSource = Me.CampaignTypesBindingSource1
        Me.CampaignTypeID.DisplayMember = "title"
        Me.CampaignTypeID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CampaignTypeID.HeaderText = "Type"
        Me.CampaignTypeID.Name = "CampaignTypeID"
        Me.CampaignTypeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CampaignTypeID.ValueMember = "campaignTypeID"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'StartDateDataGridViewTextBoxColumn
        '
        Me.StartDateDataGridViewTextBoxColumn.DataPropertyName = "startDate"
        Me.StartDateDataGridViewTextBoxColumn.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn.Name = "StartDateDataGridViewTextBoxColumn"
        '
        'EndDateDataGridViewTextBoxColumn
        '
        Me.EndDateDataGridViewTextBoxColumn.DataPropertyName = "endDate"
        Me.EndDateDataGridViewTextBoxColumn.HeaderText = "End Date"
        Me.EndDateDataGridViewTextBoxColumn.Name = "EndDateDataGridViewTextBoxColumn"
        '
        'MarketingCampaignsBindingSource1
        '
        Me.MarketingCampaignsBindingSource1.DataMember = "Marketing_Campaigns"
        Me.MarketingCampaignsBindingSource1.DataSource = Me.GEDataSet
        '
        'DiscountTypeBindingSource1
        '
        Me.DiscountTypeBindingSource1.DataMember = "Discount_Type"
        Me.DiscountTypeBindingSource1.DataSource = Me.GEDataSet
        '
        'DiscountIDDataGridViewTextBoxColumn
        '
        Me.DiscountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.DiscountIDDataGridViewTextBoxColumn.Name = "DiscountIDDataGridViewTextBoxColumn"
        Me.DiscountIDDataGridViewTextBoxColumn.Width = 45
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "discountTypeID"
        Me.Column1.DataSource = Me.DiscountTypeBindingSource1
        Me.Column1.DisplayMember = "discountType"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ValueMember = "discountTypeID"
        '
        'DiscountTypeIDDataGridViewTextBoxColumn
        '
        Me.DiscountTypeIDDataGridViewTextBoxColumn.DataPropertyName = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.HeaderText = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Name = "DiscountTypeIDDataGridViewTextBoxColumn"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Visible = False
        '
        'BuyOneDataGridViewTextBoxColumn
        '
        Me.BuyOneDataGridViewTextBoxColumn.DataPropertyName = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.HeaderText = "Buy One"
        Me.BuyOneDataGridViewTextBoxColumn.Name = "BuyOneDataGridViewTextBoxColumn"
        '
        'GetOneDataGridViewTextBoxColumn
        '
        Me.GetOneDataGridViewTextBoxColumn.DataPropertyName = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.HeaderText = "Get One"
        Me.GetOneDataGridViewTextBoxColumn.Name = "GetOneDataGridViewTextBoxColumn"
        '
        'DiscountAmountDataGridViewTextBoxColumn
        '
        Me.DiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.DiscountAmountDataGridViewTextBoxColumn.Name = "DiscountAmountDataGridViewTextBoxColumn"
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        Me.PromotionIDDataGridViewTextBoxColumn.Width = 45
        '
        'campaign
        '
        Me.campaign.DataPropertyName = "campaignID"
        Me.campaign.DataSource = Me.MarketingCampaignsBindingSource1
        Me.campaign.DisplayMember = "title"
        Me.campaign.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.campaign.HeaderText = "Campaign"
        Me.campaign.Name = "campaign"
        Me.campaign.ValueMember = "campaignID"
        Me.campaign.Width = 200
        '
        'CampaignIDDataGridViewTextBoxColumn1
        '
        Me.CampaignIDDataGridViewTextBoxColumn1.DataPropertyName = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn1.HeaderText = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn1.Name = "CampaignIDDataGridViewTextBoxColumn1"
        Me.CampaignIDDataGridViewTextBoxColumn1.Visible = False
        '
        'TitleDataGridViewTextBoxColumn1
        '
        Me.TitleDataGridViewTextBoxColumn1.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn1.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn1.Name = "TitleDataGridViewTextBoxColumn1"
        Me.TitleDataGridViewTextBoxColumn1.Width = 200
        '
        'DescriptionDataGridViewTextBoxColumn1
        '
        Me.DescriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionDataGridViewTextBoxColumn1.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn1.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn1.Name = "DescriptionDataGridViewTextBoxColumn1"
        '
        'StartDateDataGridViewTextBoxColumn1
        '
        Me.StartDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate"
        Me.StartDateDataGridViewTextBoxColumn1.HeaderText = "Start Date"
        Me.StartDateDataGridViewTextBoxColumn1.Name = "StartDateDataGridViewTextBoxColumn1"
        '
        'EndDateDataGridViewTextBoxColumn1
        '
        Me.EndDateDataGridViewTextBoxColumn1.DataPropertyName = "endDate"
        Me.EndDateDataGridViewTextBoxColumn1.HeaderText = "End Date"
        Me.EndDateDataGridViewTextBoxColumn1.Name = "EndDateDataGridViewTextBoxColumn1"
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
        Me.tabPromotions.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDiscounts.ResumeLayout(False)
        Me.tabDiscounts.PerformLayout()
        CType(Me.DiscountTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampaignTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketingCampaignsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents PromoInfoIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DiscountsBindingSource As BindingSource
    Friend WithEvents DiscountsTableAdapter As GEDataSetTableAdapters.DiscountsTableAdapter
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
    Friend WithEvents promoEDate As DateTimePicker
    Friend WithEvents promoSDate As DateTimePicker
    Friend WithEvents txtPromoDesc As TextBox
    Friend WithEvents txtPromotionName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnAddPromotion As Button
    Friend WithEvents cmbCampPicker As ComboBox
    Friend WithEvents chkCampAssociation As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbDiscountType As ComboBox
    Friend WithEvents txtBuyOne As TextBox
    Friend WithEvents lblBuyOne As Label
    Friend WithEvents lblFlatDiscount As Label
    Friend WithEvents txtFlatDiscount As TextBox
    Friend WithEvents lblPercentageDiscount As Label
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents DiscountTypeBindingSource As BindingSource
    Friend WithEvents Discount_TypeTableAdapter As GEDataSetTableAdapters.Discount_TypeTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbPromo As ComboBox
    Friend WithEvents lblGetOne As Label
    Friend WithEvents txtGetOne As TextBox
    Friend WithEvents CampaignTypesBindingSource1 As BindingSource
    Friend WithEvents CampaignIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampaignTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampaignTypeID As DataGridViewComboBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarketingCampaignsBindingSource1 As BindingSource
    Friend WithEvents DiscountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents DiscountTypeBindingSource1 As BindingSource
    Friend WithEvents DiscountTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GetOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents campaign As DataGridViewComboBoxColumn
    Friend WithEvents CampaignIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
