Imports System.Text
Public Class frmMathsGame
    Dim Time As Integer


    Private Sub frmMathsGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Question(0 To 20) As String


        Select Case Question
            Case 1

        End Select


        txtQuestion.Text = Question(0)


        Timer1.Start()
        Timer1.Enabled = True
        Time = 0
        txtQuestion.Text = Question(1)


    End Sub


    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        txtTime.Text = Time
        Timer1.Enabled = False


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Time = Time + 1
        txtTime.Text = Time.ToString


    End Sub



End Class


