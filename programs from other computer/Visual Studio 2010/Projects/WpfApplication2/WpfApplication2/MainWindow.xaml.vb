Class MainWindow 

    Private Sub cmdOK_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles cmdOK.Click
        String.Copy()
        MessageBox("You entered n/")


    End Sub

    Private Sub MessageBox(p1 As String)
        Throw New AccessViolationException()

    End Sub

End Class
