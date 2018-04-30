<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employeesupdate
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HekoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TextBox6 = New System.Windows.Forms.MaskedTextBox()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(62, 40)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "EmployeeID:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(47, 223)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(82, 13)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Employee DOB:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(34, 190)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(95, 13)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Secondary Phone:"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(51, 151)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(78, 13)
		Me.Label6.TabIndex = 5
		Me.Label6.Text = "Priamry Phone:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(68, 114)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 13)
		Me.Label7.TabIndex = 6
		Me.Label7.Text = "Last Name:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(69, 77)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(60, 13)
		Me.Label8.TabIndex = 7
		Me.Label8.Text = "First Name:"
		'
		'TextBox1
		'
		Me.TextBox1.Enabled = False
		Me.TextBox1.Location = New System.Drawing.Point(147, 37)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 8
		'
		'TextBox2
		'
		Me.TextBox2.Enabled = False
		Me.TextBox2.Location = New System.Drawing.Point(147, 74)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 9
		'
		'TextBox3
		'
		Me.TextBox3.Enabled = False
		Me.TextBox3.Location = New System.Drawing.Point(147, 111)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.ReadOnly = True
		Me.TextBox3.Size = New System.Drawing.Size(100, 20)
		Me.TextBox3.TabIndex = 10
		'
		'TextBox4
		'
		Me.TextBox4.Enabled = False
		Me.TextBox4.Location = New System.Drawing.Point(147, 148)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.ReadOnly = True
		Me.TextBox4.Size = New System.Drawing.Size(100, 20)
		Me.TextBox4.TabIndex = 11
		'
		'TextBox5
		'
		Me.TextBox5.Enabled = False
		Me.TextBox5.Location = New System.Drawing.Point(147, 185)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.ReadOnly = True
		Me.TextBox5.Size = New System.Drawing.Size(100, 20)
		Me.TextBox5.TabIndex = 12
		'
		'Button1
		'
		Me.Button1.Enabled = False
		Me.Button1.Location = New System.Drawing.Point(12, 275)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(264, 39)
		Me.Button1.TabIndex = 14
		Me.Button1.Text = "Save"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.HekoToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(288, 24)
		Me.MenuStrip1.TabIndex = 15
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'UpdateToolStripMenuItem
		'
		Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
		Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
		Me.UpdateToolStripMenuItem.Text = "Update"
		'
		'HekoToolStripMenuItem
		'
		Me.HekoToolStripMenuItem.Name = "HekoToolStripMenuItem"
		Me.HekoToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HekoToolStripMenuItem.Text = "Help"
		'
		'TextBox6
		'
		Me.TextBox6.Enabled = False
		Me.TextBox6.Location = New System.Drawing.Point(147, 223)
		Me.TextBox6.Mask = "00/00/0000"
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.ReadOnly = True
		Me.TextBox6.Size = New System.Drawing.Size(100, 20)
		Me.TextBox6.TabIndex = 16
		Me.TextBox6.ValidatingType = GetType(Date)
		'
		'Employeesupdate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(288, 326)
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Employeesupdate"
		Me.Text = "Employees"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HekoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox6 As MaskedTextBox
End Class
