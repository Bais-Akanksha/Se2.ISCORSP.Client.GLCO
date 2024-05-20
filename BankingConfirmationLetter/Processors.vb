Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.BankingConfirmationLetter.Processors

#Region " BankingConfirmationLetter "

    Public Class BankingConfirmationLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.BankingConfirmationLetter"
            MyBase.Name = "BankingConfirmationLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.BankingConfirmationLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.BankingConfirmationLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.BankingConfirmationLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.BankingConfirmationLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.BankingConfirmationLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.BankingConfirmationLetter.CLM.Carrier)
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

#Region " BankingConfirmationLetter Redirect"

    Public Class BankingConfirmationLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.BankingConfirmationLetterRedirect"
            MyBase.Name = "BankingConfirmationLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.BankingConfirmationLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.BankingConfirmationLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.BankingConfirmationLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.BankingConfirmationLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.BankingConfirmationLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.BankingConfirmationLetter.CLM.Carrier)

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
