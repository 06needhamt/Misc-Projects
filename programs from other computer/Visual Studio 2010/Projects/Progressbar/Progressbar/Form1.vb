Public Class Form1

    Dim C As Object

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 100
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                MsgBox("Finished!")
            End If
        End If
        If ProgressBar1.Maximum() Then


        End If

    End Sub



    Private Sub FileOpen()
        If ProgressBar1.Value = ProgressBar1.Maximum Then

        End If

        'Declaration
    End Sub
    Public Shared Sub FileOpen( _
     FileNumber As Integer, _
     FileName As String, _
     Mode As OpenMode, _
     Access As OpenAccess, _
     Share As OpenShare, _
     RecordLength As Integer _
    )


    End Sub

    Private Sub Runtime(C As Object)
        Throw New NotImplementedException
    End Sub

End Class
