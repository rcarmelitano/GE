<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCCPayment
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
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblPaymentAmount = New System.Windows.Forms.Label()
        Me.nudPayment = New System.Windows.Forms.NumericUpDown()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New GroceryGUI.GEDataSetTableAdapters.CustomersTableAdapter()
        Me.cbEmail = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.nudPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Location = New System.Drawing.Point(151, 97)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalCost.TabIndex = 0
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(87, 100)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(58, 13)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Total Cost:"
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Location = New System.Drawing.Point(94, 148)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(51, 13)
        Me.lblPaymentAmount.TabIndex = 2
        Me.lblPaymentAmount.Text = "Payment:"
        '
        'nudPayment
        '
        Me.nudPayment.DecimalPlaces = 2
        Me.nudPayment.Location = New System.Drawing.Point(151, 146)
        Me.nudPayment.Name = "nudPayment"
        Me.nudPayment.Size = New System.Drawing.Size(121, 20)
        Me.nudPayment.TabIndex = 3
        '
        'btnMakePayment
        '
        Me.btnMakePayment.Location = New System.Drawing.Point(106, 215)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(146, 38)
        Me.btnMakePayment.TabIndex = 4
        Me.btnMakePayment.Text = "Make Payment"
        Me.btnMakePayment.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(134, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(90, 24)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Payment"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(110, 125)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.Visible = False
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.GEDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'cbEmail
        '
        Me.cbEmail.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersBindingSource2, "customerID", True))
        Me.cbEmail.FormattingEnabled = True
        Me.cbEmail.Location = New System.Drawing.Point(151, 122)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(175, 21)
        Me.cbEmail.TabIndex = 9
        Me.cbEmail.Visible = False
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.GEDataSet
        '
        'CustomersBindingSource2
        '
        Me.CustomersBindingSource2.DataMember = "Customers"
        Me.CustomersBindingSource2.DataSource = Me.GEDataSet
        '
        'frmCCCPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 266)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnMakePayment)
        Me.Controls.Add(Me.nudPayment)
        Me.Controls.Add(Me.lblPaymentAmount)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmCCCPayment"
        Me.Text = "Payment"
        CType(Me.nudPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblPaymentAmount As Label
    Friend WithEvents nudPayment As NumericUpDown
    Friend WithEvents btnMakePayment As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents lblEmail As Label
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As GEDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents cbEmail As ComboBox
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents CustomersBindingSource2 As BindingSource
End Class
