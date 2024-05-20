Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.ADLStartLetter.Processors

#Region " ADLStartLetter "

    Public Class ADLStartLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ADLStartLetter"
            MyBase.Name = "ADLStartLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ADLStartLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ADLStartLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ADLStartLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ADLStartLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ADLStartLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ADLStartLetter.CLM.Carrier)
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

#Region " ADLStartLetter Redirect"

    Public Class ADLStartLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ADLStartLetterRedirect"
            MyBase.Name = "ADLStartLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ADLStartLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ADLStartLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ADLStartLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ADLStartLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ADLStartLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ADLStartLetter.CLM.Carrier)

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
