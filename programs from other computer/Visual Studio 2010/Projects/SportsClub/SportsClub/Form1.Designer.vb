<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblMemberLength = New System.Windows.Forms.Label()
        Me.txtMemberLength = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(51, 29)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(54, 13)
        Me.lblAge.TabIndex = 0
        Me.lblAge.Text = "Enter Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(54, 62)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(51, 20)
        Me.txtAge.TabIndex = 1
        '
        'lblMemberLength
        '
        Me.lblMemberLength.AutoSize = True
        Me.lblMemberLength.Location = New System.Drawing.Point(131, 29)
        Me.lblMemberLength.Name = "lblMemberLength"
        Me.lblMemberLength.Size = New System.Drawing.Size(133, 13)
        Me.lblMemberLength.TabIndex = 2
        Me.lblMemberLength.Text = "Enter Member Ship Length"
        '
        'txtMemberLength
        '
        Me.txtMemberLength.Location = New System.Drawing.Point(134, 62)
        Me.txtMemberLength.Name = "txtMemberLength"
        Me.txtMemberLength.Size = New System.Drawing.Size(130, 20)
        Me.txtMemberLength.TabIndex = 3
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(346, 62)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(10, 13)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 320)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtMemberLength)
        Me.Controls.Add(Me.lblMemberLength)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblMemberLength As System.Windows.Forms.Label
    Friend WithEvents txtMemberLength As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label

End Class
