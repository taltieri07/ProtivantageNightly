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
        CType(Me.RuleDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbChange
        '
        Me.cmbChange.FormattingEnabled = True
        Me.cmbChange.Items.AddRange(New Object() {"Increase Total Weekly Dose", "Decrease Total Weekly Dose", "Keep Total Weekly Dose the same"})
        Me.cmbChange.Location = New System.Drawing.Point(525, 12)
        Me.cmbChange.Name = "cmbChange"
        Me.cmbChange.Size = New System.Drawing.Size(187, 21)
        Me.cmbChange.TabIndex = 0
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Location = New System.Drawing.Point(718, 15)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(19, 13)
        Me.lblBy.TabIndex = 1
        Me.lblBy.Text = "By"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Location = New System.Drawing.Point(784, 15)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(15, 13)
        Me.lblPercent.TabIndex = 2
        Me.lblPercent.Text = "%"
        '
        'txtPercentChange
        '
        Me.txtPercentChange.Location = New System.Drawing.Point(743, 12)
        Me.txtPercentChange.Name = "txtPercentChange"
        Me.txtPercentChange.Size = New System.Drawing.Size(35, 20)
        Me.txtPercentChange.TabIndex = 3
        '
        'lblCriteria
        '
        Me.lblCriteria.AutoSize = True
        Me.lblCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCriteria.ForeColor = System.Drawing.Color.Indigo
        Me.lblCriteria.Location = New System.Drawing.Point(12, 12)
        Me.lblCriteria.Name = "lblCriteria"
        Me.lblCriteria.Size = New System.Drawing.Size(66, 17)
        Me.lblCriteria.TabIndex = 4
        Me.lblCriteria.Text = "Criteria:"
        '
        'lblCrit1
        '
        Me.lblCrit1.AutoSize = True
        Me.lblCrit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrit1.ForeColor = System.Drawing.Color.Black
        Me.lblCrit1.Location = New System.Drawing.Point(85, 15)
        Me.lblCrit1.Name = "lblCrit1"
        Me.lblCrit1.Size = New System.Drawing.Size(153, 13)
        Me.lblCrit1.TabIndex = 5
        Me.lblCrit1.Text = "1)  Reason for Therapy = "
        '
        'lblCrit2
        '
        Me.lblCrit2.AutoSize = True
        Me.lblCrit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrit2.ForeColor = System.Drawing.Color.Black
        Me.lblCrit2.Location = New System.Drawing.Point(85, 41)
        Me.lblCrit2.Name = "lblCrit2"
        Me.lblCrit2.Size = New System.Drawing.Size(48, 13)
        Me.lblCrit2.TabIndex = 6
        Me.lblCrit2.Text = "2)  INR"
        '
        'lblExisting
        '
        Me.lblExisting.AutoSize = True
        Me.lblExisting.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExisting.ForeColor = System.Drawing.Color.Indigo
        Me.lblExisting.Location = New System.Drawing.Point(12, 110)
        Me.lblExisting.Name = "lblExisting"
        Me.lblExisting.Size = New System.Drawing.Size(120, 18)
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
        Me.cmbReasonForTherapy.Location = New System.Drawing.Point(262, 11)
        Me.cmbReasonForTherapy.Name = "cmbReasonForTherapy"
        Me.cmbReasonForTherapy.Size = New System.Drawing.Size(148, 21)
        Me.cmbReasonForTherapy.TabIndex = 21
        '
        'cmbRelational1
        '
        Me.cmbRelational1.FormattingEnabled = True
        Me.cmbRelational1.Items.AddRange(New Object() {"=", ">", ">="})
        Me.cmbRelational1.Location = New System.Drawing.Point(142, 38)
        Me.cmbRelational1.Name = "cmbRelational1"
        Me.cmbRelational1.Size = New System.Drawing.Size(42, 21)
        Me.cmbRelational1.TabIndex = 22
        '
        'cmbRelational2
        '
        Me.cmbRelational2.FormattingEnabled = True
        Me.cmbRelational2.Items.AddRange(New Object() {"<", "<="})
        Me.cmbRelational2.Location = New System.Drawing.Point(262, 38)
        Me.cmbRelational2.Name = "cmbRelational2"
        Me.cmbRelational2.Size = New System.Drawing.Size(42, 21)
        Me.cmbRelational2.TabIndex = 23
        '
        'lblThen
        '
        Me.lblThen.AutoSize = True
        Me.lblThen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblThen.ForeColor = System.Drawing.Color.Indigo
        Me.lblThen.Location = New System.Drawing.Point(442, 15)
        Me.lblThen.Name = "lblThen"
        Me.lblThen.Size = New System.Drawing.Size(73, 17)
        Me.lblThen.TabIndex = 24
        Me.lblThen.Text = "Then do:"
        '
        'txtINRcompare1
        '
        Me.txtINRcompare1.Location = New System.Drawing.Point(190, 38)
        Me.txtINRcompare1.Name = "txtINRcompare1"
        Me.txtINRcompare1.Size = New System.Drawing.Size(35, 20)
        Me.txtINRcompare1.TabIndex = 25
        '
        'txtINRcompare2
        '
        Me.txtINRcompare2.Location = New System.Drawing.Point(310, 38)
        Me.txtINRcompare2.Name = "txtINRcompare2"
        Me.txtINRcompare2.Size = New System.Drawing.Size(35, 20)
        Me.txtINRcompare2.TabIndex = 26
        '
        'btnSaveRule
        '
        Me.btnSaveRule.BackColor = System.Drawing.Color.Plum
        Me.btnSaveRule.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveRule.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnSaveRule.Location = New System.Drawing.Point(349, 80)
        Me.btnSaveRule.Name = "btnSaveRule"
        Me.btnSaveRule.Size = New System.Drawing.Size(151, 23)
        Me.btnSaveRule.TabIndex = 119
        Me.btnSaveRule.Text = "&Save Rule Definition"
        Me.btnSaveRule.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(525, 81)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(56, 21)
        Me.btnClear.TabIndex = 120
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(819, 330)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(140, 21)
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
        Me.RuleDatagrid.Location = New System.Drawing.Point(19, 134)
        Me.RuleDatagrid.Name = "RuleDatagrid"
        Me.RuleDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.RuleDatagrid.ShowEditingIcon = False
        Me.RuleDatagrid.Size = New System.Drawing.Size(951, 183)
        Me.RuleDatagrid.TabIndex = 122
        '
        'lblAnd
        '
        Me.lblAnd.AutoSize = True
        Me.lblAnd.Location = New System.Drawing.Point(231, 42)
        Me.lblAnd.Name = "lblAnd"
        Me.lblAnd.Size = New System.Drawing.Size(25, 13)
        Me.lblAnd.TabIndex = 123
        Me.lblAnd.Text = "and"
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(743, 42)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(227, 20)
        Me.txtComment.TabIndex = 124
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.ForeColor = System.Drawing.Color.Black
        Me.lblComment.Location = New System.Drawing.Point(679, 45)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(58, 13)
        Me.lblComment.TabIndex = 125
        Me.lblComment.Text = "Comment"
        '
        'lblVariance
        '
        Me.lblVariance.AutoSize = True
        Me.lblVariance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVariance.ForeColor = System.Drawing.Color.Black
        Me.lblVariance.Location = New System.Drawing.Point(816, 15)
        Me.lblVariance.Name = "lblVariance"
        Me.lblVariance.Size = New System.Drawing.Size(105, 13)
        Me.lblVariance.TabIndex = 126
        Me.lblVariance.Text = "Variance Allowed"
        '
        'txtVariance
        '
        Me.txtVariance.Location = New System.Drawing.Point(935, 13)
        Me.txtVariance.Name = "txtVariance"
        Me.txtVariance.Size = New System.Drawing.Size(35, 20)
        Me.txtVariance.TabIndex = 127
        '
        'txtPriority
        '
        Me.txtPriority.Location = New System.Drawing.Point(525, 39)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.Size = New System.Drawing.Size(35, 20)
        Me.txtPriority.TabIndex = 129
        '
        'lblPriority
        '
        Me.lblPriority.AutoSize = True
        Me.lblPriority.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriority.ForeColor = System.Drawing.Color.Black
        Me.lblPriority.Location = New System.Drawing.Point(469, 42)
        Me.lblPriority.Name = "lblPriority"
        Me.lblPriority.Size = New System.Drawing.Size(46, 13)
        Me.lblPriority.TabIndex = 128
        Me.lblPriority.Text = "Priority"
        '
        'frmCDSRuleDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 364)
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
End Class
