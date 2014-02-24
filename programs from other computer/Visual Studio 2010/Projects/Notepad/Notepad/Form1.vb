Imports System.IO
Public Class TextEditor

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        txtContent.Clear()
        txtContent.Focus()

    End Sub

    Private Sub txtContent_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContent.Click

        txtContent.Focus()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItem.Click
        MsgBox("Do You Want To save changes to this file?", MsgBoxStyle.Exclamation, "Save")

    End Sub

End Class
