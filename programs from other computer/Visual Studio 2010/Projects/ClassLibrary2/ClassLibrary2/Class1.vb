Option Explicit On
Public Class Class1

    Declare Function AddNumbers Lib "Example.dll" _
    (ByVal a As Double, ByVal b As Double) As Double

    Sub Main()
        Dim Result As Double
        Result = AddNumbers(1, 2)
        Debug.Print("The result was: " & Result)
    End Sub

End Class
