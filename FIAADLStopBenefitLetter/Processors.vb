Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIAADLStopBenefitLetter.Processors

#Region " FIAADLStopBenefitLetter "

    Public Class FIAADLStopBenefitLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADLStopBenefitLetter"
            MyBase.Name = "FIAADLStopBenefitLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADLStopBenefitLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADLStopBenefitLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADLStopBenefitLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADLStopBenefitLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADLStopBenefitLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADLStopBenefitLetter.CLM.Carrier)
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

#Region " FIAADLStopBenefitLetter Redirect"

    Public Class FIAADLStopBenefitLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADLStopBenefitLetterRedirect"
            MyBase.Name = "FIAADLStopBenefitLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADLStopBenefitLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADLStopBenefitLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADLStopBenefitLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADLStopBenefitLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADLStopBenefitLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADLStopBenefitLetter.CLM.Carrier)

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
