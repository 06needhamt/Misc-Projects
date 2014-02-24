Imports System.Drawing.Graphics
Imports System.GC

Public Class Form1
    Dim g As Graphics
    Dim map(20, 20, 20) As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CreateGraphics()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub


    Public Sub memtest()

        Labelmem.Text = System.GC.GetTotalMemory(True)
        Me.Refresh()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Call createmap()
        Call memtest()
        If System.GC.GetTotalMemory(True) >= 900000 Then
            MessageBox.Show("Out of memory program must halt")
            End
        End If

        Me.Refresh()

    End Sub

    Public Sub createmap()
        map(1, 0, 0) = 1
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
