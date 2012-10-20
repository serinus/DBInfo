Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim sb As New System.Text.StringBuilder()
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "Data Source", Me.SidTextBox.Text)
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "User ID", Me.UsernameTextBox.Text)
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "Password", Me.PasswordTextBox.Text)
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "Unicode", "True")

        Dim oracleConnection As New OracleClient.OracleConnection()
        oracleConnection.ConnectionString = sb.ToString()
        Try
            oracleConnection.Open()
            Form1.DataTable2TableAdapter.Connection = oracleConnection
            My.Settings.ConnectionString = sb.ToString()
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
