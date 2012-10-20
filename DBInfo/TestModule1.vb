Module TestModule1

    Public Sub TestOracleConnectionStringBuilder()
        Dim sb As New System.Text.StringBuilder()
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "Data Source", "SC")
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "User ID", "PROST")
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "Password", "PROST")
        OracleClient.OracleConnectionStringBuilder.AppendKeyValuePair(sb, "Unicode", "True")
        Debug.Assert("Data Source=SC;User ID=PROST;Password=PROST;Unicode=True" = sb.ToString())
    End Sub


End Module
