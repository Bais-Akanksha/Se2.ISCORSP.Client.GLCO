Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.FIAADLStartBenefitLetter.Processors

#Region " FIAADLStartBenefitLetter "

    Public Class FIAADLStartBenefitLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADLStartBenefitLetter"
            MyBase.Name = "FIAADLStartBenefitLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADLStartBenefitLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADLStartBenefitLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADLStartBenefitLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADLStartBenefitLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADLStartBenefitLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADLStartBenefitLetter.CLM.Carrier)
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

#Region " FIAADLStartBenefitLetter Redirect"

    Public Class FIAADLStartBenefitLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.FIAADLStartBenefitLetterRedirect"
            MyBase.Name = "FIAADLStartBenefitLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.FIAADLStartBenefitLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.FIAADLStartBenefitLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.FIAADLStartBenefitLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.FIAADLStartBenefitLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.FIAADLStartBenefitLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.FIAADLStartBenefitLetter.CLM.Carrier)

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
