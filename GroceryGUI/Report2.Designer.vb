<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport2
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sales_per_locationTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter()
        Me.GEStoredProcedures = New GroceryGUI.GEStoredProcedures()
        Me.GEStoredProceduresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesperlocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dgvReport14 = New System.Windows.Forms.DataGridView()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpInventoryOnHandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOPTENPRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOP_TEN_PRODUCTSTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.TOP_TEN_PRODUCTSTableAdapter()
        Me.SpInventoryOnHandTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.spInventoryOnHandTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpInventoryOnHandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOPTENPRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(86, 88)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 35)
        Me.btnDisplay.TabIndex = 15
        Me.btnDisplay.Text = "Search by Category"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Enter a category ID:"
        '
        'Sales_per_locationTableAdapter
        '
        Me.Sales_per_locationTableAdapter.ClearBeforeFill = True
        '
        'GEStoredProcedures
        '
        Me.GEStoredProcedures.DataSetName = "GEStoredProcedures"
        Me.GEStoredProcedures.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GEStoredProceduresBindingSource
        '
        Me.GEStoredProceduresBindingSource.DataSource = Me.GEStoredProcedures
        Me.GEStoredProceduresBindingSource.Position = 0
        '
        'SalesperlocationBindingSource
        '
        Me.SalesperlocationBindingSource.DataMember = "Sales_per_location"
        Me.SalesperlocationBindingSource.DataSource = Me.GEStoredProceduresBindingSource
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Location = New System.Drawing.Point(147, 49)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.Size = New System.Drawing.Size(100, 20)
        Me.txtCategoryID.TabIndex = 14
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(44, 20)
        Me.mnuBack.Text = "Back"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(597, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'dgvReport14
        '
        Me.dgvReport14.AllowUserToAddRows = False
        Me.dgvReport14.AllowUserToDeleteRows = False
        Me.dgvReport14.AutoGenerateColumns = False
        Me.dgvReport14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport14.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn})
        Me.dgvReport14.DataSource = Me.SpInventoryOnHandBindingSource
        Me.dgvReport14.Location = New System.Drawing.Point(75, 152)
        Me.dgvReport14.Name = "dgvReport14"
        Me.dgvReport14.ReadOnly = True
        Me.dgvReport14.RowHeadersVisible = False
        Me.dgvReport14.Size = New System.Drawing.Size(406, 281)
        Me.dgvReport14.TabIndex = 12
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "productName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpInventoryOnHandBindingSource
        '
        Me.SpInventoryOnHandBindingSource.DataMember = "spInventoryOnHand"
        Me.SpInventoryOnHandBindingSource.DataSource = Me.GEStoredProceduresBindingSource
        '
        'TOPTENPRODUCTSBindingSource
        '
        Me.TOPTENPRODUCTSBindingSource.DataMember = "TOP_TEN_PRODUCTS"
        Me.TOPTENPRODUCTSBindingSource.DataSource = Me.GEStoredProceduresBindingSource
        '
        'TOP_TEN_PRODUCTSTableAdapter
        '
        Me.TOP_TEN_PRODUCTSTableAdapter.ClearBeforeFill = True
        '
        'SpInventoryOnHandTableAdapter
        '
        Me.SpInventoryOnHandTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(341, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Search by Department"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Enter a department ID:"
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(414, 49)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartmentID.TabIndex = 17
        '
        'frmReport2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 502)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCategoryID)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvReport14)
        Me.Name = "frmReport2"
        Me.Text = "Report2"
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpInventoryOnHandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOPTENPRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Sales_per_locationTableAdapter As GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter
    Friend WithEvents GEStoredProcedures As GEStoredProcedures
    Friend WithEvents GEStoredProceduresBindingSource As BindingSource
    Friend WithEvents SalesperlocationBindingSource As BindingSource
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents dgvReport14 As DataGridView
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOPTENPRODUCTSBindingSource As BindingSource
    Friend WithEvents TOP_TEN_PRODUCTSTableAdapter As GEStoredProceduresTableAdapters.TOP_TEN_PRODUCTSTableAdapter
    Friend WithEvents SpInventoryOnHandBindingSource As BindingSource
    Friend WithEvents SpInventoryOnHandTableAdapter As GEStoredProceduresTableAdapters.spInventoryOnHandTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDepartmentID As TextBox
End Class
