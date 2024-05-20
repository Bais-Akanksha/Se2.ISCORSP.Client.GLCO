Imports System.IO
Imports Se2.ISI.Base.Processing

Namespace Se2.ISCORSP.Client.GLCO.WaivePremiumLetter.Processors

#Region " WaivePremiumLetter "

    Public Class WaivePremiumLetter
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.WaivePremiumLetter"
            MyBase.Name = "WaivePremiumLetter"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.WaivePremiumLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.WaivePremiumLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.WaivePremiumLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.WaivePremiumLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.WaivePremiumLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.WaivePremiumLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.WaivePremiumLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.WaivePremiumLetter.CLM.PolValue)
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

#Region "WaivePremiumLetterRedirect"

    Public Class WaivePremiumLetterRedirect
        Inherits BaseProcessor

        Private ErrorCount As Integer = 0

        Public Sub New()
            MyBase.New()
            MyBase.InterfaceKey = "ISCORSP.GLCO.WaivePremiumLetterRedirect"
            MyBase.Name = "WaivePremiumLetterRedirect"
            isXMLFile = True
            MyBase.RootNode = "DataServicesLetter"
            Me.[CLM].Add("Policies", New GLCO.WaivePremiumLetter.CLM.Policies)
            Me.[CLM].Add("Policy", New GLCO.WaivePremiumLetter.CLM.Policy)
            Me.[CLM].Add("Roles", New GLCO.WaivePremiumLetter.CLM.Roles)
            Me.[CLM].Add("Role", New GLCO.WaivePremiumLetter.CLM.Role)
            Me.[CLM].Add("CarrierInformation", New GLCO.WaivePremiumLetter.CLM.CarrierInformation)
            Me.[CLM].Add("Carrier", New GLCO.WaivePremiumLetter.CLM.Carrier)
            Me.[CLM].Add("PolValues", New GLCO.WaivePremiumLetter.CLM.PolValues)
            Me.[CLM].Add("PolValue", New GLCO.WaivePremiumLetter.CLM.PolValue)
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
