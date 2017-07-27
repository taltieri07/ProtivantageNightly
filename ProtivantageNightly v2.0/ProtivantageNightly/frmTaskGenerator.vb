Imports System.Data.SqlClient
Imports System.Configuration


Public Class frmTaskGenerator


    Private Sub SendAdminTask(ByVal TaskCount)

        Dim SelectStringAdmin As String          'Sql Query
        Dim ConnAdmin As SqlConnection     'represents unique connection to database
        Dim MyCommandAdmin As SqlCommand               'reads the records from database	
        Dim drAdmin As SqlDataReader       'stores the retrieved records
        Dim ConnStringAdmin As String                    'for connection to sql database
        Dim AdminUserName As String
        Dim AdminTaskType As String

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        'If found, return the connection string.
        If Not settings Is Nothing Then
            ConnStringAdmin = settings.ConnectionString
        End If

        ConnAdmin = New SqlConnection(ConnStringAdmin)     ' Creates connection
        ConnAdmin.Open()

        SelectStringAdmin = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommandAdmin = New SqlCommand(SelectStringAdmin, ConnAdmin)
        drAdmin = MyCommandAdmin.ExecuteReader

        While drAdmin.Read()

            If Not IsDBNull(drAdmin("AdminUser")) Then
                AdminUserName = drAdmin("AdminUser")
            Else
                AdminUserName = "NA"
            End If

            If Not IsDBNull(drAdmin("AdminTaskType")) Then
                AdminTaskType = drAdmin("AdminTaskType")
            Else
                AdminTaskType = "Miscellaneous"
            End If

        End While

        Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
        Dim MyToken As String

        Try
            'Unity Service generates a session token that has access as assigned by Allscripts
            MyToken = unitySvc.GetSecurityToken(serviceUser, servicePwd)
        Catch ex As Exception
            MsgBox(ex.InnerException)
            MsgBox(ex.Message)

            MsgBox("Session Not Established", vbOK)
            Exit Sub
        End Try

        If AdminUserName <> "NA" Then
            Dim MyDS As DataSet = unitySvc.Magic("SaveTask", twusername, appName, 0, MyToken, AdminTaskType, AdminUserName, 0, TaskCount & " Tasks Sent. Module ran to completion.", "Protivantage Nightly Task Summary:", "", Nothing)
        End If

        ConnAdmin.Close()
        unitySvc.RetireSecurityToken(serviceUser, servicePwd)


    End Sub


    Private Sub SendTask(ByVal PatID, ByVal NextINR, ByVal TaskOwner)


        Dim SelectStringSettings As String          'Sql Query
        Dim ConnSettingsInfo As SqlConnection     'represents unique connection to database
        Dim MyCommand As SqlCommand               'reads the records from database	
        Dim drSettingsInfo As SqlDataReader       'stores the retrieved records
        Dim ODTaskType As String
        Dim ODTaskPriority As String
        Dim ConnString As String                    'for connection to sql database

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        'If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnSettingsInfo = New SqlConnection(ConnString)     ' Creates connection
        ConnSettingsInfo.Open()

        SelectStringSettings = "Select * FROM tblSettings WHERE EnterpriseSetting = 1"
        MyCommand = New SqlCommand(SelectStringSettings, ConnSettingsInfo)
        drSettingsInfo = MyCommand.ExecuteReader

        While drSettingsInfo.Read()

            If Not IsDBNull(drSettingsInfo("DefaultOverdueTaskType")) Then
                ODTaskType = drSettingsInfo("DefaultOverdueTaskType")
            Else
                MsgBox("Unable to find default overdue task type.  Please check application settings.", vbOKOnly)
                ConnSettingsInfo.Close()
                Exit Sub
            End If

            If Not IsDBNull(drSettingsInfo("DefaultOverdueTaskPriority")) Then
                ODTaskPriority = drSettingsInfo("DefaultOverdueTaskPriority")
            Else
                ODTaskPriority = "Routine"
            End If


        End While

        Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
        Dim MyToken As String

        Try
            'Unity Service generates a session token that has access as assigned by Allscripts
            MyToken = unitySvc.GetSecurityToken(serviceUser, servicePwd)
        Catch ex As Exception
            MsgBox(ex.InnerException)
            MsgBox(ex.Message)

            MsgBox("Session Not Established", vbOK)
            Exit Sub
        End Try

        Dim TaskContent As String = "This patient is overdue for their PT/INR bloodwork.  Please check in the Chart " & _
            "Viewer to see if their results have recently been received.  If not, please call the patient and " & _
            "notify them that they should get PT/INR drawn as soon as possible. " & _
            vbCrLf & "The patient's PT/INR was due on " & NextINR & "."

        Dim TaskPriorityXML As String = "<taskdata><taskpriority>" & ODTaskPriority & "</taskpriority><subject>Patient Overdue for PT/INR</subject></taskdata>"


        Dim MyDS As DataSet = unitySvc.Magic("SaveTask", twusername, appName, PatID, MyToken, ODTaskType, TaskOwner, 0, TaskContent, TaskPriorityXML, "", Nothing)


        ConnSettingsInfo.Close()
        unitySvc.RetireSecurityToken(serviceUser, servicePwd)


    End Sub


    Private Sub frmTaskGenerator_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim ConnectionTasks As SqlConnection          'represents unique connection to database
        Dim CommandTasks As SqlCommand               'reads the records from database	
        Dim drTaskInfo As SqlDataReader            'stores the retrieved records
        Dim SelectString As String                  'Sql Query
        Dim ConnString As String                    'for connection to sql database
        Dim TaskCount As Integer = 0

        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("PVConnString")

        ' If found, return the connection string.
        If Not settings Is Nothing Then
            ConnString = settings.ConnectionString
        End If

        ConnectionTasks = New SqlConnection(ConnString)     ' Creates connection
        ConnectionTasks.Open()

        SelectString = "SELECT RecentTTD.*, tt.* FROM tblTherapy as tt INNER JOIN " & _
                            "(SELECT tblTherapyDetails.* FROM tblTherapyDetails INNER JOIN " & _
                                "(SELECT MAX(EvaluationDate) AS MaxEvalDate, PatientID " & _
                                "FROM tblTherapyDetails " & _
                                "GROUP BY PatientID) GroupedTTD " & _
                            "ON tblTherapyDetails.PatientID = GroupedTTD.PatientID and tblTherapyDetails.EvaluationDate = GroupedTTD.MaxEvalDate) RecentTTD " & _
                        "ON RecentTTD.PatientID = tt.PatientID " & _
                        "WHERE Notify = 1 and NextINR + NotifyInterval < GetDate() and (Inactive is null or Inactive = 0)"

       

        'vvvvvvvvvvvv*Temporary Code to test tasks*vvvvvvvvvvvvvvvv
        'Dim ThpDetailsAdapter As New SqlCeDataAdapter
        'Dim dsTaskDetails As New DataSet

        'ThpDetailsAdapter.SelectCommand = New SqlCeCommand(SelectString, ConnectionTasks)
        'ThpDetailsAdapter.Fill(dsTaskDetails, "tblTherapyDetails")

        'Dim TaskDetails As DataTable = dsTaskDetails.Tables("tblTherapyDetails")

        'Dim myView As DataView = New DataView(TaskDetails)

        'Me.TaskListDGView.DataSource = myView
        '^^^^^^^^^^^*Temporary Code to test tasks*^^^^^^^^^^^^^^^^^



        'vvvvvvvvvvv*Below will need to be uncommented*vvvvvvvvvvvvv
        CommandTasks = New SqlCommand(SelectString, ConnectionTasks)
        drTaskInfo = CommandTasks.ExecuteReader

        Do While drTaskInfo.Read()
            SendTask(drTaskInfo("PatientID"), drTaskInfo("NextINR"), drTaskInfo("TaskOwner"))
            TaskCount = TaskCount + 1
            'MsgBox("Task generated for " & drTaskInfo("PatientID"))
        Loop

        SendAdminTask(TaskCount)

        drTaskInfo.Close()

        Me.Close()

    End Sub
End Class
