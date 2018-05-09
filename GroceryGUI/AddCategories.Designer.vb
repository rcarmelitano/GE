<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCategories
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
        Me.mnuUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.btnCreateCategory = New System.Windows.Forms.Button()
        Me.txtDepartmentID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCategoryID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateCategory = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.mnuUpdate})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'mnuUpdate
        '
        Me.mnuUpdate.Name = "mnuUpdate"
        Me.mnuUpdate.Size = New System.Drawing.Size(70, 24)
        Me.mnuUpdate.Text = "Update"
        Me.mnuUpdate.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Category Name:"
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Location = New System.Drawing.Point(199, 145)
        Me.txtCategoryName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(203, 22)
        Me.txtCategoryName.TabIndex = 3
        '
        'btnCreateCategory
        '
        Me.btnCreateCategory.Location = New System.Drawing.Point(127, 203)
        Me.btnCreateCategory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCreateCategory.Name = "btnCreateCategory"
        Me.btnCreateCategory.Size = New System.Drawing.Size(236, 60)
        Me.btnCreateCategory.TabIndex = 5
        Me.btnCreateCategory.Text = "Create Category"
        Me.btnCreateCategory.UseVisualStyleBackColor = True
        '
        'txtDepartmentID
        '
        Me.txtDepartmentID.Location = New System.Drawing.Point(199, 100)
        Me.txtDepartmentID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDepartmentID.Name = "txtDepartmentID"
        Me.txtDepartmentID.Size = New System.Drawing.Size(203, 22)
        Me.txtDepartmentID.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Department ID:"
        '
        'txtCategoryID
        '
        Me.txtCategoryID.Enabled = False
        Me.txtCategoryID.Location = New System.Drawing.Point(199, 55)
        Me.txtCategoryID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCategoryID.Name = "txtCategoryID"
        Me.txtCategoryID.ReadOnly = True
        Me.txtCategoryID.Size = New System.Drawing.Size(203, 22)
        Me.txtCategoryID.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Category ID:"
        '
        'btnUpdateCategory
        '
        Me.btnUpdateCategory.Enabled = False
        Me.btnUpdateCategory.Location = New System.Drawing.Point(127, 203)
        Me.btnUpdateCategory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdateCategory.Name = "btnUpdateCategory"
        Me.btnUpdateCategory.Size = New System.Drawing.Size(236, 60)
        Me.btnUpdateCategory.TabIndex = 10
        Me.btnUpdateCategory.Text = "Update Category"
        Me.btnUpdateCategory.UseVisualStyleBackColor = True
        Me.btnUpdateCategory.Visible = False
        '
        'frmAddCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 278)
        Me.Controls.Add(Me.btnUpdateCategory)
        Me.Controls.Add(Me.txtCategoryID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDepartmentID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCreateCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCategoryName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAddCategories"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add a Category"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents btnCreateCategory As Button
    Friend WithEvents txtDepartmentID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategoryID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuUpdate As ToolStripMenuItem
    Friend WithEvents btnUpdateCategory As Button
End Class
