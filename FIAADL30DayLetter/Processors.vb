Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIAADL30DayLetter.Processors

#Region " FIAADL30DayLetter "

    Public Class FIAADL30DayLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADL30DayLetter"
            MyBase.Name = "FIAADL30DayLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADL30DayLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADL30DayLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADL30DayLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADL30DayLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADL30DayLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADL30DayLetter.CLM.Carrier)
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

#Region " FIAADL30DayLetter Redirect"

    Public Class FIAADL30DayLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADL30DayLetterRedirect"
            MyBase.Name = "FIAADL30DayLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADL30DayLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADL30DayLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADL30DayLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADL30DayLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADL30DayLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADL30DayLetter.CLM.Carrier)

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
