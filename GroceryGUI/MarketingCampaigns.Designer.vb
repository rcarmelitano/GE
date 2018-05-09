<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarketingCampaigns
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
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCampaignsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCampaignName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnAddPromotion = New System.Windows.Forms.Button()
        Me.CampaignTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Campaign_TypesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Campaign_TypesTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCampaignID = New System.Windows.Forms.TextBox()
        Me.startDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.endDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.comboCampType = New System.Windows.Forms.ComboBox()
        Me.CampaignTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CampaignTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CampaignTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ViewCampaignsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(424, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ViewCampaignsToolStripMenuItem
        '
        Me.ViewCampaignsToolStripMenuItem.Name = "ViewCampaignsToolStripMenuItem"
        Me.ViewCampaignsToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.ViewCampaignsToolStripMenuItem.Text = "View Campaigns"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(73, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Campaign Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(78, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Campaign Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(107, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(116, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Start Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(119, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "End Date:"
        '
        'txtCampaignName
        '
        Me.txtCampaignName.Location = New System.Drawing.Point(192, 62)
        Me.txtCampaignName.Name = "txtCampaignName"
        Me.txtCampaignName.Size = New System.Drawing.Size(195, 20)
        Me.txtCampaignName.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(192, 134)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(195, 20)
        Me.txtDescription.TabIndex = 8
        '
        'btnAddPromotion
        '
        Me.btnAddPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPromotion.Location = New System.Drawing.Point(81, 247)
        Me.btnAddPromotion.Name = "btnAddPromotion"
        Me.btnAddPromotion.Size = New System.Drawing.Size(268, 45)
        Me.btnAddPromotion.TabIndex = 11
        Me.btnAddPromotion.Text = "Add Campaign"
        Me.btnAddPromotion.UseVisualStyleBackColor = True
        '
        'CampaignTypesBindingSource
        '
        Me.CampaignTypesBindingSource.DataMember = "Campaign_Types"
        Me.CampaignTypesBindingSource.DataSource = Me.GEDataSetBindingSource
        '
        'GEDataSetBindingSource
        '
        Me.GEDataSetBindingSource.DataSource = Me.GEDataSet
        Me.GEDataSetBindingSource.Position = 0
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Campaign_TypesTableAdapter
        '
        Me.Campaign_TypesTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(94, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Campaign ID: "
        '
        'txtCampaignID
        '
        Me.txtCampaignID.Location = New System.Drawing.Point(192, 29)
        Me.txtCampaignID.Name = "txtCampaignID"
        Me.txtCampaignID.Size = New System.Drawing.Size(195, 20)
        Me.txtCampaignID.TabIndex = 22
        '
        'startDatePicker
        '
        Me.startDatePicker.CustomFormat = "mm/dd/yyyy"
        Me.startDatePicker.Location = New System.Drawing.Point(192, 171)
        Me.startDatePicker.Name = "startDatePicker"
        Me.startDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.startDatePicker.TabIndex = 23
        Me.startDatePicker.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'endDatePicker
        '
        Me.endDatePicker.CustomFormat = "mm/dd/yyyy"
        Me.endDatePicker.Location = New System.Drawing.Point(192, 203)
        Me.endDatePicker.Name = "endDatePicker"
        Me.endDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.endDatePicker.TabIndex = 24
        Me.endDatePicker.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'comboCampType
        '
        Me.comboCampType.DataSource = Me.CampaignTypesBindingSource1
        Me.comboCampType.DisplayMember = "title"
        Me.comboCampType.FormattingEnabled = True
        Me.comboCampType.Location = New System.Drawing.Point(192, 97)
        Me.comboCampType.Name = "comboCampType"
        Me.comboCampType.Size = New System.Drawing.Size(195, 21)
        Me.comboCampType.TabIndex = 26
        Me.comboCampType.ValueMember = "campaignTypeID"
        '
        'CampaignTypesBindingSource1
        '
        Me.CampaignTypesBindingSource1.DataMember = "Campaign_Types"
        Me.CampaignTypesBindingSource1.DataSource = Me.GEDataSetBindingSource
        '
        'MarketingCampaigns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 304)
        Me.Controls.Add(Me.comboCampType)
        Me.Controls.Add(Me.endDatePicker)
        Me.Controls.Add(Me.startDatePicker)
        Me.Controls.Add(Me.txtCampaignID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAddPromotion)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCampaignName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MarketingCampaigns"
        Me.Text = "Marketing Campaigns"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CampaignTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CampaignTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCampaignsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCampaignName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnAddPromotion As Button
    Friend WithEvents GEDataSetBindingSource As BindingSource
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CampaignTypesBindingSource As BindingSource
    Friend WithEvents Campaign_TypesTableAdapter As GEDataSetTableAdapters.Campaign_TypesTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCampaignID As TextBox
    Friend WithEvents startDatePicker As DateTimePicker
    Friend WithEvents endDatePicker As DateTimePicker
    Friend WithEvents comboCampType As ComboBox
    Friend WithEvents CampaignTypesBindingSource1 As BindingSource
End Class
