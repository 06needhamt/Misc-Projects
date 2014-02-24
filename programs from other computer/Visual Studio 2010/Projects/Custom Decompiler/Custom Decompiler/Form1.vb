Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog
        Dim FileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FileName = fd.FileName
            drpPath.Text = FileName
        End If
    End Sub

    Private Sub cmdExit_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click
        If MessageBox.Show(Me, "Are You Sure You Want To Exit?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            Me.Focus()
        End If
    End Sub

    Private Sub cmdDecompile_Click(sender As System.Object, e As System.EventArgs) Handles cmdDecompile.Click
        Throw New NotImplementedException
    End Sub
End Class
