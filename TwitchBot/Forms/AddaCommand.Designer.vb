<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddaCommand
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
        Me.CancelBtn1 = New System.Windows.Forms.Button()
        Me.SaveBtn1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValueTxt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CommandTxt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelBtn1
        '
        Me.CancelBtn1.Location = New System.Drawing.Point(114, 93)
        Me.CancelBtn1.Name = "CancelBtn1"
        Me.CancelBtn1.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn1.TabIndex = 13
        Me.CancelBtn1.Text = "Cancel"
        Me.CancelBtn1.UseVisualStyleBackColor = True
        '
        'SaveBtn1
        '
        Me.SaveBtn1.Location = New System.Drawing.Point(195, 93)
        Me.SaveBtn1.Name = "SaveBtn1"
        Me.SaveBtn1.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn1.TabIndex = 12
        Me.SaveBtn1.Text = "Save"
        Me.SaveBtn1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Value:"
        '
        'ValueTxt1
        '
        Me.ValueTxt1.Location = New System.Drawing.Point(78, 67)
        Me.ValueTxt1.Name = "ValueTxt1"
        Me.ValueTxt1.Size = New System.Drawing.Size(192, 20)
        Me.ValueTxt1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Command:"
        '
        'CommandTxt1
        '
        Me.CommandTxt1.Location = New System.Drawing.Point(78, 34)
        Me.CommandTxt1.Name = "CommandTxt1"
        Me.CommandTxt1.Size = New System.Drawing.Size(192, 20)
        Me.CommandTxt1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Add a command to the bot."
        '
        'AddaCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 124)
        Me.Controls.Add(Me.CancelBtn1)
        Me.Controls.Add(Me.SaveBtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ValueTxt1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CommandTxt1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddaCommand"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add a Command"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn1 As Button
    Friend WithEvents SaveBtn1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ValueTxt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CommandTxt1 As TextBox
    Friend WithEvents Label1 As Label
End Class
