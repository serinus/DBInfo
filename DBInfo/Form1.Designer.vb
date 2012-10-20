<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New DBInfo.DataSet1
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.接続CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ログインLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridView1 = New DBInfo.UserControl1
        Me.TABLENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABLETYPEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABCOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COLUMNNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COLCOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABCOLCOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 19)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Location = New System.Drawing.Point(200, 0)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 19)
        Me.TextBox2.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox3)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox5)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(625, 38)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox3.Location = New System.Drawing.Point(400, 0)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 19)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox4.Location = New System.Drawing.Point(0, 19)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 19)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox5.Location = New System.Drawing.Point(200, 19)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 19)
        Me.TextBox5.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.接続CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '接続CToolStripMenuItem
        '
        Me.接続CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ログインLToolStripMenuItem})
        Me.接続CToolStripMenuItem.Name = "接続CToolStripMenuItem"
        Me.接続CToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.接続CToolStripMenuItem.Text = "接続(&C)"
        '
        'ログインLToolStripMenuItem
        '
        Me.ログインLToolStripMenuItem.Name = "ログインLToolStripMenuItem"
        Me.ログインLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ログインLToolStripMenuItem.Text = "ログイン(&L)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TABLENAMEDataGridViewTextBoxColumn, Me.TABLETYPEDataGridViewTextBoxColumn, Me.TABCOMMENTSDataGridViewTextBoxColumn, Me.COLUMNNAMEDataGridViewTextBoxColumn, Me.COLCOMMENTSDataGridViewTextBoxColumn, Me.TABCOLCOMMENTSDataGridViewTextBoxColumn, Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn, Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "DataTable2"
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(625, 282)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 0
        '
        'TABLENAMEDataGridViewTextBoxColumn
        '
        Me.TABLENAMEDataGridViewTextBoxColumn.DataPropertyName = "TABLE_NAME"
        Me.TABLENAMEDataGridViewTextBoxColumn.HeaderText = "TABLE_NAME"
        Me.TABLENAMEDataGridViewTextBoxColumn.Name = "TABLENAMEDataGridViewTextBoxColumn"
        Me.TABLENAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TABLENAMEDataGridViewTextBoxColumn.Width = 102
        '
        'TABLETYPEDataGridViewTextBoxColumn
        '
        Me.TABLETYPEDataGridViewTextBoxColumn.DataPropertyName = "TABLE_TYPE"
        Me.TABLETYPEDataGridViewTextBoxColumn.HeaderText = "TABLE_TYPE"
        Me.TABLETYPEDataGridViewTextBoxColumn.Name = "TABLETYPEDataGridViewTextBoxColumn"
        Me.TABLETYPEDataGridViewTextBoxColumn.ReadOnly = True
        Me.TABLETYPEDataGridViewTextBoxColumn.Width = 98
        '
        'TABCOMMENTSDataGridViewTextBoxColumn
        '
        Me.TABCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "TAB_COMMENTS"
        Me.TABCOMMENTSDataGridViewTextBoxColumn.HeaderText = "TAB_COMMENTS"
        Me.TABCOMMENTSDataGridViewTextBoxColumn.Name = "TABCOMMENTSDataGridViewTextBoxColumn"
        Me.TABCOMMENTSDataGridViewTextBoxColumn.ReadOnly = True
        Me.TABCOMMENTSDataGridViewTextBoxColumn.Width = 120
        '
        'COLUMNNAMEDataGridViewTextBoxColumn
        '
        Me.COLUMNNAMEDataGridViewTextBoxColumn.DataPropertyName = "COLUMN_NAME"
        Me.COLUMNNAMEDataGridViewTextBoxColumn.HeaderText = "COLUMN_NAME"
        Me.COLUMNNAMEDataGridViewTextBoxColumn.Name = "COLUMNNAMEDataGridViewTextBoxColumn"
        Me.COLUMNNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.COLUMNNAMEDataGridViewTextBoxColumn.Width = 113
        '
        'COLCOMMENTSDataGridViewTextBoxColumn
        '
        Me.COLCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "COL_COMMENTS"
        Me.COLCOMMENTSDataGridViewTextBoxColumn.HeaderText = "COL_COMMENTS"
        Me.COLCOMMENTSDataGridViewTextBoxColumn.Name = "COLCOMMENTSDataGridViewTextBoxColumn"
        Me.COLCOMMENTSDataGridViewTextBoxColumn.ReadOnly = True
        Me.COLCOMMENTSDataGridViewTextBoxColumn.Width = 119
        '
        'TABCOLCOMMENTSDataGridViewTextBoxColumn
        '
        Me.TABCOLCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "TAB_COL_COMMENTS"
        Me.TABCOLCOMMENTSDataGridViewTextBoxColumn.HeaderText = "TAB_COL_COMMENTS"
        Me.TABCOLCOMMENTSDataGridViewTextBoxColumn.Name = "TABCOLCOMMENTSDataGridViewTextBoxColumn"
        Me.TABCOLCOMMENTSDataGridViewTextBoxColumn.ReadOnly = True
        Me.TABCOLCOMMENTSDataGridViewTextBoxColumn.Width = 146
        '
        'TABLENAMECOMMENTSDataGridViewTextBoxColumn
        '
        Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "TABLE_NAME_COMMENTS"
        Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn.HeaderText = "TABLE_NAME_COMMENTS"
        Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn.Name = "TABLENAMECOMMENTSDataGridViewTextBoxColumn"
        Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn.ReadOnly = True
        Me.TABLENAMECOMMENTSDataGridViewTextBoxColumn.Width = 169
        '
        'COLUMNNAMECOMMENTSDataGridViewTextBoxColumn
        '
        Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "COLUMN_NAME_COMMENTS"
        Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn.HeaderText = "COLUMN_NAME_COMMENTS"
        Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn.Name = "COLUMNNAMECOMMENTSDataGridViewTextBoxColumn"
        Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn.ReadOnly = True
        Me.COLUMNNAMECOMMENTSDataGridViewTextBoxColumn.Width = 180
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 344)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As UserControl1
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As DBInfo.DataSet1
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TABLENAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLETYPEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABCOMMENTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLUMNNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLCOMMENTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABCOLCOMMENTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLENAMECOMMENTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COLUMNNAMECOMMENTSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 接続CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ログインLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
