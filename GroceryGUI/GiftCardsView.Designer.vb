<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiftCardsView
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.GiftCardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gift_CardsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Gift_CardsTableAdapter()
        Me.GiftCardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GiftCardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GiftCardIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.DateOfPurchaseDataGridViewTextBoxColumn, Me.CardTotalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GiftCardsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(397, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(413, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GiftCardsBindingSource
        '
        Me.GiftCardsBindingSource.DataMember = "Gift_Cards"
        Me.GiftCardsBindingSource.DataSource = Me.GEDataSet
        '
        'Gift_CardsTableAdapter
        '
        Me.Gift_CardsTableAdapter.ClearBeforeFill = True
        '
        'GiftCardIDDataGridViewTextBoxColumn
        '
        Me.GiftCardIDDataGridViewTextBoxColumn.DataPropertyName = "giftCardID"
        Me.GiftCardIDDataGridViewTextBoxColumn.HeaderText = "giftCardID"
        Me.GiftCardIDDataGridViewTextBoxColumn.Name = "GiftCardIDDataGridViewTextBoxColumn"
        Me.GiftCardIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.GiftCardIDDataGridViewTextBoxColumn.Width = 79
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 86
        '
        'DateOfPurchaseDataGridViewTextBoxColumn
        '
        Me.DateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "dateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "dateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Name = "DateOfPurchaseDataGridViewTextBoxColumn"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Width = 109
        '
        'CardTotalDataGridViewTextBoxColumn
        '
        Me.CardTotalDataGridViewTextBoxColumn.DataPropertyName = "cardTotal"
        Me.CardTotalDataGridViewTextBoxColumn.HeaderText = "cardTotal"
        Me.CardTotalDataGridViewTextBoxColumn.Name = "CardTotalDataGridViewTextBoxColumn"
        Me.CardTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardTotalDataGridViewTextBoxColumn.Width = 77
        '
        'frmGiftCardsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 318)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmGiftCardsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Gift Cards"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GiftCardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents DiscountsBindingSource As BindingSource
    Friend WithEvents DiscountsTableAdapter As GEDataSetTableAdapters.DiscountsTableAdapter
    Friend WithEvents GiftCardsBindingSource As BindingSource
    Friend WithEvents Gift_CardsTableAdapter As GEDataSetTableAdapters.Gift_CardsTableAdapter
    Friend WithEvents GiftCardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
