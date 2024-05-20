Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.ADLEndLetter.Processors

#Region " ADLEndLetter "

    Public Class ADLEndLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ADLEndLetter"
            MyBase.Name = "ADLEndLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ADLEndLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ADLEndLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ADLEndLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ADLEndLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ADLEndLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ADLEndLetter.CLM.Carrier)
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

#Region " ADLEndLetter Redirect"

    Public Class ADLEndLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ADLEndLetterRedirect"
            MyBase.Name = "ADLEndLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ADLEndLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ADLEndLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ADLEndLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ADLEndLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ADLEndLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ADLEndLetter.CLM.Carrier)

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
