<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleCalculator
    Inherits System.Windows.Forms.Form

   
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.cmdPlusButton = New System.Windows.Forms.Button()
        Me.cmdMinusButton = New System.Windows.Forms.Button()
        Me.cmdMultiplyButton = New System.Windows.Forms.Button()
        Me.cmdDivideButton = New System.Windows.Forms.Button()
        Me.cmdClearButton = New System.Windows.Forms.Button()
        Me.cmdQuitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.Location = New System.Drawing.Point(37, 36)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(44, 26)
        Me.lblFirstNumber.TabIndex = 0
        Me.lblFirstNumber.Text = "First" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.AutoSize = True
        Me.lblSecondNumber.Location = New System.Drawing.Point(122, 36)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(44, 26)
        Me.lblSecondNumber.TabIndex = 1
        Me.lblSecondNumber.Text = "Second" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(40, 78)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(41, 20)
        Me.txtFirstNumber.TabIndex = 2
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(125, 78)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(41, 20)
        Me.txtSecondNumber.TabIndex = 3
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(40, 128)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(126, 160)
        Me.lstResults.TabIndex = 4
        '
        'cmdPlusButton
        '
        Me.cmdPlusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPlusButton.Location = New System.Drawing.Point(254, 38)
        Me.cmdPlusButton.Name = "cmdPlusButton"
        Me.cmdPlusButton.Size = New System.Drawing.Size(44, 44)
        Me.cmdPlusButton.TabIndex = 5
        Me.cmdPlusButton.Text = "+"
        Me.cmdPlusButton.UseVisualStyleBackColor = True
        '
        'cmdMinusButton
        '
        Me.cmdMinusButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinusButton.Location = New System.Drawing.Point(254, 88)
        Me.cmdMinusButton.Name = "cmdMinusButton"
        Me.cmdMinusButton.Size = New System.Drawing.Size(44, 44)
        Me.cmdMinusButton.TabIndex = 6
        Me.cmdMinusButton.Text = "-"
        Me.cmdMinusButton.UseVisualStyleBackColor = True
        '
        'cmdMultiplyButton
        '
        Me.cmdMultiplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMultiplyButton.Location = New System.Drawing.Point(254, 138)
        Me.cmdMultiplyButton.Name = "cmdMultiplyButton"
        Me.cmdMultiplyButton.Size = New System.Drawing.Size(44, 44)
        Me.cmdMultiplyButton.TabIndex = 7
        Me.cmdMultiplyButton.Text = "*"
        Me.cmdMultiplyButton.UseVisualStyleBackColor = True
        '
        'cmdDivideButton
        '
        Me.cmdDivideButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDivideButton.Location = New System.Drawing.Point(254, 188)
        Me.cmdDivideButton.Name = "cmdDivideButton"
        Me.cmdDivideButton.Size = New System.Drawing.Size(44, 44)
        Me.cmdDivideButton.TabIndex = 8
        Me.cmdDivideButton.Text = "/"
        Me.cmdDivideButton.UseVisualStyleBackColor = True
        '
        'cmdClearButton
        '
        Me.cmdClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearButton.Location = New System.Drawing.Point(189, 244)
        Me.cmdClearButton.Name = "cmdClearButton"
        Me.cmdClearButton.Size = New System.Drawing.Size(73, 44)
        Me.cmdClearButton.TabIndex = 9
        Me.cmdClearButton.Text = "Clear"
        Me.cmdClearButton.UseVisualStyleBackColor = True
        '
        'cmdQuitButton
        '
        Me.cmdQuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuitButton.Location = New System.Drawing.Point(297, 244)
        Me.cmdQuitButton.Name = "cmdQuitButton"
        Me.cmdQuitButton.Size = New System.Drawing.Size(70, 44)
        Me.cmdQuitButton.TabIndex = 10
        Me.cmdQuitButton.Text = "Quit"
        Me.cmdQuitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(450, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Result"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(399, 162)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 12
        '
        'frmSimpleCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 313)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdQuitButton)
        Me.Controls.Add(Me.cmdClearButton)
        Me.Controls.Add(Me.cmdDivideButton)
        Me.Controls.Add(Me.cmdMultiplyButton)
        Me.Controls.Add(Me.cmdMinusButton)
        Me.Controls.Add(Me.cmdPlusButton)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Name = "frmSimpleCalculator"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstNumber As System.Windows.Forms.Label
    Friend WithEvents lblSecondNumber As System.Windows.Forms.Label
    Friend WithEvents txtFirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents cmdPlusButton As System.Windows.Forms.Button
    Friend WithEvents cmdMinusButton As System.Windows.Forms.Button
    Friend WithEvents cmdMultiplyButton As System.Windows.Forms.Button
    Friend WithEvents cmdDivideButton As System.Windows.Forms.Button
    Friend WithEvents cmdClearButton As System.Windows.Forms.Button
    Friend WithEvents cmdQuitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub txtFirstNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFirstNumber.TextChanged
        Dim FirstNumber As String
        FirstNumber = txtFirstNumber.Text
    End Sub

    Private Sub txtSecondNumber_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSecondNumber.TextChanged
        Dim SecondNumber As String
        SecondNumber = txtSecondNumber.Text
    End Sub

    Private Sub cmdPlusButton_Click(sender As System.Object, e As System.EventArgs) Handles cmdPlusButton.Click
        Dim Total, Number1, Number2 As Double
        Number1 = txtFirstNumber.Text
        Number2 = txtSecondNumber.Text
        Total = Number1 + Number2
        txtResult.Text = Number1 & " + " & Number2 & " = " & Total
        lstResults.Items.Add(txtResult.Text)
        lstResults.Text = ""
        txtResult.Focus()
    End Sub

    Private Sub cmdMinusButton_Click(sender As System.Object, e As System.EventArgs) Handles cmdMinusButton.Click
        Dim Total, Number1, Number2 As Double
        Number1 = txtFirstNumber.Text
        Number2 = txtSecondNumber.Text
        Total = Number1 - Number2
        txtResult.Text = Number1 & " - " & Number2 & " = " & Total
        lstResults.Items.Add(txtResult.Text)
        lstResults.Text = ""
        txtResult.Focus()
    End Sub

    Private Sub cmdMultiplyButton_Click(sender As System.Object, e As System.EventArgs) Handles cmdMultiplyButton.Click
        Dim Total, Number1, Number2 As Double
        Number1 = txtFirstNumber.Text
        Number2 = txtSecondNumber.Text
        Total = Number1 * Number2
        txtResult.Text = Number1 & " * " & Number2 & " = " & Total
        lstResults.Items.Add(txtResult.Text)
        lstResults.Text = ""
        txtResult.Focus()

    End Sub

    Private Sub cmdDivideButton_Click(sender As System.Object, e As System.EventArgs) Handles cmdDivideButton.Click
        Dim Total, Number1, Number2 As Double
        Number1 = txtFirstNumber.Text
        Number2 = txtSecondNumber.Text
        Total = Number1 / Number2
        txtResult.Text = Number1 & " / " & Number2 & " = " & Total
        lstResults.Items.Add(txtResult.Text)
        lstResults.Text = ""
        txtResult.Focus()
    End Sub

    Friend WithEvents txtResult As System.Windows.Forms.TextBox

    Private Sub cmdClearButton_Click(sender As System.Object, e As System.EventArgs) Handles cmdClearButton.Click
        txtResult.SelectAll()
        txtResult.Copy()
        txtResult.Clear()
        txtFirstNumber.Clear()
        txtSecondNumber.Clear()
        lstResults.ClearSelected()
        

    End Sub

    Private Sub cmdQuitButton_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuitButton.Click
        End
    End Sub

End Class
