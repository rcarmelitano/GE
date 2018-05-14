<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport9
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sales_per_locationTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter()
        Me.GEStoredProcedures = New GroceryGUI.GEStoredProcedures()
        Me.GEStoredProceduresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesperlocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.dgvReport14 = New System.Windows.Forms.DataGridView()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOPTENPRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOP_TEN_PRODUCTSTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.TOP_TEN_PRODUCTSTableAdapter()
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOPTENPRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(232, 45)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 23)
        Me.btnDisplay.TabIndex = 10
        Me.btnDisplay.Text = "Display Report"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter a year:"
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
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(126, 47)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 9
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
        Me.MenuStrip1.Size = New System.Drawing.Size(429, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'dgvReport14
        '
        Me.dgvReport14.AllowUserToAddRows = False
        Me.dgvReport14.AllowUserToDeleteRows = False
        Me.dgvReport14.AutoGenerateColumns = False
        Me.dgvReport14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport14.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.RevenueDataGridViewTextBoxColumn})
        Me.dgvReport14.DataSource = Me.TOPTENPRODUCTSBindingSource
        Me.dgvReport14.Location = New System.Drawing.Point(12, 86)
        Me.dgvReport14.Name = "dgvReport14"
        Me.dgvReport14.ReadOnly = True
        Me.dgvReport14.RowHeadersVisible = False
        Me.dgvReport14.Size = New System.Drawing.Size(406, 281)
        Me.dgvReport14.TabIndex = 7
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
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RevenueDataGridViewTextBoxColumn
        '
        Me.RevenueDataGridViewTextBoxColumn.DataPropertyName = "Revenue"
        Me.RevenueDataGridViewTextBoxColumn.HeaderText = "Revenue"
        Me.RevenueDataGridViewTextBoxColumn.Name = "RevenueDataGridViewTextBoxColumn"
        Me.RevenueDataGridViewTextBoxColumn.ReadOnly = True
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
        'frmReport9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 379)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvReport14)
        Me.Name = "frmReport9"
        Me.Text = "Report 9 - Top Ten Selling Products"
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtYear As TextBox
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents dgvReport14 As DataGridView
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RevenueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOPTENPRODUCTSBindingSource As BindingSource
    Friend WithEvents TOP_TEN_PRODUCTSTableAdapter As GEStoredProceduresTableAdapters.TOP_TEN_PRODUCTSTableAdapter
End Class
