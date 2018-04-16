<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewShipping
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
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateShipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewShipments = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.txtShipAddressOne = New System.Windows.Forms.TextBox()
        Me.txtShipAddressTwo = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZIP = New System.Windows.Forms.TextBox()
        Me.txtTrackingNumber = New System.Windows.Forms.TextBox()
        Me.cmbCouriers = New System.Windows.Forms.ComboBox()
        Me.btnCreateShipment = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.rdoBtnLocalYes = New System.Windows.Forms.RadioButton()
        Me.rdoBtnLocalNo = New System.Windows.Forms.RadioButton()
        Me.dtpTimeOfDelivery = New System.Windows.Forms.DateTimePicker()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.UpdateShipmentToolStripMenuItem, Me.mnuViewShipments})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'UpdateShipmentToolStripMenuItem
        '
        Me.UpdateShipmentToolStripMenuItem.Name = "UpdateShipmentToolStripMenuItem"
        Me.UpdateShipmentToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.UpdateShipmentToolStripMenuItem.Text = "Update Shipment"
        '
        'mnuViewShipments
        '
        Me.mnuViewShipments.Name = "mnuViewShipments"
        Me.mnuViewShipments.Size = New System.Drawing.Size(103, 20)
        Me.mnuViewShipments.Text = "View Shipments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Shipping Address 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Shipping Address 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "City:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tracking Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ZIP:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "State:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Couriers:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Local Delivery?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Time of Delivery:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Shipping Price:"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(118, 51)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(166, 20)
        Me.txtOrderID.TabIndex = 17
        '
        'txtShipAddressOne
        '
        Me.txtShipAddressOne.Location = New System.Drawing.Point(118, 103)
        Me.txtShipAddressOne.Name = "txtShipAddressOne"
        Me.txtShipAddressOne.Size = New System.Drawing.Size(166, 20)
        Me.txtShipAddressOne.TabIndex = 18
        '
        'txtShipAddressTwo
        '
        Me.txtShipAddressTwo.Location = New System.Drawing.Point(118, 129)
        Me.txtShipAddressTwo.Name = "txtShipAddressTwo"
        Me.txtShipAddressTwo.Size = New System.Drawing.Size(166, 20)
        Me.txtShipAddressTwo.TabIndex = 19
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(118, 155)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(166, 20)
        Me.txtCity.TabIndex = 20
        '
        'txtZIP
        '
        Me.txtZIP.Location = New System.Drawing.Point(118, 207)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.Size = New System.Drawing.Size(166, 20)
        Me.txtZIP.TabIndex = 22
        '
        'txtTrackingNumber
        '
        Me.txtTrackingNumber.Location = New System.Drawing.Point(118, 77)
        Me.txtTrackingNumber.Name = "txtTrackingNumber"
        Me.txtTrackingNumber.Size = New System.Drawing.Size(166, 20)
        Me.txtTrackingNumber.TabIndex = 24
        '
        'cmbCouriers
        '
        Me.cmbCouriers.Enabled = False
        Me.cmbCouriers.FormattingEnabled = True
        Me.cmbCouriers.Items.AddRange(New Object() {"Fed-Ex", "UPS", "USPS"})
        Me.cmbCouriers.Location = New System.Drawing.Point(119, 286)
        Me.cmbCouriers.Name = "cmbCouriers"
        Me.cmbCouriers.Size = New System.Drawing.Size(166, 21)
        Me.cmbCouriers.TabIndex = 29
        '
        'btnCreateShipment
        '
        Me.btnCreateShipment.Location = New System.Drawing.Point(126, 373)
        Me.btnCreateShipment.Name = "btnCreateShipment"
        Me.btnCreateShipment.Size = New System.Drawing.Size(107, 36)
        Me.btnCreateShipment.TabIndex = 30
        Me.btnCreateShipment.Text = "Create Shipment"
        Me.btnCreateShipment.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(117, 332)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(167, 23)
        Me.lblPrice.TabIndex = 31
        '
        'rdoBtnLocalYes
        '
        Me.rdoBtnLocalYes.AutoSize = True
        Me.rdoBtnLocalYes.Location = New System.Drawing.Point(118, 260)
        Me.rdoBtnLocalYes.Name = "rdoBtnLocalYes"
        Me.rdoBtnLocalYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoBtnLocalYes.TabIndex = 32
        Me.rdoBtnLocalYes.TabStop = True
        Me.rdoBtnLocalYes.Text = "Yes"
        Me.rdoBtnLocalYes.UseVisualStyleBackColor = True
        '
        'rdoBtnLocalNo
        '
        Me.rdoBtnLocalNo.AutoSize = True
        Me.rdoBtnLocalNo.Location = New System.Drawing.Point(194, 260)
        Me.rdoBtnLocalNo.Name = "rdoBtnLocalNo"
        Me.rdoBtnLocalNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoBtnLocalNo.TabIndex = 33
        Me.rdoBtnLocalNo.TabStop = True
        Me.rdoBtnLocalNo.Text = "No"
        Me.rdoBtnLocalNo.UseVisualStyleBackColor = True
        '
        'dtpTimeOfDelivery
        '
        Me.dtpTimeOfDelivery.Location = New System.Drawing.Point(117, 234)
        Me.dtpTimeOfDelivery.Name = "dtpTimeOfDelivery"
        Me.dtpTimeOfDelivery.Size = New System.Drawing.Size(179, 20)
        Me.dtpTimeOfDelivery.TabIndex = 34
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois", "Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana", "Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania", "Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming"})
        Me.cmbState.Location = New System.Drawing.Point(119, 180)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(165, 21)
        Me.cmbState.TabIndex = 35
        '
        'frmNewShipping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 418)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.dtpTimeOfDelivery)
        Me.Controls.Add(Me.rdoBtnLocalNo)
        Me.Controls.Add(Me.rdoBtnLocalYes)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCreateShipment)
        Me.Controls.Add(Me.cmbCouriers)
        Me.Controls.Add(Me.txtTrackingNumber)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtShipAddressTwo)
        Me.Controls.Add(Me.txtShipAddressOne)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmNewShipping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Shipment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuViewShipments As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtShipAddressOne As TextBox
    Friend WithEvents txtShipAddressTwo As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZIP As TextBox
    Friend WithEvents txtTrackingNumber As TextBox
    Friend WithEvents cmbCouriers As ComboBox
    Friend WithEvents btnCreateShipment As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents rdoBtnLocalYes As RadioButton
    Friend WithEvents rdoBtnLocalNo As RadioButton
    Friend WithEvents UpdateShipmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dtpTimeOfDelivery As DateTimePicker
    Friend WithEvents cmbState As ComboBox
End Class
