<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateShipping
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
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnCreateShipment = New System.Windows.Forms.Button()
        Me.txtTimeDelivered = New System.Windows.Forms.TextBox()
        Me.txtZIP = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtShipAddressTwo = New System.Windows.Forms.TextBox()
        Me.txtShipAddressOne = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewShipments = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCourier = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.lblTrackingNumber = New System.Windows.Forms.Label()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.Location = New System.Drawing.Point(117, 289)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(167, 23)
        Me.lblPrice.TabIndex = 56
        '
        'btnCreateShipment
        '
        Me.btnCreateShipment.Location = New System.Drawing.Point(126, 332)
        Me.btnCreateShipment.Name = "btnCreateShipment"
        Me.btnCreateShipment.Size = New System.Drawing.Size(107, 36)
        Me.btnCreateShipment.TabIndex = 55
        Me.btnCreateShipment.Text = "Create Shipment"
        Me.btnCreateShipment.UseVisualStyleBackColor = True
        '
        'txtTimeDelivered
        '
        Me.txtTimeDelivered.Location = New System.Drawing.Point(118, 233)
        Me.txtTimeDelivered.Name = "txtTimeDelivered"
        Me.txtTimeDelivered.Size = New System.Drawing.Size(166, 20)
        Me.txtTimeDelivered.TabIndex = 53
        '
        'txtZIP
        '
        Me.txtZIP.Location = New System.Drawing.Point(119, 207)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.Size = New System.Drawing.Size(166, 20)
        Me.txtZIP.TabIndex = 51
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(119, 155)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(166, 20)
        Me.txtCity.TabIndex = 49
        '
        'txtShipAddressTwo
        '
        Me.txtShipAddressTwo.Location = New System.Drawing.Point(119, 129)
        Me.txtShipAddressTwo.Name = "txtShipAddressTwo"
        Me.txtShipAddressTwo.Size = New System.Drawing.Size(166, 20)
        Me.txtShipAddressTwo.TabIndex = 48
        '
        'txtShipAddressOne
        '
        Me.txtShipAddressOne.Location = New System.Drawing.Point(119, 103)
        Me.txtShipAddressOne.Name = "txtShipAddressOne"
        Me.txtShipAddressOne.Size = New System.Drawing.Size(166, 20)
        Me.txtShipAddressOne.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 293)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Shipping Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Couriers:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Time Delivered:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "ZIP:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "State:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "City:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Shipping Address 2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Shipping Address 1:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.mnuViewShipments})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(359, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'mnuViewShipments
        '
        Me.mnuViewShipments.Name = "mnuViewShipments"
        Me.mnuViewShipments.Size = New System.Drawing.Size(103, 20)
        Me.mnuViewShipments.Text = "View Shipments"
        '
        'lblCourier
        '
        Me.lblCourier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourier.Location = New System.Drawing.Point(117, 260)
        Me.lblCourier.Name = "lblCourier"
        Me.lblCourier.Size = New System.Drawing.Size(167, 23)
        Me.lblCourier.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Tracking Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Order ID:"
        '
        'lblOrderID
        '
        Me.lblOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrderID.Location = New System.Drawing.Point(119, 44)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(167, 23)
        Me.lblOrderID.TabIndex = 62
        '
        'lblTrackingNumber
        '
        Me.lblTrackingNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrackingNumber.Location = New System.Drawing.Point(119, 73)
        Me.lblTrackingNumber.Name = "lblTrackingNumber"
        Me.lblTrackingNumber.Size = New System.Drawing.Size(167, 23)
        Me.lblTrackingNumber.TabIndex = 61
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois", "Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana", "Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania", "Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming"})
        Me.cmbState.Location = New System.Drawing.Point(119, 180)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(167, 21)
        Me.cmbState.TabIndex = 63
        '
        'frmUpdateShipping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 377)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.lblTrackingNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCourier)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnCreateShipment)
        Me.Controls.Add(Me.txtTimeDelivered)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtShipAddressTwo)
        Me.Controls.Add(Me.txtShipAddressOne)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUpdateShipping"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipment Update"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnCreateShipment As Button
    Friend WithEvents txtTimeDelivered As TextBox
    Friend WithEvents txtZIP As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtShipAddressTwo As TextBox
    Friend WithEvents txtShipAddressOne As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuClose As ToolStripMenuItem
    Friend WithEvents mnuViewShipments As ToolStripMenuItem
    Friend WithEvents lblCourier As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOrderID As Label
    Friend WithEvents lblTrackingNumber As Label
    Friend WithEvents cmbState As ComboBox
End Class
