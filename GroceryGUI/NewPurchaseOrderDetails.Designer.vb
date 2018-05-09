﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPurchaseOrderDetails
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
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.btnPlacePurchaseOrder = New System.Windows.Forms.Button()
        Me.cmbStatusID = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.txtPurchaseOrderID = New System.Windows.Forms.TextBox()
        Me.ProductsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.ProductsTableAdapter()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOrderDetailID = New System.Windows.Forms.TextBox()
        Me.txtSKU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUnitOfPurchase = New System.Windows.Forms.TextBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.AutoGenerateColumns = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.RetailUnitDataGridViewTextBoxColumn, Me.RetailCostDataGridViewTextBoxColumn, Me.btnAdd})
        Me.dgvProducts.DataSource = Me.ProductsBindingSource
        Me.dgvProducts.Location = New System.Drawing.Point(16, 255)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.RowHeadersVisible = False
        Me.dgvProducts.Size = New System.Drawing.Size(676, 191)
        Me.dgvProducts.TabIndex = 23
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RetailUnitDataGridViewTextBoxColumn
        '
        Me.RetailUnitDataGridViewTextBoxColumn.DataPropertyName = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.HeaderText = "retailUnit"
        Me.RetailUnitDataGridViewTextBoxColumn.Name = "RetailUnitDataGridViewTextBoxColumn"
        Me.RetailUnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RetailCostDataGridViewTextBoxColumn
        '
        Me.RetailCostDataGridViewTextBoxColumn.DataPropertyName = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.HeaderText = "retailCost"
        Me.RetailCostDataGridViewTextBoxColumn.Name = "RetailCostDataGridViewTextBoxColumn"
        Me.RetailCostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnAdd
        '
        Me.btnAdd.HeaderText = ""
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ReadOnly = True
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseColumnTextForButtonValue = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnPlacePurchaseOrder
        '
        Me.btnPlacePurchaseOrder.Location = New System.Drawing.Point(212, 638)
        Me.btnPlacePurchaseOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPlacePurchaseOrder.Name = "btnPlacePurchaseOrder"
        Me.btnPlacePurchaseOrder.Size = New System.Drawing.Size(296, 48)
        Me.btnPlacePurchaseOrder.TabIndex = 22
        Me.btnPlacePurchaseOrder.Text = "Place Purchase Order"
        Me.btnPlacePurchaseOrder.UseVisualStyleBackColor = True
        '
        'cmbStatusID
        '
        Me.cmbStatusID.Enabled = False
        Me.cmbStatusID.FormattingEnabled = True
        Me.cmbStatusID.Items.AddRange(New Object() {"Order Placed", "Received", "Complete"})
        Me.cmbStatusID.Location = New System.Drawing.Point(323, 160)
        Me.cmbStatusID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbStatusID.Name = "cmbStatusID"
        Me.cmbStatusID.Size = New System.Drawing.Size(160, 24)
        Me.cmbStatusID.TabIndex = 21
        Me.cmbStatusID.Text = "Order Placed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Status ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 546)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Order Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Purchase Order ID:"
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Enabled = False
        Me.txtOrderTotal.Location = New System.Drawing.Point(323, 543)
        Me.txtOrderTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.ReadOnly = True
        Me.txtOrderTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtOrderTotal.TabIndex = 15
        Me.txtOrderTotal.Text = "0.00"
        '
        'txtPurchaseOrderID
        '
        Me.txtPurchaseOrderID.Enabled = False
        Me.txtPurchaseOrderID.Location = New System.Drawing.Point(323, 112)
        Me.txtPurchaseOrderID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchaseOrderID.Name = "txtPurchaseOrderID"
        Me.txtPurchaseOrderID.ReadOnly = True
        Me.txtPurchaseOrderID.Size = New System.Drawing.Size(132, 22)
        Me.txtPurchaseOrderID.TabIndex = 14
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(323, 453)
        Me.nupQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nupQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.ReadOnly = True
        Me.nupQuantity.Size = New System.Drawing.Size(160, 22)
        Me.nupQuantity.TabIndex = 24
        Me.nupQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 455)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Quantity:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Order Detail ID:"
        '
        'txtOrderDetailID
        '
        Me.txtOrderDetailID.Enabled = False
        Me.txtOrderDetailID.Location = New System.Drawing.Point(323, 64)
        Me.txtOrderDetailID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOrderDetailID.Name = "txtOrderDetailID"
        Me.txtOrderDetailID.ReadOnly = True
        Me.txtOrderDetailID.Size = New System.Drawing.Size(132, 22)
        Me.txtOrderDetailID.TabIndex = 26
        '
        'txtSKU
        '
        Me.txtSKU.Enabled = False
        Me.txtSKU.Location = New System.Drawing.Point(65, 223)
        Me.txtSKU.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.ReadOnly = True
        Me.txtSKU.Size = New System.Drawing.Size(161, 22)
        Me.txtSKU.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "SKU:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 500)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Unit of Purchase:"
        '
        'txtUnitOfPurchase
        '
        Me.txtUnitOfPurchase.Location = New System.Drawing.Point(323, 496)
        Me.txtUnitOfPurchase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnitOfPurchase.Name = "txtUnitOfPurchase"
        Me.txtUnitOfPurchase.Size = New System.Drawing.Size(132, 22)
        Me.txtUnitOfPurchase.TabIndex = 30
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(323, 593)
        Me.txtNote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(132, 22)
        Me.txtNote.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 593)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Notes:"
        '
        'NewPurchaseOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 700)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUnitOfPurchase)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSKU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOrderDetailID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nupQuantity)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.btnPlacePurchaseOrder)
        Me.Controls.Add(Me.cmbStatusID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrderTotal)
        Me.Controls.Add(Me.txtPurchaseOrderID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "NewPurchaseOrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPurchaseOrderDetails"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnPlacePurchaseOrder As Button
    Friend WithEvents cmbStatusID As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrderTotal As TextBox
    Friend WithEvents txtPurchaseOrderID As TextBox
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As GEDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents nupQuantity As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOrderDetailID As TextBox
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUnitOfPurchase As TextBox
    Friend WithEvents txtNote As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailUnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As DataGridViewButtonColumn
End Class
