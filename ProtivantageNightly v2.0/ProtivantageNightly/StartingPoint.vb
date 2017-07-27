Imports System
Imports System.Configuration
Imports System.ServiceModel.Configuration


Module StartingPoint

    Public Sub Main(ByVal Params() As String)

        Dim appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim serviceModel = ServiceModelSectionGroup.GetSectionGroup(appConfig)
        Dim bindings = serviceModel.Bindings
        Dim endpoints = serviceModel.Client.Endpoints

        Dim endpointElement = endpoints(0)
        Dim EndpointAddress As String = endpointElement.Address.OriginalString

        If EndpointAddress.ToUpper.StartsWith("HTTPS") Then
            BindingType = "securehttp"
        Else
            BindingType = "basichttp"
        End If


        Dim unitySvc As UnityServiceClient = New UnityServiceClient(BindingType)
        Dim MyToken As String

        twusername = System.Configuration.ConfigurationManager.AppSettings("EHRUsername")
        twpassword = System.Configuration.ConfigurationManager.AppSettings("EHRPassword")
        serviceUser = System.Configuration.ConfigurationManager.AppSettings("ServiceUser")
        servicePwd = System.Configuration.ConfigurationManager.AppSettings("ServicePwd")
        appName = System.Configuration.ConfigurationManager.AppSettings("appName")

        'MsgBox(twusername & ", " & twpassword & ", " & serviceUser & ", " & servicePwd & ", " & appName)

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

        Dim MyDS1 As DataSet = unitySvc.Magic("GetUserAuthentication", twusername, appName, "", MyToken, twpassword, "", "", "", "", "", Nothing)

        If MyDS1.Tables(0).Rows(0)("ValidUser") <> "YES" Then
            MsgBox("There is a problem with the EHR user identified in ProtivantageNightly.exe.config.  Please notify your administrator.", vbOKOnly)
            Exit Sub
        End If

        Dim MyDS2 As DataSet = unitySvc.Magic("GetServerInfo", twusername, appName, "", MyToken, "", "", "", "", "", "", Nothing)


        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If Params.Count = 0 Then
            Application.Run(New FrmSettings)
            'MsgBox("Manually Opened")
        Else
            Application.Run(New frmTaskGenerator)
            'MsgBox("Scheduled Task")
        End If

    End Sub

End Module