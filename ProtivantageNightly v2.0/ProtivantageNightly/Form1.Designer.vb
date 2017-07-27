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
        Me.components = New System.ComponentModel.Container()
        Me.ChkAllow5 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkAllow4 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbODTaskType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbODTaskPriority = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNoteType = New System.Windows.Forms.ComboBox()
        Me.lblNoteType = New System.Windows.Forms.Label()
        Me.cmbTaskType = New System.Windows.Forms.ComboBox()
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.NumMyInterval2 = New System.Windows.Forms.NumericUpDown()
        Me.NumMyInterval1 = New System.Windows.Forms.NumericUpDown()
        Me.lblDays2 = New System.Windows.Forms.Label()
        Me.lblDays1 = New System.Windows.Forms.Label()
        Me.lblInterval2 = New System.Windows.Forms.Label()
        Me.lblInterval1 = New System.Windows.Forms.Label()
        Me.ChkAllow3 = New System.Windows.Forms.CheckBox()
        Me.cmbTaskPriority = New System.Windows.Forms.ComboBox()
        Me.lblTaskAllowOverride = New System.Windows.Forms.Label()
        Me.lblTaskPriority = New System.Windows.Forms.Label()
        Me.ChkAllow2 = New System.Windows.Forms.CheckBox()
        Me.ChkAllow1 = New System.Windows.Forms.CheckBox()
        Me.lblUserOverrideNotify = New System.Windows.Forms.Label()
        Me.lblUserOverrideOverdue = New System.Windows.Forms.Label()
        Me.lblDefaultNotify = New System.Windows.Forms.Label()
        Me.ChkDefaultNotify = New System.Windows.Forms.CheckBox()
        Me.lblDefaultOverdueInterval = New System.Windows.Forms.Label()
        Me.NumDefaultOverdueInterval = New System.Windows.Forms.NumericUpDown()
        Me.lblFlowsheet = New System.Windows.Forms.Label()
        Me.txtFlowsheet = New System.Windows.Forms.TextBox()
        Me.ChkEdited = New System.Windows.Forms.CheckBox()
        Me.TaskPriorityDEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.NumMyInterval2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMyInterval1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkAllow5
        '
        Me.ChkAllow5.AutoSize = True
        Me.ChkAllow5.Location = New System.Drawing.Point(489, 256)
        Me.ChkAllow5.Name = "ChkAllow5"
        Me.ChkAllow5.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow5.TabIndex = 105
        Me.ChkAllow5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Allow User Override?"
        '
        'ChkAllow4
        '
        Me.ChkAllow4.AutoSize = True
        Me.ChkAllow4.Location = New System.Drawing.Point(489, 188)
        Me.ChkAllow4.Name = "ChkAllow4"
        Me.ChkAllow4.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow4.TabIndex = 103
        Me.ChkAllow4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Allow User Override?"
        '
        'cmbODTaskType
        '
        Me.cmbODTaskType.FormattingEnabled = True
        Me.cmbODTaskType.Location = New System.Drawing.Point(236, 214)
        Me.cmbODTaskType.Name = "cmbODTaskType"
        Me.cmbODTaskType.Size = New System.Drawing.Size(268, 21)
        Me.cmbODTaskType.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Overdue Task Type"
        '
        'cmbODTaskPriority
        '
        Me.cmbODTaskPriority.FormattingEnabled = True
        Me.cmbODTaskPriority.Location = New System.Drawing.Point(236, 189)
        Me.cmbODTaskPriority.Name = "cmbODTaskPriority"
        Me.cmbODTaskPriority.Size = New System.Drawing.Size(118, 21)
        Me.cmbODTaskPriority.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Default Overdue Task Priority"
        '
        'cmbNoteType
        '
        Me.cmbNoteType.FormattingEnabled = True
        Me.cmbNoteType.Location = New System.Drawing.Point(236, 162)
        Me.cmbNoteType.Name = "cmbNoteType"
        Me.cmbNoteType.Size = New System.Drawing.Size(268, 21)
        Me.cmbNoteType.TabIndex = 97
        '
        'lblNoteType
        '
        Me.lblNoteType.AutoSize = True
        Me.lblNoteType.Location = New System.Drawing.Point(21, 166)
        Me.lblNoteType.Name = "lblNoteType"
        Me.lblNoteType.Size = New System.Drawing.Size(103, 13)
        Me.lblNoteType.TabIndex = 98
        Me.lblNoteType.Text = "Note Type to Create"
        '
        'cmbTaskType
        '
        Me.cmbTaskType.FormattingEnabled = True
        Me.cmbTaskType.Location = New System.Drawing.Point(236, 136)
        Me.cmbTaskType.Name = "cmbTaskType"
        Me.cmbTaskType.Size = New System.Drawing.Size(268, 21)
        Me.cmbTaskType.TabIndex = 95
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Location = New System.Drawing.Point(21, 140)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(114, 13)
        Me.lblTaskName.TabIndex = 96
        Me.lblTaskName.Text = "Notification Task Type"
        '
        'NumMyInterval2
        '
        Me.NumMyInterval2.Location = New System.Drawing.Point(236, 265)
        Me.NumMyInterval2.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NumMyInterval2.Name = "NumMyInterval2"
        Me.NumMyInterval2.Size = New System.Drawing.Size(56, 20)
        Me.NumMyInterval2.TabIndex = 86
        '
        'NumMyInterval1
        '
        Me.NumMyInterval1.Location = New System.Drawing.Point(236, 242)
        Me.NumMyInterval1.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NumMyInterval1.Name = "NumMyInterval1"
        Me.NumMyInterval1.Size = New System.Drawing.Size(56, 20)
        Me.NumMyInterval1.TabIndex = 83
        '
        'lblDays2
        '
        Me.lblDays2.AutoSize = True
        Me.lblDays2.Location = New System.Drawing.Point(298, 269)
        Me.lblDays2.Name = "lblDays2"
        Me.lblDays2.Size = New System.Drawing.Size(29, 13)
        Me.lblDays2.TabIndex = 94
        Me.lblDays2.Text = "days"
        '
        'lblDays1
        '
        Me.lblDays1.AutoSize = True
        Me.lblDays1.Location = New System.Drawing.Point(298, 246)
        Me.lblDays1.Name = "lblDays1"
        Me.lblDays1.Size = New System.Drawing.Size(29, 13)
        Me.lblDays1.TabIndex = 93
        Me.lblDays1.Text = "days"
        '
        'lblInterval2
        '
        Me.lblInterval2.AutoSize = True
        Me.lblInterval2.Location = New System.Drawing.Point(21, 269)
        Me.lblInterval2.Name = "lblInterval2"
        Me.lblInterval2.Size = New System.Drawing.Size(68, 13)
        Me.lblInterval2.TabIndex = 92
        Me.lblInterval2.Text = "My Interval 2"
        '
        'lblInterval1
        '
        Me.lblInterval1.AutoSize = True
        Me.lblInterval1.Location = New System.Drawing.Point(21, 246)
        Me.lblInterval1.Name = "lblInterval1"
        Me.lblInterval1.Size = New System.Drawing.Size(68, 13)
        Me.lblInterval1.TabIndex = 91
        Me.lblInterval1.Text = "My Interval 1"
        '
        'ChkAllow3
        '
        Me.ChkAllow3.AutoSize = True
        Me.ChkAllow3.Location = New System.Drawing.Point(489, 112)
        Me.ChkAllow3.Name = "ChkAllow3"
        Me.ChkAllow3.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow3.TabIndex = 81
        Me.ChkAllow3.UseVisualStyleBackColor = True
        '
        'cmbTaskPriority
        '
        Me.cmbTaskPriority.FormattingEnabled = True
        Me.cmbTaskPriority.Location = New System.Drawing.Point(236, 111)
        Me.cmbTaskPriority.Name = "cmbTaskPriority"
        Me.cmbTaskPriority.Size = New System.Drawing.Size(118, 21)
        Me.cmbTaskPriority.TabIndex = 80
        '
        'lblTaskAllowOverride
        '
        Me.lblTaskAllowOverride.AutoSize = True
        Me.lblTaskAllowOverride.Location = New System.Drawing.Point(377, 113)
        Me.lblTaskAllowOverride.Name = "lblTaskAllowOverride"
        Me.lblTaskAllowOverride.Size = New System.Drawing.Size(106, 13)
        Me.lblTaskAllowOverride.TabIndex = 90
        Me.lblTaskAllowOverride.Text = "Allow User Override?"
        '
        'lblTaskPriority
        '
        Me.lblTaskPriority.AutoSize = True
        Me.lblTaskPriority.Location = New System.Drawing.Point(21, 115)
        Me.lblTaskPriority.Name = "lblTaskPriority"
        Me.lblTaskPriority.Size = New System.Drawing.Size(158, 13)
        Me.lblTaskPriority.TabIndex = 89
        Me.lblTaskPriority.Text = "Default Notification Task Priority"
        '
        'ChkAllow2
        '
        Me.ChkAllow2.AutoSize = True
        Me.ChkAllow2.Location = New System.Drawing.Point(489, 90)
        Me.ChkAllow2.Name = "ChkAllow2"
        Me.ChkAllow2.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow2.TabIndex = 78
        Me.ChkAllow2.UseVisualStyleBackColor = True
        '
        'ChkAllow1
        '
        Me.ChkAllow1.AutoSize = True
        Me.ChkAllow1.Location = New System.Drawing.Point(489, 66)
        Me.ChkAllow1.Name = "ChkAllow1"
        Me.ChkAllow1.Size = New System.Drawing.Size(15, 14)
        Me.ChkAllow1.TabIndex = 76
        Me.ChkAllow1.UseVisualStyleBackColor = True
        '
        'lblUserOverrideNotify
        '
        Me.lblUserOverrideNotify.AutoSize = True
        Me.lblUserOverrideNotify.Location = New System.Drawing.Point(377, 91)
        Me.lblUserOverrideNotify.Name = "lblUserOverrideNotify"
        Me.lblUserOverrideNotify.Size = New System.Drawing.Size(106, 13)
        Me.lblUserOverrideNotify.TabIndex = 85
        Me.lblUserOverrideNotify.Text = "Allow User Override?"
        '
        'lblUserOverrideOverdue
        '
        Me.lblUserOverrideOverdue.AutoSize = True
        Me.lblUserOverrideOverdue.Location = New System.Drawing.Point(377, 67)
        Me.lblUserOverrideOverdue.Name = "lblUserOverrideOverdue"
        Me.lblUserOverrideOverdue.Size = New System.Drawing.Size(106, 13)
        Me.lblUserOverrideOverdue.TabIndex = 84
        Me.lblUserOverrideOverdue.Text = "Allow User Override?"
        '
        'lblDefaultNotify
        '
        Me.lblDefaultNotify.AutoSize = True
        Me.lblDefaultNotify.Location = New System.Drawing.Point(21, 91)
        Me.lblDefaultNotify.Name = "lblDefaultNotify"
        Me.lblDefaultNotify.Size = New System.Drawing.Size(201, 13)
        Me.lblDefaultNotify.TabIndex = 82
        Me.lblDefaultNotify.Text = "Overdue Notification Checked by Default"
        '
        'ChkDefaultNotify
        '
        Me.ChkDefaultNotify.AutoSize = True
        Me.ChkDefaultNotify.Location = New System.Drawing.Point(236, 90)
        Me.ChkDefaultNotify.Name = "ChkDefaultNotify"
        Me.ChkDefaultNotify.Size = New System.Drawing.Size(15, 14)
        Me.ChkDefaultNotify.TabIndex = 77
        Me.ChkDefaultNotify.UseVisualStyleBackColor = True
        '
        'lblDefaultOverdueInterval
        '
        Me.lblDefaultOverdueInterval.AutoSize = True
        Me.lblDefaultOverdueInterval.Location = New System.Drawing.Point(21, 67)
        Me.lblDefaultOverdueInterval.Name = "lblDefaultOverdueInterval"
        Me.lblDefaultOverdueInterval.Size = New System.Drawing.Size(168, 13)
        Me.lblDefaultOverdueInterval.TabIndex = 79
        Me.lblDefaultOverdueInterval.Text = "Default Value for Overdue Interval"
        '
        'NumDefaultOverdueInterval
        '
        Me.NumDefaultOverdueInterval.Location = New System.Drawing.Point(236, 63)
        Me.NumDefaultOverdueInterval.Name = "NumDefaultOverdueInterval"
        Me.NumDefaultOverdueInterval.Size = New System.Drawing.Size(60, 20)
        Me.NumDefaultOverdueInterval.TabIndex = 75
        '
        'lblFlowsheet
        '
        Me.lblFlowsheet.AutoSize = True
        Me.lblFlowsheet.Location = New System.Drawing.Point(21, 43)
        Me.lblFlowsheet.Name = "lblFlowsheet"
        Me.lblFlowsheet.Size = New System.Drawing.Size(86, 13)
        Me.lblFlowsheet.TabIndex = 74
        Me.lblFlowsheet.Text = "Flowsheet Name"
        '
        'txtFlowsheet
        '
        Me.txtFlowsheet.Location = New System.Drawing.Point(236, 38)
        Me.txtFlowsheet.Name = "txtFlowsheet"
        Me.txtFlowsheet.Size = New System.Drawing.Size(268, 20)
        Me.txtFlowsheet.TabIndex = 72
        '
        'ChkEdited
        '
        Me.ChkEdited.AutoSize = True
        Me.ChkEdited.Location = New System.Drawing.Point(469, 5)
        Me.ChkEdited.Name = "ChkEdited"
        Me.ChkEdited.Size = New System.Drawing.Size(56, 17)
        Me.ChkEdited.TabIndex = 73
        Me.ChkEdited.Text = "Edited"
        Me.ChkEdited.UseVisualStyleBackColor = True
        Me.ChkEdited.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(409, 309)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(100, 24)
        Me.BtnCancel.TabIndex = 88
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(293, 309)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 24)
        Me.BtnSave.TabIndex = 87
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 342)
        Me.Controls.Add(Me.ChkAllow5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ChkAllow4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbODTaskType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbODTaskPriority)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNoteType)
        Me.Controls.Add(Me.lblNoteType)
        Me.Controls.Add(Me.cmbTaskType)
        Me.Controls.Add(Me.lblTaskName)
        Me.Controls.Add(Me.NumMyInterval2)
        Me.Controls.Add(Me.NumMyInterval1)
        Me.Controls.Add(Me.lblDays2)
        Me.Controls.Add(Me.lblDays1)
        Me.Controls.Add(Me.lblInterval2)
        Me.Controls.Add(Me.lblInterval1)
        Me.Controls.Add(Me.ChkAllow3)
        Me.Controls.Add(Me.cmbTaskPriority)
        Me.Controls.Add(Me.lblTaskAllowOverride)
        Me.Controls.Add(Me.lblTaskPriority)
        Me.Controls.Add(Me.ChkAllow2)
        Me.Controls.Add(Me.ChkAllow1)
        Me.Controls.Add(Me.lblUserOverrideNotify)
        Me.Controls.Add(Me.lblUserOverrideOverdue)
        Me.Controls.Add(Me.lblDefaultNotify)
        Me.Controls.Add(Me.ChkDefaultNotify)
        Me.Controls.Add(Me.lblDefaultOverdueInterval)
        Me.Controls.Add(Me.NumDefaultOverdueInterval)
        Me.Controls.Add(Me.lblFlowsheet)
        Me.Controls.Add(Me.txtFlowsheet)
        Me.Controls.Add(Me.ChkEdited)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumMyInterval2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMyInterval1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkAllow5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkAllow4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbODTaskType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbODTaskPriority As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNoteType As System.Windows.Forms.ComboBox
    Friend WithEvents lblNoteType As System.Windows.Forms.Label
    Friend WithEvents cmbTaskType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTaskName As System.Windows.Forms.Label
    Friend WithEvents NumMyInterval2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumMyInterval1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDays2 As System.Windows.Forms.Label
    Friend WithEvents lblDays1 As System.Windows.Forms.Label
    Friend WithEvents lblInterval2 As System.Windows.Forms.Label
    Friend WithEvents lblInterval1 As System.Windows.Forms.Label
    Friend WithEvents ChkAllow3 As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTaskPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lblTaskAllowOverride As System.Windows.Forms.Label
    Friend WithEvents lblTaskPriority As System.Windows.Forms.Label
    Friend WithEvents ChkAllow2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAllow1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblUserOverrideNotify As System.Windows.Forms.Label
    Friend WithEvents lblUserOverrideOverdue As System.Windows.Forms.Label
    Friend WithEvents lblDefaultNotify As System.Windows.Forms.Label
    Friend WithEvents ChkDefaultNotify As System.Windows.Forms.CheckBox
    Friend WithEvents lblDefaultOverdueInterval As System.Windows.Forms.Label
    Friend WithEvents NumDefaultOverdueInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFlowsheet As System.Windows.Forms.Label
    Friend WithEvents txtFlowsheet As System.Windows.Forms.TextBox
    Friend WithEvents ChkEdited As System.Windows.Forms.CheckBox
    Friend WithEvents TaskPriorityDEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
End Class
