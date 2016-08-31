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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TwitchForm))
        Me.TwitchData1 = New System.Windows.Forms.ListBox()
        Me.RightClickMenu1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetBotName1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteAccount1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Exit1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLog1 = New System.Windows.Forms.Button()
        Me.CommandsBox1 = New System.Windows.Forms.ComboBox()
        Me.SaveLogDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RightClickMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TwitchData1
        '
        Me.TwitchData1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TwitchData1.FormattingEnabled = True
        Me.TwitchData1.Location = New System.Drawing.Point(0, 0)
        Me.TwitchData1.Name = "TwitchData1"
        Me.TwitchData1.Size = New System.Drawing.Size(508, 186)
        Me.TwitchData1.TabIndex = 1
        '
        'RightClickMenu1
        '
        Me.RightClickMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetBotName1, Me.ToolStripMenuItem2, Me.DeleteAccount1, Me.ToolStripMenuItem1, Me.Exit1})
        Me.RightClickMenu1.Name = "RightClickMenu1"
        Me.RightClickMenu1.Size = New System.Drawing.Size(197, 82)
        '
        'SetBotName1
        '
        Me.SetBotName1.Name = "SetBotName1"
        Me.SetBotName1.Size = New System.Drawing.Size(196, 22)
        Me.SetBotName1.Text = "Change the Bots Name"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 6)
        '
        'DeleteAccount1
        '
        Me.DeleteAccount1.Name = "DeleteAccount1"
        Me.DeleteAccount1.Size = New System.Drawing.Size(196, 22)
        Me.DeleteAccount1.Text = "Delete Account Info"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 6)
        '
        'Exit1
        '
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(196, 22)
        Me.Exit1.Text = "Exit"
        '
        'SaveLog1
        '
        Me.SaveLog1.Location = New System.Drawing.Point(12, 200)
        Me.SaveLog1.Name = "SaveLog1"
        Me.SaveLog1.Size = New System.Drawing.Size(75, 23)
        Me.SaveLog1.TabIndex = 2
        Me.SaveLog1.Text = "Save Log"
        Me.SaveLog1.UseVisualStyleBackColor = True
        '
        'CommandsBox1
        '
        Me.CommandsBox1.FormattingEnabled = True
        Me.CommandsBox1.Items.AddRange(New Object() {"Select an Action", "---------------------------------------------", "Add a Command", "Delete a Command", "---------------------------------------------", "Rename the Bot", "---------------------------------------------", "Delete Account Info"})
        Me.CommandsBox1.Location = New System.Drawing.Point(305, 202)
        Me.CommandsBox1.Name = "CommandsBox1"
        Me.CommandsBox1.Size = New System.Drawing.Size(191, 21)
        Me.CommandsBox1.TabIndex = 7
        Me.CommandsBox1.Text = "Select an Action"
        '
        'TwitchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 235)
        Me.ContextMenuStrip = Me.RightClickMenu1
        Me.Controls.Add(Me.CommandsBox1)
        Me.Controls.Add(Me.SaveLog1)
        Me.Controls.Add(Me.TwitchData1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TwitchForm"
        Me.Text = "TwitchBot"
        Me.RightClickMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TwitchData1 As ListBox
    Friend WithEvents RightClickMenu1 As ContextMenuStrip
    Friend WithEvents SetBotName1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents DeleteAccount1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents Exit1 As ToolStripMenuItem
    Friend WithEvents SaveLog1 As Button
    Friend WithEvents CommandsBox1 As ComboBox
    Friend WithEvents SaveLogDialog1 As SaveFileDialog
End Class
