<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discounts1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.DiscountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.DiscountsTableAdapter()
        Me.DiscountTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Discount_TypeTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Discount_TypeTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisName = New System.Windows.Forms.TextBox()
        Me.lblBuy = New System.Windows.Forms.Label()
        Me.lblGet = New System.Windows.Forms.Label()
        Me.txtBuy = New System.Windows.Forms.TextBox()
        Me.txtGet = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Discount Type:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DiscountTypeBindingSource
        Me.ComboBox1.DisplayMember = "discountType"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(232, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "discountTypeID"
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiscountsBindingSource
        '
        Me.DiscountsBindingSource.DataMember = "Discounts"
        Me.DiscountsBindingSource.DataSource = Me.GEDataSet
        '
        'DiscountsTableAdapter
        '
        Me.DiscountsTableAdapter.ClearBeforeFill = True
        '
        'DiscountTypeBindingSource
        '
        Me.DiscountTypeBindingSource.DataMember = "Discount_Type"
        Me.DiscountTypeBindingSource.DataSource = Me.GEDataSet
        '
        'Discount_TypeTableAdapter
        '
        Me.Discount_TypeTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Discount Name:"
        '
        'txtDisName
        '
        Me.txtDisName.Location = New System.Drawing.Point(232, 23)
        Me.txtDisName.Name = "txtDisName"
        Me.txtDisName.Size = New System.Drawing.Size(121, 20)
        Me.txtDisName.TabIndex = 4
        '
        'lblBuy
        '
        Me.lblBuy.AutoSize = True
        Me.lblBuy.Location = New System.Drawing.Point(201, 94)
        Me.lblBuy.Name = "lblBuy"
        Me.lblBuy.Size = New System.Drawing.Size(25, 13)
        Me.lblBuy.TabIndex = 5
        Me.lblBuy.Text = "Buy"
        '
        'lblGet
        '
        Me.lblGet.AutoSize = True
        Me.lblGet.Location = New System.Drawing.Point(201, 120)
        Me.lblGet.Name = "lblGet"
        Me.lblGet.Size = New System.Drawing.Size(24, 13)
        Me.lblGet.TabIndex = 6
        Me.lblGet.Text = "Get"
        '
        'txtBuy
        '
        Me.txtBuy.Location = New System.Drawing.Point(232, 91)
        Me.txtBuy.Name = "txtBuy"
        Me.txtBuy.Size = New System.Drawing.Size(121, 20)
        Me.txtBuy.TabIndex = 7
        '
        'txtGet
        '
        Me.txtGet.Location = New System.Drawing.Point(232, 117)
        Me.txtGet.Name = "txtGet"
        Me.txtGet.Size = New System.Drawing.Size(121, 20)
        Me.txtGet.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(524, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Discounts1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 340)
        Me.Controls.Add(Me.txtGet)
        Me.Controls.Add(Me.txtBuy)
        Me.Controls.Add(Me.lblGet)
        Me.Controls.Add(Me.lblBuy)
        Me.Controls.Add(Me.txtDisName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Discounts1"
        Me.Text = "Add Discount"
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents DiscountsBindingSource As BindingSource
    Friend WithEvents DiscountsTableAdapter As GEDataSetTableAdapters.DiscountsTableAdapter
    Friend WithEvents DiscountTypeBindingSource As BindingSource
    Friend WithEvents Discount_TypeTableAdapter As GEDataSetTableAdapters.Discount_TypeTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDisName As TextBox
    Friend WithEvents lblBuy As Label
    Friend WithEvents lblGet As Label
    Friend WithEvents txtBuy As TextBox
    Friend WithEvents txtGet As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
