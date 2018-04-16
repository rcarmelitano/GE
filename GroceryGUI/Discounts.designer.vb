<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiscounts
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDiscountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuyOneGetOne = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFlatDiscount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.chkLinkYes = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkLinkNo = New System.Windows.Forms.CheckBox()
        Me.txtDiscountName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemoveProduct = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.btnRemoveID = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAddPromotion = New System.Windows.Forms.Button()
        Me.chkSunday = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkFriday = New System.Windows.Forms.CheckBox()
        Me.chkThursday = New System.Windows.Forms.CheckBox()
        Me.cmbPromotion = New System.Windows.Forms.ComboBox()
        Me.chkWednesday = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddDiscount = New System.Windows.Forms.Button()
        Me.chkTuesday = New System.Windows.Forms.CheckBox()
        Me.chkMonday = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.ViewDiscountsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'ViewDiscountsToolStripMenuItem
        '
        Me.ViewDiscountsToolStripMenuItem.Name = "ViewDiscountsToolStripMenuItem"
        Me.ViewDiscountsToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ViewDiscountsToolStripMenuItem.Text = "View Discounts"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtBuyOneGetOne)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFlatDiscount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPercentage)
        Me.GroupBox2.Controls.Add(Me.chkLinkYes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkLinkNo)
        Me.GroupBox2.Controls.Add(Me.txtDiscountName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 229)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discount Type Amounts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "(Choose One)"
        '
        'txtBuyOneGetOne
        '
        Me.txtBuyOneGetOne.Location = New System.Drawing.Point(110, 87)
        Me.txtBuyOneGetOne.Name = "txtBuyOneGetOne"
        Me.txtBuyOneGetOne.Size = New System.Drawing.Size(166, 20)
        Me.txtBuyOneGetOne.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Buy One Get One:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Flat Discount:"
        '
        'txtFlatDiscount
        '
        Me.txtFlatDiscount.Location = New System.Drawing.Point(110, 125)
        Me.txtFlatDiscount.Name = "txtFlatDiscount"
        Me.txtFlatDiscount.Size = New System.Drawing.Size(166, 20)
        Me.txtFlatDiscount.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Percentage:"
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(110, 160)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(166, 20)
        Me.txtPercentage.TabIndex = 26
        '
        'chkLinkYes
        '
        Me.chkLinkYes.AutoSize = True
        Me.chkLinkYes.Location = New System.Drawing.Point(111, 201)
        Me.chkLinkYes.Name = "chkLinkYes"
        Me.chkLinkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkLinkYes.TabIndex = 32
        Me.chkLinkYes.Text = "Yes"
        Me.chkLinkYes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Link to Promotion?"
        '
        'chkLinkNo
        '
        Me.chkLinkNo.AutoSize = True
        Me.chkLinkNo.Location = New System.Drawing.Point(184, 202)
        Me.chkLinkNo.Name = "chkLinkNo"
        Me.chkLinkNo.Size = New System.Drawing.Size(40, 17)
        Me.chkLinkNo.TabIndex = 33
        Me.chkLinkNo.Text = "No"
        Me.chkLinkNo.UseVisualStyleBackColor = True
        '
        'txtDiscountName
        '
        Me.txtDiscountName.Location = New System.Drawing.Point(110, 50)
        Me.txtDiscountName.Name = "txtDiscountName"
        Me.txtDiscountName.Size = New System.Drawing.Size(166, 20)
        Me.txtDiscountName.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Discount Name:"
        '
        'btnRemoveProduct
        '
        Me.btnRemoveProduct.Location = New System.Drawing.Point(432, 473)
        Me.btnRemoveProduct.Name = "btnRemoveProduct"
        Me.btnRemoveProduct.Size = New System.Drawing.Size(98, 33)
        Me.btnRemoveProduct.TabIndex = 59
        Me.btnRemoveProduct.Text = "Remove"
        Me.btnRemoveProduct.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(349, 326)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(276, 141)
        Me.DataGridView2.TabIndex = 58
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(550, 293)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 57
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'cmbProduct
        '
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(423, 293)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(121, 21)
        Me.cmbProduct.TabIndex = 56
        '
        'btnRemoveID
        '
        Me.btnRemoveID.Location = New System.Drawing.Point(90, 473)
        Me.btnRemoveID.Name = "btnRemoveID"
        Me.btnRemoveID.Size = New System.Drawing.Size(98, 33)
        Me.btnRemoveID.TabIndex = 54
        Me.btnRemoveID.Text = "Remove"
        Me.btnRemoveID.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 326)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(276, 141)
        Me.DataGridView1.TabIndex = 53
        '
        'btnAddPromotion
        '
        Me.btnAddPromotion.Location = New System.Drawing.Point(208, 293)
        Me.btnAddPromotion.Name = "btnAddPromotion"
        Me.btnAddPromotion.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPromotion.TabIndex = 52
        Me.btnAddPromotion.Text = "Add"
        Me.btnAddPromotion.UseVisualStyleBackColor = True
        '
        'chkSunday
        '
        Me.chkSunday.AutoSize = True
        Me.chkSunday.Location = New System.Drawing.Point(23, 160)
        Me.chkSunday.Name = "chkSunday"
        Me.chkSunday.Size = New System.Drawing.Size(62, 17)
        Me.chkSunday.TabIndex = 28
        Me.chkSunday.Text = "Sunday"
        Me.chkSunday.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(23, 138)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(68, 17)
        Me.chkSaturday.TabIndex = 28
        Me.chkSaturday.Text = "Saturday"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkFriday
        '
        Me.chkFriday.AutoSize = True
        Me.chkFriday.Location = New System.Drawing.Point(23, 116)
        Me.chkFriday.Name = "chkFriday"
        Me.chkFriday.Size = New System.Drawing.Size(54, 17)
        Me.chkFriday.TabIndex = 4
        Me.chkFriday.Text = "Friday"
        Me.chkFriday.UseVisualStyleBackColor = True
        '
        'chkThursday
        '
        Me.chkThursday.AutoSize = True
        Me.chkThursday.Location = New System.Drawing.Point(23, 94)
        Me.chkThursday.Name = "chkThursday"
        Me.chkThursday.Size = New System.Drawing.Size(70, 17)
        Me.chkThursday.TabIndex = 3
        Me.chkThursday.Text = "Thursday"
        Me.chkThursday.UseVisualStyleBackColor = True
        '
        'cmbPromotion
        '
        Me.cmbPromotion.FormattingEnabled = True
        Me.cmbPromotion.Location = New System.Drawing.Point(81, 293)
        Me.cmbPromotion.Name = "cmbPromotion"
        Me.cmbPromotion.Size = New System.Drawing.Size(121, 21)
        Me.cmbPromotion.TabIndex = 51
        '
        'chkWednesday
        '
        Me.chkWednesday.AutoSize = True
        Me.chkWednesday.Location = New System.Drawing.Point(23, 72)
        Me.chkWednesday.Name = "chkWednesday"
        Me.chkWednesday.Size = New System.Drawing.Size(83, 17)
        Me.chkWednesday.TabIndex = 2
        Me.chkWednesday.Text = "Wednesday"
        Me.chkWednesday.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Promotion ID:"
        '
        'btnAddDiscount
        '
        Me.btnAddDiscount.Location = New System.Drawing.Point(88, 526)
        Me.btnAddDiscount.Name = "btnAddDiscount"
        Me.btnAddDiscount.Size = New System.Drawing.Size(442, 40)
        Me.btnAddDiscount.TabIndex = 49
        Me.btnAddDiscount.Text = "Add Discount"
        Me.btnAddDiscount.UseVisualStyleBackColor = True
        '
        'chkTuesday
        '
        Me.chkTuesday.AutoSize = True
        Me.chkTuesday.Location = New System.Drawing.Point(23, 50)
        Me.chkTuesday.Name = "chkTuesday"
        Me.chkTuesday.Size = New System.Drawing.Size(67, 17)
        Me.chkTuesday.TabIndex = 1
        Me.chkTuesday.Text = "Tuesday"
        Me.chkTuesday.UseVisualStyleBackColor = True
        '
        'chkMonday
        '
        Me.chkMonday.AutoSize = True
        Me.chkMonday.Location = New System.Drawing.Point(23, 28)
        Me.chkMonday.Name = "chkMonday"
        Me.chkMonday.Size = New System.Drawing.Size(64, 17)
        Me.chkMonday.TabIndex = 0
        Me.chkMonday.Text = "Monday"
        Me.chkMonday.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(346, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Product ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSunday)
        Me.GroupBox1.Controls.Add(Me.chkSaturday)
        Me.GroupBox1.Controls.Add(Me.chkFriday)
        Me.GroupBox1.Controls.Add(Me.chkThursday)
        Me.GroupBox1.Controls.Add(Me.chkWednesday)
        Me.GroupBox1.Controls.Add(Me.chkTuesday)
        Me.GroupBox1.Controls.Add(Me.chkMonday)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 229)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repeat"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(74, 195)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Repeat: "
        '
        'frmDiscounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 570)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRemoveProduct)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.cmbProduct)
        Me.Controls.Add(Me.btnRemoveID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAddPromotion)
        Me.Controls.Add(Me.cmbPromotion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnAddDiscount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmDiscounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discounts"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDiscountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuyOneGetOne As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFlatDiscount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents chkLinkYes As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkLinkNo As CheckBox
    Friend WithEvents btnRemoveProduct As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents btnRemoveID As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddPromotion As Button
    Friend WithEvents chkSunday As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkFriday As CheckBox
    Friend WithEvents chkThursday As CheckBox
    Friend WithEvents cmbPromotion As ComboBox
    Friend WithEvents chkWednesday As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddDiscount As Button
    Friend WithEvents chkTuesday As CheckBox
    Friend WithEvents txtDiscountName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMonday As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
End Class
