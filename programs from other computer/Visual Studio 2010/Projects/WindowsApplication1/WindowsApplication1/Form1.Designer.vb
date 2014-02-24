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
        Me.cmdChangeAllignment = New System.Windows.Forms.Button()
        Me.txtChangeAllignment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdChangeAllignment
        '
        Me.cmdChangeAllignment.Location = New System.Drawing.Point(63, 115)
        Me.cmdChangeAllignment.Name = "cmdChangeAllignment"
        Me.cmdChangeAllignment.Size = New System.Drawing.Size(158, 23)
        Me.cmdChangeAllignment.TabIndex = 0
        Me.cmdChangeAllignment.Text = "Change allignment"
        Me.cmdChangeAllignment.UseVisualStyleBackColor = True
        '
        'txtChangeAllignment
        '
        Me.txtChangeAllignment.Location = New System.Drawing.Point(92, 48)
        Me.txtChangeAllignment.Name = "txtChangeAllignment"
        Me.txtChangeAllignment.Size = New System.Drawing.Size(100, 20)
        Me.txtChangeAllignment.TabIndex = 1
        Me.txtChangeAllignment.Text = "Hello"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtChangeAllignment)
        Me.Controls.Add(Me.cmdChangeAllignment)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdChangeAllignment As System.Windows.Forms.Button
    Friend WithEvents txtChangeAllignment As System.Windows.Forms.TextBox

End Class
