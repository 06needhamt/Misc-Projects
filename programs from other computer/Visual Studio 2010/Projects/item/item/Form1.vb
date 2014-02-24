Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtNumber.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Call saveitem(txtItem.Text, txtNumber.Text, txtPrice.Text, drpStallNumber.Text)
        drpStallNumber.Text = ""
        txtItem.Clear()
        txtNumber.Clear()
        txtPrice.Clear()
        txtItem.Focus()
        MessageBox.Show("Item Sucessfully Saved")
    End Sub

    Public Sub saveitem(ByVal itemDescription, ByVal itemNumber, ByVal ItemPrice, ByVal StallNumber)
        Dim path As String = System.IO.Directory.GetCurrentDirectory()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub items_Click(sender As System.Object, e As System.EventArgs) Handles items.Click

    End Sub
End Class
