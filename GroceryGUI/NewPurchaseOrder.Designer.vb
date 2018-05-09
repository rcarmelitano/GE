<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPurchaseOrder
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
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtPurchaseOrderID = New System.Windows.Forms.TextBox()
        Me.txtOrderTotal = New System.Windows.Forms.TextBox()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbStatusID = New System.Windows.Forms.ComboBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.SuppliersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.SuppliersTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(152, 374)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.MaxDate = New Date(2710, 12, 23, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(265, 22)
        Me.dtpDate.TabIndex = 0
        Me.dtpDate.Value = New Date(2018, 5, 8, 0, 0, 0, 0)
        '
        'txtPurchaseOrderID
        '
        Me.txtPurchaseOrderID.Enabled = False
        Me.txtPurchaseOrderID.Location = New System.Drawing.Point(152, 48)
        Me.txtPurchaseOrderID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPurchaseOrderID.Name = "txtPurchaseOrderID"
        Me.txtPurchaseOrderID.ReadOnly = True
        Me.txtPurchaseOrderID.Size = New System.Drawing.Size(132, 22)
        Me.txtPurchaseOrderID.TabIndex = 1
        '
        'txtOrderTotal
        '
        Me.txtOrderTotal.Enabled = False
        Me.txtOrderTotal.Location = New System.Drawing.Point(152, 331)
        Me.txtOrderTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrderTotal.Name = "txtOrderTotal"
        Me.txtOrderTotal.ReadOnly = True
        Me.txtOrderTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtOrderTotal.TabIndex = 3
        Me.txtOrderTotal.Text = "0.00"
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Enabled = False
        Me.txtSupplierID.Location = New System.Drawing.Point(152, 145)
        Me.txtSupplierID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(132, 22)
        Me.txtSupplierID.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Purchase Order ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Supplier ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 335)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Order Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Status ID:"
        '
        'cmbStatusID
        '
        Me.cmbStatusID.Enabled = False
        Me.cmbStatusID.FormattingEnabled = True
        Me.cmbStatusID.Items.AddRange(New Object() {"Order Placed", "Received", "Complete"})
        Me.cmbStatusID.Location = New System.Drawing.Point(152, 96)
        Me.cmbStatusID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatusID.Name = "cmbStatusID"
        Me.cmbStatusID.Size = New System.Drawing.Size(160, 24)
        Me.cmbStatusID.TabIndex = 9
        Me.cmbStatusID.Text = "Order Placed"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(89, 448)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(296, 48)
        Me.btnContinue.TabIndex = 10
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.btnAdd})
        Me.DataGridView1.DataSource = Me.SuppliersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 177)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(377, 144)
        Me.DataGridView1.TabIndex = 11
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "supplierName"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnAdd
        '
        Me.btnAdd.HeaderText = ""
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.ReadOnly = True
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseColumnTextForButtonValue = True
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 374)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Date:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(439, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'NewPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 506)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.cmbStatusID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.txtOrderTotal)
        Me.Controls.Add(Me.txtPurchaseOrderID)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewPurchaseOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewPurchaseOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtPurchaseOrderID As TextBox
    Friend WithEvents txtOrderTotal As TextBox
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbStatusID As ComboBox
    Friend WithEvents btnContinue As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As GEDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As DataGridViewButtonColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
