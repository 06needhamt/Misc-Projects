<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.drpPath = New System.Windows.Forms.ComboBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdDecompile = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.drpLanguage = New System.Windows.Forms.ComboBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'drpPath
        '
        Me.drpPath.FormattingEnabled = True
        Me.drpPath.Location = New System.Drawing.Point(67, 63)
        Me.drpPath.Name = "drpPath"
        Me.drpPath.Size = New System.Drawing.Size(121, 21)
        Me.drpPath.TabIndex = 0
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(197, 61)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(75, 23)
        Me.cmdBrowse.TabIndex = 1
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(25, 177)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdDecompile
        '
        Me.cmdDecompile.Location = New System.Drawing.Point(175, 177)
        Me.cmdDecompile.Name = "cmdDecompile"
        Me.cmdDecompile.Size = New System.Drawing.Size(75, 23)
        Me.cmdDecompile.TabIndex = 3
        Me.cmdDecompile.Text = "Decompile"
        Me.cmdDecompile.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(5, 66)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(56, 13)
        Me.lblFile.TabIndex = 4
        Me.lblFile.Text = "Select File"
        '
        'drpLanguage
        '
        Me.drpLanguage.FormattingEnabled = True
        Me.drpLanguage.Items.AddRange(New Object() {"VB.net", "C#.net", "C++", "C", "Java"})
        Me.drpLanguage.Location = New System.Drawing.Point(67, 119)
        Me.drpLanguage.Name = "drpLanguage"
        Me.drpLanguage.Size = New System.Drawing.Size(121, 21)
        Me.drpLanguage.TabIndex = 5
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(5, 122)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(55, 13)
        Me.lblLanguage.TabIndex = 6
        Me.lblLanguage.Text = "Language"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.drpLanguage)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.cmdDecompile)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.drpPath)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents drpPath As System.Windows.Forms.ComboBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdDecompile As System.Windows.Forms.Button
    Friend WithEvents lblFile As System.Windows.Forms.Label
    Friend WithEvents drpLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents lblLanguage As System.Windows.Forms.Label

End Class
