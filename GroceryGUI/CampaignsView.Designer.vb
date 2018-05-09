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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarketingCampaignsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CampaignIDDataGridViewTextBoxColumn, Me.CampaignTypeIDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.StartDateDataGridViewTextBoxColumn, Me.EndDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MarketingCampaignsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1065, 527)
        Me.DataGridView1.TabIndex = 0
        '
        'CampaignIDDataGridViewTextBoxColumn
        '
        Me.CampaignIDDataGridViewTextBoxColumn.DataPropertyName = "campaignID"
        Me.CampaignIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.CampaignIDDataGridViewTextBoxColumn.Name = "CampaignIDDataGridViewTextBoxColumn"
        Me.CampaignIDDataGridViewTextBoxColumn.Width = 50
        '
        'CampaignTypeIDDataGridViewTextBoxColumn
        '
        Me.CampaignTypeIDDataGridViewTextBoxColumn.DataPropertyName = "campaignTypeID"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.HeaderText = "Type ID"
        Me.CampaignTypeIDDataGridViewTextBoxColumn.Name = "CampaignTypeIDDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 150
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1067, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'CampaignsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CampaignsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CampaignsView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarketingCampaignsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents MarketingCampaignsBindingSource As BindingSource
    Friend WithEvents Marketing_CampaignsTableAdapter As GEDataSetTableAdapters.Marketing_CampaignsTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CampaignIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CampaignTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
