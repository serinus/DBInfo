Public Class Form1

    Public DataTable2TableAdapter As New DataSet1TableAdapters.DataTable2TableAdapter()

    Private Sub TextBox_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Validated, TextBox2.Validated, TextBox3.Validated, TextBox4.Validated, TextBox5.Validated
        If sender.Tag = sender.Text Then Exit Sub
        sender.Tag = sender.Text
        Me.DataTableFill()
    End Sub

    Private Sub DataTableFill()
        If (TextBox1.Tag + TextBox2.Tag + TextBox3.Tag + TextBox4.Tag + TextBox5.Tag).Length > 0 Then
            Dim d As DataSet1 = BindingSource1.DataSource
            DataTable2TableAdapter.Fill(dataTable:=d.DataTable2, TABLE_NAME:=Me.TextBox1.Tag, TABLE_TYPE:=Me.TextBox2.Tag, TAB_COMMENTS:=Me.TextBox3.Tag, COLUMN_NAME:=Me.TextBox4.Tag, COL_COMMENTS:=Me.TextBox5.Tag)
            Me.DataGridView1_FitWidth()
        End If
    End Sub

    Private Sub TextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Enter, TextBox2.Enter, TextBox3.Enter, TextBox4.Enter, TextBox5.Enter
        sender.SelectAll()
    End Sub

    Private Sub DataGridView1_FitWidth()
        Me.TextBox1.Width = DataGridView1.Columns(0).Width
        Me.TextBox2.Width = DataGridView1.Columns(1).Width
        Me.TextBox3.Width = DataGridView1.Columns(2).Width
        Me.TextBox4.Width = DataGridView1.Columns(3).Width
        Me.TextBox5.Width = DataGridView1.Columns(4).Width
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown, TextBox3.KeyDown, TextBox4.KeyDown, TextBox5.KeyDown
        If Not e.KeyCode = Keys.Enter Then Exit Sub
        Me.ValidateChildren()
        If Me.DataGridView1.RowCount = 0 Then Exit Sub
        Me.DataGridView1.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridView1_FitWidth()
        Me.TextBox1.Tag = String.Empty
        Me.TextBox2.Tag = String.Empty
        Me.TextBox3.Tag = String.Empty
        Me.TextBox4.Tag = String.Empty
        Me.TextBox5.Tag = String.Empty
        DataTable2TableAdapter.Connection.ConnectionString = My.Settings.ConnectionString
    End Sub

    Private Sub ログインLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ログインLToolStripMenuItem.Click
        LoginForm1.ShowDialog(Me)
    End Sub
End Class
