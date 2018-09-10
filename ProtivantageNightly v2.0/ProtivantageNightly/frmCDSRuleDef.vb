Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmCDSRuleDef


    Private Sub frmCDSRuleDef_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        Dim ConnRuleInfo As SqlConnection
        Dim dsRuleDetails As New DataSet             'RuleDetails dataset
        Dim ConnString As String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnRuleInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnRuleInfo.Open()

        Dim qryDetails As String = "SELECT Priority, ReasonForTherapy, TargetInrRange, INRLowerLimit, INRUpperLimit, IncDec, PercentageChange, " & _
            "VarianceAllowed, Comment, NotificationOnly, Inactive FROM tblDosingAlgorithm WHERE (Inactive Is Null or Inactive = 0) ORDER BY Priority ASC"             'Sql Query for Therapy Details data grid"
        Dim RuleDetailsAdapter As New SqlDataAdapter         'Data Adapter for Therapy Details data grid view

        RuleDetailsAdapter.SelectCommand = New SqlCommand(qryDetails, ConnRuleInfo)
        RuleDetailsAdapter.Fill(dsRuleDetails, "tblDosingAlgorithm")

        Dim RuleDetails As DataTable = dsRuleDetails.Tables("tblDosingAlgorithm")
        Dim myView As DataView = New DataView(RuleDetails)

        Me.RuleDatagrid.DataSource = myView


        Me.RuleDatagrid.Columns(0).HeaderText = "Priority"
        Me.RuleDatagrid.Columns(1).HeaderText = "Reason For Therapy"
        Me.RuleDatagrid.Columns(2).HeaderText = "Target"
        Me.RuleDatagrid.Columns(3).HeaderText = "INR Range"
        Me.RuleDatagrid.Columns(4).HeaderText = "INR Range"
        Me.RuleDatagrid.Columns(5).HeaderText = "Suggested Change"
        Me.RuleDatagrid.Columns(6).HeaderText = "% Change"
        Me.RuleDatagrid.Columns(7).HeaderText = "Variance Allowed"
        Me.RuleDatagrid.Columns(8).HeaderText = "Comments"
        Me.RuleDatagrid.Columns(9).HeaderText = "Notification Only"
        Me.RuleDatagrid.Columns(10).HeaderText = "Inactive"

        Me.RuleDatagrid.Columns(0).Resizable = True
        Me.RuleDatagrid.Columns(1).Resizable = True
        Me.RuleDatagrid.Columns(2).Resizable = True
        Me.RuleDatagrid.Columns(3).Resizable = True
        Me.RuleDatagrid.Columns(4).Resizable = True
        Me.RuleDatagrid.Columns(5).Resizable = True
        Me.RuleDatagrid.Columns(6).Resizable = True
        Me.RuleDatagrid.Columns(7).Resizable = True
        Me.RuleDatagrid.Columns(8).Resizable = True
        Me.RuleDatagrid.Columns(9).Resizable = True
        Me.RuleDatagrid.Columns(10).Resizable = True

        Me.RuleDatagrid.ColumnHeadersHeight = 60

        Me.RuleDatagrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(0).Width = 50
        Me.RuleDatagrid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RuleDatagrid.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RuleDatagrid.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(3).Width = 50
        Me.RuleDatagrid.Columns(4).Width = 50
        Me.RuleDatagrid.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RuleDatagrid.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(6).Width = 58
        Me.RuleDatagrid.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Me.RuleDatagrid.Columns(7).Width = 62
        Me.RuleDatagrid.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.RuleDatagrid.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.RuleDatagrid.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Me.RuleDatagrid.Columns(0).ReadOnly = True
        Me.RuleDatagrid.Columns(1).ReadOnly = True
        Me.RuleDatagrid.Columns(2).ReadOnly = True
        Me.RuleDatagrid.Columns(3).ReadOnly = True
        Me.RuleDatagrid.Columns(4).ReadOnly = True
        Me.RuleDatagrid.Columns(5).ReadOnly = True
        Me.RuleDatagrid.Columns(6).ReadOnly = True
        Me.RuleDatagrid.Columns(7).ReadOnly = True
        Me.RuleDatagrid.Columns(8).ReadOnly = True
        Me.RuleDatagrid.Columns(9).ReadOnly = True
        Me.RuleDatagrid.Columns(10).ReadOnly = False

        ConnRuleInfo.Close()

    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

        Me.cmbReasonForTherapy.Text = ""
        Me.cmbRelational1.Text = ""
        Me.txtINRcompare1.Text = ""
        Me.cmbRelational2.Text = ""
        Me.txtINRcompare2.Text = ""
        Me.cmbChange.Text = ""
        Me.txtPercentChange.Text = ""
        Me.txtVariance.Text = ""
        Me.txtComment.Text = ""
        Me.cmbINRRange.Text = ""
        Me.txtPriority.Text = ""
        Me.chkNotification.Checked = False



    End Sub

    Private Sub btnReturn_Click(sender As System.Object, e As System.EventArgs) Handles btnReturn.Click

        If (Me.cmbReasonForTherapy.Text Is Nothing Or Me.cmbReasonForTherapy.Text = "") And (Me.cmbRelational1.Text Is Nothing Or Me.cmbRelational1.Text = "") And (Me.txtINRcompare1.Text Is Nothing Or Me.txtINRcompare1.Text = "") And (Me.cmbRelational2.Text Is Nothing Or Me.cmbRelational2.Text = "") And (Me.txtINRcompare2.Text Is Nothing Or Me.txtINRcompare2.Text = "") And (Me.cmbChange.Text Is Nothing Or Me.cmbChange.Text = "") And (Me.txtPercentChange.Text Is Nothing Or Me.txtPercentChange.Text = "") And (Me.txtVariance.Text Is Nothing Or Me.txtVariance.Text = "") And (Me.txtPriority.Text Is Nothing Or Me.txtPriority.Text = "") Then
            FrmSettings.Show()
            Me.Close()
        Else
            Dim CancelYN = MsgBox("Unsaved data exists in top section.  Are you sure you want to close without saving?", vbYesNo)

            If CancelYN = vbYes Then
                FrmSettings.Show()
                Me.Close()
            Else
                Exit Sub
            End If

        End If


    End Sub

    Private Sub btnSaveRule_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveRule.Click

        Dim ConnString As String                    'Connection String to CoumadinTracker
        Dim SelectString As String                  'Sql Query
        Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
        Dim MyCommand As SqlCommand               'reads the records from database	

        Dim DoseChange As String

        If Me.cmbChange.Text = "Increase Total Weekly Dose" Then
            DoseChange = "Increase"
        End If

        If Me.cmbChange.Text = "Decrease Total Weekly Dose" Then
            DoseChange = "Decrease"
        End If

        If Me.cmbChange.Text = "Increase Total Weekly Dose" Or Me.cmbChange.Text = "Decrease Total Weekly Dose" Then
            If Me.txtPercentChange.Text = "" Or Me.txtPercentChange.Text Is Nothing Then
                MsgBox("Please enter the suggested percentage " & DoseChange & ".", vbOKOnly, "Required field missing.")
                Me.txtPercentChange.Focus()
                Exit Sub
            End If
        End If

        If Not Me.cmbRelational1.Text Is Nothing And Me.cmbRelational1.Text <> "" Then
            If Me.txtINRcompare1.Text Is Nothing Or Me.txtINRcompare1.Text = "" Then
                MsgBox("Please enter the lower range of the INR value or remove the corresponding relational operator.", vbOKOnly, "Required field missing.")
                Me.txtINRcompare1.Focus()
                Exit Sub
            End If
        End If

        If Not Me.cmbRelational2.Text Is Nothing And Me.cmbRelational2.Text <> "" Then
            If Me.txtINRcompare2.Text Is Nothing Or Me.txtINRcompare2.Text = "" Then
                MsgBox("Please enter the upper range of the INR value or remove the corresponding relational operator.", vbOKOnly, "Required field missing.")
                Me.txtINRcompare2.Focus()
                Exit Sub
            End If
        End If

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        'do something about priority

        Dim PercentChange As Double

        If Me.txtPercentChange.Text = "" Or Me.txtPercentChange.Text Is Nothing Then
            PercentChange = 0
        Else
            PercentChange = Convert.ToDouble(Me.txtPercentChange.Text)
        End If

        Dim Notification As Integer

        If Me.chkNotification.Checked Then
            Notification = 1
        Else
            Notification = 0
        End If

        SelectString = "INSERT INTO tblDosingAlgorithm([Priority], [ReasonForTherapy], [TargetInrRange], [INRLowerLimit], [INRUpperLimit], [IncDec], [PercentageChange], [VarianceAllowed], " & _
            "[Comment], [NotificationOnly], [Inactive]) VALUES ('" & Me.txtPriority.Text & "', '" & Me.cmbReasonForTherapy.Text & "', '" & Me.cmbINRRange.Text & "', '" & Me.cmbRelational1.Text & " " & Me.txtINRcompare1.Text & _
            "', '" & Me.cmbRelational2.Text & " " & Me.txtINRcompare2.Text & "', '" & Me.cmbChange.Text & "', " & PercentChange & ", " & Me.txtVariance.Text & ", '" & Me.txtComment.Text & "', " & Notification & ", 0);"
        MsgBox(SelectString)

        MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
        MyCommand.ExecuteNonQuery()

        ConnSettingsInfo.Close()

        MsgBox("Clinical Decision Support rule has been added.", vbOKOnly, "Rule Definition")

        frmCDSRuleDef_Load(sender, e)

    End Sub


    Private Sub cmbChange_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbChange.SelectedIndexChanged

        If Me.cmbChange.Text = "Keep Total Weekly Dose the same" Then

            Me.lblBy.Visible = False
            Me.txtPercentChange.Visible = False
            Me.txtPercentChange.Text = ""
            Me.lblPercent.Visible = False

        Else

            Me.lblBy.Visible = True
            Me.txtPercentChange.Visible = True
            Me.lblPercent.Visible = True

        End If

    End Sub

End Class