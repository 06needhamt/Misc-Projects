Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Static Price As String

    End Sub

    Private Sub txtAge_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAge.TextChanged
        Dim Junior As Object
        Dim Senior As Object
        Dim Veteran As Object
        Dim Customer As Object
        Static Price As String
        If txtAge.Text <= "18" Then Customer = Junior
        If txtAge.Text >= "19" Or txtAge.Text <= "49" Then Customer = Senior
        If txtAge.Text >= "50" Then Customer = Veteran

        If Customer Is Junior Then Price = "£30"
        If Customer Is Senior Then Price = "£50"
        If Customer Is Veteran Then Price = "£40"




    End Sub

    Private Sub txtMemberLength_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMemberLength.TextChanged
        Dim Junior As Object
        Dim Senior As Object
        Dim Veteran As Object
        Dim Customer As Object
        Dim Price As Integer

        If Customer = Junior And txtMemberLength.Text >= "2" Then Price = "£20"
        If Customer = Senior And txtMemberLength.Text >= "5" Then Price = "£30"
        If Customer = Veteran And txtMemberLength.Text >= "10" Then Price = "£25"


    End Sub

    Private Sub lblPrice_Click(sender As System.Object, e As System.EventArgs) Handles lblPrice.Click

    End Sub
End Class
