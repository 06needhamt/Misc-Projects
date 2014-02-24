Public Class frmAbout

    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblVersion.Text = "Version " & Notepad.FileManipulation.CurrentVersion
        lblCurrentUser.Text = Notepad.Help.currentUser
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub lnkLblTerms_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLblTerms.LinkClicked
        MsgBox("EXAMPLE SOFTWARE TERMS")
    End Sub
End Class
