Public Class UserControl1

    Public Overrides Function GetClipboardContent() As DataObject
        Dim clipboardContent As DataObject = MyBase.GetClipboardContent()
        If clipboardContent Is Nothing Then Return Nothing
        Dim text As String = clipboardContent.GetText(TextDataFormat.Text)
        Return New DataObject(DataFormats.Text, text)
    End Function

End Class
