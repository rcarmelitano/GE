<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCampType
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
        Me.lblCampType = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCampTypeName = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCampType
        '
        Me.lblCampType.AutoSize = True
        Me.lblCampType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCampType.Location = New System.Drawing.Point(12, 56)
        Me.lblCampType.Name = "lblCampType"
        Me.lblCampType.Size = New System.Drawing.Size(148, 16)
        Me.lblCampType.TabIndex = 0
        Me.lblCampType.Text = "Campaign Type Name:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Button1.Location = New System.Drawing.Point(112, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Type"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCampTypeName
        '
        Me.txtCampTypeName.Location = New System.Drawing.Point(166, 56)
        Me.txtCampTypeName.Name = "txtCampTypeName"
        Me.txtCampTypeName.Size = New System.Drawing.Size(162, 20)
        Me.txtCampTypeName.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Button2.Location = New System.Drawing.Point(112, 147)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NewCampType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 233)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtCampTypeName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCampType)
        Me.Name = "NewCampType"
        Me.Text = "Add Campaign Type"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCampType As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCampTypeName As TextBox
    Friend WithEvents Button2 As Button
End Class
