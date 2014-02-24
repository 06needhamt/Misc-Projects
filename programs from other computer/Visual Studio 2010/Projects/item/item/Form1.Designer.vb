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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.drpStallNumber = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.items = New System.Windows.Forms.Button()
        Me.lst256 = New System.Windows.Forms.ListBox()
        Me.lst436 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(90, 159)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(90, 74)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(183, 20)
        Me.txtItem.TabIndex = 1
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(90, 48)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(183, 20)
        Me.txtNumber.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(90, 100)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(183, 20)
        Me.txtPrice.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item Price"
        '
        'drpStallNumber
        '
        Me.drpStallNumber.FormattingEnabled = True
        Me.drpStallNumber.Items.AddRange(New Object() {"256", "436"})
        Me.drpStallNumber.Location = New System.Drawing.Point(79, 13)
        Me.drpStallNumber.Name = "drpStallNumber"
        Me.drpStallNumber.Size = New System.Drawing.Size(178, 21)
        Me.drpStallNumber.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Stall Number"
        '
        'items
        '
        Me.items.Location = New System.Drawing.Point(90, 206)
        Me.items.Name = "items"
        Me.items.Size = New System.Drawing.Size(75, 23)
        Me.items.TabIndex = 9
        Me.items.Text = "items"
        Me.items.UseVisualStyleBackColor = True
        '
        'lst256
        '
        Me.lst256.FormattingEnabled = True
        Me.lst256.Location = New System.Drawing.Point(280, 13)
        Me.lst256.Name = "lst256"
        Me.lst256.Size = New System.Drawing.Size(120, 225)
        Me.lst256.TabIndex = 10
        '
        'lst436
        '
        Me.lst436.FormattingEnabled = True
        Me.lst436.Location = New System.Drawing.Point(406, 13)
        Me.lst436.Name = "lst436"
        Me.lst436.Size = New System.Drawing.Size(120, 225)
        Me.lst436.TabIndex = 11
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 262)
        Me.Controls.Add(Me.lst436)
        Me.Controls.Add(Me.lst256)
        Me.Controls.Add(Me.items)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.drpStallNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents drpStallNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents items As System.Windows.Forms.Button
    Friend WithEvents lst256 As System.Windows.Forms.ListBox
    Friend WithEvents lst436 As System.Windows.Forms.ListBox

End Class
