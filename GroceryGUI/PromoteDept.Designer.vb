<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromoteDept
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
        Me.lblSelPromo = New System.Windows.Forms.Label()
        Me.cmbPromoSel = New System.Windows.Forms.ComboBox()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.lblSelDept = New System.Windows.Forms.Label()
        Me.cmbDeptSel = New System.Windows.Forms.ComboBox()
        Me.DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DepartmentsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblDgvLabel = New System.Windows.Forms.Label()
        Me.PromotionsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotedDepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PromotedDepartmentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Promoted_DepartmentsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Promoted_DepartmentsTableAdapter()
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Promotion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DepartmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotedDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotedDepartmentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelPromo
        '
        Me.lblSelPromo.AutoSize = True
        Me.lblSelPromo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSelPromo.Location = New System.Drawing.Point(12, 9)
        Me.lblSelPromo.Name = "lblSelPromo"
        Me.lblSelPromo.Size = New System.Drawing.Size(113, 16)
        Me.lblSelPromo.TabIndex = 4
        Me.lblSelPromo.Text = "Select Promotion:"
        '
        'cmbPromoSel
        '
        Me.cmbPromoSel.DataSource = Me.PromotionsBindingSource
        Me.cmbPromoSel.DisplayMember = "title"
        Me.cmbPromoSel.FormattingEnabled = True
        Me.cmbPromoSel.Location = New System.Drawing.Point(131, 8)
        Me.cmbPromoSel.Name = "cmbPromoSel"
        Me.cmbPromoSel.Size = New System.Drawing.Size(190, 21)
        Me.cmbPromoSel.TabIndex = 5
        Me.cmbPromoSel.ValueMember = "promotionID"
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'lblSelDept
        '
        Me.lblSelDept.AutoSize = True
        Me.lblSelDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblSelDept.Location = New System.Drawing.Point(3, 42)
        Me.lblSelDept.Name = "lblSelDept"
        Me.lblSelDept.Size = New System.Drawing.Size(122, 16)
        Me.lblSelDept.TabIndex = 6
        Me.lblSelDept.Text = "Select Department:"
        '
        'cmbDeptSel
        '
        Me.cmbDeptSel.DataSource = Me.DepartmentsBindingSource
        Me.cmbDeptSel.DisplayMember = "name"
        Me.cmbDeptSel.FormattingEnabled = True
        Me.cmbDeptSel.Location = New System.Drawing.Point(131, 41)
        Me.cmbDeptSel.Name = "cmbDeptSel"
        Me.cmbDeptSel.Size = New System.Drawing.Size(190, 21)
        Me.cmbDeptSel.TabIndex = 7
        Me.cmbDeptSel.ValueMember = "departmentID"
        '
        'DepartmentsBindingSource
        '
        Me.DepartmentsBindingSource.DataMember = "Departments"
        Me.DepartmentsBindingSource.DataSource = Me.GEDataSet
        '
        'DepartmentsTableAdapter
        '
        Me.DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Button1.Location = New System.Drawing.Point(110, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Promote"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblDgvLabel
        '
        Me.lblDgvLabel.AutoSize = True
        Me.lblDgvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblDgvLabel.Location = New System.Drawing.Point(12, 131)
        Me.lblDgvLabel.Name = "lblDgvLabel"
        Me.lblDgvLabel.Size = New System.Drawing.Size(131, 16)
        Me.lblDgvLabel.TabIndex = 11
        Me.lblDgvLabel.Text = "Existing Connections"
        '
        'PromotionsBindingSource2
        '
        Me.PromotionsBindingSource2.DataMember = "Promotions"
        Me.PromotionsBindingSource2.DataSource = Me.GEDataSet
        '
        'PromotedDepartmentsBindingSource
        '
        Me.PromotedDepartmentsBindingSource.DataMember = "Promoted_Departments"
        Me.PromotedDepartmentsBindingSource.DataSource = Me.GEDataSet
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Button2.Location = New System.Drawing.Point(110, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Return"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PromotionIDDataGridViewTextBoxColumn, Me.Promotion, Me.Department, Me.DepartmentIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PromotedDepartmentsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(6, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(315, 261)
        Me.DataGridView1.TabIndex = 14
        '
        'PromotedDepartmentsBindingSource1
        '
        Me.PromotedDepartmentsBindingSource1.DataMember = "Promoted_Departments"
        Me.PromotedDepartmentsBindingSource1.DataSource = Me.GEDataSet
        '
        'Promoted_DepartmentsTableAdapter
        '
        Me.Promoted_DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        Me.PromotionIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PromotionIDDataGridViewTextBoxColumn.Visible = False
        '
        'Promotion
        '
        Me.Promotion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Promotion.DataPropertyName = "promotionID"
        Me.Promotion.DataSource = Me.PromotionsBindingSource
        Me.Promotion.DisplayMember = "title"
        Me.Promotion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Promotion.HeaderText = "Promotion"
        Me.Promotion.Name = "Promotion"
        Me.Promotion.ReadOnly = True
        Me.Promotion.ValueMember = "promotionID"
        '
        'Department
        '
        Me.Department.DataPropertyName = "departmentID"
        Me.Department.DataSource = Me.DepartmentsBindingSource
        Me.Department.DisplayMember = "name"
        Me.Department.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.ValueMember = "departmentID"
        Me.Department.Width = 90
        '
        'DepartmentIDDataGridViewTextBoxColumn
        '
        Me.DepartmentIDDataGridViewTextBoxColumn.DataPropertyName = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.HeaderText = "departmentID"
        Me.DepartmentIDDataGridViewTextBoxColumn.Name = "DepartmentIDDataGridViewTextBoxColumn"
        Me.DepartmentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.DepartmentIDDataGridViewTextBoxColumn.Visible = False
        '
        'PromoteDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 461)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblDgvLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbDeptSel)
        Me.Controls.Add(Me.lblSelDept)
        Me.Controls.Add(Me.cmbPromoSel)
        Me.Controls.Add(Me.lblSelPromo)
        Me.Name = "PromoteDept"
        Me.Text = "Promote Department"
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotedDepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotedDepartmentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelPromo As Label
    Friend WithEvents cmbPromoSel As ComboBox
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents lblSelDept As Label
    Friend WithEvents cmbDeptSel As ComboBox
    Friend WithEvents DepartmentsBindingSource As BindingSource
    Friend WithEvents DepartmentsTableAdapter As GEDataSetTableAdapters.DepartmentsTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents lblDgvLabel As Label
    Friend WithEvents PromotionsBindingSource2 As BindingSource
    Friend WithEvents PromotedDepartmentsBindingSource As BindingSource
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PromotedDepartmentsBindingSource1 As BindingSource
    Friend WithEvents Promoted_DepartmentsTableAdapter As GEDataSetTableAdapters.Promoted_DepartmentsTableAdapter
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Promotion As DataGridViewComboBoxColumn
    Friend WithEvents Department As DataGridViewComboBoxColumn
    Friend WithEvents DepartmentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
