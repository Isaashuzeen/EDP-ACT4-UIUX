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
        Me.AddUser = New System.Windows.Forms.Button()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AddUser
        '
        Me.AddUser.Location = New System.Drawing.Point(416, 277)
        Me.AddUser.Name = "AddUser"
        Me.AddUser.Size = New System.Drawing.Size(75, 23)
        Me.AddUser.TabIndex = 5
        Me.AddUser.Text = "Add User"
        Me.AddUser.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.Location = New System.Drawing.Point(329, 277)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(75, 23)
        Me.LogIn.TabIndex = 4
        Me.LogIn.Text = "&Log In"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(326, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(326, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(329, 229)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(162, 20)
        Me.Password.TabIndex = 1
        Me.Password.UseSystemPasswordChar = True
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(329, 178)
        Me.Username.Multiline = True
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(162, 23)
        Me.Username.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.EDP_ACT4_UIUX.My.Resources.Resources._27374038_7283496
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AddUser)
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddUser As Button
    Friend WithEvents LogIn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
End Class
