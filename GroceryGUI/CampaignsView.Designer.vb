<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CampaignsView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CampaignIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampaignTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarketingCampaignsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.Marketing_CampaignsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Marketing_CampaignsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketingCampaignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CampaignIDDataGridViewTextBoxColumn, Me.CampaignTypeIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MarketingCampaignsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(799, 428)
        Me.DataGridView1.TabIndex = 0
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
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Marketing_CampaignsTableAdapter
        '
        Me.Marketing_CampaignsTableAdapter.ClearBeforeFill = True
        '
        'CampaignsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CampaignsView"
        Me.Text = "CampaignsView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketingCampaignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents MarketingCampaignsBindingSource As BindingSource
    Friend WithEvents Marketing_CampaignsTableAdapter As GEDataSetTableAdapters.Marketing_CampaignsTableAdapter
    Friend WithEvents CampaignIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampaignTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
