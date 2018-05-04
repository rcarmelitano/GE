<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSupplier
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
        Me.chkInactive = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuhistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddressOne = New System.Windows.Forms.TextBox()
        Me.txtAddressTwo = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.lblsupplierID = New System.Windows.Forms.Label()
        Me.lblCO = New System.Windows.Forms.Label()
        Me.lblFR = New System.Windows.Forms.Label()
        Me.lblLM = New System.Windows.Forms.Label()
        Me.lblPH = New System.Windows.Forms.Label()
        Me.lblCT = New System.Windows.Forms.Label()
        Me.lblAD1 = New System.Windows.Forms.Label()
        Me.lblST = New System.Windows.Forms.Label()
        Me.lblZP = New System.Windows.Forms.Label()
        Me.lblFX = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.btnsave2 = New System.Windows.Forms.Button()
        Me.txtstate = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkInactive
        '
        Me.chkInactive.AutoSize = True
        Me.chkInactive.Enabled = False
        Me.chkInactive.Location = New System.Drawing.Point(12, 24)
        Me.chkInactive.Name = "chkInactive"
        Me.chkInactive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkInactive.Size = New System.Drawing.Size(73, 17)
        Me.chkInactive.TabIndex = 0
        Me.chkInactive.Text = "   Inactive"
        Me.chkInactive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contact First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Contact Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address 2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Address 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 250)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Phone:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "City:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "State:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(106, 425)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ZIP:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuhistory, Me.UpdateToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(648, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(44, 20)
        Me.mnuBack.Text = "Back"
        '
        'mnuhistory
        '
        Me.mnuhistory.Name = "mnuhistory"
        Me.mnuhistory.Size = New System.Drawing.Size(57, 20)
        Me.mnuhistory.Text = "History"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 460)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Notes:"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Enabled = False
        Me.txtCompanyName.Location = New System.Drawing.Point(139, 71)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.ReadOnly = True
        Me.txtCompanyName.Size = New System.Drawing.Size(143, 20)
        Me.txtCompanyName.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(139, 107)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(143, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(139, 142)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(143, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(139, 177)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(143, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtAddressOne
        '
        Me.txtAddressOne.Enabled = False
        Me.txtAddressOne.Location = New System.Drawing.Point(139, 282)
        Me.txtAddressOne.Name = "txtAddressOne"
        Me.txtAddressOne.ReadOnly = True
        Me.txtAddressOne.Size = New System.Drawing.Size(143, 20)
        Me.txtAddressOne.TabIndex = 8
        '
        'txtAddressTwo
        '
        Me.txtAddressTwo.Enabled = False
        Me.txtAddressTwo.Location = New System.Drawing.Point(139, 317)
        Me.txtAddressTwo.Name = "txtAddressTwo"
        Me.txtAddressTwo.ReadOnly = True
        Me.txtAddressTwo.Size = New System.Drawing.Size(143, 20)
        Me.txtAddressTwo.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(139, 352)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(143, 20)
        Me.txtCity.TabIndex = 10
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Location = New System.Drawing.Point(139, 457)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ReadOnly = True
        Me.txtNotes.Size = New System.Drawing.Size(291, 123)
        Me.txtNotes.TabIndex = 13
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(0, 595)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(648, 63)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Enabled = False
        Me.txtSupplierID.Location = New System.Drawing.Point(139, 45)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.ReadOnly = True
        Me.txtSupplierID.Size = New System.Drawing.Size(143, 20)
        Me.txtSupplierID.TabIndex = 1
        '
        'lblsupplierID
        '
        Me.lblsupplierID.AutoSize = True
        Me.lblsupplierID.Location = New System.Drawing.Point(76, 48)
        Me.lblsupplierID.Name = "lblsupplierID"
        Me.lblsupplierID.Size = New System.Drawing.Size(54, 13)
        Me.lblsupplierID.TabIndex = 0
        Me.lblsupplierID.Text = "supplierID"
        '
        'lblCO
        '
        Me.lblCO.AutoSize = True
        Me.lblCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCO.Location = New System.Drawing.Point(22, 71)
        Me.lblCO.Name = "lblCO"
        Me.lblCO.Size = New System.Drawing.Size(20, 25)
        Me.lblCO.TabIndex = 15
        Me.lblCO.Text = "*"
        '
        'lblFR
        '
        Me.lblFR.AutoSize = True
        Me.lblFR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFR.Location = New System.Drawing.Point(12, 110)
        Me.lblFR.Name = "lblFR"
        Me.lblFR.Size = New System.Drawing.Size(20, 25)
        Me.lblFR.TabIndex = 16
        Me.lblFR.Text = "*"
        '
        'lblLM
        '
        Me.lblLM.AutoSize = True
        Me.lblLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLM.Location = New System.Drawing.Point(12, 145)
        Me.lblLM.Name = "lblLM"
        Me.lblLM.Size = New System.Drawing.Size(20, 25)
        Me.lblLM.TabIndex = 17
        Me.lblLM.Text = "*"
        '
        'lblPH
        '
        Me.lblPH.AutoSize = True
        Me.lblPH.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPH.Location = New System.Drawing.Point(69, 212)
        Me.lblPH.Name = "lblPH"
        Me.lblPH.Size = New System.Drawing.Size(20, 25)
        Me.lblPH.TabIndex = 19
        Me.lblPH.Text = "*"
        '
        'lblCT
        '
        Me.lblCT.AutoSize = True
        Me.lblCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCT.Location = New System.Drawing.Point(80, 352)
        Me.lblCT.Name = "lblCT"
        Me.lblCT.Size = New System.Drawing.Size(20, 25)
        Me.lblCT.TabIndex = 20
        Me.lblCT.Text = "*"
        '
        'lblAD1
        '
        Me.lblAD1.AutoSize = True
        Me.lblAD1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAD1.Location = New System.Drawing.Point(50, 282)
        Me.lblAD1.Name = "lblAD1"
        Me.lblAD1.Size = New System.Drawing.Size(20, 25)
        Me.lblAD1.TabIndex = 21
        Me.lblAD1.Text = "*"
        '
        'lblST
        '
        Me.lblST.AutoSize = True
        Me.lblST.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblST.Location = New System.Drawing.Point(72, 387)
        Me.lblST.Name = "lblST"
        Me.lblST.Size = New System.Drawing.Size(20, 25)
        Me.lblST.TabIndex = 22
        Me.lblST.Text = "*"
        '
        'lblZP
        '
        Me.lblZP.AutoSize = True
        Me.lblZP.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZP.Location = New System.Drawing.Point(80, 422)
        Me.lblZP.Name = "lblZP"
        Me.lblZP.Size = New System.Drawing.Size(20, 25)
        Me.lblZP.TabIndex = 23
        Me.lblZP.Text = "*"
        '
        'lblFX
        '
        Me.lblFX.AutoSize = True
        Me.lblFX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFX.Location = New System.Drawing.Point(80, 247)
        Me.lblFX.Name = "lblFX"
        Me.lblFX.Size = New System.Drawing.Size(20, 25)
        Me.lblFX.TabIndex = 24
        Me.lblFX.Text = "*"
        '
        'txtPhone
        '
        Me.txtPhone.Enabled = False
        Me.txtPhone.Location = New System.Drawing.Point(139, 212)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(143, 20)
        Me.txtPhone.TabIndex = 25
        '
        'txtZip
        '
        Me.txtZip.Enabled = False
        Me.txtZip.Location = New System.Drawing.Point(139, 422)
        Me.txtZip.Mask = "00000"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(143, 20)
        Me.txtZip.TabIndex = 26
        '
        'txtFax
        '
        Me.txtFax.Enabled = False
        Me.txtFax.Location = New System.Drawing.Point(139, 250)
        Me.txtFax.Mask = "(999) 000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(143, 20)
        Me.txtFax.TabIndex = 27
        '
        'btnsave2
        '
        Me.btnsave2.Enabled = False
        Me.btnsave2.Location = New System.Drawing.Point(0, 592)
        Me.btnsave2.Name = "btnsave2"
        Me.btnsave2.Size = New System.Drawing.Size(648, 63)
        Me.btnsave2.TabIndex = 28
        Me.btnsave2.Text = "Update"
        Me.btnsave2.UseVisualStyleBackColor = True
        '
        'txtstate
        '
        Me.txtstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtstate.Enabled = False
        Me.txtstate.FormattingEnabled = True
        Me.txtstate.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.txtstate.Location = New System.Drawing.Point(139, 387)
        Me.txtstate.Name = "txtstate"
        Me.txtstate.Size = New System.Drawing.Size(143, 21)
        Me.txtstate.TabIndex = 29
        '
        'NewSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 655)
        Me.Controls.Add(Me.txtstate)
        Me.Controls.Add(Me.btnsave2)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblFX)
        Me.Controls.Add(Me.lblZP)
        Me.Controls.Add(Me.lblST)
        Me.Controls.Add(Me.lblAD1)
        Me.Controls.Add(Me.lblCT)
        Me.Controls.Add(Me.lblPH)
        Me.Controls.Add(Me.lblLM)
        Me.Controls.Add(Me.lblFR)
        Me.Controls.Add(Me.lblCO)
        Me.Controls.Add(Me.txtSupplierID)
        Me.Controls.Add(Me.lblsupplierID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddressTwo)
        Me.Controls.Add(Me.txtAddressOne)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkInactive)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "NewSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkInactive As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents mnuhistory As ToolStripMenuItem
	Friend WithEvents Label12 As Label
	Friend WithEvents txtCompanyName As TextBox
	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents txtLastName As TextBox
	Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddressOne As TextBox
    Friend WithEvents txtAddressTwo As TextBox
	Friend WithEvents txtCity As TextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnUpdate As Button
	Friend WithEvents txtSupplierID As TextBox
	Friend WithEvents lblsupplierID As Label
	Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblCO As Label
	Friend WithEvents lblFR As Label
	Friend WithEvents lblLM As Label
	Friend WithEvents lblPH As Label
	Friend WithEvents lblCT As Label
	Friend WithEvents lblAD1 As Label
	Friend WithEvents lblST As Label
	Friend WithEvents lblZP As Label
	Friend WithEvents lblFX As Label
	Friend WithEvents txtPhone As MaskedTextBox
	Friend WithEvents txtZip As MaskedTextBox
	Friend WithEvents txtFax As MaskedTextBox
	Friend WithEvents btnsave2 As Button
	Friend WithEvents txtstate As ComboBox
End Class
