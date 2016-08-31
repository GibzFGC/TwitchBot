<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteaCommand
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
        Me.DeleteBtn1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CommandTxt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CancelBtn1
        '
        Me.CancelBtn1.Location = New System.Drawing.Point(114, 66)
        Me.CancelBtn1.Name = "CancelBtn1"
        Me.CancelBtn1.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn1.TabIndex = 18
        Me.CancelBtn1.Text = "Cancel"
        Me.CancelBtn1.UseVisualStyleBackColor = True
        '
        'DeleteBtn1
        '
        Me.DeleteBtn1.Location = New System.Drawing.Point(195, 66)
        Me.DeleteBtn1.Name = "DeleteBtn1"
        Me.DeleteBtn1.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn1.TabIndex = 17
        Me.DeleteBtn1.Text = "Delete"
        Me.DeleteBtn1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Command:"
        '
        'CommandTxt1
        '
        Me.CommandTxt1.Location = New System.Drawing.Point(78, 36)
        Me.CommandTxt1.Name = "CommandTxt1"
        Me.CommandTxt1.Size = New System.Drawing.Size(192, 20)
        Me.CommandTxt1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Delete a command to the bot."
        '
        'DeleteaCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 98)
        Me.Controls.Add(Me.CancelBtn1)
        Me.Controls.Add(Me.DeleteBtn1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CommandTxt1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeleteaCommand"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete a Command"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelBtn1 As Button
    Friend WithEvents DeleteBtn1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CommandTxt1 As TextBox
    Friend WithEvents Label1 As Label
End Class
