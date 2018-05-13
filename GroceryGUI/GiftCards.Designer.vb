<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGiftCards
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
        Me.dgvGiftCards = New System.Windows.Forms.DataGridView()
        Me.GiftCardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGiftCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Gift_CardsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Gift_CardsTableAdapter()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GiftCardIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CustomerLastName = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvGiftCards, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GiftCardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGiftCards
        '
        Me.dgvGiftCards.AllowUserToAddRows = False
        Me.dgvGiftCards.AllowUserToDeleteRows = False
        Me.dgvGiftCards.AutoGenerateColumns = False
        Me.dgvGiftCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGiftCards.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GiftCardIDDataGridViewTextBoxColumn, Me.CustomerFirstName, Me.CustomerLastName, Me.CustomerIDDataGridViewTextBoxColumn, Me.DateOfPurchaseDataGridViewTextBoxColumn, Me.CardTotalDataGridViewTextBoxColumn, Me.btnAdd})
        Me.dgvGiftCards.DataSource = Me.GiftCardsBindingSource
        Me.dgvGiftCards.Location = New System.Drawing.Point(12, 27)
        Me.dgvGiftCards.Name = "dgvGiftCards"
        Me.dgvGiftCards.ReadOnly = True
        Me.dgvGiftCards.RowHeadersVisible = False
        Me.dgvGiftCards.Size = New System.Drawing.Size(602, 333)
        Me.dgvGiftCards.TabIndex = 0
        '
        'GiftCardsBindingSource
        '
        Me.GiftCardsBindingSource.DataMember = "Gift_Cards"
        Me.GiftCardsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.NewGiftCardToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(614, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewGiftCardToolStripMenuItem
        '
        Me.NewGiftCardToolStripMenuItem.Name = "NewGiftCardToolStripMenuItem"
        Me.NewGiftCardToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.NewGiftCardToolStripMenuItem.Text = "New Gift Card"
        '
        'Gift_CardsTableAdapter
        '
        Me.Gift_CardsTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.GEDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.GEDataSet
        '
        'GiftCardIDDataGridViewTextBoxColumn
        '
        Me.GiftCardIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.GiftCardIDDataGridViewTextBoxColumn.DataPropertyName = "giftCardID"
        Me.GiftCardIDDataGridViewTextBoxColumn.HeaderText = "Gift Card ID"
        Me.GiftCardIDDataGridViewTextBoxColumn.Name = "GiftCardIDDataGridViewTextBoxColumn"
        Me.GiftCardIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.GiftCardIDDataGridViewTextBoxColumn.Width = 87
        '
        'CustomerFirstName
        '
        Me.CustomerFirstName.DataPropertyName = "customerID"
        Me.CustomerFirstName.DataSource = Me.CustomersBindingSource
        Me.CustomerFirstName.DisplayMember = "firstName"
        Me.CustomerFirstName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CustomerFirstName.HeaderText = "First Name"
        Me.CustomerFirstName.Name = "CustomerFirstName"
        Me.CustomerFirstName.ReadOnly = True
        Me.CustomerFirstName.ValueMember = "customerID"
        '
        'CustomerLastName
        '
        Me.CustomerLastName.DataPropertyName = "customerID"
        Me.CustomerLastName.DataSource = Me.CustomersBindingSource1
        Me.CustomerLastName.DisplayMember = "lastName"
        Me.CustomerLastName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.CustomerLastName.HeaderText = "Last Name"
        Me.CustomerLastName.Name = "CustomerLastName"
        Me.CustomerLastName.ReadOnly = True
        Me.CustomerLastName.ValueMember = "customerID"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 90
        '
        'DateOfPurchaseDataGridViewTextBoxColumn
        '
        Me.DateOfPurchaseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "dateOfPurchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "Date Of Purchase"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Name = "DateOfPurchaseDataGridViewTextBoxColumn"
        Me.DateOfPurchaseDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfPurchaseDataGridViewTextBoxColumn.Width = 107
        '
        'CardTotalDataGridViewTextBoxColumn
        '
        Me.CardTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CardTotalDataGridViewTextBoxColumn.DataPropertyName = "cardTotal"
        Me.CardTotalDataGridViewTextBoxColumn.HeaderText = "Card Total"
        Me.CardTotalDataGridViewTextBoxColumn.Name = "CardTotalDataGridViewTextBoxColumn"
        Me.CardTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.CardTotalDataGridViewTextBoxColumn.Width = 75
        '
        'btnAdd
        '
        Me.btnAdd.HeaderText = ""
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ReadOnly = True
        Me.btnAdd.Text = "Refill"
        Me.btnAdd.UseColumnTextForButtonValue = True
        Me.btnAdd.Width = 61
        '
        'frmGiftCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 367)
        Me.Controls.Add(Me.dgvGiftCards)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmGiftCards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gift Cards"
        CType(Me.dgvGiftCards, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GiftCardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGiftCards As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents GiftCardsBindingSource As BindingSource
    Friend WithEvents Gift_CardsTableAdapter As GEDataSetTableAdapters.Gift_CardsTableAdapter
    Friend WithEvents NewGiftCardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents GiftCardIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstName As DataGridViewComboBoxColumn
    Friend WithEvents CustomerLastName As DataGridViewComboBoxColumn
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchaseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CardTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As DataGridViewButtonColumn
End Class
