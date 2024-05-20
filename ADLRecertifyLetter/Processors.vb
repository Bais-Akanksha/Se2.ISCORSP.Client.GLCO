Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.ADLRecertifyLetter.Processors

#Region " ADLRecertifyLetter "

    Public Class ADLRecertifyLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ADLRecertifyLetter"
            MyBase.Name = "ADLRecertifyLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ADLRecertifyLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ADLRecertifyLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ADLRecertifyLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ADLRecertifyLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ADLRecertifyLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ADLRecertifyLetter.CLM.Carrier)
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

#Region " ADLRecertifyLetter Redirect"

    Public Class ADLRecertifyLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.ADLRecertifyLetterRedirect"
            MyBase.Name = "ADLRecertifyLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.ADLRecertifyLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.ADLRecertifyLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.ADLRecertifyLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.ADLRecertifyLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.ADLRecertifyLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.ADLRecertifyLetter.CLM.Carrier)

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
