<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromotion
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
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CouponsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPromotionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAddPromotion = New System.Windows.Forms.Button()
        Me.txtPromotionName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotionsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.PromotionsTableAdapter()
        Me.startDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.endDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPromoID = New System.Windows.Forms.TextBox()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CategoriesTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ManageToolStripMenuItem, Me.DiscountsToolStripMenuItem, Me.CouponsToolStripMenuItem, Me.ViewPromotionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(424, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.ManageToolStripMenuItem.Text = "Manage Promotions"
        '
        'DiscountsToolStripMenuItem
        '
        Me.DiscountsToolStripMenuItem.Name = "DiscountsToolStripMenuItem"
        Me.DiscountsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.DiscountsToolStripMenuItem.Text = "Discounts"
        '
        'CouponsToolStripMenuItem
        '
        Me.CouponsToolStripMenuItem.Name = "CouponsToolStripMenuItem"
        Me.CouponsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CouponsToolStripMenuItem.Text = "Coupons"
        '
        'ViewPromotionsToolStripMenuItem
        '
        Me.ViewPromotionsToolStripMenuItem.Name = "ViewPromotionsToolStripMenuItem"
        Me.ViewPromotionsToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ViewPromotionsToolStripMenuItem.Text = "View Promotions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Promotion Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Start Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(119, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "End Date:"
        '
        'btnAddPromotion
        '
        Me.btnAddPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPromotion.Location = New System.Drawing.Point(81, 247)
        Me.btnAddPromotion.Name = "btnAddPromotion"
        Me.btnAddPromotion.Size = New System.Drawing.Size(268, 45)
        Me.btnAddPromotion.TabIndex = 7
        Me.btnAddPromotion.Text = "Add Promotion"
        Me.btnAddPromotion.UseVisualStyleBackColor = True
        '
        'txtPromotionName
        '
        Me.txtPromotionName.Location = New System.Drawing.Point(191, 87)
        Me.txtPromotionName.Name = "txtPromotionName"
        Me.txtPromotionName.Size = New System.Drawing.Size(149, 20)
        Me.txtPromotionName.TabIndex = 8
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(191, 123)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(149, 20)
        Me.txtDescription.TabIndex = 10
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.GEDataSet
        '
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'startDatePicker
        '
        Me.startDatePicker.Location = New System.Drawing.Point(191, 164)
        Me.startDatePicker.Name = "startDatePicker"
        Me.startDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.startDatePicker.TabIndex = 12
        '
        'endDatePicker
        '
        Me.endDatePicker.Location = New System.Drawing.Point(191, 202)
        Me.endDatePicker.Name = "endDatePicker"
        Me.endDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.endDatePicker.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Promotion ID:"
        '
        'txtPromoID
        '
        Me.txtPromoID.Location = New System.Drawing.Point(191, 49)
        Me.txtPromoID.Name = "txtPromoID"
        Me.txtPromoID.Size = New System.Drawing.Size(149, 20)
        Me.txtPromoID.TabIndex = 15
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.GEDataSet
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'frmPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 304)
        Me.Controls.Add(Me.txtPromoID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.endDatePicker)
        Me.Controls.Add(Me.startDatePicker)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPromotionName)
        Me.Controls.Add(Me.btnAddPromotion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPromotion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promotion"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CouponsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAddPromotion As Button
    Friend WithEvents txtPromotionName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents ViewPromotionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents PromotionsBindingSource As BindingSource
    Friend WithEvents PromotionsTableAdapter As GEDataSetTableAdapters.PromotionsTableAdapter
    Friend WithEvents startDatePicker As DateTimePicker
    Friend WithEvents endDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPromoID As TextBox
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As GEDataSetTableAdapters.CategoriesTableAdapter
End Class
