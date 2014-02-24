Imports System.Drawing
Public Class Form1
    ' GRAPHIC VARIABLES

    Dim G As Graphics
    Dim BBG As Graphics
    Dim BB As Bitmap
    Dim r As Rectangle

    ' FPS COUNTER

    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 0
    Dim MaxTicks As Integer = 0

    'GAME RUNNING

    Dim IsRunning As Boolean = True

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()

        'INITIALISE GRAPHICS OBJECTS
        G = Me.CreateGraphics
        BB = New Bitmap(Me.Width, Me.Height)

        StartGameLoop()
    End Sub
    Private Sub StartGameLoop()
        Do While IsRunning = True
            Application.DoEvents()

        Loop
    End Sub
    Private Sub TickCounter()
        If tSec = TimeOfDay.Second And IsRunning = True Then
            tTicks = tTicks + 1
        Else
            MaxTicks = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
        End If
    End Sub
End Class

