Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.DNQLetter.Processors

#Region " DNQLetter "

    Public Class DNQLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.DNQLetter"
            MyBase.Name = "DNQLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.DNQLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.DNQLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.DNQLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.DNQLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.DNQLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.DNQLetter.CLM.Carrier)
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

#Region " DNQLetter Redirect"

    Public Class DNQLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.DNQLetterRedirect"
            MyBase.Name = "DNQLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.DNQLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.DNQLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.DNQLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.DNQLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.DNQLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.DNQLetter.CLM.Carrier)

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
