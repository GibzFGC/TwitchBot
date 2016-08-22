<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwitchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TwitchForm))
        Me.TwitchData1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'TwitchData1
        '
        Me.TwitchData1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TwitchData1.FormattingEnabled = True
        Me.TwitchData1.Location = New System.Drawing.Point(0, 0)
        Me.TwitchData1.Name = "TwitchData1"
        Me.TwitchData1.Size = New System.Drawing.Size(508, 235)
        Me.TwitchData1.TabIndex = 1
        '
        'TwitchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 235)
        Me.Controls.Add(Me.TwitchData1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TwitchForm"
        Me.Text = "TwitchBot"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TwitchData1 As ListBox
End Class
