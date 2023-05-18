<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddFormCheckUp
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.checkupDate = New System.Windows.Forms.DateTimePicker()
        Me.equipmentID = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.medID = New System.Windows.Forms.TextBox()
        Me.treatmentID = New System.Windows.Forms.TextBox()
        Me.findings = New System.Windows.Forms.TextBox()
        Me.patientID = New System.Windows.Forms.TextBox()
        Me.checkupID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.checkupDate)
        Me.Panel1.Controls.Add(Me.equipmentID)
        Me.Panel1.Controls.Add(Me.quantity)
        Me.Panel1.Controls.Add(Me.medID)
        Me.Panel1.Controls.Add(Me.treatmentID)
        Me.Panel1.Controls.Add(Me.findings)
        Me.Panel1.Controls.Add(Me.patientID)
        Me.Panel1.Controls.Add(Me.checkupID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(136, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 481)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(139, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 36)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(31, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Done"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'checkupDate
        '
        Me.checkupDate.Location = New System.Drawing.Point(31, 331)
        Me.checkupDate.Name = "checkupDate"
        Me.checkupDate.Size = New System.Drawing.Size(200, 20)
        Me.checkupDate.TabIndex = 7
        '
        'equipmentID
        '
        Me.equipmentID.Location = New System.Drawing.Point(31, 373)
        Me.equipmentID.Multiline = True
        Me.equipmentID.Name = "equipmentID"
        Me.equipmentID.Size = New System.Drawing.Size(184, 32)
        Me.equipmentID.TabIndex = 6
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(31, 269)
        Me.quantity.Multiline = True
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(184, 32)
        Me.quantity.TabIndex = 5
        '
        'medID
        '
        Me.medID.Location = New System.Drawing.Point(31, 219)
        Me.medID.Multiline = True
        Me.medID.Name = "medID"
        Me.medID.Size = New System.Drawing.Size(184, 32)
        Me.medID.TabIndex = 4
        '
        'treatmentID
        '
        Me.treatmentID.Location = New System.Drawing.Point(31, 171)
        Me.treatmentID.Multiline = True
        Me.treatmentID.Name = "treatmentID"
        Me.treatmentID.Size = New System.Drawing.Size(184, 32)
        Me.treatmentID.TabIndex = 3
        '
        'findings
        '
        Me.findings.Location = New System.Drawing.Point(31, 123)
        Me.findings.Multiline = True
        Me.findings.Name = "findings"
        Me.findings.Size = New System.Drawing.Size(184, 32)
        Me.findings.TabIndex = 2
        '
        'patientID
        '
        Me.patientID.Location = New System.Drawing.Point(31, 73)
        Me.patientID.Multiline = True
        Me.patientID.Name = "patientID"
        Me.patientID.Size = New System.Drawing.Size(184, 32)
        Me.patientID.TabIndex = 1
        '
        'checkupID
        '
        Me.checkupID.Location = New System.Drawing.Point(31, 22)
        Me.checkupID.Multiline = True
        Me.checkupID.Name = "checkupID"
        Me.checkupID.Size = New System.Drawing.Size(184, 32)
        Me.checkupID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CheckUp_ID"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Patient_ID"
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Findings"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Treatment_ID"
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Med_ID"
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Equipment_ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 480)
        Me.Panel2.TabIndex = 9
        '
        'AddFormCheckUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 481)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddFormCheckUp"
        Me.Text = "Add Record"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents equipmentID As TextBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents medID As TextBox
    Friend WithEvents treatmentID As TextBox
    Friend WithEvents findings As TextBox
    Friend WithEvents patientID As TextBox
    Friend WithEvents checkupID As TextBox
    Friend WithEvents checkupDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
