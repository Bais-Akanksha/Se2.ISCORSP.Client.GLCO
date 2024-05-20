Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIAADL60DayLetter.Processors

#Region " FIAADL60DayLetter "

    Public Class FIAADL60DayLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADL60DayLetter"
            MyBase.Name = "FIAADL60DayLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADL60DayLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADL60DayLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADL60DayLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADL60DayLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADL60DayLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADL60DayLetter.CLM.Carrier)
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

#Region " FIAADL60DayLetter Redirect"

    Public Class FIAADL60DayLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADL60DayLetterRedirect"
            MyBase.Name = "FIAADL60DayLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADL60DayLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADL60DayLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADL60DayLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADL60DayLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADL60DayLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADL60DayLetter.CLM.Carrier)

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
