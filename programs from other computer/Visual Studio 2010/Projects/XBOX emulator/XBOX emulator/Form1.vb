Public Class Form1
    Dim FileName As String
    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        Dim fd As OpenFileDialog = New OpenFileDialog


        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Xbox Executable file(.XEX)|*.XEX"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            FileName = fd.FileName
            drpPath.Text = FileName
        End If
    End Sub

    Private Sub cmdConvert_Click(sender As System.Object, e As System.EventArgs) Handles cmdConvert.Click
        Dim reader1 As New System.IO.StreamReader(FileName, True)
        reader1.ReadToEnd()
        Dim writer1 As New System.IO.StreamWriter("C:/New/file.exe", False)
        writer1.Write(FileName)
        reader1.Dispose()
        writer1.Dispose()

    End Sub
End Class
