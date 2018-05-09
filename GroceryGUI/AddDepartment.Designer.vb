<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddDepartment
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
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDepartmentName = New System.Windows.Forms.TextBox()
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCreateDepartment = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBack, Me.mnuUpdate})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(365, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(52, 24)
        Me.mnuBack.Text = "Back"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(70, 24)
        Me.mnuUpdate.Text = "Update"
        Me.mnuUpdate.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department Name:"
        '
        'txtDepartmentName
        '
        Me.txtDepartmentName.Location = New System.Drawing.Point(176, 124)
        Me.txtDepartmentName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDepartmentName.Name = "txtDepartmentName"
        Me.txtDepartmentName.Size = New System.Drawing.Size(132, 22)
        Me.txtDepartmentName.TabIndex = 2
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Enabled = False
        Me.txtDepartmentID.Location = New System.Drawing.Point(176, 62)
        Me.txtDepartmentID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.ReadOnly = True
        Me.txtDepartmentID.Size = New System.Drawing.Size(132, 22)
        Me.txtDepartmentID.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Department ID:"
        '
        'btnCreateDepartment
        '
        Me.btnCreateDepartment.Location = New System.Drawing.Point(73, 181)
        Me.btnCreateDepartment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateDepartment.Name = "btnCreateDepartment"
        Me.btnCreateDepartment.Size = New System.Drawing.Size(236, 60)
        Me.btnCreateDepartment.TabIndex = 5
        Me.btnCreateDepartment.Text = "Create Department"
        Me.btnCreateDepartment.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(73, 181)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(236, 60)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update Department"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'frmAddDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 261)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCreateDepartment)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDepartmentName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAddDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Department"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuBack As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateDepartment As Button
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents btnUpdate As Button
End Class
