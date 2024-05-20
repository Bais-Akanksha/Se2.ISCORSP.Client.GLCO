Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.CostBasisLetter.Processors

#Region " CostBasisLetter "

    Public Class CostBasisLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.CostBasisLetter"
            MyBase.Name = "CostBasisLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.CostBasisLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.CostBasisLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.CostBasisLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.CostBasisLetter.CLM.Role)
            Me.[CLM].Add("Exchanges", New GLCO.CostBasisLetter.CLM.Exchanges)
            Me.[CLM].Add("Exchange", New GLCO.CostBasisLetter.CLM.Exchange)
            Me.[CLM].Add("CarrierInformation", New GLCO.CostBasisLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.CostBasisLetter.CLM.Carrier)
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

#Region " CostBasisLetter Redirect"

    Public Class CostBasisLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.CostBasisLetterRedirect"
            MyBase.Name = "CostBasisLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.CostBasisLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.CostBasisLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.CostBasisLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.CostBasisLetter.CLM.Role)
            Me.[CLM].Add("Exchanges", New GLCO.CostBasisLetter.CLM.Exchanges)
            Me.[CLM].Add("Exchange", New GLCO.CostBasisLetter.CLM.Exchange)
            Me.[CLM].Add("CarrierInformation", New GLCO.CostBasisLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.CostBasisLetter.CLM.Carrier)

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
