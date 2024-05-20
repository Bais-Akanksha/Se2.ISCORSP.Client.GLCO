Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.AgentWelcomeLetter.Processors

#Region " AgentWelcomeLetter "

    Public Class AgentWelcomeLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AgentWelcomeLetter"
            MyBase.Name = "AgentWelcomeLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.AgentWelcomeLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AgentWelcomeLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AgentWelcomeLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AgentWelcomeLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AgentWelcomeLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AgentWelcomeLetter.CLM.Carrier)
            NotificationSeconds = 1
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try
        End Function

    End Class

#Region " AgentWelcomeLetter Redirect"

    Public Class AgentWelcomeLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AgentWelcomeLetterRedirect"
            MyBase.Name = "AgentWelcomeLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.AgentWelcomeLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.AgentWelcomeLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.AgentWelcomeLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.AgentWelcomeLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.AgentWelcomeLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AgentWelcomeLetter.CLM.Carrier)

            NotificationSeconds = 1
        End Sub

        Public Overrides Function InitDataSource() As Boolean
            Try
                Me.DataSource = New DataSource.BASE_DATA(Args.cmdLnArgs)
                Return True
            Catch
                Return False
            End Try
        End Function

    End Class

#End Region

#End Region

End Namespace
