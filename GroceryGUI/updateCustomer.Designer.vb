<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateCustomer
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Gift_CardsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gift_CardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtUsedLineOfCredit = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAvailableCredit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New GroceryGUI.GEDataSetTableAdapters.TableAdapterManager()
        Me.btnsave2 = New System.Windows.Forms.Button()
        Me.lblFR = New System.Windows.Forms.Label()
        Me.lblLR = New System.Windows.Forms.Label()
        Me.lblDR = New System.Windows.Forms.Label()
        Me.lblPR = New System.Windows.Forms.Label()
        Me.txtbirthdate = New System.Windows.Forms.MaskedTextBox()
        Me.txtprimary = New System.Windows.Forms.MaskedTextBox()
        Me.txtSecondary = New System.Windows.Forms.MaskedTextBox()
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.Gift_CardsTableAdapter = New GroceryGUI.GEDataSetTableAdapters.Gift_CardsTableAdapter()
        CustomerIDLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Gift_CardsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gift_CardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(137, 66)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(67, 13)
        CustomerIDLabel.TabIndex = 0
        CustomerIDLabel.Text = "customer ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Gift_CardsDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(399, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 215)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gift Cards"
        '
        'Gift_CardsDataGridView
        '
        Me.Gift_CardsDataGridView.AllowUserToAddRows = False
        Me.Gift_CardsDataGridView.AllowUserToDeleteRows = False
        Me.Gift_CardsDataGridView.AutoGenerateColumns = False
        Me.Gift_CardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Gift_CardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gift_CardsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.Gift_CardsDataGridView.DataSource = Me.Gift_CardsBindingSource
        Me.Gift_CardsDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.Gift_CardsDataGridView.Name = "Gift_CardsDataGridView"
        Me.Gift_CardsDataGridView.ReadOnly = True
        Me.Gift_CardsDataGridView.RowHeadersVisible = False
        Me.Gift_CardsDataGridView.Size = New System.Drawing.Size(188, 188)
        Me.Gift_CardsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "giftCardID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "giftCardID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 79
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cardTotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cardTotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 77
        '
        'Gift_CardsBindingSource
        '
        Me.Gift_CardsBindingSource.DataMember = "Gift_Cards"
        Me.Gift_CardsBindingSource.DataSource = Me.GEDataSet
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(26, 19)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(76, 17)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Newsletter"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(26, 49)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "Flier"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(26, 78)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Email"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(399, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subscriptions"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnSave.Location = New System.Drawing.Point(14, 405)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(585, 67)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtUsedLineOfCredit
        '
        Me.txtUsedLineOfCredit.Enabled = False
        Me.txtUsedLineOfCredit.Location = New System.Drawing.Point(210, 361)
        Me.txtUsedLineOfCredit.Name = "txtUsedLineOfCredit"
        Me.txtUsedLineOfCredit.ReadOnly = True
        Me.txtUsedLineOfCredit.Size = New System.Drawing.Size(155, 20)
        Me.txtUsedLineOfCredit.TabIndex = 9
        Me.txtUsedLineOfCredit.Text = "0.00"
        '
        'txtFirst
        '
        Me.txtFirst.Enabled = False
        Me.txtFirst.Location = New System.Drawing.Point(210, 91)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.ReadOnly = True
        Me.txtFirst.Size = New System.Drawing.Size(155, 20)
        Me.txtFirst.TabIndex = 2
        '
        'txtLast
        '
        Me.txtLast.Enabled = False
        Me.txtLast.Location = New System.Drawing.Point(210, 128)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.ReadOnly = True
        Me.txtLast.Size = New System.Drawing.Size(155, 20)
        Me.txtLast.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(210, 284)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(155, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtAvailableCredit
        '
        Me.txtAvailableCredit.Enabled = False
        Me.txtAvailableCredit.Location = New System.Drawing.Point(210, 322)
        Me.txtAvailableCredit.Name = "txtAvailableCredit"
        Me.txtAvailableCredit.ReadOnly = True
        Me.txtAvailableCredit.Size = New System.Drawing.Size(155, 20)
        Me.txtAvailableCredit.TabIndex = 8
        Me.txtAvailableCredit.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(121, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Available Credit:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(169, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(11, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Secondary Phone # (Dashes included):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(28, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Primary Phone # (Dashes included):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(138, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(143, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(144, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name:"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Padding = New System.Windows.Forms.Padding(23, 0, 4, 0)
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Padding = New System.Windows.Forms.Padding(23, 0, 5, 0)
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.BackToolStripMenuItem.Text = "Close"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(104, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Used Line of Credit:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.mnuUpdate, Me.AddressToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(20, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(613, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(57, 20)
        Me.mnuUpdate.Text = "Update"
        '
        'AddressToolStripMenuItem
        '
        Me.AddressToolStripMenuItem.Name = "AddressToolStripMenuItem"
        Me.AddressToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AddressToolStripMenuItem.Text = "address"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Enabled = False
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(210, 63)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CustomerIDTextBox.TabIndex = 1
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.GEDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Billing_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Campaign_Opt_InsTableAdapter = Nothing
        Me.TableAdapterManager.Campaign_TypesTableAdapter = Nothing
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CouponsTableAdapter = Nothing
        Me.TableAdapterManager.CreditAuditTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.Discount_TypeTableAdapter = Nothing
        Me.TableAdapterManager.DiscountsTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Gift_CardsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Item_DiscountTableAdapter = Nothing
        Me.TableAdapterManager.Marketing_CampaignsTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Order_DiscountTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.Payment_TypesTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Promoted_ProductsTableAdapter = Nothing
        Me.TableAdapterManager.PromotionsTableAdapter = Nothing
        Me.TableAdapterManager.Purchase_Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Purchase_OrderTableAdapter = Nothing
        Me.TableAdapterManager.ReturnsTableAdapter = Nothing
        Me.TableAdapterManager.Shipment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.ShipmentTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_AddressesTableAdapter = Nothing
        Me.TableAdapterManager.Shipping_MethodsTableAdapter = Nothing
        Me.TableAdapterManager.ShrinkageTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Trade_ShowsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroceryGUI.GEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnsave2
        '
        Me.btnsave2.Enabled = False
        Me.btnsave2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnsave2.Location = New System.Drawing.Point(12, 405)
        Me.btnsave2.Name = "btnsave2"
        Me.btnsave2.Size = New System.Drawing.Size(589, 67)
        Me.btnsave2.TabIndex = 10
        Me.btnsave2.Text = "Save"
        Me.btnsave2.UseVisualStyleBackColor = True
        Me.btnsave2.Visible = False
        '
        'lblFR
        '
        Me.lblFR.AutoSize = True
        Me.lblFR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFR.Location = New System.Drawing.Point(112, 96)
        Me.lblFR.Name = "lblFR"
        Me.lblFR.Size = New System.Drawing.Size(20, 25)
        Me.lblFR.TabIndex = 0
        Me.lblFR.Text = "*"
        '
        'lblLR
        '
        Me.lblLR.AutoSize = True
        Me.lblLR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLR.Location = New System.Drawing.Point(112, 125)
        Me.lblLR.Name = "lblLR"
        Me.lblLR.Size = New System.Drawing.Size(20, 25)
        Me.lblLR.TabIndex = 0
        Me.lblLR.Text = "*"
        '
        'lblDR
        '
        Me.lblDR.AutoSize = True
        Me.lblDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDR.Location = New System.Drawing.Point(112, 167)
        Me.lblDR.Name = "lblDR"
        Me.lblDR.Size = New System.Drawing.Size(20, 25)
        Me.lblDR.TabIndex = 0
        Me.lblDR.Text = "*"
        '
        'lblPR
        '
        Me.lblPR.AutoSize = True
        Me.lblPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPR.Location = New System.Drawing.Point(2, 208)
        Me.lblPR.Name = "lblPR"
        Me.lblPR.Size = New System.Drawing.Size(20, 25)
        Me.lblPR.TabIndex = 0
        Me.lblPR.Text = "*"
        '
        'txtbirthdate
        '
        Me.txtbirthdate.Enabled = False
        Me.txtbirthdate.Location = New System.Drawing.Point(210, 167)
        Me.txtbirthdate.Mask = "00/00/0000"
        Me.txtbirthdate.Name = "txtbirthdate"
        Me.txtbirthdate.ReadOnly = True
        Me.txtbirthdate.Size = New System.Drawing.Size(155, 20)
        Me.txtbirthdate.TabIndex = 4
        Me.txtbirthdate.ValidatingType = GetType(Date)
        '
        'txtprimary
        '
        Me.txtprimary.Enabled = False
        Me.txtprimary.Location = New System.Drawing.Point(210, 208)
        Me.txtprimary.Mask = "(999) 000-0000"
        Me.txtprimary.Name = "txtprimary"
        Me.txtprimary.ReadOnly = True
        Me.txtprimary.Size = New System.Drawing.Size(155, 20)
        Me.txtprimary.TabIndex = 5
        '
        'txtSecondary
        '
        Me.txtSecondary.Enabled = False
        Me.txtSecondary.Location = New System.Drawing.Point(210, 246)
        Me.txtSecondary.Mask = "(999) 000-0000"
        Me.txtSecondary.Name = "txtSecondary"
        Me.txtSecondary.ReadOnly = True
        Me.txtSecondary.Size = New System.Drawing.Size(155, 20)
        Me.txtSecondary.TabIndex = 6
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'Gift_CardsTableAdapter
        '
        Me.Gift_CardsTableAdapter.ClearBeforeFill = True
        '
        'frmUpdateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 484)
        Me.Controls.Add(Me.txtSecondary)
        Me.Controls.Add(Me.txtprimary)
        Me.Controls.Add(Me.txtbirthdate)
        Me.Controls.Add(Me.lblPR)
        Me.Controls.Add(Me.lblDR)
        Me.Controls.Add(Me.lblLR)
        Me.Controls.Add(Me.lblFR)
        Me.Controls.Add(Me.btnsave2)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtUsedLineOfCredit)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAvailableCredit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Update"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Gift_CardsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gift_CardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtUsedLineOfCredit As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAvailableCredit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As GEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents Gift_CardsDataGridView As DataGridView
    Friend WithEvents Gift_CardsBindingSource As BindingSource
    Friend WithEvents btnsave2 As Button
    Friend WithEvents lblFR As Label
    Friend WithEvents lblLR As Label
    Friend WithEvents lblDR As Label
    Friend WithEvents lblPR As Label
    Friend WithEvents txtbirthdate As MaskedTextBox
    Friend WithEvents txtprimary As MaskedTextBox
    Friend WithEvents txtSecondary As MaskedTextBox
    Friend WithEvents AddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents Gift_CardsTableAdapter As GEDataSetTableAdapters.Gift_CardsTableAdapter
End Class
