<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TwitchUser1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TwitchOAuth1 = New System.Windows.Forms.TextBox()
        Me.TwitchLogin1 = New System.Windows.Forms.Button()
        Me.TwitchRemember1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TwitchChannel1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login to Twitch IRC."
        '
        'TwitchUser1
        '
        Me.TwitchUser1.Location = New System.Drawing.Point(113, 35)
        Me.TwitchUser1.Name = "TwitchUser1"
        Me.TwitchUser1.Size = New System.Drawing.Size(310, 20)
        Me.TwitchUser1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Twitch Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Twitch OAuth Key:"
        '
        'TwitchOAuth1
        '
        Me.TwitchOAuth1.Location = New System.Drawing.Point(113, 67)
        Me.TwitchOAuth1.Name = "TwitchOAuth1"
        Me.TwitchOAuth1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TwitchOAuth1.Size = New System.Drawing.Size(310, 20)
        Me.TwitchOAuth1.TabIndex = 3
        Me.TwitchOAuth1.UseSystemPasswordChar = True
        '
        'TwitchLogin1
        '
        Me.TwitchLogin1.Location = New System.Drawing.Point(348, 127)
        Me.TwitchLogin1.Name = "TwitchLogin1"
        Me.TwitchLogin1.Size = New System.Drawing.Size(75, 23)
        Me.TwitchLogin1.TabIndex = 5
        Me.TwitchLogin1.Text = "Login"
        Me.TwitchLogin1.UseVisualStyleBackColor = True
        '
        'TwitchRemember1
        '
        Me.TwitchRemember1.AutoSize = True
        Me.TwitchRemember1.Location = New System.Drawing.Point(113, 131)
        Me.TwitchRemember1.Name = "TwitchRemember1"
        Me.TwitchRemember1.Size = New System.Drawing.Size(83, 17)
        Me.TwitchRemember1.TabIndex = 6
        Me.TwitchRemember1.Text = "Remember?"
        Me.TwitchRemember1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Twitch Channel:"
        '
        'TwitchChannel1
        '
        Me.TwitchChannel1.Location = New System.Drawing.Point(113, 98)
        Me.TwitchChannel1.Name = "TwitchChannel1"
        Me.TwitchChannel1.Size = New System.Drawing.Size(310, 20)
        Me.TwitchChannel1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 157)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TwitchChannel1)
        Me.Controls.Add(Me.TwitchRemember1)
        Me.Controls.Add(Me.TwitchLogin1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TwitchOAuth1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TwitchUser1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "TwitchBot: Launch Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TwitchUser1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TwitchOAuth1 As TextBox
    Friend WithEvents TwitchLogin1 As Button
    Friend WithEvents TwitchRemember1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TwitchChannel1 As TextBox
End Class
