Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.AnnualRMDAgentLetter.Processors

#Region " AnnualRMDAgentLetter "

    Public Class AnnualRMDAgentLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AnnualRMDAgentLetter"
            MyBase.Name = "AnnualRMDAgentLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("InvestAdvisors", New GLCO.AnnualRMDAgentLetter.CLM.InvestAdvisors)
            Me.[CLM].Add("InvestAdvisor", New GLCO.AnnualRMDAgentLetter.CLM.InvestAdvisor)
            Me.[CLM].Add("CarrierInformation", New GLCO.AnnualRMDAgentLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AnnualRMDAgentLetter.CLM.Carrier)
            Me.[CLM].Add("Clients", New GLCO.AnnualRMDAgentLetter.CLM.Clients)
            Me.[CLM].Add("Client", New GLCO.AnnualRMDAgentLetter.CLM.Client)
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

#Region " AnnualRMDAgentLetter Redirect"

    Public Class AnnualRMDAgentLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.AnnualRMDAgentLetterRedirect"
            MyBase.Name = "AnnualRMDAgentLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("InvestAdvisors", New GLCO.AnnualRMDAgentLetter.CLM.InvestAdvisors)
            Me.[CLM].Add("InvestAdvisor", New GLCO.AnnualRMDAgentLetter.CLM.InvestAdvisor)
            Me.[CLM].Add("CarrierInformation", New GLCO.AnnualRMDAgentLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.AnnualRMDAgentLetter.CLM.Carrier)
            Me.[CLM].Add("Clients", New GLCO.AnnualRMDAgentLetter.CLM.Clients)
            Me.[CLM].Add("Client", New GLCO.AnnualRMDAgentLetter.CLM.Client)

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
