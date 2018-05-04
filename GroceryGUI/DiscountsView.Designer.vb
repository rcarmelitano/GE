<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscountsView
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
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.DiscountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetOneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(548, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiscountIDDataGridViewTextBoxColumn, Me.DiscountTypeIDDataGridViewTextBoxColumn, Me.BuyOneDataGridViewTextBoxColumn, Me.GetOneDataGridViewTextBoxColumn, Me.DiscountAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DiscountsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(523, 279)
        Me.DataGridView1.TabIndex = 1
        '
        'DiscountsBindingSource
        '
        Me.DiscountsBindingSource.DataMember = "Discounts"
        Me.DiscountsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiscountsTableAdapter
        '
        Me.DiscountsTableAdapter.ClearBeforeFill = True
        '
        'DiscountIDDataGridViewTextBoxColumn
        '
        Me.DiscountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.HeaderText = "Discount ID"
        Me.DiscountIDDataGridViewTextBoxColumn.Name = "DiscountIDDataGridViewTextBoxColumn"
        Me.DiscountIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscountTypeIDDataGridViewTextBoxColumn
        '
        Me.DiscountTypeIDDataGridViewTextBoxColumn.DataPropertyName = "discountTypeID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.HeaderText = "Discount Type ID"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.Name = "DiscountTypeIDDataGridViewTextBoxColumn"
        Me.DiscountTypeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuyOneDataGridViewTextBoxColumn
        '
        Me.BuyOneDataGridViewTextBoxColumn.DataPropertyName = "buyOne"
        Me.BuyOneDataGridViewTextBoxColumn.HeaderText = "Buy One"
        Me.BuyOneDataGridViewTextBoxColumn.Name = "BuyOneDataGridViewTextBoxColumn"
        Me.BuyOneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GetOneDataGridViewTextBoxColumn
        '
        Me.GetOneDataGridViewTextBoxColumn.DataPropertyName = "getOne"
        Me.GetOneDataGridViewTextBoxColumn.HeaderText = "Get One"
        Me.GetOneDataGridViewTextBoxColumn.Name = "GetOneDataGridViewTextBoxColumn"
        Me.GetOneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscountAmountDataGridViewTextBoxColumn
        '
        Me.DiscountAmountDataGridViewTextBoxColumn.DataPropertyName = "discountAmount"
        Me.DiscountAmountDataGridViewTextBoxColumn.HeaderText = "Discount Amount"
        Me.DiscountAmountDataGridViewTextBoxColumn.Name = "DiscountAmountDataGridViewTextBoxColumn"
        Me.DiscountAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmDiscountsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 318)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmDiscountsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of Discounts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents DiscountsBindingSource As BindingSource
    Friend WithEvents DiscountsTableAdapter As GEDataSetTableAdapters.DiscountsTableAdapter
    Friend WithEvents DiscountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BuyOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GetOneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
