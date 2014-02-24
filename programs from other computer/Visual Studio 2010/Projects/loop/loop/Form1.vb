Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        For one = 1 To 1000
            TextBox1.Text = "a"
        Next

        For two = 1 To 1000
            lSam()

            TextBox1.Text = "b"
        Next

        For three = 1 To 1000
            TextBox1.Text = "c"
        Next
        For four = 1 To 1000
            TextBox1.Text = "d"
        Next
        For five = 1 To 1000
            TextBox1.Text = "e"
        Next

        For six = 1 To 1000
            TextBox1.Text = "f"
        Next
        For seven = 1 To 1000
            TextBox1.Text = "g"
        Next
        For eight = 1 To 1000
            TextBox1.Text = "h"
        Next


    End Sub

    Private Function lSam() As Integer
        Do
            Do
                Do
                    Do
                        Do
                            Do
                                TextBox1.Visible = False
                            Loop
                        Loop
                    Loop
                Loop
            Loop
        Loop
    End Function

End Class
