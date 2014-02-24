Imports System

Public Class MyException

    Inherits System.Exception

#Region "Declarations"
    Public Name As String = "Toms Exception"
    Public Information As String
    Public line As Long
#End Region

#Region "Functions"

#End Region

#Region "Methods"

#End Region

#Region "Dependencies"


    Public Sub New()

        Call Newinstance()


    End Sub

    Public Function  Newinstance()
        Newinstance = New MyException
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#End Region

End Class
