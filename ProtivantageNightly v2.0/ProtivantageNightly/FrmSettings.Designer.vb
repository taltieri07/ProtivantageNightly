﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.BtnTaskGeneration = New System.Windows.Forms.Button()
        Me.lblAdminUser = New System.Windows.Forms.Label()
        Me.cmbAdminUser = New System.Windows.Forms.ComboBox()
        Me.lblInactivity = New System.Windows.Forms.Label()
        Me.numTimeout = New System.Windows.Forms.NumericUpDown()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmbAdminTaskType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblINRName = New System.Windows.Forms.Label()
        Me.txtINRName = New System.Windows.Forms.TextBox()
        Me.btnCDS = New System.Windows.Forms.Button()
        CType(Me.NumMyInterval2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMyInterval1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkAllow5
        '
        Me.ChkAllow5.AutoSize = True
        Me.ChkAllow5.Location = New System.Drawing.Point(733, 303)
        Me.ChkAllow5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAllow5.Name = "ChkAllow5"
        Me.ChkAllow5.Size = New System.Drawing.Size(18, 17)
        Me.ChkAllow5.TabIndex = 105
        Me.ChkAllow5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(584, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Allow User Override?"
        '
        'ChkAllow4
        '
        Me.ChkAllow4.AutoSize = True
        Me.ChkAllow4.Location = New System.Drawing.Point(733, 219)
        Me.ChkAllow4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAllow4.Name = "ChkAllow4"
        Me.ChkAllow4.Size = New System.Drawing.Size(18, 17)
        Me.ChkAllow4.TabIndex = 103
        Me.ChkAllow4.UseVisualStyleBackColor = True
        Me.ChkAllow4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(584, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 17)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Allow User Override?"
        Me.Label3.Visible = False
        '
        'cmbODTaskType
        '
        Me.cmbODTaskType.FormattingEnabled = True
        Me.cmbODTaskType.Location = New System.Drawing.Point(396, 251)
        Me.cmbODTaskType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbODTaskType.Name = "cmbODTaskType"
        Me.cmbODTaskType.Size = New System.Drawing.Size(356, 24)
        Me.cmbODTaskType.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 256)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Overdue Task Type"
        '
        'cmbODTaskPriority
        '
        Me.cmbODTaskPriority.FormattingEnabled = True
        Me.cmbODTaskPriority.Location = New System.Drawing.Point(396, 220)
        Me.cmbODTaskPriority.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbODTaskPriority.Name = "cmbODTaskPriority"
        Me.cmbODTaskPriority.Size = New System.Drawing.Size(156, 24)
        Me.cmbODTaskPriority.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 225)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Default Overdue Task Priority"
        '
        'cmbNoteType
        '
        Me.cmbNoteType.FormattingEnabled = True
        Me.cmbNoteType.Location = New System.Drawing.Point(396, 187)
        Me.cmbNoteType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbNoteType.Name = "cmbNoteType"
        Me.cmbNoteType.Size = New System.Drawing.Size(356, 24)
        Me.cmbNoteType.TabIndex = 97
        '
        'lblNoteType
        '
        Me.lblNoteType.AutoSize = True
        Me.lblNoteType.Location = New System.Drawing.Point(28, 192)
        Me.lblNoteType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoteType.Name = "lblNoteType"
        Me.lblNoteType.Size = New System.Drawing.Size(136, 17)
        Me.lblNoteType.TabIndex = 98
        Me.lblNoteType.Text = "Note Type to Create"
        '
        'cmbTaskType
        '
        Me.cmbTaskType.FormattingEnabled = True
        Me.cmbTaskType.Location = New System.Drawing.Point(396, 155)
        Me.cmbTaskType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTaskType.Name = "cmbTaskType"
        Me.cmbTaskType.Size = New System.Drawing.Size(356, 24)
        Me.cmbTaskType.TabIndex = 95
        '
        'lblTaskName
        '
        Me.lblTaskName.AutoSize = True
        Me.lblTaskName.Location = New System.Drawing.Point(28, 160)
        Me.lblTaskName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(149, 17)
        Me.lblTaskName.TabIndex = 96
        Me.lblTaskName.Text = "Notification Task Type"
        '
        'NumMyInterval2
        '
        Me.NumMyInterval2.Location = New System.Drawing.Point(396, 314)
        Me.NumMyInterval2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumMyInterval2.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NumMyInterval2.Name = "NumMyInterval2"
        Me.NumMyInterval2.Size = New System.Drawing.Size(75, 22)
        Me.NumMyInterval2.TabIndex = 86
        '
        'NumMyInterval1
        '
        Me.NumMyInterval1.Location = New System.Drawing.Point(396, 286)
        Me.NumMyInterval1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumMyInterval1.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NumMyInterval1.Name = "NumMyInterval1"
        Me.NumMyInterval1.Size = New System.Drawing.Size(75, 22)
        Me.NumMyInterval1.TabIndex = 83
        '
        'lblDays2
        '
        Me.lblDays2.AutoSize = True
        Me.lblDays2.Location = New System.Drawing.Point(479, 319)
        Me.lblDays2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDays2.Name = "lblDays2"
        Me.lblDays2.Size = New System.Drawing.Size(38, 17)
        Me.lblDays2.TabIndex = 94
        Me.lblDays2.Text = "days"
        '
        'lblDays1
        '
        Me.lblDays1.AutoSize = True
        Me.lblDays1.Location = New System.Drawing.Point(479, 290)
        Me.lblDays1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDays1.Name = "lblDays1"
        Me.lblDays1.Size = New System.Drawing.Size(38, 17)
        Me.lblDays1.TabIndex = 93
        Me.lblDays1.Text = "days"
        '
        'lblInterval2
        '
        Me.lblInterval2.AutoSize = True
        Me.lblInterval2.Location = New System.Drawing.Point(28, 319)
        Me.lblInterval2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInterval2.Name = "lblInterval2"
        Me.lblInterval2.Size = New System.Drawing.Size(88, 17)
        Me.lblInterval2.TabIndex = 92
        Me.lblInterval2.Text = "My Interval 2"
        '
        'lblInterval1
        '
        Me.lblInterval1.AutoSize = True
        Me.lblInterval1.Location = New System.Drawing.Point(28, 290)
        Me.lblInterval1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInterval1.Name = "lblInterval1"
        Me.lblInterval1.Size = New System.Drawing.Size(88, 17)
        Me.lblInterval1.TabIndex = 91
        Me.lblInterval1.Text = "My Interval 1"
        '
        'ChkAllow3
        '
        Me.ChkAllow3.AutoSize = True
        Me.ChkAllow3.Location = New System.Drawing.Point(733, 126)
        Me.ChkAllow3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAllow3.Name = "ChkAllow3"
        Me.ChkAllow3.Size = New System.Drawing.Size(18, 17)
        Me.ChkAllow3.TabIndex = 81
        Me.ChkAllow3.UseVisualStyleBackColor = True
        '
        'cmbTaskPriority
        '
        Me.cmbTaskPriority.FormattingEnabled = True
        Me.cmbTaskPriority.Location = New System.Drawing.Point(396, 124)
        Me.cmbTaskPriority.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTaskPriority.Name = "cmbTaskPriority"
        Me.cmbTaskPriority.Size = New System.Drawing.Size(156, 24)
        Me.cmbTaskPriority.TabIndex = 80
        '
        'lblTaskAllowOverride
        '
        Me.lblTaskAllowOverride.AutoSize = True
        Me.lblTaskAllowOverride.Location = New System.Drawing.Point(584, 127)
        Me.lblTaskAllowOverride.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskAllowOverride.Name = "lblTaskAllowOverride"
        Me.lblTaskAllowOverride.Size = New System.Drawing.Size(141, 17)
        Me.lblTaskAllowOverride.TabIndex = 90
        Me.lblTaskAllowOverride.Text = "Allow User Override?"
        '
        'lblTaskPriority
        '
        Me.lblTaskPriority.AutoSize = True
        Me.lblTaskPriority.Location = New System.Drawing.Point(28, 129)
        Me.lblTaskPriority.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaskPriority.Name = "lblTaskPriority"
        Me.lblTaskPriority.Size = New System.Drawing.Size(210, 17)
        Me.lblTaskPriority.TabIndex = 89
        Me.lblTaskPriority.Text = "Default Notification Task Priority"
        '
        'ChkAllow2
        '
        Me.ChkAllow2.AutoSize = True
        Me.ChkAllow2.Location = New System.Drawing.Point(733, 98)
        Me.ChkAllow2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAllow2.Name = "ChkAllow2"
        Me.ChkAllow2.Size = New System.Drawing.Size(18, 17)
        Me.ChkAllow2.TabIndex = 78
        Me.ChkAllow2.UseVisualStyleBackColor = True
        '
        'ChkAllow1
        '
        Me.ChkAllow1.AutoSize = True
        Me.ChkAllow1.Location = New System.Drawing.Point(733, 69)
        Me.ChkAllow1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAllow1.Name = "ChkAllow1"
        Me.ChkAllow1.Size = New System.Drawing.Size(18, 17)
        Me.ChkAllow1.TabIndex = 76
        Me.ChkAllow1.UseVisualStyleBackColor = True
        '
        'lblUserOverrideNotify
        '
        Me.lblUserOverrideNotify.AutoSize = True
        Me.lblUserOverrideNotify.Location = New System.Drawing.Point(584, 100)
        Me.lblUserOverrideNotify.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserOverrideNotify.Name = "lblUserOverrideNotify"
        Me.lblUserOverrideNotify.Size = New System.Drawing.Size(141, 17)
        Me.lblUserOverrideNotify.TabIndex = 85
        Me.lblUserOverrideNotify.Text = "Allow User Override?"
        '
        'lblUserOverrideOverdue
        '
        Me.lblUserOverrideOverdue.AutoSize = True
        Me.lblUserOverrideOverdue.Location = New System.Drawing.Point(584, 70)
        Me.lblUserOverrideOverdue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserOverrideOverdue.Name = "lblUserOverrideOverdue"
        Me.lblUserOverrideOverdue.Size = New System.Drawing.Size(141, 17)
        Me.lblUserOverrideOverdue.TabIndex = 84
        Me.lblUserOverrideOverdue.Text = "Allow User Override?"
        '
        'lblDefaultNotify
        '
        Me.lblDefaultNotify.AutoSize = True
        Me.lblDefaultNotify.Location = New System.Drawing.Point(28, 100)
        Me.lblDefaultNotify.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDefaultNotify.Name = "lblDefaultNotify"
        Me.lblDefaultNotify.Size = New System.Drawing.Size(264, 17)
        Me.lblDefaultNotify.TabIndex = 82
        Me.lblDefaultNotify.Text = "Overdue Notification Checked by Default"
        '
        'ChkDefaultNotify
        '
        Me.ChkDefaultNotify.AutoSize = True
        Me.ChkDefaultNotify.Location = New System.Drawing.Point(396, 98)
        Me.ChkDefaultNotify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkDefaultNotify.Name = "ChkDefaultNotify"
        Me.ChkDefaultNotify.Size = New System.Drawing.Size(18, 17)
        Me.ChkDefaultNotify.TabIndex = 77
        Me.ChkDefaultNotify.UseVisualStyleBackColor = True
        '
        'lblDefaultOverdueInterval
        '
        Me.lblDefaultOverdueInterval.AutoSize = True
        Me.lblDefaultOverdueInterval.Location = New System.Drawing.Point(28, 70)
        Me.lblDefaultOverdueInterval.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDefaultOverdueInterval.Name = "lblDefaultOverdueInterval"
        Me.lblDefaultOverdueInterval.Size = New System.Drawing.Size(223, 17)
        Me.lblDefaultOverdueInterval.TabIndex = 79
        Me.lblDefaultOverdueInterval.Text = "Default Value for Overdue Interval"
        '
        'NumDefaultOverdueInterval
        '
        Me.NumDefaultOverdueInterval.Location = New System.Drawing.Point(396, 65)
        Me.NumDefaultOverdueInterval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumDefaultOverdueInterval.Name = "NumDefaultOverdueInterval"
        Me.NumDefaultOverdueInterval.Size = New System.Drawing.Size(80, 22)
        Me.NumDefaultOverdueInterval.TabIndex = 75
        '
        'lblFlowsheet
        '
        Me.lblFlowsheet.AutoSize = True
        Me.lblFlowsheet.Location = New System.Drawing.Point(28, 41)
        Me.lblFlowsheet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFlowsheet.Name = "lblFlowsheet"
        Me.lblFlowsheet.Size = New System.Drawing.Size(112, 17)
        Me.lblFlowsheet.TabIndex = 74
        Me.lblFlowsheet.Text = "Flowsheet Name"
        '
        'txtFlowsheet
        '
        Me.txtFlowsheet.Location = New System.Drawing.Point(396, 34)
        Me.txtFlowsheet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFlowsheet.Name = "txtFlowsheet"
        Me.txtFlowsheet.Size = New System.Drawing.Size(356, 22)
        Me.txtFlowsheet.TabIndex = 72
        '
        'ChkEdited
        '
        Me.ChkEdited.AutoSize = True
        Me.ChkEdited.Location = New System.Drawing.Point(663, 6)
        Me.ChkEdited.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkEdited.Name = "ChkEdited"
        Me.ChkEdited.Size = New System.Drawing.Size(70, 21)
        Me.ChkEdited.TabIndex = 73
        Me.ChkEdited.Text = "Edited"
        Me.ChkEdited.UseVisualStyleBackColor = True
        Me.ChkEdited.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(620, 510)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(133, 30)
        Me.BtnCancel.TabIndex = 88
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(396, 510)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(133, 30)
        Me.BtnSave.TabIndex = 87
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnTaskGeneration
        '
        Me.BtnTaskGeneration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTaskGeneration.ForeColor = System.Drawing.Color.Red
        Me.BtnTaskGeneration.Location = New System.Drawing.Point(31, 510)
        Me.BtnTaskGeneration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnTaskGeneration.Name = "BtnTaskGeneration"
        Me.BtnTaskGeneration.Size = New System.Drawing.Size(291, 30)
        Me.BtnTaskGeneration.TabIndex = 107
        Me.BtnTaskGeneration.Text = "&Run Manual Task Generation"
        Me.BtnTaskGeneration.UseVisualStyleBackColor = True
        '
        'lblAdminUser
        '
        Me.lblAdminUser.AutoSize = True
        Me.lblAdminUser.Location = New System.Drawing.Point(28, 348)
        Me.lblAdminUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdminUser.Name = "lblAdminUser"
        Me.lblAdminUser.Size = New System.Drawing.Size(284, 17)
        Me.lblAdminUser.TabIndex = 108
        Me.lblAdminUser.Text = "Admin User (receives nightly task summary)"
        '
        'cmbAdminUser
        '
        Me.cmbAdminUser.FormattingEnabled = True
        Me.cmbAdminUser.Location = New System.Drawing.Point(396, 345)
        Me.cmbAdminUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbAdminUser.Name = "cmbAdminUser"
        Me.cmbAdminUser.Size = New System.Drawing.Size(191, 24)
        Me.cmbAdminUser.TabIndex = 109
        '
        'lblInactivity
        '
        Me.lblInactivity.AutoSize = True
        Me.lblInactivity.Location = New System.Drawing.Point(28, 412)
        Me.lblInactivity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInactivity.Name = "lblInactivity"
        Me.lblInactivity.Size = New System.Drawing.Size(180, 17)
        Me.lblInactivity.TabIndex = 111
        Me.lblInactivity.Text = "Inactivity Timeout (Minutes)"
        '
        'numTimeout
        '
        Me.numTimeout.Location = New System.Drawing.Point(396, 410)
        Me.numTimeout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numTimeout.Name = "numTimeout"
        Me.numTimeout.Size = New System.Drawing.Size(75, 22)
        Me.numTimeout.TabIndex = 112
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(788, 553)
        Me.ShapeContainer1.TabIndex = 113
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 553
        Me.LineShape4.X2 = 553
        Me.LineShape4.Y1 = 302
        Me.LineShape4.Y2 = 325
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 553
        Me.LineShape3.X2 = 577
        Me.LineShape3.Y1 = 313
        Me.LineShape3.Y2 = 313
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 528
        Me.LineShape2.X2 = 552
        Me.LineShape2.Y1 = 325
        Me.LineShape2.Y2 = 325
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 528
        Me.LineShape1.X2 = 552
        Me.LineShape1.Y1 = 302
        Me.LineShape1.Y2 = 302
        '
        'cmbAdminTaskType
        '
        Me.cmbAdminTaskType.FormattingEnabled = True
        Me.cmbAdminTaskType.Location = New System.Drawing.Point(396, 377)
        Me.cmbAdminTaskType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbAdminTaskType.Name = "cmbAdminTaskType"
        Me.cmbAdminTaskType.Size = New System.Drawing.Size(356, 24)
        Me.cmbAdminTaskType.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 382)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(285, 17)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Admin Task Type (for nightly task summary)"
        '
        'lblINRName
        '
        Me.lblINRName.AutoSize = True
        Me.lblINRName.Location = New System.Drawing.Point(28, 443)
        Me.lblINRName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblINRName.Name = "lblINRName"
        Me.lblINRName.Size = New System.Drawing.Size(204, 17)
        Me.lblINRName.TabIndex = 117
        Me.lblINRName.Text = "Dictionary Name for INR Result"
        '
        'txtINRName
        '
        Me.txtINRName.Location = New System.Drawing.Point(396, 439)
        Me.txtINRName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtINRName.Name = "txtINRName"
        Me.txtINRName.Size = New System.Drawing.Size(153, 22)
        Me.txtINRName.TabIndex = 116
        '
        'btnCDS
        '
        Me.btnCDS.BackColor = System.Drawing.Color.Plum
        Me.btnCDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnCDS.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCDS.Location = New System.Drawing.Point(552, 471)
        Me.btnCDS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCDS.Name = "btnCDS"
        Me.btnCDS.Size = New System.Drawing.Size(201, 27)
        Me.btnCDS.TabIndex = 118
        Me.btnCDS.Text = "C&DS Rule Definitions"
        Me.btnCDS.UseVisualStyleBackColor = False
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 553)
        Me.Controls.Add(Me.btnCDS)
        Me.Controls.Add(Me.lblINRName)
        Me.Controls.Add(Me.txtINRName)
        Me.Controls.Add(Me.cmbAdminTaskType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numTimeout)
        Me.Controls.Add(Me.lblInactivity)
        Me.Controls.Add(Me.cmbAdminUser)
        Me.Controls.Add(Me.lblAdminUser)
        Me.Controls.Add(Me.BtnTaskGeneration)
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
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSettings"
        Me.Text = "Protivantage Settings"
        CType(Me.NumMyInterval2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMyInterval1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDefaultOverdueInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskPriorityDEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTimeout, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnTaskGeneration As System.Windows.Forms.Button
    Friend WithEvents lblAdminUser As System.Windows.Forms.Label
    Friend WithEvents cmbAdminUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblInactivity As System.Windows.Forms.Label
    Friend WithEvents numTimeout As System.Windows.Forms.NumericUpDown
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmbAdminTaskType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblINRName As System.Windows.Forms.Label
    Friend WithEvents txtINRName As System.Windows.Forms.TextBox
    Friend WithEvents btnCDS As System.Windows.Forms.Button
End Class
