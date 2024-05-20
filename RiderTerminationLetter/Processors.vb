Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.RiderTerminationLetter.Processors

#Region " RiderTerminationLetter "

    Public Class RiderTerminationLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.RiderTerminationLetter"
            MyBase.Name = "RiderTerminationLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.RiderTerminationLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.RiderTerminationLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.RiderTerminationLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.RiderTerminationLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.RiderTerminationLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.RiderTerminationLetter.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.RiderTerminationLetter.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.RiderTerminationLetter.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.RiderTerminationLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.RiderTerminationLetter.CLM.PolValue)
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

#Region "RiderTerminationLetterRedirect"

    Public Class RiderTerminationLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.RiderTerminationLetterRedirect"
            MyBase.Name = "RiderTerminationLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.RiderTerminationLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.RiderTerminationLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.RiderTerminationLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.RiderTerminationLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.RiderTerminationLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.RiderTerminationLetter.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.RiderTerminationLetter.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.RiderTerminationLetter.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.RiderTerminationLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.RiderTerminationLetter.CLM.PolValue)
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
