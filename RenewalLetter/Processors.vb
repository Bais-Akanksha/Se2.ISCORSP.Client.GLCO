Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.RenewalLetter.Processors

#Region " RenewalLetter "

    Public Class RenewalLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.RenewalLetter"
            MyBase.Name = "RenewalLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.RenewalLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.RenewalLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.RenewalLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.RenewalLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.RenewalLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.RenewalLetter.CLM.Carrier)
            Me.[CLM].Add("RenewFunds", New GLCO.RenewalLetter.CLM.RenewFunds)
            Me.[CLM].Add("RenewFund", New GLCO.RenewalLetter.CLM.RenewFund)
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

#Region "RenewalLetterRedirect"

    Public Class RenewalLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.RenewalLetterRedirect"
            MyBase.Name = "RenewalLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.RenewalLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.RenewalLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.RenewalLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.RenewalLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.RenewalLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.RenewalLetter.CLM.Carrier)
            Me.[CLM].Add("RenewFunds", New GLCO.RenewalLetter.CLM.RenewFunds)
            Me.[CLM].Add("RenewFund", New GLCO.RenewalLetter.CLM.RenewFund)
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
