Imports System.Data.SqlClient
Imports System.Configuration

Public Class Form1

    Dim ConnAllscripts As SqlConnection       'connection to Works database
    Dim ConnString As String                    'Connection String to CoumadinTracker
    Dim ConnStringAHS As String                 'Connection String to Works
    Dim SelectString As String                  'Sql Query
    Dim SelectStringSettings As String          'Sql Query
    Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
    Dim MyCommand As SqlCommand               'reads the records from database	
    Dim drSettingsInfo As SqlDataReader       'stores the retrieved records


    Private Sub FrmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim MyToken As String
        Dim unitySvc As UnityServiceClient = New UnityServiceClient("basichttp")
        ' Obtain security token
        Try
            ' Unity Service generates a session token that has access as assigned by Allscripts
            MyToken = unitySvc.GetSecurityToken(serviceUser, servicePwd)

        Catch ex As Exception
            MsgBox(ex.InnerException)
            MsgBox(ex.Message)

            MsgBox("Session Not Established", vbOK)
            Exit Sub

            ' Do something with exception.  Could not obtain token.
        End Try

        Dim MyDS As DataSet = unitySvc.Magic("GetDictionary", twusername, appName, "", MyToken, "Task_Priority_DE", "", "", "", "", "", Nothing)
        Dim TaskPriorityTable = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable
        Dim TaskPriorityTable2 = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable

        With Me.cmbTaskPriority
            .DisplayMember = "EntryName"
            .ValueMember = "ID"
            .DataSource = TaskPriorityTable
            .SelectedIndex = 0
            .Enabled = True
        End With

        With Me.cmbODTaskPriority
            .DisplayMember = "EntryName"
            .ValueMember = "ID"
            .DataSource = TaskPriorityTable2
            .SelectedIndex = 0
            .Enabled = True
        End With

        MyDS = unitySvc.Magic("GetDictionary", twusername, appName, "", MyToken, "IDX_Task_Action_DE", "", "", "", "", "", Nothing)
        Dim TaskNameTable = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable
        Dim TaskNameTable2 = MyDS.Tables(0).Select("Active = 'Y'").CopyToDataTable

        With Me.cmbTaskType
            .DisplayMember = "EntryName"
            .ValueMember = "EntryMnemonic"
            .DataSource = TaskNameTable
            .SelectedIndex = 0
            .Enabled = True
        End With

        With Me.cmbODTaskType
            .DisplayMember = "EntryName"
            .ValueMember = "EntryMnemonic"
            .DataSource = TaskNameTable2
            .SelectedIndex = 0
            .Enabled = True
        End With

        MyDS = unitySvc.Magic("GetDocumentType", twusername, appName, "", MyToken, "", "", "", "", "", "", Nothing)

        Dim NoteTypeTable As DataTable = MyDS.Tables(0)

        With Me.cmbNoteType
            .DisplayMember = "DisplayName"
            .ValueMember = "DisplayName"
            .DataSource = NoteTypeTable
            .SelectedIndex = 0
            .Enabled = True
        End With

        'MyDS = unitySvc.Magic("GetTaskList", UserName, appName, "", MyToken, "", "", "", "", "", "", Nothing)

        'Dim TaskListTable As DataTable = MyDS.Tables(0)

        'Dim myTaskView As DataView = New DataView(TaskListTable)

        'Me.doctypes.DataSource = myTaskView

        unitySvc.RetireSecurityToken(serviceUser, servicePwd)

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()
            If Not IsDBNull(drSettingsInfo("FlowsheetName")) Then
                Me.txtFlowsheet.Text = drSettingsInfo("FlowsheetName")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultOverdueInterval")) Then
                Me.NumDefaultOverdueInterval.Value = drSettingsInfo("DefaultOverdueInterval")
            End If

            If Not IsDBNull(drSettingsInfo("OverdueIntervalAllowOverride")) Then
                Me.ChkAllow1.Checked = drSettingsInfo("OverdueIntervalAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultNotify")) Then
                Me.ChkDefaultNotify.Checked = drSettingsInfo("DefaultNotify")
            End If

            If Not IsDBNull(drSettingsInfo("NotifyAllowOverride")) Then
                Me.ChkAllow2.Checked = drSettingsInfo("NotifyAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultTaskPriority")) Then
                Me.cmbTaskPriority.SelectedValue = drSettingsInfo("DefaultTaskPriority")
            End If

            If Not IsDBNull(drSettingsInfo("TaskPriorityAllowOverride")) Then
                Me.ChkAllow3.Checked = drSettingsInfo("TaskPriorityAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultTaskType")) Then
                Me.cmbTaskType.SelectedValue = drSettingsInfo("DefaultTaskType")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultNoteType")) Then
                Me.cmbNoteType.SelectedValue = drSettingsInfo("DefaultNoteType")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultOverdueTaskPriority")) Then
                Me.cmbODTaskPriority.SelectedValue = drSettingsInfo("DefaultOverdueTaskPriority")
            End If

            If Not IsDBNull(drSettingsInfo("DefaultOverdueTaskType")) Then
                Me.cmbODTaskType.SelectedValue = drSettingsInfo("DefaultOverdueTaskType")
            End If

            If Not IsDBNull(drSettingsInfo("MyInterval1")) Then
                Me.NumMyInterval1.Value = drSettingsInfo("MyInterval1")
            End If

            If Not IsDBNull(drSettingsInfo("MyInterval2")) Then
                Me.NumMyInterval2.Value = drSettingsInfo("MyInterval2")
            End If

            If Not IsDBNull(drSettingsInfo("OverdueTaskPriorityAllowOverride")) Then
                Me.ChkAllow4.Checked = drSettingsInfo("OverdueTaskPriorityAllowOverride")
            End If

            If Not IsDBNull(drSettingsInfo("MyIntervalsAllowOverride")) Then
                Me.ChkAllow5.Checked = drSettingsInfo("MyIntervalsAllowOverride")
            End If

        End While

        Me.ChkEdited.Checked = False

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click

        Dim UserResponse As MsgBoxResult

        If Me.ChkEdited.Checked = True Then
            UserResponse = MsgBox("Changes have not been saved.  Do you wish to save your changes?", MsgBoxStyle.YesNoCancel, "Save changes?")

            If UserResponse = MsgBoxResult.Yes Then
                BtnSave_Click(sender, e)
            ElseIf UserResponse = MsgBoxResult.No Then
                Me.Close()
            ElseIf UserResponse = MsgBoxResult.Cancel Then
                Exit Sub
            End If

        End If

        Me.Close()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If Me.txtFlowsheet.Text = "" Or Me.txtFlowsheet.Text Is Nothing Then
            MsgBox("Flowsheet cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.txtFlowsheet.Focus()
            Exit Sub
        End If


        If Me.cmbTaskPriority.SelectedValue Is Nothing Then
            MsgBox("Default Task Priority cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.cmbTaskPriority.Focus()
            Exit Sub
        End If

        If Me.cmbTaskType.SelectedValue = "" Or Me.cmbTaskType.SelectedValue Is Nothing Then
            MsgBox("Notification Task Type cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.cmbTaskType.Focus()
            Exit Sub
        End If

        If Me.cmbNoteType.SelectedValue = "" Or Me.cmbNoteType.SelectedValue Is Nothing Then
            MsgBox("Note Type cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.cmbNoteType.Focus()
            Exit Sub
        End If

        If Me.cmbODTaskPriority.SelectedValue Is Nothing Then
            MsgBox("Default Overdue Task Priority cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.cmbODTaskPriority.Focus()
            Exit Sub
        End If

        If Me.cmbODTaskType.SelectedValue = "" Or Me.cmbODTaskType.SelectedValue Is Nothing Then
            MsgBox("Overdue Task Type cannot be null.  Please select a value.", vbOKOnly, "Required field missing.")
            Me.cmbODTaskType.Focus()
            Exit Sub
        End If


        Dim IntCount As Integer

        'Dim TaskPriorityID As Integer
        'Dim TaskStatusID As Integer

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectString = "Select Count(*) as returncount FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
        IntCount = MyCommand.ExecuteScalar

        If IntCount = 0 Then
            SelectString = "INSERT INTO tblSettings([EnterpriseSetting], [FlowsheetName], [DefaultOverdueInterval], " & _
                "[OverdueIntervalAllowOverride], [DefaultNotify], [NotifyAllowOverride], [DefaultTaskPriority], [TaskPriorityAllowOverride], [DefaultTaskType], [DefaultNoteType], [DefaultOverdueTaskType], [DefaultOverdueTaskPriority], " & _
                "[MyInterval1], [MyInterval2], [OverdueTaskPriorityAllowOverride], [MyIntervalsAllowOverride]) VALUES (1, '" & Me.txtFlowsheet.Text & "', " & Me.NumDefaultOverdueInterval.Value & ", " & _
                Me.ChkAllow1.CheckState & ", " & Me.ChkDefaultNotify.CheckState & ", " & Me.ChkAllow2.CheckState & ", '" & Me.cmbTaskPriority.SelectedValue & "', " & Me.ChkAllow3.CheckState & ", '" & Me.cmbTaskType.SelectedValue & "', '" & Me.cmbNoteType.SelectedValue & "', '" & _
                Me.cmbODTaskType.SelectedValue & "', '" & Me.cmbODTaskPriority.SelectedValue & "', " & Me.NumMyInterval1.Value & ", " & Me.NumMyInterval2.Value & ", " & Me.ChkAllow4.CheckState & ", " & Me.ChkAllow5.CheckState & ");"

            MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
            MyCommand.ExecuteNonQuery()
        ElseIf IntCount = 1 Then
            SelectString = "UPDATE tblSettings SET [EnterpriseSetting] = 1, [FlowsheetName] = '" & Me.txtFlowsheet.Text & _
                "', [DefaultOverdueInterval] = " & Me.NumDefaultOverdueInterval.Value & ", [OverdueIntervalAllowOverride] = " & Me.ChkAllow1.CheckState & _
                ", [DefaultNotify] = " & Me.ChkDefaultNotify.CheckState & ", [NotifyAllowOverride] = " & Me.ChkAllow2.CheckState & ", [DefaultTaskPriority] = " & _
                Me.cmbTaskPriority.SelectedValue & ", [TaskPriorityAllowOverride] = " & Me.ChkAllow3.CheckState & ", [DefaultTaskType] = '" & Me.cmbTaskType.SelectedValue & "', [DefaultNoteType] = '" & Me.cmbNoteType.SelectedValue & _
                "', [DefaultOverdueTaskType] = '" & Me.cmbODTaskType.SelectedValue & "', [DefaultOverdueTaskPriority] = '" & Me.cmbODTaskPriority.SelectedValue & "', [MyInterval1] = " & Me.NumMyInterval1.Value & ", [MyInterval2] = " & _
                Me.NumMyInterval2.Value & ", [OverdueTaskPriorityAllowOverride] = " & Me.ChkAllow4.CheckState & ", [MyIntervalsAllowOverride] = " & Me.ChkAllow5.CheckState & " WHERE [EnterpriseSetting] = 1;"

            MyCommand = New SqlCommand(SelectString, ConnSettingsInfo)
            MyCommand.ExecuteNonQuery()

        End If

        MsgBox("Settings have been saved.", MsgBoxStyle.OkOnly, "Enterprise Settings Saved.")
        Me.Close()

    End Sub

    Private Sub txtFlowsheet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFlowsheet.TextChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtINRCOde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumDefaultOverdueInterval_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumDefaultOverdueInterval.ValueChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllow1.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkDefaultNotify_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDefaultNotify.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllow2.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbTaskPriority_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTaskPriority.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAllow3.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtPTDisplayAs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub txtINRDisplayAs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumMyInterval1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMyInterval1.ValueChanged

        If Me.NumMyInterval1.Value > 365 Then
            MsgBox("Please enter a value between 1 and 365.", MsgBoxStyle.OkOnly, "Invalid Entry!")
        End If

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub NumMyInterval2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMyInterval2.ValueChanged

        If Me.NumMyInterval2.Value > 365 Then
            MsgBox("Please enter a value between 1 and 365.", MsgBoxStyle.OkOnly, "Invalid Entry!")
        End If

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbTaskType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTaskType.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub


    Private Sub cmbNoteType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNoteType.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbODTaskPriority_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbODTaskPriority.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub cmbODTaskType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbODTaskType.SelectedIndexChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkAllow4.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub

    Private Sub ChkAllow5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkAllow5.CheckedChanged

        Me.ChkEdited.Checked = True

    End Sub
End Class


End Class