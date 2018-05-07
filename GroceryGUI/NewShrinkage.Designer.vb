<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewShrinkage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GEDataSet = New GroceryGUI.GEDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InventoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New GroceryGUI.GEDataSetTableAdapters.InventoryTableAdapter()
        Me.InventoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shrinkage ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SKU:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 330)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Shrink Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 453)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 411)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Details:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(307, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(101, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 408)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(101, 367)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(137, 20)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(101, 450)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 20)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(101, 327)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 20)
        Me.TextBox5.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(101, 286)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(137, 20)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(101, 130)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(137, 20)
        Me.TextBox7.TabIndex = 15
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(101, 89)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(137, 20)
        Me.TextBox8.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(246, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add to Shrinkage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GEDataSet
        '
        Me.GEDataSet.DataSetName = "GEDataSet"
        Me.GEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIDDataGridViewTextBoxColumn, Me.SKUDataGridViewTextBoxColumn, Me.InventoryCountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InventoryBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 160)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(283, 117)
        Me.DataGridView1.TabIndex = 18
        '
        'InventoryBindingSource1
        '
        Me.InventoryBindingSource1.DataMember = "Inventory"
        Me.InventoryBindingSource1.DataSource = Me.GEDataSet
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.GEDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'InventoryIDDataGridViewTextBoxColumn
        '
        Me.InventoryIDDataGridViewTextBoxColumn.DataPropertyName = "inventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.HeaderText = "Inventory ID"
        Me.InventoryIDDataGridViewTextBoxColumn.Name = "InventoryIDDataGridViewTextBoxColumn"
        Me.InventoryIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryIDDataGridViewTextBoxColumn.Width = 70
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 54
        '
        'InventoryCountDataGridViewTextBoxColumn
        '
        Me.InventoryCountDataGridViewTextBoxColumn.DataPropertyName = "inventoryCount"
        Me.InventoryCountDataGridViewTextBoxColumn.HeaderText = "Inventory Count"
        Me.InventoryCountDataGridViewTextBoxColumn.Name = "InventoryCountDataGridViewTextBoxColumn"
        Me.InventoryCountDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryCountDataGridViewTextBoxColumn.Width = 103
        '
        'frmNewShrinkage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 534)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewShrinkage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Shrinkage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.GEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GEDataSet As GEDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As GEDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents InventoryBindingSource1 As BindingSource
    Friend WithEvents InventoryIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryCountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
