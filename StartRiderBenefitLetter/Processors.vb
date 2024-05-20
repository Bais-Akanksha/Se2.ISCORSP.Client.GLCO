Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.StartRiderBenefitLetter.Processors

#Region " StartRiderBenefitLetter "

    Public Class StartRiderBenefitLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.StartRiderBenefitLetter"
            MyBase.Name = "StartRiderBenefitLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.StartRiderBenefitLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.StartRiderBenefitLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.StartRiderBenefitLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.StartRiderBenefitLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.StartRiderBenefitLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.StartRiderBenefitLetter.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.StartRiderBenefitLetter.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.StartRiderBenefitLetter.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.StartRiderBenefitLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.StartRiderBenefitLetter.CLM.PolValue)
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

#Region "StartRiderBenefitLetterRedirect"

    Public Class StartRiderBenefitLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.StartRiderBenefitLetterRedirect"
            MyBase.Name = "StartRiderBenefitLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.StartRiderBenefitLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.StartRiderBenefitLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.StartRiderBenefitLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.StartRiderBenefitLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.StartRiderBenefitLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.StartRiderBenefitLetter.CLM.Carrier)
            Me.[CLM].Add("Features", New GLCO.StartRiderBenefitLetter.CLM.Features)
            Me.[CLM].Add("Feature", New GLCO.StartRiderBenefitLetter.CLM.Feature)
            Me.[CLM].Add("PolValues", New GLCO.StartRiderBenefitLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.StartRiderBenefitLetter.CLM.PolValue)
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
