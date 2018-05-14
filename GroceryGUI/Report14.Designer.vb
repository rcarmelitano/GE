<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport14
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
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvReport14 = New System.Windows.Forms.DataGridView()
        Me.SalesperlocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GEStoredProceduresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEStoredProcedures = New GroceryGUI.GEStoredProcedures()
        Me.Sales_per_locationTableAdapter = New GroceryGUI.GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1156, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(44, 20)
        Me.mnuBack.Text = "Back"
        '
        'dgvReport14
        '
        Me.dgvReport14.AllowUserToAddRows = False
        Me.dgvReport14.AllowUserToDeleteRows = False
        Me.dgvReport14.AutoGenerateColumns = False
        Me.dgvReport14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport14.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocationDataGridViewTextBoxColumn, Me.JanuaryDataGridViewTextBoxColumn, Me.FeburaryDataGridViewTextBoxColumn, Me.MarchDataGridViewTextBoxColumn, Me.AprilDataGridViewTextBoxColumn, Me.MayDataGridViewTextBoxColumn, Me.JuneDataGridViewTextBoxColumn, Me.JulyDataGridViewTextBoxColumn, Me.AugustDataGridViewTextBoxColumn, Me.SeptemberDataGridViewTextBoxColumn, Me.OctoberDataGridViewTextBoxColumn, Me.NovemberDataGridViewTextBoxColumn, Me.DecemberDataGridViewTextBoxColumn})
        Me.dgvReport14.DataSource = Me.SalesperlocationBindingSource
        Me.dgvReport14.Location = New System.Drawing.Point(12, 80)
        Me.dgvReport14.Name = "dgvReport14"
        Me.dgvReport14.ReadOnly = True
        Me.dgvReport14.RowHeadersVisible = False
        Me.dgvReport14.Size = New System.Drawing.Size(1132, 457)
        Me.dgvReport14.TabIndex = 2
        '
        'SalesperlocationBindingSource
        '
        Me.SalesperlocationBindingSource.DataMember = "Sales_per_location"
        Me.SalesperlocationBindingSource.DataSource = Me.GEStoredProceduresBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter a year:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(126, 41)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 4
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(232, 39)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(118, 23)
        Me.btnDisplay.TabIndex = 5
        Me.btnDisplay.Text = "Display Report"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
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
        'GEStoredProceduresBindingSource
        '
        Me.GEStoredProceduresBindingSource.DataSource = Me.GEStoredProcedures
        Me.GEStoredProceduresBindingSource.Position = 0
        '
        'GEStoredProcedures
        '
        Me.GEStoredProcedures.DataSetName = "GEStoredProcedures"
        Me.GEStoredProcedures.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sales_per_locationTableAdapter
        '
        Me.Sales_per_locationTableAdapter.ClearBeforeFill = True
        '
        'frmReport14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 549)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReport14)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmReport14"
        Me.Text = "Report 14 - Sales per Location"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvReport14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesperlocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEStoredProceduresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEStoredProcedures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents dgvReport14 As DataGridView
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents SalesperlocationBindingSource As BindingSource
    Friend WithEvents GEStoredProceduresBindingSource As BindingSource
    Friend WithEvents GEStoredProcedures As GEStoredProcedures
    Friend WithEvents Sales_per_locationTableAdapter As GEStoredProceduresTableAdapters.Sales_per_locationTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnDisplay As Button
End Class
