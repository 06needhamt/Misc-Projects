Public Class frmHelp
    'FAQCode
    Private Sub btnNotepadFAQ_Click(sender As System.Object, e As System.EventArgs) Handles btnNotepadFAQ.Click
        UncheckAllBtns()
        btnNotepadFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.ntpdHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub btnEditingFAQ_Click(sender As System.Object, e As System.EventArgs) Handles btnEditingFAQ.Click
        UncheckAllBtns()
        btnEditingFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.editHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub btnPrintingFAQ_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintingFAQ.Click
        UncheckAllBtns()
        btnPrintingFAQ.Checked = True
        Notepad.FileManipulation.OpenRTFResource(My.Resources.printingHelpFile, rtfHelpDisplay)
    End Sub
    Private Sub UncheckAllBtns()
        btnEditingFAQ.Checked = False
        btnPrintingFAQ.Checked = False
        btnNotepadFAQ.Checked = False
    End Sub

    'Support code
    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        Notepad.Help.sendUserRequest(txtProblem.Text, txtEmail.Text)
        Me.Close()
    End Sub
    Private Sub txtEmail_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmail.TextChanged
        If txtEmail.Text = "" Or txtProblem.Text = "" Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If
    End Sub
    Private Sub txtProblem_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProblem.TextChanged
        If txtEmail.Text = "" Or txtProblem.Text = "" Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If
    End Sub


End Class