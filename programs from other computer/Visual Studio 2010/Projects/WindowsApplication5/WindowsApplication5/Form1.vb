Public Class Form1
    Dim thread1 As System.Threading.Thread
    Dim thread2 As System.Threading.Thread
    Dim thread3 As System.Threading.Thread
    Dim thread4 As System.Threading.Thread

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Call Loop1()


    End Sub
    Public Sub Loop1()
        Dim isrunning As Boolean
        isrunning = True
        Do Until isrunning = False
            For index = 1 To 9999
                For index2 = 1 To 9999
                    For index3 = 1 To 9999
                        For index4 = 1 To 9999
                            For index5 = 1 To 9999
                                Call Loop2()


                            Next

                        Next

                    Next

                Next

            Next
        Loop
    End Sub

    Public Sub Loop2()
        Dim isrunning As Boolean
        isrunning = True
        Do Until isrunning = False
            For index = 1 To 9999
                For index2 = 1 To 9999
                    For index3 = 1 To 9999
                        For index4 = 1 To 9999
                            For index5 = 1 To 9999
                                Call Loop3()


                            Next

                        Next

                    Next

                Next

            Next
        Loop
    End Sub

    Public Sub Loop3()
        Dim isrunning As Boolean
        isrunning = True
        Do Until isrunning = False
            For index = 1 To 9999
                For index2 = 1 To 9999
                    For index3 = 1 To 9999
                        For index4 = 1 To 9999
                            For index5 = 1 To 9999
                                Call Loop4()

                            Next

                        Next

                    Next

                Next

            Next
        Loop
    End Sub
    Public Sub Loop4()
        Dim isrunning As Boolean
        isrunning = True
        Do Until isrunning = False
            For index = 1 To 9999
                For index2 = 1 To 9999
                    For index3 = 1 To 9999
                        For index4 = 1 To 9999
                            For index5 = 1 To 9999
                                Call Loop1()


                            Next

                        Next

                    Next

                Next

            Next
        Loop
    End Sub
End Class
