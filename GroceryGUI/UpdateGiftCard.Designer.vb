<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateGiftCard
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
        Me.txtGiftCardID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudCardTotal = New System.Windows.Forms.NumericUpDown()
        Me.btnRefillGiftCard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateOfPurchase = New System.Windows.Forms.DateTimePicker()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.nudCardTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtGiftCardID
        '
        Me.txtGiftCardID.Enabled = False
        Me.txtGiftCardID.Location = New System.Drawing.Point(110, 43)
        Me.txtGiftCardID.Name = "txtGiftCardID"
        Me.txtGiftCardID.ReadOnly = True
        Me.txtGiftCardID.Size = New System.Drawing.Size(113, 20)
        Me.txtGiftCardID.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Gift Card ID:"
        '
        'nudCardTotal
        '
        Me.nudCardTotal.DecimalPlaces = 2
        Me.nudCardTotal.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudCardTotal.Location = New System.Drawing.Point(110, 167)
        Me.nudCardTotal.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudCardTotal.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudCardTotal.Name = "nudCardTotal"
        Me.nudCardTotal.ReadOnly = True
        Me.nudCardTotal.Size = New System.Drawing.Size(213, 20)
        Me.nudCardTotal.TabIndex = 83
        Me.nudCardTotal.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'btnRefillGiftCard
        '
        Me.btnRefillGiftCard.Location = New System.Drawing.Point(122, 209)
        Me.btnRefillGiftCard.Name = "btnRefillGiftCard"
        Me.btnRefillGiftCard.Size = New System.Drawing.Size(134, 33)
        Me.btnRefillGiftCard.TabIndex = 79
        Me.btnRefillGiftCard.Text = "Refill Gift Card"
        Me.btnRefillGiftCard.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Card Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Date of Purchase:"
        '
        'dtpDateOfPurchase
        '
        Me.dtpDateOfPurchase.Enabled = False
        Me.dtpDateOfPurchase.Location = New System.Drawing.Point(110, 125)
        Me.dtpDateOfPurchase.Name = "dtpDateOfPurchase"
        Me.dtpDateOfPurchase.Size = New System.Drawing.Size(213, 20)
        Me.dtpDateOfPurchase.TabIndex = 76
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(110, 84)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(113, 20)
        Me.txtCustomerID.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Customer ID:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(378, 24)
        Me.MenuStrip1.TabIndex = 86
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'frmUpdateGiftCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 247)
        Me.Controls.Add(Me.txtGiftCardID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudCardTotal)
        Me.Controls.Add(Me.btnRefillGiftCard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateOfPurchase)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmUpdateGiftCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gift Card Refill"
        CType(Me.nudCardTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGiftCardID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nudCardTotal As NumericUpDown
    Friend WithEvents btnRefillGiftCard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateOfPurchase As DateTimePicker
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
End Class
