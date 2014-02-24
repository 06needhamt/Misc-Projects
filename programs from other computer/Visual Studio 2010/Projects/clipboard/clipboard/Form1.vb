Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        TextBox1.Text = "A"
        Call CopyText(TextBox1.Text)
    End Sub

    Public Sub CopyText(ByVal text As String)
        Clipboard.GetText(TextDataFormat.Text)
        TextBox1.Text = text
        Clipboard.SetText(text)
        Call PasteText(TextBox1.Text)
    End Sub

    Public Sub PasteText(ByVal text As String)
        Clipboard.ContainsText(TextDataFormat.Text)

    End Sub

End Class
