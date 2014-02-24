Public Class MainWindow
    Public Shared isrunning As Boolean
    Private Sub Window_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        isrunning = True
        Do While isrunning = True
            Do
                Application.Main
            Loop
        Loop
    End Sub

End Class
