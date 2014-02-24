Option Explicit On
Option Strict On

Public Class Form1

    Private Sub HandledError1()
        Dim test As Short

        Try
            test = 16000
            test *= test
        Catch ex1 As Exception
            MsgBox("We caught an exception in the sub: " & vbCrLf & ex1.ToString)
            Exit Sub
        Finally
            MsgBox("We are in finally.")
        End Try
        MsgBox("We are after the Try.")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HandledError1()
    End Sub

End Class