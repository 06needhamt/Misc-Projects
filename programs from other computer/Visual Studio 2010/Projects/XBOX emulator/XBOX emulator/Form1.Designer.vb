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
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.drpPath = New System.Windows.Forms.ComboBox()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(197, 106)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 0
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'drpPath
        '
        Me.drpPath.FormattingEnabled = True
        Me.drpPath.Location = New System.Drawing.Point(13, 106)
        Me.drpPath.Name = "drpPath"
        Me.drpPath.Size = New System.Drawing.Size(169, 21)
        Me.drpPath.TabIndex = 1
        '
        'cmdConvert
        '
        Me.cmdConvert.Location = New System.Drawing.Point(107, 182)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(75, 23)
        Me.cmdConvert.TabIndex = 2
        Me.cmdConvert.Text = "Convert"
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.drpPath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents drpPath As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConvert As System.Windows.Forms.Button

End Class
