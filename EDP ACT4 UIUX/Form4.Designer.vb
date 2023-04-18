<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.checkup_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_patients = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.findings = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.treatment_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_med = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.equipment_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 59)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check_up List"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(191, 429)
        Me.Panel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(0, 219)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(191, 36)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 177)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Insert"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(191, 36)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Edit "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 36)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add Record"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 36)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkup_id, Me.id_patients, Me.findings, Me.treatment_id, Me.id_med, Me.quantity, Me.date_, Me.equipment_id})
        Me.DataGridView1.Location = New System.Drawing.Point(197, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(658, 411)
        Me.DataGridView1.TabIndex = 2
        '
        'checkup_id
        '
        Me.checkup_id.DataPropertyName = "checkup_id"
        Me.checkup_id.HeaderText = "checkup_id"
        Me.checkup_id.Name = "checkup_id"
        Me.checkup_id.Width = 77
        '
        'id_patients
        '
        Me.id_patients.DataPropertyName = "id_patients"
        Me.id_patients.HeaderText = "id_patients"
        Me.id_patients.Name = "id_patients"
        Me.id_patients.Width = 77
        '
        'findings
        '
        Me.findings.DataPropertyName = "findings"
        Me.findings.HeaderText = "findings"
        Me.findings.Name = "findings"
        Me.findings.Width = 77
        '
        'treatment_id
        '
        Me.treatment_id.DataPropertyName = "treatment_id"
        Me.treatment_id.HeaderText = "treatment_id"
        Me.treatment_id.Name = "treatment_id"
        Me.treatment_id.Width = 77
        '
        'id_med
        '
        Me.id_med.DataPropertyName = "id_med"
        Me.id_med.HeaderText = "id_med"
        Me.id_med.Name = "id_med"
        Me.id_med.Width = 76
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.Width = 77
        '
        'date_
        '
        Me.date_.DataPropertyName = "date"
        Me.date_.HeaderText = "date_"
        Me.date_.Name = "date_"
        Me.date_.Width = 77
        '
        'equipment_id
        '
        Me.equipment_id.DataPropertyName = "equipment_id"
        Me.equipment_id.HeaderText = "equipment_id"
        Me.equipment_id.Name = "equipment_id"
        Me.equipment_id.Width = 77
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(867, 488)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.Text = "Check_up"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents checkup_id As DataGridViewTextBoxColumn
    Friend WithEvents id_patients As DataGridViewTextBoxColumn
    Friend WithEvents findings As DataGridViewTextBoxColumn
    Friend WithEvents treatment_id As DataGridViewTextBoxColumn
    Friend WithEvents id_med As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents date_ As DataGridViewTextBoxColumn
    Friend WithEvents equipment_id As DataGridViewTextBoxColumn
End Class
