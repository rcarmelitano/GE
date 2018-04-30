<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuickKey
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeyItem = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnBagel = New System.Windows.Forms.Button()
        Me.btnBreakfast = New System.Windows.Forms.Button()
        Me.btnLargeCoffee = New System.Windows.Forms.Button()
        Me.btnMediumCoffee = New System.Windows.Forms.Button()
        Me.btnSmallCoffee = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(465, 36)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Key Item:"
        '
        'txtKeyItem
        '
        Me.txtKeyItem.Location = New System.Drawing.Point(148, 91)
        Me.txtKeyItem.Name = "txtKeyItem"
        Me.txtKeyItem.Size = New System.Drawing.Size(163, 20)
        Me.txtKeyItem.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(317, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnBagel
        '
        Me.btnBagel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBagel.Location = New System.Drawing.Point(196, 167)
        Me.btnBagel.Name = "btnBagel"
        Me.btnBagel.Size = New System.Drawing.Size(73, 64)
        Me.btnBagel.TabIndex = 5
        Me.btnBagel.Text = "Bagel"
        Me.btnBagel.UseVisualStyleBackColor = True
        '
        'btnBreakfast
        '
        Me.btnBreakfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBreakfast.Location = New System.Drawing.Point(319, 167)
        Me.btnBreakfast.Name = "btnBreakfast"
        Me.btnBreakfast.Size = New System.Drawing.Size(73, 64)
        Me.btnBreakfast.TabIndex = 6
        Me.btnBreakfast.Text = "Breakfast Combo"
        Me.btnBreakfast.UseVisualStyleBackColor = True
        '
        'btnLargeCoffee
        '
        Me.btnLargeCoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLargeCoffee.Location = New System.Drawing.Point(319, 256)
        Me.btnLargeCoffee.Name = "btnLargeCoffee"
        Me.btnLargeCoffee.Size = New System.Drawing.Size(73, 64)
        Me.btnLargeCoffee.TabIndex = 9
        Me.btnLargeCoffee.Text = "Large Coffee"
        Me.btnLargeCoffee.UseVisualStyleBackColor = True
        '
        'btnMediumCoffee
        '
        Me.btnMediumCoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMediumCoffee.Location = New System.Drawing.Point(196, 256)
        Me.btnMediumCoffee.Name = "btnMediumCoffee"
        Me.btnMediumCoffee.Size = New System.Drawing.Size(73, 64)
        Me.btnMediumCoffee.TabIndex = 8
        Me.btnMediumCoffee.Text = "Medium Coffee"
        Me.btnMediumCoffee.UseVisualStyleBackColor = True
        '
        'btnSmallCoffee
        '
        Me.btnSmallCoffee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSmallCoffee.Location = New System.Drawing.Point(71, 256)
        Me.btnSmallCoffee.Name = "btnSmallCoffee"
        Me.btnSmallCoffee.Size = New System.Drawing.Size(73, 64)
        Me.btnSmallCoffee.TabIndex = 7
        Me.btnSmallCoffee.Text = "Small Coffee"
        Me.btnSmallCoffee.UseVisualStyleBackColor = True
        '
        'frmQuickKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 358)
        Me.Controls.Add(Me.btnLargeCoffee)
        Me.Controls.Add(Me.btnMediumCoffee)
        Me.Controls.Add(Me.btnSmallCoffee)
        Me.Controls.Add(Me.btnBreakfast)
        Me.Controls.Add(Me.btnBagel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtKeyItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmQuickKey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quick Key"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeyItem As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnBagel As Button
    Friend WithEvents btnBreakfast As Button
    Friend WithEvents btnLargeCoffee As Button
    Friend WithEvents btnMediumCoffee As Button
    Friend WithEvents btnSmallCoffee As Button

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the current form and display the checkoutForm
        frmCheckoutForm.Show()
        Me.Close()
    End Sub
End Class
