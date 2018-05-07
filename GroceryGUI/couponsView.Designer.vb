<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCouponsView
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
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CouponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.CouponsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CouponsTableAdapter()
        Me.CouponIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PromotionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CouponStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CouponEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CouponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(842, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CouponIDDataGridViewTextBoxColumn, Me.DiscountIDDataGridViewTextBoxColumn, Me.PromotionIDDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.CouponStartDateDataGridViewTextBoxColumn, Me.CouponEndDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CouponsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(8, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(822, 308)
        Me.DataGridView1.TabIndex = 1
        '
        'CouponsBindingSource
        '
        Me.CouponsBindingSource.DataMember = "Coupons"
        Me.CouponsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CouponsTableAdapter
        '
        Me.CouponsTableAdapter.ClearBeforeFill = True
        '
        'CouponIDDataGridViewTextBoxColumn
        '
        Me.CouponIDDataGridViewTextBoxColumn.DataPropertyName = "couponID"
        Me.CouponIDDataGridViewTextBoxColumn.HeaderText = "Coupon ID"
        Me.CouponIDDataGridViewTextBoxColumn.Name = "CouponIDDataGridViewTextBoxColumn"
        Me.CouponIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiscountIDDataGridViewTextBoxColumn
        '
        Me.DiscountIDDataGridViewTextBoxColumn.DataPropertyName = "discountID"
        Me.DiscountIDDataGridViewTextBoxColumn.HeaderText = "Discount ID"
        Me.DiscountIDDataGridViewTextBoxColumn.Name = "DiscountIDDataGridViewTextBoxColumn"
        Me.DiscountIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PromotionIDDataGridViewTextBoxColumn
        '
        Me.PromotionIDDataGridViewTextBoxColumn.DataPropertyName = "promotionID"
        Me.PromotionIDDataGridViewTextBoxColumn.HeaderText = "Promotion ID"
        Me.PromotionIDDataGridViewTextBoxColumn.Name = "PromotionIDDataGridViewTextBoxColumn"
        Me.PromotionIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 319
        '
        'CouponStartDateDataGridViewTextBoxColumn
        '
        Me.CouponStartDateDataGridViewTextBoxColumn.DataPropertyName = "couponStartDate"
        Me.CouponStartDateDataGridViewTextBoxColumn.HeaderText = "Coupon Start Date"
        Me.CouponStartDateDataGridViewTextBoxColumn.Name = "CouponStartDateDataGridViewTextBoxColumn"
        Me.CouponStartDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CouponEndDateDataGridViewTextBoxColumn
        '
        Me.CouponEndDateDataGridViewTextBoxColumn.DataPropertyName = "couponEndDate"
        Me.CouponEndDateDataGridViewTextBoxColumn.HeaderText = "Coupon End Date"
        Me.CouponEndDateDataGridViewTextBoxColumn.Name = "CouponEndDateDataGridViewTextBoxColumn"
        Me.CouponEndDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCouponsView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 341)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmCouponsView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Coupons List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CouponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CouponsBindingSource As BindingSource
    Friend WithEvents CouponsTableAdapter As GEDataSetTableAdapters.CouponsTableAdapter
    Friend WithEvents CouponIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PromotionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CouponStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CouponEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
