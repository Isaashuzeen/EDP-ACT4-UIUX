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
        Me.AddUser = New System.Windows.Forms.Button()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Hpas = New System.Windows.Forms.Button()
        Me.Spas = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Password.BackColor = System.Drawing.SystemColors.Info
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password.Location = New System.Drawing.Point(330, 228)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(162, 13)
        Me.Password.TabIndex = 1
        Me.Password.UseSystemPasswordChar = True
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.SystemColors.Info
        Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Username.Location = New System.Drawing.Point(330, 182)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(162, 13)
        Me.Username.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EDP_ACT4_UIUX.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(300, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.EDP_ACT4_UIUX.My.Resources.Resources.padlock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(300, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Hpas
        '
        Me.Hpas.BackgroundImage = Global.EDP_ACT4_UIUX.My.Resources.Resources.hide
        Me.Hpas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Hpas.FlatAppearance.BorderSize = 0
        Me.Hpas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hpas.Location = New System.Drawing.Point(470, 225)
        Me.Hpas.Name = "Hpas"
        Me.Hpas.Size = New System.Drawing.Size(22, 20)
        Me.Hpas.TabIndex = 8
        Me.Hpas.UseVisualStyleBackColor = True
        '
        'Spas
        '
        Me.Spas.BackgroundImage = Global.EDP_ACT4_UIUX.My.Resources.Resources.eye
        Me.Spas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Spas.FlatAppearance.BorderSize = 0
        Me.Spas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Spas.Location = New System.Drawing.Point(470, 224)
        Me.Spas.Name = "Spas"
        Me.Spas.Size = New System.Drawing.Size(21, 21)
        Me.Spas.TabIndex = 9
        Me.Spas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(326, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "__________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(326, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "__________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Please Enter your Username"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(148, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Please Enter your Password"
        Me.Label6.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.EDP_ACT4_UIUX.My.Resources.Resources._27374038_7283496
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Spas)
        Me.Controls.Add(Me.Hpas)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AddUser)
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Log In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddUser As Button
    Friend WithEvents LogIn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Hpas As Button
    Friend WithEvents Spas As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
