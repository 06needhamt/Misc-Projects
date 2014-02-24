Public Class FunctionLibary
#Region "Properties"
    Public Property Total As Object

#End Region
#Region "Numerical Operators"

    Public Function Add()

        Dim number1 As Integer
        Dim number2 As Integer

        Add = number1 + number2

    End Function

    Public Function Subtract()

        Dim number1 As Integer
        Dim number2 As Integer

        Subtract = number1 - number2

    End Function

    Public Function Multiply()

        Dim number1 As Integer
        Dim number2 As Integer

        Multiply = number1 * number2

    End Function

    Public Function Divide()

        Dim number1 As Integer
        Dim number2 As Integer

        Divide = number1 / number2

    End Function

#End Region

#Region "Methods"

    Public Sub Addbtn() Handles cmdAdd.click
        Call Add()
        txtTotal.text = Total

    End Sub

    Public Sub Subtractbtn() Handles cmdSubbtract.click
        Call Subtract()
        txtTotal.Text = Total
    End Sub
    Public Sub Multiplybtn() Handles cmdmultiply.click
        Call Multiply()
        txtTotal.text = Total
    End Sub
    Public Sub Dividebtn() Handles cmdDivide.click
        Call Divide()
        txtTotal.text = Total
    End Sub

    Public Sub SaveResults(ByVal Total)
        Dim writer As System.IO.StreamWriter = New System.IO.StreamWriter("C:\New\Result.txt", False)
        Do While Total >= 0
            writer.Write(Total.ToString)
            writer.WriteLine()
            writer.Close()
            Total = 0
            Exit Do
        Loop

    End Sub
#End Region

End Class
