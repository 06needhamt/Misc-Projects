Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            MessageBox.Show("1")
        End If

        If CheckBox2.Checked = True Then
            MessageBox.Show("2")
        End If

    End Sub
End Class
