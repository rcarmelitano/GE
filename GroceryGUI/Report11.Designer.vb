<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport11
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
        Me.Sales_per_locationTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter()
        Me.GEStoredProcedures = New GroceryGUI.GEStoredProcedures()
        Me.GEStoredProceduresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesperlocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TOPTENPRODUCTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOP_TEN_PRODUCTSTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.TOP_TEN_PRODUCTSTableAdapter()
        Me.SALESCROSSTABBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALES_CROSSTABTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.SALES_CROSSTABTableAdapter()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvReport14 = New System.Windows.Forms.DataGridView()
        Me.JanuaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeburaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AprilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JulyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AugustDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeptemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OctoberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NovemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TOPTENPRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESCROSSTABBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1141, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'SALESCROSSTABBindingSource
        '
        Me.SALESCROSSTABBindingSource.DataMember = "SALES_CROSSTAB"
        Me.SALESCROSSTABBindingSource.DataSource = Me.GEStoredProceduresBindingSource
        '
        'SALES_CROSSTABTableAdapter
        '
        Me.SALES_CROSSTABTableAdapter.ClearBeforeFill = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(224, 25)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 23)
        Me.btnDisplay.TabIndex = 15
        Me.btnDisplay.Text = "Display Report"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(118, 27)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Enter a year:"
        '
        'dgvReport14
        '
        Me.dgvReport14.AllowUserToAddRows = False
        Me.dgvReport14.AllowUserToDeleteRows = False
        Me.dgvReport14.AutoGenerateColumns = False
        Me.dgvReport14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport14.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JanuaryDataGridViewTextBoxColumn, Me.FeburaryDataGridViewTextBoxColumn, Me.MarchDataGridViewTextBoxColumn, Me.AprilDataGridViewTextBoxColumn, Me.MayDataGridViewTextBoxColumn, Me.JuneDataGridViewTextBoxColumn, Me.JulyDataGridViewTextBoxColumn, Me.AugustDataGridViewTextBoxColumn, Me.SeptemberDataGridViewTextBoxColumn, Me.OctoberDataGridViewTextBoxColumn, Me.NovemberDataGridViewTextBoxColumn, Me.DecemberDataGridViewTextBoxColumn})
        Me.dgvReport14.DataSource = Me.SALESCROSSTABBindingSource
        Me.dgvReport14.Location = New System.Drawing.Point(4, 66)
        Me.dgvReport14.Name = "dgvReport14"
        Me.dgvReport14.ReadOnly = True
        Me.dgvReport14.RowHeadersVisible = False
        Me.dgvReport14.Size = New System.Drawing.Size(1132, 457)
        Me.dgvReport14.TabIndex = 12
        '
        'JanuaryDataGridViewTextBoxColumn
        '
        Me.JanuaryDataGridViewTextBoxColumn.DataPropertyName = "January"
        Me.JanuaryDataGridViewTextBoxColumn.HeaderText = "January"
        Me.JanuaryDataGridViewTextBoxColumn.Name = "JanuaryDataGridViewTextBoxColumn"
        Me.JanuaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FeburaryDataGridViewTextBoxColumn
        '
        Me.FeburaryDataGridViewTextBoxColumn.DataPropertyName = "feburary"
        Me.FeburaryDataGridViewTextBoxColumn.HeaderText = "feburary"
        Me.FeburaryDataGridViewTextBoxColumn.Name = "FeburaryDataGridViewTextBoxColumn"
        Me.FeburaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarchDataGridViewTextBoxColumn
        '
        Me.MarchDataGridViewTextBoxColumn.DataPropertyName = "march"
        Me.MarchDataGridViewTextBoxColumn.HeaderText = "march"
        Me.MarchDataGridViewTextBoxColumn.Name = "MarchDataGridViewTextBoxColumn"
        Me.MarchDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AprilDataGridViewTextBoxColumn
        '
        Me.AprilDataGridViewTextBoxColumn.DataPropertyName = "april"
        Me.AprilDataGridViewTextBoxColumn.HeaderText = "april"
        Me.AprilDataGridViewTextBoxColumn.Name = "AprilDataGridViewTextBoxColumn"
        Me.AprilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MayDataGridViewTextBoxColumn
        '
        Me.MayDataGridViewTextBoxColumn.DataPropertyName = "may"
        Me.MayDataGridViewTextBoxColumn.HeaderText = "may"
        Me.MayDataGridViewTextBoxColumn.Name = "MayDataGridViewTextBoxColumn"
        Me.MayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JuneDataGridViewTextBoxColumn
        '
        Me.JuneDataGridViewTextBoxColumn.DataPropertyName = "june"
        Me.JuneDataGridViewTextBoxColumn.HeaderText = "june"
        Me.JuneDataGridViewTextBoxColumn.Name = "JuneDataGridViewTextBoxColumn"
        Me.JuneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JulyDataGridViewTextBoxColumn
        '
        Me.JulyDataGridViewTextBoxColumn.DataPropertyName = "july"
        Me.JulyDataGridViewTextBoxColumn.HeaderText = "july"
        Me.JulyDataGridViewTextBoxColumn.Name = "JulyDataGridViewTextBoxColumn"
        Me.JulyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AugustDataGridViewTextBoxColumn
        '
        Me.AugustDataGridViewTextBoxColumn.DataPropertyName = "august"
        Me.AugustDataGridViewTextBoxColumn.HeaderText = "august"
        Me.AugustDataGridViewTextBoxColumn.Name = "AugustDataGridViewTextBoxColumn"
        Me.AugustDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeptemberDataGridViewTextBoxColumn
        '
        Me.SeptemberDataGridViewTextBoxColumn.DataPropertyName = "september"
        Me.SeptemberDataGridViewTextBoxColumn.HeaderText = "september"
        Me.SeptemberDataGridViewTextBoxColumn.Name = "SeptemberDataGridViewTextBoxColumn"
        Me.SeptemberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OctoberDataGridViewTextBoxColumn
        '
        Me.OctoberDataGridViewTextBoxColumn.DataPropertyName = "october"
        Me.OctoberDataGridViewTextBoxColumn.HeaderText = "october"
        Me.OctoberDataGridViewTextBoxColumn.Name = "OctoberDataGridViewTextBoxColumn"
        Me.OctoberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NovemberDataGridViewTextBoxColumn
        '
        Me.NovemberDataGridViewTextBoxColumn.DataPropertyName = "november"
        Me.NovemberDataGridViewTextBoxColumn.HeaderText = "november"
        Me.NovemberDataGridViewTextBoxColumn.Name = "NovemberDataGridViewTextBoxColumn"
        Me.NovemberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DecemberDataGridViewTextBoxColumn
        '
        Me.DecemberDataGridViewTextBoxColumn.DataPropertyName = "december"
        Me.DecemberDataGridViewTextBoxColumn.HeaderText = "december"
        Me.DecemberDataGridViewTextBoxColumn.Name = "DecemberDataGridViewTextBoxColumn"
        Me.DecemberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmReport11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 549)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReport14)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmReport11"
        Me.Text = "Report 11 - Sales Crosstab"
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TOPTENPRODUCTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESCROSSTABBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Sales_per_locationTableAdapter As GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter
    Friend WithEvents GEStoredProcedures As GEStoredProcedures
    Friend WithEvents GEStoredProceduresBindingSource As BindingSource
    Friend WithEvents SalesperlocationBindingSource As BindingSource
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TOPTENPRODUCTSBindingSource As BindingSource
    Friend WithEvents TOP_TEN_PRODUCTSTableAdapter As GEStoredProceduresTableAdapters.TOP_TEN_PRODUCTSTableAdapter
    Friend WithEvents SALESCROSSTABBindingSource As BindingSource
    Friend WithEvents SALES_CROSSTABTableAdapter As GEStoredProceduresTableAdapters.SALES_CROSSTABTableAdapter
    Friend WithEvents btnDisplay As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvReport14 As DataGridView
    Friend WithEvents JanuaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FeburaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarchDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AprilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JuneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JulyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AugustDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeptemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OctoberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NovemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DecemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
