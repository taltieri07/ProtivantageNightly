<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCDSRuleDef
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
        Me.cmbChange = New System.Windows.Forms.ComboBox()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.txtPercentChange = New System.Windows.Forms.TextBox()
        Me.lblCriteria = New System.Windows.Forms.Label()
        Me.lblCrit1 = New System.Windows.Forms.Label()
        Me.lblCrit2 = New System.Windows.Forms.Label()
        Me.lblExisting = New System.Windows.Forms.Label()
        Me.cmbReasonForTherapy = New System.Windows.Forms.ComboBox()
        Me.cmbRelational1 = New System.Windows.Forms.ComboBox()
        Me.cmbRelational2 = New System.Windows.Forms.ComboBox()
        Me.lblThen = New System.Windows.Forms.Label()
        Me.txtINRcompare1 = New System.Windows.Forms.TextBox()
        Me.txtINRcompare2 = New System.Windows.Forms.TextBox()
        Me.btnSaveRule = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.RuleDatagrid = New System.Windows.Forms.DataGridView()
        Me.lblAnd = New System.Windows.Forms.Label()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblVariance = New System.Windows.Forms.Label()
        Me.txtVariance = New System.Windows.Forms.TextBox()
        Me.txtPriority = New System.Windows.Forms.TextBox()
        Me.lblPriority = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.cmbINRRange = New System.Windows.Forms.ComboBox()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.chkNotification = New System.Windows.Forms.CheckBox()
        CType(Me.RuleDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbChange
        '
        Me.cmbChange.FormattingEnabled = True
        Me.cmbChange.Items.AddRange(New Object() {"Increase Total Weekly Dose", "Decrease Total Weekly Dose", "Keep Total Weekly Dose the same"})
        Me.cmbChange.Location = New System.Drawing.Point(700, 15)
        Me.cmbChange.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbChange.Name = "cmbChange"
        Me.cmbChange.Size = New System.Drawing.Size(248, 24)
        Me.cmbChange.TabIndex = 0
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(957, 18)
        Me.lblBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(24, 17)
        Me.lblBy.TabIndex = 1
        Me.lblBy.Text = "By"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(1045, 18)
        Me.lblPercent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(20, 17)
        Me.lblPercent.TabIndex = 2
        Me.lblPercent.Text = "%"
        '
        'txtPercentChange
        '
        Me.txtPercentChange.Location = New System.Drawing.Point(991, 15)
        Me.txtPercentChange.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPercentChange.Name = "txtPercentChange"
        Me.txtPercentChange.Size = New System.Drawing.Size(45, 22)
        Me.txtPercentChange.TabIndex = 3
        '
        'lblCriteria
        '
        Me.lblCriteria.AutoSize = True
        Me.lblCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCriteria.ForeColor = System.Drawing.Color.Indigo
        Me.lblCriteria.Location = New System.Drawing.Point(16, 15)
        Me.lblCriteria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(78, 20)
        Me.lblCriteria.TabIndex = 4
        Me.lblCriteria.Text = "Criteria:"
        '
        'lblCrit1
        '
        Me.lblCrit1.AutoSize = True
        Me.lblCrit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrit1.ForeColor = System.Drawing.Color.Black
        Me.lblCrit1.Location = New System.Drawing.Point(113, 18)
        Me.lblCrit1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrit1.Name = "lblCrit1"
        Me.lblCrit1.Size = New System.Drawing.Size(197, 17)
        Me.lblCrit1.TabIndex = 5
        Me.lblCrit1.Text = "1)  Reason for Therapy = "
        '
        'lblCrit2
        '
        Me.lblCrit2.AutoSize = True
        Me.lblCrit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrit2.ForeColor = System.Drawing.Color.Black
        Me.lblCrit2.Location = New System.Drawing.Point(113, 81)
        Me.lblCrit2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrit2.Name = "lblCrit2"
        Me.lblCrit2.Size = New System.Drawing.Size(59, 17)
        Me.lblCrit2.TabIndex = 6
        Me.lblCrit2.Text = "3)  INR"
        '
        'lblExisting
        '
        Me.lblExisting.AutoSize = True
        Me.lblExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExisting.ForeColor = System.Drawing.Color.Indigo
        Me.lblExisting.Location = New System.Drawing.Point(16, 135)
        Me.lblExisting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExisting.Name = "lblExisting"
        Me.lblExisting.Size = New System.Drawing.Size(144, 22)
        Me.lblExisting.TabIndex = 9
        Me.lblExisting.Text = "Existing Rules:"
        '
        'cmbReasonForTherapy
        '
        Me.cmbReasonForTherapy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReasonForTherapy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReasonForTherapy.DropDownWidth = 200
        Me.cmbReasonForTherapy.FormattingEnabled = True
        Me.cmbReasonForTherapy.Items.AddRange(New Object() {"[any]", "Anticardiolipin Antibody Syndrome", "Artificial Heart Valves", "Atrial Fibrillation", "Atrial Flutter", "Cardiac Thrombus", "Cardiomyopathy", "CHF", "CVA", "DVT", "DVT/PE", "EVAR", "Factor 5", "Hypercoaguable State", "Intra-Abdominal Thrombosis", "Joint Replacement", "PE", "PFO", "Recurrent DVT", "Recurrent PE", "Stenting", "TIA", "Valvular Heart Disease"})
        Me.cmbReasonForTherapy.Location = New System.Drawing.Point(349, 14)
        Me.cmbReasonForTherapy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbReasonForTherapy.Name = "cmbReasonForTherapy"
        Me.cmbReasonForTherapy.Size = New System.Drawing.Size(196, 24)
        Me.cmbReasonForTherapy.TabIndex = 21
        '
        'cmbRelational1
        '
        Me.cmbRelational1.FormattingEnabled = True
        Me.cmbRelational1.Items.AddRange(New Object() {"=", ">", ">="})
        Me.cmbRelational1.Location = New System.Drawing.Point(189, 77)
        Me.cmbRelational1.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRelational1.Name = "cmbRelational1"
        Me.cmbRelational1.Size = New System.Drawing.Size(55, 24)
        Me.cmbRelational1.TabIndex = 22
        '
        'cmbRelational2
        '
        Me.cmbRelational2.FormattingEnabled = True
        Me.cmbRelational2.Items.AddRange(New Object() {"<", "<="})
        Me.cmbRelational2.Location = New System.Drawing.Point(349, 77)
        Me.cmbRelational2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRelational2.Name = "cmbRelational2"
        Me.cmbRelational2.Size = New System.Drawing.Size(55, 24)
        Me.cmbRelational2.TabIndex = 23
        '
        'lblThen
        '
        Me.lblThen.AutoSize = True
        Me.lblThen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblThen.ForeColor = System.Drawing.Color.Indigo
        Me.lblThen.Location = New System.Drawing.Point(589, 18)
        Me.lblThen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThen.Name = "lblThen"
        Me.lblThen.Size = New System.Drawing.Size(82, 20)
        Me.lblThen.TabIndex = 24
        Me.lblThen.Text = "Then do:"
        '
        'txtINRcompare1
        '
        Me.txtINRcompare1.Location = New System.Drawing.Point(253, 77)
        Me.txtINRcompare1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtINRcompare1.Name = "txtINRcompare1"
        Me.txtINRcompare1.Size = New System.Drawing.Size(45, 22)
        Me.txtINRcompare1.TabIndex = 25
        '
        'txtINRcompare2
        '
        Me.txtINRcompare2.Location = New System.Drawing.Point(413, 77)
        Me.txtINRcompare2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtINRcompare2.Name = "txtINRcompare2"
        Me.txtINRcompare2.Size = New System.Drawing.Size(45, 22)
        Me.txtINRcompare2.TabIndex = 26
        '
        'btnSaveRule
        '
        Me.btnSaveRule.BackColor = System.Drawing.Color.Plum
        Me.btnSaveRule.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveRule.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSaveRule.Location = New System.Drawing.Point(465, 109)
        Me.btnSaveRule.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveRule.Name = "btnSaveRule"
        Me.btnSaveRule.Size = New System.Drawing.Size(201, 28)
        Me.btnSaveRule.TabIndex = 119
        Me.btnSaveRule.Text = "&Save Rule Definition"
        Me.btnSaveRule.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(700, 111)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 26)
        Me.btnClear.TabIndex = 120
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(1092, 406)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(187, 26)
        Me.btnReturn.TabIndex = 121
        Me.btnReturn.Text = "&Return to Settings"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'RuleDatagrid
        '
        Me.RuleDatagrid.AllowUserToAddRows = False
        Me.RuleDatagrid.AllowUserToDeleteRows = False
        Me.RuleDatagrid.AllowUserToResizeRows = False
        Me.RuleDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.RuleDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.RuleDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.RuleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RuleDatagrid.Location = New System.Drawing.Point(25, 165)
        Me.RuleDatagrid.Margin = New System.Windows.Forms.Padding(4)
        Me.RuleDatagrid.Name = "RuleDatagrid"
        Me.RuleDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RuleDatagrid.ShowEditingIcon = False
        Me.RuleDatagrid.Size = New System.Drawing.Size(1268, 225)
        Me.RuleDatagrid.TabIndex = 122
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(308, 82)
        Me.lblAnd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(32, 17)
        Me.lblAnd.TabIndex = 123
        Me.lblAnd.Text = "and"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(991, 52)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(301, 22)
        Me.txtComment.TabIndex = 124
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.ForeColor = System.Drawing.Color.Black
        Me.lblComment.Location = New System.Drawing.Point(905, 55)
        Me.lblComment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(74, 17)
        Me.lblComment.TabIndex = 125
        Me.lblComment.Text = "Comment"
        '
        'lblVariance
        '
        Me.lblVariance.AutoSize = True
        Me.lblVariance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariance.ForeColor = System.Drawing.Color.Black
        Me.lblVariance.Location = New System.Drawing.Point(1088, 18)
        Me.lblVariance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariance.Name = "lblVariance"
        Me.lblVariance.Size = New System.Drawing.Size(132, 17)
        Me.lblVariance.TabIndex = 126
        Me.lblVariance.Text = "Variance Allowed"
        '
        'txtVariance
        '
        Me.txtVariance.Location = New System.Drawing.Point(1247, 16)
        Me.txtVariance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVariance.Name = "txtVariance"
        Me.txtVariance.Size = New System.Drawing.Size(45, 22)
        Me.txtVariance.TabIndex = 127
        '
        'txtPriority
        '
        Me.txtPriority.Location = New System.Drawing.Point(700, 48)
        Me.txtPriority.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(45, 22)
        Me.txtPriority.TabIndex = 129
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.ForeColor = System.Drawing.Color.Black
        Me.lblPriority.Location = New System.Drawing.Point(625, 52)
        Me.lblPriority.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(60, 17)
        Me.lblPriority.TabIndex = 128
        Me.lblPriority.Text = "Priority"
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarget.ForeColor = System.Drawing.Color.Black
        Me.lblTarget.Location = New System.Drawing.Point(113, 50)
        Me.lblTarget.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(178, 17)
        Me.lblTarget.TabIndex = 130
        Me.lblTarget.Text = "2)  Target INR Range ="
        '
        'cmbINRRange
        '
        Me.cmbINRRange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbINRRange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbINRRange.FormattingEnabled = True
        Me.cmbINRRange.Items.AddRange(New Object() {"1.8 - 2.0", "1.8 - 2.3", "2.0 - 2.5", "2.0 - 3.0", "2.0 - 4.0", "2.5 - 3.0", "2.5 - 3.5", "3.0 - 4.0"})
        Me.cmbINRRange.Location = New System.Drawing.Point(349, 45)
        Me.cmbINRRange.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbINRRange.Name = "cmbINRRange"
        Me.cmbINRRange.Size = New System.Drawing.Size(149, 24)
        Me.cmbINRRange.TabIndex = 131
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotification.ForeColor = System.Drawing.Color.Black
        Me.lblNotification.Location = New System.Drawing.Point(557, 82)
        Me.lblNotification.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(128, 17)
        Me.lblNotification.TabIndex = 132
        Me.lblNotification.Text = "Notification Only"
        '
        'chkNotification
        '
        Me.chkNotification.AutoSize = True
        Me.chkNotification.Location = New System.Drawing.Point(700, 79)
        Me.chkNotification.Name = "chkNotification"
        Me.chkNotification.Size = New System.Drawing.Size(18, 17)
        Me.chkNotification.TabIndex = 133
        Me.chkNotification.UseVisualStyleBackColor = True
        '
        'frmCDSRuleDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 448)
        Me.Controls.Add(Me.chkNotification)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.cmbINRRange)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.txtPriority)
        Me.Controls.Add(Me.lblPriority)
        Me.Controls.Add(Me.txtVariance)
        Me.Controls.Add(Me.lblVariance)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblAnd)
        Me.Controls.Add(Me.RuleDatagrid)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveRule)
        Me.Controls.Add(Me.txtINRcompare2)
        Me.Controls.Add(Me.txtINRcompare1)
        Me.Controls.Add(Me.lblThen)
        Me.Controls.Add(Me.cmbRelational2)
        Me.Controls.Add(Me.cmbRelational1)
        Me.Controls.Add(Me.cmbReasonForTherapy)
        Me.Controls.Add(Me.lblExisting)
        Me.Controls.Add(Me.lblCrit2)
        Me.Controls.Add(Me.lblCrit1)
        Me.Controls.Add(Me.lblCriteria)
        Me.Controls.Add(Me.txtPercentChange)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.cmbChange)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCDSRuleDef"
        Me.Text = "CDS Rule Definitions"
        CType(Me.RuleDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbChange As System.Windows.Forms.ComboBox
    Friend WithEvents lblBy As System.Windows.Forms.Label
    Friend WithEvents lblPercent As System.Windows.Forms.Label
    Friend WithEvents txtPercentChange As System.Windows.Forms.TextBox
    Friend WithEvents lblCriteria As System.Windows.Forms.Label
    Friend WithEvents lblCrit1 As System.Windows.Forms.Label
    Friend WithEvents lblCrit2 As System.Windows.Forms.Label
    Friend WithEvents lblExisting As System.Windows.Forms.Label
    Friend WithEvents cmbReasonForTherapy As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRelational1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRelational2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblThen As System.Windows.Forms.Label
    Friend WithEvents txtINRcompare1 As System.Windows.Forms.TextBox
    Friend WithEvents txtINRcompare2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveRule As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents RuleDatagrid As System.Windows.Forms.DataGridView
    Friend WithEvents lblAnd As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents lblVariance As System.Windows.Forms.Label
    Friend WithEvents txtVariance As System.Windows.Forms.TextBox
    Friend WithEvents txtPriority As System.Windows.Forms.TextBox
    Friend WithEvents lblPriority As System.Windows.Forms.Label
    Friend WithEvents lblTarget As System.Windows.Forms.Label
    Friend WithEvents cmbINRRange As System.Windows.Forms.ComboBox
    Friend WithEvents lblNotification As System.Windows.Forms.Label
    Friend WithEvents chkNotification As System.Windows.Forms.CheckBox
End Class
