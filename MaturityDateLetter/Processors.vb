Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.MaturityDateLetter.Processors

#Region " MaturityDateLetter "

    Public Class MaturityDateLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.MaturityDateLetter"
            MyBase.Name = "MaturityDateLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.MaturityDateLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.MaturityDateLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.MaturityDateLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.MaturityDateLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.MaturityDateLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.MaturityDateLetter.CLM.Carrier)
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

#Region "MaturityDateLetterRedirect"

    Public Class MaturityDateLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.MaturityDateLetterRedirect"
            MyBase.Name = "MaturityDateLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.MaturityDateLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.MaturityDateLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.MaturityDateLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.MaturityDateLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.MaturityDateLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.MaturityDateLetter.CLM.Carrier)
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
